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
            btnAddArtist = new Button();
            btnAddAlbum = new Button();
            btnAddSong = new Button();
            SuspendLayout();
            // 
            // lblTotalArtists
            // 
            lblTotalArtists.AutoSize = true;
            lblTotalArtists.Location = new Point(71, 83);
            lblTotalArtists.Margin = new Padding(4, 0, 4, 0);
            lblTotalArtists.Name = "lblTotalArtists";
            lblTotalArtists.Size = new Size(108, 25);
            lblTotalArtists.TabIndex = 0;
            lblTotalArtists.Text = "Total Artists:";
            // 
            // lblTotalAlbums
            // 
            lblTotalAlbums.AutoSize = true;
            lblTotalAlbums.Location = new Point(71, 167);
            lblTotalAlbums.Margin = new Padding(4, 0, 4, 0);
            lblTotalAlbums.Name = "lblTotalAlbums";
            lblTotalAlbums.Size = new Size(119, 25);
            lblTotalAlbums.TabIndex = 1;
            lblTotalAlbums.Text = "Total Albums:";
            // 
            // lblTotalSongs
            // 
            lblTotalSongs.AutoSize = true;
            lblTotalSongs.Location = new Point(71, 250);
            lblTotalSongs.Margin = new Padding(4, 0, 4, 0);
            lblTotalSongs.Name = "lblTotalSongs";
            lblTotalSongs.Size = new Size(108, 25);
            lblTotalSongs.TabIndex = 2;
            lblTotalSongs.Text = "Total Songs:";
            // 
            // lblUpcomingReleases
            // 
            lblUpcomingReleases.AutoSize = true;
            lblUpcomingReleases.Location = new Point(71, 333);
            lblUpcomingReleases.Margin = new Padding(4, 0, 4, 0);
            lblUpcomingReleases.Name = "lblUpcomingReleases";
            lblUpcomingReleases.Size = new Size(170, 25);
            lblUpcomingReleases.TabIndex = 3;
            lblUpcomingReleases.Text = "Upcoming Releases:";
            // 
            // btnAddArtist
            // 
            btnAddArtist.Location = new Point(71, 417);
            btnAddArtist.Margin = new Padding(4, 5, 4, 5);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(143, 38);
            btnAddArtist.TabIndex = 4;
            btnAddArtist.Text = "Add Artist";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Location = new Point(286, 417);
            btnAddAlbum.Margin = new Padding(4, 5, 4, 5);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(143, 38);
            btnAddAlbum.TabIndex = 5;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.Location = new Point(500, 417);
            btnAddSong.Margin = new Padding(4, 5, 4, 5);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(143, 38);
            btnAddSong.TabIndex = 6;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 529);
            Controls.Add(btnAddSong);
            Controls.Add(btnAddAlbum);
            Controls.Add(btnAddArtist);
            Controls.Add(lblUpcomingReleases);
            Controls.Add(lblTotalSongs);
            Controls.Add(lblTotalAlbums);
            Controls.Add(lblTotalArtists);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardForm";
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTotalArtists;
        private System.Windows.Forms.Label lblTotalAlbums;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblUpcomingReleases;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnAddSong;
    }
}
