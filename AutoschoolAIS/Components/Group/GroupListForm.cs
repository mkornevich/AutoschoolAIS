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
            var adapter = Env.Database.CreateDataAdapter("SELECT * FROM [Group]");
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            groupsTV.DataSource = dataSet.Tables[0];
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            var command = Env.Database.CreateCommand(
                @"INSERT INTO [Group]([Name], Comment, StartAt, EndAt) VALUES 
                (N'Новая группа', '', GETDATE(), GETDATE());
                SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];");
            object id = command.ExecuteScalar();
            new GroupEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)groupsTV.SelectedRows[0].DataBoundItem).Row;
            var command = Env.Database.CreateCommand("DELETE FROM [Group] WHERE Id = @Id");
            command.Parameters.AddWithValue("Id", row["Id"]);
            command.ExecuteNonQuery();
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)groupsTV.SelectedRows[0].DataBoundItem).Row;
            new GroupEditForm().ShowForEdit((int)row["Id"]);
        }
    }
}
