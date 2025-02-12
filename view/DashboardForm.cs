using System;
using System.Windows.Forms;
using RYHME.Controllers;
using RYHME.view;

namespace RYHME
{
    public partial class DashboardForm : Form
    {
        private readonly ArtistController _artistController;
        private readonly AlbumController _albumController;
        private readonly SongController _songController;

        public DashboardForm(ArtistController artistController, AlbumController albumController, SongController songController)
        {
            _artistController = artistController;
            _albumController = albumController;
            _songController = songController;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var totalArtists = _artistController.GetAllArtists().Count;
            var totalAlbums = _albumController.GetAllAlbums().Count;
            var totalSongs = _songController.GetAllSongs().Count;
            var upcomingReleases = 3; // Placeholder for actual logic

            lblTotalArtists.Text = $"Total Artists: {totalArtists}";
            lblTotalAlbums.Text = $"Total Albums: {totalAlbums}";
            lblTotalSongs.Text = $"Total Songs: {totalSongs}";
            lblUpcomingReleases.Text = $"Upcoming Releases: {upcomingReleases}";
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var artistsForm = new ArtistsForm(_artistController);
            artistsForm.Show();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            var albumsForm = new AlbumsForm(_albumController, _artistController);
            albumsForm.Show();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            var songsForm = new SongsForm(_songController, _albumController);
            songsForm.Show();
        }
    }
}
