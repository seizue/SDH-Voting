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

        private List<InvestorViewModel> originalInvestorList; 

        public Main()
        {
            InitializeComponent();
      
            LoadData();
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
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
            originalInvestorList = investors.Select(i => new InvestorViewModel
            {
                Id = i.Id,
                Name = i.Name,
                Votes = i.Votes,
                Shares = i.Shares
            }).ToList();

            UpdateDataGridView(originalInvestorList);

            //Custom Row Height of DataGrid
            foreach (DataGridViewRow row in InventoryDataGrid.Rows)
            {
                row.Height = 30;
            }
        }

        private void UpdateDataGridView(List<InvestorViewModel> investors)
        {
            // Clear the existing rows and columns
            InventoryDataGrid.Rows.Clear();
            InventoryDataGrid.Columns.Clear();

            // Add columns without formatting for ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id"
            };
            InventoryDataGrid.Columns.Add(idColumn);

            // Add columns with formatting for Votes and Shares
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name"
            };
            InventoryDataGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn votesColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Votes",
                DataPropertyName = "Votes",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            };
            InventoryDataGrid.Columns.Add(votesColumn);

            DataGridViewTextBoxColumn sharesColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Shares",
                DataPropertyName = "Shares",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            };
            InventoryDataGrid.Columns.Add(sharesColumn);

            // Add rows
            foreach (var investor in investors)
            {
                InventoryDataGrid.Rows.Add(investor.Id, investor.Name, investor.Votes, investor.Shares);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                // Restore to normal size
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // Maximize the form considering the taskbar height
                Rectangle workingArea = Screen.GetWorkingArea(this);
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);

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

                // Ensure the selected row index is within bounds
                if (selectedIndex >= 0 && selectedIndex < originalInvestorList.Count)
                {
                    InvestorViewModel selectedInvestorViewModel = originalInvestorList[selectedIndex];

                    // Ensure selectedInvestorViewModel is not null
                    if (selectedInvestorViewModel != null)
                    {
                        // Find the corresponding Investor object
                        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "InvestorMasterlist.json");

                        if (File.Exists(filePath))
                        {
                            string json = File.ReadAllText(filePath);
                            List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json);

                            // Ensure investors is not null and contains data
                            if (investors != null)
                            {
                                Investor selectedInvestor = investors.Find(i => i.Name == selectedInvestorViewModel.Name);

                                if (selectedInvestor != null)
                                {
                                    UpdateForm updateForm = new UpdateForm(selectedInvestor);
                                    updateForm.ShowDialog();
                                    LoadData(); // Refresh the data grid after closing the update form
                                }
                                else
                                {
                                    MessageBox.Show("Selected investor not found in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error loading investor data from file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Investor data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row does not contain valid data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = InventoryDataGrid.SelectedRows[0].Index;

                // Ensure the selected row index is within bounds
                if (selectedIndex >= 0 && selectedIndex < originalInvestorList.Count)
                {
                    InvestorViewModel selectedInvestorViewModel = originalInvestorList[selectedIndex];

                    // Find the corresponding Investor object
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "InvestorMasterlist.json");

                    if (File.Exists(filePath))
                    {
                        string json = File.ReadAllText(filePath);
                        List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json);

                        // Ensure investors is not null and contains data
                        if (investors != null)
                        {
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
                            else
                            {
                                MessageBox.Show("Selected investor not found in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error loading investor data from file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Investor data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected row index is out of bounds.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim().ToLower();

            // Check if the search text is empty
            if (string.IsNullOrEmpty(searchText))
            {
                // If the search text is empty, load all data
                UpdateDataGridView(originalInvestorList);
                return;
            }

            // Filter the data based on the search text
            var filteredData = originalInvestorList
                                .Where(investor =>
                                    investor.Id.ToLower().Contains(searchText) ||
                                    investor.Name.ToLower().Contains(searchText) ||
                                    investor.Votes.ToString().Contains(searchText))
                                .ToList();

            // Update the DataGridView with the filtered data
            UpdateDataGridView(filteredData);
        }


        private void txtBoxSearch_ButtonClick(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim().ToLower();

            // Filter the data based on the search text and selected checkboxes
            var filteredData = originalInvestorList.Where(investor =>
                (checkBoxId.Checked && investor.Id.ToLower().Contains(searchText)) ||
                (checkBoxName.Checked && investor.Name.ToLower().Contains(searchText)) ||
                (checkBoxVotes.Checked && investor.Votes.ToString().Contains(searchText))
            ).ToList();

            // Update the DataGridView with the filtered data
            UpdateDataGridView(filteredData);
        }


        private void btnInvMasterlist_Click(object sender, EventArgs e)
        {
            userControlVoting1.Visible = false;
        }
    

        private void btnVoting_Click(object sender, EventArgs e)
        {
            userControlVoting1.Visible = true;
        }
    }


    public class Investor
    {
        public String Id { get; set; } 
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
    }

    public class InvestorViewModel
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
    }

    public class Representative
    {
        public string Name { get; set; }
    }


}
