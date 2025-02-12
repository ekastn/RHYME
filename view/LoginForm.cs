using System;
using System.Windows.Forms;
using RYHME.Controllers;

namespace RYHME
{
    public partial class LoginForm : Form
    {
        private readonly UserController _userController;

        public LoginForm(UserController userController)
        {
            _userController = userController;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = _userController.AuthenticateUser(username, password);
            if (user != null)
            {
                // Login successful
                this.Hide();
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
