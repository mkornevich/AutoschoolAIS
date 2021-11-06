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
    public partial class EventListForm : Form
    {
        public EventFilterForm FilterForm { get; private set; }

        public EventListForm()
        {
            InitializeComponent();
            FilterForm = new EventFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            if (tableView.SelectedId != null)
            {
                Env.Db.Query("Event").Where("Id", tableView.SelectedId).Delete();
                Env.Change.OnDatabaseChanged();
            }
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

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (searchTB.Text == "")
            {
                FilterForm.searchTB.Text = "";
            }
        }
    }
}
