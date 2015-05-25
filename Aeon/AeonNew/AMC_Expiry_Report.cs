using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;


namespace AeonNew
{
    
    public partial class AMC_Expiry_Report : Form
    {
        string command = "select C.ORGANISATION_ID, C.ORG_NAME, EQUIPMENT_NAME, SERIAL_NO, INSTALLATION_DATE,  TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE from CLIENT_DETAILS C, EQUIPMENTT_DETAILS E where C.ORGANISATION_ID = E.ORGANISATION_ID order by ORGANISATION_ID";
        AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
        public AMC_Expiry_Report()
        {
            InitializeComponent();
        }

        private void Complaintreport_Load(object sender, EventArgs e)
        {
          
                

               // report();
            
        }

        public void report()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand com = new OracleCommand(command);
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataAdapter sdt = new OracleDataAdapter(com);
                DataTable ds = new DataTable();
                sdt.Fill(ds);
                if(ds.Rows.Count == 0)
                {
                    MessageBox.Show("Select Different Date");
                    return;
                }
                Report_AMC_Expiry crp = new Report_AMC_Expiry();
                crp.SetDataSource(ds);
                crp.SetParameterValue("Parameter_Date1", dateTimePicker1.Text);
                crp.SetParameterValue("Parameter_Date2", dateTimePicker2.Text);
                crystalReportViewer1.ReportSource = crp;
            }
            // crystalReportViewer1.Refresh();
            
        }

       

     

        private void button3_Click(object sender, EventArgs e)
        {

            command = "select C.ORGANISATION_ID, C.ORG_NAME, EQUIPMENT_NAME, INSTALLATION_DATE, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE from CLIENT_DETAILS C, EQUIPMENTT_DETAILS E where C.ORGANISATION_ID = E.ORGANISATION_ID  and E.AMC_END_DATE >= to_date('" + dateTimePicker1.Text + "') and E.AMC_END_DATE <= to_date('" + dateTimePicker2.Text + "') order by ORGANISATION_ID";
            report();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //command = "select C.ORGANISATION_ID, C.ORG_NAME, EQUIPMENT_NAME, INSTALLATION_DATE, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE from CLIENT_DETAILS C, EQUIPMENTT_DETAILS E where C.ORGANISATION_ID = E.ORGANISATION_ID  and E.AMC_END_DATE >= to_date('" + dateTimePicker1.Text + "') and E.AMC_END_DATE <= to_date('" + dateTimePicker2.Text + "') order by ORGANISATION_ID";
            //report();
        }
    }
}
