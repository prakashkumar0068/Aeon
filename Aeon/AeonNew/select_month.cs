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
    public partial class select_month : Form
    {
        String fromdate1;
        String todate1;
        OracleConnection conn;
        OracleDataAdapter dataAdapter;
        int ORDER_BOOKED_AME = 0, PAYMENT_COLLECTED_AME = 0, ORDER_BOOKED_AE = 0, PAYMENT_COLLECTED_AE = 0;

        DataTable datatable;
     
        public select_month()
        {
            InitializeComponent();
        }

        private void todate_ValueChanged(object sender, EventArgs e)
        {
            name.Items.Clear();

            fromdate1 = fromdate.Value.Day.ToString() + "/" + fromdate.Value.Month.ToString() + "/" + fromdate.Value.Year.ToString();
            todate1 = todate.Value.Day.ToString() + "/" + todate.Value.Month.ToString() + "/" + todate.Value.Year.ToString();

            conn = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd1 = new OracleCommand("SELECT DISTINCT(MARKETING_PERSON_NAME) FROM DSR WHERE DATE_OF_VISIT BETWEEN  to_date('" + fromdate1 + "','DD/MM/YYYY') AND to_date('" + todate1 + "','DD/MM/YYYY') ", conn);

            OracleDataReader dr2 = cmd1.ExecuteReader();

            while (dr2.Read())
            {
                name.Items.Add(dr2[0].ToString());

            }
           
            conn.Close();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Items.Count == 0)
            {
                MessageBox.Show("Data Not Found Select Different Date ");
                button1.Visible = false;
                return;
            }
            conn = ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("SELECT PARTY_NAME,CONTACTED_PERSON,ORDER_BOOKED_AME,PAYMENT_COLLECTED_AME,ORDER_BOOKED_AE,PAYMENT_COLLECTED_AE from DSR WHERE DATE_OF_VISIT BETWEEN  to_date('" + fromdate1 + "','DD/MM/YYYY') AND  to_date('" + todate1 + "','DD/MM/YYYY') AND  MARKETING_PERSON_NAME = '" + name.SelectedItem.ToString() + "' ", conn);
            datatable = new DataTable();
            dataAdapter.Fill(datatable);
            if(datatable.Rows.Count == 0)
            {
                MessageBox.Show("Select Different Date");
                return;
                    
            }
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                ORDER_BOOKED_AME += Convert.ToInt32(datatable.Rows[i][2].ToString());
                PAYMENT_COLLECTED_AME += Convert.ToInt32(datatable.Rows[i][3].ToString());
                ORDER_BOOKED_AE += Convert.ToInt32(datatable.Rows[i][4].ToString());
                PAYMENT_COLLECTED_AE += Convert.ToInt32(datatable.Rows[i][5].ToString());
            }

            select_month_CrystalReport a = new select_month_CrystalReport();
            a.SetDataSource(datatable);
            selectmonth_crystalReportViewer.ReportSource = a;

            a.SetParameterValue("ORDER_BOOKED_AME", ORDER_BOOKED_AME);
            a.SetParameterValue("PAYMENT_COLLECTED_AME", PAYMENT_COLLECTED_AME);
            a.SetParameterValue("ORDER_BOOKED_AE", ORDER_BOOKED_AE);
            a.SetParameterValue("PAYMENT_COLLECTED_AE", PAYMENT_COLLECTED_AE);
            conn.Close();
            ORDER_BOOKED_AME = 0;
            PAYMENT_COLLECTED_AME = 0;
            ORDER_BOOKED_AE = 0;
            PAYMENT_COLLECTED_AE = 0;
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            ORDER_BOOKED_AME = 0;
            PAYMENT_COLLECTED_AME = 0;
            ORDER_BOOKED_AE = 0;
            PAYMENT_COLLECTED_AE = 0;
        }
    }
}
