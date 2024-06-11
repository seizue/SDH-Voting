using Newtonsoft.Json;
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
    public partial class Main : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
            List<Investor> investors = new List<Investor>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();
                }
            }

            // Project to view model
            var investorViewModels = investors.Select(i => new InvestorViewModel
            {
                Name = i.Name,
                Votes = i.Votes
            }).ToList();

            InventoryDataGrid.DataSource = new BindingList<InvestorViewModel>(investorViewModels);
        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panelNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panelNav_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button_AddNewUser_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
            LoadData();
        }

        private void button_UpdateUser_Click(object sender, EventArgs e)
        {
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = InventoryDataGrid.SelectedRows[0].Index;
                InvestorViewModel selectedInvestorViewModel = (InvestorViewModel)InventoryDataGrid.Rows[selectedIndex].DataBoundItem;

                // Find the corresponding Investor object
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "InvestorMasterlist.json");
                List<Investor> investors = new List<Investor>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json);
                }

                Investor selectedInvestor = investors.Find(i => i.Name == selectedInvestorViewModel.Name);

                if (selectedInvestor != null)
                {
                    UpdateForm updateForm = new UpdateForm(selectedInvestor);
                    updateForm.ShowDialog();
                    LoadData(); // Refresh the data grid after closing the update form
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = InventoryDataGrid.SelectedRows[0].Index;

                // Get the selected InvestorViewModel
                InvestorViewModel selectedInvestorViewModel = (InvestorViewModel)InventoryDataGrid.Rows[selectedIndex].DataBoundItem;

                // Find the corresponding Investor object
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "InvestorMasterlist.json");
                List<Investor> investors = new List<Investor>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json);
                }

                Investor selectedInvestor = investors.Find(i => i.Name == selectedInvestorViewModel.Name);

                if (selectedInvestor != null)
                {
                    // Remove the selected investor from the list
                    investors.Remove(selectedInvestor);

                    // Save the updated list to JSON file
                    string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                    File.WriteAllText(filePath, updatedJson);

                    // Refresh the DataGridView
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            // Check if there is data in the DataGridView
            if (InventoryDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Initialize a StringBuilder to store CSV content
            StringBuilder csvContent = new StringBuilder();

            // Write the header row
            DataGridViewRow headerRow = InventoryDataGrid.Rows[0];
            foreach (DataGridViewCell headerCell in headerRow.Cells)
            {
                csvContent.Append(headerCell.OwningColumn.HeaderText + ",");
            }
            csvContent.AppendLine();

            // Write the data rows
            foreach (DataGridViewRow dataRow in InventoryDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in dataRow.Cells)
                {
                    csvContent.Append(cell.Value + ",");
                }
                csvContent.AppendLine();
            }

            // Generate file name with current date
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = $"SDH_Voting_{currentDate}.csv";

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

    }

    public class Investor
    {
        public int Id { get; set; } // Unique ID
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
    }

    public class InvestorViewModel
    {
        public string Name { get; set; }
        public int Votes { get; set; }
    }
}
