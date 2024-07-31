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
    public partial class HistoryForm : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public HistoryForm()
        {
            InitializeComponent();
            LoadFoldersIntoGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
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

        private void LoadFoldersIntoGrid()
        {
            string postedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "Posted");

            try
            {
                // Get all subdirectories in the Posted folder
                string[] directories = Directory.GetDirectories(postedFolderPath);

                // Clear existing rows in the DataGridView
                GridHistory.Rows.Clear();

                int id = 1; // Initialize ID counter

                foreach (string directory in directories)
                {
                    DirectoryInfo di = new DirectoryInfo(directory);

                    // Extract the folder name and format it
                    string folderName = di.Name;
                    string formattedPostedName = $"Posted_{folderName}";

                    // Create a new row in the DataGridView
                    int rowIndex = GridHistory.Rows.Add(); 
                    DataGridViewRow row = GridHistory.Rows[rowIndex];

                    // Set values for the existing columns
                    row.Cells["sdhID"].Value = id++; 
                    row.Cells["sdhDate"].Value = di.Name; 
                    row.Cells["sdhPosted"].Value = formattedPostedName; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading folders: " + ex.Message);
            }
        }


        private void HistoryForm_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);

            WindowState = FormWindowState.Maximized;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim().ToLower();

            // Loop through all rows in the DataGridView
            foreach (DataGridViewRow row in GridHistory.Rows)
            {
                // Check if the row is a new row (the row used for adding new data, not a data row)
                if (row.IsNewRow) continue;

                // Assuming you want to search in all columns. Adjust as necessary.
                bool rowVisible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        rowVisible = true;
                        break;
                    }
                }

                // Set the row's visibility
                row.Visible = rowVisible;
            }
        }

        private void textBoxSearch_ClearClicked()
        {
            foreach (DataGridViewRow row in GridHistory.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }
        }

        private void historyDate_ValueChanged(object sender, EventArgs e)
        {
            FilterByDate(historyDate.Value);
        }

        private void FilterByDate(DateTime selectedDate)
        {
            foreach (DataGridViewRow row in GridHistory.Rows)
            {
                if (row.IsNewRow) continue;

                // Assuming the date is in the format "yyyyMMdd" or similar. Adjust parsing as necessary.
                if (DateTime.TryParse(row.Cells["sdhDate"].Value?.ToString(), out DateTime rowDate))
                {
                    // Check if the row's date matches the selected date
                    row.Visible = rowDate.Date == selectedDate.Date;
                }
                else
                {
                    row.Visible = false; // Hide rows with invalid or missing dates
                }
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to select the location and file name for the CSV file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Save as CSV";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Write column headers
                            string[] columnHeaders = GridHistory.Columns.Cast<DataGridViewColumn>()
                                                    .Select(column => column.HeaderText)
                                                    .ToArray();
                            writer.WriteLine(string.Join(",", columnHeaders));

                            // Write rows
                            foreach (DataGridViewRow row in GridHistory.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string[] cells = row.Cells.Cast<DataGridViewCell>()
                                                       .Select(cell => cell.Value?.ToString().Replace(",", string.Empty))
                                                       .ToArray();
                                writer.WriteLine(string.Join(",", cells));
                            }
                        }
                        MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while exporting data: " + ex.Message);
                    }
                }
            }
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            HistoryDetailedForm historyDetailedForm = new HistoryDetailedForm();
            historyDetailedForm.ShowDialog();
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
    }
}
