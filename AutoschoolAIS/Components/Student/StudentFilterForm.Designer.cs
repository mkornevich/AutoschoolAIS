
namespace AutoschoolAIS.Components.Student
{
    partial class StudentFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFilterForm));
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupIC = new AutoschoolAIS.Controls.IdsChooser();
            this.SuspendLayout();
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(12, 25);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(215, 20);
            this.searchTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // groupIC
            // 
            this.groupIC.BackColor = System.Drawing.SystemColors.Window;
            this.groupIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupIC.GetTextById = null;
            this.groupIC.Id = null;
            this.groupIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupIC.Ids")));
            this.groupIC.IsMultiselect = false;
            this.groupIC.Location = new System.Drawing.Point(12, 64);
            this.groupIC.Name = "groupIC";
            this.groupIC.Size = new System.Drawing.Size(215, 20);
            this.groupIC.SqlGetTextById = null;
            this.groupIC.TabIndex = 4;
            this.groupIC.Text = "Пусто";
            // 
            // StudentFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 98);
            this.Controls.Add(this.groupIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentFilterForm";
            this.Text = "Фильтр студентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox searchTB;
        public Controls.IdsChooser groupIC;
    }
}