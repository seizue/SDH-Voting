﻿namespace SDH_Voting
{
    partial class ViewVotersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVotersForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.ViewGridVoters = new MetroFramework.Controls.MetroGrid();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.labelRepresentative = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sdhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdhVoters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVoters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 8);
            this.panel2.TabIndex = 530;
            // 
            // panelGrid
            // 
            this.panelGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrid.Controls.Add(this.ViewGridVoters);
            this.panelGrid.Controls.Add(this.panel11);
            this.panelGrid.Controls.Add(this.panel10);
            this.panelGrid.Controls.Add(this.panel9);
            this.panelGrid.Controls.Add(this.panel24);
            this.panelGrid.Location = new System.Drawing.Point(12, 77);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(673, 505);
            this.panelGrid.TabIndex = 531;
            // 
            // ViewGridVoters
            // 
            this.ViewGridVoters.AllowUserToAddRows = false;
            this.ViewGridVoters.AllowUserToResizeColumns = false;
            this.ViewGridVoters.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ViewGridVoters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewGridVoters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewGridVoters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ViewGridVoters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewGridVoters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ViewGridVoters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(85)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewGridVoters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ViewGridVoters.ColumnHeadersHeight = 48;
            this.ViewGridVoters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdhID,
            this.sdhVoters});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewGridVoters.DefaultCellStyle = dataGridViewCellStyle3;
            this.ViewGridVoters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewGridVoters.EnableHeadersVisualStyles = false;
            this.ViewGridVoters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ViewGridVoters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ViewGridVoters.Location = new System.Drawing.Point(1, 1);
            this.ViewGridVoters.MultiSelect = false;
            this.ViewGridVoters.Name = "ViewGridVoters";
            this.ViewGridVoters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewGridVoters.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ViewGridVoters.RowHeadersWidth = 5;
            this.ViewGridVoters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75F);
            this.ViewGridVoters.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ViewGridVoters.RowTemplate.Height = 23;
            this.ViewGridVoters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ViewGridVoters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewGridVoters.Size = new System.Drawing.Size(671, 503);
            this.ViewGridVoters.TabIndex = 438;
            this.ViewGridVoters.UseCustomBackColor = true;
            this.ViewGridVoters.UseCustomForeColor = true;
            this.ViewGridVoters.UseStyleColors = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(672, 1);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1, 503);
            this.panel11.TabIndex = 436;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 1);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 503);
            this.panel10.TabIndex = 435;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 504);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(673, 1);
            this.panel9.TabIndex = 434;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(673, 1);
            this.panel24.TabIndex = 433;
            // 
            // labelRepresentative
            // 
            this.labelRepresentative.AutoSize = true;
            this.labelRepresentative.Font = new System.Drawing.Font("Calibri", 11.4F, System.Drawing.FontStyle.Bold);
            this.labelRepresentative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRepresentative.Location = new System.Drawing.Point(141, 38);
            this.labelRepresentative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepresentative.Name = "labelRepresentative";
            this.labelRepresentative.Size = new System.Drawing.Size(14, 19);
            this.labelRepresentative.TabIndex = 534;
            this.labelRepresentative.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 19);
            this.label8.TabIndex = 533;
            this.label8.Text = "REPRESENTATIVE :";
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel13.Location = new System.Drawing.Point(0, 66);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(699, 1);
            this.panel13.TabIndex = 532;
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
            this.btnExportCSV.Location = new System.Drawing.Point(649, 34);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportCSV.Size = new System.Drawing.Size(24, 25);
            this.btnExportCSV.TabIndex = 536;
            this.btnExportCSV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(-1, 592);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 10);
            this.panel3.TabIndex = 537;
            // 
            // sdhID
            // 
            this.sdhID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdhID.DividerWidth = 2;
            this.sdhID.FillWeight = 99.7962F;
            this.sdhID.HeaderText = "ID";
            this.sdhID.Name = "sdhID";
            // 
            // sdhVoters
            // 
            this.sdhVoters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdhVoters.FillWeight = 420F;
            this.sdhVoters.HeaderText = "Shareholders that have Voted";
            this.sdhVoters.Name = "sdhVoters";
            // 
            // ViewVotersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.labelRepresentative);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ViewVotersForm";
            this.Opacity = 0.99D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVoters)).EndInit();
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
        private MetroFramework.Controls.MetroGrid ViewGridVoters;
        private System.Windows.Forms.Label labelRepresentative;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdhVoters;
    }
}