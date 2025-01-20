using System;
using System.Windows.Forms;
using RYHME.Services;
using RYHME.model;

namespace RYHME.view
{
    public partial class ReleasesForm : Form
    {
        private ReleaseService _releaseService;

        public ReleasesForm()
        {
            InitializeComponent();
            _releaseService = new ReleaseService();
            LoadReleases();
        }

        private void LoadReleases()
        {
            var releases = _releaseService.GetAllReleases();
            releasesDataGridView.DataSource = releases;
        }

        private void addReleaseButton_Click(object sender, EventArgs e)
        {
            var release = new ReleaseSchedule
            {
                AlbumOrSong = albumOrSongComboBox.Text,
                ReleaseDate = releaseDatePicker.Value,
                Status = statusComboBox.Text
            };

            _releaseService.AddRelease(release);
            LoadReleases();
        }

        private void updateReleaseButton_Click(object sender, EventArgs e)
        {
            if (releasesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = releasesDataGridView.SelectedRows[0];
                var releaseId = (int)selectedRow.Cells["Id"].Value;

                var release = new ReleaseSchedule
                {
                    Id = releaseId,
                    AlbumOrSong = albumOrSongComboBox.Text,
                    ReleaseDate = releaseDatePicker.Value,
                    Status = statusComboBox.Text
                };

                _releaseService.UpdateRelease(release);
                LoadReleases();
            }
        }

        private void deleteReleaseButton_Click(object sender, EventArgs e)
        {
            if (releasesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = releasesDataGridView.SelectedRows[0];
                var releaseId = (int)selectedRow.Cells["Id"].Value;

                _releaseService.DeleteRelease(releaseId);
                LoadReleases();
            }
        }
    }
}
