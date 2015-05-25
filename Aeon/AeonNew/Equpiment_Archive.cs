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
    public partial class Equpiment_Archive : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        OracleTransaction transaction;
        List<string> orgid = new List<string>();
        string id = "";
        int eqp_id,unit_price,is_active,org_id;
        String serial_no;
        public Equpiment_Archive()
        {
            InitializeComponent();
            serial_no = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Equpiment_Archive_Load(object sender, EventArgs e)
        {
           OracleConnection conn = ConnectionManager.getDatabaseConnection();
           OracleCommand cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
           OracleDataReader  datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_org_name.Items.Add(datareader["ORG_NAME"].ToString());
                //orgid.Add(datareader["ORGANISATION_ID"].ToString());
            }
            conn.Close();

        }

        private void cmb_org_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_serial_no.Items.Clear();
            cmb_serial_no.Text = "Select Serial No";
            dataGridView.DataSource = "";
            
            OracleConnection conn = ConnectionManager.getDatabaseConnection();
           
            OracleCommand cmd = new OracleCommand("select * from  CLIENT_DETAILS Where ORG_NAME='"+cmb_org_name.SelectedItem+"'", conn);
             OracleDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                id = datareader["ORGANISATION_ID"].ToString();
                //  orgid.Add(datareader["ORGANISATION_ID"].ToString());
            }
            conn.Close();
            datareader.Close();
            conn.Open();
            try
            {
                string todate1 = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                
                 cmd = new OracleCommand("select Distinct(SERIAL_NUMBER) From EQUIPMENTT_DETAILS Where ORGANISATION_ID=" +id + " and IS_ACTIVE=1 and AMC_END_DATE < to_date('" + todate1 + "','DD/MM/YYYY')", conn);
                 datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    cmb_serial_no.Items.Add(datareader["SERIAL_NUMBER"].ToString());
                    
                }
                
            }
            catch(Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serial_no = null;
            databind();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            serial_no = dataGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
           
            
        }

        private void bt_archive_Click(object sender, EventArgs e)
        {
            if (cmb_org_name.SelectedIndex < 0)
            {
                MessageBox.Show("Select Client Name");
                return;
            }
            if (cmb_serial_no.SelectedIndex < 0)
            {
                MessageBox.Show("Select Serial No");
                return;
            }
            if (serial_no == null)
            {
                MessageBox.Show("Click Coresponding Cell in Grid View Which Product Want to Archive");
                return;
            }
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select * from EQUIPMENTT_DETAILS where SERIAL_NUMBER = '"+serial_no+"' ", conn);
            datareader = cmd.ExecuteReader();

            if (datareader.Read())
            {
                
             
                transaction = conn.BeginTransaction();
                eqp_id = Convert.ToInt32(datareader[9].ToString());
                unit_price = Convert.ToInt32(datareader[6].ToString());
                is_active = Convert.ToInt32(datareader[13].ToString());
                org_id = Convert.ToInt32(datareader[0].ToString());
                try
                {
                   
              
                    {
                        cmd = new OracleCommand("insert into ARCHIVED_TABLE_EQUIPMENT values(" + org_id + ",'" + datareader[1].ToString() + "',to_date('" + datareader[2].ToString().Replace("12:00:00 AM", "") + "','DD/MM/YYYY'),'" + datareader[3].ToString() + "','" + datareader[4].ToString() + "','" + datareader[5].ToString() + "'," + unit_price + ",to_date('" + datareader[7].ToString().Replace("12:00:00 AM", "") + "','DD/MM/YYYY'),to_date('" + datareader[8].ToString().Replace("12:00:00 AM", "") + "','DD/MM/YYYY')," + eqp_id + ",'" + datareader[10].ToString() + "','" + datareader[11].ToString() + "','" + datareader[12].ToString() + "'," + is_active + ") ", conn);
                        cmd.ExecuteNonQuery();
                        cmd = new OracleCommand("delete from EQUIPMENTT_DETAILS where SERIAL_NUMBER = '" + serial_no + "'", conn);
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        MessageBox.Show("Data Successfully Archieved");
                        databind();
                    }
                }
                catch (EntitySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    datareader.Close();
                    conn.Close();
                }
            }
        }
        public void databind()
        {
            OracleConnection conn = ConnectionManager.getDatabaseConnection();
            try
            {
                string todate1 = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

                OracleDataAdapter cmd = new OracleDataAdapter("select * From EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + id + " and IS_ACTIVE=1 and AMC_END_DATE < to_date('" + todate1 + "','DD/MM/YYYY') and SERIAL_NUMBER='" + cmb_serial_no.SelectedItem + "'", conn);
                DataTable dt = new DataTable();
                cmd.Fill(dt);
                dataGridView.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
