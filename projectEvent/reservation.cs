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
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
        }

        private void RrbPackage1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RtxtPackage5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RrbPackage3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RpnLReservation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RlblSubTitle_Click(object sender, EventArgs e)
        {

        }

        private void RlblTitle_Click(object sender, EventArgs e)
        {

        }

        private void RrbPackage1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RtxtPackage5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void RtxtPackage4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RtxtPackage3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RtxtPackage1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RrbPackage4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RrbPackage2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RrbPackage5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RrbPackage3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void RtxtPackage2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RchklstAddOn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCleaningDate_Click(object sender, EventArgs e)
        {

        }

        private void RclndrCleaningDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void RlblPackageSelect_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RbtnManageAddress_Click(object sender, EventArgs e)
        {
            AddressList addressListForm = new AddressList();
            addressListForm.OnAddressSelected += (fullName, phone, area, unitNo, fullAddress) =>
            {
                
            };
            addressListForm.ShowDialog();
        }


        private void RtxtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void RlblAddress_Click(object sender, EventArgs e)
        {

        }

        private void RlblRemarks_Click(object sender, EventArgs e)
        {

        }

        private void RbtnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
