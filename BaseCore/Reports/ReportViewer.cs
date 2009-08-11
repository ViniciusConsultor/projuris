using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BaseCore
{
    public partial class ReportViewer : Form
    {
        private bool firstTime;
        public Microsoft.Reporting.WinForms.ReportViewer compRptViewer
        {
            get { return reportViewer1; }
        }
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.firstTime = true;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(reportViewer1_RenderingComplete);
            this.reportViewer1.LocalReport.SubreportProcessing +=
               new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.reportViewer1.RefreshReport();
        }
        //tbock: Para processamento dos SubReports
        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        { 
        
        }

        void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            //Caso colocasse juntamente com o Load, o report iria aparecer como 'was canceled' e não iria aparecer o carregamento do report.
            if (this.firstTime)
            {
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
                this.firstTime = false;
            }
        }


    }
}
