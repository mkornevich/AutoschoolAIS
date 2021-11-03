using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.Student;
using AutoschoolAIS.Components.Teacher;
using SqlKata;
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

        private int? _groupId;

        public LessonCreateForm()
        {
            InitializeComponent();

            studentIC.GetTextById = id => Env.Db.Query("Student").Select("User.Name AS Name").LeftJoin("User", "User.Id", "UserId").Where("Student.Id", id).First().Name;
            studentIC.BuildTableViewWithForm = () => new StudentListForm().tableView;

            teacherIC.GetTextById = id => Env.Db.Query("Teacher").Select("User.Name AS Name").LeftJoin("User", "User.Id", "UserId").Where("Teacher.Id", id).First().Name;
            teacherIC.BuildTableViewWithForm = () => new TeacherListForm().tableView;

            groupIC.GetTextById = id => Env.Db.Query("Group").Where("Id", id).First().Name;
            groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        private void FillFormToDefault()
        {
            studentIC.Id = null;
            groupIC.Id = null;
            teacherIC.Id = null;
            isPassedCB.Checked = false;
            hoursNUD.Value = 0;
            startAtDTP.Value = DateTime.Now;
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void Store()
        {
            if (modeTC.SelectedTab == studentTP)
            {
                Env.Db.Query("Lesson")
                    .Insert(new
                    {
                        StudentId = studentIC.Id,
                        TeacherId = teacherIC.Id,
                        isPassed = isPassedCB.Checked,
                        Hours = hoursNUD.Value,
                        StartAt = startAtDTP.Value.ToString(Env.SqlDateTimeFormat),
                    });
            }
            else
            {
                Env.Db.Query("Lesson").Insert(new[] {
                    "StudentId",
                    "TeacherId",
                    "IsPassed",
                    "Hours",
                    "StartAt",
                }, new Query("Student")
                    .Select("Id AS StudentId")
                    .SelectRaw("? AS TeacherId", teacherIC.Id)
                    .SelectRaw("? AS IsPassed", isPassedCB.Checked)
                    .SelectRaw("? AS Hours", hoursNUD.Value)
                    .SelectRaw("? AS StartAt", startAtDTP.Value.ToString(Env.SqlDateTimeFormat))
                    .Where("GroupId", groupIC.Id)
                );
            }
        }

        public void ShowForCreate()
        {
            FillFormToDefault();
            MdiParent = Env.MainForm;
            Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Store();
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
