using NPOI.SS.UserModel;
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

namespace AutoschoolAIS.Components.Teacher
{
    public partial class TeacherReportForm : Form
    {
        public TeacherReportForm()
        {
            InitializeComponent();

            teacherIC.GetTextById = id => Env.Db.Query("Teacher").LeftJoin("User", "User.Id", "UserId").Where("Teacher.Id", id).First().Name;
            teacherIC.BuildTableViewWithForm = () => new TeacherListForm().tableView;
        }

        private void BuildReportAct(object sender, EventArgs e)
        {
            if (teacherIC.Id == null)
            {
                MessageBox.Show("Пожалуйста укажите учителя.");
                return;
            }

            var teacher = Env.Db.Query("Teacher")
                .Select(
                    "User.Name AS User",
                    "Email",
                    "Car.Name AS Car",
                    "Subject.Name AS Subject"

                )
                .LeftJoin("User", "User.Id", "UserId")
                .LeftJoin("Car", "Car.Id", "PinnedCarId")
                .LeftJoin("Subject", "Subject.Id", "SubjectId")
                .Where("Teacher.Id", teacherIC.Id)
                .First();

            var workbook = Env.Report.LoadTemplate("TeacherReport");

            ISheet sheet = workbook.GetSheetAt(0);

            sheet.GetRow(2).GetCell(3).SetCellValue(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            sheet.GetRow(3).GetCell(3).SetCellValue(teacher.User);
            sheet.GetRow(4).GetCell(3).SetCellValue(teacher.Email);
            sheet.GetRow(5).GetCell(3).SetCellValue(teacher.Car);
            sheet.GetRow(6).GetCell(3).SetCellValue(teacher.Subject);

            Env.Report.Store("TeacherReport", workbook);
            Env.Report.OpenRecentlyStored();
        }
    }
}
