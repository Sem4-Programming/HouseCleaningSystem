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


namespace House_Cleaning
{
    public partial class ReviewPage : Form
    {
        int selectedRating = 0;
        public ReviewPage()
        {
            InitializeComponent();
           
        }

        private void picStar1_Click(object sender, EventArgs e)
        {
            selectedRating = 1;
        }

        private void tbReview_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReview_Click(object sender, EventArgs e)
        {

        }

        private void ReviewPage_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelReview_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmitReview_Click(object sender, EventArgs e)
        {
            if (selectedRating == 0)
            {
                MessageBox.Show("Please select a rating before submitting.", "Error");
            }
            else
            {
              
                MessageBox.Show("Thank you for your feedback!", "Submitted");

                // Redirect to home
                Home home = new Home();
                home.Show();
                this.Hide();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void picStar2_Click(object sender, EventArgs e)
        {
            selectedRating = 2;
        }

        private void picStar3_Click(object sender, EventArgs e)
        {
            selectedRating = 3;
        }

        private void picStar4_Click(object sender, EventArgs e)
        {
            selectedRating = 4;
        }

        private void picStar5_Click(object sender, EventArgs e)
        {
            selectedRating = 5;
        }
    }
}
