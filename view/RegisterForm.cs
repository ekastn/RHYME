using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using RYHME.Controllers;
using RYHME.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYHME.view
{
    public partial class RegisterForm : Form
    {

        private readonly UserController _userController;
        private LoginForm _loginForm;

        public RegisterForm(UserController userController, LoginForm loginform)
        {
            _loginForm = loginform;
            InitializeComponent();
            _userController = userController;
        }

        private void RegisterUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;
            string contact = txtContact.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password (you should use a proper hashing algorithm in a real application)
            string passwordHash = HashPassword(password);

            User newUser = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                Contact = contact
            };

            try
            {
                _userController.AddUser(newUser);
                MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                _loginForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtContact.Clear();
            txtRePassword.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }
    }
}
