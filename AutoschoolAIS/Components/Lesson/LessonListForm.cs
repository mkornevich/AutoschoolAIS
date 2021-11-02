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
    public partial class LessonListForm : Form
    {
        public LessonFilterForm FilterForm { get; private set; }

        public LessonListForm()
        {
            InitializeComponent();
            FilterForm = new LessonFilterForm(tableView);
            FilterForm.ReloadTable();
            Env.Change.DatabaseChanged += FilterForm.ReloadTable;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            int id = Env.Db.Query("Lesson").InsertGetId<int>(new Dictionary<string, object>
            {
                {"IsPassed", false },
                {"Hours", 0 },
                {"StartAt", DateTime.Now.ToString(Env.SqlDateTimeFormat) }
            });
            new LessonEditForm().ShowForEdit(id);
            Env.Change.OnDatabaseChanged();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var row = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row;
            new LessonEditForm().ShowForEdit((int)row["Id"]);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = ((DataRowView)tableView.SelectedRows[0].DataBoundItem).Row["Id"];
            Env.Db.Query("Lesson").Where("Id", id).Delete();
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
