
namespace AutoschoolAIS.Components.Lesson
{
    partial class LessonCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonCreateForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.cancelBtn = new System.Windows.Forms.ToolStripButton();
            this.startAtDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursNUD = new System.Windows.Forms.NumericUpDown();
            this.isPassedCB = new System.Windows.Forms.CheckBox();
            this.teacherIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label2 = new System.Windows.Forms.Label();
            this.groupIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label1 = new System.Windows.Forms.Label();
            this.modeTC = new System.Windows.Forms.TabControl();
            this.studentTP = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.studentIC = new AutoschoolAIS.Controls.IdsChooser();
            this.groupTP = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).BeginInit();
            this.modeTC.SuspendLayout();
            this.studentTP.SuspendLayout();
            this.groupTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn,
            this.cancelBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(246, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "Записать";
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
            // cancelBtn
            // 
            this.cancelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelBtn.Image = global::AutoschoolAIS.Properties.Resources.error_16;
            this.cancelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(23, 22);
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // startAtDTP
            // 
            this.startAtDTP.Location = new System.Drawing.Point(12, 218);
            this.startAtDTP.Name = "startAtDTP";
            this.startAtDTP.Size = new System.Drawing.Size(219, 20);
            this.startAtDTP.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Кол-во часов";
            // 
            // hoursNUD
            // 
            this.hoursNUD.Location = new System.Drawing.Point(12, 179);
            this.hoursNUD.Name = "hoursNUD";
            this.hoursNUD.Size = new System.Drawing.Size(219, 20);
            this.hoursNUD.TabIndex = 18;
            // 
            // isPassedCB
            // 
            this.isPassedCB.AutoSize = true;
            this.isPassedCB.Location = new System.Drawing.Point(12, 143);
            this.isPassedCB.Name = "isPassedCB";
            this.isPassedCB.Size = new System.Drawing.Size(70, 17);
            this.isPassedCB.TabIndex = 17;
            this.isPassedCB.Text = "Пройден";
            this.isPassedCB.UseVisualStyleBackColor = true;
            // 
            // teacherIC
            // 
            this.teacherIC.BackColor = System.Drawing.SystemColors.Window;
            this.teacherIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherIC.GetTextById = null;
            this.teacherIC.Id = null;
            this.teacherIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("teacherIC.Ids")));
            this.teacherIC.IsMultiselect = false;
            this.teacherIC.Location = new System.Drawing.Point(12, 117);
            this.teacherIC.Name = "teacherIC";
            this.teacherIC.Size = new System.Drawing.Size(219, 20);
            this.teacherIC.SqlGetTextById = null;
            this.teacherIC.TabIndex = 15;
            this.teacherIC.Text = "Пусто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Учитель";
            // 
            // groupIC
            // 
            this.groupIC.BackColor = System.Drawing.SystemColors.Window;
            this.groupIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupIC.GetTextById = null;
            this.groupIC.Id = null;
            this.groupIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupIC.Ids")));
            this.groupIC.IsMultiselect = false;
            this.groupIC.Location = new System.Drawing.Point(6, 19);
            this.groupIC.Name = "groupIC";
            this.groupIC.Size = new System.Drawing.Size(203, 20);
            this.groupIC.SqlGetTextById = null;
            this.groupIC.TabIndex = 14;
            this.groupIC.Text = "Пусто";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Группа студентов";
            // 
            // modeTC
            // 
            this.modeTC.Controls.Add(this.studentTP);
            this.modeTC.Controls.Add(this.groupTP);
            this.modeTC.Location = new System.Drawing.Point(12, 28);
            this.modeTC.Name = "modeTC";
            this.modeTC.SelectedIndex = 0;
            this.modeTC.Size = new System.Drawing.Size(223, 70);
            this.modeTC.TabIndex = 22;
            // 
            // studentTP
            // 
            this.studentTP.Controls.Add(this.label5);
            this.studentTP.Controls.Add(this.studentIC);
            this.studentTP.Location = new System.Drawing.Point(4, 22);
            this.studentTP.Name = "studentTP";
            this.studentTP.Padding = new System.Windows.Forms.Padding(3);
            this.studentTP.Size = new System.Drawing.Size(215, 44);
            this.studentTP.TabIndex = 0;
            this.studentTP.Text = "Для студента";
            this.studentTP.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Студент";
            // 
            // studentIC
            // 
            this.studentIC.BackColor = System.Drawing.SystemColors.Window;
            this.studentIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIC.GetTextById = null;
            this.studentIC.Id = null;
            this.studentIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("studentIC.Ids")));
            this.studentIC.IsMultiselect = false;
            this.studentIC.Location = new System.Drawing.Point(6, 19);
            this.studentIC.Name = "studentIC";
            this.studentIC.Size = new System.Drawing.Size(203, 20);
            this.studentIC.SqlGetTextById = null;
            this.studentIC.TabIndex = 16;
            this.studentIC.Text = "Пусто";
            // 
            // groupTP
            // 
            this.groupTP.Controls.Add(this.label1);
            this.groupTP.Controls.Add(this.groupIC);
            this.groupTP.Location = new System.Drawing.Point(4, 22);
            this.groupTP.Name = "groupTP";
            this.groupTP.Padding = new System.Windows.Forms.Padding(3);
            this.groupTP.Size = new System.Drawing.Size(215, 44);
            this.groupTP.TabIndex = 1;
            this.groupTP.Text = "Для группы студентов";
            this.groupTP.UseVisualStyleBackColor = true;
            // 
            // LessonCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 253);
            this.Controls.Add(this.modeTC);
            this.Controls.Add(this.startAtDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoursNUD);
            this.Controls.Add(this.isPassedCB);
            this.Controls.Add(this.teacherIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonCreateForm";
            this.Text = "Создание уроков";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).EndInit();
            this.modeTC.ResumeLayout(false);
            this.studentTP.ResumeLayout(false);
            this.studentTP.PerformLayout();
            this.groupTP.ResumeLayout(false);
            this.groupTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.ToolStripButton cancelBtn;
        private System.Windows.Forms.DateTimePicker startAtDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hoursNUD;
        private System.Windows.Forms.CheckBox isPassedCB;
        private Controls.IdsChooser teacherIC;
        private System.Windows.Forms.Label label2;
        private Controls.IdsChooser groupIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl modeTC;
        private System.Windows.Forms.TabPage studentTP;
        private System.Windows.Forms.Label label5;
        private Controls.IdsChooser studentIC;
        private System.Windows.Forms.TabPage groupTP;
    }
}