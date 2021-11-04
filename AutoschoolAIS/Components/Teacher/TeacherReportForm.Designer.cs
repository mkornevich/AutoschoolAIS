
namespace AutoschoolAIS.Components.Teacher
{
    partial class TeacherReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.teacherIC = new AutoschoolAIS.Controls.IdsChooser();
            this.buildBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учитель";
            // 
            // teacherIC
            // 
            this.teacherIC.BackColor = System.Drawing.SystemColors.Window;
            this.teacherIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherIC.GetTextById = null;
            this.teacherIC.Id = null;
            this.teacherIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("teacherIC.Ids")));
            this.teacherIC.IsMultiselect = false;
            this.teacherIC.Location = new System.Drawing.Point(12, 25);
            this.teacherIC.Name = "teacherIC";
            this.teacherIC.Size = new System.Drawing.Size(217, 20);
            this.teacherIC.SqlGetTextById = null;
            this.teacherIC.TabIndex = 1;
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(12, 82);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(217, 23);
            this.buildBtn.TabIndex = 2;
            this.buildBtn.Text = "Посторить отчет";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.BuildReportAct);
            // 
            // TeacherReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 118);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.teacherIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherReportForm";
            this.Text = "Отчет по учителям";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.IdsChooser teacherIC;
        private System.Windows.Forms.Button buildBtn;
    }
}