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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
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
            resources.ApplyResources(lblTotalArtists, "lblTotalArtists");
            lblTotalArtists.ForeColor = Color.White;
            lblTotalArtists.Name = "lblTotalArtists";
            // 
            // lblTotalAlbums
            // 
            resources.ApplyResources(lblTotalAlbums, "lblTotalAlbums");
            lblTotalAlbums.ForeColor = Color.White;
            lblTotalAlbums.Name = "lblTotalAlbums";
            // 
            // lblTotalSongs
            // 
            resources.ApplyResources(lblTotalSongs, "lblTotalSongs");
            lblTotalSongs.ForeColor = Color.White;
            lblTotalSongs.Name = "lblTotalSongs";
            // 
            // lblUpcomingReleases
            // 
            resources.ApplyResources(lblUpcomingReleases, "lblUpcomingReleases");
            lblUpcomingReleases.ForeColor = Color.White;
            lblUpcomingReleases.Name = "lblUpcomingReleases";
            // 
            // btnAddArtist
            // 
            resources.ApplyResources(btnAddArtist, "btnAddArtist");
            btnAddArtist.ForeColor = Color.Black;
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnAddAlbum
            // 
            resources.ApplyResources(btnAddAlbum, "btnAddAlbum");
            btnAddAlbum.ForeColor = Color.Black;
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // btnAddSong
            // 
            resources.ApplyResources(btnAddSong, "btnAddSong");
            btnAddSong.ForeColor = Color.Black;
            btnAddSong.Name = "btnAddSong";
            btnAddSong.UseVisualStyleBackColor = true;
            btnAddSong.Click += btnAddSong_Click;
            // 
            // DashboardForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            BackgroundImage = Properties.Resources.loginRegis;
            Controls.Add(btnAddSong);
            Controls.Add(btnAddAlbum);
            Controls.Add(btnAddArtist);
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

        private System.Windows.Forms.Label lblTotalArtists;
        private System.Windows.Forms.Label lblTotalAlbums;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblUpcomingReleases;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnAddSong;
    }
}
