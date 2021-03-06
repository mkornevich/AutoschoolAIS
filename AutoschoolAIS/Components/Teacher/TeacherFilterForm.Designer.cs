
namespace AutoschoolAIS.Components.Teacher
{
    partial class TeacherFilterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isWorkedCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(12, 25);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(216, 20);
            this.searchTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Работает";
            // 
            // isWorkedCB
            // 
            this.isWorkedCB.FormattingEnabled = true;
            this.isWorkedCB.Items.AddRange(new object[] {
            "",
            "Работает",
            "Не работает"});
            this.isWorkedCB.Location = new System.Drawing.Point(12, 64);
            this.isWorkedCB.Name = "isWorkedCB";
            this.isWorkedCB.Size = new System.Drawing.Size(216, 21);
            this.isWorkedCB.TabIndex = 5;
            // 
            // TeacherFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 99);
            this.Controls.Add(this.isWorkedCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherFilterForm";
            this.Text = "Фильтр учителей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox isWorkedCB;
    }
}