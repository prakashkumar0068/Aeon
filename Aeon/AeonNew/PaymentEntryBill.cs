using Oracle.DataAccess.Client;
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
    public partial class PaymentEntryBill : Form
    {
        int max_bill, payment_mode, INSTALLMENTS_PAID;
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter dataAdapter;
        OracleDataReader datareader;
        DataTable datatable;
        String cmb_client, Ch_DD_Date, next_install_date, bank_name, Ch_DD_No, serial_no, remark;



        public PaymentEntryBill(String cmb_client, String Ch_DD_No, String Ch_DD_Date, String bank_name, String next_install_date, int INSTALLMENTS_PAID, int payment_mode, string serial_no, string remark)
        {
            this.cmb_client = cmb_client;
            this.Ch_DD_No = Ch_DD_No;
            this.Ch_DD_Date = Ch_DD_Date;
            this.bank_name = bank_name;
            this.next_install_date = next_install_date;
            this.INSTALLMENTS_PAID = INSTALLMENTS_PAID;
            this.payment_mode = payment_mode;
            this.serial_no = serial_no;
            this.remark = remark;

            InitializeComponent();
        }
        //PurchaseOrderReport
        private void PaymentEntryBill_Load(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("Select Max(BILL_NO) from PAYMENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
                max_bill = Convert.ToInt32(datareader[0].ToString());

            dataAdapter = new OracleDataAdapter("select BILL_NO,DECIDED_INSTALLMENT,AMT_REC_IN,AMT_RECEIVED,NUM_INST_COVERED,SERIAL_NUMBER from PAYMENT_DETAILS where SERIAL_NUMBER = '" + serial_no + "' and BILL_NO  = " + max_bill + "", conn);
            datatable = new DataTable();
            dataAdapter.Fill(datatable);
            RecieptReport report = new RecieptReport();

            report.SetDataSource(datatable);
            crystalReportViewer.ReportSource = report;
            if (payment_mode == 1)
            {
                report.SetParameterValue("client", cmb_client);
                report.SetParameterValue("Ch/DD_No", Ch_DD_No);
                report.SetParameterValue("Ch/DD_Date", Ch_DD_Date);
                report.SetParameterValue("bank_name", bank_name);
                report.SetParameterValue("next_install_date", next_install_date);
                report.SetParameterValue("paid_install", INSTALLMENTS_PAID);
                report.SetParameterValue("remark", remark);
            }
            else
            {
                report.SetParameterValue("client", cmb_client);
                report.SetParameterValue("Ch/DD_No", "N/A");
                report.SetParameterValue("Ch/DD_Date", "N/A");
                report.SetParameterValue("bank_name", "N/A");
                report.SetParameterValue("next_install_date", next_install_date);
                report.SetParameterValue("paid_install", INSTALLMENTS_PAID);
                report.SetParameterValue("remark", remark);
            }
            datareader.Close();
            conn.Close();
        }

      

       
    }
}
