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
            LoadRepresentatives(); 
        }

        private void btn_UpdateRep_Click(object sender, EventArgs e)
        {
            if (dataGridViewRepresentative.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewRepresentative.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < dataGridViewRepresentative.Rows.Count)
                {
                    string representativeName = dataGridViewRepresentative.Rows[selectedIndex].Cells["Representative"].Value.ToString();

                    UpdateRepForm updateRepForm = new UpdateRepForm(representativeName);
                    if (updateRepForm.ShowDialog() == DialogResult.OK)
                    {
                        // Save the updated representative data
                        string updatedName = updateRepForm.RepName;

                        // Load the existing representatives from the JSON file
                        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                        string filePath = Path.Combine(folderPath, "SDHRep.json");
                        List<Representative> representatives = new List<Representative>();

                        if (File.Exists(filePath))
                        {
                            string json = File.ReadAllText(filePath);
                            representatives = JsonConvert.DeserializeObject<List<Representative>>(json) ?? new List<Representative>();
                        }

                        // Find and update the representative in the list
                        Representative representativeToUpdate = representatives.FirstOrDefault(r => r.Name == representativeName);
                        if (representativeToUpdate != null)
                        {
                            representativeToUpdate.Name = updatedName;

                            // Save the updated list to the JSON file
                            string updatedJson = JsonConvert.SerializeObject(representatives, Formatting.Indented);
                            File.WriteAllText(filePath, updatedJson);

                            // Refresh the DataGridView
                            LoadRepresentatives();
                            MessageBox.Show("Representative updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Representative not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadRepresentatives(); // Reload the representatives after adding a new one
        }

        private void LoadRepresentatives()
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
                else
                {
                    MessageBox.Show("SDHRep.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Clear the existing rows before populating
                dataGridViewRepresentative.Rows.Clear();

                // Add representatives to the DataGridView
                foreach (var rep in representatives)
                {
                    int id = dataGridViewRepresentative.Rows.Add(); // Auto-generated ID
                    dataGridViewRepresentative.Rows[id].Cells["Representative"].Value = rep.Name; // Load Name into Representative column
                    dataGridViewRepresentative.Rows[id].Cells["TotalVotes"].Value = rep.Votes; // Load Votes into TotalVotes column
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

        }

        private void btnExpandGrid_Click(object sender, EventArgs e)
        {

        }
    }
  
}

