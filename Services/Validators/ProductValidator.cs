using System;
using System.Globalization;

namespace OrderSystem.Services.Validators
{
    internal class ProductValidator
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            name = name.Trim();
            return name.All(c => char.IsLetterOrDigit(c) || c == '-' || c == '\'' || c == ' ');
        }
        public static bool IsValidPrice(string input)
        {
            return double.TryParse(input, CultureInfo.InvariantCulture, out double price) && price > 0;

        }
        public static bool IsValidPrice(double price)
        {
            return price > 0;
        }
        public static bool IsValidQuantity(string input)
        {
            return int.TryParse(input, CultureInfo.InvariantCulture, out int quantity) && quantity > 0;
        }
    }
}
