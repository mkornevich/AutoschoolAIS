using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services.Messages
{
    public class Message
    {
        public MessageType Type { get; set; }

        public string Text { get; set; }

        public Message(string text, MessageType type)
        {
            Text = text;
            Type = type;
        }
    }
}
