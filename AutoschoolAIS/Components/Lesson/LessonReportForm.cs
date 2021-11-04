using AutoschoolAIS.Components.Group;
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

namespace AutoschoolAIS.Components.Lesson
{
    public partial class LessonReportForm : Form
    {
        public LessonReportForm()
        {
            InitializeComponent();

            groupIC.GetTextById = id => Env.Db.Query("Group").Where("Id", id).First().Name;
            groupIC.BuildTableViewWithForm = () => new GroupListForm().tableView;
        }

        private void BuildReportAct(object sender, EventArgs e)
        {
            if (groupIC.Id == null)
            {
                MessageBox.Show("Пожалуйста укажите группу.");
                return;
            }

            var group = Env.Db.Query("Group")
                .Where("Id", groupIC.Id)
                .First();

            var hoursStatistic = Env.Db.Query("HoursStatistic")
                .Where("GroupId", groupIC.Id)
                .OrderBy("GroupId", "StudentName", "SubjectName")
                .Get();

            var workbook = Env.Report.LoadTemplate("LessonReport");

            ISheet sheet = workbook.GetSheetAt(0);

            sheet.GetRow(2).GetCell(3).SetCellValue(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            sheet.GetRow(3).GetCell(3).SetCellValue(group.Name);

            int currRow = 7;
            var baseRow = sheet.GetRow(currRow);

            foreach (var statRow in hoursStatistic)
            {
                var row = sheet.GetRow(currRow);

                row.GetCell(0).SetCellValue(statRow.StudentName);
                row.GetCell(3).SetCellValue(statRow.SubjectName);
                row.GetCell(6).SetCellValue(statRow.PlanHours);
                row.GetCell(7).SetCellValue(statRow.PassedHours);
                row.GetCell(8).SetCellValue(statRow.LeftHours);

                currRow++;
                baseRow.CopyRowTo(currRow);
            }

            sheet.RemoveRow(sheet.GetRow(currRow));

            Env.Report.Store("LessonReport", workbook);
            Env.Report.OpenRecentlyStored();
        }
    }
}
