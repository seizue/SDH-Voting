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

        public event EventHandler<string> StockHolderSelected;

        public VoterSelectionForm()
        {
            InitializeComponent();
            LoadData();

            foreach (DataGridViewRow row in GridVoters.Rows)
            {
                row.Height = 25;
            }
            // Attach the CellDoubleClick event handler
            GridVoters.CellDoubleClick += GridVoters_CellDoubleClick;
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

                    // Remove duplicates based on Id
                    investors = deserializedInvestors
                                .GroupBy(i => i.Id)
                                .Select(g => g.First())
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

                // Raise the event to pass data back to SDHVoForm
                StockHolderSelected?.Invoke(this, stockHolderName);

                // Close the form or perform any other actions
                this.Close();
            }
        }


        private void VoterSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
