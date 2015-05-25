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
    public partial class pin_wise_amc_lost_report : Form
    {
        public pin_wise_amc_lost_report()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pin.SelectedIndex < 0)
            {
                MessageBox.Show("Select Pin");
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleDataAdapter data = new OracleDataAdapter("SELECT c.ORG_NAME,e.EQUIPMENT_NAME,e.TYPE,e.CAPASITY,e.BRAND,c.CITY,e.AMC_UNIT_PRICE,e.AMC_END_DATE FROM CLIENT_DETAILS c, EQUIPMENTT_DETAILS e where c.ORGANISATION_ID = e.ORGANISATION_ID and PIN ='" + pin.SelectedItem.ToString() + "' ", con);

                DataTable dt1 = new DataTable();
                data.Fill(dt1);
                if(dt1.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found Select Different Pin");
                    return;
                }
                DataTable dtCloned = dt1.Clone();
                dtCloned.Columns["AMC_END_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt1.Rows)
                {
                    dtCloned.ImportRow(row);


                }
                foreach (DataRow row in dtCloned.Rows)
                {
                    string df = row["AMC_END_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["AMC_END_DATE"] = df;
                }


                Pin_wise_AMC_LOST_CrystalReport aa = new Pin_wise_AMC_LOST_CrystalReport();
                aa.SetDataSource(dtCloned);



                pinwise_crystalReportViewer.ReportSource = aa;
                con.Close();

            }


        }

        private void pin_wise_amc_lost_report_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT distinct(PIN),STATE FROM CLIENT_DETAILS ", con);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    pin.Items.Add(dr[0].ToString());
                    state.Items.Add(dr["STATE"].ToString());

                }




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(state.SelectedIndex < 0)
            {
                MessageBox.Show("Select State");
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleDataAdapter data = new OracleDataAdapter("SELECT c.ORG_NAME,e.EQUIPMENT_NAME,e.TYPE,e.BRAND,c.CITY,c.PIN,e.AMC_UNIT_PRICE,e.AMC_END_DATE FROM CLIENT_DETAILS c, EQUIPMENTT_DETAILS e where c.ORGANISATION_ID = e.ORGANISATION_ID and STATE ='" + state.SelectedItem.ToString() + "' ", con);

                DataTable dt1 = new DataTable();
                data.Fill(dt1);
                if(dt1.Rows.Count == 0)
                {
                    MessageBox.Show("No Data found Select Different State");
                    return;
                }
                DataTable dtCloned = dt1.Clone();
                dtCloned.Columns["AMC_END_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt1.Rows)
                {
                    dtCloned.ImportRow(row);


                }
                foreach (DataRow row in dtCloned.Rows)
                {
                    string df = row["AMC_END_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["AMC_END_DATE"] = df;
                }


                State_Wise_Amc_Lost_CrystalReport aa = new State_Wise_Amc_Lost_CrystalReport();
                aa.SetDataSource(dtCloned);



                pinwise_crystalReportViewer.ReportSource = aa;
                con.Close();

            }
        }
    }
}
