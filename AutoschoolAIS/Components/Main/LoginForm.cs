using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS.Components.Main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!Env.Auth.TryAuthenticate(emailTB.Text, passwordTB.Text))
            {
                MessageBox.Show("Вы ввели неправильно логин или пароль. Попробуйте еще раз.");
                return;
            }
            Close();
        }

        private void FormClosingAct(object sender, FormClosingEventArgs e)
        {
            if (!Env.Auth.IsAuth)
            {
                Application.Exit();
            }
        }
    }
}
