using RYHME.view;

namespace RYHME
{
    public partial class MainForm : Form
    {
        private Form currentChildForm;

        public MainForm()
        {
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
            OpenChildForm(new DashboardForm());
        }

        private void buttonNavArtists_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArtistsForm());
        }

        private void buttonNavAlbums_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AlbumsForm());
        }

        private void buttonNavReleases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReleasesForm());
        }
    }
}
