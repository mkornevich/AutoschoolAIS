﻿using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Components.Student
{
    public partial class StudentListForm : Form
    {
        public StudentFilterForm FilterForm { get; private set; }

        public StudentListForm()
        {
            InitializeComponent();
            FilterForm = new StudentFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int id = Env.Db.Query("Student").InsertGetId<int>(new Dictionary<string, object>
            {
                {"UserId", null },
                {"GroupId", null },
            });
            new StudentEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (tableView.SelectedId != null)
            {
                new StudentEditForm().ShowForEdit(tableView.SelectedId);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tableView.SelectedId != null)
            {
                Env.Db.Query("Student").Where("Id", tableView.SelectedId).Delete();
                Env.Change.OnDatabaseChanged();
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            FilterForm.Show();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            if (searchTB.Text != "")
            {
                FilterForm.searchTB.Text = searchTB.Text;
            }
            FilterForm.ReloadTable();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                FilterForm.searchTB.Text = "";
            }
        }
    }
}
