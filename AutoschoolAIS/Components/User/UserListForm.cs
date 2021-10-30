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
            var adapter = Env.Database.CreateDataAdapter(
                "SELECT Id, [Name], Email, [Role] FROM [User]");
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            usersTV.DataSource = dataSet.Tables[0];
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var command = Env.Database.CreateCommand(
                @"INSERT INTO [User]([Name], Email, Password, [Role]) VALUES (N'Новый пользователь', '', '', 'viewer');
                SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];");
            object id = command.ExecuteScalar();
            new UserEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)usersTV.SelectedRows[0].DataBoundItem).Row;
            new UserEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)usersTV.SelectedRows[0].DataBoundItem).Row;
            var command = Env.Database.CreateCommand( "DELETE FROM [User] WHERE Id = @Id");
            command.Parameters.AddWithValue("Id", row["Id"]);
            command.ExecuteNonQuery();
            Env.Change.OnDatabaseChanged();
        }
    }
}
