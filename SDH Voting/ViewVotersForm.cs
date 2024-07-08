using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class ViewVotersForm : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public ViewVotersForm(string representativeName)
        {
            InitializeComponent();
            LoadVoters(representativeName);
        }

        private void LoadVoters(string representativeName)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDH_VoteSelected.json");

            try
            {
                List<string> voters = new List<string>();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    JArray voteData = JArray.Parse(json);

                    // Collect voters for the selected representative
                    foreach (JObject vote in voteData)
                    {
                        string currentRepresentative = vote["Representative"].ToString();
                        string stockHolder = vote["StockHolder"].ToString();

                        if (currentRepresentative.Equals(representativeName, StringComparison.OrdinalIgnoreCase))
                        {
                            voters.Add(stockHolder);
                        }
                    }

                    // Set the representative's name in the label
                    labelRepresentative.Text = $"{representativeName}";

                    // Bind voters data to the DataGridView
                    ViewGridVoters.Rows.Clear();

                    int id = 1;
                    foreach (string voter in voters)
                    {
                        int index = ViewGridVoters.Rows.Add();
                        ViewGridVoters.Rows[index].Cells["sdhID"].Value = id++; // Generate and assign ID
                        ViewGridVoters.Rows[index].Cells["sdhVoters"].Value = voter;
                        // Remove setting the representative's name in the grid as it's now displayed in the label
                        // ViewGridVoters.Rows[index].Cells["sdhRepresentative"].Value = representativeName;
                    }
                }
                else
                {
                    MessageBox.Show("SDH_VoteSelected.json file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading voters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panelNav_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
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

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder csv = new StringBuilder();

                // Get representative's name from the label
                string representativeName = labelRepresentative.Text.Replace("Representative: ", "").Trim();

                // Add header with representative name
                csv.AppendLine($"Representative:,{representativeName}");

                // Add header for voters
                csv.AppendLine("ID,Voter");

                // Add rows
                foreach (DataGridViewRow row in ViewGridVoters.Rows)
                {
                    if (row.Cells["sdhID"].Value != null && row.Cells["sdhVoters"].Value != null)
                    {
                        string id = row.Cells["sdhID"].Value.ToString();
                        string voter = row.Cells["sdhVoters"].Value.ToString();
                        csv.AppendLine($"{id},{voter}");
                    }
                }

                // Generate file name with the representative's name and current date
                string fileName = $"{representativeName}_{DateTime.Now.ToString("yyyy-MM-dd")}.csv";

                // Use SaveFileDialog to choose custom save location
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    Filter = "CSV files (*.csv)|*.csv",
                    Title = "Save Voters List as CSV"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save to the selected file path
                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());

                    MessageBox.Show($"CSV file saved to {saveFileDialog.FileName}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
