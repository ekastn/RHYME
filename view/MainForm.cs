using RYHME.view;
using RYHME.Controllers;

namespace RYHME
{
    public partial class MainForm : Form
    {
        private Form currentChildForm;
        private readonly ArtistController _artistController;
        private readonly AlbumController _albumController;
        private readonly SongController _songController;
        private readonly ReleaseController _releaseController;

        public MainForm(ArtistController artistController, AlbumController albumController, SongController songController, ReleaseController releaseController)
        {
            _artistController = artistController;
            _albumController = albumController;
            _songController = songController;
            _releaseController = releaseController;
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm(_artistController, _albumController, _songController));
        }

        private void buttonNavArtists_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArtistsForm(_artistController));
        }

        private void buttonNavAlbums_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlbumsForm(_albumController, _artistController));
        }

        private void buttonNavReleases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReleasesForm(_releaseController));
        }
    }
}
