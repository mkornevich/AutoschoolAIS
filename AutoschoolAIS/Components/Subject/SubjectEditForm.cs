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

namespace AutoschoolAIS.Components.Subject
{
    public partial class SubjectEditForm : Form
    {
        private dynamic _row;

        private object _identity;

        public SubjectEditForm()
        {
            InitializeComponent();
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row.Name;
            commentTB.Text = _row.Comment;
            createdAtDTP.Value = DateTime.Parse(_row.CreatedAt.ToString());
        }

        private void FormToDataRow()
        {
            _row.Name = nameTB.Text;
            _row.Comment = commentTB.Text;
            _row.CreatedAt = createdAtDTP.Value.ToString();
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (nameTB.Text == "")
            {
                m.AddError("Название должно быть заполнено.");
            }

            if (m.HasErrors)
            {
                m.Show();
                return false;
            }

            return true;
        }

        private void LoadDataRow()
        {
            _row = Env.Db.Query("Subject")
                .Select("Name", "Comment", "CreatedAt")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Subject")
                .Where("Id", _identity)
                .Update((IDictionary<string, object>)_row);
        }

        public void ShowForEdit(object identity)
        {
            _identity = identity;
            LoadDataRow();
            DataRowToForm();
            MdiParent = Env.MainForm;
            Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            if (ValidateForm())
            {
                FormToDataRow();
                StoreDataRow();
                Close();
                Env.Change.OnDatabaseChanged();
            }
        }
    }
}
