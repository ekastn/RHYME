using System;
using System.Windows.Forms;
using RYHME.model;
using RYHME.Services;

namespace RYHME.view
{
    public partial class ArtistsForm : Form
    {
        //private ArtistService _artistService;

        public ArtistsForm()
        {
            InitializeComponent();
            //_artistService = new ArtistService();
            //LoadArtists();
        }

        //private void LoadArtists()
        //{
        //    var artists = _artistService.GetAllArtists();
        //    artistsDataGridView.DataSource = artists;
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            //var artist = new Artist
            //{
            //    Name = nameTextBox.Text,
            //    Genre = genreTextBox.Text,
            //    Contact = contactTextBox.Text,
            //    ProfilePicture = profilePictureTextBox.Text
            //};

            //_artistService.AddArtist(artist);
            //LoadArtists();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //if (artistsDataGridView.SelectedRows.Count > 0)
            //{
            //    var selectedRow = artistsDataGridView.SelectedRows[0];
            //    var artist = (Artist)selectedRow.DataBoundItem;

            //    artist.Name = nameTextBox.Text;
            //    artist.Genre = genreTextBox.Text;
            //    artist.Contact = contactTextBox.Text;
            //    artist.ProfilePicture = profilePictureTextBox.Text;

            //    _artistService.UpdateArtist(artist);
            //    LoadArtists();
            //}
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //if (artistsDataGridView.SelectedRows.Count > 0)
            //{
            //    var selectedRow = artistsDataGridView.SelectedRows[0];
            //    var artist = (Artist)selectedRow.DataBoundItem;

            //    _artistService.DeleteArtist(artist.Id);
            //    LoadArtists();
            //}
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //var searchTerm = searchTextBox.Text;
            //var artists = _artistService.SearchArtists(searchTerm);
            //artistsDataGridView.DataSource = artists;
        }
    }
}
