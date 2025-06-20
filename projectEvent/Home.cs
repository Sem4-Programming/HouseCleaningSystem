using System;
using System.Windows.Forms;
using ReservationForm; 
using House_Cleaning_System;
using AddressReservationForm;
namespace projectEvent
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lblHomeCare_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pB1_Click(object sender, EventArgs e)
        {

        }


        private void btnReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reservationForm = new reservation();
            reservationForm.Show();
        }


        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            var manageForm = new ManageReservationForm();
            manageForm.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the current form
            var logInForm = new LogIn();
            logInForm.Show(); //Show the LogIn form

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the current form
            var usercreateaccount = new UserCreateAccount();
            usercreateaccount.Show(); //Show the LogIn form

        }
    }
}
