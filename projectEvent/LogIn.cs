using projectEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Cleaning_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void labelLogIn_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsernameLogIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordLogIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogIn.Text.Trim();
            string password = textBoxPasswordLogIn.Text.Trim();

            // Check if username is empty
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUsernameLogIn.Focus();
                return;
            }

            // Check if password is empty
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPasswordLogIn.Focus();
                return;
            }

            // Proceed to Dashboard
            AdminDashboard dashboardForm = new AdminDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void buttonSignUpLogIn_Click(object sender, EventArgs e)
        {
            // Redirect to CreateUserAccount form
            UserCreateAccount UserCreateAccount = new UserCreateAccount();
            UserCreateAccount.Show();
            this.Hide();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
