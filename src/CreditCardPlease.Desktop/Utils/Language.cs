using System.Globalization;
using System.Threading;

namespace CreditCardPlease.Desktop.Utils
{
    internal class Language
    {
        private static async Task Test()
        {
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("en");

            string culture = CultureInfo.CurrentUICulture.Name;
        }
    }
}
