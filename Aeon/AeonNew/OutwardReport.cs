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
    public partial class OutwardReport : Form
    {
        String fromdate1;
        String todate1;
        int p_id;
  
        public OutwardReport()
        {
            InitializeComponent();
        }

        private void todate_ValueChanged(object sender, EventArgs e)
        {
            productname.Items.Clear();
            fromdate1 = fromdate.Value.Day.ToString() + "/" + fromdate.Value.Month.ToString() + "/" + fromdate.Value.Year.ToString();
            todate1 = todate.Value.Day.ToString() + "/" + todate.Value.Month.ToString() + "/" + todate.Value.Year.ToString();


            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd = new OracleCommand("SELECT Distinct(PRODUCT.PRODUCT_NAME) FROM PRODUCT inner join OUTWARD_TABLE ON PRODUCT.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id WHERE OUTWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY')  ", con);

            OracleDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                productname.Items.Add(dr[0].ToString());

            }

            con.Close();
            if (productname.Items.Count == 0)
            {
                MessageBox.Show("Data Not Found Select Different Date");
                return;
            }

        }

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd2 = new OracleCommand("select PRODUCT_ID from PRODUCT where PRODUCT_NAME = '" + productname.SelectedItem.ToString() + "'", con);

            OracleDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                p_id = Convert.ToInt32(dr2[0].ToString());

            }

            brand.Items.Clear();


            OracleCommand cmd4 = new OracleCommand("SELECT OUTWARD_TABLE.BRAND FROM PRODUCT inner join OUTWARD_TABLE ON PRODUCT.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id WHERE OUTWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') AND PRODUCT_NAME = '" + productname.SelectedItem.ToString() + "'    ", con);


            OracleDataReader dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                brand.Items.Add(dr4[0].ToString());

            }
            con.Close();

        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {

            modal.Items.Clear();
          

            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd1 = new OracleCommand("SELECT OUTWARD_TABLE.MODAL FROM PRODUCT inner join OUTWARD_TABLE ON PRODUCT.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id WHERE OUTWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') AND PRODUCT_NAME = '" + productname.SelectedItem.ToString() + "' AND BRAND = '" + brand.SelectedItem.ToString() + "'  ", con);

            OracleDataReader dr2 = cmd1.ExecuteReader();

            while (dr2.Read())
            {
                modal.Items.Add(dr2[0].ToString());

            }
            con.Close();
        }

        private void modal_SelectedIndexChanged(object sender, EventArgs e)
        {

            capacity.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("SELECT distinct(INWARD_TABLE.CAPCITY) FROM INWARD_TABLE, PRODUCT,OUTWARD_TABLE  WHERE OUTWARD_TABLE.OUTWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') AND PRODUCT.PRODUCT_NAME = '" + productname.SelectedItem.ToString() + "' AND OUTWARD_TABLE.BRAND = '" + brand.SelectedItem.ToString() + "' and INWARD_TABLE.MODAL_NUMBER = '" + modal.SelectedItem.ToString() + "' and INWARD_TABLE.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id    ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                capacity.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void capacity_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT PRODUCT.PRODUCT_NAME , OUTWARD_TABLE.SERIAL_NUMBER,OUTWARD_TABLE.BRAND,OUTWARD_TABLE.MODAL,OUTWARD_TABLE.OUTWARD_DATE FROM PRODUCT inner join OUTWARD_TABLE ON PRODUCT.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id WHERE OUTWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') and  PRODUCT.PRODUCT_ID=" + p_id + " and OUTWARD_TABLE.BRAND='" + brand.SelectedItem.ToString() + "' and OUTWARD_TABLE.MODAL='" + modal.SelectedItem.ToString() + "' and PRODUCT.PRODUCT_NAME='" + productname.SelectedItem.ToString() + "'";
            bind(query);
        }
        public void bind(string query)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();

            fromdate1 = fromdate.Value.Day.ToString() + "/" + fromdate.Value.Month.ToString() + "/" + fromdate.Value.Year.ToString();
            todate1 = todate.Value.Day.ToString() + "/" + todate.Value.Month.ToString() + "/" + todate.Value.Year.ToString();

            OracleDataAdapter data = new OracleDataAdapter(query, con);


            DataTable dt1 = new DataTable();
            data.Fill(dt1);
            outwardreport aa = new outwardreport();
            aa.SetDataSource(dt1);


            outwardcrystalReportViewer.ReportSource = aa;
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleDataAdapter data = new OracleDataAdapter("SELECT PRODUCT.PRODUCT_NAME , OUTWARD_TABLE.SERIAL_NUMBER , OUTWARD_TABLE.BRAND ,OUTWARD_TABLE.MODAL , OUTWARD_TABLE.OUTWARD_DATE FROM PRODUCT inner join OUTWARD_TABLE ON PRODUCT.PRODUCT_Id=OUTWARD_TABLE.PRODUCT_Id ", con);
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
            data.Fill(dt);
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["OUTWARD_DATE"].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);


            }
            foreach (DataRow row in dtCloned.Rows)
            {
                string df = row["OUTWARD_DATE"].ToString().Replace("12:00:00 AM", "");
                row["OUTWARD_DATE"] = df;
            }

            outwardreport a = new outwardreport();
            a.SetDataSource(dtCloned);
            outwardcrystalReportViewer.ReportSource = a;
          con.Close();

        }

        private void OutwardReport_Load(object sender, EventArgs e)
        {

        }

        private void outwardcrystalReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void productname_MouseClick(object sender, MouseEventArgs e)
        {
            if (productname.Items.Count == 0)
            {
                MessageBox.Show("First Select Date");
                return;
            }
        }
    }
}