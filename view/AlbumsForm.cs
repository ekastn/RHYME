using System;
using System.Windows.Forms;
using RYHME.Services;
using RYHME.model;

namespace RYHME.view
{
    public partial class AlbumsForm : Form
    {
        private readonly AlbumService _albumService;
        private readonly ArtistService _artistService;

        public AlbumsForm()
        {
            InitializeComponent();
            _albumService = new AlbumService();
            _artistService = new ArtistService();
            LoadAlbums();
            LoadArtists();
        }

        private void LoadAlbums()
        {
            var albums = _albumService.GetAllAlbums();
            albumsDataGridView.DataSource = albums;
        }

        private void LoadArtists()
        {
            var artists = _artistService.GetAllArtists();
            artistComboBox.DataSource = artists;
            artistComboBox.DisplayMember = "Name";
            artistComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var album = new Album
            {
                Title = titleTextBox.Text,
                ArtistId = (int)artistComboBox.SelectedValue,
                ReleaseYear = int.Parse(releaseYearTextBox.Text),
                Genre = genreTextBox.Text,
                CoverImage = coverImageTextBox.Text
            };

            _albumService.AddAlbum(album);
            LoadAlbums();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var album = new Album
            {
                Id = int.Parse(idTextBox.Text),
                Title = titleTextBox.Text,
                ArtistId = (int)artistComboBox.SelectedValue,
                ReleaseYear = int.Parse(releaseYearTextBox.Text),
                Genre = genreTextBox.Text,
                CoverImage = coverImageTextBox.Text
            };

            _albumService.UpdateAlbum(album);
            LoadAlbums();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var albumId = int.Parse(idTextBox.Text);
            _albumService.DeleteAlbum(albumId);
            LoadAlbums();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = searchTextBox.Text;
            var albums = _albumService.SearchAlbums(searchTerm);
            albumsDataGridView.DataSource = albums;
        }
    }
}
