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
    public partial class Citywise_Amc_Lost_Report : Form
    {
        public Citywise_Amc_Lost_Report()
        {
            InitializeComponent();
        }

        private void Citywise_Amc_Lost_Report_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT distinct(CITY) FROM CLIENT_DETAILS ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    city.Items.Add(dr[0].ToString());
                    showcity.Items.Add(dr[0].ToString());
                }

                con.Close();
            }
        }

        private void orgname_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentname.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT distinct(EQUIPMENTT_DETAILS.EQUIPMENT_NAME) FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where CITY ='" + city.SelectedItem.ToString() + "' AND ORG_NAME ='" + orgname.SelectedItem.ToString() + "'  ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    equipmentname.Items.Add(dr[0].ToString());

                }

                con.Close();
            }

        }

        private void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            orgname.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                orgname.Items.Clear();
                OracleCommand cmd = new OracleCommand("SELECT distinct(ORG_NAME) FROM CLIENT_DETAILS where CITY='" + city.SelectedItem.ToString() + "' ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    orgname.Items.Add(dr[0].ToString());

                }

                con.Close();
            }

        }

        private void equipmentname_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                type.Items.Clear();
                OracleCommand cmd = new OracleCommand("SELECT distinct(EQUIPMENTT_DETAILS.TYPE) FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where CITY ='" + city.SelectedItem.ToString() + "' AND ORG_NAME ='" + orgname.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "'  ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    type.Items.Add(dr[0].ToString());

                }

                con.Close();
            }

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            brand.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                brand.Items.Clear();

                OracleCommand cmd = new OracleCommand("SELECT distinct(EQUIPMENTT_DETAILS.BRAND) FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where CITY ='" + city.SelectedItem.ToString() + "' AND ORG_NAME ='" + orgname.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "'AND TYPE ='" + type.SelectedItem.ToString() + "'  ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    brand.Items.Add(dr[0].ToString());

                }

                con.Close();
            }

        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            amc_unit_price.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                amc_unit_price.Items.Clear();
                OracleCommand cmd = new OracleCommand("SELECT distinct(EQUIPMENTT_DETAILS.AMC_UNIT_PRICE) FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where CITY ='" + city.SelectedItem.ToString() + "' AND ORG_NAME ='" + orgname.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "'AND TYPE ='" + type.SelectedItem.ToString() + "' AND BRAND ='" + brand.SelectedItem.ToString() + "'  ", con);

                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    amc_unit_price.Items.Add(dr[0].ToString());

                }

                con.Close();
            }

        }

        private void amc_unit_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (city.SelectedIndex < 0)
            {
                MessageBox.Show("Select City");
                return;
            }
            if(orgname.SelectedIndex < 0)
            {
                MessageBox.Show("Select Client");
                return;
            }
            if(equipmentname.SelectedIndex < 0)
            {
                MessageBox.Show("Select Equipment Name");
                return;
            }
            if(brand.SelectedIndex < 0)
            {
                MessageBox.Show("Select Brand");
                return;
            }
            if(type.SelectedIndex < 0)
            {
                MessageBox.Show("Select Type");
                return;
            }
            
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
              
                OracleDataAdapter data = new OracleDataAdapter("SELECT CLIENT_DETAILS.ORG_NAME,CLIENT_DETAILS.CITY,EQUIPMENTT_DETAILS.EQUIPMENT_NAME,EQUIPMENTT_DETAILS.TYPE,EQUIPMENTT_DETAILS.BRAND,EQUIPMENTT_DETAILS.AMC_UNIT_PRICE,EQUIPMENTT_DETAILS.AMC_END_DATE FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where BRAND ='" + brand.SelectedItem.ToString() + "' AND CITY ='" + city.SelectedItem.ToString() + "' AND TYPE ='" + type.SelectedItem.ToString() + "' AND EQUIPMENT_NAME ='" + equipmentname.SelectedItem.ToString() + "'AND ORG_NAME ='" + orgname.SelectedItem.ToString() + "' ", con);


                DataTable dt1 = new DataTable();
                data.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
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




                Citywise_Amc_Lost_CrystalReport aa = new Citywise_Amc_Lost_CrystalReport();
                aa.SetDataSource(dtCloned);



                citywise_crystalReportViewer.ReportSource = aa;
                con.Close();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(showcity.SelectedIndex < 0)
            {
                MessageBox.Show("Select City");
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleDataAdapter data = new OracleDataAdapter("SELECT CLIENT_DETAILS.ORG_NAME,CLIENT_DETAILS.CITY,EQUIPMENTT_DETAILS.EQUIPMENT_NAME,EQUIPMENTT_DETAILS.TYPE,EQUIPMENTT_DETAILS.BRAND,EQUIPMENTT_DETAILS.AMC_UNIT_PRICE,EQUIPMENTT_DETAILS.AMC_END_DATE FROM CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID = EQUIPMENTT_DETAILS.ORGANISATION_ID where CITY ='" + showcity.SelectedItem.ToString() + "' ", con);


                DataTable dt1 = new DataTable();
                data.Fill(dt1);
                if(dt1.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found Select Different City");
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




                Citywise_Amc_Lost_CrystalReport aa = new Citywise_Amc_Lost_CrystalReport();
                aa.SetDataSource(dtCloned);



                citywise_crystalReportViewer.ReportSource = aa;
                con.Close();


            }
        }
    }
}
