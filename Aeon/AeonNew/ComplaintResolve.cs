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
    public partial class ComplaintResolve : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter dataAdapter;
        OracleDataReader datareader;
        int org_id, comp_id,flag;
        public ComplaintResolve()
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
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComplaintResolve_Load(object sender, EventArgs e)
        {
            cmb_client_name.Text = "Select Client Name";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_client_name.Items.Add(datareader[0]);
            }
            conn.Close();
        }

        private void cmb_client_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn = ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("select * from COMPLAINT_TABLE where STATUS = 0 and ORGANISATION_ID = (select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client_name.SelectedItem.ToString() + "' ) ", conn);

            DataTable datatable = new DataTable();
            dataAdapter.Fill(datatable);
            dataGridView.DataSource = datatable;
            conn.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            org_id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            comp_id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            flag = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[13].Value.ToString());
            CellClick cellView = new CellClick(org_id, comp_id,flag);
            //cellView.Show();
            cellView.ShowDialog();
        }
    }
}
