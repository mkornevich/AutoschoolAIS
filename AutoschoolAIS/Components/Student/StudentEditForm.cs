using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.User;
using AutoschoolAIS.Utils;
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
    public partial class StudentEditForm : Form
    {
        private DataRow _row;

        public StudentEditForm()
        {
            InitializeComponent();

            userIC.SqlGetTextById = "SELECT [Name] FROM [User] WHERE Id = @Id";
            userIC.BuildTableViewFunction = () => new UserListForm().tableView;

            groupIC.SqlGetTextById = "SELECT [Name] FROM [Group] WHERE Id = @Id";
            groupIC.BuildTableViewFunction = () => new GroupListForm().tableView;
        }

        private void DataRowToForm()
        {
            userIC.Id = (int)_row["UserId"];
            groupIC.Id = (int)_row["GroupId"];
        }

        private void FormToDataRow()
        {
            _row["UserId"] = userIC.Id;
            _row["GroupId"] = groupIC.Id;
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void LoadDataRow(object identity)
        {
            var adapter = Env.Db.CreateDataAdapter(
                "SELECT * FROM [Student] WHERE Id = @Id");
            adapter.SelectCommand.Parameters.AddWithValue("Id", identity);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            _row = dataSet.Tables[0].Rows[0];
        }

        private void StoreDataRow()
        {
            var command = Env.Db.CreateCommand("" +
                "UPDATE [Student] SET UserId = @UserId, GroupId = @GroupId WHERE Id = @Id");
            DbUtils.DataRowToParams(_row, command.Parameters);
            command.ExecuteNonQuery();
        }

        public void ShowForEdit(object identity)
        {
            LoadDataRow(identity);
            DataRowToForm();
            MdiParent = Env.MainForm;
            Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FormToDataRow();
                StoreDataRow();
                Close();
                Env.Change.OnDatabaseChanged();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
