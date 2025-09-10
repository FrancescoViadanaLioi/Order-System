using System;
using System.Globalization;
using System.Net.Mail;
using System.Linq;
using OrderSystem.Entities.EntitiesEnum;

namespace OrderSystem.Services.Validators
{
    internal class ClientValidators
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            name = name.Trim();
            return name.All(c => char.IsLetter(c) || c == '-' || c == '\'' || c == ' ');
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                email = email.Trim().ToLower();
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsValidBirthDate(string input, out DateTime date)
        {
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy" ,CultureInfo.InvariantCulture, DateTimeStyles.None, out date)) return false;

            int age = DateTime.Now.Year - date.Year;
            if (date.Year < 1920 || age < 18) return false;

            string formatted = date.ToString("dd/MM/yyyy");
            return true;
        }
        public static bool IsValidBirthDate(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (date.Year < 1920 || age < 18) return false;
            return true;
        }
    }
}
