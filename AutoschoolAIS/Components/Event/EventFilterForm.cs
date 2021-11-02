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

namespace AutoschoolAIS.Components.Event
{
    public partial class EventFilterForm : Form
    {
        private TableView _tableView;

        public EventFilterForm(TableView tableView)
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
            var q = Env.Db.Query("Event")
                .Select(
                    "Event.Id AS Id",
                    "User.Name AS UserName", 
                    "ObjectId", 
                    "ObjectType",
                    "EventType",
                    "Description",
                    "CreatedAt"
                )
                .LeftJoin("User", "User.Id", "UserId");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                    .Where("User.Name", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("ObjectType", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("EventType", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("Description", "LIKE", "%" + searchTB.Text + "%")
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
