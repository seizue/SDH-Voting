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
    public partial class UpdateRepForm : Form
    {
        public string RepName { get; private set; }

        public UpdateRepForm(string currentRepName)
        {
            InitializeComponent();
            textBoxRepName.Text = currentRepName;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SaveUpdate_Click(object sender, EventArgs e)
        {
            RepName = textBoxRepName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
