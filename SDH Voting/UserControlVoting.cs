using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SDH_Voting
{
    public partial class UserControlVoting : UserControl
    {
        public UserControlVoting()
        {
            InitializeComponent();
            LoadRepresentatives(); 

            foreach (DataGridViewRow row in dataGridViewRepresentative.Rows)
            {
                row.Height = 30;
            }
        }

        private void btn_UpdateRep_Click(object sender, EventArgs e)
        {
            UpdateRepForm updateRepForm = new UpdateRepForm();
            updateRepForm.ShowDialog();
        }

        private void btn_VoidRep_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddRepresentative_Click(object sender, EventArgs e)
        {
            AddRepForm addRepForm = new AddRepForm();
            addRepForm.ShowDialog();
            LoadRepresentatives(); // Reload the representatives after adding a new one
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

            // Clear the existing rows
            dataGridViewRepresentative.Rows.Clear();

            // Auto-generate IDs and add representatives to the DataGridView
            for (int i = 0; i < representatives.Count; i++)
            {
                int id = i + 1; // Auto-generate ID starting from 1
                dataGridViewRepresentative.Rows.Add(id, representatives[i].Name, "", "", ""); // Add representative name to the correct column
            }
        }

        private void dataGridViewRepresentative_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Exclude "View" column from showing "-"
            if (dataGridViewRepresentative.Columns[e.ColumnIndex].Name == "View")
            {
                return;
            }

            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "-";
                e.FormattingApplied = true;
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            SDHVoForm votersForm = new SDHVoForm();
            votersForm.ShowDialog();
        }
    }
  
}
