using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kalibrasi.report
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //CrystalDecisions.CrystalReports.Engine.ReportDocument rptTemplate = new CrystalDecisions.CrystalReports.Engine.ReportDocument();          

            try
            {
                report.rptDaftarInduk rptDaftarInduk = new rptDaftarInduk();
                switch (global_variable.global.gcReportName)
                {
                    case "Daftar Induk":
                        //rptTemplate.Load("rptDaftarInduk.rpt");
                        crystalReportViewer1.ReportSource = rptDaftarInduk;
                        break;
                    default:
                        //rptTemplate.Load("rptDaftarInduk.rpt");
                        crystalReportViewer1.ReportSource = rptDaftarInduk;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //crystalReportViewer1.ReportSource = rptTemplate;
            crystalReportViewer1.Refresh();
            global_variable.global.gcReportName = "";
        }
    }
}
