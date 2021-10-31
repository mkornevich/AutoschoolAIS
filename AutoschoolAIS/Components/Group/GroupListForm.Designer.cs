
namespace AutoschoolAIS.Components.Group
{
    partial class GroupListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.createBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.tableView = new AutoschoolAIS.Controls.TableView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchTB,
            this.searchBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // createBtn
            // 
            this.createBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createBtn.Image = global::AutoschoolAIS.Properties.Resources.add_16;
            this.createBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(23, 22);
            this.createBtn.Text = "toolStripButton1";
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = global::AutoschoolAIS.Properties.Resources.minus_16;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteBtn.Text = "toolStripButton2";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editBtn.Image = global::AutoschoolAIS.Properties.Resources.edit_16;
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(23, 22);
            this.editBtn.Text = "toolStripButton3";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 25);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBtn.Image = global::AutoschoolAIS.Properties.Resources.search_16;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(23, 22);
            this.searchBtn.Text = "toolStripButton4";
            // 
            // groupsTV
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.AllowUserToResizeRows = false;
            this.tableView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.CommentColumn,
            this.StartAtColumn,
            this.EndAtColumn});
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("groupsTV.Ids")));
            this.tableView.IsMultiselect = false;
            this.tableView.Location = new System.Drawing.Point(0, 25);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "groupsTV";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersVisible = false;
            this.tableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView.Size = new System.Drawing.Size(800, 425);
            this.tableView.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.DataPropertyName = "Comment";
            this.CommentColumn.HeaderText = "Комментарий";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            // 
            // StartAtColumn
            // 
            this.StartAtColumn.DataPropertyName = "StartAt";
            this.StartAtColumn.HeaderText = "Начало";
            this.StartAtColumn.Name = "StartAtColumn";
            this.StartAtColumn.ReadOnly = true;
            // 
            // EndAtColumn
            // 
            this.EndAtColumn.DataPropertyName = "EndAt";
            this.EndAtColumn.HeaderText = "Окончание";
            this.EndAtColumn.Name = "EndAtColumn";
            this.EndAtColumn.ReadOnly = true;
            // 
            // GroupListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupListForm";
            this.Text = "Группы";
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
        private System.Windows.Forms.ToolStripTextBox searchTB;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndAtColumn;
        public Controls.TableView tableView;
    }
}