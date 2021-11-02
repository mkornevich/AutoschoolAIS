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

            //groupIC.GetTextById = (id) => Env.Db.Query("Group").Where("Id", id).First().Name;
            //groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        public void ReloadTable()
        {
            var q = Env.Db.Query("Lesson")
                .Select(
                    "Lesson.Id AS Id", 
                    "StudentUser.Name AS StudentName", 
                    "TeacherUser.Name AS TeacherName",
                    "Lesson.Hours AS Hours",
                    "Lesson.StartAt AS StartAt"
                )
                .SelectRaw("IIF(Lesson.IsPassed = 1, N'Да', N'Нет') AS IsPassed")
                .LeftJoin("Student", "Student.Id", "Lesson.StudentId")
                .LeftJoin("Teacher", "Teacher.Id", "Lesson.TeacherId")
                .LeftJoin("User AS StudentUser", "StudentUser.Id", "Student.UserId")
                .LeftJoin("User AS TeacherUser", "TeacherUser.Id", "Teacher.UserId");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                    .Where("StudentUser.Name", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("TeacherUser.Name", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            //if (groupIC.Ids.Count > 0)
            //{
            //    q.WhereIn("GroupId", groupIC.Ids);
            //}

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
