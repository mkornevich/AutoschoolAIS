using AutoschoolAIS.Components.GroupSubjectHours;
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

namespace AutoschoolAIS.Components.Group
{
    public partial class GroupEditForm : Form
    {
        private dynamic _row;

        private object _identity;

        public GroupEditForm()
        {
            InitializeComponent();

            Env.Change.DatabaseChanged += ReloadGroupSubjectHoursTable;
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row.Name;
            commentTB.Text = _row.Comment;
            startAtDTP.Value = DateTime.Parse(_row.StartAt.ToString());
            endAtDTP.Value = DateTime.Parse(_row.EndAt.ToString());
        }

        private void FormToDataRow()
        {
            _row.Name = nameTB.Text;
            _row.Comment = commentTB.Text;
            _row.StartAt = startAtDTP.Value.ToString(Env.SqlDateTimeFormat);
            _row.EndAt = endAtDTP.Value.ToString(Env.SqlDateTimeFormat);
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (nameTB.Text == "")
            {
                m.AddError("Название группы не должно быть пустым.");
            }

            if (startAtDTP.Value >= endAtDTP.Value)
            {
                m.AddError("Дата начала должна быть меньше даты окончания.");
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
            _row = Env.Db.Query("Group")
                .Select("Name", "Comment", "StartAt", "EndAt")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Group")
                .Where("Id", _identity)
                .Update((IDictionary<string, object>)_row);
        }

        public void ShowForEdit(object identity)
        {
            _identity = identity;
            LoadDataRow();
            DataRowToForm();
            MdiParent = Env.MainForm;
            ReloadGroupSubjectHoursTable();
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

        private void ReloadGroupSubjectHoursTable()
        {
            groupSubjectHoursTV.DataSourceDynamic = Env.Db.Query("GroupSubjectHours AS GSH")
                .Select("GSH.Id AS Id", "Subject.Name AS SubjectName", "Hours")
                .LeftJoin("Subject", "Subject.Id", "SubjectId")
                .Where("GroupId", _identity)
                .Get();
        }

        private void createGroupSubjectHoursBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            int id = Env.Db.Query("GroupSubjectHours").InsertGetId<int>(new
            {
                GroupId = _identity,
                Hours = 0,
            });
            new GroupSubjectHoursEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editGroupSubjectHoursBtn_Click(object sender, EventArgs e)
        {
            if (groupSubjectHoursTV.SelectedId != null)
            {
                new GroupSubjectHoursEditForm().ShowForEdit(groupSubjectHoursTV.SelectedId);
            }
        }

        private void deleteGroupSubjectHoursBtn_Click(object sender, EventArgs e)
        {
            if (groupSubjectHoursTV.SelectedId != null)
            {
                Env.Db.Query("GroupSubjectHours").Where("Id", groupSubjectHoursTV.SelectedId).Delete();
                Env.Change.OnDatabaseChanged();
            }
        }
    }
}
