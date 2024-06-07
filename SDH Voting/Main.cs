using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class Main : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "InvestorMasterlist.json");
            List<Investor> investors = new List<Investor>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                investors = JsonConvert.DeserializeObject<List<Investor>>(json);
            }

            // Project to view model
            var investorViewModels = investors.Select(i => new InvestorViewModel
            {
                Name = i.Name,
                Votes = i.Votes
            }).ToList();

            InventoryDataGrid.DataSource = investorViewModels;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void button_AddNewUser_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
            LoadData();
        }

        private void button_UpdateUser_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
        }
    }

    public class Investor
    {
        public string Name { get; set; }
        public int Shares { get; set; }
        public int Votes { get; set; }
    }

    public class InvestorViewModel
    {
        public string Name { get; set; }
        public int Votes { get; set; }
    }
}
