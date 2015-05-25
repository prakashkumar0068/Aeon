using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class CellClick : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        int org_id, comp_id,flag;
        OracleTransaction transaction;
        String path;
        public CellClick(int org_id, int comp_id,int flag)
        {
            this.comp_id = comp_id;
            this.org_id = org_id;
            this.flag = flag;
            path = null;
            InitializeComponent();
        }
        public static OracleConnection getDatabaseConnection()                          // start  connction string
        {

            string connectionString = "Data Source = " +
                                         "(DESCRIPTION = " +
                                         "(ADDRESS_LIST = " +
                                         "(ADDRESS = (PROTOCOL = TCP)" +
                                         "(HOST =10.10.45.122)" +
                                         "(PORT = 1521)" +
                                         ")" +
                                         ")" +
                                         "(CONNECT_DATA = " +
                                         "(SERVICE_NAME = XE)" +
                                         ")" +
                                         ");" +
                                         "User Id = AEON;" +
                                         "password = aeon;";


            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;

        }                                                                                            // end  connction string
        private void CellClick_Load(object sender, EventArgs e)
        {
            cmb_paid.Text = "Select Payment Service";
            if(flag == 0)
            {
                groupBox3.Visible = false;
            }
        }

        private void cmb_paid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_paid.SelectedItem.ToString() == "No")
            {
                return;
            }
            if (cmb_paid.SelectedItem.ToString() == "Yes")
            {
                ComplaintPaymentDetails obj = new ComplaintPaymentDetails(comp_id);
                // obj.Show();
                obj.ShowDialog();
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            if(txt_fault_report.Text == "")
            {
                MessageBox.Show("Enter fault Report");
                return;
            }
            if(txt_action_taken.Text == "")
            {
                MessageBox.Show("Enter Action Taken");
                return;
            }
            if(path == null)
            {
                MessageBox.Show("Click Browse Button and Select Action Report Reciept Image");
                return;
            }
            if (cmb_paid.SelectedIndex < 0 && flag == 1)
            {
                MessageBox.Show("Select Service Type");
                return;
            }
            else
            {
                transaction = conn.BeginTransaction();
                cmd = new OracleCommand("insert into COMPLAINTCLOSINGDETAILS values(" + org_id + "," + comp_id + ",to_date('" + (dateTimePicker.Value.Day.ToString() + "/" + dateTimePicker.Value.Month.ToString() + "/" + dateTimePicker.Value.Year.ToString()) + "','DD/MM/YYYY'),'" + dateTimePicker.Value.ToShortTimeString() + "','" + txt_fault_report.Text + "','" + txt_action_taken.Text + "') ", conn);
                cmd.ExecuteNonQuery();
                cmd = new OracleCommand("update COMPLAINT_TABLE set STATUS = 1 where COMPLAINT_ID = " + comp_id + " ", conn);
                cmd.ExecuteNonQuery();
                Directory.CreateDirectory("Temp");
                File.Copy(path, @"Temp\" + comp_id + ".jpg");
                transaction.Commit();

               

                MessageBox.Show("Data Saved");
            }
            Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Title = "Scanned Copy Of Resolve Complaint";
            browse.InitialDirectory = @"c:\";
            browse.Filter = "All files (*.jpg)|*.*|All files (*.*)|*.*"; ;
            browse.FilterIndex = 2;
            browse.RestoreDirectory = true;
            if (browse.ShowDialog() == DialogResult.OK)
            {
                path = browse.FileName;

            }
            else
                return;

            pictureBox.ImageLocation = path;
            
        }
    }
}
