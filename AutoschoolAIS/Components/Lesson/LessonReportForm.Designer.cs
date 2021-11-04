
namespace AutoschoolAIS.Components.Lesson
{
    partial class LessonReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonReportForm));
            this.buildBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupIC = new AutoschoolAIS.Controls.IdsChooser();
            this.SuspendLayout();
            // 
            // buildBtn
            // 
            this.buildBtn.Location = new System.Drawing.Point(12, 77);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Size = new System.Drawing.Size(217, 23);
            this.buildBtn.TabIndex = 5;
            this.buildBtn.Text = "Посторить отчет";
            this.buildBtn.UseVisualStyleBackColor = true;
            this.buildBtn.Click += new System.EventHandler(this.BuildReportAct);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группа";
            // 
            // groupIC
            // 
            this.groupIC.BackColor = System.Drawing.SystemColors.Window;
            this.groupIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupIC.GetTextById = null;
            this.groupIC.Id = null;
            this.groupIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupIC.Ids")));
            this.groupIC.IsMultiselect = false;
            this.groupIC.Location = new System.Drawing.Point(12, 25);
            this.groupIC.Name = "groupIC";
            this.groupIC.Size = new System.Drawing.Size(217, 20);
            this.groupIC.SqlGetTextById = null;
            this.groupIC.TabIndex = 4;
            this.groupIC.Text = "Пусто";
            // 
            // LessonReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 115);
            this.Controls.Add(this.buildBtn);
            this.Controls.Add(this.groupIC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonReportForm";
            this.Text = "Отчет по урокам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buildBtn;
        private Controls.IdsChooser groupIC;
        private System.Windows.Forms.Label label1;
    }
}