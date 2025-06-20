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
    public partial class AddressList : Form
    {
        public AddressList()
        {
            InitializeComponent();
        }

        private void ALlblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ALpnlAddress1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ALpnlAddress2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ALpnlAddress3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ALlblMyAddress_Click(object sender, EventArgs e)
        {

        }

        private void ALbtnAddAddress_Click(object sender, EventArgs e)
        {
            AddAddress addAddressForm = new AddAddress(this);
            addAddressForm.ShowDialog();
        }


        private void AddressList_Load(object sender, EventArgs e)
        {

        }

        public void AddAddressToPanel(string fullName, string phone, string area, string unitNo, string fullAddress)
        {
            Panel addressCard = new Panel();
            addressCard.Size = new Size(300, 130);
            addressCard.BorderStyle = BorderStyle.FixedSingle;
            addressCard.BackColor = Color.White;
            addressCard.Margin = new Padding(10);
            addressCard.Cursor = Cursors.Hand;

            Label info = new Label();
            info.Dock = DockStyle.Fill;
            info.Font = new Font("Segoe UI", 10);
            info.Text = $"Name: {fullName}\nPhone: {phone}\nArea: {area}\nUnit No: {unitNo}\nAddress: {fullAddress}";
            info.TextAlign = ContentAlignment.TopLeft;
            info.Padding = new Padding(10);
            info.BackColor = Color.Transparent;

            addressCard.Controls.Add(info);

            // 🔴 Handle click to select this address
            addressCard.Click += (s, e) =>
            {
                OnAddressSelected?.Invoke(fullName, phone, area, unitNo, fullAddress);
                this.Close();
            };
            info.Click += (s, e) =>  // So clicking the label also triggers
            {
                OnAddressSelected?.Invoke(fullName, phone, area, unitNo, fullAddress);
                this.Close();
            };

            switch (addressCount)
            {
                case 0:
                    ALpnlAddress1.Controls.Clear();
                    ALpnlAddress1.Controls.Add(addressCard);
                    break;
                case 1:
                    ALpnlAddress2.Controls.Clear();
                    ALpnlAddress2.Controls.Add(addressCard);
                    break;
                case 2:
                    ALpnlAddress3.Controls.Clear();
                    ALpnlAddress3.Controls.Add(addressCard);
                    break;
                default:
                    MessageBox.Show("You can only add up to 3 addresses.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            addressCount++;
        }

        

        private int addressCount = 0;

        public delegate void AddressSelectedHandler(string fullName, string phone, string area, string unitNo, string fullAddress);
        public event AddressSelectedHandler OnAddressSelected;


    }
}
