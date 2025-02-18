using RYHME.Controllers;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.view
{
    public partial class ArtistsForm : Form
    {
        private readonly ArtistController _artistController;

        public ArtistsForm(ArtistController artistController)
        {
            _artistController = artistController;
            InitializeComponent();
            LoadArtists();
        }

        private void LoadArtists()
        {
            var artists = _artistController.GetAllArtists();
            artistsDataGridView.DataSource = artists;
            CleanForm();
        }

        private void CleanForm()
        {
            nameTextBox.Text = "";
            genreTextBox.Text = "";
            contactTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var artist = new Artist
            {
                Name = nameTextBox.Text,
                Genre = genreTextBox.Text,
                Contact = contactTextBox.Text,
                ManagerId = 1 // FIXME: Hardcoded manager ID
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

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx) | *.xlsx";
            save.FileName = "Report Artist.xlsx";

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
                excel_lib.ExportToExcel(artistsDataGridView, filePath);

                MessageBox.Show("Data berhasil di export ke excel", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
