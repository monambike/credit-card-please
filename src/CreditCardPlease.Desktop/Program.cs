// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Globalization;

namespace CreditCardPlease.Desktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
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