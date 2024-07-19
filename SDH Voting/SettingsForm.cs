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
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;
        public SettingsForm()
        {
            InitializeComponent();
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
         
            // Save the cleared data to SDH_VoteSelected.json
            SaveSDH_VoteSelectedData();

            // Update the status and reset VoteCount in InvestorMasterlist.json
            UpdateInvestorMasterlistStatus();

            // Empty the data in SDHRep.json
            EmptySDHRepData();

       
            // Optionally, notify the user or perform additional actions
            MessageBox.Show("ALL DATA ARE DELETED PERMANENTLY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateInvestorMasterlistStatus()
        {
            try
            {
                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
                string masterListFilePath = Path.Combine(folderPath, "InvestorMasterlist.json");

                if (File.Exists(masterListFilePath))
                {
                    // Read the JSON data from the file
                    string json = File.ReadAllText(masterListFilePath);

                    // Deserialize the JSON data into a list of investors
                    List<Investor> investors = JsonConvert.DeserializeObject<List<Investor>>(json);

                    // Update the status and reset the VoteCount of all investors
                    foreach (var investor in investors)
                    {
                        investor.Status = "NO";
                        investor.VoteCount = 0;
                    }

                    // Serialize the updated list of investors back to JSON format
                    string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);

                    // Write the updated JSON data back to the file
                    File.WriteAllText(masterListFilePath, updatedJson);
                }
                else
                {
                    MessageBox.Show("InvestorMasterlist.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating InvestorMasterlist status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
