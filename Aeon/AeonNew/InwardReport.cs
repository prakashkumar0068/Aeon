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
    public partial class InwardReport : Form
    {
        String fromdate1;
        String todate1;
        int p_id;
        public InwardReport()
        {
            InitializeComponent();
        }

        private void todate_ValueChanged(object sender, EventArgs e)
        {
            productname.Items.Clear();
            productname.Text = "Select Product";
            fromdate1 = fromdate.Value.Day.ToString() + "/" + fromdate.Value.Month.ToString() + "/" + fromdate.Value.Year.ToString();
            todate1 = todate.Value.Day.ToString() + "/" + todate.Value.Month.ToString() + "/" + todate.Value.Year.ToString();


            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd = new OracleCommand("SELECT distinct(PRODUCT.PRODUCT_NAME) FROM PRODUCT inner join INWARD_TABLE ON PRODUCT.PRODUCT_Id=INWARD_TABLE.PRODUCT_Id WHERE INWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') and Active=1", con);

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


            OracleCommand cmd4 = new OracleCommand("SELECT INWARD_TABLE.BRAND FROM PRODUCT inner join INWARD_TABLE ON PRODUCT.PRODUCT_Id=INWARD_TABLE.PRODUCT_Id WHERE INWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') and Active=1 AND PRODUCT_NAME = '" + productname.SelectedItem.ToString() + "'  ", con);


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
            string modalbinding = "SELECT Distinct(MODAL_NUMBER) FROM INWARD_TABLE  Where  BRAND='" + brand.SelectedItem.ToString() + "' and   PRODUCT_ID = " + p_id + " and Active=1 ";

            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd1 = new OracleCommand(modalbinding, con);
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
            OracleCommand cmd3 = new OracleCommand("select Distinct(CAPCITY) from INWARD_TABLE Where  MODAL_NUMBER='" + modal.SelectedItem.ToString() + "' and Active=1 and PRODUCT_ID = " + p_id + " and  BRAND='" + brand.SelectedItem.ToString() + "'  ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                capacity.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void capacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT PRODUCT.PRODUCT_NAME , INWARD_TABLE.SERIAL_NUMBER,INWARD_TABLE.BRAND,INWARD_TABLE.MODAL_NUMBER,INWARD_TABLE.INWARD_DATE FROM PRODUCT inner join INWARD_TABLE ON PRODUCT.PRODUCT_Id=INWARD_TABLE.PRODUCT_Id WHERE INWARD_DATE BETWEEN  TO_DATE( '" + fromdate1 + "','DD/MM/YYYY') AND  TO_DATE('" + todate1 + "','DD/MM/YYYY') and  PRODUCT.PRODUCT_ID=" + p_id + " and INWARD_TABLE.BRAND='" + brand.SelectedItem.ToString() + "' and INWARD_TABLE.MODAL_NUMBER='" + modal.SelectedItem.ToString() + "' and PRODUCT.PRODUCT_NAME='" + productname.SelectedItem.ToString() + "'";
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
            InwardCrystalReport aa = new InwardCrystalReport();
            aa.SetDataSource(dt1);

            inwardcrystalReportViewer.ReportSource = aa;
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleDataAdapter data = new OracleDataAdapter("SELECT PRODUCT.PRODUCT_NAME , INWARD_TABLE.SERIAL_NUMBER,INWARD_TABLE.BRAND,INWARD_TABLE.MODAL_NUMBER,INWARD_TABLE.INWARD_DATE FROM PRODUCT inner join INWARD_TABLE ON PRODUCT.PRODUCT_Id=INWARD_TABLE.PRODUCT_Id ", con);
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
            data.Fill(dt);
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns["INWARD_DATE"].DataType = typeof(string);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
              
              
            }
            foreach (DataRow row in dtCloned.Rows)
            {
                string df = row["INWARD_DATE"].ToString().Replace("12:00:00 AM", "");
                row["INWARD_DATE"] = df;
            }

            InwardCrystalReport a = new InwardCrystalReport();
            a.SetDataSource(dtCloned);


            inwardcrystalReportViewer.ReportSource = a;
            con.Close();

        }

        private void InwardReport_Load(object sender, EventArgs e)
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
