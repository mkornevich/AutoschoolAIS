
namespace AutoschoolAIS.Components.Lesson
{
    partial class LessonListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.filterBtn = new System.Windows.Forms.ToolStripButton();
            this.reloadBtn = new System.Windows.Forms.ToolStripButton();
            this.tableView = new AutoschoolAIS.Controls.TableView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPassedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBtn,
            this.deleteBtn,
            this.editBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchTB,
            this.filterBtn,
            this.reloadBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createBtn
            // 
            this.createBtn.Image = global::AutoschoolAIS.Properties.Resources.add_16;
            this.createBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(23, 22);
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::AutoschoolAIS.Properties.Resources.minus_16;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editBtn.Image = global::AutoschoolAIS.Properties.Resources.edit_16;
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(23, 22);
            this.editBtn.Text = "toolStripButton4";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 25);
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // filterBtn
            // 
            this.filterBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filterBtn.Image = global::AutoschoolAIS.Properties.Resources.filter_16;
            this.filterBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(23, 22);
            this.filterBtn.Text = "toolStripButton1";
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloadBtn.Image")));
            this.reloadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(23, 22);
            this.reloadBtn.Text = "toolStripButton3";
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.AllowUserToResizeRows = false;
            this.tableView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.StudentNameColumn,
            this.TeacherNameColumn,
            this.IsPassedColumn,
            this.HoursColumn,
            this.StartAtColumn});
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("tableView.Ids")));
            this.tableView.IsMultiselect = false;
            this.tableView.Location = new System.Drawing.Point(0, 25);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersVisible = false;
            this.tableView.SelectedId = null;
            this.tableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView.Size = new System.Drawing.Size(800, 425);
            this.tableView.TabIndex = 4;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // StudentNameColumn
            // 
            this.StudentNameColumn.DataPropertyName = "StudentName";
            this.StudentNameColumn.HeaderText = "Студент";
            this.StudentNameColumn.Name = "StudentNameColumn";
            this.StudentNameColumn.ReadOnly = true;
            this.StudentNameColumn.Width = 200;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.DataPropertyName = "TeacherName";
            this.TeacherNameColumn.HeaderText = "Учитель";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.ReadOnly = true;
            this.TeacherNameColumn.Width = 200;
            // 
            // IsPassedColumn
            // 
            this.IsPassedColumn.DataPropertyName = "IsPassed";
            this.IsPassedColumn.HeaderText = "Пройден";
            this.IsPassedColumn.Name = "IsPassedColumn";
            this.IsPassedColumn.ReadOnly = true;
            // 
            // HoursColumn
            // 
            this.HoursColumn.DataPropertyName = "Hours";
            this.HoursColumn.HeaderText = "Кол-во часов";
            this.HoursColumn.Name = "HoursColumn";
            this.HoursColumn.ReadOnly = true;
            // 
            // StartAtColumn
            // 
            this.StartAtColumn.DataPropertyName = "StartAt";
            this.StartAtColumn.HeaderText = "Начало";
            this.StartAtColumn.Name = "StartAtColumn";
            this.StartAtColumn.ReadOnly = true;
            this.StartAtColumn.Width = 150;
            // 
            // LessonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LessonListForm";
            this.Text = "Уроки";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createBtn;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripButton editBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchTB;
        private System.Windows.Forms.ToolStripButton filterBtn;
        private System.Windows.Forms.ToolStripButton reloadBtn;
        private Controls.TableView tableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPassedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAtColumn;
    }
}