namespace RYHME
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTotalArtists = new Label();
            lblTotalAlbums = new Label();
            lblTotalSongs = new Label();
            lblUpcomingReleases = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblTotalArtists
            // 
            lblTotalArtists.AutoSize = true;
            lblTotalArtists.BackColor = Color.Transparent;
            lblTotalArtists.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalArtists.ForeColor = Color.White;
            lblTotalArtists.Location = new Point(414, 262);
            lblTotalArtists.Name = "lblTotalArtists";
            lblTotalArtists.Size = new Size(160, 38);
            lblTotalArtists.TabIndex = 0;
            lblTotalArtists.Text = "Total Artists";
            // 
            // lblTotalAlbums
            // 
            lblTotalAlbums.AutoSize = true;
            lblTotalAlbums.BackColor = Color.Transparent;
            lblTotalAlbums.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAlbums.ForeColor = Color.White;
            lblTotalAlbums.Location = new Point(663, 262);
            lblTotalAlbums.Name = "lblTotalAlbums";
            lblTotalAlbums.Size = new Size(176, 38);
            lblTotalAlbums.TabIndex = 0;
            lblTotalAlbums.Text = "Total Albums";
            // 
            // lblTotalSongs
            // 
            lblTotalSongs.AutoSize = true;
            lblTotalSongs.BackColor = Color.Transparent;
            lblTotalSongs.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSongs.ForeColor = Color.White;
            lblTotalSongs.Location = new Point(414, 338);
            lblTotalSongs.Name = "lblTotalSongs";
            lblTotalSongs.Size = new Size(158, 38);
            lblTotalSongs.TabIndex = 0;
            lblTotalSongs.Text = "Total Songs";
            // 
            // lblUpcomingReleases
            // 
            lblUpcomingReleases.AutoSize = true;
            lblUpcomingReleases.BackColor = Color.Transparent;
            lblUpcomingReleases.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpcomingReleases.ForeColor = Color.White;
            lblUpcomingReleases.Location = new Point(663, 338);
            lblUpcomingReleases.Name = "lblUpcomingReleases";
            lblUpcomingReleases.Size = new Size(246, 38);
            lblUpcomingReleases.TabIndex = 0;
            lblUpcomingReleases.Text = "Upcoming Release";
            // 
            // button1
            // 
            button1.Location = new Point(424, 431);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Add Artist";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAddArtist_Click;
            // 
            // button2
            // 
            button2.Location = new Point(612, 431);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Add Album";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAddAlbum_Click;
            // 
            // button3
            // 
            button3.Location = new Point(797, 431);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 1;
            button3.Text = "Add Song";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAddSong_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.loginRegis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 648);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblUpcomingReleases);
            Controls.Add(lblTotalSongs);
            Controls.Add(lblTotalAlbums);
            Controls.Add(lblTotalArtists);
            DoubleBuffered = true;
            Name = "DashboardForm";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTotalArtists;
        private Label lblTotalAlbums;
        private Label lblTotalSongs;
        private Label lblUpcomingReleases;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
