
namespace AutoschoolAIS.Components.GroupSubjectHours
{
    partial class GroupSubjectHoursEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupSubjectHoursEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursNUD = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.cancelBtn = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.subjectIC = new AutoschoolAIS.Controls.IdsChooser();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группа:";
            // 
            // groupL
            // 
            this.groupL.AutoSize = true;
            this.groupL.Location = new System.Drawing.Point(70, 25);
            this.groupL.Name = "groupL";
            this.groupL.Size = new System.Drawing.Size(10, 13);
            this.groupL.TabIndex = 1;
            this.groupL.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во часов";
            // 
            // hoursNUD
            // 
            this.hoursNUD.Location = new System.Drawing.Point(12, 102);
            this.hoursNUD.Name = "hoursNUD";
            this.hoursNUD.Size = new System.Drawing.Size(234, 20);
            this.hoursNUD.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn,
            this.cancelBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(258, 25);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Предмет";
            // 
            // subjectIC
            // 
            this.subjectIC.BackColor = System.Drawing.SystemColors.Window;
            this.subjectIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectIC.GetTextById = null;
            this.subjectIC.Id = null;
            this.subjectIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("subjectIC.Ids")));
            this.subjectIC.IsMultiselect = false;
            this.subjectIC.Location = new System.Drawing.Point(12, 63);
            this.subjectIC.Name = "subjectIC";
            this.subjectIC.Size = new System.Drawing.Size(234, 20);
            this.subjectIC.SqlGetTextById = null;
            this.subjectIC.TabIndex = 7;
            this.subjectIC.Text = "Пусто";
            // 
            // GroupSubjectHoursEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 138);
            this.Controls.Add(this.subjectIC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.hoursNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupSubjectHoursEditForm";
            this.Text = "Часы у группы на предмете";
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groupL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hoursNUD;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.ToolStripButton cancelBtn;
        private System.Windows.Forms.Label label5;
        private Controls.IdsChooser subjectIC;
    }
}