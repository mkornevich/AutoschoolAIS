
namespace AutoschoolAIS.Services.Messages
{
    partial class MessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messagesTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messagesTB
            // 
            this.messagesTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagesTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.messagesTB.Location = new System.Drawing.Point(12, 0);
            this.messagesTB.Multiline = true;
            this.messagesTB.Name = "messagesTB";
            this.messagesTB.ReadOnly = true;
            this.messagesTB.Size = new System.Drawing.Size(290, 407);
            this.messagesTB.TabIndex = 0;
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 407);
            this.Controls.Add(this.messagesTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessagesForm";
            this.Text = "Сообщения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesTB;
    }
}