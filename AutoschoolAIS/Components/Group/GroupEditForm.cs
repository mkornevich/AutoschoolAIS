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

namespace AutoschoolAIS.Components.Group
{
    public partial class GroupEditForm : Form
    {
        private DataRow _row;

        public GroupEditForm()
        {
            InitializeComponent();
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row["Name"].ToString();
            commentTB.Text = _row["Comment"].ToString();
            startAtDTP.Value = DateTime.Parse(_row["StartAt"].ToString());
            endAtDTP.Value = DateTime.Parse(_row["EndAt"].ToString());
        }

        private void FormToDataRow()
        {
            _row["Name"] = nameTB.Text;
            _row["Comment"] = commentTB.Text;
            _row["StartAt"] = startAtDTP.Value.ToString();
            _row["EndAt"] = endAtDTP.Value.ToString();
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void LoadDataRow(object identity)
        {
            var adapter = Env.Database.CreateDataAdapter(
                "SELECT * FROM [Group] WHERE Id = @Id");
            adapter.SelectCommand.Parameters.AddWithValue("Id", identity);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            _row = dataSet.Tables[0].Rows[0];
        }

        private void StoreDataRow()
        {
            var command = Env.Database.CreateCommand("" +
                "UPDATE [Group] SET Name = @Name, Comment = @Comment, StartAt = @StartAt, EndAt = @EndAt WHERE Id = @Id");
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
