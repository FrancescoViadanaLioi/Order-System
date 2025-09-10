using System;
using OrderSystem.Entities;
using OrderSystem.Entities.EntitiesEnum;

namespace OrderSystem.View.Resources
{
    internal class ConsoleUI
    {
        public static void ShowError(string text)
        {
            var message = new Message(text, MessageKind.Error, waitForInput: true, clearScreen: true);
            ShowMessage(message);
        }
        public static void ShowInfo(string text)
        {
            var message = new Message(text, MessageKind.Information, waitForInput: true, clearScreen: false);
            ShowMessage(message);
        }
        private static void ShowMessage(Message message)
        {
            string prefix = $"{message.Kind}";
            Console.WriteLine($"{prefix.ToUpper()}: {message.Text}");

            if (message.WaitForInput)
            {
                Console.WriteLine("(Press any key to proceed)");
                Console.ReadKey();
            }
            if (message.ClearScreen)
            {
                Console.Clear();
            }
        }
    }
}
