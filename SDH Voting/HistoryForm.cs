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
    }
}
