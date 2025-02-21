using System;
using System.Text;
using System.Windows.Forms;
using RYHME.Controllers;
using RYHME.view;
using RYHME.Utils;

namespace RYHME
{
    public partial class LoginForm : Form
    {
        private readonly UserController _userController;
        private readonly SessionManager _sessionManager;

        public LoginForm(UserController userController, SessionManager sessionManager)
        {
            _userController = userController;
            _sessionManager = sessionManager;
            InitializeComponent();
        }

        private string HashPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
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

            var user = _userController.AuthenticateUser(username, HashPassword(password));

            if (user != null)
            {
                _sessionManager.SetLoggedInUser(user);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm(_userController, this, _sessionManager);
            form.Show();
            this.Hide();
        }
    }
}
