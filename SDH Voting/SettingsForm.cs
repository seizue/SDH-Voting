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

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
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
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panelNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panelNav_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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
            // Save the selected item of the ComboBox to application settings if it's valid
            if (comBox_WindowState.SelectedItem != null && Enum.IsDefined(typeof(FormWindowState), comBox_WindowState.SelectedItem.ToString()))
            {
                Properties.Settings.Default.MainFormWindowState = comBox_WindowState.SelectedItem.ToString();
                Properties.Settings.Default.Save();

                // Inform the user that changes will reflect after application restart
                MessageBox.Show("Settings saved. Please close and restart the application for the changes to take effect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle invalid state gracefully, for example, by showing a message to the user
                MessageBox.Show("Invalid window state selected. Please select a valid window state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the settings form or perform any other necessary actions
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
        }

    }
}
