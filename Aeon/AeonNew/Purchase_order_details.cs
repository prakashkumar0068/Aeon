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
    public partial class Purchase_order_details : Form
    {
        int id;

        String date1;

        public Purchase_order_details()
        {
            InitializeComponent();
        }

       
        private void Purchase_order_details_Load(object sender, EventArgs e)
        {
            OracleConnection conn = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("select ORG_NAME,ORGANISATION_ID from CLIENT_DETAILS ", conn);
            OracleDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                org_name.Items.Add(datareader[0]);
                //id = Convert.ToInt32(datareader[1].ToString());

            }
            OracleCommand cmd1 = new OracleCommand("select PO_NUMBER from PURCHASE_ORDER ", conn);
            OracleDataReader datareader1 = cmd1.ExecuteReader();
            while (datareader1.Read())
            {
                po_number.Items.Add(datareader1[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (org_name.SelectedIndex < 0)
            {
                MessageBox.Show("Select Organization Name");
                return;
            }

            else
            {

                OracleConnection con = ConnectionManager.getDatabaseConnection();
                OracleDataAdapter data = new OracleDataAdapter("SELECT  PURCHASE_ORDER.PO_NUMBER,PURCHASE_ORDER.ORGANISATION_ID,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION_ID,PURCHASE_ORDER_DESCRIPTION.QTY,PURCHASE_ORDER_DESCRIPTION.UNIT_PRICE,PURCHASE_ORDER.PO_DATE,PURCHASE_ORDER.TAX FROM  PURCHASE_ORDER  inner join PURCHASE_ORDER_DESCRIPTION ON PURCHASE_ORDER.PO_NUMBER = PURCHASE_ORDER_DESCRIPTION.PO_NUMBER where  PURCHASE_ORDER.ORGANISATION_ID = " + id + " ", con);
                //  OracleDataAdapter data = new OracleDataAdapter("SELECT   * from PURCHASE_ORDER_DESCRIPTION", con);
                DataTable dt1 = new DataTable();
                DataTable dt = new DataTable();
                data.Fill(dt);
                DataTable dtCloned = dt.Clone();
                dtCloned.Columns["PO_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dtCloned.ImportRow(row);


                }
                foreach (DataRow row in dtCloned.Rows)
                {
                    string df = row["PO_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["PO_DATE"] = df;
                }

                purchasereport a = new purchasereport();
                a.SetDataSource(dtCloned);


                purchase_order_crystalReportViewer1.ReportSource = a;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (po_number.SelectedIndex < 0)
            {
                MessageBox.Show("Select PO Number");
                return;
            }

            else
            {

                OracleConnection con = ConnectionManager.getDatabaseConnection();
                OracleDataAdapter data = new OracleDataAdapter("SELECT  PURCHASE_ORDER.PO_NUMBER,PURCHASE_ORDER.ORGANISATION_ID,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION_ID,PURCHASE_ORDER_DESCRIPTION.QTY,PURCHASE_ORDER_DESCRIPTION.UNIT_PRICE,PURCHASE_ORDER.PO_DATE,PURCHASE_ORDER.TAX FROM  PURCHASE_ORDER  inner join PURCHASE_ORDER_DESCRIPTION ON PURCHASE_ORDER.PO_NUMBER = PURCHASE_ORDER_DESCRIPTION.PO_NUMBER where  PURCHASE_ORDER.ORGANISATION_ID = " + id + " AND PURCHASE_ORDER.PO_NUMBER = '" + po_number.SelectedItem.ToString() + "' ", con);
                //  OracleDataAdapter data = new OracleDataAdapter("SELECT   * from PURCHASE_ORDER_DESCRIPTION", con);
                DataTable dt1 = new DataTable();
                DataTable dt = new DataTable();
                data.Fill(dt);
                DataTable dtCloned = dt.Clone();
                dtCloned.Columns["PO_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dtCloned.ImportRow(row);


                }
                foreach (DataRow row in dtCloned.Rows)
                {
                    string df = row["PO_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["PO_DATE"] = df;
                }

                purchasereport a = new purchasereport();
                a.SetDataSource(dtCloned);


                purchase_order_crystalReportViewer1.ReportSource = a;
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
           

           
            {
                date1 = date.Value.Day.ToString() + "/" + date.Value.Month.ToString() + "/" + date.Value.Year.ToString();

                OracleConnection con = ConnectionManager.getDatabaseConnection();
                OracleDataAdapter data = new OracleDataAdapter("SELECT  PURCHASE_ORDER.PO_NUMBER,PURCHASE_ORDER.ORGANISATION_ID,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION,PURCHASE_ORDER_DESCRIPTION.DESCRIPTION_ID,PURCHASE_ORDER_DESCRIPTION.QTY,PURCHASE_ORDER_DESCRIPTION.UNIT_PRICE,PURCHASE_ORDER.PO_DATE,PURCHASE_ORDER.TAX FROM  PURCHASE_ORDER  inner join PURCHASE_ORDER_DESCRIPTION ON PURCHASE_ORDER.PO_NUMBER = PURCHASE_ORDER_DESCRIPTION.PO_NUMBER where PURCHASE_ORDER.PO_DATE =  TO_DATE('" + date1 + "','DD/MM/YYYY')  ", con);


                DataTable dt = new DataTable();
                data.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    purchase_order_crystalReportViewer1.ReportSource = null;
                    MessageBox.Show("Data Not Found Select Another Date");
                    return;
                }
                DataTable dtCloned = dt.Clone();
                dtCloned.Columns["PO_DATE"].DataType = typeof(string);
                foreach (DataRow row in dt.Rows)
                {
                    dtCloned.ImportRow(row);


                }
                foreach (DataRow row in dtCloned.Rows)
                {
                    string df = row["PO_DATE"].ToString().Replace("12:00:00 AM", "");
                    row["PO_DATE"] = df;
                }


                purchasereport a = new purchasereport();
                a.SetDataSource(dtCloned);


                purchase_order_crystalReportViewer1.ReportSource = a;
                con.Close();
            }

        }

        private void org_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection conn = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS  where ORG_NAME='"+org_name.SelectedItem.ToString()+"'", conn);
            OracleDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {

                id = Convert.ToInt32(datareader[0].ToString());

            }
         
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {


        }

        private void po_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection conn = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("select ORGANISATION_ID from PURCHASE_ORDER  where PO_NUMBER=" + Convert.ToInt32(po_number.SelectedItem.ToString()) + "", conn);
            OracleDataReader datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {

                id = Convert.ToInt32(datareader[0].ToString());

            }
        }
    }
}
