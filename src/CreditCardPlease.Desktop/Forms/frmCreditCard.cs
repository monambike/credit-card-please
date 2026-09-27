using CreditCardPlease.Desktop.Constants;
using CreditCardPlease.Desktop.Resources.Localization;

namespace CreditCardPlease.Desktop
{
    public partial class frmCreditCard : Form
    {
        public frmCreditCard()
        {
            InitializeComponent();
            SetLocalization();
            UpdateLanguageMenu();
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
                Strings.DialogSendDescription,
                Strings.DialogSendTitle, MessageBoxButtons.OK);
        }

        private void CancelCreditCardSubmission()
        {
            DialogResult result = MessageBox.Show(
                Strings.DialogCancelDescription,
                Strings.DialogCancelTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ClearCreditCardFields();
                MessageBox.Show(
                    Strings.DialogCancelYesDescription,
                    Strings.DialogCancelYesTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show(
                    Strings.DialogCancelNoDescription,
                    Strings.DialogCancelNoTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ClearCreditCardFields()
        {
            txtCardNumber.Clear();
            txtCardExpirationDate.Clear();
            txtCardSecurityCode.Clear();
        }

        private void SetLocalization()
        {
            this.Text = Strings.CreditCardWindowTitle;

            lblTitle.Text = Strings.CardFormTitle;
            lblThanks.Text = Strings.CardFormThanks;

            lblCardNumber.Text = Strings.CardFormCardNumber;
            lblCardExpirationDate.Text = Strings.CardFormExpirationDate;
            lblCardSecurityCode.Text = Strings.CardFormSecurityCode;
            lblRequiredFields.Text = $"* {Strings.CardFormRequiredFields}";

            btnCancel.Text = Strings.CardFormCancel;
            btnSend.Text = Strings.CardFormSendData;
        }

        private void miLanguageSystemDefault_Click(object sender, EventArgs e)
            => SetApplicationLanguage(Languages.System);

        private void miLanguageEnglish_Click(object sender, EventArgs e)
            => SetApplicationLanguage(Languages.English);

        private void miLanguagePortuguese_Click(object sender, EventArgs e)
            => SetApplicationLanguage(Languages.Portuguese);

        private static void SetApplicationLanguage(string language)
        {
            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void UpdateLanguageMenu()
        {
            string language = Properties.Settings.Default.Language;

            miLanguageSystemDefault.Checked = language == Languages.System;
            miLanguageEnglish.Checked = language == Languages.English;
            miLanguagePortuguese.Checked = language == Languages.Portuguese;
        }
    }
}
