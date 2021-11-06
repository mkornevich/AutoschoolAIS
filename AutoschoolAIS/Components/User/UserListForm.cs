using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Components.User
{
    public partial class UserListForm : Form
    {
        public UserFilterForm FilterForm { get; private set; }

        public UserListForm()
        {
            InitializeComponent();
            FilterForm = new UserFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void ReloadTable()
        {
            tableView.DataSourceDynamic = Env.Db.Query("User")
                .Select("Id", "Name", "Email", "Role").Get();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var id = Env.Db.Query("User").InsertGetId<int>(new { Name = "Новый пользователь", Role = "viewer" });
            new UserEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (tableView.SelectedId != null)
            {
                new UserEditForm().ShowForEdit(tableView.SelectedId);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tableView.SelectedId != null)
            {
                Env.Db.Query("User").Where("Id", tableView.SelectedId).Delete();
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
    }
}
