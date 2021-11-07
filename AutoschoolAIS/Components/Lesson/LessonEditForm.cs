using AutoschoolAIS.Components.Student;
using AutoschoolAIS.Components.Teacher;
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

namespace AutoschoolAIS.Components.Lesson
{
    public partial class LessonEditForm : Form
    {
        private IDictionary<string, object> _row;

        private object _identity;

        public LessonEditForm()
        {
            InitializeComponent();

            studentIC.GetTextById = id => Env.Db.Query("Student").Select("User.Name AS Name").LeftJoin("User", "User.Id", "UserId").Where("Student.Id", id).First().Name;
            studentIC.BuildTableViewWithForm = () => new StudentListForm().tableView;

            teacherIC.GetTextById = id => Env.Db.Query("Teacher").Select("User.Name AS Name").LeftJoin("User", "User.Id", "UserId").Where("Teacher.Id", id).First().Name;
            teacherIC.BuildTableViewWithForm = () => new TeacherListForm().tableView;
        }

        private void DataRowToForm()
        {
            studentIC.Id = (int?)_row["StudentId"];
            teacherIC.Id = (int?)_row["TeacherId"];
            isPassedCB.Checked = (bool)_row["IsPassed"];
            hoursNUD.Value = (int)_row["Hours"];
            startAtDTP.Value = DateTime.Parse(_row["StartAt"].ToString());
        }

        private void FormToDataRow()
        {
            _row["StudentId"] = studentIC.Id;
            _row["TeacherId"] = teacherIC.Id;
            _row["IsPassed"] = isPassedCB.Checked;
            _row["Hours"] = hoursNUD.Value;
            _row["StartAt"] = startAtDTP.Value.ToString(Env.SqlDateTimeFormat);
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (studentIC.Id == null)
            {
                m.AddError("Необходимо указать студента.");
            }

            if (teacherIC.Id == null)
            {
                m.AddError("Необходимо указать учителя.");
            }

            if (hoursNUD.Value <= 0)
            {
                m.AddError("Количество часов должно быть больше 0.");
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
            _row = Env.Db.Query("Lesson")
                .Select("StudentId", "TeacherId", "IsPassed", "Hours", "StartAt")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Lesson")
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
