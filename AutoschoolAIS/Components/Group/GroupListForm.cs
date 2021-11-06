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

namespace AutoschoolAIS.Components.Group
{
    public partial class GroupListForm : Form
    {
        public GroupFilterForm FilterForm { get; private set; }

        public GroupListForm()
        {
            InitializeComponent();
            FilterForm = new GroupFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            int id = Env.Db.Query("Group").InsertGetId<int>(new
            {
                Name = "Новая группа",
                StartAt = DateTime.Now.ToString(),
                EndAt = DateTime.Now.ToString(),
            });
            new GroupEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            if (tableView.SelectedId != null)
            {
                Env.Db.Query("Group").Where("Id", tableView.SelectedId).Delete();
                Env.Change.OnDatabaseChanged();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (tableView.SelectedId != null)
            {
                new GroupEditForm().ShowForEdit(tableView.SelectedId);
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
