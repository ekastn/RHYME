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
            this.lblTotalArtists = new System.Windows.Forms.Label();
            this.lblTotalAlbums = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.lblUpcomingReleases = new System.Windows.Forms.Label();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalArtists
            // 
            this.lblTotalArtists.AutoSize = true;
            this.lblTotalArtists.Location = new System.Drawing.Point(50, 50);
            this.lblTotalArtists.Name = "lblTotalArtists";
            this.lblTotalArtists.Size = new System.Drawing.Size(70, 15);
            this.lblTotalArtists.TabIndex = 0;
            this.lblTotalArtists.Text = "Total Artists:";
            // 
            // lblTotalAlbums
            // 
            this.lblTotalAlbums.AutoSize = true;
            this.lblTotalAlbums.Location = new System.Drawing.Point(50, 100);
            this.lblTotalAlbums.Name = "lblTotalAlbums";
            this.lblTotalAlbums.Size = new System.Drawing.Size(75, 15);
            this.lblTotalAlbums.TabIndex = 1;
            this.lblTotalAlbums.Text = "Total Albums:";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Location = new System.Drawing.Point(50, 150);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(70, 15);
            this.lblTotalSongs.TabIndex = 2;
            this.lblTotalSongs.Text = "Total Songs:";
            // 
            // lblUpcomingReleases
            // 
            this.lblUpcomingReleases.AutoSize = true;
            this.lblUpcomingReleases.Location = new System.Drawing.Point(50, 200);
            this.lblUpcomingReleases.Name = "lblUpcomingReleases";
            this.lblUpcomingReleases.Size = new System.Drawing.Size(112, 15);
            this.lblUpcomingReleases.TabIndex = 3;
            this.lblUpcomingReleases.Text = "Upcoming Releases:";
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(50, 250);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(100, 23);
            this.btnAddArtist.TabIndex = 4;
            this.btnAddArtist.Text = "Add Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(200, 250);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(100, 23);
            this.btnAddAlbum.TabIndex = 5;
            this.btnAddAlbum.Text = "Add Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(350, 250);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(100, 23);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.lblUpcomingReleases);
            this.Controls.Add(this.lblTotalSongs);
            this.Controls.Add(this.lblTotalAlbums);
            this.Controls.Add(this.lblTotalArtists);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
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
