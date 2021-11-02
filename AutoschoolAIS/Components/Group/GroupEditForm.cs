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
            var row = ((DataRowView)groupSubjectHoursTV.SelectedRows[0].DataBoundItem).Row;
            new GroupSubjectHoursEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteGroupSubjectHoursBtn_Click(object sender, EventArgs e)
        {
            var id = ((DataRowView)groupSubjectHoursTV.SelectedRows[0].DataBoundItem).Row["Id"];
            Env.Db.Query("GroupSubjectHours").Where("Id", id).Delete();
            Env.Change.OnDatabaseChanged();
        }
    }
}
