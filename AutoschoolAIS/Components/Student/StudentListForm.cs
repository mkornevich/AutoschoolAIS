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

namespace AutoschoolAIS.Components.Student
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
            ReloadTable();
            Env.Change.DatabaseChanged += ReloadTable;
        }

        private void ReloadTable()
        {
            tableView.DataSourceDynamic = Env.Db.Query("Student")
                .Select("Student.Id As Id", "User.Name AS UserName", "Group.Name AS GroupName")
                .LeftJoin("User", "User.Id", "UserId")
                .LeftJoin("Group", "Group.Id", "GroupId")
                .Get();
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
            var row = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row;
            new StudentEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row["Id"];
            Env.Db.Query("Student").Where("Id", id).Delete();
            Env.Change.OnDatabaseChanged();
        }
    }
}
