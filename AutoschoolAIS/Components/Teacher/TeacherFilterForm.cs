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

namespace AutoschoolAIS.Components.Teacher
{
    public partial class TeacherFilterForm : Form
    {
        private TableView _tableView;

        public TeacherFilterForm(TableView tableView)
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
            var q = Env.Db.Query("Teacher")
                .Select(
                    "Teacher.Id As Id",
                    "User.Name AS UserName",
                    "Subject.Name AS SubjectName",
                    "Car.Name AS PinnedCarName",
                    "Teacher.CreatedAt AS CreatedAt"
                )
                .SelectRaw("IIF(Teacher.IsWorked = 1, N'Да', N'Нет') AS IsWorked")
                .LeftJoin("User", "User.Id", "UserId")
                .LeftJoin("Subject", "Subject.Id", "SubjectId")
                .LeftJoin("Car", "Car.Id", "PinnedCarId");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                    .Where("User.Name", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("Subject.Name", "LIKE", "%" + searchTB.Text + "%")
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
