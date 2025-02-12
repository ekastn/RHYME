using RYHME.Controllers;
using RYHME.Models;

namespace RYHME.view
{
    public partial class ArtistsForm : Form
    {
        private readonly ArtistController _artistController;

        public ArtistsForm(ArtistController artistController)
        {
            _artistController = artistController;
            InitializeComponent();
        }

        private void LoadArtists()
        {
            var artists = _artistController.GetAllArtists();
            artistsDataGridView.DataSource = artists;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var artist = new Artist
            {
                Name = nameTextBox.Text,
                Genre = genreTextBox.Text,
                Contact = contactTextBox.Text
            };
            _artistController.AddArtist(artist);
            LoadArtists();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (artistsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = artistsDataGridView.SelectedRows[0];
                var artist = (Artist)selectedRow.DataBoundItem;
                artist.Name = nameTextBox.Text;
                artist.Genre = genreTextBox.Text;
                artist.Contact = contactTextBox.Text;
                _artistController.UpdateArtist(artist);
                LoadArtists();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (artistsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = artistsDataGridView.SelectedRows[0];
                var artist = (Artist)selectedRow.DataBoundItem;
                _artistController.DeleteArtist(artist.Id);
                LoadArtists();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.ToLower();
            var artists = _artistController.GetAllArtists()
                .Where(a => a.Name.ToLower().Contains(searchText))
                .ToList();
            artistsDataGridView.DataSource = artists;
        }
    }
}
