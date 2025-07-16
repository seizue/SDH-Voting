namespace SDH_Voting
{
    partial class HistoryDetailedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryDetailedForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.GridDetailedHistory = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new SDH_Voting.UserControlVoting.DataGridViewProgressColumn();
            this.No_PV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxRegisterShares = new System.Windows.Forms.TextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxRegisteredShareholders = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxTotalShareholders = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxTotalShares = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetailedHistory)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 650);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 8);
            this.panel2.TabIndex = 533;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExportCSV);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 43);
            this.panel1.TabIndex = 535;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(159, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 18);
            this.label2.TabIndex = 541;
            this.label2.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(120, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 540;
            this.label6.Text = "(Date)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 539;
            this.label1.Text = "Voting History";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV.BackColor = System.Drawing.Color.Transparent;
            this.btnExportCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportCSV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.65F, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnExportCSV.Image = global::SDH_Voting.Properties.Resources.export_csv_24px1;
            this.btnExportCSV.Location = new System.Drawing.Point(906, 9);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportCSV.Size = new System.Drawing.Size(24, 25);
            this.btnExportCSV.TabIndex = 538;
            this.btnExportCSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelDate.Location = new System.Drawing.Point(178, 12);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(56, 19);
            this.labelDate.TabIndex = 536;
            this.labelDate.Text = "Posted";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 1);
            this.panel3.TabIndex = 534;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.GridDetailedHistory);
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Location = new System.Drawing.Point(12, 85);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(935, 526);
            this.panelGrid.TabIndex = 536;
            // 
            // GridDetailedHistory
            // 
            this.GridDetailedHistory.AllowUserToAddRows = false;
            this.GridDetailedHistory.AllowUserToResizeColumns = false;
            this.GridDetailedHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GridDetailedHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDetailedHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.GridDetailedHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridDetailedHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridDetailedHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetailedHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridDetailedHistory.ColumnHeadersHeight = 48;
            this.GridDetailedHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridDetailedHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Representative,
            this.TotalVotes,
            this.Progress,
            this.No_PV,
            this.View});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDetailedHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridDetailedHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDetailedHistory.EnableHeadersVisualStyles = false;
            this.GridDetailedHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridDetailedHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridDetailedHistory.Location = new System.Drawing.Point(1, 1);
            this.GridDetailedHistory.MultiSelect = false;
            this.GridDetailedHistory.Name = "GridDetailedHistory";
            this.GridDetailedHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetailedHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridDetailedHistory.RowHeadersWidth = 5;
            this.GridDetailedHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.GridDetailedHistory.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridDetailedHistory.RowTemplate.Height = 23;
            this.GridDetailedHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridDetailedHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDetailedHistory.Size = new System.Drawing.Size(933, 524);
            this.GridDetailedHistory.TabIndex = 437;
            this.GridDetailedHistory.UseCustomBackColor = true;
            this.GridDetailedHistory.UseCustomForeColor = true;
            this.GridDetailedHistory.UseStyleColors = true;
            this.GridDetailedHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDetailedHistory_CellContentClick);
            this.GridDetailedHistory.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.GridDetailedHistory_SortCompare);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 19.42796F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 132;
            // 
            // Representative
            // 
            this.Representative.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Representative.FillWeight = 50F;
            this.Representative.HeaderText = "Representative";
            this.Representative.Name = "Representative";
            // 
            // TotalVotes
            // 
            this.TotalVotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalVotes.FillWeight = 50F;
            this.TotalVotes.HeaderText = "Total Votes";
            this.TotalVotes.Name = "TotalVotes";
            // 
            // Progress
            // 
            this.Progress.HeaderText = "Progress";
            this.Progress.Name = "Progress";
            this.Progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Progress.Width = 180;
            // 
            // No_PV
            // 
            this.No_PV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No_PV.DefaultCellStyle = dataGridViewCellStyle3;
            this.No_PV.FillWeight = 19.42796F;
            this.No_PV.HeaderText = "No. PV";
            this.No_PV.Name = "No_PV";
            this.No_PV.Width = 150;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.DefaultCellStyle = dataGridViewCellStyle4;
            this.View.FillWeight = 13F;
            this.View.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.View.HeaderText = "View PV";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.View.Text = "View";
            this.View.ToolTipText = "View People Voted";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 115;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(934, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 524);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 524);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 525);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(935, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(935, 1);
            this.panel24.TabIndex = 433;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.txtboxRegisterShares);
            this.panel12.Controls.Add(this.metroPanel4);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(this.txtboxRegisteredShareholders);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.txtboxTotalShareholders);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.txtboxTotalShares);
            this.panel12.Location = new System.Drawing.Point(-4, 617);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(963, 33);
            this.panel12.TabIndex = 537;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 505;
            this.label3.Text = "Registered Shares";
            // 
            // txtboxRegisterShares
            // 
            this.txtboxRegisterShares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxRegisterShares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRegisterShares.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRegisterShares.Location = new System.Drawing.Point(139, 7);
            this.txtboxRegisterShares.Name = "txtboxRegisterShares";
            this.txtboxRegisterShares.Size = new System.Drawing.Size(79, 19);
            this.txtboxRegisterShares.TabIndex = 504;
            this.txtboxRegisterShares.Text = "-";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel4.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(450, 1);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1, 35);
            this.metroPanel4.TabIndex = 503;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(237, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 14);
            this.label4.TabIndex = 502;
            this.label4.Text = "Registered Shareholders";
            // 
            // txtboxRegisteredShareholders
            // 
            this.txtboxRegisteredShareholders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxRegisteredShareholders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxRegisteredShareholders.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxRegisteredShareholders.Location = new System.Drawing.Point(387, 8);
            this.txtboxRegisteredShareholders.Name = "txtboxRegisteredShareholders";
            this.txtboxRegisteredShareholders.Size = new System.Drawing.Size(42, 19);
            this.txtboxRegisteredShareholders.TabIndex = 501;
            this.txtboxRegisteredShareholders.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(494, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 14);
            this.label5.TabIndex = 499;
            this.label5.Text = "Total Number of Shareholders";
            // 
            // txtboxTotalShareholders
            // 
            this.txtboxTotalShareholders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxTotalShareholders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTotalShareholders.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalShareholders.Location = new System.Drawing.Point(665, 8);
            this.txtboxTotalShareholders.Name = "txtboxTotalShareholders";
            this.txtboxTotalShareholders.Size = new System.Drawing.Size(42, 19);
            this.txtboxTotalShareholders.TabIndex = 498;
            this.txtboxTotalShareholders.Text = "-";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Gainsboro;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(963, 1);
            this.panel13.TabIndex = 497;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(728, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 487;
            this.label7.Text = "Total Number of Shares";
            // 
            // txtboxTotalShares
            // 
            this.txtboxTotalShares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtboxTotalShares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTotalShares.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalShares.Location = new System.Drawing.Point(868, 8);
            this.txtboxTotalShares.Name = "txtboxTotalShares";
            this.txtboxTotalShares.Size = new System.Drawing.Size(79, 19);
            this.txtboxTotalShares.TabIndex = 0;
            this.txtboxTotalShares.Text = "-";
            // 
            // HistoryDetailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 658);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "HistoryDetailedForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.HistoryDetailedForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDetailedHistory)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid GridDetailedHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVotes;
        private UserControlVoting.DataGridViewProgressColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_PV;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxRegisterShares;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxRegisteredShareholders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxTotalShareholders;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxTotalShares;
    }
}