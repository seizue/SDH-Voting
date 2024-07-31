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
    public partial class HistoryDetailedForm : Form
    {

        public HistoryDetailedForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryDetailedForm_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);

            WindowState = FormWindowState.Maximized;
        }
    }
}
