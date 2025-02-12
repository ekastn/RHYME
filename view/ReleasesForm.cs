using RYHME.Controllers;
using RYHME.Models;

namespace RYHME.view
{
    public partial class ReleasesForm : Form
    {
        private readonly ReleaseController _releaseController;

        public ReleasesForm(ReleaseController releaseController)
        {
            _releaseController = releaseController;
            InitializeComponent();
        }

        private void LoadReleases()
        {
            var releases = _releaseController.GetAllReleases();
            releasesDataGridView.DataSource = releases;
        }

        private void addReleaseButton_Click(object sender, EventArgs e)
        {
            var release = new Release
            {
                Title = albumOrSongComboBox.Text,
                ScheduledDate = releaseDatePicker.Value,
                Status = (ReleaseStatus)statusComboBox.SelectedItem
            };
            _releaseController.AddRelease(release);
            LoadReleases();
        }

        private void updateReleaseButton_Click(object sender, EventArgs e)
        {
            if (releasesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = releasesDataGridView.SelectedRows[0];
                var release = (Release)selectedRow.DataBoundItem;
                release.Title = albumOrSongComboBox.Text;
                release.ScheduledDate = releaseDatePicker.Value;
                release.Status = (ReleaseStatus)statusComboBox.SelectedItem;
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
    }
}
