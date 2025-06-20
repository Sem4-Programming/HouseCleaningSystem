using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressReservationForm
{
    public partial class AddAddress : Form
    {
        public AddAddress()
        {
            InitializeComponent();

          
      


            // Set initial placeholder text and color
            SetPlaceholder(AAtxtName, "Enter full name");
            SetPlaceholder(AAtxtFullAddress, "House Number, Building, Street Name");

            // Attach events for placeholders
            AAtxtName.GotFocus += RemovePlaceholder;
            AAtxtName.LostFocus += SetPlaceholderOnLeave;

            AAtxtFullAddress.GotFocus += RemovePlaceholder;
            AAtxtFullAddress.LostFocus += SetPlaceholderOnLeave;
        }

        

        private void AAtxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AAtxtFullAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void AAtxtArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholderOnLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == AAtxtName)
                    SetPlaceholder(textBox, "Enter full name");
                else if (textBox == AAtxtFullAddress)
                    SetPlaceholder(textBox, "Enter full address");
            }
        }

        private void AddAddress_Load(object sender, EventArgs e)
        {

        }

        private void AAtxtPhone_TextChanged(object sender, EventArgs e)
        {

        }


        private void AAbtnSave_Click(object sender, EventArgs e)
        {
            // Validate Full Name
            if (string.IsNullOrWhiteSpace(AAtxtName.Text) || AAtxtName.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtName.Focus();
                return;
            }

            // Validate Phone Number
            string phone = AAtxtPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtPhone.Focus();
                return;
            }
            else if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtPhone.Focus();
                return;
            }
            else if (phone.Length < 10 || phone.Length > 12)
            {
                MessageBox.Show("Invalid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtPhone.Focus();
                return;
            }

            // Validate Area
            if (string.IsNullOrWhiteSpace(AAtxtArea.Text))
            {
                MessageBox.Show("Please enter an area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtArea.Focus();
                return;
            }

            // Validate Unit No.
            if (string.IsNullOrWhiteSpace(AAtxtUnitNo.Text))
            {
                MessageBox.Show("Please enter unit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtUnitNo.Focus();
                return;
            }

            // Validate Full Address
            if (string.IsNullOrWhiteSpace(AAtxtFullAddress.Text) || AAtxtFullAddress.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please enter your full address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AAtxtFullAddress.Focus();
                return;
            }

            // All validations passed
            MessageBox.Show("Address saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            addressListForm.AddAddressToPanel(
    AAtxtName.Text.Trim(),
    AAtxtPhone.Text.Trim(),
    AAtxtArea.Text.Trim(),
    AAtxtUnitNo.Text.Trim(),
    AAtxtFullAddress.Text.Trim()
);

            this.Close(); // Optional: close the AddAddress form after saving


            // Proceed with save logic
        }



        private void AAlblFullName_Click(object sender, EventArgs e)
        {

        }

        private void AAlblPhone_Click(object sender, EventArgs e)
        {

        }

        private void AAlblArea_Click(object sender, EventArgs e)
        {

        }

        private void AAlblUnitNo_Click(object sender, EventArgs e)
        {

        }

        private void AAlblAddress_Click(object sender, EventArgs e)
        {

        }

        private void AAtxtUnitNo_TextChanged(object sender, EventArgs e)
        {

        }
        private AddressList addressListForm;

        public AddAddress(AddressList form)
        {
            InitializeComponent();
            addressListForm = form;

            // Placeholder code remains the same
            SetPlaceholder(AAtxtName, "Enter full name");
            SetPlaceholder(AAtxtFullAddress, "Enter full address");

            AAtxtName.GotFocus += RemovePlaceholder;
            AAtxtName.LostFocus += SetPlaceholderOnLeave;

            AAtxtFullAddress.GotFocus += RemovePlaceholder;
            AAtxtFullAddress.LostFocus += SetPlaceholderOnLeave;
        }

    }
}
