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
    public partial class EquipmentDetails : Form
    {
        OracleConnection conn;
        OracleCommand cmd, cmd_max;
        OracleDataReader datareader, datareader_max;
        int org_id, id_max, total_amount, TOTAL_AMC_PRICE;
        string serial_no;
        public EquipmentDetails()
        {
            InitializeComponent();
        }

        // end  connction string

        private void EquipmentDetails_Load(object sender, EventArgs e)
        {
            cmb_equipment_name.Text = "Select Equipment Name";
            cmb_equipment_type.Text = "Select Type";
            cmb_machine_under.Text = "Select Warranty";
            cmb_org_name.Text = "Select Oraganization Name";
            // cmb_installement.Text = "Select Installement";

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
                    id_max = Convert.ToInt32(datareader_max[0].ToString());
                }
                catch (Exception ex)
                {
                    id_max = 0;
                }
            }

            datareader_max.Close();
            datareader.Close();
            cmd = new OracleCommand("select distinct(EQUIPMENT_NAME) from EQUIPMENT_NAME", conn);
            datareader = cmd.ExecuteReader();
            while(datareader.Read())
            {
                cmb_equipment_name.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();


        }

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
            //  cmb_installement.Text = "Select Installement";
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
                id_max++;
                TOTAL_AMC_PRICE += Convert.ToInt32(txt_amc_price.Text); 
                cmd = new OracleCommand("insert into TEMP_EQUIPMENTT_DETAILS values(" + org_id + ",'" + cmb_equipment_name.SelectedItem.ToString() + "',TO_DATE('" + (dateTimePicker_install.Value.Day.ToString() + "/" + dateTimePicker_install.Value.Month.ToString() + "/" + dateTimePicker_install.Value.Year.ToString()) + "','DD/MM/YYYY'),'" + cmb_equipment_type.SelectedItem.ToString() + "','" + txt_capacity.Text + "','" + txt_brand.Text + "','" + Convert.ToInt32(txt_amc_price.Text) + "',TO_DATE('" + (dateTimePicker_start.Value.Day.ToString() + "/" + dateTimePicker_start.Value.Month.ToString() + "/" + dateTimePicker_start.Value.Year.ToString()) + "','DD/MM/YYYY'),TO_DATE('" + (dateTimePicker_end.Value.Day.ToString() + "/" + dateTimePicker_end.Value.Month.ToString() + "/" + dateTimePicker_end.Value.Year.ToString()) + "','DD/MM/YYYY')," + (id_max) + ",'" + cmb_machine_under.SelectedItem.ToString() + "','" + txt_serial.Text + "','" + txt_location.Text + "',0) ", conn);
                cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Do you want Add more device", "Information", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    bt_submit.Enabled = false;
                }
                listBox1.Items.Add(txt_serial.Text + "  " + cmb_equipment_name.SelectedItem.ToString());
                conn.Close();


            }




        }

        private void cmb_org_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete_temp();
            listBox1.Items.Clear();
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

        //private void cmb_installement_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //     if (cmb_installement.SelectedIndex == 0)
        //    {
        //        if (txt_amc_price.Text == "")
        //        {
        //            MessageBox.Show("Enter AMC Unit Price");
        //            cmb_installement.Text = "Select Installement";

        //            return;
        //        }
        //        serial_no = txt_serial.Text;
        //        total_amount = Convert.ToInt32(txt_amc_price.Text);
        //        Installement obj = new Installement(org_id, total_amount ,serial_no);
        //        obj.ShowDialog();
        //     }
        //}

        private void txt_amc_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        public void delete_temp()
        {
            conn = ConnectionManager.getDatabaseConnection();
            //   id_max++;
            cmd = new OracleCommand("Delete from TEMP_EQUIPMENTT_DETAILS  ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ORG_NAME = "", ADDRESS = "", CITY = "", STATE = "", PIN = "", OFFICE_NO = "", MOBILE_NO = "", serial_no = "";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select a.ORG_NAME, a.ADDRESS, a.CITY, a.STATE, a.PIN, b.OFFICE_NO, b.MOBILE_NO from CLIENT_DETAILS a,CLIENT_CONTACT_PERSON_DETAILS b where a.ORGANISATION_ID = " + org_id + " and b.ORGANISATION_ID = " + org_id + " ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                ORG_NAME = datareader[0].ToString();
                ADDRESS = datareader[1].ToString();
                CITY = datareader[2].ToString();
                STATE = datareader[3].ToString();
                PIN = datareader[4].ToString();
                OFFICE_NO = datareader[5].ToString();
                MOBILE_NO = datareader[6].ToString();
            }
            datareader.Close();
            conn.Close();
            ProposalReportViewer obj = new ProposalReportViewer(ORG_NAME, ADDRESS, CITY, STATE, PIN, OFFICE_NO, MOBILE_NO, listBox1, TOTAL_AMC_PRICE);
           obj.ShowDialog();
           try
           {
               conn = ConnectionManager.getDatabaseConnection();
               cmd.CommandText = "insert into EQUIPMENTT_DETAILS select * from TEMP_EQUIPMENTT_DETAILS";
               cmd.CommandType = CommandType.Text;
               cmd.Connection = conn;
               cmd.Parameters.Clear();
               cmd.ExecuteNonQuery();
               conn.Close();

           }

           catch(Exception ex)
           {

           }
        }

        private void txt_serial_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txt_serial_Leave(object sender, EventArgs e)
        {
            cmb_equipment_name.Enabled = true;
            cmb_equipment_type.Enabled = true;
            txt_brand.Enabled = true;
            txt_capacity.Enabled = true;
            cmb_machine_under.Enabled = true;


            cmb_equipment_name.Text = "";
            cmb_equipment_type.Text = "";
            txt_brand.Text = "";
            txt_capacity.Text = "";
            cmb_machine_under.Text = "";
            txt_amc_price.Text = "";
            dateTimePicker_end.Text = "";
            dateTimePicker_start.Text = "";
            dateTimePicker_install.Text = "";
            txt_location.Text = ""; 

            if (txt_serial.Text.Length > 0)
            {

                conn = ConnectionManager.getDatabaseConnection();
                cmd = new OracleCommand("Select * from EQUIPMENTT_DETAILS where SERIAL_NUMBER = '" + txt_serial.Text + "' and ORGANISATION_ID=" + org_id + "", conn);
                datareader = cmd.ExecuteReader();

                if (datareader.Read())
                {

                    cmb_equipment_name.Text = datareader["EQUIPMENT_NAME"].ToString();
                    cmb_equipment_type.Text = datareader["TYPE"].ToString();
                    txt_brand.Text = datareader["BRAND"].ToString();
                    txt_capacity.Text = datareader["CAPASITY"].ToString();
                    cmb_machine_under.Text = datareader["UNDER"].ToString();
                    txt_amc_price.Text = datareader["AMC_UNIT_PRICE"].ToString();
                    dateTimePicker_end.Text = datareader["AMC_START_DATE"].ToString();
                    dateTimePicker_start.Text = datareader["AMC_END_DATE"].ToString();
                    dateTimePicker_install.Text = datareader["INSTALLATION_DATE"].ToString();
                    txt_location.Text = datareader["LOCATION"].ToString();
                    cmb_equipment_name.Enabled = false;
                    cmb_equipment_type.Enabled = false;
                    txt_brand.Enabled = false;
                    txt_capacity.Enabled = false;
                    cmb_machine_under.Enabled = false;


                }
                datareader.Close();
                conn.Close();
            }
        }
    }
}
    

