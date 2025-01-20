using System;
using System.Text.RegularExpressions;

namespace RYHME.Utils
{
    public static class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            var regex = new Regex(@"^\+?[1-9]\d{1,14}$");
            return regex.IsMatch(phoneNumber);
        }

        public static bool IsValidUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return false;

            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            return regex.IsMatch(password);
        }

        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                return false;

            // Username must be between 3 and 20 characters long and contain only letters, digits, and underscores
            var regex = new Regex(@"^[a-zA-Z0-9_]{3,20}$");
            return regex.IsMatch(username);
        }
    }
}
