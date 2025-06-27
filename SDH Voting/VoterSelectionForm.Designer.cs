namespace SDH_Voting
{
    partial class VoterSelectionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterSelectionForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.GridVoters = new MetroFramework.Controls.MetroGrid();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.checkBoxShowShareholdersVoted = new MetroFramework.Controls.MetroCheckBox();
            this.sdhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhStockHolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhTotalVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhSelect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVoters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 8);
            this.panel2.TabIndex = 519;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.GridVoters);
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Location = new System.Drawing.Point(12, 113);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(739, 487);
            this.panelGrid.TabIndex = 521;
            // 
            // GridVoters
            // 
            this.GridVoters.AllowUserToAddRows = false;
            this.GridVoters.AllowUserToDeleteRows = false;
            this.GridVoters.AllowUserToResizeColumns = false;
            this.GridVoters.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GridVoters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridVoters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridVoters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridVoters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.GridVoters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridVoters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridVoters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVoters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridVoters.ColumnHeadersHeight = 48;
            this.GridVoters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdhID,
            this.sdhStockHolder,
            this.sdhShares,
            this.sdhTotalVotes,
            this.sdhSelect});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridVoters.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridVoters.EnableHeadersVisualStyles = false;
            this.GridVoters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridVoters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridVoters.Location = new System.Drawing.Point(3, 3);
            this.GridVoters.MultiSelect = false;
            this.GridVoters.Name = "GridVoters";
            this.GridVoters.ReadOnly = true;
            this.GridVoters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridVoters.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridVoters.RowHeadersWidth = 5;
            this.GridVoters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            this.GridVoters.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridVoters.RowTemplate.Height = 23;
            this.GridVoters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridVoters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridVoters.Size = new System.Drawing.Size(733, 477);
            this.GridVoters.TabIndex = 437;
            this.GridVoters.UseCustomBackColor = true;
            this.GridVoters.UseCustomForeColor = true;
            this.GridVoters.UseStyleColors = true;
            this.GridVoters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVoters_CellContentClick);
            this.GridVoters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVoters_CellDoubleClick);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(738, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 485);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 485);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 486);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(739, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(739, 1);
            this.panel24.TabIndex = 433;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(20, 77);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.ShowButton = true;
            this.txtBoxSearch.ShowClearButton = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(233, 23);
            this.txtBoxSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtBoxSearch.TabIndex = 522;
            this.txtBoxSearch.UseCustomBackColor = true;
            this.txtBoxSearch.UseCustomForeColor = true;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtBoxSearch_ButtonClick);
            this.txtBoxSearch.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.txtBoxSearch_ClearClicked);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(129, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 524;
            this.label9.Text = "LIST";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 523;
            this.label8.Text = "SHAREHOLDERS";
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Location = new System.Drawing.Point(-4, 64);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(769, 1);
            this.panel13.TabIndex = 522;
            // 
            // checkBoxShowShareholdersVoted
            // 
            this.checkBoxShowShareholdersVoted.AutoSize = true;
            this.checkBoxShowShareholdersVoted.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkBoxShowShareholdersVoted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxShowShareholdersVoted.Location = new System.Drawing.Point(283, 81);
            this.checkBoxShowShareholdersVoted.Name = "checkBoxShowShareholdersVoted";
            this.checkBoxShowShareholdersVoted.Size = new System.Drawing.Size(132, 15);
            this.checkBoxShowShareholdersVoted.TabIndex = 525;
            this.checkBoxShowShareholdersVoted.TabStop = false;
            this.checkBoxShowShareholdersVoted.Text = "Shareholders Voted";
            this.checkBoxShowShareholdersVoted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowShareholdersVoted.UseCustomBackColor = true;
            this.checkBoxShowShareholdersVoted.UseCustomForeColor = true;
            this.checkBoxShowShareholdersVoted.UseSelectable = true;
            this.checkBoxShowShareholdersVoted.CheckedChanged += new System.EventHandler(this.checkBoxShowShareholdersVoted_CheckedChanged);
            // 
            // sdhID
            // 
            this.sdhID.FillWeight = 15F;
            this.sdhID.HeaderText = "ID";
            this.sdhID.Name = "sdhID";
            this.sdhID.ReadOnly = true;
            // 
            // sdhStockHolder
            // 
            this.sdhStockHolder.FillWeight = 34.84576F;
            this.sdhStockHolder.HeaderText = "Stock Holder Name";
            this.sdhStockHolder.Name = "sdhStockHolder";
            this.sdhStockHolder.ReadOnly = true;
            // 
            // sdhShares
            // 
            this.sdhShares.FillWeight = 26.13432F;
            this.sdhShares.HeaderText = "Shares";
            this.sdhShares.Name = "sdhShares";
            this.sdhShares.ReadOnly = true;
            // 
            // sdhTotalVotes
            // 
            this.sdhTotalVotes.FillWeight = 30.49004F;
            this.sdhTotalVotes.HeaderText = "Equal Votes";
            this.sdhTotalVotes.Name = "sdhTotalVotes";
            this.sdhTotalVotes.ReadOnly = true;
            // 
            // sdhSelect
            // 
            this.sdhSelect.FillWeight = 15F;
            this.sdhSelect.HeaderText = "Select";
            this.sdhSelect.Name = "sdhSelect";
            this.sdhSelect.ReadOnly = true;
            this.sdhSelect.Text = "Select";
            this.sdhSelect.UseColumnTextForButtonValue = true;
            // 
            // VoterSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 616);
            this.Controls.Add(this.checkBoxShowShareholdersVoted);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "VoterSelectionForm";
            this.Opacity = 0.99D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VoterSelectionForm_FormClosed);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVoters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid GridVoters;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel13;
        private MetroFramework.Controls.MetroCheckBox checkBoxShowShareholdersVoted;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhStockHolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhTotalVotes;
        private System.Windows.Forms.DataGridViewButtonColumn sdhSelect;
    }
}