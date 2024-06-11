using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            textBoxVotes.TextChanged += textBoxVotes_TextChanged; // Add event handler
        }

        private void textBoxVotes_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxVotes.Text;
            if (TryConvertToNumber(input, out int votes))
            {
                textBoxShares.Text = votes.ToString("N0"); // Reflect the number of votes in shares with formatting
            }
            else
            {
                textBoxShares.Text = "0"; // Handle invalid input
            }
        }

        private bool TryConvertToNumber(string input, out int result)
        {
            input = input.ToUpper().Trim(); // Standardize input to uppercase and trim whitespace
            result = 0;
            Regex regex = new Regex(@"^(\d+(\.\d+)?)([KM]?)$");
            Match match = regex.Match(input);

            if (match.Success)
            {
                double number = double.Parse(match.Groups[1].Value);
                string unit = match.Groups[3].Value;

                switch (unit)
                {
                    case "K":
                        number *= 1_000;
                        break;
                    case "M":
                        number *= 1_000_000;
                        break;
                }

                result = (int)number;
                return true;
            }

            return false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure TextBoxes are not null
                if (textBoxName == null || textBoxVotes == null || textBoxShares == null)
                {
                    MessageBox.Show("One or more input fields are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get input values
                string name = textBoxName.Text;

                // Validate and convert inputs
                if (!TryConvertToNumber(textBoxVotes.Text, out int votes))
                {
                    MessageBox.Show("Invalid input in Votes. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!TryConvertToNumber(textBoxShares.Text.Replace(",", ""), out int shares))
                {
                    MessageBox.Show("Invalid input in Shares. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new investor object with a unique ID
                Investor newInvestor = new Investor
                {
                    Id = Guid.NewGuid().GetHashCode(), // Use a hash code of a new GUID for simplicity
                    Name = name,
                    Shares = shares,
                    Votes = votes,
                };

                // Load existing data
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");

                // Ensure the directory exists
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
                List<Investor> investors = new List<Investor>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();
                }

                // Ensure the investors list is not null
                if (investors == null)
                {
                    investors = new List<Investor>();
                }

                // Add new investor
                investors.Add(newInvestor);

                // Save updated data
                string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString()); // For detailed debugging information
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
