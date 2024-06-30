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
        public SDHVoForm()
        {
            InitializeComponent();
            LoadRepresentatives();
        }

        private void LoadRepresentatives()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SDH Voting");
            string filePath = Path.Combine(folderPath, "SDHRep.json");
            List<Representative> representatives = new List<Representative>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                representatives = JsonConvert.DeserializeObject<List<Representative>>(json) ?? new List<Representative>();
            }

            // Populate the ComboBox with the representatives
            comboRep.Items.Clear(); // Clear any existing items
            foreach (var rep in representatives)
            {
                comboRep.Items.Add(rep.Name); 
            }
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

        private void labelVoterList_Click(object sender, EventArgs e)
        {
            panelVoterList.Visible = true;
            panel_Indicator.Location = new Point(118, 208);
            panel_Indicator.Size = new Size(71, 3);
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
            voterSelectionForm.ShowDialog();
        }
    }
}
