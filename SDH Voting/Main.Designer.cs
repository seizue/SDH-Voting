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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Export = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button_UpdateUser = new System.Windows.Forms.Button();
            this.button_AddNewUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.InventoryDataGrid = new MetroFramework.Controls.MetroGrid();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(131)))), ((int)(((byte)(91)))));
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
            this.buttonMaximize.Location = new System.Drawing.Point(850, 7);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 62);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(455, 62);
            this.button3.TabIndex = 433;
            this.button3.Text = "VOTING";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(809, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 46);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 11);
            this.panel3.TabIndex = 2;
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
            this.button_Export.Location = new System.Drawing.Point(817, 96);
            this.button_Export.Name = "button_Export";
            this.button_Export.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_Export.Size = new System.Drawing.Size(86, 56);
            this.button_Export.TabIndex = 379;
            this.button_Export.Text = "EXPORT CSV";
            this.button_Export.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Export.UseVisualStyleBackColor = false;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
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
            this.buttonDelete.Location = new System.Drawing.Point(720, 96);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(59, 56);
            this.buttonDelete.TabIndex = 378;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            this.button_UpdateUser.Location = new System.Drawing.Point(640, 96);
            this.button_UpdateUser.Name = "button_UpdateUser";
            this.button_UpdateUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_UpdateUser.Size = new System.Drawing.Size(61, 56);
            this.button_UpdateUser.TabIndex = 377;
            this.button_UpdateUser.Text = "UPDATE ";
            this.button_UpdateUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_UpdateUser.UseVisualStyleBackColor = false;
            this.button_UpdateUser.Click += new System.EventHandler(this.button_UpdateUser_Click);
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
            this.button_AddNewUser.Location = new System.Drawing.Point(547, 96);
            this.button_AddNewUser.Name = "button_AddNewUser";
            this.button_AddNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_AddNewUser.Size = new System.Drawing.Size(87, 56);
            this.button_AddNewUser.TabIndex = 376;
            this.button_AddNewUser.Text = "ADD NEW";
            this.button_AddNewUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AddNewUser.UseVisualStyleBackColor = false;
            this.button_AddNewUser.Click += new System.EventHandler(this.button_AddNewUser_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(456, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 62);
            this.panel4.TabIndex = 430;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(195)))), ((int)(((byte)(237)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(2, 0);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button4.Size = new System.Drawing.Size(453, 62);
            this.button4.TabIndex = 432;
            this.button4.Text = "INVESTORS MASTERLIST";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 62);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(910, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 439);
            this.panel6.TabIndex = 432;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 439);
            this.panel7.TabIndex = 433;
            // 
            // panelGrid
            // 
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
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToResizeColumns = false;
            this.InventoryDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.InventoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.InventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.InventoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InventoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.InventoryDataGrid.ColumnHeadersHeight = 48;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.InventoryDataGrid.EnableHeadersVisualStyles = false;
            this.InventoryDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InventoryDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InventoryDataGrid.Location = new System.Drawing.Point(0, 54);
            this.InventoryDataGrid.MultiSelect = false;
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.InventoryDataGrid.RowHeadersVisible = false;
            this.InventoryDataGrid.RowHeadersWidth = 5;
            this.InventoryDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.InventoryDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.InventoryDataGrid.RowTemplate.Height = 23;
            this.InventoryDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InventoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryDataGrid.Size = new System.Drawing.Size(887, 240);
            this.InventoryDataGrid.TabIndex = 432;
            this.InventoryDataGrid.UseCustomBackColor = true;
            this.InventoryDataGrid.UseCustomForeColor = true;
            this.InventoryDataGrid.UseStyleColors = true;
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
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(280, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(24, 124);
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
            this.txtBoxSearch.Size = new System.Drawing.Size(302, 23);
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
            this.label12.Location = new System.Drawing.Point(24, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 436;
            this.label12.Text = "SEARCH";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 479);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button_AddNewUser);
            this.Controls.Add(this.button_UpdateUser);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_UpdateUser;
        private System.Windows.Forms.Button button_AddNewUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel24;
        private MetroFramework.Controls.MetroGrid InventoryDataGrid;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private System.Windows.Forms.Label label12;
    }
}

