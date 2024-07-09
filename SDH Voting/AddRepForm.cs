using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class AddRepForm : Form
    {
        private List<Investor> investors;
        private string folderPath;
        private string masterListFilePath;
        private string repFilePath;
        private List<string> existingRepresentatives;

        public AddRepForm(List<string> existingRepresentatives)
        {
            InitializeComponent();
            this.existingRepresentatives = existingRepresentatives;
            InitializeData();
        }

        private void InitializeData()
        {
            // Initialize variables
            folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            masterListFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");
            repFilePath = Path.Combine(folderPath, "SDHRep.json");
            investors = new List<Investor>();

            // Load existing investors from file if it exists
            LoadInvestorsFromFile();

            // Filter out investors whose names already exist in the representatives list
            var filteredInvestors = investors.Where(inv => !existingRepresentatives.Contains(inv.Name)).ToList();
            investors = filteredInvestors;

            // Bind investors names to comboRep
            BindInvestorsToComboBox();
        }


        private void LoadInvestorsFromFile()
        {
            try
            {
                if (File.Exists(repFilePath))
                {
                    string json = File.ReadAllText(masterListFilePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading investors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindInvestorsToComboBox()
        {
            comboRep.Items.Clear();
            foreach (var investor in investors)
            {
                comboRep.Items.Add(investor.Name);
            }
        }

        private void DisplayInvestorDetails(int index)
        {
            if (index >= 0 && index < investors.Count)
            {
                textBoxName.Text = investors[index].Name; // Display the investor's name
                textBoxVotes.Text = investors[index].Votes.ToString(); // Display votes
                textBoxShares.Text = investors[index].Shares.ToString(); // Display shares
            }
        }

        private void btnSaveRep_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values from text boxes
                string repName = textBoxName.Text.Trim();
                string votesText = textBoxVotes.Text.Trim();
                string sharesText = textBoxShares.Text.Trim();

                // Validate name
                if (string.IsNullOrWhiteSpace(repName))
                {
                    MessageBox.Show("Please enter a name for the representative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parse Votes and Shares
                if (!int.TryParse(votesText, out int votes))
                {
                    MessageBox.Show("Please enter a valid number for Votes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(sharesText, out int shares))
                {
                    MessageBox.Show("Please enter a valid number for Shares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new investor
                var newInvestor = new Investor
                {
                    Name = repName,
                    Votes = votes,
                    Shares = shares
                };

                // Add the new investor to the list in memory
                investors.Add(newInvestor);

                // Save the new investor to SDHRep.json
                SaveInvestorsToFile(newInvestor);

                MessageBox.Show("Entry saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text boxes for next entry
                textBoxName.Clear();
                textBoxVotes.Clear();
                textBoxShares.Clear();
                textBoxName.Focus(); // Set focus back to name textbox
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveInvestorsToFile(Investor newInvestor)
        {
            try
            {
                Directory.CreateDirectory(folderPath); 

                // Serialize the new investor to JSON
                string json = JsonConvert.SerializeObject(newInvestor);

                // Append the serialized JSON to SDHRep.json
                File.AppendAllText(repFilePath, json + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving investor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected investor's index
            int selectedIndex = comboRep.SelectedIndex;

            // Display details for the selected investor
            DisplayInvestorDetails(selectedIndex);
        }

      
    }
}
