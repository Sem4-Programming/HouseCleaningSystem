namespace projectEvent
{
    public partial class CreditDebitPage : Form
    {
        public CreditDebitPage()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cardNoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
