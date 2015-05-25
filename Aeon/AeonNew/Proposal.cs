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
    public partial class Proposal : Form
    {
        OracleConnection conn;
        OracleCommand cmd, cmd_max;
        OracleDataReader datareader, datareader_max;
        OracleTransaction transaction;
        int org_id, id_max, total_amount;
        String serial_no;
        int TEMP1, TEMP2;
        public Proposal()
        {
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

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_amc_price.Text = "";
            txt_brand.Text = "";
            txt_capacity.Text = "";
            txt_location.Text = "";

            cmb_org_name.Text = "Select Oraganization Name";
            txt_serial.Text = "";
            cmb_equipment_name.Text = "Select Equipment Name";
            cmb_equipment_type.Text = "Select Type";
            cmb_machine_under.Text = "Select Warranty";
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            //start validation part
            if (cmb_org_name.Text == "Select Oraganization Name") { MessageBox.Show("Select Oraganization Name"); return; }
            if (cmb_equipment_name.Text == "Select Equipment Name") { MessageBox.Show("Select Equipment Name"); return; }
            if (cmb_equipment_type.Text == "Select Type") { MessageBox.Show("Select Type"); return; }
            if (txt_capacity.Text == "") { MessageBox.Show("Enter Capacity"); return; }
            if (txt_brand.Text == "") { MessageBox.Show("Enter Brand Name"); return; }
            if (txt_serial.Text == "") { MessageBox.Show("Enter Serial Number"); return; }
            if (txt_amc_price.Text == "") { MessageBox.Show("Enter price"); return; }
            if (cmb_machine_under.Text == "Select Warranty") { MessageBox.Show("Select Warranty"); return; }
            if (txt_location.Text == "") { MessageBox.Show("Enter Location"); return; }
            //end validation part
            else
            {
                conn = ConnectionManager.getDatabaseConnection();
               
                cmd = new OracleCommand("insert into TEMP_EQUIPMENTT_DETAILS values(" + org_id + ",'" + cmb_equipment_name.SelectedItem.ToString() + "',TO_DATE('" + (dateTimePicker_install.Value.Day.ToString() + "/" + dateTimePicker_install.Value.Month.ToString() + "/" + dateTimePicker_install.Value.Year.ToString()) + "','DD/MM/YYYY'),'" + cmb_equipment_type.SelectedItem.ToString() + "','" + txt_capacity.Text + "','" + txt_brand.Text + "','" + Convert.ToInt32(txt_amc_price.Text) + "',TO_DATE('" + (dateTimePicker_start.Value.Day.ToString() + "/" + dateTimePicker_start.Value.Month.ToString() + "/" + dateTimePicker_start.Value.Year.ToString()) + "','DD/MM/YYYY'),TO_DATE('" + (dateTimePicker_end.Value.Day.ToString() + "/" + dateTimePicker_end.Value.Month.ToString() + "/" + dateTimePicker_end.Value.Year.ToString()) + "','DD/MM/YYYY')," + (id_max) + ",'" + cmb_machine_under.SelectedItem.ToString() + "','" + txt_serial.Text + "','" + txt_location.Text + "') ", conn);
                cmd.ExecuteNonQuery();




                cmd_max = new OracleCommand("select MAX(ID) from TEMP_EQUIPMENTT_DETAILS", conn);
                datareader_max = cmd_max.ExecuteReader();
                if (datareader_max.Read())
                {

                    id_max = Convert.ToInt32(datareader_max[0].ToString());
                    id_max = id_max + 1;

                }
                MessageBox.Show("Data Inserted");

                datareader.Close();
                datareader_max.Close();
                conn.Close();

                txt_amc_price.Text = "";                                    //start clear  section 
                txt_brand.Text = "";
                txt_capacity.Text = "";
                txt_location.Text = "";

                cmb_org_name.Text = "Select Oraganization Name";
                txt_serial.Text = "";
                cmb_equipment_name.Text = "Select Equipment Name";
                cmb_equipment_type.Text = "Select Type";
                cmb_machine_under.Text = "Select Warranty";
                //end clear  section
            }
        }

        private void Proposal_Load(object sender, EventArgs e)
        {
            cmb_equipment_name.Text = "Select Equipment Name";
            cmb_equipment_type.Text = "Select Type";
            cmb_machine_under.Text = "Select Warranty";
            cmb_org_name.Text = "Select Oraganization Name";
            //cmb_installement.Text = "Select Installement";

            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_org_name.Items.Add(datareader["ORG_NAME"].ToString());
            }


            cmd_max = new OracleCommand("select MAX(ID) from EQUIPMENTT_DETAILS", conn);
            datareader_max = cmd_max.ExecuteReader();
            if (datareader_max.Read())
            {
                try
                {
                    TEMP1 = Convert.ToInt32(datareader_max[0].ToString());
                    TEMP1 = TEMP1 + 1;
                   
                }
                catch (Exception ex)
                {
                    TEMP1 = 0;
                }
            }



            cmd_max = new OracleCommand("select MAX(ID) from TEMP_EQUIPMENTT_DETAILS", conn);
            datareader_max = cmd_max.ExecuteReader();
            if (datareader_max.Read())
            {
                try
                {
                    TEMP2 = Convert.ToInt32(datareader_max[0].ToString());
                    TEMP2 = TEMP2 + 1;
                   
                }
                catch (Exception ex)
                {
                    TEMP2 = 1;
                }
            }

            if (TEMP1 > TEMP2)
                id_max = TEMP1;
            else
                id_max = TEMP2;




            datareader_max.Close();
            datareader.Close();
            conn.Close();
        }

        private void cmb_org_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_org_name.SelectedItem.ToString() + "'", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {

                org_id = Convert.ToInt32(datareader[0].ToString());


            }
            datareader.Close();
            conn.Close();
        }
    }
}
