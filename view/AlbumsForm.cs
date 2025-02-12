using RYHME.Controllers;
using RYHME.Models;

namespace RYHME.view
{
    public partial class AlbumsForm : Form
    {
        private readonly AlbumController _albumController;
        private readonly ArtistController _artistController;

        public AlbumsForm(AlbumController albumController, ArtistController artistController)
        {
            _albumController = albumController;
            _artistController = artistController;
            InitializeComponent();
        }

        private void LoadAlbums()
        {
            var albums = _albumController.GetAllAlbums();
            albumsDataGridView.DataSource = albums;
        }

        private void LoadArtists()
        {
            var artists = _artistController.GetAllArtists();
            artistsComboBox.DataSource = artists;
            artistsComboBox.DisplayMember = "Name";
            artistsComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var album = new Album
            {
                Title = titleTextBox.Text,
                ArtistId = (int)artistsComboBox.SelectedValue
            };
            _albumController.AddAlbum(album);
            LoadAlbums();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (albumsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = albumsDataGridView.SelectedRows[0];
                var album = (Album)selectedRow.DataBoundItem;
                album.Title = titleTextBox.Text;
                album.ArtistId = (int)artistsComboBox.SelectedValue;
                _albumController.UpdateAlbum(album);
                LoadAlbums();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (albumsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = albumsDataGridView.SelectedRows[0];
                var album = (Album)selectedRow.DataBoundItem;
                _albumController.DeleteAlbum(album.Id);
                LoadAlbums();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.ToLower();
            var albums = _albumController.GetAllAlbums()
                .Where(a => a.Title.ToLower().Contains(searchText))
                .ToList();
            albumsDataGridView.DataSource = albums;
        }
    }
}
