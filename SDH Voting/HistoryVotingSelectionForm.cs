using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace SDH_Voting
{
    public partial class HistoryVotingSelectionForm : Form
    {
        public string FolderTitle { get; set; }

        public HistoryVotingSelectionForm(string representativeName, string folderTitle)
        {
            InitializeComponent();
            FolderTitle = folderTitle;
            LoadVoters(representativeName);
        }


        private void LoadVoters(string representativeName)
        {
            // Base path for the posted folder
            string postedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "Posted");

            // Check for null or empty FolderTitle
            if (string.IsNullOrWhiteSpace(FolderTitle))
            {
                MessageBox.Show("No folder title specified. Unable to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the path based on the folder title selected
            string folderPath = Path.Combine(postedFolderPath, FolderTitle);

            // Check if the folder path exists
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"The folder '{folderPath}' does not exist. Unable to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                    // Set the representative's name in the label
                    labelRepresentative.Text = $"{representativeName}";

                    // Bind voters data to the DataGridView
                    ViewGridVoters.Rows.Clear();

                    int id = 1;
                    foreach (string voter in voters)
                    {
                        int index = ViewGridVoters.Rows.Add();
                        ViewGridVoters.Rows[index].Cells["sdhID"].Value = id++;
                        ViewGridVoters.Rows[index].Cells["sdhVoters"].Value = voter;
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
    }
}
