using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SDH_Voting
{
    public partial class SettingsForm : Form
    {
        private List<VoteSelectedData> SDH_VoteSelected = new List<VoteSelectedData>();
        private UserControlVoting userControlVoting;

        public SettingsForm(UserControlVoting userControl)
        {
            InitializeComponent();
            userControlVoting = userControl; 
        }


        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (userControlVoting != null)
            {
                // Ask for confirmation before proceeding
                DialogResult result = MessageBox.Show("Are you sure you want to delete all data? This action cannot be undone.",
                                                      "Confirm Data Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Clear data in SDH_VoteSelected
                    SDH_VoteSelected.Clear();

                    // Save the cleared data to SDH_VoteSelected.json
                    SaveSDH_VoteSelectedData();

                    DeleteInvestorMasterlistData();

                    // Empty the data in SDHRep.json
                    EmptySDHRepData();

                    // Optionally, notify the user or perform additional actions
                    MessageBox.Show("All data are deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload data in UserControlVoting
                    userControlVoting.ReloadData();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("UserControlVoting instance is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSDH_VoteSelectedData()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string filePath = Path.Combine(folderPath, "SDH_VoteSelected.json");

                // Serialize an empty array to JSON format
                string json = JsonConvert.SerializeObject(new List<VoteSelectedData>(), Formatting.Indented);

                // Write the JSON data to the file
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving SDH_VoteSelected data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmptySDHRepData()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string filePath = Path.Combine(folderPath, "SDHRep.json");

                // Write an empty string to the file to clear its content
                File.WriteAllText(filePath, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error emptying SDHRep.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteInvestorMasterlistData()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string masterListFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");

                // Write an empty array to the file to clear its content
                File.WriteAllText(masterListFilePath, "[]");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting InvestorMasterlist data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
