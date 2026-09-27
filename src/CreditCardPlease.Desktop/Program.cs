using System.Globalization;

namespace CreditCardPlease.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string language = Properties.Settings.Default.Language;

            if (language != "System")
            {
                Thread.CurrentThread.CurrentUICulture =
                    new CultureInfo(language);
            }

            Application.Run(new frmCreditCard());
        }
    }
}