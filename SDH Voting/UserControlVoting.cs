using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SDH_Voting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class UserControlVoting : UserControl
    {
        private string sdhStockHolder;

        public UserControlVoting()
        {
            InitializeComponent();
            ReloadData();
        }

        private void btn_UpdateRep_Click(object sender, EventArgs e)
        {
            // Load the existing representatives from the JSON file
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");

            if (File.Exists(filePath))
            {
                try
                {
                    // Read all text from the JSON file
                    string json = File.ReadAllText(filePath);

                    // Deserialize JSON as a single Representative object
                    Representative representative = JsonConvert.DeserializeObject<Representative>(json);

                    if (representative != null)
                    {
                        // Open the UpdateRepForm for editing
                        UpdateRepForm updateRepForm = new UpdateRepForm(representative.Name);
                        if (updateRepForm.ShowDialog() == DialogResult.OK)
                        {
                            // Update the representative's name
                            representative.Name = updateRepForm.RepName;

                            // Serialize the updated representative back to JSON with unchanged format
                            string updatedJson = JsonConvert.SerializeObject(representative);

                            // Write the updated JSON back to the file
                            File.WriteAllText(filePath, updatedJson);

                            // Refresh the DataGridView or perform any necessary actions
                            LoadRepresentatives();
                            MessageBox.Show("Representative updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to deserialize JSON into Representative object.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating representative: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("SDHRep.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            AddRepForm addRepForm = new AddRepForm();
            addRepForm.ShowDialog();
            LoadRepresentatives();
            AddViewButtonColumn();
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
                    // Read all lines from the file
                    string[] jsonLines = File.ReadAllLines(filePath);

                    foreach (var line in jsonLines)
                    {
                        // Deserialize each line into a Representative object
                        Representative rep = JsonConvert.DeserializeObject<Representative>(line);
                        if (rep != null)
                        {
                            representatives.Add(rep);
                        }
                    }
                }

                // Clear the existing rows before populating
                dataGridViewRepresentative.Rows.Clear();

                // Add representatives to the DataGridView if there are any
                if (representatives.Count > 0)
                {
                    for (int i = 0; i < representatives.Count; i++)
                    {
                        int id = dataGridViewRepresentative.Rows.Add(); // Auto-generated ID
                        dataGridViewRepresentative.Rows[id].Cells["ID"].Value = i + 1; // Set the autogenerated ID
                        dataGridViewRepresentative.Rows[id].Cells["Representative"].Value = representatives[i].Name; // Load Name into Representative column
                        dataGridViewRepresentative.Rows[id].Cells["TotalVotes"].Value = representatives[i].Votes; // Load Votes into TotalVotes column
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
                else
                {
                    MessageBox.Show("SDH_VoteSelected.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "-";
                e.FormattingApplied = true;
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            SDHVoForm votersForm = new SDHVoForm(sdhStockHolder);
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
        }

        public void ReloadData()
        {
            LoadRepresentatives();
            LoadSHSelected();

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
    }
}

