
namespace AutoschoolAIS.Components.Teacher
{
    partial class TeacherEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.userIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectIC = new AutoschoolAIS.Controls.IdsChooser();
            this.label3 = new System.Windows.Forms.Label();
            this.pinnedCarIC = new AutoschoolAIS.Controls.IdsChooser();
            this.isWorkedCB = new System.Windows.Forms.CheckBox();
            this.createdAtDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(256, 25);
            this.toolStrip1.TabIndex = 5;
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
            // userIC
            // 
            this.userIC.BackColor = System.Drawing.SystemColors.Window;
            this.userIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIC.GetTextById = null;
            this.userIC.Id = null;
            this.userIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("userIC.Ids")));
            this.userIC.IsMultiselect = false;
            this.userIC.Location = new System.Drawing.Point(12, 41);
            this.userIC.Name = "userIC";
            this.userIC.Size = new System.Drawing.Size(232, 20);
            this.userIC.SqlGetTextById = null;
            this.userIC.TabIndex = 6;
            this.userIC.Text = "Пусто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Предмет";
            // 
            // subjectIC
            // 
            this.subjectIC.BackColor = System.Drawing.SystemColors.Window;
            this.subjectIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectIC.GetTextById = null;
            this.subjectIC.Id = null;
            this.subjectIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("subjectIC.Ids")));
            this.subjectIC.IsMultiselect = false;
            this.subjectIC.Location = new System.Drawing.Point(12, 80);
            this.subjectIC.Name = "subjectIC";
            this.subjectIC.Size = new System.Drawing.Size(232, 20);
            this.subjectIC.SqlGetTextById = null;
            this.subjectIC.TabIndex = 7;
            this.subjectIC.Text = "Пусто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Закрепленный автомобиль";
            // 
            // pinnedCarIC
            // 
            this.pinnedCarIC.BackColor = System.Drawing.SystemColors.Window;
            this.pinnedCarIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinnedCarIC.GetTextById = null;
            this.pinnedCarIC.Id = null;
            this.pinnedCarIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("pinnedCarIC.Ids")));
            this.pinnedCarIC.IsMultiselect = false;
            this.pinnedCarIC.Location = new System.Drawing.Point(12, 119);
            this.pinnedCarIC.Name = "pinnedCarIC";
            this.pinnedCarIC.Size = new System.Drawing.Size(232, 20);
            this.pinnedCarIC.SqlGetTextById = null;
            this.pinnedCarIC.TabIndex = 8;
            this.pinnedCarIC.Text = "Пусто";
            // 
            // isWorkedCB
            // 
            this.isWorkedCB.AutoSize = true;
            this.isWorkedCB.Location = new System.Drawing.Point(12, 145);
            this.isWorkedCB.Name = "isWorkedCB";
            this.isWorkedCB.Size = new System.Drawing.Size(73, 17);
            this.isWorkedCB.TabIndex = 9;
            this.isWorkedCB.Text = "Работает";
            this.isWorkedCB.UseVisualStyleBackColor = true;
            // 
            // createdAtDTP
            // 
            this.createdAtDTP.Location = new System.Drawing.Point(12, 181);
            this.createdAtDTP.Name = "createdAtDTP";
            this.createdAtDTP.Size = new System.Drawing.Size(232, 20);
            this.createdAtDTP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата начала работы";
            // 
            // TeacherEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createdAtDTP);
            this.Controls.Add(this.isWorkedCB);
            this.Controls.Add(this.pinnedCarIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subjectIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userIC);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherEditForm";
            this.Text = "Учитель";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private Controls.IdsChooser userIC;
        private System.Windows.Forms.Label label2;
        private Controls.IdsChooser subjectIC;
        private System.Windows.Forms.Label label3;
        private Controls.IdsChooser pinnedCarIC;
        private System.Windows.Forms.CheckBox isWorkedCB;
        private System.Windows.Forms.DateTimePicker createdAtDTP;
        private System.Windows.Forms.Label label4;
    }
}