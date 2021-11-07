using AutoschoolAIS.Components.Subject;
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

namespace AutoschoolAIS.Components.GroupSubjectHours
{
    public partial class GroupSubjectHoursEditForm : Form
    {
        private IDictionary<string, object> _row;

        private object _identity;

        public GroupSubjectHoursEditForm()
        {
            InitializeComponent();

            subjectIC.GetTextById = id => Env.Db.Query("Subject").Select("Name").Where("Id", id).First().Name;
            subjectIC.BuildTableViewWithForm = () => new SubjectListForm().tableView;
        }

        private void DataRowToForm()
        {
            groupL.Text = (string)_row["GroupName"];
            subjectIC.Id = (int?)_row["SubjectId"];
            hoursNUD.Value = (int)_row["Hours"];
        }

        private void FormToDataRow()
        {
            _row["SubjectId"] = subjectIC.Id;
            _row["Hours"] = hoursNUD.Value;
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (subjectIC.Id == null)
            {
                m.AddError("Предмет должен быть указан.");
            }

            if (hoursNUD.Value <= 0)
            {
                m.AddError("Кол-во часов должно быть больше 0.");
            }

            if (m.HasErrors)
            {
                m.Show();
                return false;
            }

            if (Env.Db.Query("GroupSubjectHours")
                .Where("Id", "<>", _identity)
                .Where("GroupId", _row["GroupId"])
                .Where("SubjectId", subjectIC.Id)
                .Exists())
            {
                m.AddError("Для данной группы такой предмет уже задан.");
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
            _row = Env.Db.Query("GroupSubjectHours")
                .Select("Group.Name AS GroupName", "GroupId", "SubjectId", "Hours")
                .LeftJoin("Group", "Group.Id", "GroupId")
                .Where("GroupSubjectHours.Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            _row.Remove("GroupName");
            _row.Remove("GroupId");
            Env.Db.Query("GroupSubjectHours")
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
