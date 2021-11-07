
namespace AutoschoolAIS.Components.Lesson
{
    partial class LessonEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.studentIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherIC = new AutoschoolAIS.Controls.IdsChooser();
            this.isPassedCB = new System.Windows.Forms.CheckBox();
            this.hoursNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startAtDTP = new System.Windows.Forms.DateTimePicker();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студент";
            // 
            // studentIC
            // 
            this.studentIC.BackColor = System.Drawing.SystemColors.Window;
            this.studentIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIC.GetTextById = null;
            this.studentIC.Id = null;
            this.studentIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("studentIC.Ids")));
            this.studentIC.IsMultiselect = false;
            this.studentIC.Location = new System.Drawing.Point(12, 41);
            this.studentIC.Name = "studentIC";
            this.studentIC.Size = new System.Drawing.Size(192, 20);
            this.studentIC.SqlGetTextById = null;
            this.studentIC.TabIndex = 6;
            this.studentIC.Text = "Пусто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Учитель";
            // 
            // teacherIC
            // 
            this.teacherIC.BackColor = System.Drawing.SystemColors.Window;
            this.teacherIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherIC.GetTextById = null;
            this.teacherIC.Id = null;
            this.teacherIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("teacherIC.Ids")));
            this.teacherIC.IsMultiselect = false;
            this.teacherIC.Location = new System.Drawing.Point(12, 80);
            this.teacherIC.Name = "teacherIC";
            this.teacherIC.Size = new System.Drawing.Size(192, 20);
            this.teacherIC.SqlGetTextById = null;
            this.teacherIC.TabIndex = 7;
            this.teacherIC.Text = "Пусто";
            // 
            // isPassedCB
            // 
            this.isPassedCB.AutoSize = true;
            this.isPassedCB.Location = new System.Drawing.Point(12, 106);
            this.isPassedCB.Name = "isPassedCB";
            this.isPassedCB.Size = new System.Drawing.Size(70, 17);
            this.isPassedCB.TabIndex = 8;
            this.isPassedCB.Text = "Пройден";
            this.isPassedCB.UseVisualStyleBackColor = true;
            // 
            // hoursNUD
            // 
            this.hoursNUD.Location = new System.Drawing.Point(12, 142);
            this.hoursNUD.Name = "hoursNUD";
            this.hoursNUD.Size = new System.Drawing.Size(192, 20);
            this.hoursNUD.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кол-во часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Начало";
            // 
            // startAtDTP
            // 
            this.startAtDTP.Location = new System.Drawing.Point(12, 181);
            this.startAtDTP.Name = "startAtDTP";
            this.startAtDTP.Size = new System.Drawing.Size(192, 20);
            this.startAtDTP.TabIndex = 12;
            // 
            // okBtn
            // 
            this.okBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.okBtn.Image = global::AutoschoolAIS.Properties.Resources.ok_16;
            this.okBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(23, 22);
            this.okBtn.Text = "Записать";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(216, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "Записать";
            // 
            // LessonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 212);
            this.Controls.Add(this.startAtDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoursNUD);
            this.Controls.Add(this.isPassedCB);
            this.Controls.Add(this.teacherIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentIC);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonEditForm";
            this.Text = "Урок";
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.IdsChooser studentIC;
        private System.Windows.Forms.Label label2;
        private Controls.IdsChooser teacherIC;
        private System.Windows.Forms.CheckBox isPassedCB;
        private System.Windows.Forms.NumericUpDown hoursNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startAtDTP;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}