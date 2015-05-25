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
    public partial class ProductName_Wise_AMC_LostReport : Form
    {
        public ProductName_Wise_AMC_LostReport()
        {
            InitializeComponent();
        }

        private void ProductName_Wise_AMC_LostReport_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT distinct(EQUIPMENT_NAME) FROM EQUIPMENTT_DETAILS ", con);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    productname.Items.Add(dr[0].ToString());


                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productname.SelectedIndex < 0)
            {
                MessageBox.Show("Select Product");
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleDataAdapter data = new OracleDataAdapter("select CLIENT_DETAILS.ORG_NAME,EQUIPMENTT_DETAILS.EQUIPMENT_NAME,EQUIPMENTT_DETAILS.TYPE,EQUIPMENTT_DETAILS.BRAND,CLIENT_DETAILS.CITY,EQUIPMENTT_DETAILS.AMC_UNIT_PRICE,EQUIPMENTT_DETAILS.AMC_END_DATE from  CLIENT_DETAILS inner join EQUIPMENTT_DETAILS on CLIENT_DETAILS.ORGANISATION_ID=EQUIPMENTT_DETAILS.ORGANISATION_ID where EQUIPMENT_NAME='" + productname.SelectedItem.ToString() + "' ", con);

                DataTable dt = new DataTable();
                data.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data Not Found Select Different Product");
                    return;
                }
                DataTable dcloan = dt.Clone();
                dcloan.Columns["AMC_END_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dcloan.ImportRow(row);


                }
                foreach (DataRow row in dcloan.Rows)
                {
                    string df = row["AMC_END_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["AMC_END_DATE"] = df;
                }

                ProductName_Wise_AMC_Lost_CrystalReport aa = new ProductName_Wise_AMC_Lost_CrystalReport();
                aa.SetDataSource(dcloan);



                ProductNameWisecrystalReportViewer.ReportSource = aa;
                con.Close();

            }
        }
    }
}
   