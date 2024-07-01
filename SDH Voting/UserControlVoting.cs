using Newtonsoft.Json;
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

            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                row.Height = 30;
            }
        }

        private void btn_UpdateRep_Click(object sender, EventArgs e)
        {
            UpdateRepForm updateRepForm = new UpdateRepForm();
            updateRepForm.ShowDialog();
        }

        private void btn_VoidRep_Click(object sender, EventArgs e)
        {

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
            List<Representative> representatives = new List<Representative>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                representatives = JsonConvert.DeserializeObject<List<Representative>>(json) ?? new List<Representative>();
            }

            // Clear the existing rows
            dataGridViewRepresentative.Rows.Clear();

            // Auto-generate IDs and add representatives to the DataGridView
            for (int i = 0; i < representatives.Count; i++)
            {
                int id = i + 1; // Auto-generate ID starting from 1
                dataGridViewRepresentative.Rows.Add(id, representatives[i].Name, "", "", ""); // Add representative name to the correct column
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

