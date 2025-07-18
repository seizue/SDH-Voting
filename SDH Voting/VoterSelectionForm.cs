﻿using Newtonsoft.Json;
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
    public partial class VoterSelectionForm : MetroFramework.Forms.MetroForm
    {

        public event EventHandler<(string StockHolderName, string InvestorId)> StockHolderSelected;

        public VoterSelectionForm()
        {
            InitializeComponent();

            GridVoters.RowTemplate.Height = 30;

            LoadData();

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

                    // Only include investors with Status == "Register"
                    investors = deserializedInvestors
                                    .Where(i => i.Status == "Register")
                                    .ToList();
                }
            }

            GridVoters.AutoGenerateColumns = false;
            GridVoters.DataSource = new BindingList<Investor>(investors);

            if (GridVoters.Columns["sdhID"] != null)
            {
                GridVoters.Columns["sdhID"].DataPropertyName = "Id";
                GridVoters.Columns["sdhID"].Visible = false;
            }
            if (GridVoters.Columns["sdhStockHolder"] != null) GridVoters.Columns["sdhStockHolder"].DataPropertyName = "Name";
            if (GridVoters.Columns["sdhShares"] != null)
            {
                GridVoters.Columns["sdhShares"].DataPropertyName = "Shares";
                GridVoters.Columns["sdhShares"].DefaultCellStyle.Format = "N0";
            }
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

                        // Show "YES" if checked, "Register" if unchecked
                        if (checkBoxShowShareholdersVoted.Checked)
                        {
                            investors = deserializedInvestors
                                .Where(i => i.Status == "YES")
                                .ToList();
                        }
                        else
                        {
                            investors = deserializedInvestors
                                .Where(i => i.Status == "Register")
                                .ToList();
                        }
                    }
                }

                GridVoters.AutoGenerateColumns = false;
                GridVoters.DataSource = new BindingList<Investor>(investors);

                if (GridVoters.Columns["sdhID"] != null)
                {
                    GridVoters.Columns["sdhID"].DataPropertyName = "Id";
                    GridVoters.Columns["sdhID"].Visible = false;
                }
                if (GridVoters.Columns["sdhStockHolder"] != null) GridVoters.Columns["sdhStockHolder"].DataPropertyName = "Name";
                if (GridVoters.Columns["sdhShares"] != null)
                {
                    GridVoters.Columns["sdhShares"].DataPropertyName = "Shares";
                    GridVoters.Columns["sdhShares"].DefaultCellStyle.Format = "N0";
                }
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
