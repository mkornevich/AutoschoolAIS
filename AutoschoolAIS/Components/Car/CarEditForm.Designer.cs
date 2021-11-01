
namespace AutoschoolAIS.Components.Car
{
    partial class CarEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEditForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.cancelBtn = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.commentTB = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn,
            this.cancelBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(261, 25);
            this.toolStrip1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 41);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(237, 20);
            this.nameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер";
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(12, 80);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(237, 20);
            this.numberTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Комментарий";
            // 
            // commentTB
            // 
            this.commentTB.Location = new System.Drawing.Point(12, 119);
            this.commentTB.Multiline = true;
            this.commentTB.Name = "commentTB";
            this.commentTB.Size = new System.Drawing.Size(237, 151);
            this.commentTB.TabIndex = 7;
            // 
            // CarEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 283);
            this.Controls.Add(this.commentTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarEditForm";
            this.Text = "Автомобиль";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.ToolStripButton cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox commentTB;
    }
}