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
    public partial class Quantity : Form
    {
        public Quantity()
        {
            InitializeComponent();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("SELECT distinct(PRODUCT_NAME)  from PRODUCT  ", con);


                OracleDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    item.Items.Add(dr[0].ToString());

                }

                con.Close();
            }
        }

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleDataAdapter data = new OracleDataAdapter("select distinct(PRODUCT_NAME),QTY from PRODUCT where PRODUCT_NAME='" + item.SelectedItem.ToString() + "' ", con);


            DataTable dt1 = new DataTable();
            data.Fill(dt1);

            product_quantity_crystal_report aa = new product_quantity_crystal_report();
            aa.SetDataSource(dt1);


            QuanitycrystalReportViewer.ReportSource = aa;
            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleDataAdapter data = new OracleDataAdapter("select distinct(PRODUCT_NAME),QTY from PRODUCT ", con);


            DataTable dt1 = new DataTable();
            data.Fill(dt1);

            product_quantity_crystal_report aa = new product_quantity_crystal_report();
            aa.SetDataSource(dt1);


            QuanitycrystalReportViewer.ReportSource = aa;
            con.Close();
        }
    }
}
