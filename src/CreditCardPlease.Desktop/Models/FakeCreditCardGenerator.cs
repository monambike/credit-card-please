namespace CreditCardPlease.Desktop.Models
{
    /// <summary>
    /// Represents a generator for creating fake credit card information.
    /// </summary>
    internal class FakeCreditCardGenerator
    {
        /// <summary>
        /// Generates a random credit card number that passes the Luhn algorithm check.
        /// </summary>
        /// <returns>The random credit card number.</returns>
        public static string GetRandomNumber()
        {
            string numberWithoutCheckDigit = "";

            // Generate 14 random digits between 0 and 9 each and append to the string.
            for (int i = 0; i < 15; i++)
                numberWithoutCheckDigit += Random.Shared.Next(0, 10);

            int checkDigit = CalculateCheckDigit(numberWithoutCheckDigit);

            return numberWithoutCheckDigit + checkDigit;
        }

        /// <summary>
        /// Generates a random CVV for a credit card.
        /// </summary>
        /// <returns>The random credit card cvv.</returns>
        public static string GetRandomCVV()
        {
            var random = new Random();

            int cvv = random.Next(0, 1000);

            string securityCode = cvv.ToString("D3");

            return securityCode;
        }

        /// <summary>
        /// Generates a random expiration date for a credit card in the format MM/YY.
        /// </summary>
        /// <returns>The random credit card expiration date.</returns>
        public static string GetRandomExpirationDate()
        {
            var random = new Random();

            int month = random.Next(1, 13);
            int year = DateTime.Now.Year + random.Next(1, 6);

            string expirationDate = $"{month:D2}/{year % 100:D2}";
            return expirationDate;
        }

        /// <summary>
        /// Calculates the check digit for a given credit card number using the Luhn algorithm.
        /// </summary>
        /// <param name="numberWithoutCheckDigit"></param>
        /// <returns>The check digit.</returns>
        private static int CalculateCheckDigit(string numberWithoutCheckDigit)
        {
            bool shouldDoubleDigit = true;
            int sum = 0;

            for (int numberIndex = numberWithoutCheckDigit.Length - 1; numberIndex >= 0; numberIndex--)
            {
                int digit = Convert.ToInt32(numberWithoutCheckDigit[numberIndex].ToString());

                if (shouldDoubleDigit)
                {
                    digit *= 2;
                    // If doubling produces a number greater than 9, subtract 9 from it.
                    if (digit > 9) digit -= 9;
                }

                sum += digit;
                // Alternate between doubling and keeping digits unchanged.
                shouldDoubleDigit = !shouldDoubleDigit;
            }

            // Calculate the digit needed to make the sum a multiple of 10.
            var checkDigit = (10 - sum % 10) % 10;

            return checkDigit;
        }

        /// <summary>
        /// Return if a credit card number is valid under Luhn algorithm.
        /// </summary>
        /// <param name="fullNumber"></param>
        /// <returns>The credit card valid status.</returns>
        public static bool IsValidLuhnNumberAlgorithm(string fullNumber)
        {
            bool doubleDigit = false;
            int sum = 0;

            for (int numberIndex = fullNumber.Length - 1; numberIndex >= 0; numberIndex--)
            {
                if (!char.IsDigit(fullNumber[numberIndex]))
                    return false;

                int digit = Convert.ToInt32(fullNumber[numberIndex].ToString());

                if (doubleDigit)
                {
                    digit *= 2;
                    // If doubling produces a number greater than 9, subtract 9 from it.
                    if (digit > 9) digit -= 9;
                }

                sum += digit;
                // Alternate between doubling and keeping digits unchanged.
                doubleDigit = !doubleDigit;
            }

            var isValid = sum % 10 == 0;
            return isValid;
        }
    }
}
