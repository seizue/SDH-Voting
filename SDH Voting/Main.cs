using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;


namespace SDH_Voting
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {   
        private List<InvestorViewModel> originalInvestorList;
        private List<VoteSelectedData> SDH_VoteSelected = new List<VoteSelectedData>();
        private string sdhStockHolder;
        public Main()
        {
            InitializeComponent();
            InitializeApplicationData();
            LoadData();
            UpdateButtonStates();
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            checkBoxVoted.CheckedChanged += checkBoxVoted_CheckedChanged;
            checkBoxNonVoted.CheckedChanged += checkBoxNonVoted_CheckedChanged;
            this.Resize += Main_Resize;
  
            // Set the initial window state based on the saved value
            string savedWindowState = Properties.Settings.Default.MainFormWindowState;
            if (!string.IsNullOrEmpty(savedWindowState) && Enum.IsDefined(typeof(FormWindowState), savedWindowState))
            {
                // Parse the saved value and set the window state
                 this.WindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), savedWindowState);
            }
        }

        private void InitializeApplicationData()
        {
            try
            {
                string appDataRoamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string folderPath = Path.Combine(appDataRoamingFolder, "SDH Voting");

                Debug.WriteLine($"Application Data Roaming Folder: {appDataRoamingFolder}");
                Debug.WriteLine($"Target Folder Path: {folderPath}");

                // Create the folder if it does not exist
                if (!Directory.Exists(folderPath))
                {
                    try
                    {
                        Directory.CreateDirectory(folderPath);
                        Debug.WriteLine($"Created folder: {folderPath}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error creating folder: {ex.Message}");
                        MessageBox.Show($"Error creating folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method if folder creation fails
                    }
                }
                else
                {
                    Debug.WriteLine($"Folder already exists: {folderPath}");
                }

                // Check if InvestorMasterlist.json exists, create if not
                string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
                if (!File.Exists(filePath))
                {
                    try
                    {
                        File.WriteAllText(filePath, "[]"); // Initialize with an empty array if file doesn't exist
                        Debug.WriteLine($"Created file: {filePath}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error creating InvestorMasterlist.json: {ex.Message}");
                        MessageBox.Show($"Error creating InvestorMasterlist.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method if file creation fails
                    }
                }

                // Check if SDHRep.json exists, create if not
                string sdhRepFilePath = Path.Combine(folderPath, "SDHRep.json");
                if (!File.Exists(sdhRepFilePath))
                {
                    try
                    {
                        // Create an empty file (without any content)
                        using (FileStream fs = File.Create(sdhRepFilePath))
                        {
                            Debug.WriteLine($"Created empty file: {sdhRepFilePath}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error creating SDHRep.json: {ex.Message}");
                        MessageBox.Show($"Error creating SDHRep.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method if file creation fails
                    }
                }
                else
                {
                    // If the file exists but is not empty, handle it if necessary
                    string jsonContent = File.ReadAllText(sdhRepFilePath);
                    if (jsonContent.Trim() != "")
                    {
                        // Handle the case where the file is not empty as needed
                        Debug.WriteLine($"SDHRep.json exists and is not empty. Content: {jsonContent}");
                    }
                }

                // Check if SDH_VoteSelected.json exists, create if not
                string voteSelectedFilePath = Path.Combine(folderPath, "SDH_VoteSelected.json");
                if (!File.Exists(voteSelectedFilePath))
                {
                    try
                    {
                        File.WriteAllText(voteSelectedFilePath, "[]"); // Initialize with an empty array if file doesn't exist
                        Debug.WriteLine($"Created file: {voteSelectedFilePath}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error creating SDH_VoteSelected.json: {ex.Message}");
                        MessageBox.Show($"Error creating SDH_VoteSelected.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit method if file creation fails
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in InitializeApplicationData(): {ex.Message}");
                MessageBox.Show($"An error occurred while initializing application data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.MaximizedBounds = new Rectangle(workingArea.X, workingArea.Y, workingArea.Width, workingArea.Height);
            }
        }

        public void LoadData()
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
                Shares = i.Shares,
                Status = i.Status,
            }).ToList();

            UpdateDataGridView(originalInvestorList);

            //Custom Row Height of DataGrid
            foreach (DataGridViewRow row in InventoryDataGrid.Rows)
            {
                row.Height = 30;
            }

            ApplyFilters();
        }

        private void SaveDataToSHList()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
            string shListFilePath = Path.Combine(folderPath, "SDH_SHList.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                // Serialize and save to SDH_SHList.json
                string shListJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                File.WriteAllText(shListFilePath, shListJson);
            }
            else
            {
                MessageBox.Show("InvestorMasterlist.json file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "Id",
                FillWeight = 15,
            };
            InventoryDataGrid.Columns.Add(idColumn);

            // Add columns with formatting for Votes and Shares
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name",
                FillWeight = 35,
            };
            InventoryDataGrid.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn votesColumn = new DataGridViewTextBoxColumn
            {
                Name = "Votes",
                HeaderText = "Votes",
                DataPropertyName = "Votes",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                FillWeight = 25
            };
            InventoryDataGrid.Columns.Add(votesColumn);

            DataGridViewTextBoxColumn sharesColumn = new DataGridViewTextBoxColumn
            {
                Name = "Shares",
                HeaderText = "Shares",
                DataPropertyName = "Shares",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" },
                FillWeight = 25
            };
            InventoryDataGrid.Columns.Add(sharesColumn);

            // Add the new VtrStatus column
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn
            {
                Name = "VotingStatus",
                HeaderText = "Voting Status",
                DataPropertyName = "VtrStatus",
                FillWeight = 15,
            };
            InventoryDataGrid.Columns.Add(statusColumn);

            // Add rows
            foreach (var investor in investors)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(InventoryDataGrid, investor.Id, investor.Name, investor.Votes, investor.Shares, investor.Status);
                InventoryDataGrid.Rows.Add(row);

                // Set the row height explicitly
                row.Height = 30;
            }

            UpdateButtonStates();
        }

        private void ApplyFilters()
        {
            string searchText = txtBoxSearch.Text.Trim().ToLower();

            if (originalInvestorList == null)
            {
                // Log the error or handle it as needed
                MessageBox.Show("Investor list is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filter the data based on the search text
            var filteredData = originalInvestorList
                                .Where(investor =>
                                    (string.IsNullOrEmpty(searchText) ||
                                     investor.Id.ToLower().Contains(searchText) ||
                                     investor.Name.ToLower().Contains(searchText) ||
                                     investor.Votes.ToString().Contains(searchText)) &&
                                    (!checkBoxVoted.Checked || investor.Status.Equals("Yes", StringComparison.OrdinalIgnoreCase)) &&
                                    (!checkBoxNonVoted.Checked || investor.Status.Equals("No", StringComparison.OrdinalIgnoreCase)))
                                .ToList();

            // Update the DataGridView with the filtered data
            UpdateDataGridView(filteredData);
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

        private void button_AddNewUser_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
            LoadData();
            SaveDataToSHList();
            UpdateButtonStates();
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
                                    SaveDataToSHList();
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
                                SaveDataToSHList();
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

            // Check if the originalInvestorList is null
            if (originalInvestorList == null)
            {
                return;
            }

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
            CustomCellHeight();
            ApplyFilters();
        }

        private void txtBoxSearch_ButtonClick(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim().ToLower();

            // Check if the originalInvestorList is null
            if (originalInvestorList == null)
            {           
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

            CustomCellHeight();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim().ToLower();

            // Check if the originalInvestorList is null
            if (originalInvestorList == null)
            {
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
            CustomCellHeight();
        }

        public void CustomCellHeight()
        {
            //Custom Row Height of DataGrid
            foreach (DataGridViewRow row in InventoryDataGrid.Rows)
            {
                row.Height = 30;
            }
        }

        public void UpdateVotes() 
        {
            // Clear data in SDH_VoteSelected
            SDH_VoteSelected.Clear();

            // Save the cleared data to SDH_VoteSelected.json
            SaveSDH_VoteSelectedData();

            // Update the status and reset VoteCount in InvestorMasterlist.json
            UpdateInvestorMasterlistStatus();

            // Empty the data in SDHRep.json
            EmptySDHRepData();

            LoadData();
        }


        private void btnClearVote_Click(object sender, EventArgs e)
        {
            UpdateVotes();

            UpdateTotalShares(); 

            // Optionally, notify the user or perform additional actions
            MessageBox.Show("All VOTES are cleared!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveSDH_VoteSelectedData()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string filePath = Path.Combine(folderPath, "SDH_VoteSelected.json");

                // Serialize an empty array to JSON format
                string json = JsonConvert.SerializeObject(new List<VoteSelectedData>(), Formatting.Indented);

                // Write the JSON data to the file
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving SDH_VoteSelected data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmptySDHRepData()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string filePath = Path.Combine(folderPath, "SDHRep.json");

                // Write an empty string to the file to clear its content
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error emptying SDHRep.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInvestorMasterlistStatus()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string masterListFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");

                if (File.Exists(masterListFilePath))
                {
                    // Read the JSON data from the file
                    string json = File.ReadAllText(masterListFilePath);

                    // Deserialize the JSON data into a list of investors
                    List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json);

                    // Update the status and reset the VoteCount of all investors
                    foreach (var investor in investors)
                    {
                        investor.Status = "NO";
                        investor.VoteCount = 0;
                    }

                    // Serialize the updated list of investors back to JSON format
                    string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);

                    // Write the updated JSON data back to the file
                    File.WriteAllText(masterListFilePath, updatedJson);
                }
                else
                {
                    MessageBox.Show("InvestorMasterlist.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating InvestorMasterlist status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvMasterlist_Click(object sender, EventArgs e)
        {
            userControlVoting1.Visible = false;
            LoadData();
            CustomCellHeight();
            UpdateTotalShares();
            btnInvMasterlist.BackColor = Color.WhiteSmoke;
            btnInvMasterlist.ForeColor = Color.Sienna;
            tableLayoutPanel1.BackColor = Color.White;
            btnVoting.BackColor = Color.White;
            btnVoting.ForeColor = Color.DarkSlateGray;
        }


        private void btnVoting_Click(object sender, EventArgs e)
        {
            userControlVoting1.Visible = true;
            userControlVoting1.ReloadData();
            btnVoting.BackColor = Color.WhiteSmoke;
            btnVoting.ForeColor = Color.Sienna;
            tableLayoutPanel1.BackColor = Color.White;
            btnInvMasterlist.BackColor = Color.White;
            btnInvMasterlist.ForeColor = Color.DarkSlateGray;
        }

        private void btnCloseFP_Click(object sender, EventArgs e)
        {
            userControlVoting1.RestorGridView();
            btnCloseFP.Visible = false;
        }

        public void ShowCloseButton()
        {
            btnCloseFP.Visible = true;
        }

        private void checkBoxVoted_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            CustomCellHeight();
        }

        private void checkBoxNonVoted_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            CustomCellHeight();
        }

        private void UpdateButtonStates()
        {
            bool hasData = InventoryDataGrid.Rows.Count > 0;

            button_UpdateUser.Enabled = hasData;
            buttonDelete.Enabled = hasData;          
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                if (userControlVoting1.Visible)
                {
                    SDHVoForm votersForm = new SDHVoForm(sdhStockHolder, userControlVoting1);
                    votersForm.ShowDialog();
                }

                return true; // Shortcut handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UpdateTotalShares()
        {
            int totalShares = 0;
            int totalShareholders = 0;
            int registerShares = 0;
            int registerShareholders = 0;

            foreach (DataGridViewRow row in InventoryDataGrid.Rows)
            {
                // Skip the new row placeholder if present
                if (row.IsNewRow)
                    continue;

                // Check if the Shares cell has a value
                if (row.Cells["Shares"].Value != null && int.TryParse(row.Cells["Shares"].Value.ToString(), out int shares))
                {
                    totalShares += shares;
                    totalShareholders++;

                    // Check status for registered/YES
                    var statusCell = row.Cells["VotingStatus"].Value;
                    if (statusCell != null)
                    {
                        string status = statusCell.ToString();
                        if (status.Equals("Register", StringComparison.OrdinalIgnoreCase) ||
                            status.Equals("YES", StringComparison.OrdinalIgnoreCase))
                        {
                            registerShares += shares;
                            registerShareholders++;
                        }
                    }
                }
            }

            txtboxTotalShares.Text = totalShares.ToString("N0");
            txtboxTotalShareholders.Text = totalShareholders.ToString("N0");
            txtboxRegisterShares.Text = registerShares.ToString("N0");
            txtboxRegisteredShareholders.Text = registerShareholders.ToString("N0");
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (InventoryDataGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = InventoryDataGrid.SelectedRows[0].Index;

                // Ensure the selected row index is within bounds
                if (selectedIndex >= 0 && selectedIndex < originalInvestorList.Count)
                {
                    InvestorViewModel selectedInvestorViewModel = originalInvestorList[selectedIndex];

                    // Find the corresponding Investor object in the JSON file
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "InvestorMasterlist.json");

                    if (File.Exists(filePath))
                    {
                        string json = File.ReadAllText(filePath);
                        List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                        // Find the investor by name
                        Investor selectedInvestor = investors.Find(i => i.Name == selectedInvestorViewModel.Name);

                        if (selectedInvestor != null)
                        {
                            // Update the status
                            selectedInvestor.Status = "Register";

                            // Save the updated list back to the file
                            string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                            File.WriteAllText(filePath, updatedJson);

                            // Optionally update the view model and refresh the grid
                            selectedInvestorViewModel.Status = "Register";
                            LoadData();
                            UpdateTotalShares();

                            MessageBox.Show("Investor status updated to 'Register'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Selected investor not found in the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a row to register.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


    public class Investor
    {
        public String Id { get; set; } 
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
        public string Status { get; set; }
        public int VoteCount { get; set; }
    }

    public class InvestorViewModel
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
        public string Status { get; set; }
    }

    public class Representative
    {
        public string Name { get; set; }
        public int Votes { get; set; } 
        public int Shares { get; set; }
    }

    public class VoteSelectedData
    {
        public string Representative { get; set; }
        public string StockHolder { get; set; }
    }

    public class History
    {
        public int ID { get; set; }
        public string Representative { get; set; }
        public int TotalVotes { get; set; }
        public int No_PV { get; set; }
    }
}
