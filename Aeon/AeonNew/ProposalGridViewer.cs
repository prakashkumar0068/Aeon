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
    public partial class ProposalGridViewer : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        OracleDataAdapter dataAdapter;
        int org_id;
        String ORG_NAME, ADDRESS, CITY, STATE, PIN, OFFICE_NO, MOBILE_NO, serial_no;
        DataTable datatable;
        private int TOTAL_AMC_PRICE;
        public ProposalGridViewer()
        {
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
        private void ProposalGridViewer_Load(object sender, EventArgs e)
        {
            cmb_client.Text = "Select Client Name";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_client.Items.Add(datareader["ORG_NAME"].ToString());
            }
            datareader.Close();
            conn.Close();
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client.SelectedItem.ToString() + "'", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {

                org_id = Convert.ToInt32(datareader[0].ToString());


            }
            datareader.Close();



            cmd = new OracleCommand("select a.ORG_NAME, a.ADDRESS, a.CITY, a.STATE, a.PIN, b.OFFICE_NO, b.MOBILE_NO from CLIENT_DETAILS a,CLIENT_CONTACT_PERSON_DETAILS b where a.ORGANISATION_ID = " + org_id + " and b.ORGANISATION_ID = " + org_id + " ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                ORG_NAME = datareader[0].ToString();
                ADDRESS = datareader[1].ToString();
                CITY = datareader[2].ToString();
                STATE = datareader[3].ToString();
                PIN = datareader[4].ToString();
                OFFICE_NO = datareader[5].ToString();
                MOBILE_NO = datareader[6].ToString();
            }
            datareader.Close();




            dataAdapter = new OracleDataAdapter("select EQUIPMENT_NAME,SERIAL_NUMBER,BRAND,AMC_START_DATE,AMC_END_DATE,AMC_UNIT_PRICE from TEMP_EQUIPMENTT_DETAILS where ORGANISATION_ID = " + org_id + "", conn);
            datatable = new DataTable();
            dataAdapter.Fill(datatable);

            dataGridView.DataSource = datatable;







            conn.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial_no = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            ProposalReportViewer obj = new ProposalReportViewer(ORG_NAME, ADDRESS, CITY, STATE, PIN, OFFICE_NO, MOBILE_NO, lst_items ,TOTAL_AMC_PRICE);
            obj.ShowDialog();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (serial_no == null)
                MessageBox.Show("Select Row");
            else
            {
                lst_items.Items.Add(serial_no);
                serial_no = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst_items.Items.Clear();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
