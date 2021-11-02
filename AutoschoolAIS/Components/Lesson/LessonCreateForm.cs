﻿using AutoschoolAIS.Components.Student;
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
    public partial class LessonCreateForm : Form
    {
        private IDictionary<string, object> _row;

        public LessonCreateForm()
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
            return true;
        }

        private void LoadDataRow()
        {
            /*_row = Env.Db.Query("Lesson")
                .Select("StudentId", "TeacherId", "IsPassed", "Hours", "StartAt")
                .Where("Id", _identity)
                .First();*/
        }

        private void StoreDataRow()
        {
            /*Env.Db.Query("Lesson")
                .Where("Id", _identity)
                .Update(_row);*/
        }

        public void ShowForCreate()
        {
            //_identity = identity;
            //LoadDataRow();
            //DataRowToForm();
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