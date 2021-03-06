using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.User;
using AutoschoolAIS.Utils;
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
    public partial class StudentEditForm : Form
    {
        private IDictionary<string, object> _row;

        private object _identity;

        public StudentEditForm()
        {
            InitializeComponent();

            userIC.GetTextById = id => Env.Db.Query("User").Select("Name").Where("Id", id).First().Name;
            userIC.BuildTableViewWithForm = () => new UserListForm().tableView;

            groupIC.GetTextById = id => Env.Db.Query("Group").Select("Name").Where("Id", id).First().Name;
            groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        private void DataRowToForm()
        {
            userIC.Id = (int?)_row["UserId"];
            groupIC.Id = (int?)_row["GroupId"];
        }

        private void FormToDataRow()
        {
            _row["UserId"] = userIC.Id;
            _row["GroupId"] = groupIC.Id;
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (userIC.Id == null)
            {
                m.AddError("Необходимо выбрать пользователя.");
            }

            if (groupIC.Id == null)
            {
                m.AddError("Необходимо выбрать группу.");
            }

            if (m.HasErrors)
            {
                m.Show();
                return false;
            }

            if (Env.Db.Query("Student").Where("Id", "<>", _identity).Where("GroupId", groupIC.Id).Where("UserId", userIC.Id).Exists())
            {
                m.AddError("Студент под таким пользователем и в такой группе уже есть.");
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
            _row = Env.Db.Query("Student")
                .Select("UserId", "GroupId")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Student")
                .Where("Id", _identity)
                .Update(_row);
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
