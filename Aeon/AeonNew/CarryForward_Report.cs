using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Globalization;

namespace AeonNew
{
  
    public partial class CarryForward_Report : Form

    {
        DataTable payment = new DataTable();
        DataTable month = new DataTable();
        public CarryForward_Report()
        {
            InitializeComponent();
        }

        public void loadit()
        {
          
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = payment;
            dataGridView1.DataSource = bindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            payment.Columns.Add("PartyName", typeof(string));
            payment.Columns.Add("Outstanding", typeof(Int32));
            payment.Columns.Add("EquipmentName",typeof(string));
            payment.Columns.Add("Startdate", typeof(string));
            payment.Columns.Add("Enddate", typeof(string));
            payment.Columns.Add("Capacity", typeof(string));
            payment.Columns.Add("Qty", typeof(string));
            payment.Columns.Add("Form", typeof(string));
            payment.Columns.Add("Under", typeof(string));
           month.Columns.Add("PartyName", typeof(string));
           month.Columns.Add("Outstanding", typeof(Int32));
           month.Columns.Add("EquipmentName", typeof(string));
           month.Columns.Add("Startdate", typeof(string));
           month.Columns.Add("Enddate", typeof(string));
           month.Columns.Add("Capacity", typeof(string));
           month.Columns.Add("Qty", typeof(string));
           month.Columns.Add("Form", typeof(string));
          month.Columns.Add("Under", typeof(string));
            //month.Columns.Add("Outstanding", typeof(Int32));

            int todayyear = DateTime.Now.Year;
            DateTime today = DateTime.Now;

            int toaymonth = DateTime.Now.Month;
           String orgname = "";
            
            int d;
            int year; 
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select c.ORG_NAME,D.ORGANISATION_ID,NEXT_INSTALLEMENT_DATE,INSTALLEMENT_INTERVAL,TOTAL_AMOUNT,DECIDED_INSTALLEMENT,TOTAL_AMOUNT_RECEIVED ,PREV_INST_ADJ_AMOUNT,GROUP_ID from CLIENT_INSTALLEMENTS_DETAILS d,CLIENT_DETAILS c Where c.ORGANISATION_ID=d.ORGANISATION_ID";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                   
                    while (dr.Read())
                    {
                        
                        int dt = DateTime.Now.Month;
                        orgname = dr["ORG_NAME"].ToString();
                        year = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Year;
                        d = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Month;
                        int result = DateTime.Compare(today,Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()));
                       if (year > todayyear || (toaymonth<d && year==todayyear))
                        {
                            if (Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString())>0)
                            {
                                DataRow datarow = payment.NewRow();
                                datarow["PartyName"] = orgname.ToString();
                                datarow["Outstanding"] = (Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString()));
                                datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                payment.Rows.Add(datarow);
                            }
                        }
                        int interval = Convert.ToInt32(dr["INSTALLEMENT_INTERVAL"].ToString());
                        int remaining = Convert.ToInt32(dr["TOTAL_AMOUNT"].ToString()) - Convert.ToInt32(dr["TOTAL_AMOUNT_RECEIVED"].ToString());
                        int multiple =0;
                        
