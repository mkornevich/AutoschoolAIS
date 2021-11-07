using AutoschoolAIS.Components.Car;
using AutoschoolAIS.Components.Event;
using AutoschoolAIS.Components.Group;
using AutoschoolAIS.Components.Lesson;
using AutoschoolAIS.Components.Student;
using AutoschoolAIS.Components.Subject;
using AutoschoolAIS.Components.Teacher;
using AutoschoolAIS.Components.User;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Env.Auth.UserChanged += UserChangedAct;

            // here is auto auth
            // Env.Auth.TryAuthenticate("admin@gmail.ru", "a");
        }

        private void UserChangedAct()
        {
            if (!Env.Auth.IsAuth)
            {
                authMI.Text = "Авторизация...";
                new LoginForm().ShowDialog();
                return;
            }

            authMI.Text = Env.Auth.User["Name"].ToString();
        }

        private void ShowAboutFormAct(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void ShowFormAct(object sender, EventArgs e)
        {
            if (Env.Auth.HasRole("guest"))
            {
                MessageBox.Show("Данная функция недоступна для пользователя с ролью guest.");
                return;
            }
            var forms = new Dictionary<string, Func<Form>>()
            {
                { "CarListForm", () => new CarListForm() },
                { "EventListForm", () => new EventListForm() },
                { "GroupListForm", () => new GroupListForm() },
                { "LessonListForm", () => new LessonListForm() },
                { "StudentListForm", () => new StudentListForm() },
                { "SubjectListForm", () => new SubjectListForm() },
                { "TeacherListForm", () => new TeacherListForm() },
                { "UserListForm", () => new UserListForm() },

                { "StudentReportForm", () => new StudentReportForm() },
                { "TeacherReportForm", () => new TeacherReportForm() },
                { "LessonReportForm", () => new LessonReportForm() },
            };

            var item = (ToolStripMenuItem)sender;
            Form form = forms[(string)item.Tag]();
            form.MdiParent = Env.MainForm;
            form.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (!Env.Auth.IsAuth)
            {
                new LoginForm().ShowDialog();
            }
        }

        private void LogoutAct(object sender, EventArgs e)
        {
            Env.Auth.Logout();
        }
    }
}
