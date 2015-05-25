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
    public partial class Form2 : Form
    {
        string command="";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void details()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand com = new OracleCommand(command);
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataAdapter sdt = new OracleDataAdapter(com);
                DataTable ds = new DataTable();
                sdt.Fill(ds);
                dataGridView1.DataSource = ds;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = "select C.ORGANISATION_ID, C.ORG_NAME, EQUIPMENT_NAME, INSTALLATION_DATE, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE,E.ID,E.GROUP_ID,QUANTITY from CLIENT_DETAILS C, EQUIPMENTT_DETAILS E  where C.ORGANISATION_ID = E.ORGANISATION_ID  and E.AMC_END_DATE >= to_date('" + dateTimePicker1.Text + "') and E.AMC_END_DATE <= to_date('" + dateTimePicker2.Text + "') order by ORGANISATION_ID";
            // report();
            details();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string ORG_NAME = "";
            string EQUIPMENT_NAME = "";
            string AMC_START_DATE = "";

            string AMC_END_DATE = "";
            string CAPASITY = "";
            string BRAND = "";
            string QUANTITY = "";
            string group = "";
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ORG_NAME = row.Cells["ORG_NAME"].Value.ToString();
                EQUIPMENT_NAME = row.Cells["EQUIPMENT_NAME"].Value.ToString();
                AMC_START_DATE = row.Cells["AMC_START_DATE"].Value.ToString();
                AMC_END_DATE = row.Cells["AMC_END_DATE"].Value.ToString();
                CAPASITY = row.Cells["CAPASITY"].Value.ToString();
                BRAND = row.Cells["BRAND"].Value.ToString();
                QUANTITY = row.Cells["QUANTITY"].Value.ToString();
                group = row.Cells["GROUP_ID"].Value.ToString();

            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form3 example = new Form3(ORG_NAME, EQUIPMENT_NAME, AMC_START_DATE, AMC_END_DATE, CAPASITY, BRAND, QUANTITY,group);
                example.ShowDialog();
            }
                 
        }
    }
}
