using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 r = new XtraReport1();
            r.DataSource = schedulerStorage1.GetAppointments(schedulerControl1.ActiveView.GetVisibleIntervals());
            ReportPrintTool rpt = new ReportPrintTool(r);
            rpt.ShowPreviewDialog();
        }
    }
}