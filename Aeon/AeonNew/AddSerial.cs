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
    public partial class AddSerial : Form
    {
        OracleDataAdapter adp;
        DataTable dt;

        public static int  groupid;
        public static int orgid;
        public AddSerial()
        {
            InitializeComponent();
        }

        private void AddSerial_Load(object sender, EventArgs e)
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * From EQUIPMENTT_DETAILS where  GROUP_ID=" + groupid + " and ORGANISATION_ID = " + orgid + "";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                  label2.Text = dr["AMC_START_DATE"].ToString() +"-----"+ dr["AMC_END_DATE"].ToString();
                    label4.Text = dr["QUANTITY"].ToString();
                }

            }
            enter();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();
                _cmdObjj.CommandText = "insert into EQP_SERIAL_LOCATION(ORGANISATION_ID, GROUP_ID, SERIAL_NO, LOCATION) values ("+ orgid +", "+ groupid +", '"+ SerialNumberTextBox.Text +"', '"+ LocationTextBox.Text +"')";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
            }

            DialogResult result = MessageBox.Show("Do you want to add more serial numbers?", "Confirm", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                enter();
                SerialNumberTextBox.Text = "";
                LocationTextBox.Text = "";
            }
            else 
            {
                this.Close();
            }
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.CommandText="Delete from EQP_SERIAL_LOCATION Where Serial_No='"+SerialNumberTextBox.Text+"' and GROUP_ID="+groupid+" and ORGANISATION_ID="+orgid+"";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                   enter();
                }

                  
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int rowindex = e.RowIndex;
                SerialNumberTextBox.Text = dt.Rows[rowindex][2].ToString();
                LocationTextBox.Text = dt.Rows[rowindex][3].ToString();
                button1.Visible = false;
            }
            catch
            {
                MessageBox.Show("Some Error Occur");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void enter()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                String command = "select * From EQP_SERIAL_LOCATION where  GROUP_ID=" + groupid + " and ORGANISATION_ID = " + orgid + "";
                adp = new OracleDataAdapter(command, con);
                dt = new DataTable();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;
                adp.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    label7.Text = "0";
                }
                else
                {
                    dataGridView1.DataSource = bindingSource;
                }

            }
        }
    }
}
