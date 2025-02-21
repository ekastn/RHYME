using RYHME.view;
using RYHME.Controllers;
using RYHME.Utils;

namespace RYHME
{
    public partial class MainForm : Form
    {
        private Form currentChildForm;
        private readonly ArtistController _artistController;
        private readonly AlbumController _albumController;
        private readonly SongController _songController;
        private readonly ReleaseController _releaseController;
        private readonly UserController _userController;
        private readonly SessionManager _sessionManager;

        public MainForm(ArtistController artistController,
            AlbumController albumController,
            SongController songController,
            ReleaseController releaseController,
            UserController userController,
            SessionManager sessionManager)
        {
            _artistController = artistController;
            _albumController = albumController;
            _songController = songController;
            _releaseController = releaseController;
            _userController = userController;
            _sessionManager = sessionManager;
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
            OpenChildForm(new DashboardForm(_artistController, _albumController, _songController, _releaseController));
        }

        private void buttonNavArtists_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArtistsForm(_artistController, _sessionManager));
        }

        private void buttonNavAlbums_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlbumsForm(_albumController, _artistController));
        }

        private void buttonNavReleases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReleasesForm(_releaseController, _albumController, _songController));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNavSongs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SongsForm(_songController, _albumController));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _sessionManager.SetLoggedInUser(null);
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm(_artistController, _albumController, _songController, _releaseController));
        }
    }
}
