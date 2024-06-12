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
    public partial class UserControlVoting : UserControl
    {
        public UserControlVoting()
        {
            InitializeComponent();
        }

       

        private void btn_UpdateRep_Click(object sender, EventArgs e)
        {

        }

        private void btn_VoidRep_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddRepresentative_Click(object sender, EventArgs e)
        {
            AddRepForm addRepForm = new AddRepForm();
            addRepForm.ShowDialog();
        }
    }
}
