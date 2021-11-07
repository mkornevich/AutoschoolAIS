
namespace AutoschoolAIS.Components.Lesson
{
    partial class LessonFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonFilterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursCB = new System.Windows.Forms.CheckBox();
            this.hoursFromNUD = new System.Windows.Forms.NumericUpDown();
            this.hoursToNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startAtFromDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.startAtToDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.isPassedCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupIC = new AutoschoolAIS.Controls.IdsChooser();
            this.teacherIC = new AutoschoolAIS.Controls.IdsChooser();
            this.subjectIC = new AutoschoolAIS.Controls.IdsChooser();
            this.studentIC = new AutoschoolAIS.Controls.IdsChooser();
            ((System.ComponentModel.ISupportInitialize)(this.hoursFromNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursToNUD)).BeginInit();
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
            this.searchTB.Size = new System.Drawing.Size(213, 20);
            this.searchTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Студент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Учитель";
            // 
            // hoursCB
            // 
            this.hoursCB.AutoSize = true;
            this.hoursCB.Location = new System.Drawing.Point(12, 247);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(92, 17);
            this.hoursCB.TabIndex = 8;
            this.hoursCB.Text = "Кол-во часов";
            this.hoursCB.UseVisualStyleBackColor = true;
            // 
            // hoursFromNUD
            // 
            this.hoursFromNUD.Location = new System.Drawing.Point(12, 270);
            this.hoursFromNUD.Name = "hoursFromNUD";
            this.hoursFromNUD.Size = new System.Drawing.Size(103, 20);
            this.hoursFromNUD.TabIndex = 9;
            // 
            // hoursToNUD
            // 
            this.hoursToNUD.Location = new System.Drawing.Point(121, 270);
            this.hoursToNUD.Name = "hoursToNUD";
            this.hoursToNUD.Size = new System.Drawing.Size(104, 20);
            this.hoursToNUD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Начало от";
            // 
            // startAtFromDTP
            // 
            this.startAtFromDTP.Checked = false;
            this.startAtFromDTP.Location = new System.Drawing.Point(12, 309);
            this.startAtFromDTP.Name = "startAtFromDTP";
            this.startAtFromDTP.ShowCheckBox = true;
            this.startAtFromDTP.Size = new System.Drawing.Size(213, 20);
            this.startAtFromDTP.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // startAtToDTP
            // 
            this.startAtToDTP.Checked = false;
            this.startAtToDTP.Location = new System.Drawing.Point(12, 348);
            this.startAtToDTP.Name = "startAtToDTP";
            this.startAtToDTP.ShowCheckBox = true;
            this.startAtToDTP.Size = new System.Drawing.Size(213, 20);
            this.startAtToDTP.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Группа";
            // 
            // isPassedCB
            // 
            this.isPassedCB.FormattingEnabled = true;
            this.isPassedCB.Items.AddRange(new object[] {
            "",
            "Пройден",
            "Не пройден"});
            this.isPassedCB.Location = new System.Drawing.Point(12, 220);
            this.isPassedCB.Name = "isPassedCB";
            this.isPassedCB.Size = new System.Drawing.Size(213, 21);
            this.isPassedCB.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Пройден";
            // 
            // groupIC
            // 
            this.groupIC.BackColor = System.Drawing.SystemColors.Window;
            this.groupIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupIC.GetTextById = null;
            this.groupIC.Id = null;
            this.groupIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupIC.Ids")));
            this.groupIC.IsMultiselect = true;
            this.groupIC.Location = new System.Drawing.Point(12, 64);
            this.groupIC.Name = "groupIC";
            this.groupIC.Size = new System.Drawing.Size(213, 20);
            this.groupIC.SqlGetTextById = null;
            this.groupIC.TabIndex = 18;
            this.groupIC.Text = "Пусто";
            // 
            // teacherIC
            // 
            this.teacherIC.BackColor = System.Drawing.SystemColors.Window;
            this.teacherIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherIC.GetTextById = null;
            this.teacherIC.Id = null;
            this.teacherIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("teacherIC.Ids")));
            this.teacherIC.IsMultiselect = true;
            this.teacherIC.Location = new System.Drawing.Point(12, 181);
            this.teacherIC.Name = "teacherIC";
            this.teacherIC.Size = new System.Drawing.Size(213, 20);
            this.teacherIC.SqlGetTextById = null;
            this.teacherIC.TabIndex = 17;
            this.teacherIC.Text = "Пусто";
            // 
            // subjectIC
            // 
            this.subjectIC.BackColor = System.Drawing.SystemColors.Window;
            this.subjectIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectIC.GetTextById = null;
            this.subjectIC.Id = null;
            this.subjectIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("subjectIC.Ids")));
            this.subjectIC.IsMultiselect = true;
            this.subjectIC.Location = new System.Drawing.Point(12, 142);
            this.subjectIC.Name = "subjectIC";
            this.subjectIC.Size = new System.Drawing.Size(213, 20);
            this.subjectIC.SqlGetTextById = null;
            this.subjectIC.TabIndex = 16;
            this.subjectIC.Text = "Пусто";
            // 
            // studentIC
            // 
            this.studentIC.BackColor = System.Drawing.SystemColors.Window;
            this.studentIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIC.GetTextById = null;
            this.studentIC.Id = null;
            this.studentIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("studentIC.Ids")));
            this.studentIC.IsMultiselect = true;
            this.studentIC.Location = new System.Drawing.Point(12, 103);
            this.studentIC.Name = "studentIC";
            this.studentIC.Size = new System.Drawing.Size(213, 20);
            this.studentIC.SqlGetTextById = null;
            this.studentIC.TabIndex = 15;
            this.studentIC.Text = "Пусто";
            // 
            // LessonFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 382);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.isPassedCB);
            this.Controls.Add(this.groupIC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teacherIC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subjectIC);
            this.Controls.Add(this.studentIC);
            this.Controls.Add(this.startAtToDTP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startAtFromDTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hoursToNUD);
            this.Controls.Add(this.hoursFromNUD);
            this.Controls.Add(this.hoursCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LessonFilterForm";
            this.Text = "Фильтр уроков";
            ((System.ComponentModel.ISupportInitialize)(this.hoursFromNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursToNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hoursCB;
        private System.Windows.Forms.NumericUpDown hoursFromNUD;
        private System.Windows.Forms.NumericUpDown hoursToNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startAtFromDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startAtToDTP;
        private Controls.IdsChooser studentIC;
        private Controls.IdsChooser subjectIC;
        private Controls.IdsChooser teacherIC;
        private System.Windows.Forms.Label label7;
        private Controls.IdsChooser groupIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox isPassedCB;
        private System.Windows.Forms.Label label8;
    }
}