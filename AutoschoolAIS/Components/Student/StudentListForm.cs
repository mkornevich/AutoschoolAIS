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
            var adapter = Env.Db.CreateDataAdapter(
                "SELECT Student.Id AS Id, [User].Name AS UserName, [Group].Name AS GroupName FROM Student " +
                "LEFT JOIN [User] ON Student.UserId = [User].Id " +
                "LEFT JOIN [Group] ON Student.GroupId = [Group].Id");
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            tableView.DataSource = dataSet.Tables[0];
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var command = Env.Db.CreateCommand(
                @"INSERT INTO [Student](UserId, GroupId) VALUES (NULL, NULL);
                SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];");
            object id = command.ExecuteScalar();
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
            var row = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row;
            var command = Env.Db.CreateCommand("DELETE FROM [Student] WHERE Id = @Id");
            command.Parameters.AddWithValue("Id", row["Id"]);
            command.ExecuteNonQuery();
            Env.Change.OnDatabaseChanged();
        }
    }
}
