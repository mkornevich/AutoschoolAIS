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

namespace AutoschoolAIS.Components.User
{
    public partial class UserEditForm : Form
    {
        private List<string> _roles = new List<string>()
        {
            "admin",
            "viewer",
            "guest",
        };

        private DataRow _row;

        public UserEditForm()
        {
            InitializeComponent();
            roleCB.Items.Clear();
            roleCB.Items.AddRange(_roles.Cast<object>().ToArray());
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row["Name"].ToString();
            emailTB.Text = _row["Email"].ToString();
            passwordTB.Text = _row["Password"].ToString();
            roleCB.SelectedIndex = _roles.IndexOf(_row["Role"].ToString());
        }

        private void FormToDataRow()
        {
            _row["Name"] = nameTB.Text;
            _row["Email"] = emailTB.Text;
            _row["Password"] = passwordTB.Text;
            _row["Role"] = _roles[roleCB.SelectedIndex];
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void LoadDataRow(object identity)
        {
            var adapter = Env.Database.CreateDataAdapter(
                "SELECT * FROM [User] WHERE Id = @Id");
            adapter.SelectCommand.Parameters.AddWithValue("Id", identity);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            _row = dataSet.Tables[0].Rows[0];
        }

        private void StoreDataRow()
        {
            var command = Env.Database.CreateCommand("" +
                "UPDATE [User] SET Name = @Name, Email = @Email, Password = @Password, Role = @Role WHERE Id = @Id");
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

        private void passwordVisibleCB_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = passwordVisibleCB.Checked ? '\0' : '*';
        }
    }
}
