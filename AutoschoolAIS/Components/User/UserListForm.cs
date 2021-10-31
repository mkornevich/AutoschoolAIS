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
        public UserListForm()
        {
            InitializeComponent();
            ReloadTable();
            Env.Change.DatabaseChanged += ReloadTable;
        }

        private void ReloadTable()
        {
            tableView.DataSourceDynamic = Env.Db.Query("User").Get();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var id = Env.Db.Query("User").InsertGetId<int>(new { Name = "Новый пользователь", Role = "viewer" });
            new UserEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row;
            new UserEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            object id = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row["Id"];
            Env.Db.Query("User").Where("Id", id).Delete();
            Env.Change.OnDatabaseChanged();
        }
    }
}
