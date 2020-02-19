using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Utilities.Reports
{
   public static class ReportUtilities
    {
        public static ReportViewer LoadReport(string name, params ReportParameter[] parameters)
        {
            ReportViewer report = new ReportViewer();
            var serverreporturl = "http://desktop-j4aknco/ReportServer/";

            report.ProcessingMode = ProcessingMode.Remote;
            report.SizeToReportContent = true;
            report.AsyncRendering = true;
            report.ShowExportControls = true;
            report.ShowFindControls = true;
            report.ShowToolBar = true;
            report.ShowPrintButton = true;
            report.ServerReport.ReportServerUrl = new Uri(serverreporturl);
            report.ServerReport.ReportPath = "/"+ name;

            foreach (var item in parameters)
            {
                report.ServerReport.SetParameters(item);
            }
          

            return report;
        }

    }
}
