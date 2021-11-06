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
        public GroupListForm()
        {
            InitializeComponent();
            ReloadTable();
            Env.Change.DatabaseChanged += ReloadTable;
        }

        private void ReloadTable()
        {
            tableView.DataSourceDynamic = Env.Db.Query("Group").Get();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
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
    }
}
