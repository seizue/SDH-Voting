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
        public VoterSelectionForm()
        {
            InitializeComponent();
            LoadData();

            foreach (DataGridViewRow row in GridVoters.Rows)
            {
                row.Height = 25;
            }
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

            GridVoters.AutoGenerateColumns = false;
            GridVoters.DataSource = new BindingList<Investor>(investors);

            // Map existing columns to properties
            if (GridVoters.Columns["sdhID"] != null) GridVoters.Columns["sdhID"].DataPropertyName = "Id";
            if (GridVoters.Columns["sdhStockHolder"] != null) GridVoters.Columns["sdhStockHolder"].DataPropertyName = "Name";
            if (GridVoters.Columns["sdhShares"] != null) GridVoters.Columns["sdhShares"].DataPropertyName = "Shares";
            if (GridVoters.Columns["sdhTotalVotes"] != null) GridVoters.Columns["sdhTotalVotes"].DataPropertyName = "Votes";
        }




        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
