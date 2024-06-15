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
        public AddRepForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveRep_Click(object sender, EventArgs e)
        {
            // Get the representative's name from the textbox
            string repName = textBoxRepName.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(repName))
            {
                MessageBox.Show("Representative name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load existing representatives from the JSON file
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");
            List<Representative> representatives = new List<Representative>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                representatives = JsonConvert.DeserializeObject<List<Representative>>(json) ?? new List<Representative>();
            }

            // Add the new representative to the list
            representatives.Add(new Representative { Name = repName });

            // Save the updated list back to the JSON file
            string updatedJson = JsonConvert.SerializeObject(representatives, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);

            // Notify the user and close the form
            MessageBox.Show("Representative saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

}
