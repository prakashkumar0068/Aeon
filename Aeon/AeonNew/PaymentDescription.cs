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
    public partial class PaymentDescription : Form
    {
        DataTable datatable ;
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        OracleDataAdapter dataAdapter;
        int org_id;
        public PaymentDescription()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaymentDescription_Load(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while(datareader.Read())
            {
                cmb_client.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_serial_no.Items.Clear();
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '"+cmb_client.SelectedItem.ToString()+"'", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
                org_id = Convert.ToInt32(datareader[0].ToString());
            //MessageBox.Show(""+org_id);
            datareader.Close();
            cmb_serial_no.Items.Clear();
            cmd = new OracleCommand("select distinct(SERIAL_NUMBER) from EQUIPMENTT_DETAILS where  ORGANISATION_ID = "+org_id+"", conn);
            datareader = cmd.ExecuteReader();
            while(datareader.Read())
            {
                cmb_serial_no.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();

           
        }

        private void cmb_serial_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            datatable = new DataTable();
            conn = ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("select a.EQUIPMENT_NAME,a.BRAND,a.TYPE,a.CAPASITY,a.AMC_UNIT_PRICE,b.BILL_NO,b.AMT_RECEIVED,b.AMT_REC_IN,b.DECIDED_INSTALLMENT,b.NUM_INST_COVERED,b.BILL_DATE,c.BANK,c.CHEQUE_DD_NO,c.CHEQUE_DATE from EQUIPMENTT_DETAILS a FULL OUTER JOIN PAYMENT_DETAILS b ON a.ORGANISATION_ID = b.ORGANISATION_ID   FULL OUTER JOIN CHEQUT_DD_DETAILS c ON c.ORGANISATION_ID = b.ORGANISATION_ID and c.BILL_NUMBER = b.BILL_NO WHERE a.SERIAL_NUMBER = '" + cmb_serial_no.SelectedItem.ToString() + "' and b.SERIAL_NUMBER = '" + cmb_serial_no.SelectedItem.ToString() + "'", conn);

          
            dataAdapter.Fill(datatable);
            dataGridView.DataSource = datatable;
            //dataGridView.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //for (int i = 0; i < dataGridView.Columns.Count; i++)
            //{
            //    dataGridView.Columns[i].Width = 170;
            //}
        
            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].Width = 160;
            dataGridView.Columns[5].Width = 160;
            dataGridView.Columns[6].Width = 150;
            dataGridView.Columns[7].Width = 170;
            dataGridView.Columns[8].Width = 160;
            dataGridView.Columns[9].Width = 200;
            dataGridView.Columns[10].Width = 130;
            dataGridView.Columns[11].Width = 130;
            dataGridView.Columns[12].Width = 130;
            dataGridView.Columns[13].Width = 130;
            dataGridView.Columns[0].Width = 140;

        

            dataGridView.Columns[0].HeaderText = "EQUIPMENT NAME";
            dataGridView.Columns[1].HeaderText = "BRAND";
            dataGridView.Columns[2].HeaderText = "TYPE";
            dataGridView.Columns[3].HeaderText = "CAPACITY";
           
            dataGridView.Columns[4].HeaderText = "AMC UNIT PRICE";
            dataGridView.Columns[5].HeaderText = "BILL NUMBER";
            dataGridView.Columns[6].HeaderText = "AMOUNT RECEIVED";
            dataGridView.Columns[7].HeaderText = "PAYMENT MODE ";
            dataGridView.Columns[8].HeaderText = "DECIDED INSTALLMENT";
            dataGridView.Columns[9].HeaderText = "NUMBER OF INSTALLEMENT COVERED";
            dataGridView.Columns[10].HeaderText = "BILL DATE";
            dataGridView.Columns[11].HeaderText = "BANK NAME";
            dataGridView.Columns[12].HeaderText = "CHEQUE/DD NUMBER";
            dataGridView.Columns[13].HeaderText = "CHEQUE DATE";


           
            conn.Close();
        }

        
    }
}
