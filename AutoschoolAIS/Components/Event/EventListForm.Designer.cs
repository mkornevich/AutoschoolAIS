
namespace AutoschoolAIS.Components.Event
{
    partial class EventListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchTB = new System.Windows.Forms.ToolStripTextBox();
            this.filterBtn = new System.Windows.Forms.ToolStripButton();
            this.reloadBtn = new System.Windows.Forms.ToolStripButton();
            this.tableView = new AutoschoolAIS.Controls.TableView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchTB,
            this.filterBtn,
            this.reloadBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::AutoschoolAIS.Properties.Resources.minus_16;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(100, 25);
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
            this.UserNameColumn,
            this.ObjectIdColumn,
            this.ObjectTypeColumn,
            this.EventTypeColumn,
            this.DescriptionColumn,
            this.CreatedAtColumn});
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Ids = ((System.Collections.Generic.List<int>)(resources.GetObject("tableView.Ids")));
            this.tableView.IsMultiselect = false;
            this.tableView.Location = new System.Drawing.Point(0, 25);
            this.tableView.MultiSelect = false;
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersVisible = false;
            this.tableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView.Size = new System.Drawing.Size(842, 425);
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
            // UserNameColumn
            // 
            this.UserNameColumn.DataPropertyName = "UserName";
            this.UserNameColumn.HeaderText = "Пользователь";
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.ReadOnly = true;
            // 
            // ObjectIdColumn
            // 
            this.ObjectIdColumn.DataPropertyName = "ObjectId";
            this.ObjectIdColumn.HeaderText = "ID объекта";
            this.ObjectIdColumn.Name = "ObjectIdColumn";
            this.ObjectIdColumn.ReadOnly = true;
            this.ObjectIdColumn.Width = 90;
            // 
            // ObjectTypeColumn
            // 
            this.ObjectTypeColumn.DataPropertyName = "ObjectType";
            this.ObjectTypeColumn.HeaderText = "Тип объекта";
            this.ObjectTypeColumn.Name = "ObjectTypeColumn";
            this.ObjectTypeColumn.ReadOnly = true;
            // 
            // EventTypeColumn
            // 
            this.EventTypeColumn.DataPropertyName = "EventType";
            this.EventTypeColumn.HeaderText = "Тип события";
            this.EventTypeColumn.Name = "EventTypeColumn";
            this.EventTypeColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "Description";
            this.DescriptionColumn.HeaderText = "Описание";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            this.DescriptionColumn.Width = 300;
            // 
            // CreatedAtColumn
            // 
            this.CreatedAtColumn.DataPropertyName = "CreatedAt";
            this.CreatedAtColumn.HeaderText = "Дата наступления";
            this.CreatedAtColumn.Name = "CreatedAtColumn";
            this.CreatedAtColumn.ReadOnly = true;
            this.CreatedAtColumn.Width = 150;
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventListForm";
            this.Text = "События";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchTB;
        private System.Windows.Forms.ToolStripButton filterBtn;
        private System.Windows.Forms.ToolStripButton reloadBtn;
        public Controls.TableView tableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAtColumn;
    }
}