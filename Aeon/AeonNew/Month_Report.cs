using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using System.Globalization;
using Oracle.DataAccess.Client;

namespace AeonNew
{
    public partial class Month_Report : Form
    {
        
        DataTable payment = new DataTable();
        int todayyear1 = DateTime.Now.Year;
        DateTime today = DateTime.Now;
        int Amount;
        OracleDataReader dr;
        DataTable subreport = new DataTable();
        public Month_Report()
        {
            InitializeComponent();
        }


        public void loadit(int todayyear)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select c.ORG_NAME,D.ORGANISATION_ID,NEXT_INSTALLEMENT_DATE,INSTALLEMENT_INTERVAL,TOTAL_AMOUNT,DECIDED_INSTALLEMENT,TOTAL_AMOUNT_RECEIVED ,PREV_INST_ADJ_AMOUNT,NEXT_INSTALLMENT_AMOUNT from CLIENT_INSTALLEMENTS_DETAILS d,CLIENT_DETAILS c Where c.ORGANISATION_ID=d.ORGANISATION_ID";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        int year = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Year;

                        //comboBox1.Items.Add(year);
                        int month = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Month;
                        if (year == todayyear)
                        {
                            Amount = Convert.ToInt32(dr["NEXT_INSTALLMENT_AMOUNT"].ToString());
                            DataRow datarow = subreport.NewRow();
                            string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                            datarow["MonthName"] = strMonthName.ToString();
                            datarow["PartyName"] = dr["ORG_NAME"].ToString();
                            datarow["Amount"] = Amount;
                            subreport.Rows.Add(datarow);
                        }

                    }
                }
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                for (int i = 1; i <= 12; i++)
                {
                    Amount = 0;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select c.ORG_NAME,D.ORGANISATION_ID,NEXT_INSTALLEMENT_DATE,INSTALLEMENT_INTERVAL,TOTAL_AMOUNT,DECIDED_INSTALLEMENT,TOTAL_AMOUNT_RECEIVED ,PREV_INST_ADJ_AMOUNT,NEXT_INSTALLMENT_AMOUNT from CLIENT_INSTALLEMENTS_DETAILS d,CLIENT_DETAILS c Where c.ORGANISATION_ID=d.ORGANISATION_ID";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {

                        while (dr.Read())
                        {
                            int year = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Year;
                            int month = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Month;


                            if (year == todayyear && month == i)
                            {

                                Amount = Amount + Convert.ToInt32(dr["NEXT_INSTALLMENT_AMOUNT"].ToString());

                            }
                        }

                        // if (Amount > 0)
                        {

                            DataRow datarow = payment.NewRow();
                            string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                            datarow["MonthName"] = strMonthName.ToString();
                            datarow["Amount"] = Amount;
                            payment.Rows.Add(datarow);

                        }
                    }
                }
            }
            Report_Month_Due crp = new Report_Month_Due();
            crp.Subreports[0].SetDataSource(subreport);
            crp.SetDataSource(payment);
            crystalReportViewer1.ReportSource = crp; 
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
          

            
        }

        private void MonthReport_Load(object sender, EventArgs e)
        {
            payment.Columns.Add("MonthName", typeof(string));
        
            payment.Columns.Add("Amount", typeof(Int32));
            subreport.Columns.Add("MonthName", typeof(string));
            subreport.Columns.Add("PartyName", typeof(string));
            subreport.Columns.Add("Amount", typeof(Int32));


            loadit(todayyear1);
         


            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment.Clear();
            subreport.Clear();
            loadit(Convert.ToInt32(comboBox1.SelectedItem.ToString()));
        }

    }
}
