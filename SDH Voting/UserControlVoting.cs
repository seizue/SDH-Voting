using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SDH_Voting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class UserControlVoting : UserControl
    {
        private string sdhStockHolder;
        private List<VoteSelectedData> SDH_VoteSelected = new List<VoteSelectedData>();

        public UserControlVoting()
        {
            InitializeComponent();
            ReloadData();
            UpdateButtonStates();
            SetupDataGridViewColumns();
            dataGridViewRepresentative.DataError += DataGridViewRepresentative_DataError;

            // Load font size from settings
            if (Properties.Settings.Default.DataGridViewFontSize > 0)
            {
                SetDataGridViewFontSize(Properties.Settings.Default.DataGridViewFontSize);
            }
        }

        private void btn_VoidRep_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewRepresentative.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridViewRepresentative.SelectedRows[0].Index;

                // Ensure the selected row index is within bounds
                if (selectedIndex >= 0 && selectedIndex < dataGridViewRepresentative.Rows.Count)
                {
                    // Confirm the deletion with the user
                    DialogResult result = MessageBox.Show("Are you sure you want to void this representative?", "Confirm Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Get the representative name from the selected row
                            string representativeName = dataGridViewRepresentative.Rows[selectedIndex].Cells["Representative"].Value.ToString();

                            // Remove the selected row from the DataGridView
                            dataGridViewRepresentative.Rows.RemoveAt(selectedIndex);

                            // Load the existing representatives from the JSON file
                            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                            string filePath = Path.Combine(folderPath, "SDHRep.json");

                            if (File.Exists(filePath))
                            {
                                // Read all lines from the file
                                string[] jsonLines = File.ReadAllLines(filePath);

                                // Create a list to hold the updated JSON lines
                                List<string> updatedJsonLines = new List<string>();

                                foreach (var line in jsonLines)
                                {
                                    // Deserialize each line into a JObject
                                    JObject jsonRep = JObject.Parse(line);

                                    // Check if the representative's name matches the one to be removed
                                    if (jsonRep["Name"].ToString() != representativeName)
                                    {
                                        // Add the line back to the updated list
                                        updatedJsonLines.Add(line);
                                    }
                                }

                                // Write the updated JSON lines back to the file
                                File.WriteAllLines(filePath, updatedJsonLines);

                                MessageBox.Show("Representative voided successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Reload the representatives in DataGridView
                                LoadRepresentatives();
                            }
                            else
                            {
                                MessageBox.Show("SDHRep.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while voiding representative: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selected row index is out of bounds.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to void.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_AddRepresentative_Click(object sender, EventArgs e)
        {
            // Get the list of existing representatives
            List<string> existingRepresentatives = new List<string>();
            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                if (row.Cells["Representative"].Value != null)
                {
                    existingRepresentatives.Add(row.Cells["Representative"].Value.ToString());
                }
            }

            // Pass the existing representatives to AddRepForm
            AddRepForm addRepForm = new AddRepForm(existingRepresentatives);
            addRepForm.ShowDialog();
            LoadRepresentatives();
            AddViewButtonColumn();
            UpdateButtonStates();
        }

        public void LoadRepresentatives()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");

            try
            {
                List<Representative> representatives = new List<Representative>();

                if (File.Exists(filePath))
                {
                    string[] jsonLines = File.ReadAllLines(filePath);

                    foreach (var line in jsonLines)
                    {
                        Representative rep = JsonConvert.DeserializeObject<Representative>(line);
                        if (rep != null)
                        {
                            representatives.Add(rep);
                        }
                    }
                }

                // Calculate the total votes
                int totalVotes = representatives.Sum(rep => rep.Votes);

                // Clear existing rows
                dataGridViewRepresentative.Rows.Clear();

                // Add representatives to the DataGridView
                if (representatives.Count > 0)
                {
                    foreach (var rep in representatives)
                    {
                        int id = dataGridViewRepresentative.Rows.Add();
                        dataGridViewRepresentative.Rows[id].Cells["ID"].Value = id + 1;
                        dataGridViewRepresentative.Rows[id].Cells["Representative"].Value = rep.Name;
                        dataGridViewRepresentative.Rows[id].Cells["TotalVotes"].Value = FormatNumber(rep.Votes);

                        // Calculate progress based on active cells
                        int activeCellsCount = CountActiveCells(id);
                        if (activeCellsCount == 1)
                        {
                            // Set progress to 100% if only one active cell
                            dataGridViewRepresentative.Rows[id].Cells["Progress"].Value = 100;
                        }
                        else
                        {
                            // Calculate progress based on TotalVotes
                            int progressValue = totalVotes > 0 ? (int)(((double)rep.Votes / totalVotes) * 100) : 0;
                            dataGridViewRepresentative.Rows[id].Cells["Progress"].Value = progressValue;
                        }
                    }
                }

                // Set row heights
                foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
                {
                    row.Height = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading representatives: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateButtonStates();
        }


        private int CountActiveCells(int rowIndex)
        {
            int activeCells = 0;
            foreach (DataGridViewCell cell in dataGridViewRepresentative.Rows[rowIndex].Cells)
            {
                if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    activeCells++;
                }
            }
            return activeCells;
        }

        private string FormatNumber(int number)
        {
            return number.ToString("#,##0");
        }

        private void LoadSHSelected()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDH_VoteSelected.json");

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    JArray voteData = JArray.Parse(json);

                    // Dictionary to store representative and unique stockholders who voted for them
                    var representativeData = new Dictionary<string, HashSet<string>>();

                    foreach (JObject vote in voteData)
                    {
                        string representativeName = vote["Representative"].ToString();
                        string stockHolder = vote["StockHolder"].ToString();

                        if (representativeData.ContainsKey(representativeName))
                        {
                            representativeData[representativeName].Add(stockHolder); // Add stockholder if not already added
                        }
                        else
                        {
                            var stockHolders = new HashSet<string>();
                            stockHolders.Add(stockHolder);
                            representativeData.Add(representativeName, stockHolders);
                        }
                    }

                    // Update No_PV column with count of unique stockholders who voted for each representative
                    foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
                    {
                        string representativeName = row.Cells["Representative"].Value.ToString();
                        if (representativeData.ContainsKey(representativeName))
                        {
                            row.Cells["No_PV"].Value = representativeData[representativeName].Count;
                        }
                        else
                        {
                            row.Cells["No_PV"].Value = 0; // Default to 0 if no votes found for this representative
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from SDH_VoteSelected.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRepresentative_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Exclude "View" column from showing "-"
            if (dataGridViewRepresentative.Columns[e.ColumnIndex].Name == "View")
            {
                return;
            }

            // Check if the cell value is null, empty, or whitespace
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "-";
                e.FormattingApplied = true;
            }
            else if (e.Value is int && (int)e.Value == 0)
            {
                e.Value = "-";
                e.FormattingApplied = true;
            }
        }

        private void SetupDataGridViewColumns()
        {
            // Find the existing "Progress" column
            DataGridViewColumn existingProgressColumn = dataGridViewRepresentative.Columns["Progress"];

            if (existingProgressColumn is DataGridViewProgressColumn)
            {
                // Set the CellTemplate for existing DataGridViewProgressColumn
                (existingProgressColumn as DataGridViewProgressColumn).CellTemplate = new DataGridViewProgressCell();
            }
        }

        public class DataGridViewProgressColumn : DataGridViewTextBoxColumn
        {
            public DataGridViewProgressColumn() : base()
            {
                CellTemplate = new DataGridViewProgressCell();
            }
        }

        public class DataGridViewProgressCell : DataGridViewTextBoxCell
        {
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

                if (value != null && value is int)
                {
                    int progressVal = (int)value;

                    // Calculate progress bar percentage
                    float percentage = progressVal / 100.0f;

                    // Determine the width of the progress bar
                    int progressBarWidth = (int)(cellBounds.Width * percentage);

                    // Draw the progress bar
                    Brush brush = new SolidBrush(Color.FromArgb(0, 122, 204)); // Choose your progress bar color
                    graphics.FillRectangle(brush, cellBounds.X + 2, cellBounds.Y + 2, progressBarWidth, cellBounds.Height - 4);
                }
            }
        }


        private void DataGridViewRepresentative_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Error in DataGridView: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Optionally handle the error or provide user feedback
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            SDHVoForm votersForm = new SDHVoForm(sdhStockHolder, this);
            votersForm.ShowDialog();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            // Check if there is data in the DataGridView
            if (dataGridViewRepresentative.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Initialize a StringBuilder to store CSV content
            StringBuilder csvContent = new StringBuilder();

            // Write the header row, excluding the "View" column
            foreach (DataGridViewColumn column in dataGridViewRepresentative.Columns)
            {
                if (column.Name != "View")
                {
                    csvContent.Append(column.HeaderText + ",");
                }
            }
            csvContent.AppendLine();

            // Write the data rows, excluding the "View" column
            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name != "View")
                    {
                        if (cell.Value != null)
                        {
                            csvContent.Append(cell.Value.ToString() + ",");
                        }
                        else
                        {
                            csvContent.Append(",");
                        }
                    }
                }
                csvContent.AppendLine();
            }

            // Generate file name with current date
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = $"SDH_Representatives_{currentDate}.csv";

            // Prompt the user to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Export CSV File";
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Write the CSV content to the file
                File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                MessageBox.Show("Data exported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            ReloadData();
            MessageBox.Show("Refresh successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ReloadData()
        {
            LoadRepresentatives();
            LoadSHSelected();
            CustomCellHeight();
        }

        private void btnExpandGrid_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelUserGrid.Dock = DockStyle.Fill;
            dataGridViewRepresentative.Dock = DockStyle.Fill;

            Main mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                mainForm.ShowCloseButton();
            }
        }

        public void RestorGridView()
        {
            panelMenu.Visible = true;
        }

        private void UserControlVoting_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void AddViewButtonColumn()
        {
            // Clear existing button columns (if any)
            dataGridViewRepresentative.Columns.Remove("View");

            // Add a new DataGridViewButtonColumn for viewing voters
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "View";
            viewButtonColumn.HeaderText = "View Voters";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            dataGridViewRepresentative.Columns.Add(viewButtonColumn);
        }

        private void dataGridViewRepresentative_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the click is on the View Voters button column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewRepresentative.Columns["View"].Index)
            {
                // Get the representative name from the clicked row
                string representativeName = dataGridViewRepresentative.Rows[e.RowIndex].Cells["Representative"].Value.ToString();

                // Show the ViewVotersForm with the selected representative's voters
                ShowViewVotersForm(representativeName);
            }
        }

        private void ShowViewVotersForm(string representativeName)
        {
            try
            {
                // Instantiate ViewVotersForm with the selected representative's name
                ViewVotersForm viewVotersForm = new ViewVotersForm(representativeName);
                viewVotersForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing voters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CustomCellHeight()
        {
            // Default row height
            int defaultHeight = 30;

            // Limit row height to maximum of 80 pixels
            int maxHeight = 80;

            // Set custom row height for existing rows, ensuring it doesn't exceed maxHeight
            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                row.Height = Math.Min(row.Height, maxHeight);
            }
        }


        public void SetDataGridViewRowHeight(int rowHeight)
        {
          
            // Limit row height to maximum of 80 pixels
            int maxHeight = 80;
            int actualHeight = Math.Min(rowHeight, maxHeight);

            // Set row height for DataGridView template
            dataGridViewRepresentative.RowTemplate.Height = actualHeight;
            dataGridViewRepresentative.DefaultCellStyle.Font = new Font(dataGridViewRepresentative.DefaultCellStyle.Font.FontFamily, actualHeight);

            // Apply custom heights to existing rows
            CustomCellHeight();
        }


        private void btnPosted_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the "Posted" folder exists
                string postedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "Posted");
                if (!Directory.Exists(postedFolderPath))
                {
                    Directory.CreateDirectory(postedFolderPath);
                }

                // Create a folder with current date inside "Posted" folder
                string currentDateFolderName = DateTime.Now.ToString("yyyy-MM-dd");
                string currentDateFolderPath = Path.Combine(postedFolderPath, currentDateFolderName);
                if (!Directory.Exists(currentDateFolderPath))
                {
                    Directory.CreateDirectory(currentDateFolderPath);
                }

                // Save representative data inside the dated folder
                SaveRepresentativeData(currentDateFolderPath);

                // Save SDH_VoteSelected.json inside the dated folder
                string sdhVoteSelectedFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "SDH_VoteSelected.json");
                string destinationFilePath = Path.Combine(currentDateFolderPath, "SDH_VoteSelected.json");
                File.Copy(sdhVoteSelectedFilePath, destinationFilePath, true);

                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveRepresentativeData(string folderPath)
        {
            try
            {
                List<object> representativeData = new List<object>();

                foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string representativeName = Convert.ToString(row.Cells["Representative"].Value);

                        // Validate and convert TotalVotes
                        int totalVotes;
                        if (row.Cells["TotalVotes"].Value != null && int.TryParse(row.Cells["TotalVotes"].Value.ToString().Replace(",", ""), out totalVotes))
                        {
                            // Successfully parsed to int
                        }
                        else
                        {
                            totalVotes = 0; // Default to 0 or handle differently based on your logic
                        }

                        // Validate and convert No_PV
                        int pv;
                        if (row.Cells["No_PV"].Value != null && int.TryParse(row.Cells["No_PV"].Value.ToString(), out pv))
                        {
                            // Successfully parsed to int
                        }
                        else
                        {
                            pv = 0; // Default to 0 or handle differently based on your logic
                        }

                        var data = new
                        {
                            Representative = representativeName,
                            TotalVotes = totalVotes,
                            No_PV = pv
                        };

                        representativeData.Add(data);
                    }
                }

                string json = JsonConvert.SerializeObject(representativeData, Formatting.Indented);
                string filePath = Path.Combine(folderPath, "representative_result.json");
                File.WriteAllText(filePath, json);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving representative data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetDataGridViewFontSize(float fontSize)
        {
            // Set font size for DefaultCellStyle
            dataGridViewRepresentative.DefaultCellStyle.Font = new Font(dataGridViewRepresentative.DefaultCellStyle.Font.FontFamily, fontSize);

            // Set font size for AlternatingRowsDefaultCellStyle
            dataGridViewRepresentative.AlternatingRowsDefaultCellStyle.Font = new Font(dataGridViewRepresentative.AlternatingRowsDefaultCellStyle.Font.FontFamily, fontSize);

            // Set font size for RowsDefaultCellStyle
            dataGridViewRepresentative.RowsDefaultCellStyle.Font = new Font(dataGridViewRepresentative.RowsDefaultCellStyle.Font.FontFamily, fontSize);
        }


        private void UpdateButtonStates()
        {
            bool hasData = dataGridViewRepresentative.Rows.Count > 0;

            btnVote.Enabled = hasData;
            btnChart.Enabled = hasData;
            btn_VoidRep.Enabled = hasData;
            btnPosted.Enabled = hasData;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.ShowDialog();
        }
    }
}

