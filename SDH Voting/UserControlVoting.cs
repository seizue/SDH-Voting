﻿using Newtonsoft.Json;
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
        private int _selectedRowIndex = -1;
        
        public UserControlVoting()
        {
            InitializeComponent();
            ReloadData();
            UpdateButtonStates();
            SetupDataGridViewColumns();
   
            dataGridViewRepresentative.DataError += DataGridViewRepresentative_DataError;
            dataGridViewRepresentative.MouseDown += dataGridViewRepresentative_MouseDown;

            // Load font size from settings
            if (Properties.Settings.Default.DataGridViewFontSize > 0)
            {
                SetDataGridViewFontSize(Properties.Settings.Default.DataGridViewFontSize);
            }

            // Load row height from settings
            if (Properties.Settings.Default.DataGridViewRowHeight > 0)
            {
                SetDataGridViewRowHeight(Properties.Settings.Default.DataGridViewRowHeight);
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

            CustomCellHeight();
            UpdateButtonStates();
            LoadSHSelected();
            UpdateRepresentativeSummary();
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

                    // Dictionary to store representative and total votes (including duplicates)
                    var representativeVoteCount = new Dictionary<string, int>();

                    foreach (JObject vote in voteData)
                    {
                        string representativeName = vote["Representative"].ToString();

                        if (representativeVoteCount.ContainsKey(representativeName))
                        {
                            representativeVoteCount[representativeName]++;
                        }
                        else
                        {
                            representativeVoteCount[representativeName] = 1;
                        }
                    }

                    // Update No_PV column with total votes for each representative
                    foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
                    {
                        string representativeName = row.Cells["Representative"].Value.ToString();
                        if (representativeVoteCount.ContainsKey(representativeName))
                        {
                            row.Cells["No_PV"].Value = representativeVoteCount[representativeName];
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

            UpdateRepresentativeSummary();
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
                // Paint the cell background and borders only
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, null, null, errorText, cellStyle, advancedBorderStyle, paintParts & ~(DataGridViewPaintParts.ContentForeground));

                if (value != null && value is int)
                {
                    int progressVal = (int)value;
                    float percentage = progressVal / 100.0f;
                    int progressBarWidth = (int)(cellBounds.Width * percentage);

                    // Draw the progress bar
                    using (Brush brush = new SolidBrush(Color.FromArgb(0, 122, 204)))
                    {
                        graphics.FillRectangle(brush, cellBounds.X + 2, cellBounds.Y + 2, progressBarWidth, cellBounds.Height - 4);
                    }
                }
            }
        }


        private void DataGridViewRepresentative_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Error in DataGridView: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
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

 
            // Sort by TotalVotes descending (largest at top) AFTER all data is loaded
            if (dataGridViewRepresentative.Columns["TotalVotes"] != null && dataGridViewRepresentative.Rows.Count > 0)
            {
                dataGridViewRepresentative.Sort(
                    dataGridViewRepresentative.Columns["TotalVotes"],
                    ListSortDirection.Descending
                );
            }
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
            // Use the current row height from RowTemplate
            int currentHeight = dataGridViewRepresentative.RowTemplate.Height;

            // Apply the height to all rows
            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                row.Height = currentHeight;
            }
        }



        public void SetDataGridViewRowHeight(int rowHeight)
        {
            // Limit row height to maximum of 80 pixels
            int maxHeight = 80;
            int actualHeight = Math.Min(rowHeight, maxHeight);

            // Set row height for DataGridView template
            dataGridViewRepresentative.RowTemplate.Height = actualHeight;

            // Apply the height to all existing rows
            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                row.Height = actualHeight;
            }

            // Update font size based on row height (optional)
            dataGridViewRepresentative.DefaultCellStyle.Font = new Font(dataGridViewRepresentative.DefaultCellStyle.Font.FontFamily, actualHeight / 2f);
        }



        private void btnPosted_Click(object sender, EventArgs e)
        {
            try
            {
                // Ask for confirmation before proceeding
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to post and save the current data?",
                    "Confirm Posting",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult != DialogResult.Yes)
                    return;

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

                // Save summary data from Main form
                SaveSummaryDataFromMain(currentDateFolderPath);

                // Clear the DataGridView after successful posting
                dataGridViewRepresentative.Rows.Clear();

                Main mainForm = this.FindForm() as Main;
                if (mainForm != null)
                {
                    mainForm.UpdateVotes();
                }


                MessageBox.Show("Data posted and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveSummaryDataFromMain(string folderPath)
        {
            try
            {
                // Get the parent form and cast to Main
                Main mainForm = this.FindForm() as Main;
                if (mainForm == null)
                    return;

                var summary = mainForm.GetSummaryTextBoxValues();

                var summaryObj = new
                {
                    TotalShares = summary.TotalShares,
                    TotalShareholders = summary.TotalShareholders,
                    RegisterShares = summary.RegisterShares,
                    RegisteredShareholders = summary.RegisteredShareholders
                };

                string json = JsonConvert.SerializeObject(summaryObj, Formatting.Indented);
                string filePath = Path.Combine(folderPath, "summary_result.json");
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving summary data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
               
        }

        private void dataGridViewRepresentative_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewRepresentative.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    _selectedRowIndex = hit.RowIndex;
                    dataGridViewRepresentative.ClearSelection();
                    dataGridViewRepresentative.Rows[_selectedRowIndex].Selected = true;
                    dataGridViewRepresentative.CurrentCell = dataGridViewRepresentative.Rows[_selectedRowIndex].Cells[hit.ColumnIndex];
                }
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndex >= 0)
            {
                // Safely get the "Representative" cell value
                var cellValue = dataGridViewRepresentative.Rows[_selectedRowIndex].Cells["Representative"].Value;
                if (cellValue != null)
                {
                    string representativeName = cellValue.ToString();
                    ShowViewVotersForm(representativeName);
                }
            }
        }

        private void UpdateRepresentativeSummary()
        {
            int totalVotes = 0;
            int peopleVoted = 0;

            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                if (row.IsNewRow)
                    continue;

                // Sum TotalVotes column
                var cellValue = row.Cells["TotalVotes"].Value;
                int votes = 0;
                if (cellValue != null && int.TryParse(cellValue.ToString().Replace(",", ""), out votes))
                {
                    totalVotes += votes;
                }

                // Sum No_PV column (do NOT add representatives)
                var noPvValue = row.Cells["No_PV"].Value;
                int noPv = 0;
                if (noPvValue != null && int.TryParse(noPvValue.ToString(), out noPv))
                {
                    peopleVoted += noPv;
                }
            }

            txtboxTotalVotes.Text = totalVotes.ToString("N0");
            textBoxPeopleVoted.Text = peopleVoted.ToString("N0");
        }
    }
}

