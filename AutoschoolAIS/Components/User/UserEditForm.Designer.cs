
namespace AutoschoolAIS.Components.User
{
    partial class UserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.passwordVisibleCB = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(322, 25);
            this.toolStrip1.TabIndex = 0;
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
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 41);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(298, 20);
            this.nameTB.TabIndex = 1;
            this.nameTB.Text = "Text box component";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(12, 80);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(298, 20);
            this.emailTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(12, 119);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(276, 20);
            this.passwordTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Роль";
            // 
            // roleCB
            // 
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Items.AddRange(new object[] {
            "admin",
            "view",
            "guest"});
            this.roleCB.Location = new System.Drawing.Point(12, 158);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(298, 21);
            this.roleCB.TabIndex = 8;
            // 
            // passwordVisibleCB
            // 
            this.passwordVisibleCB.AutoSize = true;
            this.passwordVisibleCB.Location = new System.Drawing.Point(295, 122);
            this.passwordVisibleCB.Name = "passwordVisibleCB";
            this.passwordVisibleCB.Size = new System.Drawing.Size(15, 14);
            this.passwordVisibleCB.TabIndex = 9;
            this.passwordVisibleCB.UseVisualStyleBackColor = true;
            this.passwordVisibleCB.CheckedChanged += new System.EventHandler(this.passwordVisibleCB_CheckedChanged);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.passwordVisibleCB);
            this.Controls.Add(this.roleCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEditForm";
            this.Text = "Пользователь";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.CheckBox passwordVisibleCB;
    }
}