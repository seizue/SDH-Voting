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
using System.Diagnostics;

namespace SDH_Voting
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        private List<VoteSelectedData> SDH_VoteSelected = new List<VoteSelectedData>();
        private UserControlVoting userControlVoting;

        public SettingsForm(UserControlVoting userControl)
        {
            InitializeComponent();
            userControlVoting = userControl;

            // Set the selected item of the ComboBox based on the saved value
            string savedWindowState = Properties.Settings.Default.MainFormWindowState;
            if (!string.IsNullOrEmpty(savedWindowState))
            {
                comBox_WindowState.SelectedItem = savedWindowState;
            }

            // Set the font size in txtBoxFontSize based on saved settings
            float savedFontSize = Properties.Settings.Default.DataGridViewFontSize;
            txtBoxFontSize.Text = savedFontSize.ToString();

            // Set the row height in txtBoxRH based on saved settings
            int savedRowHeight = Properties.Settings.Default.DataGridViewRowHeight;
            txtBoxRH.Text = savedRowHeight.ToString();

            // Set the max vote limit in txtBoxVoteLimit based on saved settings
            int savedMaxVoteLimit = Properties.Settings.Default.MaxVoteLimit;
            txtBoxVoteLimit.Text = savedMaxVoteLimit.ToString();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void btnDelAllData_Click(object sender, EventArgs e)
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (comBox_WindowState.SelectedItem != null && Enum.IsDefined(typeof(FormWindowState), comBox_WindowState.SelectedItem.ToString()))
            {
                string selectedWindowState = comBox_WindowState.SelectedItem.ToString();
                Properties.Settings.Default.MainFormWindowState = selectedWindowState;

                // Save the settings
                Properties.Settings.Default.Save();

                if (selectedWindowState == FormWindowState.Maximized.ToString())
                {
                    Rectangle workingArea = Screen.GetWorkingArea(this);
                    this.MaximizedBounds = new Rectangle(workingArea.X, workingArea.Y, workingArea.Width, workingArea.Height);
                }
                else
                {
                    this.MaximizedBounds = Screen.PrimaryScreen.Bounds; 
                }

                MessageBox.Show("Settings saved. Please close and restart the application for the changes to take effect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid window state selected. Please select a valid window state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnSaveFS_Click(object sender, EventArgs e)
        {
            // Read and parse the font size from the TextBox
            if (float.TryParse(txtBoxFontSize.Text, out float fontSize))
            {
                // Validate font size (optional: add more validation as needed)
                if (fontSize > 0)
                {
                    // Save the font size to application settings
                    Properties.Settings.Default.DataGridViewFontSize = fontSize;
                    Properties.Settings.Default.Save();

                    // Apply the font size to UserControlVoting
                    userControlVoting.SetDataGridViewFontSize(fontSize);

                    MessageBox.Show("Font size saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Font size must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid font size format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the settings form or perform any other necessary actions
            this.Close();
        }

        private void btnDefaultFS_Click(object sender, EventArgs e)
        {
            // Define your default font size 
            float defaultFontSize = 9.75f;

            // Update txtBoxFontSize to reflect the default font size
            txtBoxFontSize.Text = defaultFontSize.ToString();

            // Save the default font size to application settings
            Properties.Settings.Default.DataGridViewFontSize = defaultFontSize;
            Properties.Settings.Default.Save();

            // Apply the default font size to UserControlVoting
            userControlVoting.SetDataGridViewFontSize(defaultFontSize);

            // Close the settings form or perform any other necessary actions
            this.Close();
        }

        private void btnSaveRH_Click(object sender, EventArgs e)
        {
            // Read and parse the row height from the TextBox
            if (int.TryParse(txtBoxRH.Text, out int rowHeight))
            {
                // Validate row height (optional: add more validation as needed)
                if (rowHeight > 0)
                {
                    // Save the row height to application settings
                    Properties.Settings.Default.DataGridViewRowHeight = rowHeight;
                    Properties.Settings.Default.Save();

                    // Apply the row height to UserControlVoting
                    userControlVoting.SetDataGridViewRowHeight(rowHeight);

                    MessageBox.Show("Row height saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Row height must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid row height format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the settings form or perform any other necessary actions
            this.Close();
        }


        private void btnDefaultRH_Click(object sender, EventArgs e)
        {
            // Define your default row height
            int defaultRowHeight = 30;

            // Update txtBoxRH to reflect the default row height
            txtBoxRH.Text = defaultRowHeight.ToString();

            // Save the default row height to application settings
            Properties.Settings.Default.DataGridViewRowHeight = defaultRowHeight;
            Properties.Settings.Default.Save();

            // Apply the default row height to UserControlVoting
            userControlVoting.SetDataGridViewRowHeight(defaultRowHeight);

            // Close the settings form or perform any other necessary actions
            this.Close();
        }

        private void labelDltData_Click(object sender, EventArgs e)
        {
            panelDltData.Visible = true;
        }

        private void btnCloseDltDataPanel_Click(object sender, EventArgs e)
        {
            panelDltData.Visible = false;
        }

        private void btnSaveMaxVoteLimit_Click(object sender, EventArgs e)
        {
            // Validate and save the maximum vote limit
            if (int.TryParse(txtBoxVoteLimit.Text, out int maxVoteLimit))
            {
                if (maxVoteLimit > 0)
                {
                    Properties.Settings.Default.MaxVoteLimit = maxVoteLimit;
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Maximum Vote Limit saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("The minimum vote limit is 1. Please enter a value greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid input for Maximum Vote Limit. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/seizue/SDH-Voting/issues";

            try
            {             
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message);
            }
        }

    }

}


