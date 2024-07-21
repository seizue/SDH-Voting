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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUserGrid = new System.Windows.Forms.Panel();
            this.dataGridViewRepresentative = new MetroFramework.Controls.MetroGrid();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroPanel11 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnPosted = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.btn_VoidRep = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btn_AddRepresentative = new System.Windows.Forms.Button();
            this.btnExpandGrid = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.metroPanel16 = new MetroFramework.Controls.MetroPanel();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.panelUserGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepresentative)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserGrid
            // 
            this.panelUserGrid.Controls.Add(this.dataGridViewRepresentative);
            this.panelUserGrid.Controls.Add(this.panel11);
            this.panelUserGrid.Controls.Add(this.panel10);
            this.panelUserGrid.Controls.Add(this.panel9);
            this.panelUserGrid.Controls.Add(this.panel24);
            this.panelUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserGrid.Location = new System.Drawing.Point(0, 77);
            this.panelUserGrid.Name = "panelUserGrid";
            this.panelUserGrid.Size = new System.Drawing.Size(893, 314);
            this.panelUserGrid.TabIndex = 444;
            // 
            // dataGridViewRepresentative
            // 
            this.dataGridViewRepresentative.AllowUserToAddRows = false;
            this.dataGridViewRepresentative.AllowUserToResizeColumns = false;
            this.dataGridViewRepresentative.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewRepresentative.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRepresentative.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.dataGridViewRepresentative.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRepresentative.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewRepresentative.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepresentative.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRepresentative.ColumnHeadersHeight = 48;
            this.dataGridViewRepresentative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRepresentative.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Representative,
            this.TotalVotes,
            this.Progress,
            this.No_PV,
            this.View});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepresentative.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRepresentative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRepresentative.EnableHeadersVisualStyles = false;
            this.dataGridViewRepresentative.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewRepresentative.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewRepresentative.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewRepresentative.MultiSelect = false;
            this.dataGridViewRepresentative.Name = "dataGridViewRepresentative";
            this.dataGridViewRepresentative.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepresentative.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRepresentative.RowHeadersWidth = 5;
            this.dataGridViewRepresentative.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.dataGridViewRepresentative.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRepresentative.RowTemplate.Height = 23;
            this.dataGridViewRepresentative.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRepresentative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepresentative.Size = new System.Drawing.Size(891, 312);
            this.dataGridViewRepresentative.TabIndex = 432;
            this.dataGridViewRepresentative.UseCustomBackColor = true;
            this.dataGridViewRepresentative.UseCustomForeColor = true;
            this.dataGridViewRepresentative.UseStyleColors = true;
            this.dataGridViewRepresentative.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepresentative_CellContentClick);
            this.dataGridViewRepresentative.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewRepresentative_CellFormatting);
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
            this.No_PV.FillWeight = 19.42796F;
            this.No_PV.HeaderText = "No. PV";
            this.No_PV.Name = "No_PV";
            this.No_PV.Width = 150;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.panel11.Location = new System.Drawing.Point(892, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 312);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 312);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 313);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(893, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(893, 1);
            this.panel24.TabIndex = 433;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(818, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 46);
            this.panel2.TabIndex = 439;
            // 
            // metroPanel11
            // 
            this.metroPanel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel11.HorizontalScrollbarBarColor = true;
            this.metroPanel11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel11.HorizontalScrollbarSize = 10;
            this.metroPanel11.Location = new System.Drawing.Point(74, 15);
            this.metroPanel11.Name = "metroPanel11";
            this.metroPanel11.Size = new System.Drawing.Size(1, 40);
            this.metroPanel11.TabIndex = 457;
            this.metroPanel11.UseCustomBackColor = true;
            this.metroPanel11.UseStyleColors = true;
            this.metroPanel11.VerticalScrollbarBarColor = true;
            this.metroPanel11.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel11.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(734, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 46);
            this.panel1.TabIndex = 458;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.metroPanel1);
            this.panelMenu.Controls.Add(this.btnPosted);
            this.panelMenu.Controls.Add(this.metroPanel2);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.button_Export);
            this.panelMenu.Controls.Add(this.btn_VoidRep);
            this.panelMenu.Controls.Add(this.btnChart);
            this.panelMenu.Controls.Add(this.btn_AddRepresentative);
            this.panelMenu.Controls.Add(this.btnExpandGrid);
            this.panelMenu.Controls.Add(this.btnVote);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.metroPanel16);
            this.panelMenu.Controls.Add(this.metroPanel11);
            this.panelMenu.Controls.Add(this.button_Refresh);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(893, 77);
            this.panelMenu.TabIndex = 465;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(649, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 46);
            this.panel3.TabIndex = 469;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(350, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1, 40);
            this.metroPanel1.TabIndex = 468;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnPosted
            // 
            this.btnPosted.BackColor = System.Drawing.Color.White;
            this.btnPosted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPosted.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPosted.FlatAppearance.BorderSize = 0;
            this.btnPosted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosted.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnPosted.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPosted.Image = global::SDH_Voting.Properties.Resources.approval_24px;
            this.btnPosted.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPosted.Location = new System.Drawing.Point(370, 7);
            this.btnPosted.Name = "btnPosted";
            this.btnPosted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPosted.Size = new System.Drawing.Size(57, 51);
            this.btnPosted.TabIndex = 467;
            this.btnPosted.Text = "POSTED";
            this.btnPosted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosted.UseVisualStyleBackColor = false;
            this.btnPosted.Click += new System.EventHandler(this.btnPosted_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(161, 15);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1, 40);
            this.metroPanel2.TabIndex = 464;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::SDH_Voting.Properties.Resources.file_configuration_24pxdd;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(568, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettings.Size = new System.Drawing.Size(71, 51);
            this.btnSettings.TabIndex = 462;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // button_Export
            // 
            this.button_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Export.BackColor = System.Drawing.Color.Transparent;
            this.button_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Export.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Export.FlatAppearance.BorderSize = 0;
            this.button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button_Export.ForeColor = System.Drawing.Color.Black;
            this.button_Export.Image = global::SDH_Voting.Properties.Resources.send_file_24px;
            this.button_Export.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Export.Location = new System.Drawing.Point(825, 8);
            this.button_Export.Name = "button_Export";
            this.button_Export.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Export.Size = new System.Drawing.Size(64, 50);
            this.button_Export.TabIndex = 443;
            this.button_Export.Text = "EXPORT";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Export.UseVisualStyleBackColor = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // btn_VoidRep
            // 
            this.btn_VoidRep.BackColor = System.Drawing.Color.Transparent;
            this.btn_VoidRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_VoidRep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_VoidRep.FlatAppearance.BorderSize = 0;
            this.btn_VoidRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VoidRep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_VoidRep.ForeColor = System.Drawing.Color.Black;
            this.btn_VoidRep.Image = global::SDH_Voting.Properties.Resources.waste_24px;
            this.btn_VoidRep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VoidRep.Location = new System.Drawing.Point(267, 8);
            this.btn_VoidRep.Name = "btn_VoidRep";
            this.btn_VoidRep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_VoidRep.Size = new System.Drawing.Size(64, 50);
            this.btn_VoidRep.TabIndex = 442;
            this.btn_VoidRep.Text = "DELETE";
            this.btn_VoidRep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_VoidRep.UseVisualStyleBackColor = false;
            this.btn_VoidRep.Click += new System.EventHandler(this.btn_VoidRep_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.Transparent;
            this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnChart.ForeColor = System.Drawing.Color.Black;
            this.btnChart.Image = global::SDH_Voting.Properties.Resources.combo_chart_24px11;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChart.Location = new System.Drawing.Point(94, 7);
            this.btnChart.Name = "btnChart";
            this.btnChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChart.Size = new System.Drawing.Size(50, 51);
            this.btnChart.TabIndex = 460;
            this.btnChart.Text = "CHART";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btn_AddRepresentative
            // 
            this.btn_AddRepresentative.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddRepresentative.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddRepresentative.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AddRepresentative.FlatAppearance.BorderSize = 0;
            this.btn_AddRepresentative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRepresentative.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_AddRepresentative.ForeColor = System.Drawing.Color.Black;
            this.btn_AddRepresentative.Image = global::SDH_Voting.Properties.Resources.add_user_male_24px;
            this.btn_AddRepresentative.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_AddRepresentative.Location = new System.Drawing.Point(184, 8);
            this.btn_AddRepresentative.Name = "btn_AddRepresentative";
            this.btn_AddRepresentative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_AddRepresentative.Size = new System.Drawing.Size(64, 50);
            this.btn_AddRepresentative.TabIndex = 440;
            this.btn_AddRepresentative.Text = "ADD NEW";
            this.btn_AddRepresentative.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddRepresentative.UseVisualStyleBackColor = false;
            this.btn_AddRepresentative.Click += new System.EventHandler(this.btn_AddRepresentative_Click);
            // 
            // btnExpandGrid
            // 
            this.btnExpandGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandGrid.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpandGrid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExpandGrid.FlatAppearance.BorderSize = 0;
            this.btnExpandGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandGrid.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.65F, System.Drawing.FontStyle.Bold);
            this.btnExpandGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.btnExpandGrid.Image = global::SDH_Voting.Properties.Resources.Full_Screen_24px;
            this.btnExpandGrid.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpandGrid.Location = new System.Drawing.Point(660, 8);
            this.btnExpandGrid.Name = "btnExpandGrid";
            this.btnExpandGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExpandGrid.Size = new System.Drawing.Size(64, 50);
            this.btnExpandGrid.TabIndex = 459;
            this.btnExpandGrid.Text = "EXPAND ";
            this.btnExpandGrid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExpandGrid.UseVisualStyleBackColor = false;
            this.btnExpandGrid.Click += new System.EventHandler(this.btnExpandGrid_Click);
            // 
            // btnVote
            // 
            this.btnVote.BackColor = System.Drawing.Color.Transparent;
            this.btnVote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVote.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVote.FlatAppearance.BorderSize = 0;
            this.btnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnVote.ForeColor = System.Drawing.Color.Black;
            this.btnVote.Image = global::SDH_Voting.Properties.Resources.zombie_hand_thumbs_up_26px;
            this.btnVote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVote.Location = new System.Drawing.Point(3, 7);
            this.btnVote.Name = "btnVote";
            this.btnVote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVote.Size = new System.Drawing.Size(57, 51);
            this.btnVote.TabIndex = 445;
            this.btnVote.Text = "VOTE";
            this.btnVote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVote.UseVisualStyleBackColor = false;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // metroPanel16
            // 
            this.metroPanel16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel16.HorizontalScrollbarBarColor = true;
            this.metroPanel16.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel16.HorizontalScrollbarSize = 10;
            this.metroPanel16.Location = new System.Drawing.Point(257, 19);
            this.metroPanel16.Name = "metroPanel16";
            this.metroPanel16.Size = new System.Drawing.Size(1, 29);
            this.metroPanel16.TabIndex = 455;
            this.metroPanel16.UseCustomBackColor = true;
            this.metroPanel16.UseStyleColors = true;
            this.metroPanel16.VerticalScrollbarBarColor = true;
            this.metroPanel16.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel16.VerticalScrollbarSize = 10;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Refresh.FlatAppearance.BorderSize = 0;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.65F, System.Drawing.FontStyle.Bold);
            this.button_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.button_Refresh.Image = global::SDH_Voting.Properties.Resources.database_backup_24px;
            this.button_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Refresh.Location = new System.Drawing.Point(744, 8);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Refresh.Size = new System.Drawing.Size(64, 50);
            this.button_Refresh.TabIndex = 447;
            this.button_Refresh.Text = "RFRESH";
            this.button_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // UserControlVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelUserGrid);
            this.Controls.Add(this.panelMenu);
            this.Name = "UserControlVoting";
            this.Size = new System.Drawing.Size(893, 391);
            this.Load += new System.EventHandler(this.UserControlVoting_Load);
            this.panelUserGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepresentative)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUserGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid dataGridViewRepresentative;
        private System.Windows.Forms.Button btn_AddRepresentative;
        private System.Windows.Forms.Button btn_VoidRep;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVote;
        private MetroFramework.Controls.MetroPanel metroPanel11;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button btnExpandGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelMenu;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button btnPosted;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroPanel metroPanel16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVotes;
        private DataGridViewProgressColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_PV;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}
