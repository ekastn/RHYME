using RYHME.Controllers;
using RYHME.Models;
using RYHME.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RYHME.view
{
    public partial class ReleasesForm : Form
    {
        private readonly ReleaseController _releaseController;
        private readonly AlbumController _albumController;
        private readonly SongController _songController;

        private List<Album> _albums;
        private List<Song> _songs;

        public ReleasesForm(ReleaseController releaseController,
            AlbumController albumController,
            SongController songController)
        {
            _releaseController = releaseController;
            _albumController = albumController;
            _songController = songController;

            InitializeComponent();
            LoadReleases();
            LoadAlbumsAndSongs();
        }

        private void LoadReleases()
        {
            var releases = _releaseController.GetAllReleases();
            releasesDataGridView.DataSource = releases;
        }

        private void LoadAlbumsAndSongs()
        {
            _albums = _albumController.GetAllAlbums();
            _songs = _songController.GetAllSongs();
            albumOrSongComboBox.Items.Clear();
            albumOrSongComboBox.Items.AddRange(_albums.ToArray());
            albumOrSongComboBox.Items.AddRange(_songs.ToArray());
            albumOrSongComboBox.DisplayMember = "Title";
            albumOrSongComboBox.ValueMember = "Id";
        }

        private void DisplayAlbums()
        {
            albumOrSongComboBox.Items.Clear();
            albumOrSongComboBox.Items.AddRange(_albums.ToArray());
            albumOrSongComboBox.DisplayMember = "Title";
            albumOrSongComboBox.ValueMember = "Id";
        }

        private void DisplaySongs()
        {
            albumOrSongComboBox.Items.Clear();
            albumOrSongComboBox.Items.AddRange(_songs.ToArray());
            albumOrSongComboBox.DisplayMember = "Title";
            albumOrSongComboBox.ValueMember = "Id";
        }

        private void addReleaseButton_Click(object sender, EventArgs e)
        {

            Album? album = null;
            Song? song = null;

            if (typeComboBox.SelectedItem.ToString() == "Album")
            {
                album = (Album?)albumOrSongComboBox.SelectedItem;
            }
            else if (typeComboBox.SelectedItem.ToString() == "Single")
            {
                song = (Song?)albumOrSongComboBox.SelectedItem;
            }

            if (ValidateRelease())
            {
                var release = new Release
                {
                    CreatedByUserId = 1,
                    Type = (ReleaseType)typeComboBox.SelectedItem,
                    AlbumId = album?.Id,
                    SongId = song?.Id,
                    Status = (ReleaseStatus)statusComboBox.SelectedItem,
                    ScheduledDate = releaseDatePicker.Value,
                    Notes = notesTextBox.Text
                };

                _releaseController.AddRelease(release);

                LoadReleases();
            }
        }

        private void updateReleaseButton_Click(object sender, EventArgs e)
        {
            if (releasesDataGridView.SelectedRows.Count > 0 && ValidateRelease())
            {
                var selectedRow = releasesDataGridView.SelectedRows[0];
                var release = (Release)selectedRow.DataBoundItem;
                release.Type = (ReleaseType)typeComboBox.SelectedItem;
                release.AlbumId = typeComboBox.SelectedItem.ToString() == "Album" ? (int?)albumOrSongComboBox.SelectedItem : null;
                release.SongId = typeComboBox.SelectedItem.ToString() == "Single" ? (int?)albumOrSongComboBox.SelectedItem : null;
                release.Status = (ReleaseStatus)statusComboBox.SelectedItem;
                release.ReleaseDate = releaseDatePicker.Value;
                release.Notes = notesTextBox.Text;
                release.UpdatedAt = DateTime.Now;
                _releaseController.UpdateRelease(release);
                LoadReleases();
            }
        }

        private void deleteReleaseButton_Click(object sender, EventArgs e)
        {
            if (releasesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = releasesDataGridView.SelectedRows[0];
                var release = (Release)selectedRow.DataBoundItem;
                _releaseController.DeleteRelease(release.Id);
                LoadReleases();
            }
        }

        private bool ValidateRelease()
        {
            if (typeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Type is required.");
                return false;
            }

            if (statusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Status is required.");
                return false;
            }

            return true;
        }

        private void ReleasesForm_Load(object sender, EventArgs e)
        {
            statusComboBox.DataSource = Enum.GetValues(typeof(ReleaseStatus));
            typeComboBox.DataSource = Enum.GetValues(typeof(ReleaseType));
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem.ToString() == "Album")
            {
                DisplayAlbums();
                return;
            }
            DisplaySongs();
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem.ToString() == "Album")
            {
                DisplayAlbums();
            }
            DisplaySongs();

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx) | *.xlsx";
            save.FileName = "Report Release.xlsx";

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
                excel_lib.ExportToExcel(releasesDataGridView, filePath);

                MessageBox.Show("Data berhasil di export ke excel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}


