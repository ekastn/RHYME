using System;
using System.Windows.Forms;

namespace RYHME
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Load key statistics and display them on the dashboard
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Example code to load statistics
            lblTotalArtists.Text = "Total Artists: 10";
            lblTotalAlbums.Text = "Total Albums: 5";
            lblTotalSongs.Text = "Total Songs: 20";
            lblUpcomingReleases.Text = "Upcoming Releases: 3";
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            // Open the ArtistsForm to add a new artist
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            // Open the AlbumsForm to add a new album
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.Show();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            // Open the SongsForm to add a new song
            SongsForm songsForm = new SongsForm();
            songsForm.Show();
        }
    }
}
