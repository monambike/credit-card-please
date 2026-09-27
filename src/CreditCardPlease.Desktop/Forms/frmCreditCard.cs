namespace CreditCardPlease.Desktop
{
    public partial class frmCreditCard : Form
    {
        public frmCreditCard()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCreditCardData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelCreditCardSubmission();
        }

        private void SendCreditCardData()
        {
            MessageBox.Show(
                $"T-Thank you so much! >\\\\~\\\\<\n\nYour credit card data is in good hands! ❤️",
                "I can't believe you did that!", MessageBoxButtons.OK);
        }

        private void CancelCreditCardSubmission()
        {
            DialogResult result = MessageBox.Show(
                "Please don't do anything stupid!",
                "A-are you sure?...",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ClearCreditCardFields();
                MessageBox.Show("Why would you do that? 🥺", ":(", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Phew!! You scared me..", "Omg..", MessageBoxButtons.OK);
            }
        }

        private void ClearCreditCardFields()
        {
            txtCardNumber.Clear();
            txtCardExpirationDate.Clear();
            txtCardSecurityCode.Clear();
        }
    }
}
