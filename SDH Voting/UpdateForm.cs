using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class UpdateForm : Form
    {
        private Investor _investor;

        public UpdateForm(Investor investor)
        {
            InitializeComponent();
            _investor = investor;
            LoadInvestorData();
        }

        private void LoadInvestorData()
        {
            textBoxName.Text = _investor.Name;
            textBoxVotes.Text = _investor.Votes.ToString();
            textBoxShares.Text = _investor.Shares.ToString("N0");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            // Update the investor object
            _investor.Name = textBoxName.Text;
            _investor.Votes = votes;
            _investor.Shares = shares;

            // Determine the folder path
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");

            // Ensure the directory exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Determine the file path
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");

            List<Investor> investors = new List<Investor>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                investors = JsonConvert.DeserializeObject<List<Investor>>(json);
            }

            // Find the original investor by ID and update it
            Investor originalInvestor = investors.Find(i => i.Id == _investor.Id);
            if (originalInvestor != null)
            {
                originalInvestor.Name = _investor.Name;
                originalInvestor.Votes = _investor.Votes;
                originalInvestor.Shares = _investor.Shares;
            }

            // Save the updated list
            string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);

            // Close the form
            this.Close();
        }

        private bool TryConvertToNumber(string input, out int result)
        {
            input = input.ToUpper().Trim();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