                        if (year < todayyear)
                        {
                            
                            int cv = 1;
                            if (toaymonth == d)
                            {
                                dt = 12;
                            }
                            else if (toaymonth < d)
                            {
                                dt = ((todayyear - year) * 12) - (d-toaymonth);
                            }
                            else
                            {
                                dt = ((todayyear - year) * 12) + ( toaymonth-d);
                            }
                           
                            multiple = dt / interval;

                            DateTime ADD = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).AddMonths(dt);
                            //MessageBox.Show(ADD.ToLongDateString());
                            multiple++;
                            int addmonth = ADD.Month;
                            int addyear = ADD.Year;
                            if (today.Month == addmonth && todayyear == addyear)
                            {
                                int decide = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());
                                int prev = Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString());
                                int total = Convert.ToInt32(dr["TOTAL_AMOUNT"].ToString());
                                int compare = (decide * (multiple-1)) + prev;

                                
                                if (compare < total) 

                               
                                {
                                   
                                    DataRow datarow = month.NewRow();
                                    datarow["PartyName"] = orgname.ToString();
                                    datarow["Outstanding"] = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());
                                    datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                    equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                    month.Rows.Add(datarow);
                                    multiple--;
                                }
                            }


                            try
                            {
                                cv = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());

                            }
                            catch
                            {

                            }


                            if ((cv * multiple) > remaining)
                            {

                                //MessageBox.Show("Total" + (cv * multiple) + "" + Convert.ToInt32(dr["GROUP_ID"]));
                                if (remaining > 0)
                                {
                                    DataRow datarow = payment.NewRow();
                                    datarow["PartyName"] = orgname.ToString();
                                    datarow["Outstanding"] = (remaining);
                                    datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                    equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                    payment.Rows.Add(datarow);
                                }


                            }
                            else
                            {
                                
                                DataRow datarow = payment.NewRow();
                                datarow["PartyName"] = orgname.ToString();
                                datarow["Outstanding"] = Convert.ToInt32(((Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString()) * multiple) + Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString())).ToString());
                                equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                payment.Rows.Add(datarow);

                            }
                        }
                       
                        else if (year==todayyear && d<toaymonth )
                        {
                            
                            dt = toaymonth - d;
                            multiple = dt / interval;
                           
                            int cv=1;
                            DateTime ADD = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).AddMonths(multiple*interval);
                            multiple++;
                                
                            
                            int addmonth = ADD.Month;
                            int addyear = ADD.Year;
                            if (toaymonth == addmonth && todayyear == addyear)
                            {
                                int decide = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());
                                int prev = Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString());
                                int total=Convert.ToInt32(dr["TOTAL_AMOUNT"].ToString());
                                int compare=(decide*(multiple-1))+prev;

                               // MessageBox.Show(dr["NEXT_INSTALLEMENT_DATE"].ToString());
                                if (compare<total) 
                                {
                                    //MessageBox.Show(dr["NEXT_INSTALLEMENT_DATE"].ToString());
                                    DataRow datarow = month.NewRow();
                                    datarow["PartyName"] = orgname.ToString();
                                    datarow["Outstanding"] = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());
                                    datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                    equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                    month.Rows.Add(datarow);
                                    multiple--;
                                }
                            }


                            try
                            {
                                cv = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString());
                                
                            }
                            catch
                            {
                                
                            }

                            
                            if ((cv* multiple) > remaining)
                            {
                               
                                
                                if (remaining > 0)
                                {
                                    DataRow datarow = payment.NewRow();
                                    datarow["PartyName"] = orgname.ToString();
                                    datarow["Outstanding"] = (remaining);
                                    datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                    equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                    payment.Rows.Add(datarow);
                                }
                               
                                
                            }
                            else
                            {

                                
                                DataRow datarow = payment.NewRow();
                                datarow["PartyName"] = orgname.ToString();
                                datarow["Outstanding"] = Convert.ToInt32(((Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString()) * multiple) + Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString())).ToString());
                                equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                payment.Rows.Add(datarow);
                             
                            }

                        }
                       
                    }

                }

               
                  
            }
            //loadit();
            report();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }


        public void equipmentdetails(int id, int Group_id, DataRow payment)
        {
             using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + id + " and GROUP_ID=" +Group_id+ "";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {

                        payment["EquipmentName"] = dr["EQUIPMENT_NAME"].ToString();
                        payment["Startdate"] = dr["AMC_START_DATE"].ToString();
                        payment["Enddate"] = dr["AMC_END_DATE"].ToString();
                        payment["Capacity"] = dr["CAPASITY"].ToString();
                        payment["Qty"] = dr["QUANTITY"].ToString();
                        payment["Under"] = dr["UNDER"].ToString();
                     }

                    }
                }
        }

        public void report()
        {
            int todaymonth = DateTime.Now.Month;
            int todayyear = DateTime.Now.Year;
            // MessageBox.Show(todayyear + "   " + todaymonth);


            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select c.ORG_NAME,D.ORGANISATION_ID,NEXT_INSTALLEMENT_DATE,INSTALLEMENT_INTERVAL,TOTAL_AMOUNT,DECIDED_INSTALLEMENT,TOTAL_AMOUNT_RECEIVED ,PREV_INST_ADJ_AMOUNT,GROUP_ID from CLIENT_INSTALLEMENTS_DETAILS d,CLIENT_DETAILS c Where c.ORGANISATION_ID=d.ORGANISATION_ID";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {

                        int getYear = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Year;
                        int getmonth = Convert.ToDateTime(dr["NEXT_INSTALLEMENT_DATE"].ToString()).Month;

                         int remaining = Convert.ToInt32(dr["TOTAL_AMOUNT"].ToString()) - Convert.ToInt32(dr["TOTAL_AMOUNT_RECEIVED"].ToString());
                        if (getmonth == todaymonth && getYear == todayyear)
                        {
                            if (remaining > 0)
                            {  //MessageBox.Show("Anadi");
                                DataRow datarow = month.NewRow();
                                datarow["PartyName"] = dr["ORG_NAME"].ToString();
                                datarow["Outstanding"] = Convert.ToInt32(dr["DECIDED_INSTALLEMENT"].ToString()) + Convert.ToInt32(dr["PREV_INST_ADJ_AMOUNT"].ToString());
                                datarow["Form"] = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                                equipmentdetails(Convert.ToInt32(dr["ORGANISATION_ID"]), Convert.ToInt32(dr["GROUP_ID"]), datarow);
                                month.Rows.Add(datarow);
                            }
                            //month.Rows.Add(datarow);

                        }

                    }
                }

            }
            Double total = 0;
            foreach (DataRow st in month.Rows)
            {
                total = total + Convert.ToInt32(st["Outstanding"]);
            }
            foreach (DataRow st in payment.Rows)
            {
                total = total + Convert.ToInt32(st["Outstanding"]);
            }
           // MessageBox.Show("  " + total);
            Report_CarryForward crp = new Report_CarryForward();
            crp.Subreports[0].SetDataSource(payment);
            crp.SetDataSource(month);
            crp.SetParameterValue("Parameter_GrandTotal", total);
            int monthnumber = DateTime.Now.Month;
            
            string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthnumber);

            crp.SetParameterValue("My Parameter", "Carried Forward And Due Amount For The Month Of " + strMonthName);
            crystalReportViewer1.ReportSource = crp;
        }
      
    }
  
}
