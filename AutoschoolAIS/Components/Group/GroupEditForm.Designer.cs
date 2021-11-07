
namespace AutoschoolAIS.Components.Group
{
    partial class GroupEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupEditForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.okBtn = new System.Windows.Forms.ToolStripButton();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commentTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startAtDTP = new System.Windows.Forms.DateTimePicker();
            this.endAtDTP = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupSubjectHoursTV = new AutoschoolAIS.Controls.TableView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.createGroupSubjectHoursBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteGroupSubjectHoursBtn = new System.Windows.Forms.ToolStripButton();
            this.editGroupSubjectHoursBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSubjectHoursTV)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(611, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // okBtn
            // 
            this.okBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.okBtn.Image = global::AutoschoolAIS.Properties.Resources.ok_16;
            this.okBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(23, 22);
            this.okBtn.Text = "toolStripButton1";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(12, 41);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(310, 20);
            this.nameTB.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Комментарий";
            // 
            // commentTB
            // 
            this.commentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTB.Location = new System.Drawing.Point(12, 80);
            this.commentTB.Multiline = true;
            this.commentTB.Name = "commentTB";
            this.commentTB.Size = new System.Drawing.Size(587, 82);
            this.commentTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начало";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Окончание";
            // 
            // startAtDTP
            // 
            this.startAtDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startAtDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startAtDTP.Location = new System.Drawing.Point(328, 41);
            this.startAtDTP.Name = "startAtDTP";
            this.startAtDTP.Size = new System.Drawing.Size(131, 20);
            this.startAtDTP.TabIndex = 7;
            this.startAtDTP.Value = new System.DateTime(2021, 10, 29, 23, 59, 0, 0);
            // 
            // endAtDTP
            // 
            this.endAtDTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endAtDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endAtDTP.Location = new System.Drawing.Point(465, 41);
            this.endAtDTP.Name = "endAtDTP";
            this.endAtDTP.Size = new System.Drawing.Size(133, 20);
            this.endAtDTP.TabIndex = 8;
            this.endAtDTP.Value = new System.DateTime(2021, 10, 29, 23, 59, 0, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 245);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupSubjectHoursTV);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Часы по предметам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupSubjectHoursTV
            // 
            this.groupSubjectHoursTV.AllowUserToAddRows = false;
            this.groupSubjectHoursTV.AllowUserToDeleteRows = false;
            this.groupSubjectHoursTV.AllowUserToResizeRows = false;
            this.groupSubjectHoursTV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.groupSubjectHoursTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupSubjectHoursTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupSubjectHoursTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.SubjectNameColumn,
            this.HoursColumn});
            this.groupSubjectHoursTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSubjectHoursTV.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupSubjectHoursTV.Ids")));
            this.groupSubjectHoursTV.IsMultiselect = false;
            this.groupSubjectHoursTV.Location = new System.Drawing.Point(3, 28);
            this.groupSubjectHoursTV.MultiSelect = false;
            this.groupSubjectHoursTV.Name = "groupSubjectHoursTV";
            this.groupSubjectHoursTV.ReadOnly = true;
            this.groupSubjectHoursTV.RowHeadersVisible = false;
            this.groupSubjectHoursTV.SelectedId = null;
            this.groupSubjectHoursTV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupSubjectHoursTV.Size = new System.Drawing.Size(573, 188);
            this.groupSubjectHoursTV.TabIndex = 4;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.DataPropertyName = "SubjectName";
            this.SubjectNameColumn.HeaderText = "Предмет";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            this.SubjectNameColumn.Width = 200;
            // 
            // HoursColumn
            // 
            this.HoursColumn.DataPropertyName = "Hours";
            this.HoursColumn.HeaderText = "Кол-во часов";
            this.HoursColumn.Name = "HoursColumn";
            this.HoursColumn.ReadOnly = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createGroupSubjectHoursBtn,
            this.deleteGroupSubjectHoursBtn,
            this.editGroupSubjectHoursBtn});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(573, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // createGroupSubjectHoursBtn
            // 
            this.createGroupSubjectHoursBtn.Image = global::AutoschoolAIS.Properties.Resources.add_16;
            this.createGroupSubjectHoursBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createGroupSubjectHoursBtn.Name = "createGroupSubjectHoursBtn";
            this.createGroupSubjectHoursBtn.Size = new System.Drawing.Size(23, 22);
            this.createGroupSubjectHoursBtn.Click += new System.EventHandler(this.createGroupSubjectHoursBtn_Click);
            // 
            // deleteGroupSubjectHoursBtn
            // 
            this.deleteGroupSubjectHoursBtn.Image = global::AutoschoolAIS.Properties.Resources.minus_16;
            this.deleteGroupSubjectHoursBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteGroupSubjectHoursBtn.Name = "deleteGroupSubjectHoursBtn";
            this.deleteGroupSubjectHoursBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteGroupSubjectHoursBtn.Click += new System.EventHandler(this.deleteGroupSubjectHoursBtn_Click);
            // 
            // editGroupSubjectHoursBtn
            // 
            this.editGroupSubjectHoursBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editGroupSubjectHoursBtn.Image = global::AutoschoolAIS.Properties.Resources.edit_16;
            this.editGroupSubjectHoursBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editGroupSubjectHoursBtn.Name = "editGroupSubjectHoursBtn";
            this.editGroupSubjectHoursBtn.Size = new System.Drawing.Size(23, 22);
            this.editGroupSubjectHoursBtn.Text = "toolStripButton4";
            this.editGroupSubjectHoursBtn.Click += new System.EventHandler(this.editGroupSubjectHoursBtn_Click);
            // 
            // GroupEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 425);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.endAtDTP);
            this.Controls.Add(this.startAtDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commentTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupEditForm";
            this.Text = "Группа";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSubjectHoursTV)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton okBtn;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commentTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startAtDTP;
        private System.Windows.Forms.DateTimePicker endAtDTP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton createGroupSubjectHoursBtn;
        private System.Windows.Forms.ToolStripButton deleteGroupSubjectHoursBtn;
        private System.Windows.Forms.ToolStripButton editGroupSubjectHoursBtn;
        private Controls.TableView groupSubjectHoursTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursColumn;
    }
}