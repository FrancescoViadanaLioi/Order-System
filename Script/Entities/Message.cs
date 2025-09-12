using System;
using OrderSystem.Entities.EntitiesEnum;

namespace OrderSystem.Entities
{
    internal class Message
    {
        public string Text { get; set; }
        public MessageKind Kind { get; set; }
        public bool WaitForInput { get; set; }
        public bool ClearScreen { get; set; }

        public Message(string text, MessageKind kind, bool waitForInput, bool clearScreen)
        {
            Text = text;
            Kind = kind;
            WaitForInput = waitForInput;
            ClearScreen = clearScreen;
        }
    }
}
