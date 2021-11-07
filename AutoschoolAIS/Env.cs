using AutoschoolAIS.Components.Main;
using AutoschoolAIS.Services;
using AutoschoolAIS.Services.Auth;
using AutoschoolAIS.Services.Messages;
using AutoschoolAIS.Services.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoschoolAIS
{
    public static class Env
    {
        public const string SqlDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Autoschool.mdf;Integrated Security=True";

        public static bool DesignMode => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public static string AppDirectory => Path.GetDirectoryName(Application.ExecutablePath);

        public static MainForm MainForm { get; private set; }

        public static ChangeService Change { get; private set; }

        public static DatabaseService Db { get; private set; }

        public static AuthService Auth { get; private set; }

        public static ReportService Report { get; private set; }

        public static MessagesService Messages { get; private set; }

        public static void Init()
        {
            Change = new ChangeService();
            Db = new DatabaseService(ConnectionString);
            Auth = new AuthService();
            Report = new ReportService();
            Messages = new MessagesService();

            MainForm = new MainForm();
        }
    }
}
