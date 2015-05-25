using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace AeonNew
{
    public partial class Report_DSR : Form
    {
        DateTime today = DateTime.Now;
        int todaymonth = DateTime.Now.Month;
        int todayyear = DateTime.Now.Year;
        DateTime datevisit;
        DataTable contactTable = new DataTable();
        public Report_DSR()
        {
            InitializeComponent();
        }

        private void Report_DSR_Load(object sender, EventArgs e)
        {
            int ORDER_BOOKED_AME_TOTAL = 0;
            int PAYMENT_COLLECTED_AME_TOTAL = 0;
            int ORDER_BOOKED_AE_TOTAL = 0;
            int PAYMENT_COLLECTED_AE_TOTAL = 0;
            contactTable.Columns.Add("ENTRY_ID", typeof(Int32));

            contactTable.Columns.Add("MARKETING_PERSON_NAME", typeof(String));
            contactTable.Columns.Add("PARTY_NAME", typeof(String));
            contactTable.Columns.Add("CONTACTED_PERSON", typeof(String));
            contactTable.Columns.Add("PHONE_NUMBER", typeof(String));
            contactTable.Columns.Add("DATE_OF_VISIT", typeof(String));
            contactTable.Columns.Add("NEXT_CALL_DATE", typeof(String));

            contactTable.Columns.Add("ORDER_BOOKED_AME", typeof(Int32));
            contactTable.Columns.Add("PAYMENT_COLLECTED_AME", typeof(Int32));
            contactTable.Columns.Add("ORDER_BOOKED_AE", typeof(Int32));
            contactTable.Columns.Add("PAYMENT_COLLECTED_AE", typeof(Int32));

            contactTable.Columns.Add("REMARK", typeof(String));
            contactTable.Columns.Add("ENTRY_STATUS", typeof(String));

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String query = "select * from DSR where MARKETING_PERSON_NAME ='" + LoginForm.Username + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                OracleDataReader  dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                   
                    while (dr.Read())
                    {
                        datevisit = Convert.ToDateTime(dr["DATE_OF_VISIT"].ToString());
                        if (datevisit.Month == todaymonth && todayyear == datevisit.Year)
                        {
                            ORDER_BOOKED_AME_TOTAL = ORDER_BOOKED_AME_TOTAL + Convert.ToInt32(dr["ORDER_BOOKED_AME"].ToString());
                            PAYMENT_COLLECTED_AME_TOTAL = PAYMENT_COLLECTED_AME_TOTAL + Convert.ToInt32(dr["PAYMENT_COLLECTED_AME"].ToString());
                            ORDER_BOOKED_AE_TOTAL = ORDER_BOOKED_AE_TOTAL + Convert.ToInt32(dr["ORDER_BOOKED_AE"].ToString());
                            PAYMENT_COLLECTED_AE_TOTAL = PAYMENT_COLLECTED_AE_TOTAL + Convert.ToInt32(dr["PAYMENT_COLLECTED_AE"].ToString());
                            
                            if (today.ToShortDateString().Equals(datevisit.ToShortDateString()))
                            {
                                DataRow newrow = contactTable.NewRow();
                                newrow["ENTRY_ID"] = Convert.ToInt32(dr["ENTRY_ID"].ToString());

                                newrow["MARKETING_PERSON_NAME"] = dr["MARKETING_PERSON_NAME"].ToString();
                                newrow["PARTY_NAME"] = dr["PARTY_NAME"].ToString();
                                newrow["CONTACTED_PERSON"] = (dr["CONTACTED_PERSON"].ToString());
                                newrow["PHONE_NUMBER"] = (dr["PHONE_NUMBER"].ToString());
                                newrow["DATE_OF_VISIT"] = (dr["DATE_OF_VISIT"].ToString());
                                newrow["NEXT_CALL_DATE"] = (dr["NEXT_CALL_DATE"].ToString());

                                newrow["ORDER_BOOKED_AME"] = Convert.ToInt32(dr["ORDER_BOOKED_AME"].ToString());
                                newrow["PAYMENT_COLLECTED_AME"] = Convert.ToInt32(dr["PAYMENT_COLLECTED_AME"].ToString());
                                newrow["ORDER_BOOKED_AE"] = Convert.ToInt32(dr["ORDER_BOOKED_AE"].ToString());
                                newrow["PAYMENT_COLLECTED_AE"] = Convert.ToInt32(dr["PAYMENT_COLLECTED_AE"].ToString());

                                newrow["REMARK"] = (dr["REMARK"].ToString());
                                newrow["ENTRY_STATUS"] = (dr["ENTRY_STATUS"].ToString());

                                contactTable.Rows.Add(newrow);
                            }
                        }
                      }
                }
                //MessageBox.Show("PAYMENT_COLLECTED_AE_TOTAL" + PAYMENT_COLLECTED_AE_TOTAL);
                Report_DSR_MarketingPerson dsr = new Report_DSR_MarketingPerson();
               
                dsr.SetDataSource(contactTable);
                dsr.SetParameterValue("O_AME", ORDER_BOOKED_AME_TOTAL);
                dsr.SetParameterValue("P_AME", PAYMENT_COLLECTED_AME_TOTAL);
                dsr.SetParameterValue("O_AE", ORDER_BOOKED_AE_TOTAL);
                dsr.SetParameterValue("P_AE", PAYMENT_COLLECTED_AE_TOTAL);
                this.crystalReportViewer1.ReportSource = dsr;

            }
        }
    }
}
