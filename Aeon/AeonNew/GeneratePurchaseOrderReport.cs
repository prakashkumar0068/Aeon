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
    public partial class GeneratePurchaseOrderReport : Form
    {
        DataTable datatable = new DataTable();
       
        int tax, grand_total, sub_total, total_tax;
        String Address;
        public GeneratePurchaseOrderReport(DataTable datatable, String Address, int tax, int subtotal)
        {

            this.Address = Address;
            this.datatable = datatable;
           
            this.tax = tax;
            sub_total = subtotal;
            total_tax = (subtotal * tax) / 100;
            grand_total = subtotal + total_tax;
            InitializeComponent();
        }

        private void GeneratePurchaseOrderReport_Load(object sender, EventArgs e)
        {
            PurchaseOrderReport report = new PurchaseOrderReport();

            report.SetDataSource(datatable);
            crystalReportViewer.ReportSource = report;

            report.SetParameterValue("address", Address);
            report.SetParameterValue("sub_total", sub_total);
            report.SetParameterValue("grand_total", grand_total);
            report.SetParameterValue("tax", tax);
            report.SetParameterValue("total_tax", total_tax);
            
           
        }
    }
}
