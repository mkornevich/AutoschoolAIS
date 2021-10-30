using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Controls
{
    public class Chooser : Panel
    {
        public event EventHandler ClickChoose
        {
            add => _button.Click += value;
            remove => _button.Click -= value;
        }

        public override string Text { get => _textBox.Text; set => _textBox.Text = value; }

        private TextBox _textBox = new TextBox()
        {
            BackColor = SystemColors.Window,
            BorderStyle = BorderStyle.None,
            Location = new Point(2, 3),
            Size = new Size(261, 13),
            ReadOnly = true,
            Anchor = AnchorStyles.Left | AnchorStyles.Right,
        };

        private Button _button = new Button()
        {
            UseVisualStyleBackColor = true,
            Size = new Size(23, 20),
            Location = new Point(267, 0),
            Text = "...",
            Font = new Font(FontFamily.GenericSansSerif, 6),
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
        };

        public Chooser()
        {
            Size = new Size(290, 20);
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(_button);
            Controls.Add(_textBox);
        }
    }
}
