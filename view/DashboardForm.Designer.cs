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
            lblTotalArtists.ForeColor = Color.White;
            lblTotalArtists.Location = new Point(57, 66);
            lblTotalArtists.Name = "lblTotalArtists";
            lblTotalArtists.Size = new Size(90, 20);
            lblTotalArtists.TabIndex = 0;
            lblTotalArtists.Text = "Total Artists:";
            // 
            // lblTotalAlbums
            // 
            lblTotalAlbums.AutoSize = true;
            lblTotalAlbums.ForeColor = Color.White;
            lblTotalAlbums.Location = new Point(57, 134);
            lblTotalAlbums.Name = "lblTotalAlbums";
            lblTotalAlbums.Size = new Size(99, 20);
            lblTotalAlbums.TabIndex = 1;
            lblTotalAlbums.Text = "Total Albums:";
            // 
            // lblTotalSongs
            // 
            lblTotalSongs.AutoSize = true;
            lblTotalSongs.ForeColor = Color.White;
            lblTotalSongs.Location = new Point(57, 200);
            lblTotalSongs.Name = "lblTotalSongs";
            lblTotalSongs.Size = new Size(89, 20);
            lblTotalSongs.TabIndex = 2;
            lblTotalSongs.Text = "Total Songs:";
            // 
            // lblUpcomingReleases
            // 
            lblUpcomingReleases.AutoSize = true;
            lblUpcomingReleases.ForeColor = Color.White;
            lblUpcomingReleases.Location = new Point(57, 266);
            lblUpcomingReleases.Name = "lblUpcomingReleases";
            lblUpcomingReleases.Size = new Size(142, 20);
            lblUpcomingReleases.TabIndex = 3;
            lblUpcomingReleases.Text = "Upcoming Releases:";
            // 
            // btnAddArtist
            // 
            btnAddArtist.ForeColor = Color.Black;
            btnAddArtist.Location = new Point(57, 334);
            btnAddArtist.Margin = new Padding(3, 4, 3, 4);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(114, 30);
            btnAddArtist.TabIndex = 4;
            btnAddArtist.Text = "Add Artist";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.ForeColor = Color.Black;
            btnAddAlbum.Location = new Point(229, 334);
            btnAddAlbum.Margin = new Padding(3, 4, 3, 4);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(114, 30);
            btnAddAlbum.TabIndex = 5;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // btnAddSong
            // 
            btnAddSong.ForeColor = Color.Black;
            btnAddSong.Location = new Point(400, 334);
            btnAddSong.Margin = new Padding(3, 4, 3, 4);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new Size(114, 30);
            btnAddSong.TabIndex = 6;
            btnAddSong.Text = "Add Song";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.Desain_tanpa_judul;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(691, 441);
            Controls.Add(btnAddSong);
            Controls.Add(btnAddAlbum);
            Controls.Add(btnAddArtist);
            Controls.Add(lblUpcomingReleases);
            Controls.Add(lblTotalSongs);
            Controls.Add(lblTotalAlbums);
            Controls.Add(lblTotalArtists);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
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
