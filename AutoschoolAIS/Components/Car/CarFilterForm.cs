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

namespace AutoschoolAIS.Components.Car
{
    public partial class CarFilterForm : Form
    {
        private TableView _tableView;

        public CarFilterForm(TableView tableView)
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
            var q = Env.Db.Query("Car").Select("Id", "Name", "Number", "Comment");

            if (searchTB.Text != "")
            {
                q.Where(qq => qq
                .Where("Name", "LIKE", "%" + searchTB.Text + "%")
                .OrWhere("Number", "LIKE", "%" + searchTB.Text + "%")
                .OrWhere("Comment", "LIKE", "%" + searchTB.Text + "%")
                );
            }

            _tableView.DataSourceDynamic = q.Get();
        }
    }
}
