using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class ViewVotersForm : Form
    {
        public ViewVotersForm(string representativeName)
        {
            InitializeComponent();
            LoadVoters(representativeName);
        }

        private void LoadVoters(string representativeName)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDH_VoteSelected.json");

            try
            {
                List<string> voters = new List<string>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    JArray voteData = JArray.Parse(json);

                    // Collect voters for the selected representative
                    foreach (JObject vote in voteData)
                    {
                        string currentRepresentative = vote["Representative"].ToString();
                        string stockHolder = vote["StockHolder"].ToString();

                        if (currentRepresentative.Equals(representativeName, StringComparison.OrdinalIgnoreCase))
                        {
                            voters.Add(stockHolder);
                        }
                    }

                    // Bind voters data to the DataGridView
                    ViewGridVoters.Rows.Clear();

                    int id = 1;
                    foreach (string voter in voters)
                    {
                        int index = ViewGridVoters.Rows.Add();
                        ViewGridVoters.Rows[index].Cells["sdhID"].Value = id++; // Generate and assign ID
                        ViewGridVoters.Rows[index].Cells["sdhVoters"].Value = voter;
                        ViewGridVoters.Rows[index].Cells["sdhRepresentative"].Value = representativeName;
                    }
                }
                else
                {
                    MessageBox.Show("SDH_VoteSelected.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading voters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
