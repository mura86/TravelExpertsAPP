using System.Text.RegularExpressions;

namespace ProductMaintenanceGUI
{
    /*
     *
     * A repository of validation methods
     * Author: Renato Pires
     * Date: March 2023
     *
     */

    public static class InputValidator
    {
        // Regular expressions to match non-negative decimal and integer values
        private static readonly Regex nonNegativeDecimalRegex = new Regex(@"^(0|[1-9]\d*)(\.\d+)?$");

        private static readonly Regex nonNegativeIntegerRegex = new Regex(@"^(0|[1-9]\d*)$");

        /* Checks if the text box has text in it */

        public static bool IsPresent(System.Windows.Forms.TextBox textBox)
        {
            // If the text box is empty or contains only white space, show an error message and return false
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is required");
                textBox.Focus();
                return false;
            }

            // Otherwise, return true
            return true;
        }

        /* Checks if the text box contains a non-negative integer value */

        public static bool IsNonNegativeInt(TextBox textBox)
        {
            // Check if the input matches the pattern of a non-negative integer
            bool isValid = nonNegativeIntegerRegex.IsMatch(textBox.Text);

            // If the input is not a non-negative integer, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(textBox.Tag + " has to be a non-negative whole number");
                textBox.SelectAll();
                textBox.Focus();
            }

            // Otherwise, return true
            return isValid;
        }

        /* Checks if the text box contains an integer value within a specified range */

        public static bool IsIntInRange(TextBox textBox, int minVal, int maxVal)
        {
            // Check if the input is a non-negative integer
            if (IsNonNegativeInt(textBox))
            {
                // Parse the input value as an integer
                int result = int.Parse(textBox.Text);

                // If the input value is not within the specified range, show an error message and return false
                if (result < minVal || result > maxVal)
                {
                    MessageBox.Show(textBox.Tag + " has to be between " + minVal + " and " + maxVal);
                    textBox.SelectAll();
                    textBox.Focus();
                    return false;
                }

                // Otherwise, return true
                return true;
            }

            // If the input is not a non-negative integer, return false
            return false;
        }

        /* Checks if the text box contains a non-negative double value */

        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            // Check if the input matches the pattern of a non-negative decimal number
            bool isValid = nonNegativeDecimalRegex.IsMatch(textBox.Text);

            // If the input is not a non-negative decimal number, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(textBox.Tag + " has to be a non-negative decimal number");
                textBox.SelectAll();
                textBox.Focus();
            }

            // Otherwise, return true
            return isValid;
        }

        /* Checks if the text box contains a non-negative decimal value */

        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            // Call the IsNonNegativeDouble method to check if the input is a non-negative decimal number
            return IsNonNegativeDouble(textBox);
        }

        /* Checks if the text box contains a decimal value within a specified range */

        public static bool IsDecimalInRange(TextBox textBox, decimal minVal, decimal maxVal)
        {
            // Check if the input is a non-negative decimal number
            if (IsNonNegativeDecimal(textBox))
            {
                // Parse the input value as a// decimal
                decimal result = decimal.Parse(textBox.Text);

                // If the input value is not within the specified range, show an error message and return false
                if (result < minVal || result > maxVal)
                {
                    MessageBox.Show(textBox.Tag + " has to be between " + minVal + " and " + maxVal);
                    textBox.SelectAll();
                    textBox.Focus();
                    return false;
                }

                // Otherwise, return true
                return true;
            }

            // If the input is not a non-negative decimal number, return false
            return false;
        }

        /* Checks if the text box contains a valid name */

        public static bool IsValidName(TextBox txtName)
        {
            // Check if the input matches the pattern of one or more alphabetical characters
            const string regex = @"^[a-zA-Z]+$";
            bool isValid = Regex.IsMatch(txtName.Text, regex);

            // If the input is not a valid name, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(txtName.Tag + " cannot contain special characters or numbers.");
            }

            // Otherwise, return true
            return isValid;
        }

        /* Checks if the text box contains a valid email address */

        public static bool IsValidEmail(TextBox textBox)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(textBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show(textBox.Tag + " has to be a valid email address");
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
        }

        /* Checks if the text box contains a valid phone number */

        public static bool IsValidPhone(TextBox textBox)
        {
            // Use a regular expression to match a phone number in the format (###) ###-####
            const string regex = @"^\(\d{3}\) \d{3}-\d{4}$";
            bool isValid = Regex.IsMatch(textBox.Text, regex);

            // If the input is not a valid phone number, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(textBox.Tag + " has to be a valid phone number in the format (###) ###-####");
                textBox.SelectAll();
                textBox.Focus();
            }

            // Otherwise, return true
            return isValid;
        }

        /* Checks if the text box contains a valid date */

        public static bool IsValidDate(TextBox textBox)
        {
            // Use DateTime.TryParseExact method to validate the input value as a date in the format of MM/dd/yyyy
            if (DateTime.TryParseExact(textBox.Text, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                if (date.Year >= 1900 && date.Year <= 2100)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(textBox.Tag + " has to be a valid date in the format MM/dd/yyyy and the year must be between 1900 and 2100.");
                    textBox.SelectAll();
                    textBox.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show(textBox.Tag + " has to be a valid date in the format MM/dd/yyyy");
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }
        }

        /* Checks if the text box contains a valid password */

        public static bool IsValidPassword(TextBox textBox)
        {
            // Use a regular expression to match a password that is at least 8 characters long and contains at least one uppercase letter, one lowercase letter, and one digit
            const string regex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            bool isValid = Regex.IsMatch(textBox.Text, regex);

            // If the input is not a valid password, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(textBox.Tag + " has to be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one digit");
                textBox.SelectAll();
                textBox.Focus();
            }

            // Otherwise, return true
            return isValid;
        }

        public static bool IsValidLength(TextBox textBox, int maxLength)
        {
            // If the text box has more characters than the max length, show an error message and return false
            if (textBox.Text.Length > maxLength)
            {
                MessageBox.Show(textBox.Tag + " has a maximum length of " + maxLength + " characters.");
                textBox.Focus();
                return false;
            }

            // Otherwise, return true
            return true;
        }

        /* Checks if the text box contains a decimal value with a specified number of digits before and after the decimal point */

        public static bool IsDecimalFormat(TextBox textBox, int numDigitsBeforeDecimal, int numDigitsAfterDecimal)
        {
            numDigitsBeforeDecimal -= 1;
            // Construct a regular expression pattern that matches a decimal number with the specified number of digits
            string pattern = "^\\d{1," + numDigitsBeforeDecimal + "}\\.\\d{1," + numDigitsAfterDecimal + "}$";
            Regex regex = new Regex(pattern);

            // Check if the input matches the pattern of a decimal number with the specified number of digits
            bool isValid = regex.IsMatch(textBox.Text);

            // If the input is not a decimal number with the specified number of digits, show an error message and return false
            if (!isValid)
            {
                MessageBox.Show(textBox.Tag + " has to be a decimal number with max of " + numDigitsBeforeDecimal + " digits before and " + numDigitsAfterDecimal + " digit(s) after the decimal point");
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }

            // Otherwise, return true
            return true;
        }
    }
}