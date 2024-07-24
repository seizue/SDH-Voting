using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SDH_Voting
{
    public partial class VoterSelectionForm : Form
    {

        public event EventHandler<(string StockHolderName, string InvestorId)> StockHolderSelected;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public VoterSelectionForm()
        {
            InitializeComponent();
            LoadData();

            foreach (DataGridViewRow row in GridVoters.Rows)
            {
                row.Height = 25;
            }

            // Attach event handler
            GridVoters.CellDoubleClick += GridVoters_CellDoubleClick;
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
                    var deserializedInvestors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                    // Include only investors who haven't reached the vote limit and whose status is not "YES"
                    investors = deserializedInvestors
                                    .Where(i => i.VoteCount < 5 && i.Status != "YES")
                                    .ToList();
                }
            }

            // Ensure AutoGenerateColumns is false to prevent automatic column creation
            GridVoters.AutoGenerateColumns = false;

            // Set the data source
            GridVoters.DataSource = new BindingList<Investor>(investors);

            // Map existing columns to properties
            if (GridVoters.Columns["sdhID"] != null)
            {
                GridVoters.Columns["sdhID"].DataPropertyName = "Id";
                GridVoters.Columns["sdhID"].Visible = false; // Hide the Id column
            }

            if (GridVoters.Columns["sdhStockHolder"] != null) GridVoters.Columns["sdhStockHolder"].DataPropertyName = "Name";

            // Format Shares column with commas
            if (GridVoters.Columns["sdhShares"] != null)
            {
                GridVoters.Columns["sdhShares"].DataPropertyName = "Shares";
                GridVoters.Columns["sdhShares"].DefaultCellStyle.Format = "N0";
            }

            // Format Total Votes column with commas
            if (GridVoters.Columns["sdhTotalVotes"] != null)
            {
                GridVoters.Columns["sdhTotalVotes"].DataPropertyName = "Votes";
                GridVoters.Columns["sdhTotalVotes"].DefaultCellStyle.Format = "N0";
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridVoters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = GridVoters.Rows[e.RowIndex];

                // Get the value from the "sdhStockHolder" column
                string stockHolderName = selectedRow.Cells["sdhStockHolder"].Value.ToString();
                string investorId = selectedRow.Cells["sdhID"].Value.ToString();

                // Raise the event to pass data back to SDHVoForm
                StockHolderSelected?.Invoke(this, (stockHolderName, investorId));

                // Close the form or perform any other actions
                this.Close();
            }
        }


        private void VoterSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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

        private void GridVoters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = GridVoters.Rows[e.RowIndex];

                // Get the value from the "sdhStockHolder" column
                string stockHolderName = selectedRow.Cells["sdhStockHolder"].Value.ToString();
                string investorId = selectedRow.Cells["sdhID"].Value.ToString();

                // Raise the event to pass data back to SDHVoForm
                StockHolderSelected?.Invoke(this, (stockHolderName, investorId));

                // Close the form or perform any other actions
                this.Close();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim();

            // Get the BindingList from the DataSource
            BindingList<Investor> investors = (BindingList<Investor>)GridVoters.DataSource;

            // If no search text is entered, reset the DataGridView
            if (string.IsNullOrWhiteSpace(searchText))
            {
                GridVoters.DataSource = investors;
            }
            else
            {
                // Perform case-insensitive search by stock holder name
                var filteredInvestors = investors.Where(i => i.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                // Update the DataGridView with the filtered results
                GridVoters.DataSource = new BindingList<Investor>(filteredInvestors);
            }
        }

        private void txtBoxSearch_ClearClicked()
        {
            txtBoxSearch.Text = ""; // Clear the text in txtBoxSearch
            LoadData();
        }

        private void txtBoxSearch_ButtonClick(object sender, EventArgs e)
        {
            string searchText = txtBoxSearch.Text.Trim();

            // Get the BindingList from the DataSource
            BindingList<Investor> investors = (BindingList<Investor>)GridVoters.DataSource;

            // If no search text is entered, reset the DataGridView
            if (string.IsNullOrWhiteSpace(searchText))
            {
                GridVoters.DataSource = investors;
            }
            else
            {
                // Perform case-insensitive search by stock holder name
                var filteredInvestors = investors.Where(i => i.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                // Update the DataGridView with the filtered results
                GridVoters.DataSource = new BindingList<Investor>(filteredInvestors);
            }
        }

        private void checkBoxShowShareholdersVoted_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilteredData();
        }

        private void LoadFilteredData()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
            List<Investor> investors = new List<Investor>();

            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var deserializedInvestors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                        if (checkBoxShowShareholdersVoted.Checked)
                        {
                            // Include only investors who have voted (Status == "YES")
                            investors = deserializedInvestors
                                            .Where(i => i.Status == "YES")
                                            .ToList();
                        }
                        else
                        {
                            // Include all investors who haven't reached the vote limit and whose status is not "YES"
                            investors = deserializedInvestors
                                            .Where(i => i.VoteCount < 5 && i.Status != "YES")
                                            .ToList();
                        }
                    }
                }

                // Ensure AutoGenerateColumns is false to prevent automatic column creation
                GridVoters.AutoGenerateColumns = false;

                // Set the data source
                GridVoters.DataSource = new BindingList<Investor>(investors);

                // Map existing columns to properties
                if (GridVoters.Columns["sdhID"] != null)
                {
                    GridVoters.Columns["sdhID"].DataPropertyName = "Id";
                    GridVoters.Columns["sdhID"].Visible = false; // Hide the Id column
                }

                if (GridVoters.Columns["sdhStockHolder"] != null) GridVoters.Columns["sdhStockHolder"].DataPropertyName = "Name";

                // Format Shares column with commas
                if (GridVoters.Columns["sdhShares"] != null)
                {
                    GridVoters.Columns["sdhShares"].DataPropertyName = "Shares";
                    GridVoters.Columns["sdhShares"].DefaultCellStyle.Format = "N0";
                }

                // Format Total Votes column with commas
                if (GridVoters.Columns["sdhTotalVotes"] != null)
                {
                    GridVoters.Columns["sdhTotalVotes"].DataPropertyName = "Votes";
                    GridVoters.Columns["sdhTotalVotes"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
