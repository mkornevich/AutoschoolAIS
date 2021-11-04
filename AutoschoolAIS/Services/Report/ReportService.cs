using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoschoolAIS.Services.Report
{
    public class ReportService
    {
        private string _recentlyStored;

        public ReportService()
        {

        }

        public IWorkbook LoadTemplate(string reportName)
        {
            var templatePath = Env.AppDirectory + "\\Templates\\" + reportName + ".xlsx";
            var fs = new FileStream(templatePath, FileMode.Open);
            var workbook = new XSSFWorkbook(fs);
            fs.Close();
            return workbook;
        }

        public void Store(string reportName, IWorkbook workbook)
        {
            var reportPath = Env.AppDirectory + "\\Reports\\" + reportName + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".xlsx";
            using (FileStream stream = new FileStream(reportPath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(stream);
            }
            _recentlyStored = reportPath;
        }

        public void OpenRecentlyStored()
        {
            Process.Start(_recentlyStored);
        }
    }
}
