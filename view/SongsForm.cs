using RYHME.Controllers;
using RYHME.Models;
using RYHME.Utils;

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
            LoadSongs();
            LoadAlbums();
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
            int duration;
            int.TryParse(durationTextBox.Text, out duration);
            var song = new Song
            {
                Title = titleTextBox.Text,
                AlbumId = (int)albumComboBox.SelectedValue,
                Duration = duration
            };
            _songController.AddSong(song);
            LoadSongs();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (songsDataGridView.SelectedRows.Count > 0)
            {
                int duration;
                int.TryParse(durationTextBox.Text, out duration);
                var selectedRow = songsDataGridView.SelectedRows[0];
                var song = (Song)selectedRow.DataBoundItem;
                song.Title = titleTextBox.Text;
                song.AlbumId = (int)albumComboBox.SelectedValue;
                song.Duration = duration;
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx) | *.xlsx";
            save.FileName = "Report Songs.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;

                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}");
                    count++;
                }

                Excel excel_lib = new Excel();
                excel_lib.ExportToExcel(songsDataGridView, filePath);

                MessageBox.Show("Data berhasil di export ke excel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
