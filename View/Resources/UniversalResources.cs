using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.View.Resources
{
    internal static class DataInput
    {
        public static string? AskForInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
    internal static class Formatter
    {
        public static string Format(double value)
        {
            return value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    internal static class InputHelper
    {
        public static T GetValidatedInput<T>(
            string prompt,
            Func<string, bool> validator,
            Func<string, T> converter,
            string errorMessage)
        {
            while (true)
            {
                string? input = DataInput.AskForInput(prompt);
                if (input != null && validator(input)) return converter(input);
                ConsoleUI.ShowError(errorMessage);
            }
        }
        
    }
}
