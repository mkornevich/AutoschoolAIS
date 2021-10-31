using AutoschoolAIS.Components.Main;
using AutoschoolAIS.Services;
using AutoschoolAIS.Services.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS
{
    public static class Env
    {
        public const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Autoschool.mdf;Integrated Security=True";

        public static bool DesignMode => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

        public static MainForm MainForm { get; private set; }

        public static ChangeService Change { get; private set; }

        public static DatabaseService Db { get; private set; }

        public static AuthService Auth { get; private set; }

        public static void Init()
        {
            Change = new ChangeService();
            Db = new DatabaseService(ConnectionString);
            Auth = new AuthService();

            MainForm = new MainForm();
        }
    }
}
