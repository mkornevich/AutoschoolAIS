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
    public partial class CarEditForm : Form
    {
        private dynamic _row;

        private object _identity;

        public CarEditForm()
        {
            InitializeComponent();
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row.Name;
            numberTB.Text = _row.Number;
            commentTB.Text = _row.Comment;
        }

        private void FormToDataRow()
        {
            _row.Name = nameTB.Text;
            _row.Number = numberTB.Text;
            _row.Comment = commentTB.Text;
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void LoadDataRow()
        {
            _row = Env.Db.Query("Car")
                .Select("Name", "Number", "Comment")
                .Where("Id", _identity)
                .First<dynamic>();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("Car")
                .Where("Id", _identity)
                .Update((IDictionary<string, object>)_row);
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
            if (!Env.Auth.HasRole("admin"))
            {
                MessageBox.Show("Данная функция доступна для пользователя с ролью admin.");
                return;
            }
            if (ValidateForm())
            {
                FormToDataRow();
                StoreDataRow();
                Close();
                Env.Change.OnDatabaseChanged();
            }
        }
    }
}
