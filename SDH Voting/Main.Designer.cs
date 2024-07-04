namespace SDH_Voting
{
    partial class Main
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnCloseFP = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.btnVoting = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInvMasterlist = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.InventoryDataGrid = new MetroFramework.Controls.MetroGrid();
            this.invID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxName = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxVotes = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel16 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBoxId = new MetroFramework.Controls.MetroCheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlVoting1 = new SDH_Voting.UserControlVoting();
            this.button_AddNewUser = new System.Windows.Forms.Button();
            this.button_UpdateUser = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.panelNav.Controls.Add(this.btnCloseFP);
            this.panelNav.Controls.Add(this.buttonMinimize);
            this.panelNav.Controls.Add(this.buttonMaximize);
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(911, 29);
            this.panelNav.TabIndex = 0;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            this.panelNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseMove);
            this.panelNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseUp);
            // 
            // btnCloseFP
            // 
            this.btnCloseFP.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.btnCloseFP.FlatAppearance.BorderSize = 0;
            this.btnCloseFP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCloseFP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFP.Image = global::SDH_Voting.Properties.Resources.restore_window_24px4;
            this.btnCloseFP.Location = new System.Drawing.Point(6, 2);
            this.btnCloseFP.Name = "btnCloseFP";
            this.btnCloseFP.Size = new System.Drawing.Size(23, 22);
            this.btnCloseFP.TabIndex = 7;
            this.btnCloseFP.UseVisualStyleBackColor = false;
            this.btnCloseFP.Visible = false;
            this.btnCloseFP.Click += new System.EventHandler(this.btnCloseFP_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(816, 7);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(14, 14);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(103)))));
            this.buttonMaximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(851, 7);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(14, 14);
            this.buttonMaximize.TabIndex = 5;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(885, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(14, 14);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // btnVoting
            // 
            this.btnVoting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(123)))), ((int)(((byte)(108)))));
            this.btnVoting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVoting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.btnVoting.FlatAppearance.BorderSize = 0;
            this.btnVoting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(123)))), ((int)(((byte)(108)))));
            this.btnVoting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoting.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoting.ForeColor = System.Drawing.Color.Beige;
            this.btnVoting.Location = new System.Drawing.Point(3, 3);
            this.btnVoting.Name = "btnVoting";
            this.btnVoting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVoting.Size = new System.Drawing.Size(449, 47);
            this.btnVoting.TabIndex = 433;
            this.btnVoting.Text = "VOTING";
            this.btnVoting.UseVisualStyleBackColor = false;
            this.btnVoting.Click += new System.EventHandler(this.btnVoting_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(806, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 46);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 11);
            this.panel3.TabIndex = 2;
            // 
            // btnInvMasterlist
            // 
            this.btnInvMasterlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(162)))), ((int)(((byte)(143)))));
            this.btnInvMasterlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvMasterlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvMasterlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.btnInvMasterlist.FlatAppearance.BorderSize = 0;
            this.btnInvMasterlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(123)))), ((int)(((byte)(108)))));
            this.btnInvMasterlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvMasterlist.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.btnInvMasterlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(42)))));
            this.btnInvMasterlist.Location = new System.Drawing.Point(458, 3);
            this.btnInvMasterlist.Name = "btnInvMasterlist";
            this.btnInvMasterlist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInvMasterlist.Size = new System.Drawing.Size(450, 47);
            this.btnInvMasterlist.TabIndex = 432;
            this.btnInvMasterlist.Text = "INVESTORS MASTERLIST";
            this.btnInvMasterlist.UseVisualStyleBackColor = false;
            this.btnInvMasterlist.Click += new System.EventHandler(this.btnInvMasterlist_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Location = new System.Drawing.Point(910, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 382);
            this.panel6.TabIndex = 432;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Controls.Add(this.InventoryDataGrid);
            this.panelGrid.Location = new System.Drawing.Point(12, 165);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(887, 294);
            this.panelGrid.TabIndex = 434;
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
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToResizeColumns = false;
            this.InventoryDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InventoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.InventoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InventoryDataGrid.ColumnHeadersHeight = 48;
            this.InventoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invID,
            this.invName,
            this.invVotes,
            this.invShares,
            this.invStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.InventoryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryDataGrid.EnableHeadersVisualStyles = false;
            this.InventoryDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryDataGrid.Location = new System.Drawing.Point(0, 0);
            this.InventoryDataGrid.MultiSelect = false;
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InventoryDataGrid.RowHeadersWidth = 5;
            this.InventoryDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.InventoryDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.InventoryDataGrid.RowTemplate.Height = 23;
            this.InventoryDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDataGrid.Size = new System.Drawing.Size(887, 294);
            this.InventoryDataGrid.TabIndex = 432;
            this.InventoryDataGrid.UseCustomBackColor = true;
            this.InventoryDataGrid.UseCustomForeColor = true;
            this.InventoryDataGrid.UseStyleColors = true;
            // 
            // invID
            // 
            this.invID.HeaderText = "ID";
            this.invID.Name = "invID";
            // 
            // invName
            // 
            this.invName.HeaderText = "Name";
            this.invName.Name = "invName";
            // 
            // invVotes
            // 
            this.invVotes.HeaderText = "Votes";
            this.invVotes.Name = "invVotes";
            // 
            // invShares
            // 
            this.invShares.HeaderText = "Equal Shares";
            this.invShares.Name = "invShares";
            // 
            // invStatus
            // 
            this.invStatus.HeaderText = "Status";
            this.invStatus.Name = "invStatus";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(24, 121);
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
            this.txtBoxSearch.Size = new System.Drawing.Size(251, 23);
            this.txtBoxSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.txtBoxSearch.TabIndex = 435;
            this.txtBoxSearch.UseCustomBackColor = true;
            this.txtBoxSearch.UseCustomForeColor = true;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtBoxSearch_ButtonClick);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(23, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 436;
            this.label12.Text = "SEARCH";
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkBoxName.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxName.Location = new System.Drawing.Point(354, 129);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(56, 15);
            this.checkBoxName.TabIndex = 437;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseCustomBackColor = true;
            this.checkBoxName.UseCustomForeColor = true;
            this.checkBoxName.UseSelectable = true;
            // 
            // checkBoxVotes
            // 
            this.checkBoxVotes.AutoSize = true;
            this.checkBoxVotes.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkBoxVotes.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxVotes.Location = new System.Drawing.Point(427, 129);
            this.checkBoxVotes.Name = "checkBoxVotes";
            this.checkBoxVotes.Size = new System.Drawing.Size(54, 15);
            this.checkBoxVotes.TabIndex = 438;
            this.checkBoxVotes.Text = "Votes";
            this.checkBoxVotes.UseCustomBackColor = true;
            this.checkBoxVotes.UseCustomForeColor = true;
            this.checkBoxVotes.UseSelectable = true;
            // 
            // metroPanel16
            // 
            this.metroPanel16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel16.HorizontalScrollbarBarColor = true;
            this.metroPanel16.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel16.HorizontalScrollbarSize = 10;
            this.metroPanel16.Location = new System.Drawing.Point(721, 106);
            this.metroPanel16.Name = "metroPanel16";
            this.metroPanel16.Size = new System.Drawing.Size(1, 29);
            this.metroPanel16.TabIndex = 456;
            this.metroPanel16.UseCustomBackColor = true;
            this.metroPanel16.UseStyleColors = true;
            this.metroPanel16.VerticalScrollbarBarColor = true;
            this.metroPanel16.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel16.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.metroPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(644, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1, 29);
            this.metroPanel1.TabIndex = 457;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel7.Location = new System.Drawing.Point(0, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 382);
            this.panel7.TabIndex = 460;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.checkBoxId.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxId.Location = new System.Drawing.Point(299, 129);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(36, 15);
            this.checkBoxId.TabIndex = 461;
            this.checkBoxId.Text = "ID";
            this.checkBoxId.UseCustomBackColor = true;
            this.checkBoxId.UseCustomForeColor = true;
            this.checkBoxId.UseSelectable = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Location = new System.Drawing.Point(553, 101);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 46);
            this.panel8.TabIndex = 462;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnVoting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInvMasterlist, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 53);
            this.tableLayoutPanel1.TabIndex = 438;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(84)))));
            this.panel1.Location = new System.Drawing.Point(454, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 52);
            this.panel1.TabIndex = 464;
            // 
            // userControlVoting1
            // 
            this.userControlVoting1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlVoting1.BackColor = System.Drawing.Color.White;
            this.userControlVoting1.Location = new System.Drawing.Point(11, 83);
            this.userControlVoting1.Name = "userControlVoting1";
            this.userControlVoting1.Size = new System.Drawing.Size(893, 382);
            this.userControlVoting1.TabIndex = 437;
            // 
            // button_AddNewUser
            // 
            this.button_AddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.button_AddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.button_AddNewUser.FlatAppearance.BorderSize = 0;
            this.button_AddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddNewUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button_AddNewUser.ForeColor = System.Drawing.Color.Black;
            this.button_AddNewUser.Image = global::SDH_Voting.Properties.Resources.add_user_male_24px;
            this.button_AddNewUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AddNewUser.Location = new System.Drawing.Point(574, 97);
            this.button_AddNewUser.Name = "button_AddNewUser";
            this.button_AddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_AddNewUser.Size = new System.Drawing.Size(64, 50);
            this.button_AddNewUser.TabIndex = 376;
            this.button_AddNewUser.Text = "ADD NEW";
            this.button_AddNewUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AddNewUser.UseVisualStyleBackColor = false;
            this.button_AddNewUser.Click += new System.EventHandler(this.button_AddNewUser_Click);
            // 
            // button_UpdateUser
            // 
            this.button_UpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.button_UpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_UpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.button_UpdateUser.FlatAppearance.BorderSize = 0;
            this.button_UpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateUser.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button_UpdateUser.ForeColor = System.Drawing.Color.Black;
            this.button_UpdateUser.Image = global::SDH_Voting.Properties.Resources.edit_profile_24px;
            this.button_UpdateUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_UpdateUser.Location = new System.Drawing.Point(651, 96);
            this.button_UpdateUser.Name = "button_UpdateUser";
            this.button_UpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_UpdateUser.Size = new System.Drawing.Size(64, 50);
            this.button_UpdateUser.TabIndex = 377;
            this.button_UpdateUser.Text = "UPDATE ";
            this.button_UpdateUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_UpdateUser.UseVisualStyleBackColor = false;
            this.button_UpdateUser.Click += new System.EventHandler(this.button_UpdateUser_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = global::SDH_Voting.Properties.Resources.waste_24px;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete.Location = new System.Drawing.Point(728, 97);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(64, 50);
            this.buttonDelete.TabIndex = 378;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.button_Export.Location = new System.Drawing.Point(829, 97);
            this.button_Export.Name = "button_Export";
            this.button_Export.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Export.Size = new System.Drawing.Size(64, 50);
            this.button_Export.TabIndex = 379;
            this.button_Export.Text = "EXPORT";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Export.UseVisualStyleBackColor = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.userControlVoting1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel16);
            this.Controls.Add(this.checkBoxVotes);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button_AddNewUser);
            this.Controls.Add(this.button_UpdateUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.checkBoxId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelNav.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_UpdateUser;
        private System.Windows.Forms.Button button_AddNewUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVoting;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid InventoryDataGrid;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroCheckBox checkBoxName;
        private MetroFramework.Controls.MetroCheckBox checkBoxVotes;
        private UserControlVoting userControlVoting1;
        private MetroFramework.Controls.MetroPanel metroPanel16;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnInvMasterlist;
        private MetroFramework.Controls.MetroCheckBox checkBoxId;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invID;
        private System.Windows.Forms.DataGridViewTextBoxColumn invName;
        private System.Windows.Forms.DataGridViewTextBoxColumn invVotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn invShares;
        private System.Windows.Forms.DataGridViewTextBoxColumn invStatus;
        private System.Windows.Forms.Button btnCloseFP;
    }
}

