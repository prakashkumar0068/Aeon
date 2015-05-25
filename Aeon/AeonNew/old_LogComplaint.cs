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

namespace AeonNew
{
    public partial class old_LogComplaint : Form
    {
        public static string orgname;
        public static string logcomplaint;
        public static int orgid;
        ClientDetails objMain;
        Form _frm;

        public old_LogComplaint(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        public old_LogComplaint()
        {
            // TODO: Complete member initialization
        }

        private void LogComplaint_Load(object sender, EventArgs e)
        {
            objMain = (ClientDetails)_frm;
            DateTime dt = DateTime.Now;
            time.Text = dt.ToString("hh : mm tt");
            string dateToday = DateTime.Now.Date.ToLongDateString();
            datetoday.Text = dateToday.ToString();
            complaintnumberLabel.Text = CountRecords();
            OrgnameLabel.Text = orgname;
            logcomplaintLabel.Text = logcomplaint;
            

        }
        public string CountRecords()
        {

            int max = 0;

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(COMPLAINT_ID) from COMPLAINT_TABLE";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        max = Int32.Parse((dr["max(COMPLAINT_ID)"].ToString()));
                    }
                    catch (Exception es)
                    {

                    }

                }
            }
            max++;
          ///  MessageBox.Show(max+"");

            return max.ToString();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logcomplaintLabel.Text = textBox1.Text;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into COMPLAINT_TABLE VALUES (" + orgid + ", " + complaintnumberLabel.Text + ", '" + datetoday.Text + "', '" + time.Text + "', '" + logcomplaintLabel.Text + "', '" + equipmentTextbox.Text + "', '" + brandTextbox.Text + "', '" + modelTextbox.Text + "', '" + capcityTextbox.Text + "', '" + machinUnderCombo.SelectedItem.ToString() + "', '" + engineerTextbox.Text + "', 'Unresolved','"+faultTextbox.Text+"')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                this.Close();
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogComplaint_FormClosed(object sender, FormClosedEventArgs e)
        {
            objMain.complaintdetails();
        }

    }
}
