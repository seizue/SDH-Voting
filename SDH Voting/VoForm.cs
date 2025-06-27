using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
    public partial class SDHVoForm : MetroFramework.Forms.MetroForm
    {
        private UserControlVoting userControlVoting;
        private string selectedInvestorId;
        private List<Investor> investors;

        public SDHVoForm(string sdhStockHolder, UserControlVoting userControl)
        {
            InitializeComponent();
            LoadRepresentativesComboRep();
            txtBoxSH.Text = sdhStockHolder;
            LoadInvestorsData();
            userControlVoting = userControl;
        }

        private void LoadRepresentativesComboRep()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");
            List<Representative> representatives = new List<Representative>();

            try
            {
                if (File.Exists(filePath))
                {
                    // Read all lines from the file
                    string[] jsonLines = File.ReadAllLines(filePath);

                    foreach (string json in jsonLines)
                    {
                        // Deserialize each JSON line into a Representative object
                        Representative rep = JsonConvert.DeserializeObject<Representative>(json);
                        representatives.Add(rep);
                    }

                    // Populate the ComboBox with the representatives' names
                    comboRep.Items.Clear(); // Clear any existing items
                    foreach (var rep in representatives)
                    {
                        comboRep.Items.Add(rep.Name);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading representatives: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvestorsData()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                // Display total stockholders count
                textBoxAllSH.Text = investors.Count.ToString();

                // Calculate counts based on Status
                int votedCount = investors.Count(i => i.Status == "YES");
                int notVotedCount = investors.Count(i => i.Status == "NO");

                // Display counts
                txtBoxVoted.Text = votedCount.ToString(); 
                txtBoxAVoters.Text = notVotedCount.ToString();
            }
            else
            {
                MessageBox.Show("InvestorMasterlist.json file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void labelStatus_Click(object sender, EventArgs e)
        {
          
        }

        private void btnViewVoter_Click(object sender, EventArgs e)
        {
            VoterSelectionForm voterSelectionForm = new VoterSelectionForm();
            // Subscribe to the event in VoterSelectionForm to receive the selected stockholder name and ID
            voterSelectionForm.StockHolderSelected += VoterSelectionForm_StockHolderSelected;
            voterSelectionForm.ShowDialog();
        }

        // Update the event handler to match the correct signature
        private void VoterSelectionForm_StockHolderSelected(object sender, (string StockHolderName, string InvestorId) data)
        {
            // Update the text box with the selected stockholder name
            txtBoxSH.Text = data.StockHolderName;
            // Store the selected investor's ID
            selectedInvestorId = data.InvestorId;
        }

        private void SDHVoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveVoters_Click(object sender, EventArgs e)
        {
            SaveRepVoter();
            userControlVoting.ReloadData(); // Refresh the DataGridView
        }


        public void SaveRepVoter()
        {
            if (string.IsNullOrEmpty(selectedInvestorId))
            {
                MessageBox.Show("No investor selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string investorFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");
                string repFilePath = Path.Combine(folderPath, "SDHRep.json");

                List<Investor> investors = new List<Investor>();
                List<Representative> representatives = new List<Representative>();

                if (File.Exists(investorFilePath))
                {
                    string investorJson = File.ReadAllText(investorFilePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(investorJson) ?? new List<Investor>();
                }

                if (File.Exists(repFilePath))
                {
                    string[] repJsonArray = File.ReadAllLines(repFilePath);
                    foreach (string repJson in repJsonArray)
                    {
                        var representative = JsonConvert.DeserializeObject<Representative>(repJson);
                        representatives.Add(representative);
                    }
                }

                var investor = investors.FirstOrDefault(i => i.Id == selectedInvestorId);
                if (investor != null)
                {
                    if (investor.VoteCount <= 0)
                    {
                        investor.VoteCount = 1;
                    }
                    else
                    {
                        investor.VoteCount++;
                    }

                    int maxVoteLimit = Properties.Settings.Default.MaxVoteLimit;
                    if (investor.VoteCount >= maxVoteLimit)
                    {
                        investor.Status = "YES";
                    }
                }

                // Validate representative selection
                if (comboRep.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Representative to Vote.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRepName = comboRep.SelectedItem.ToString();

                var rep = representatives.FirstOrDefault(r => r.Name == selectedRepName);
                if (rep != null)
                {
                    var selectedInvestorVotes = investor?.Votes ?? 0;
                    rep.Votes += selectedInvestorVotes;
                    rep.Shares += selectedInvestorVotes;
                }

                string updatedInvestorJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                File.WriteAllText(investorFilePath, updatedInvestorJson);

                List<string> updatedRepJsonLines = new List<string>();
                foreach (var representative in representatives)
                {
                    string repJsonLine = JsonConvert.SerializeObject(representative, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        ContractResolver = new DefaultContractResolver
                        {
                            IgnoreSerializableAttribute = true
                        }
                    });
                    updatedRepJsonLines.Add(repJsonLine);
                }

                File.WriteAllLines(repFilePath, updatedRepJsonLines);

                SaveSelectedVoteData(folderPath);

                // Refresh the DataGridView in UserControlVoting
                userControlVoting.ReloadData();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveSelectedVoteData(string folderPath)
        {
            string voteSelectedFilePath = Path.Combine(folderPath, "SDH_VoteSelected.json");
            List<VoteSelectedData> voteSelectedList = new List<VoteSelectedData>();

            if (File.Exists(voteSelectedFilePath))
            {
                string voteSelectedJson = File.ReadAllText(voteSelectedFilePath);
                voteSelectedList = JsonConvert.DeserializeObject<List<VoteSelectedData>>(voteSelectedJson) ?? new List<VoteSelectedData>();
            }

            // Add new entry for the selected vote
            voteSelectedList.Add(new VoteSelectedData
            {
                Representative = comboRep.SelectedItem.ToString(),
                StockHolder = txtBoxSH.Text
            });

            // Save updated vote selected data
            string updatedVoteSelectedJson = JsonConvert.SerializeObject(voteSelectedList, Formatting.Indented);
            File.WriteAllText(voteSelectedFilePath, updatedVoteSelectedJson);
        }

        private void SDHVoForm_Load(object sender, EventArgs e)
        {
            if (userControlVoting != null)
            {
                userControlVoting.ReloadData();
                LoadInvestorsData();
            }
            else
            {
                MessageBox.Show("userControlVoting is null. Cannot reload data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxDoneVoting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoneVoting.Checked)
            {
                if (string.IsNullOrEmpty(txtBoxSH.Text))
                {
                    MessageBox.Show("Please select an Shareholder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxDoneVoting.Checked = false; // Uncheck the checkbox
                    return;
                }

                // Find the investor with the matching Name (assuming Name is the property to match)
                var investorToUpdate = investors.FirstOrDefault(i => i.Name == txtBoxSH.Text);

                if (investorToUpdate != null)
                {
                    // Confirm with the user before proceeding
                    DialogResult result = MessageBox.Show("Are you sure you want to mark this Shareholder as voted? You cannot vote again.",
                        "Confirm Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Update the Status to "YES"
                        investorToUpdate.Status = "YES";

                        // Update the displayed count of voted investors
                        int votedCount = investors.Count(i => i.Status == "YES");
                        txtBoxVoted.Text = votedCount.ToString();

                        // Update the displayed count of not voted investors
                        int notVotedCount = investors.Count(i => i.Status == "NO");
                        txtBoxAVoters.Text = notVotedCount.ToString();

                        // Save updated investors list to file
                        try
                        {
                            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                            string investorFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");

                            string updatedInvestorJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                            File.WriteAllText(investorFilePath, updatedInvestorJson);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to save Shareholder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // User clicked No, so uncheck the checkbox
                        checkBoxDoneVoting.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Shareholder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBoxUndoVote_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUndoVote.Checked)
            {
                if (string.IsNullOrEmpty(txtBoxSH.Text))
                {
                    MessageBox.Show("Please select an Shareholder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxUndoVote.Checked = false; // Uncheck the checkbox
                    return;
                }

                // Find the investor with the matching Name (assuming Name is the property to match)
                var investorToUpdate = investors.FirstOrDefault(i => i.Name == txtBoxSH.Text);

                if (investorToUpdate != null)
                {
                    // Confirm with the user before proceeding
                    DialogResult result = MessageBox.Show("Are you sure you want to undo this Shareholder vote?",
                        "Confirm Undo Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Update the Status to "NO"
                        investorToUpdate.Status = "NO";

                        // Update the displayed count of voted investors
                        int votedCount = investors.Count(i => i.Status == "YES");
                        txtBoxVoted.Text = votedCount.ToString();

                        // Update the displayed count of not voted investors
                        int notVotedCount = investors.Count(i => i.Status == "NO");
                        txtBoxAVoters.Text = notVotedCount.ToString();

                        // Save updated investors list to file
                        try
                        {
                            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                            string investorFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");

                            string updatedInvestorJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                            File.WriteAllText(investorFilePath, updatedInvestorJson);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to save Shareholder data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // User clicked No, so uncheck the checkbox
                        checkBoxUndoVote.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Shareholder not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }


}
