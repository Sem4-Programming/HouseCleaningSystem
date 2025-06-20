using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using projectEvent; // Required for opening URLs

namespace House_Cleaning_System
{
    public partial class UserCreateAccount : Form
    {
        public UserCreateAccount()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            // Validation for empty fields
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return;
            }

            // Redirect to Dashboard after successful validation
            AdminDashboard dashboardForm = new AdminDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // Open Google sign-up page
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://accounts.google.com/signup",
                UseShellExecute = true
            });
        }
    }
}
