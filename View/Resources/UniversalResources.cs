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
}
