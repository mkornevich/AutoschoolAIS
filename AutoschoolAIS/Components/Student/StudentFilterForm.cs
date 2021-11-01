using AutoschoolAIS.Components.Group;
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

namespace AutoschoolAIS.Components.Student
{
    public partial class StudentFilterForm : Form
    {
        private TableView _tableView;

        public StudentFilterForm(TableView tableView)
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
        }

        public void ReloadTable()
        {
            var q = Env.Db.Query("Student")
                .Select("Student.Id As Id", "User.Name AS UserName", "Group.Name AS GroupName")
                .LeftJoin("User", "User.Id", "UserId")
                .LeftJoin("Group", "Group.Id", "GroupId");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                .Where("User.Name", "LIKE", "%" + searchTB.Text + "%")
                .OrWhere("Group.Name", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            if (groupIC.Ids.Count > 0)
            {
                q.WhereIn("GroupId", groupIC.Ids);
            }

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
