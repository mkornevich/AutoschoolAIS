using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Services.Messages
{
    public partial class MessagesForm : Form
    {
        public List<Message> Messages
        {
            set
            {
                messagesTB.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    var index = (i + 1).ToString();
                    var text = value[i].Text;
                    var type = MessageTypeToString(value[i].Type);
                    messagesTB.Text += index + ") " + type + "\r\n" + text + "\r\n\r\n";
                }
            }
        }

        private string MessageTypeToString(MessageType type)
        {
            switch(type)
            {
                case MessageType.Error:
                    return "Ошибка";
                case MessageType.Warning:
                    return "Предупреждение";
                case MessageType.Info:
                    return "Информация";
                default:
                    return "Не распознано";
            }
        }

        public MessagesForm()
        {
            InitializeComponent();
        }
    }
}
