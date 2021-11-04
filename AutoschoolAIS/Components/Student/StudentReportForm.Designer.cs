
namespace AutoschoolAIS.Components.Student
{
    partial class StudentReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReportForm));
            this.buildBtn = new System.Windows.Forms.Button();
            this.studentIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(12, 82);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(217, 23);
            this.buildBtn.TabIndex = 5;
            this.buildBtn.Text = "Посторить отчет";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.BuildReportAct);
            // 
            // studentIC
            // 
            this.studentIC.BackColor = System.Drawing.SystemColors.Window;
            this.studentIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIC.GetTextById = null;
            this.studentIC.Id = null;
            this.studentIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("studentIC.Ids")));
            this.studentIC.IsMultiselect = false;
            this.studentIC.Location = new System.Drawing.Point(12, 25);
            this.studentIC.Name = "studentIC";
            this.studentIC.Size = new System.Drawing.Size(217, 20);
            this.studentIC.SqlGetTextById = null;
            this.studentIC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Студент";
            // 
            // StudentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 116);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.studentIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentReportForm";
            this.Text = "Отчет по студентам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buildBtn;
        private Controls.IdsChooser studentIC;
        private System.Windows.Forms.Label label1;
    }
}