using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SDH_Voting
{
    public partial class HistoryDetailedForm : Form
    {
        public string FolderTitle { get; set; }

        public HistoryDetailedForm()
        {
            InitializeComponent();

            foreach (DataGridViewRow row in GridDetailedHistory.Rows)
            {
                row.Height = 30;
            }
        }


        private void HistoryDetailedForm_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);

            WindowState = FormWindowState.Maximized;

            // Set the label with the folder title
            labelDate.Text = FolderTitle;

            // Load representatives data
            LoadRepresentatives();   
        }


        public void LoadRepresentatives()
        {
            // Base path for the posted folder
            string postedFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting", "Posted");

            // Check for null or empty FolderTitle
            if (string.IsNullOrWhiteSpace(FolderTitle))
            {
                MessageBox.Show("No folder title specified. Unable to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the path based on the folder title selected
            string folderPath = Path.Combine(postedFolderPath, FolderTitle);

            // Check if the folder path exists
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"The folder '{folderPath}' does not exist. Unable to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string filePath = Path.Combine(folderPath, "representative_result.json");

            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"The file '{filePath}' does not exist. Unable to load data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the JSON data
                string jsonData = File.ReadAllText(filePath);
                var histories = JsonConvert.DeserializeObject<List<History>>(jsonData);

                // Clear existing rows
                GridDetailedHistory.Rows.Clear();

                // Add columns if not already added
                SetupDataGridViewColumns();

                // Calculate maximum votes to determine progress percentage
                int maxVotes = histories.Max(h => h.TotalVotes);

                // Populate the DataGridView
                int rowIndex = 0;
                foreach (var history in histories)
                {
                    int progressValue = maxVotes > 0 ? (int)(((double)history.TotalVotes / maxVotes) * 100) : 0;

                    GridDetailedHistory.Rows.Add(
                        rowIndex + 1,
                        history.Representative,
                        FormatNumber(history.TotalVotes),
                        progressValue,
                        history.No_PV
                    );
                    rowIndex++;
                }

                // Optionally, adjust row heights after adding rows if needed
                foreach (DataGridViewRow row in GridDetailedHistory.Rows)
                {
                    row.Height = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading representatives: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int CountActiveCells(int rowIndex)
        {
            int activeCells = 0;
            foreach (DataGridViewCell cell in GridDetailedHistory.Rows[rowIndex].Cells)
            {
                if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                {
                    activeCells++;
                }
            }
            return activeCells;
        }

        private string FormatNumber(int number)
        {
            return number.ToString("#,##0");
        }

        private void SetupDataGridViewColumns()
        {
            // Find the existing "Progress" column
            DataGridViewColumn existingProgressColumn = GridDetailedHistory.Columns["Progress"];

            if (existingProgressColumn is DataGridViewProgressColumn)
            {
                // Set the CellTemplate for existing DataGridViewProgressColumn
                (existingProgressColumn as DataGridViewProgressColumn).CellTemplate = new DataGridViewProgressCell();
            }
        }

        public class DataGridViewProgressColumn : DataGridViewTextBoxColumn
        {
            public DataGridViewProgressColumn() : base()
            {
                CellTemplate = new DataGridViewProgressCell();
            }
        }

        public class DataGridViewProgressCell : DataGridViewTextBoxCell
        {
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

                if (value != null && value is int)
                {
                    int progressVal = (int)value;

                    // Calculate progress bar percentage
                    float percentage = progressVal / 100.0f;

                    // Determine the width of the progress bar
                    int progressBarWidth = (int)(cellBounds.Width * percentage);

                    // Draw the progress bar
                    Brush brush = new SolidBrush(Color.FromArgb(0, 122, 204)); // Choose your progress bar color
                    graphics.FillRectangle(brush, cellBounds.X + 2, cellBounds.Y + 2, progressBarWidth, cellBounds.Height - 4);
                }
            }
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridDetailedHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the View Voters button column
            if (e.RowIndex >= 0 && e.ColumnIndex == GridDetailedHistory.Columns["View"].Index)
            {
                // Get the representative name from the clicked row
                string representativeName = GridDetailedHistory.Rows[e.RowIndex].Cells["Representative"].Value.ToString();

                // Show the ViewVotersForm with the selected representative's voters
                ShowViewVotersForm(representativeName);
            }
        }

        private void ShowViewVotersForm(string representativeName)
        {
            try
            {
                // Instantiate ViewVotersForm with the selected representative's name
                ViewVotersForm viewVotersForm = new ViewVotersForm(representativeName);
                viewVotersForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing voters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
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
                            // Define columns to exclude
                            HashSet<string> columnsToExclude = new HashSet<string> { "Progress" };

                            // Write column headers, excluding specified columns
                            var columnsToWrite = GridDetailedHistory.Columns
                                                 .Cast<DataGridViewColumn>()
                                                 .Where(column => !columnsToExclude.Contains(column.HeaderText.Trim()))
                                                 .ToList();

                            string[] columnHeaders = columnsToWrite.Select(column => column.HeaderText).ToArray();
                            writer.WriteLine(string.Join(",", columnHeaders));

                            // Write rows, excluding data from specified columns
                            foreach (DataGridViewRow row in GridDetailedHistory.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string[] cells = columnsToWrite.Select(column => row.Cells[column.Index].Value?.ToString().Replace(",", string.Empty)).ToArray();
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


    }
}

