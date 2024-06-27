using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
