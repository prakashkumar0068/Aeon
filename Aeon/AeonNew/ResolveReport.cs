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
    public partial class ResolveReport : Form
    {

        String s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11,s12,client_name,s13,s14,s15;

        public ResolveReport(String s1, String s2, String s3, String s4, String s5, String s6, String s7, String s8, String s9, String s10, String s11, String s12, String client_name)
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
            this.s11 = s11;
            this.s12 = s12;
            this.client_name = client_name;






            InitializeComponent();
        }

        private void ResolveReport_Load(object sender, EventArgs e)
        {
            solveReport report = new solveReport();
            
            report.SetParameterValue("1", s1);
            report.SetParameterValue("2", s2);
            report.SetParameterValue("3", s3);
            report.SetParameterValue("4", s4);
            report.SetParameterValue("6", s5);
            report.SetParameterValue("5", s6);
            report.SetParameterValue("8", s7);
            report.SetParameterValue("11", s8);
            report.SetParameterValue("7", s9);
            report.SetParameterValue("10", s10);
            report.SetParameterValue("9", s11);

            report.SetParameterValue("client_name", client_name);

            report.SetParameterValue("12", s12);

            crystalReportViewer.ReportSource = report;
        }
    }
}
