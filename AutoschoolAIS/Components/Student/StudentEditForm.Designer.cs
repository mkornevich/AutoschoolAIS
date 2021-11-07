
namespace AutoschoolAIS.Components.Student
{
    partial class StudentEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.userIC = new AutoschoolAIS.Controls.IdsChooser();
            this.groupIC = new AutoschoolAIS.Controls.IdsChooser();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.userIC.Size = new System.Drawing.Size(260, 20);
            this.userIC.SqlGetTextById = null;
            this.userIC.TabIndex = 5;
            this.userIC.Text = "This is text";
            // 
            // groupIC
            // 
            this.groupIC.BackColor = System.Drawing.SystemColors.Window;
            this.groupIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupIC.GetTextById = null;
            this.groupIC.Id = null;
            this.groupIC.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupIC.Ids")));
            this.groupIC.IsMultiselect = false;
            this.groupIC.Location = new System.Drawing.Point(12, 80);
            this.groupIC.Name = "groupIC";
            this.groupIC.Size = new System.Drawing.Size(260, 20);
            this.groupIC.SqlGetTextById = null;
            this.groupIC.TabIndex = 6;
            this.groupIC.Text = "This is text";
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.groupIC);
            this.Controls.Add(this.userIC);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentEditForm";
            this.Text = "Студент";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private Controls.IdsChooser userIC;
        private Controls.IdsChooser groupIC;
    }
}