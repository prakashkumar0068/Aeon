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
    public partial class ProposalReportViewer : Form
    {
        OracleConnection conn;
        OracleTransaction transaction;
        OracleDataReader datareader;
        OracleCommand cmd;
        String ORG_NAME, ADDRESS, CITY, STATE, PIN, OFFICE_NO, MOBILE_NO;
        ListBox serial_no;



        int sr_no = 0, is_active = 0, TOTAL_AMC_PRICE;


        public ProposalReportViewer(String ORG_NAME, String ADDRESS, String CITY, String STATE, String PIN, String OFFICE_NO, String MOBILE_NO, ListBox serial_no, int TOTAL_AMC_PRICE)
        {
            this.ORG_NAME = ORG_NAME;
            this.ADDRESS = ADDRESS;
            this.CITY = CITY;
            this.STATE = STATE;
            this.PIN = PIN;
            this.OFFICE_NO = OFFICE_NO;
            this.MOBILE_NO = MOBILE_NO;
            this.serial_no = serial_no;
            this.TOTAL_AMC_PRICE = TOTAL_AMC_PRICE;
            InitializeComponent();
         }
        public static OracleConnection getDatabaseConnection()                          // start  connction string
        {

            string connectionString = "Data Source = " +
                                         "(DESCRIPTION = " +
                                         "(ADDRESS_LIST = " +
                                         "(ADDRESS = (PROTOCOL = TCP)" +
                                         "(HOST =10.10.45.122)" +
                                         "(PORT = 1521)" +
                                         ")" +
                                         ")" +
                                         "(CONNECT_DATA = " +
                                         "(SERVICE_NAME = XE)" +
                                         ")" +
                                         ");" +
                                         "User Id = AEON;" +
                                         "password = aeon;";


            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;

        }                                                                                            // end  connction string

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProposalReportViewer_Load(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();

            datatable.Columns.Add("Sr_No", typeof(Int32));
            datatable.Columns.Add("EQUIPMENT_NAME", typeof(String));
            datatable.Columns.Add("SERIAL_NUMBER", typeof(String));
            datatable.Columns.Add("BRAND", typeof(String));
            datatable.Columns.Add("AMC_START_DATE", typeof(String));
            datatable.Columns.Add("AMC_END_DATE", typeof(String));
            datatable.Columns.Add("AMC_UNIT_PRICE", typeof(Int32));
            DataRow dtrow; ;

            conn =ConnectionManager.getDatabaseConnection();

           //for (int i = 0; i < serial_no.Items.Count; i++)
            {
                cmd = new OracleCommand("select EQUIPMENT_NAME,SERIAL_NUMBER,BRAND,AMC_START_DATE,AMC_END_DATE,AMC_UNIT_PRICE from TEMP_EQUIPMENTT_DETAILS", conn);
                datareader = cmd.ExecuteReader();
                sr_no++;
                //dtrow = datatable.NewRow();
                while (datareader.Read())
                {


                    dtrow = datatable.NewRow();
                    dtrow["Sr_No"] = sr_no;
                    dtrow["EQUIPMENT_NAME"] = datareader[0].ToString();
                    dtrow["SERIAL_NUMBER"] = datareader[1].ToString();
                    dtrow["BRAND"] = datareader[2].ToString();
                    dtrow["AMC_START_DATE"] = datareader[3].ToString().Replace("12:00:00 AM", "");
                    dtrow["AMC_END_DATE"] = datareader[4].ToString().Replace("12:00:00 AM", "");
                    dtrow["AMC_UNIT_PRICE"] = Convert.ToInt32(datareader[5].ToString());
                    datatable.Rows.Add(dtrow);

                }
                datareader.Close();

            }
            transaction = conn.BeginTransaction();
            for (int i = 0; i < serial_no.Items.Count; i++)
            {
                cmd = new OracleCommand("select * from TEMP_EQUIPMENTT_DETAILS where SERIAL_NUMBER = '" + serial_no.Items[i].ToString() + "' ", conn);
                datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    cmd = new OracleCommand("insert into EQUIPMENTT_DETAILS values(" + Convert.ToInt32(datareader[0].ToString()) + ",'" + datareader[1].ToString() + "',TO_DATE('" + datareader[2].ToString() + "','DD/MM/YYYY'),'" + datareader[3].ToString() + "','" + datareader[4].ToString() + "','" + datareader[5].ToString() + "'," + Convert.ToInt32(datareader[6].ToString()) + ",TO_DATE('" + datareader[7].ToString() + "','DD/MM/YYYY'),TO_DATE('" + datareader[8].ToString() + "','DD/MM/YYYY')," + (Convert.ToInt32(datareader[9].ToString() + 1)) + ",'" + datareader[10].ToString() + "','" + datareader[11].ToString() + "','" + datareader[12].ToString() + "'," + is_active + ") ", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new OracleCommand("delete from TEMP_EQUIPMENTT_DETAILS where SERIAL_NUMBER = '" + serial_no.Items[i].ToString() + "'  ", conn);
                    cmd.ExecuteNonQuery();





                }
            }

            transaction.Commit();







            ProposalReport report = new ProposalReport();
            report.SetDataSource(datatable);

            crystalReportViewer.ReportSource = report;


            report.SetParameterValue("ORG_NAME", ORG_NAME);
            report.SetParameterValue("ADDRESS", ADDRESS);
            report.SetParameterValue("CITY", CITY);
            report.SetParameterValue("STATE", STATE);
            report.SetParameterValue("PIN", PIN);
            report.SetParameterValue("OFFICE_NO", OFFICE_NO);
            report.SetParameterValue("MOBILE_NO", MOBILE_NO);
            report.SetParameterValue("TOTAL_AMC_PRICE", TOTAL_AMC_PRICE);





            conn.Close();
        }
    }
}
