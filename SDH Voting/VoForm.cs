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

        // --- Add this flag for exception logic ---
        private bool forceDoneVoting = false;

        public SDHVoForm(string sdhStockHolder, UserControlVoting userControl)
        {
            InitializeComponent();
            LoadRepresentativesComboRep();
            txtBoxSH.Text = sdhStockHolder;
            LoadInvestorsData();
            userControlVoting = userControl;

            // Set the max vote limit in txtBoxVoteLimit based on saved settings
            int savedMaxVoteLimit = Properties.Settings.Default.MaxVoteLimit;
            txtBoxVoteLimit.Text = savedMaxVoteLimit.ToString();
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

                    // Populate the metroGridRep with representatives' names in the voRep column
                    metroGridRep.Rows.Clear(); // Clear existing rows
                    foreach (var rep in representatives)
                    {
                        int rowIndex = metroGridRep.Rows.Add();
                        metroGridRep.Rows[rowIndex].Cells["voRep"].Value = rep.Name;
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
                int notVotedCount = investors.Count(i => i.Status == "Register");

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

                // --- Get selected representatives from metroGridRep ---
                var selectedRepNames = new List<string>();
                foreach (DataGridViewRow row in metroGridRep.Rows)
                {
                    if (!row.IsNewRow && row.Cells["voSelection"]?.Value is bool isChecked && isChecked)
                    {
                        var repName = row.Cells["voRep"]?.Value?.ToString();
                        if (!string.IsNullOrEmpty(repName))
                            selectedRepNames.Add(repName);
                    }
                }

                // Enforce selection limit based on txtBoxVoteLimit
                int voteLimit = 0;
                int.TryParse(txtBoxVoteLimit.Text, out voteLimit);
                if (voteLimit <= 0) voteLimit = 1; // fallback to 1 if invalid

                if (selectedRepNames.Count == 0)
                {
                    MessageBox.Show("Please select at least one Representative to Vote (using the checkboxes).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (selectedRepNames.Count > voteLimit)
                {
                    MessageBox.Show($"You can only select up to {voteLimit} representative(s). Please uncheck extra selections.", "Selection Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- Exception: If forceDoneVoting is set, always set status to YES ---
                if (investor != null)
                {
                    investor.VoteCount = selectedRepNames.Count;
                    if (forceDoneVoting)
                    {
                        investor.Status = "YES";
                    }
                    else
                    {
                        if (investor.VoteCount == voteLimit)
                        {
                            investor.Status = "YES";
                        }
                        else
                        {
                            investor.Status = "Register";
                        }
                    }
                }

                var selectedInvestorVotes = investor?.Votes ?? 0;
                foreach (var selectedRepName in selectedRepNames)
                {
                    var rep = representatives.FirstOrDefault(r => r.Name == selectedRepName);
                    if (rep != null)
                    {
                        rep.Votes += selectedInvestorVotes;
                        rep.Shares += selectedInvestorVotes;
                    }
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

                SaveSelectedVoteData(folderPath, selectedRepNames);

                // Refresh the DataGridView in UserControlVoting
                userControlVoting.ReloadData();

                // --- Reset the force flag after save ---
                forceDoneVoting = false;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- UPDATED: Accepts selectedRepNames as parameter ---
        private void SaveSelectedVoteData(string folderPath, List<string> selectedRepNames)
        {
            string voteSelectedFilePath = Path.Combine(folderPath, "SDH_VoteSelected.json");
            List<VoteSelectedData> voteSelectedList = new List<VoteSelectedData>();

            if (File.Exists(voteSelectedFilePath))
            {
                string voteSelectedJson = File.ReadAllText(voteSelectedFilePath);
                voteSelectedList = JsonConvert.DeserializeObject<List<VoteSelectedData>>(voteSelectedJson) ?? new List<VoteSelectedData>();
            }

            // Add new entry for each selected representative
            foreach (var repName in selectedRepNames)
            {
                voteSelectedList.Add(new VoteSelectedData
                {
                    Representative = repName,
                    StockHolder = txtBoxSH.Text
                });
            }

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
                        // --- Set the force flag for SaveRepVoter ---
                        forceDoneVoting = true;
                        // Optionally, update UI immediately if needed
                        investorToUpdate.Status = "YES";

                        // Update the displayed count of voted investors
                        int votedCount = investors.Count(i => i.Status == "YES");
                        txtBoxVoted.Text = votedCount.ToString();

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
