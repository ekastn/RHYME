using RYHME.Controllers;

namespace RYHME.view
{
    public partial class SongsForm : Form
    {
        private readonly SongController _songController;
        private readonly AlbumController _albumController;

        public SongsForm(SongController songController, AlbumController albumController)
        {
            _songController = songController;
            _albumController = albumController;
            InitializeComponent();
        }

        private void LoadSongs()
        {
            var songs = _songController.GetAllSongs();
            songsDataGridView.DataSource = songs;
        }

        private void LoadAlbums()
        {
            var albums = _albumController.GetAllAlbums();
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
                Duration = TimeSpan.Parse(durationTextBox.Text)
            };
            _songController.AddSong(song);
            LoadSongs();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (songsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = songsDataGridView.SelectedRows[0];
                var song = (Song)selectedRow.DataBoundItem;
                song.Title = titleTextBox.Text;
                song.AlbumId = (int)albumComboBox.SelectedValue;
                song.Duration = TimeSpan.Parse(durationTextBox.Text);
                _songController.UpdateSong(song);
                LoadSongs();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (songsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = songsDataGridView.SelectedRows[0];
                var song = (Song)selectedRow.DataBoundItem;
                _songController.DeleteSong(song.Id);
                LoadSongs();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.ToLower();
            var songs = _songController.GetAllSongs()
                .Where(s => s.Title.ToLower().Contains(searchText))
                .ToList();
            songsDataGridView.DataSource = songs;
        }
    }
}
