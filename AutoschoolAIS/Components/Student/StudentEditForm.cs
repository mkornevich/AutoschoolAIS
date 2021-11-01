using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.User;
using AutoschoolAIS.Utils;
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
    public partial class StudentEditForm : Form
    {
        private IDictionary<string, object> _row;

        private object _identity;

        public StudentEditForm()
        {
            InitializeComponent();

            userIC.GetTextById = id => Env.Db.Query("User").Select("Name").Where("Id", id).First().Name;
            userIC.BuildTableViewWithForm = () => new UserListForm().tableView;

            groupIC.GetTextById = id => Env.Db.Query("Group").Select("Name").Where("Id", id).First().Name;
            groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        private void DataRowToForm()
        {
            userIC.Id = (int?)_row["UserId"];
            groupIC.Id = (int?)_row["GroupId"];
        }

        private void FormToDataRow()
        {
            _row["UserId"] = userIC.Id;
            _row["GroupId"] = groupIC.Id;
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void LoadDataRow()
        {
            _row = Env.Db.Query("Student")
                .Select("UserId", "GroupId")
                .Where("Id", _identity)
                .First();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Student")
                .Where("Id", _identity)
                .Update(_row);
        }

        public void ShowForEdit(object identity)
        {
            _identity = identity;
            LoadDataRow();
            DataRowToForm();
            MdiParent = Env.MainForm;
            Show();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                FormToDataRow();
                StoreDataRow();
                Close();
                Env.Change.OnDatabaseChanged();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
