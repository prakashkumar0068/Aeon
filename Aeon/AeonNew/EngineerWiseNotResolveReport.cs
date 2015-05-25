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
    public partial class EngineerWiseNotResolveReport : Form
    {
        DataTable datatable;
        String name;
        public EngineerWiseNotResolveReport(DataTable datatable, String name)
        {
            this.datatable = datatable;
            this.name = name;
            InitializeComponent();
        }

        private void EngineerWiseNotResolveReport_Load(object sender, EventArgs e)
        {
            EngineerWiseNotResolve_CrystalReport report = new EngineerWiseNotResolve_CrystalReport();
            report.SetDataSource(datatable);
            report.SetParameterValue("name",name);
            crystalReportViewer1.ReportSource = report;

        }
    }
}
