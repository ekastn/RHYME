﻿namespace RYHME
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavigation = new Panel();
            button5 = new Button();
            buttonNavReleases = new Button();
            buttonNavAlbums = new Button();
            buttonNavArtists = new Button();
            buttonNavDashboard = new Button();
            panelChild = new Panel();
            panelTop = new Panel();
            panelNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.Black;
            panelNavigation.Controls.Add(button5);
            panelNavigation.Controls.Add(buttonNavReleases);
            panelNavigation.Controls.Add(buttonNavAlbums);
            panelNavigation.Controls.Add(buttonNavArtists);
            panelNavigation.Controls.Add(buttonNavDashboard);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(190, 563);
            panelNavigation.TabIndex = 0;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 523);
            button5.Name = "button5";
            button5.Padding = new Padding(12, 0, 0, 0);
            button5.Size = new Size(190, 40);
            button5.TabIndex = 2;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // buttonNavReleases
            // 
            buttonNavReleases.AutoSize = true;
            buttonNavReleases.FlatAppearance.BorderSize = 0;
            buttonNavReleases.FlatStyle = FlatStyle.Flat;
            buttonNavReleases.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNavReleases.ForeColor = Color.White;
            buttonNavReleases.Location = new Point(3, 210);
            buttonNavReleases.Name = "buttonNavReleases";
            buttonNavReleases.Padding = new Padding(12, 0, 0, 0);
            buttonNavReleases.Size = new Size(190, 40);
            buttonNavReleases.TabIndex = 1;
            buttonNavReleases.Text = "Releases";
            buttonNavReleases.TextAlign = ContentAlignment.MiddleLeft;
            buttonNavReleases.UseVisualStyleBackColor = true;
            buttonNavReleases.Click += buttonNavReleases_Click;
            // 
            // buttonNavAlbums
            // 
            buttonNavAlbums.AutoSize = true;
            buttonNavAlbums.FlatAppearance.BorderSize = 0;
            buttonNavAlbums.FlatStyle = FlatStyle.Flat;
            buttonNavAlbums.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNavAlbums.ForeColor = Color.White;
            buttonNavAlbums.Location = new Point(3, 169);
            buttonNavAlbums.Name = "buttonNavAlbums";
            buttonNavAlbums.Padding = new Padding(12, 0, 0, 0);
            buttonNavAlbums.Size = new Size(190, 40);
            buttonNavAlbums.TabIndex = 1;
            buttonNavAlbums.Text = "Albums";
            buttonNavAlbums.TextAlign = ContentAlignment.MiddleLeft;
            buttonNavAlbums.UseVisualStyleBackColor = true;
            buttonNavAlbums.Click += buttonNavAlbums_Click;
            // 
            // buttonNavArtists
            // 
            buttonNavArtists.AutoSize = true;
            buttonNavArtists.FlatAppearance.BorderSize = 0;
            buttonNavArtists.FlatStyle = FlatStyle.Flat;
            buttonNavArtists.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNavArtists.ForeColor = Color.White;
            buttonNavArtists.Location = new Point(3, 128);
            buttonNavArtists.Name = "buttonNavArtists";
            buttonNavArtists.Padding = new Padding(12, 0, 0, 0);
            buttonNavArtists.Size = new Size(190, 40);
            buttonNavArtists.TabIndex = 1;
            buttonNavArtists.Text = "Artists";
            buttonNavArtists.TextAlign = ContentAlignment.MiddleLeft;
            buttonNavArtists.UseVisualStyleBackColor = true;
            buttonNavArtists.Click += buttonNavArtists_Click;
            // 
            // buttonNavDashboard
            // 
            buttonNavDashboard.AutoSize = true;
            buttonNavDashboard.FlatAppearance.BorderSize = 0;
            buttonNavDashboard.FlatStyle = FlatStyle.Flat;
            buttonNavDashboard.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNavDashboard.ForeColor = Color.White;
            buttonNavDashboard.Location = new Point(0, 87);
            buttonNavDashboard.Name = "buttonNavDashboard";
            buttonNavDashboard.Padding = new Padding(12, 0, 0, 0);
            buttonNavDashboard.Size = new Size(190, 40);
            buttonNavDashboard.TabIndex = 1;
            buttonNavDashboard.Text = "Dashboard";
            buttonNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonNavDashboard.UseVisualStyleBackColor = true;
            buttonNavDashboard.Click += buttonNavDashboard_Click;
            // 
            // panelChild
            // 
            panelChild.BackColor = SystemColors.GrayText;
            panelChild.Dock = DockStyle.Bottom;
            panelChild.Location = new Point(190, 49);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(733, 514);
            panelChild.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ActiveCaption;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(190, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(733, 51);
            panelTop.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 563);
            Controls.Add(panelTop);
            Controls.Add(panelChild);
            Controls.Add(panelNavigation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "RHYME";
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavigation;
        private Button buttonNavDashboard;
        private Button buttonNavReleases;
        private Button buttonNavAlbums;
        private Button buttonNavArtists;
        private Panel panelChild;
        private Panel panelTop;
        private Button button5;
    }
}
