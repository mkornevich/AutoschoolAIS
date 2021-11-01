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
    public partial class CarListForm : Form
    {
        public CarFilterForm FilterForm { get; private set; }

        public CarListForm()
        {
            InitializeComponent();
            FilterForm = new CarFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int id = Env.Db.Query("Car").InsertGetId<int>(new
            {
                Name = "Новая машина",
            });
            new CarEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row;
            new CarEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row["Id"];
            Env.Db.Query("Car").Where("Id", id).Delete();
            Env.Change.OnDatabaseChanged();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            FilterForm.Show();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            if (searchTB.Text != "")
            {
                FilterForm.searchTB.Text = searchTB.Text;
            }
            FilterForm.ReloadTable();
        }
    }
}
