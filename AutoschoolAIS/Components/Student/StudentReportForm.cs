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

namespace AutoschoolAIS.Components.Student
{
    public partial class StudentReportForm : Form
    {
        public StudentReportForm()
        {
            InitializeComponent();

            studentIC.GetTextById = id => Env.Db.Query("Student").LeftJoin("User", "User.Id", "UserId").Where("Student.Id", id).First().Name;
            studentIC.BuildTableViewWithForm = () => new StudentListForm().tableView;
        }

        private void BuildReportAct(object sender, EventArgs e)
        {
            if (studentIC.Id == null)
            {
                MessageBox.Show("Пожалуйста укажите студента.");
                return;
            }

            var student = Env.Db.Query("Student")
                .Select(
                    "User.Name AS User",
                    "Email",
                    "Group.Name AS Group"
                )
                .LeftJoin("User", "User.Id", "UserId")
                .LeftJoin("Group", "Group.Id", "GroupId")
                .Where("Student.Id", studentIC.Id)
                .First();

            var hoursStatistic = Env.Db.Query("HoursStatistic")
                .Where("StudentId", studentIC.Id)
                .OrderBy("GroupId", "StudentName", "SubjectName")
                .Get();

            var workbook = Env.Report.LoadTemplate("StudentReport");

            ISheet sheet = workbook.GetSheetAt(0);

            sheet.GetRow(2).GetCell(3).SetCellValue(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            sheet.GetRow(3).GetCell(3).SetCellValue(student.User);
            sheet.GetRow(4).GetCell(3).SetCellValue(student.Email);
            sheet.GetRow(5).GetCell(3).SetCellValue(student.Group);

            int currRow = 10;
            var baseRow = sheet.GetRow(currRow);

            foreach (var statRow in hoursStatistic)
            {
                var row = sheet.GetRow(currRow);

                row.GetCell(0).SetCellValue(statRow.SubjectName);
                row.GetCell(3).SetCellValue(statRow.PlanHours);
                row.GetCell(5).SetCellValue(statRow.PassedHours);
                row.GetCell(7).SetCellValue(statRow.LeftHours);
                
                currRow++;
                baseRow.CopyRowTo(currRow);
            }

            sheet.RemoveRow(sheet.GetRow(currRow));

            Env.Report.Store("StudentReport", workbook);
            Env.Report.OpenRecentlyStored();
        }
    }
}
