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

namespace AutoschoolAIS.Components.User
{
    public partial class UserEditForm : Form
    {
        private dynamic _row;

        private object _identity;

        private List<string> _roles = new List<string>()
        {
            "admin",
            "viewer",
            "guest",
        };

        public UserEditForm()
        {
            InitializeComponent();
            roleCB.Items.Clear();
            roleCB.Items.AddRange(_roles.Cast<object>().ToArray());
        }

        private void DataRowToForm()
        {
            nameTB.Text = _row.Name;
            emailTB.Text = _row.Email;
            passwordTB.Text = _row.Password;
            roleCB.SelectedIndex = _roles.IndexOf(_row.Role);
        }

        private void FormToDataRow()
        {
            _row.Name = nameTB.Text;
            _row.Email = emailTB.Text;
            _row.Password = passwordTB.Text;
            _row.Role = _roles[roleCB.SelectedIndex];
        }

        private bool ValidateForm()
        {
            var m = Env.Messages.Clear();

            if (emailTB.Text == "")
            {
                m.AddError("Пожалуйста укажите почту.");
            }

            if (Env.Db.Query("User").Where("Email", emailTB.Text).Where("Id", "<>" , _identity).FirstOrDefault() != null) 
            {
                m.AddError("Пользователь с такой почтой уже существует.");
            }

            if (nameTB.Text == "")
            {
                m.AddError("Имя не должно быть пустым.");
            }

            if (passwordTB.Text == "")
            {
                m.AddError("Пароль не должен быть пустым.");
            }

            if (m.HasErrors)
            {
                m.Show();
                return false;
            }

            return true;
        }

        private void LoadDataRow()
        {
            _row = Env.Db.Query("User")
                .Select("Name", "Email", "Password", "Role")
                .Where("Id", _identity)
                .First<dynamic>();
        }

        private void StoreDataRow()
        {
            Env.Db.Query("User")
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

        private void passwordVisibleCB_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = passwordVisibleCB.Checked ? '\0' : '*';
        }
    }
}
