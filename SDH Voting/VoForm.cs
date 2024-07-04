using Newtonsoft.Json;
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
    public partial class SDHVoForm : Form
    {

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private string selectedInvestorId;

        public SDHVoForm(string sdhStockHolder)
        {
            InitializeComponent();
            LoadRepresentatives();
            txtBoxSH.Text = sdhStockHolder;
        }

        private void LoadRepresentatives()
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


        private void LoadData()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
            List<Investor> investors = new List<Investor>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(json))
                {
                    var deserializedInvestors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();

                    // Remove duplicates based on Id
                    investors = deserializedInvestors
                                .GroupBy(i => i.Id)
                                .Select(g => g.First())
                                .ToList();
                }
            }

            // Ensure AutoGenerateColumns is false to prevent automatic column creation
            SelectionVotersGrid.AutoGenerateColumns = false;

            // Set the data source
            SelectionVotersGrid.DataSource = new BindingList<Investor>(investors);

            // Map existing columns to properties
            if (SelectionVotersGrid.Columns["vtrName"] != null)
                SelectionVotersGrid.Columns["vtrName"].DataPropertyName = "Name";
            if (SelectionVotersGrid.Columns["vtrVotes"] != null)
            {
                SelectionVotersGrid.Columns["vtrVotes"].DataPropertyName = "Votes";
                SelectionVotersGrid.Columns["vtrVotes"].DefaultCellStyle.Format = "N0";
            }
            if (SelectionVotersGrid.Columns["vtrStatus"] != null)
                SelectionVotersGrid.Columns["vtrStatus"].DataPropertyName = "Status";
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

        private void labelVoterList_Click(object sender, EventArgs e)
        {
            panelVoterList.Visible = true;
            panel_Indicator.Location = new Point(118, 208);
            panel_Indicator.Size = new Size(71, 3);
            LoadData();
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            panelVoterList.Visible = false;
            panel_Indicator.Location = new Point(27, 208);
            panel_Indicator.Size = new Size(49, 3);
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
                string filePath = Path.Combine(folderPath, "InvestorMasterlist.json");
                List<Investor> investors = new List<Investor>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    investors = JsonConvert.DeserializeObject<List<Investor>>(json) ?? new List<Investor>();
                }

                // Update the status of the selected investor to "YES"
                var investor = investors.FirstOrDefault(i => i.Id == selectedInvestorId);
                if (investor != null)
                {
                    investor.Status = "YES";
                }

                // Save the updated data back to the JSON file
                string updatedJson = JsonConvert.SerializeObject(investors, Formatting.Indented);
                File.WriteAllText(filePath, updatedJson);

                // Save selected data to SDH_VoteSelected.json
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

                // Reload the data to reflect changes in the DataGridView
                LoadData();

                // Close the form 
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }

    
}
