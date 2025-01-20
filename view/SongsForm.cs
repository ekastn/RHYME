using System;
using System.Windows.Forms;
using RYHME.Services;
using RYHME.model;

namespace RYHME.view
{
    public partial class SongsForm : Form
    {
        private readonly SongService _songService;
        private readonly AlbumService _albumService;

        public SongsForm()
        {
            InitializeComponent();
            _songService = new SongService();
            _albumService = new AlbumService();
            LoadSongs();
            LoadAlbums();
        }

        private void LoadSongs()
        {
            var songs = _songService.GetAllSongs();
            songsDataGridView.DataSource = songs;
        }

        private void LoadAlbums()
        {
            var albums = _albumService.GetAllAlbums();
            albumComboBox.DataSource = albums;
            albumComboBox.DisplayMember = "Title";
            albumComboBox.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var song = new Song
            {
                Title = titleTextBox.Text,
                AlbumId = (int)albumComboBox.SelectedValue,
                Duration = TimeSpan.Parse(durationTextBox.Text),
                Lyrics = lyricsTextBox.Text
            };

            _songService.AddSong(song);
            LoadSongs();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var song = new Song
            {
                Id = int.Parse(idTextBox.Text),
                Title = titleTextBox.Text,
                AlbumId = (int)albumComboBox.SelectedValue,
                Duration = TimeSpan.Parse(durationTextBox.Text),
                Lyrics = lyricsTextBox.Text
            };

            _songService.UpdateSong(song);
            LoadSongs();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var songId = int.Parse(idTextBox.Text);
            _songService.DeleteSong(songId);
            LoadSongs();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = searchTextBox.Text;
            var songs = _songService.SearchSongs(searchTerm);
            songsDataGridView.DataSource = songs;
        }
    }
}
