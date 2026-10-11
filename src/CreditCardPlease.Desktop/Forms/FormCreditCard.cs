// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using CreditCardPlease.Desktop.Constants;
using CreditCardPlease.Desktop.Models;
using CreditCardPlease.Desktop.Resources.Localization;

namespace CreditCardPlease.Desktop
{
    /// <summary>
    /// Form Credit Card.
    /// </summary>
    public partial class FormCreditCard : Form
    {
        /// <summary>
        /// Constructor for the frmCreditCard class.
        /// </summary>
        public FormCreditCard()
        {
            InitializeComponent();
            UpdateFormLocalization();
        }

        /// <summary>
        /// Event handler for the Card Number text box text changed event. Formats the card number input with spaces every 4 digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtCardNumber.SelectionStart;

            int digitsBeforeCursor = txtCardNumber.Text
                .Substring(0, cursorPosition)
                .Count(char.IsDigit);

            string digits = new string(
                txtCardNumber.Text
                    .Where(char.IsDigit)
                    .Take(16)
                    .ToArray());

            string formattedNumber = string.Join(" ",
                Enumerable.Range(0, (digits.Length + 3) / 4)
                    .Select(i => digits.Substring(
                        i * 4,
                        Math.Min(4, digits.Length - i * 4))));

            if (txtCardNumber.Text != formattedNumber)
            {
                txtCardNumber.Text = formattedNumber;

                int newCursorPosition = 0;
                int digitsFound = 0;

                while (newCursorPosition < formattedNumber.Length
                    && digitsFound < digitsBeforeCursor)
                {
                    if (char.IsDigit(formattedNumber[newCursorPosition]))
                        digitsFound++;

                    newCursorPosition++;
                }

                txtCardNumber.SelectionStart = newCursorPosition;
            }
        }

        /// <summary>
        /// Event handler for the Card Expiration Date text box text changed event. Formats the expiration date input as MM/YY.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCardExpirationDate_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtCardExpirationDate.SelectionStart;

            int digitsBeforeCursor = txtCardExpirationDate.Text
                .Substring(0, cursorPosition)
                .Count(char.IsDigit);

            string digits = new string(
                txtCardExpirationDate.Text
                    .Where(char.IsDigit)
                    .Take(4)
                    .ToArray());

            string formattedDate = digits.Length > 2
                ? digits.Insert(2, "/")
                : digits;

