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
    public partial class Lost_Amc : Form
    {
        public Lost_Amc()
        {
            InitializeComponent();
        }

        private void Lost_Amc_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT ORG_NAME FROM CLIENT_DETAILS ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    orgname.Items.Add(dr[0].ToString());

                }

                con.Close();

            }
        }

        private void orgname_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentname.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT DISTINCT(EQUIPMENT_NAME) FROM EQUIPMENTT_DETAILS", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                equipmentname.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void equipmentname_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT DISTINCT(type) FROM EQUIPMENTT_DETAILS where   EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "' ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                type.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            capacity.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT capasity FROM EQUIPMENTT_DETAILS where   TYPE ='" + type.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "' ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                capacity.Items.Add(dr3[0].ToString());

            }
            con.Close();
     
        }

        private void capacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            brand.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT BRAND FROM EQUIPMENTT_DETAILS where  CAPASITY ='" + capacity.SelectedItem.ToString() + "' AND TYPE ='" + type.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "' ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                brand.Items.Add(dr3[0].ToString());

            }
            con.Close();

        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            amc_unit_price.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT AMC_UNIT_PRICE FROM EQUIPMENTT_DETAILS where BRAND ='" + brand.SelectedItem.ToString() + "' AND CAPASITY ='" + capacity.SelectedItem.ToString() + "' AND TYPE ='" + type.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "' ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                amc_unit_price.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void amc_unit_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String end_date1 = end_date.Value.Day.ToString() + "/" + end_date.Value.Month.ToString() + "/" + end_date.Value.Year.ToString();
                OracleDataAdapter data = new OracleDataAdapter("SELECT CLIENT_DETAILS.ORG_NAME,EQUIPMENTT_DETAILS.EQUIPMENT_NAME,EQUIPMENTT_DETAILS.TYPE,EQUIPMENTT_DETAILS.CAPASITY,EQUIPMENTT_DETAILS.BRAND,EQUIPMENTT_DETAILS.AMC_UNIT_PRICE,EQUIPMENTT_DETAILS.AMC_END_DATE FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where BRAND ='" + brand.SelectedItem.ToString() + "' AND CAPASITY ='" + capacity.SelectedItem.ToString() + "' AND TYPE ='" + type.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "' ", con);


                DataTable dt1 = new DataTable();
                data.Fill(dt1);
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




                AMC_LOST_CrystalReport aa = new AMC_LOST_CrystalReport();
                aa.SetDataSource(dtCloned);



                lost_amc_crystalReportViewer.ReportSource = aa;
                con.Close();


            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String end_date1 = end_date.Value.Day.ToString() + "/" + end_date.Value.Month.ToString() + "/" + end_date.Value.Year.ToString();
                OracleDataAdapter data = new OracleDataAdapter("SELECT CLIENT_DETAILS.ORG_NAME,EQUIPMENTT_DETAILS.EQUIPMENT_NAME,EQUIPMENTT_DETAILS.TYPE,EQUIPMENTT_DETAILS.CAPASITY,EQUIPMENTT_DETAILS.BRAND,EQUIPMENTT_DETAILS.AMC_UNIT_PRICE,EQUIPMENTT_DETAILS.AMC_END_DATE FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where AMC_END_DATE <= TO_DATE('" + end_date1 + "','DD/MM/YYYY') ", con);


                DataTable dt1 = new DataTable();
                data.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    lost_amc_crystalReportViewer.ReportSource = null;
                    MessageBox.Show("Data Not Found Select Different Date");

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




                AMC_LOST_CrystalReport aa = new AMC_LOST_CrystalReport();
                aa.SetDataSource(dtCloned);

                lost_amc_crystalReportViewer.ReportSource = aa;
                con.Close();


            }
        }
    }
}
