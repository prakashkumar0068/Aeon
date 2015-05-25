using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class GenerateDateReport : Form
    {
        String s1, s2, s3, s4, s5, s6, s7, s8, s9,s10;
        public GenerateDateReport(String s1, String s2, String s3, String s4, String s5, String s6, String s7, String s8, String s9, String s10)
        {

            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
            this.s5 = s5;
            this.s6 = s6;
            this.s7 = s7;
            this.s8 = s8;
            this.s9 = s9;
            this.s10 = s10;

            InitializeComponent();
        }


        private void GenerateDateReport_Load(object sender, EventArgs e)
        {
            DateReport report = new DateReport();

            report.SetParameterValue("1", s1);
            report.SetParameterValue("2", s2);
            report.SetParameterValue("3", s3);
            report.SetParameterValue("4", s4);
            report.SetParameterValue("5", s5.Replace("12:00:00 AM", " "));
            report.SetParameterValue("6", s6);
            report.SetParameterValue("7", s7.Replace("12:00:00 AM", " "));
            report.SetParameterValue("8", s8);
            report.SetParameterValue("9", s9);
            report.SetParameterValue("10", s10);


            crystalReportViewer.ReportSource = report;
        }
    }
}
