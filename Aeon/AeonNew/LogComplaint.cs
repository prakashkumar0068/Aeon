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
    public partial class LogComplaint : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        int complain_id = 0;

        OracleTransaction transaction;
        public LogComplaint()
        {
            InitializeComponent();
        }

        private void LogComplaint_Load(object sender, EventArgs e)
        {
            cmb_client_name.Text = "Select Client";
            cmb_serial_number.Text = "Select Serial Number";
            txt_brand.Text = "";
            txt_capacity.Text = "";
            txt_engineer_name.Text = "";
            txt_equipment_name.Text = "";
            txt_loging_person.Text = "";
            txt_model.Text = "";
            txt_warranty.Text = "";
            lst_engineers.Items.Clear();
            richTextBox.Text = "";
            cmb_service_type.Text = "Select Service Type";

            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_client_name.Items.Add(datareader[0]);
            }

            cmd = new OracleCommand("select MAX(COMPLAINT_ID) from COMPLAINT_TABLE ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                try
                {
                    complain_id = Convert.ToInt32(datareader[0].ToString());
                    lb_complain_number.Text = (complain_id + 1).ToString();
                }
                catch (Exception ex)
                {
                    complain_id = 0;
                }
            }
            lb_complain_number.Text = (complain_id + 1).ToString();
            datareader.Close();
            conn.Close();

        }

        private void cmb_client_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_serial_number.Items.Clear();
            cmb_serial_number.Text = "Select Serial Number";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select SERIAL_NUMBER from EQUIPMENTT_DETAILS where ORGANISATION_ID = (select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client_name.SelectedItem.ToString() + "' )  ", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_serial_number.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();
        }

        private void cmb_serial_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_equipment_name.Text = "";
            txt_brand.Text = "";
            txt_model.Text = "";
            txt_capacity.Text = "";
            txt_warranty.Text = "";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select EQUIPMENT_NAME,BRAND,CAPASITY,UNDER from EQUIPMENTT_DETAILS where SERIAL_NUMBER = '" + cmb_serial_number.SelectedItem.ToString() + "'  ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                txt_equipment_name.Text = datareader[0].ToString();
                txt_brand.Text = datareader[1].ToString();
                txt_capacity.Text = datareader[2].ToString();
                txt_warranty.Text = datareader[3].ToString();
            }
            datareader.Close();
            conn.Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            lst_engineers.Items.Add(txt_engineer_name.Text).ToString();
            txt_engineer_name.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb_service_type.SelectedIndex.ToString());

            conn = ConnectionManager.getDatabaseConnection();

            transaction = conn.BeginTransaction();
            try
            {

                cmd = new OracleCommand("insert into COMPLAINT_TABLE values((select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client_name.SelectedItem.ToString() + "' )," + (Convert.ToInt32(lb_complain_number.Text)) + ",TO_DATE('" + (dateTimePicker.Value.Day.ToString() + "/" + dateTimePicker.Value.Month.ToString() + "/" + dateTimePicker.Value.Year.ToString()) + "','DD/MM/YYYY'),'" + dateTimePicker.Value.ToShortTimeString() + "','" + txt_loging_person.Text + "','" + txt_equipment_name.Text + "','" + txt_brand.Text + "','','" + txt_capacity.Text + "','" + txt_warranty.Text + "','0','" + richTextBox.Text + "','" + cmb_serial_number.SelectedItem.ToString() + "'," + cmb_service_type.SelectedIndex + ")", conn);
                cmd.ExecuteNonQuery();
                for (int i = 0; i < lst_engineers.Items.Count; i++)
                {
                    cmd = new OracleCommand("insert into ENG_SCHEDULE values(" + (Convert.ToInt32(lb_complain_number.Text)) + ",'" + lst_engineers.Items[i].ToString() + "') ", conn);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Data Saved");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Commit Exception Type: {0}" + ex.GetType().ToString());
                try { transaction.Rollback(); }
                catch (Exception ex_roll) { MessageBox.Show(ex_roll.ToString()); }
            }

            cmd = new OracleCommand("select MAX(COMPLAINT_ID) from COMPLAINT_TABLE ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {

                complain_id = Convert.ToInt32(datareader[0].ToString());

            }

            lb_complain_number.Text = (complain_id + 1).ToString();


            datareader.Close();
            conn.Close();

            //lb_complain_number.Text = complain_id.ToString();
            cmb_client_name.Text = "Select Client";
            cmb_serial_number.Text = "Select Serial Number";
            txt_brand.Text = "";
            txt_capacity.Text = "";
            txt_engineer_name.Text = "";
            txt_equipment_name.Text = "";
            txt_loging_person.Text = "";
            txt_model.Text = "";
            txt_warranty.Text = "";
            lst_engineers.Items.Clear();
            richTextBox.Text = "";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
