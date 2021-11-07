using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services.Messages
{
    public class MessagesService
    {
        private List<Message> Messages { get; } = new List<Message>();

        public int ErrorCount => Messages.Count(m => m.Type == MessageType.Error);

        public bool HasErrors => ErrorCount > 0;

        public MessagesService Clear()
        {
            Messages.Clear();
            return this;
        }

        public MessagesService AddMessage(string text, MessageType type)
        {
            Messages.Add(new Message(text, type));
            return this;
        }

        public MessagesService AddError(string text)
        {
            return AddMessage(text, MessageType.Error);
        }

        public MessagesService AddError(bool cond, string text)
        {
            if (cond)
            {
                AddError(text);
            }
            return this;
        }

        public MessagesService AddWarning(string text)
        {
            return AddMessage(text, MessageType.Warning);
        }

        public MessagesService AddWarning(bool cond, string text)
        {
            if (cond)
            {
                AddWarning(text);
            }
            return this;
        }

        public MessagesService AddInfo(string text)
        {
            return AddMessage(text, MessageType.Info);
        }

        public MessagesService AddInfo(bool cond, string text)
        {
            if (cond)
            {
                AddInfo(text);
            }
            return this;
        }

        private MessagesForm CreateMessagesForm(bool asMdi)
        {
            var form = new MessagesForm();
            form.Messages = Messages;
            if (asMdi)
            {
                form.MdiParent = Env.MainForm;
            }
            return form;
        }

        public void Show(bool asMdi = true)
        {
            CreateMessagesForm(asMdi).Show();
        }

        public void ShowDialog(bool asMdi = true)
        {
            CreateMessagesForm(asMdi).ShowDialog();
        }
    }
}
