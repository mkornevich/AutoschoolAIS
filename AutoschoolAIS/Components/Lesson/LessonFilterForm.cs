using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.Student;
using AutoschoolAIS.Controls;
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
    public partial class LessonFilterForm : Form
    {
        private TableView _tableView;

        public LessonFilterForm(TableView tableView)
        {
            InitializeComponent();
            _tableView = tableView;
            MdiParent = Env.MainForm;
            FormClosing += (s, e) =>
            {
                e.Cancel = true;
                Hide();
            };

            groupIC.GetTextById = (id) => Env.Db.Query("Group").Where("Id", id).First().Name;
            groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;

            studentIC.GetTextById = (id) => Env.Db.Query("Student").LeftJoin("User", "User.Id", "Student.UserId").Where("Student.Id", id).First().Name;
            studentIC.BuildTableViewWithForm = () => new StudentListForm().tableView;

            subjectIC.GetTextById = (id) => Env.Db.Query("Subject").Where("Id", id).First().Name;
            subjectIC.BuildTableViewWithForm = () => new GroupListForm().tableView;

            teacherIC.GetTextById = (id) => Env.Db.Query("Teacher").LeftJoin("User", "User.Id", "Teacher.UserId").Where("Teacher.Id", id).First().Name;
            teacherIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        public void ReloadTable()
        {
            var q = Env.Db.Query("Lesson")
                .Select(
                    "Lesson.Id AS Id", 
                    "Group.Name AS GroupName",
                    "StudentUser.Name AS StudentName", 
                    "Subject.Name AS SubjectName",
                    "TeacherUser.Name AS TeacherName",
                    "Lesson.Hours AS Hours",
                    "Lesson.StartAt AS StartAt"
                )
                .SelectRaw("IIF(Lesson.IsPassed = 1, N'Да', N'Нет') AS IsPassed")
                .LeftJoin("Student", "Student.Id", "Lesson.StudentId")
                .LeftJoin("Group", "Group.Id", "Student.GroupId")
                .LeftJoin("Teacher", "Teacher.Id", "Lesson.TeacherId")
                .LeftJoin("Subject", "Subject.Id", "Teacher.SubjectId")
                .LeftJoin("User AS StudentUser", "StudentUser.Id", "Student.UserId")
                .LeftJoin("User AS TeacherUser", "TeacherUser.Id", "Teacher.UserId");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                    .Where("Group.Name", "LIKE", "%" + searchTB.Text + "%")
                    .Where("StudentUser.Name", "LIKE", "%" + searchTB.Text + "%")
                    .Where("Subject.Name", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("TeacherUser.Name", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            if (groupIC.Ids.Count > 0)
            {
                q.WhereIn("Group.Id", groupIC.Ids);
            }

            if (studentIC.Ids.Count > 0)
            {
                q.WhereIn("Student.Id", studentIC.Ids);
            }

            if (subjectIC.Ids.Count > 0)
            {
                q.WhereIn("Subject.Id", subjectIC.Ids);
            }

            if (teacherIC.Ids.Count > 0)
            {
                q.WhereIn("Teacher.Id", teacherIC.Ids);
            }

            if (isPassedCB.Text != "")
            {
                q.Where("Lesson.IsPassed", isPassedCB.Text == "Пройден");
            }

            if (hoursCB.Checked)
            {
                q.Where("Lesson.Hours", ">", hoursFromNUD.Value);
                q.Where("Lesson.Hours", "<", hoursToNUD.Value);
            }

            if (startAtFromDTP.Checked)
            {
                q.Where("Lesson.StartAt", ">", startAtFromDTP.Value.ToString(Env.SqlDateTimeFormat));
            }

            if (startAtToDTP.Checked)
            {
                q.Where("Lesson.StartAt", "<", startAtToDTP.Value.ToString(Env.SqlDateTimeFormat));
            }

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
