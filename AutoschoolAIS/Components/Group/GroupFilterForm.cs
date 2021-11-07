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

namespace AutoschoolAIS.Components.Group
{
    public partial class GroupFilterForm : Form
    {
        private TableView _tableView;

        public GroupFilterForm(TableView tableView)
        {
            InitializeComponent();
            _tableView = tableView;
            MdiParent = Env.MainForm;
            FormClosing += (s, e) =>
            {
                e.Cancel = true;
                Hide();
            };
        }

        public void ReloadTable()
        {
            var q = Env.Db.Query("Group");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                    .Where("Name", "LIKE", "%" + searchTB.Text + "%")
                    .OrWhere("Comment", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            if (fromDTP.Checked)
            {
                q.Where("StartAt", ">=", fromDTP.Value.ToString(Env.SqlDateTimeFormat));
            }

            if (toDTP.Checked)
            {
                q.Where("EndAt", "<=", toDTP.Value.ToString(Env.SqlDateTimeFormat));
            }

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
