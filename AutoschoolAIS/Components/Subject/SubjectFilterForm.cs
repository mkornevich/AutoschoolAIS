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

namespace AutoschoolAIS.Components.Subject
{
    public partial class SubjectFilterForm : Form
    {
        private TableView _tableView;

        public SubjectFilterForm(TableView tableView)
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
            var q = Env.Db.Query("Subject");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                .Where("Name", "LIKE", "%" + searchTB.Text + "%")
                .OrWhere("Comment", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
