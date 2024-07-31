namespace SDH_Voting
{
    partial class HistoryForm
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
            this.panel20 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.GridHistory = new MetroFramework.Controls.MetroGrid();
            this.sdhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhPosted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Export = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.historyDate = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.panelNav.Controls.Add(this.panel20);
            this.panelNav.Controls.Add(this.buttonClose);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1104, 29);
            this.panelNav.TabIndex = 478;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            this.panelNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseMove);
            this.panelNav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseUp);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkGreen;
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1104, 1);
            this.panel20.TabIndex = 512;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1078, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(14, 14);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.GridHistory);
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Location = new System.Drawing.Point(292, 86);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 585);
            this.panelGrid.TabIndex = 526;
            // 
            // GridHistory
            // 
            this.GridHistory.AllowUserToAddRows = false;
            this.GridHistory.AllowUserToResizeColumns = false;
            this.GridHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GridHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.GridHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridHistory.ColumnHeadersHeight = 48;
            this.GridHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdhID,
            this.sdhPosted,
            this.sdhDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridHistory.EnableHeadersVisualStyles = false;
            this.GridHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridHistory.Location = new System.Drawing.Point(3, 3);
            this.GridHistory.MultiSelect = false;
            this.GridHistory.Name = "GridHistory";
            this.GridHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridHistory.RowHeadersWidth = 5;
            this.GridHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.GridHistory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridHistory.RowTemplate.Height = 23;
            this.GridHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridHistory.Size = new System.Drawing.Size(794, 575);
            this.GridHistory.TabIndex = 437;
            this.GridHistory.UseCustomBackColor = true;
            this.GridHistory.UseCustomForeColor = true;
            this.GridHistory.UseStyleColors = true;
            // 
            // sdhID
            // 
            this.sdhID.DividerWidth = 2;
            this.sdhID.FillWeight = 21.7786F;
            this.sdhID.HeaderText = "ID";
            this.sdhID.Name = "sdhID";
            // 
            // sdhPosted
            // 
            this.sdhPosted.FillWeight = 34.84576F;
            this.sdhPosted.HeaderText = "Posted";
            this.sdhPosted.Name = "sdhPosted";
            // 
            // sdhDate
            // 
            this.sdhDate.FillWeight = 26.13432F;
            this.sdhDate.HeaderText = "Date";
            this.sdhDate.Name = "sdhDate";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(799, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 583);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 583);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 584);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(800, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(800, 1);
            this.panel24.TabIndex = 433;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 8);
            this.panel2.TabIndex = 532;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewData);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button_Export);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 46);
            this.panel1.TabIndex = 533;
            // 
            // btnViewData
            // 
            this.btnViewData.BackColor = System.Drawing.Color.Transparent;
            this.btnViewData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewData.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnViewData.FlatAppearance.BorderSize = 0;
            this.btnViewData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewData.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.btnViewData.ForeColor = System.Drawing.Color.Black;
            this.btnViewData.Image = global::SDH_Voting.Properties.Resources.binoculars_24px;
            this.btnViewData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewData.Location = new System.Drawing.Point(295, 6);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewData.Size = new System.Drawing.Size(98, 33);
            this.btnViewData.TabIndex = 538;
            this.btnViewData.Text = "VIEW DATA";
            this.btnViewData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewData.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(145, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 537;
            this.label9.Text = "LIST";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 19);
            this.label8.TabIndex = 536;
            this.label8.Text = "VOTING HISTORY";
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
            this.button_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Export.Location = new System.Drawing.Point(980, 10);
            this.button_Export.Name = "button_Export";
            this.button_Export.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Export.Size = new System.Drawing.Size(84, 33);
            this.button_Export.TabIndex = 535;
            this.button_Export.Text = "EXPORT";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Export.UseVisualStyleBackColor = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 1);
            this.panel3.TabIndex = 534;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.historyDate);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxSearch);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 597);
            this.panel4.TabIndex = 534;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(26, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 1);
            this.panel5.TabIndex = 517;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 516;
            this.label1.Text = "FILTER DATE";
            // 
            // historyDate
            // 
            this.historyDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.historyDate.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.historyDate.Location = new System.Drawing.Point(28, 43);
            this.historyDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.historyDate.Name = "historyDate";
            this.historyDate.Size = new System.Drawing.Size(233, 25);
            this.historyDate.TabIndex = 515;
            this.historyDate.ValueChanged += new System.EventHandler(this.historyDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 513;
            this.label3.Text = "SEARCH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(71, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 514;
            this.label6.Text = "(History)";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(26, 148);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.ShowButton = true;
            this.textBoxSearch.ShowClearButton = true;
            this.textBoxSearch.Size = new System.Drawing.Size(235, 23);
            this.textBoxSearch.Style = MetroFramework.MetroColorStyle.Silver;
            this.textBoxSearch.TabIndex = 512;
            this.textBoxSearch.UseCustomBackColor = true;
            this.textBoxSearch.UseCustomForeColor = true;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.ClearClicked += new MetroFramework.Controls.MetroTextBox.LUClear(this.textBoxSearch_ClearClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(142)))), ((int)(((byte)(141)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.MintCream;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(26, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(235, 29);
            this.btnSearch.TabIndex = 511;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 680);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.panelNav.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelGrid;
        private MetroFramework.Controls.MetroGrid GridHistory;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroDateTime historyDate;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhPosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhDate;
    }
}