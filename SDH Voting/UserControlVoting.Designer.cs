namespace SDH_Voting
{
    partial class UserControlVoting
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.dataGridViewRepresentative = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelVoting = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnVote = new System.Windows.Forms.Button();
            this.btn_AddRepresentative = new System.Windows.Forms.Button();
            this.btn_UpdateRep = new System.Windows.Forms.Button();
            this.btn_VoidRep = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepresentative)).BeginInit();
            this.panelVoting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Controls.Add(this.dataGridViewRepresentative);
            this.panelGrid.Location = new System.Drawing.Point(1, 70);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(887, 294);
            this.panelGrid.TabIndex = 444;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(886, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 292);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 292);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 293);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(887, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(887, 1);
            this.panel24.TabIndex = 433;
            // 
            // dataGridViewRepresentative
            // 
            this.dataGridViewRepresentative.AllowUserToAddRows = false;
            this.dataGridViewRepresentative.AllowUserToResizeColumns = false;
            this.dataGridViewRepresentative.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewRepresentative.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewRepresentative.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRepresentative.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.dataGridViewRepresentative.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRepresentative.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRepresentative.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepresentative.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewRepresentative.ColumnHeadersHeight = 48;
            this.dataGridViewRepresentative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Representative,
            this.No_PV,
            this.TotalVotes,
            this.View});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepresentative.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewRepresentative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRepresentative.EnableHeadersVisualStyles = false;
            this.dataGridViewRepresentative.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewRepresentative.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewRepresentative.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRepresentative.MultiSelect = false;
            this.dataGridViewRepresentative.Name = "dataGridViewRepresentative";
            this.dataGridViewRepresentative.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepresentative.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewRepresentative.RowHeadersWidth = 5;
            this.dataGridViewRepresentative.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.dataGridViewRepresentative.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewRepresentative.RowTemplate.Height = 23;
            this.dataGridViewRepresentative.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRepresentative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepresentative.Size = new System.Drawing.Size(887, 294);
            this.dataGridViewRepresentative.TabIndex = 432;
            this.dataGridViewRepresentative.UseCustomBackColor = true;
            this.dataGridViewRepresentative.UseCustomForeColor = true;
            this.dataGridViewRepresentative.UseStyleColors = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Representative
            // 
            this.Representative.HeaderText = "Representative";
            this.Representative.Name = "Representative";
            // 
            // No_PV
            // 
            this.No_PV.HeaderText = "No. PV";
            this.No_PV.Name = "No_PV";
            // 
            // TotalVotes
            // 
            this.TotalVotes.HeaderText = "Total Votes";
            this.TotalVotes.Name = "TotalVotes";
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(795, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 46);
            this.panel2.TabIndex = 439;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(88, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 46);
            this.panel1.TabIndex = 446;
            // 
            // panelVoting
            // 
            this.panelVoting.Controls.Add(this.panel12);
            this.panelVoting.Location = new System.Drawing.Point(1, 70);
            this.panelVoting.Name = "panelVoting";
            this.panelVoting.Size = new System.Drawing.Size(893, 297);
            this.panelVoting.TabIndex = 447;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Location = new System.Drawing.Point(129, 3);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(355, 1);
            this.panel12.TabIndex = 457;
            // 
            // btnVote
            // 
            this.btnVote.BackColor = System.Drawing.Color.Transparent;
            this.btnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.btnVote.FlatAppearance.BorderSize = 0;
            this.btnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnVote.ForeColor = System.Drawing.Color.Black;
            this.btnVote.Image = global::SDH_Voting.Properties.Resources.ballot_24px1;
            this.btnVote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVote.Location = new System.Drawing.Point(0, 3);
            this.btnVote.Name = "btnVote";
            this.btnVote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVote.Size = new System.Drawing.Size(87, 56);
            this.btnVote.TabIndex = 445;
            this.btnVote.Text = "VOTE";
            this.btnVote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVote.UseVisualStyleBackColor = false;
            // 
            // btn_AddRepresentative
            // 
            this.btn_AddRepresentative.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddRepresentative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddRepresentative.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.btn_AddRepresentative.FlatAppearance.BorderSize = 0;
            this.btn_AddRepresentative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRepresentative.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_AddRepresentative.ForeColor = System.Drawing.Color.Black;
            this.btn_AddRepresentative.Image = global::SDH_Voting.Properties.Resources.add_user_male_24px;
            this.btn_AddRepresentative.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AddRepresentative.Location = new System.Drawing.Point(113, 3);
            this.btn_AddRepresentative.Name = "btn_AddRepresentative";
            this.btn_AddRepresentative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_AddRepresentative.Size = new System.Drawing.Size(87, 56);
            this.btn_AddRepresentative.TabIndex = 440;
            this.btn_AddRepresentative.Text = "ADD NEW";
            this.btn_AddRepresentative.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddRepresentative.UseVisualStyleBackColor = false;
            this.btn_AddRepresentative.Click += new System.EventHandler(this.btn_AddRepresentative_Click);
            // 
            // btn_UpdateRep
            // 
            this.btn_UpdateRep.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpdateRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_UpdateRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.btn_UpdateRep.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateRep.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdateRep.Image = global::SDH_Voting.Properties.Resources.edit_profile_24px;
            this.btn_UpdateRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_UpdateRep.Location = new System.Drawing.Point(206, 3);
            this.btn_UpdateRep.Name = "btn_UpdateRep";
            this.btn_UpdateRep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_UpdateRep.Size = new System.Drawing.Size(61, 56);
            this.btn_UpdateRep.TabIndex = 441;
            this.btn_UpdateRep.Text = "UPDATE ";
            this.btn_UpdateRep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_UpdateRep.UseVisualStyleBackColor = false;
            this.btn_UpdateRep.Click += new System.EventHandler(this.btn_UpdateRep_Click);
            // 
            // btn_VoidRep
            // 
            this.btn_VoidRep.BackColor = System.Drawing.Color.Transparent;
            this.btn_VoidRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_VoidRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.btn_VoidRep.FlatAppearance.BorderSize = 0;
            this.btn_VoidRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VoidRep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_VoidRep.ForeColor = System.Drawing.Color.Black;
            this.btn_VoidRep.Image = global::SDH_Voting.Properties.Resources.delete_user_male_24px;
            this.btn_VoidRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VoidRep.Location = new System.Drawing.Point(275, 3);
            this.btn_VoidRep.Name = "btn_VoidRep";
            this.btn_VoidRep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_VoidRep.Size = new System.Drawing.Size(59, 56);
            this.btn_VoidRep.TabIndex = 442;
            this.btn_VoidRep.Text = "VOID";
            this.btn_VoidRep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VoidRep.UseVisualStyleBackColor = false;
            this.btn_VoidRep.Click += new System.EventHandler(this.btn_VoidRep_Click);
            // 
            // button_Export
            // 
            this.button_Export.BackColor = System.Drawing.Color.Transparent;
            this.button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Export.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.button_Export.FlatAppearance.BorderSize = 0;
            this.button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button_Export.ForeColor = System.Drawing.Color.Black;
            this.button_Export.Image = global::SDH_Voting.Properties.Resources.send_file_24px;
            this.button_Export.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Export.Location = new System.Drawing.Point(803, 3);
            this.button_Export.Name = "button_Export";
            this.button_Export.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Export.Size = new System.Drawing.Size(86, 56);
            this.button_Export.TabIndex = 443;
            this.button_Export.Text = "EXPORT CSV";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Export.UseVisualStyleBackColor = false;
            // 
            // UserControlVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelVoting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.btn_AddRepresentative);
            this.Controls.Add(this.btn_UpdateRep);
            this.Controls.Add(this.btn_VoidRep);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.panel2);
            this.Name = "UserControlVoting";
            this.Size = new System.Drawing.Size(893, 367);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepresentative)).EndInit();
            this.panelVoting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid dataGridViewRepresentative;
        private System.Windows.Forms.Button btn_AddRepresentative;
        private System.Windows.Forms.Button btn_UpdateRep;
        private System.Windows.Forms.Button btn_VoidRep;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_PV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVotes;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Panel panelVoting;
        private System.Windows.Forms.Panel panel12;
    }
}