            if (txtCardExpirationDate.Text != formattedDate)
            {
                txtCardExpirationDate.Text = formattedDate;

                int newCursorPosition = 0;
                int digitsFound = 0;

                while (newCursorPosition < formattedDate.Length
                    && digitsFound < digitsBeforeCursor)
                {
                    if (char.IsDigit(formattedDate[newCursorPosition]))
                        digitsFound++;

                    newCursorPosition++;
                }

                // Keep the cursor after the slash when both month digits are entered.
                if (digitsBeforeCursor >= 2 && formattedDate.Length > 2)
                    newCursorPosition = Math.Max(newCursorPosition, 3);

                txtCardExpirationDate.SelectionStart = newCursorPosition;
            }
        }

        /// <summary>
        /// Event handler for the Send button click event. Sends credit card data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e) => SendCreditCardData();

        /// <summary>
        /// Event handler for the Cancel button click event. Cancels credit card submission.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e) => CancelSubmissionOrExitApplication();


        /// <summary>
        /// Event handler for the "Monika" menu item click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miMonika_Click(object sender, EventArgs e)
        {
            SetRandomFakeCreditCardData();
        }

        /// <summary>
        /// Event handler for the "uwu" menu item click event. UwU
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miUwu_Click(object sender, EventArgs e)
            => MessageBox.Show("uwu", "owo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        /// <summary>
        /// Event handler for the Exit menu item click event. Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, EventArgs e) => ExitApplication();

        /// <summary>
        /// Event handler for the System Default language menu item click event. Sets the application language to system default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miLanguageSystemDefault_Click(object sender, EventArgs e)
            => SetApplicationLanguageAndRestart(Languages.System);

        /// <summary>
        /// Event handler for the System Default language menu item click event. Sets the application language to english.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miLanguageEnglish_Click(object sender, EventArgs e)
            => SetApplicationLanguageAndRestart(Languages.English);

        /// <summary>
        /// Event handler for the System Default language menu item click event. Sets the application language to portuguese.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miLanguagePortuguese_Click(object sender, EventArgs e)
            => SetApplicationLanguageAndRestart(Languages.Portuguese);

        /// <summary>
        /// Event handler for the About menu item click event. Displays information about the application and its author.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miAbout_Click(object sender, EventArgs e)
            => MessageBox.Show(Strings.DialogAboutDescription, Strings.DialogAboutTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        /// <summary>
        /// Event handler for the Disclaimer menu item click event. Displays a disclaimer message about credit card data usage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miDisclaimer_Click(object sender, EventArgs e)
        => MessageBox.Show(Strings.DialogDisclaimerDescription, Strings.DialogDisclaimerTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);


        /// <summary>
        /// Sends the credit card data and clears the input fields.
        /// </summary>
        private void SendCreditCardData()
        {
            ClearCreditCardFields();

            MessageBox.Show(Strings.DialogSendDescription, $"Sayori: {Strings.DialogSendTitle}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Cancels the credit card submission and clears the input fields.
        /// </summary>
        private void CancelSubmissionOrExitApplication()
        {
            if (IsCreditCardFieldsEmpty())
                ExitApplication();
            else
                CancelCreditCardSubmission();
        }

        private void CancelCreditCardSubmission()
        {
            DialogResult result = MessageBox.Show(
                Strings.DialogCancelDescription,
                $"Sayori: {Strings.DialogCancelTitle}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ClearCreditCardFields();
                MessageBox.Show(
                    Strings.DialogCancelYesDescription,
                    $"Sayori: {Strings.DialogCancelYesTitle}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show(
                    Strings.DialogCancelNoDescription,
                    $"Sayori: {Strings.DialogCancelNoTitle}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Clears the credit card input fields in the form.
        /// </summary>
        private void ClearCreditCardFields()
        {
            txtCardNumber.Clear();
            txtCardExpirationDate.Clear();
            txtCardSecurityCode.Clear();
        }

        /// <summary>
        /// Checks if all credit card input fields are empty.
        /// </summary>
        /// <returns>Returns true if all fields are empty, false otherwise.</returns>
        private bool IsCreditCardFieldsEmpty()
        {
            var fields = new TextBox[]
            {
                txtCardNumber,
                txtCardExpirationDate,
                txtCardSecurityCode
            };

            foreach (var field in fields)
                if (!string.IsNullOrWhiteSpace(field.Text))
                    return false;

            return true;
        }

        /// <summary>
        /// Exits the application after confirming with the user.
        /// </summary>
        private static void ExitApplication()
        {
            DialogResult result = MessageBox.Show(
                Strings.DialogExitDescription,
                $"Sayori: {Strings.DialogExitTitle}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Application.Exit();
        }


        /// <summary>
        /// Sets the application language and restarts the application to apply the changes.
        /// </summary>
        /// <param name="language"></param>
        private static void SetApplicationLanguageAndRestart(string language)
        {
            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        /// <summary>
        /// Updates the form's localization based on the current language settings.
        /// </summary>
        private void UpdateFormLocalization()
        {
            UpdateControlsLocalizationText();
            UpdateLanguageMenuSelection();
        }

        /// <summary>
        /// Updates the language menu items to reflect the current language selection.
        /// </summary>
        private void UpdateLanguageMenuSelection()
        {
            string language = Properties.Settings.Default.Language;

            miLanguageSystemDefault.Checked = language == Languages.System;
            miLanguageEnglish.Checked = language == Languages.English;
            miLanguagePortuguese.Checked = language == Languages.Portuguese;
        }

        /// <summary>
        /// Sets the localization for the controls in the form based on the current language settings.
        /// </summary>
        private void UpdateControlsLocalizationText()
        {
            // Window Title
            this.Text = Strings.CreditCardWindowTitle;

            // Title Labels
            lblTitle.Text = Strings.CardFormTitle;
            lblThanks.Text = Strings.CardFormThanks;
            // Credit Card Labels
            lblCardNumber.Text = $"{Strings.CardFormCardNumber}:";
            lblCardExpirationDate.Text = $"{Strings.CardFormExpirationDate}:";
            lblCardSecurityCode.Text = $"{Strings.CardFormSecurityCode}:";
            lblRequiredFields.Text = $"* {Strings.CardFormRequiredFields}";
            // Buttons Texts
            btnCancel.Text = Strings.CardFormCancel;
            btnSend.Text = Strings.CardFormSendData;

            // Menu Items Texts
            miApplication.Text = Strings.MenuApplication;
            miExit.Text = Strings.MenuExit;
            miSettings.Text = Strings.MenuSettings;
            miLanguage.Text = Strings.MenuLanguage;
            miLanguageSystemDefault.Text = $"({Strings.MenuSystemDefault})";
            miAbout.Text = Strings.MenuAbout;
        }

        /// <summary>
        /// Sets random fake credit card data in the input fields.
        /// </summary>
        private void SetRandomFakeCreditCardData()
        {
            txtCardNumber.Text = FakeCreditCardGenerator.GetRandomNumber();
            txtCardExpirationDate.Text = FakeCreditCardGenerator.GetRandomExpirationDate();
            txtCardSecurityCode.Text = FakeCreditCardGenerator.GetRandomCVV();

            MessageBox.Show(
                Strings.DialogMonikaDescription,
                Strings.DialogMonikaTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
