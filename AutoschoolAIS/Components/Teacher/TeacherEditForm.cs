using AutoschoolAIS.Components.Car;
using AutoschoolAIS.Components.Subject;
using AutoschoolAIS.Components.User;
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

namespace AutoschoolAIS.Components.Teacher
{
    public partial class TeacherEditForm : Form
    {
        private IDictionary<string, object> _row;

        private object _identity;

        public TeacherEditForm()
        {
            InitializeComponent();

            userIC.GetTextById = id => Env.Db.Query("User").Select("Name").Where("Id", id).First().Name;
            userIC.BuildTableViewWithForm = () => new UserListForm().tableView;

            subjectIC.GetTextById = id => Env.Db.Query("Subject").Select("Name").Where("Id", id).First().Name;
            subjectIC.BuildTableViewWithForm = () => new SubjectListForm().tableView;

            pinnedCarIC.GetTextById = id => Env.Db.Query("Car").Select("Name").Where("Id", id).First().Name;
            pinnedCarIC.BuildTableViewWithForm = () => new CarListForm().tableView;
        }

        private void DataRowToForm()
        {
            userIC.Id = (int?)_row["UserId"];
            subjectIC.Id = (int?)_row["SubjectId"];
            pinnedCarIC.Id = (int?)_row["PinnedCarId"];
            isWorkedCB.Checked = (bool)_row["IsWorked"];
            createdAtDTP.Value = DateTime.Parse(_row["CreatedAt"].ToString());
        }

        private void FormToDataRow()
        {
            _row["UserId"] = userIC.Id;
            _row["SubjectId"] = subjectIC.Id;
            _row["PinnedCarId"] = pinnedCarIC.Id;
            _row["IsWorked"] = isWorkedCB.Checked;
            _row["CreatedAt"] = createdAtDTP.Value.ToString(Env.SqlDateTimeFormat);
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (userIC.Id == null)
            {
                m.AddError("Необходимо указать пользователя.");
            }

            if (subjectIC.Id == null)
            {
                m.AddError("Необходимо указать предмет.");
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
            _row = Env.Db.Query("Teacher")
                .Select("UserId", "SubjectId", "PinnedCarId", "IsWorked", "CreatedAt")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Teacher")
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
