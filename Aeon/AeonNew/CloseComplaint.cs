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
    public partial class CloseComplaint : Form
    {

        private DataTable contactTable = null;
        private OracleCommandBuilder oracleCommandBuilder = null;
        public static int id;
        public static string orgname;
        int complaintid;
        public CloseComplaint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personclosedLabel.Text = textBox1.Text;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into COMPLAINTCLOSINGDETAILS VALUES(" + id + ", " + complaintid + ", '" + dateLabel.Text + "', '" + timecloseText.Text + "', '" + faultTextbox.Text + "', '" + actiontakenText.Text + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.ExecuteNonQuery();
                OracleCommand _cmdObjj = con.CreateCommand();

                _cmdObjj.CommandText = "update COMPLAINT_TABLE set STATUS='Resolved' Where ORGANISATION_ID=" + id + " and COMPLAINT_ID="+complaintid+"";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                MessageBox.Show("Records updated successsfully");
                complaintatn();
               
            }

        }

        private void CloseComplaint_Load(object sender, EventArgs e)
        {
            nameLabel.Text = orgname;
            DateTime dt = DateTime.Now;
            timecloseText.Text = dt.ToString("hh : mm tt");
            string dateToday = DateTime.Now.Date.ToLongDateString();
            dateLabel.Text = dateToday.ToString();
            personclosedLabel.Text = old_LogComplaint.logcomplaint;
            complaintatn();
        }


        public void complaintatn()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                string query = "select * from COMPLAINT_TABLE where ORGANISATION_ID =" +id+" and STATUS='Unresolved'";

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = contactTable;
                complaintGridview.DataSource = bindingSource;
                complaintGridview.Columns[0].Visible = false;
                complaintGridview.RowsDefaultCellStyle.BackColor = Color.Bisque;
                complaintGridview.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void complaintGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            faultTextbox.Text = contactTable.Rows[e.RowIndex][12].ToString();
          
            complaintid =Convert.ToInt32(contactTable.Rows[e.RowIndex][1]);
        }
    }
}
