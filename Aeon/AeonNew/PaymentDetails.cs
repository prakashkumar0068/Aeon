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
    public partial class PaymentDetails : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        OracleTransaction transaction;
        OracleDataAdapter dataAdapter;
        DataTable datatable;
        int org_id, decided_installement, TOTAL_AMOUNT_RECEIVED, INSTALLMENTS_PAID, bill_no, amc_price, total_install, install_interval, payment_mode = 0;
        String payment_date, cheque_dd_date, next_install_date;
        string machine_id, Ch_DD_No, Ch_DD_Date, bank_name, client, serial_no;
        int max_bill;
        String remark;
        public PaymentDetails()
        {
            remark = "N/A";
            InitializeComponent();
        }
      
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            //if (groupBox_cheque_dd.Visible == false)
            //    MessageBox.Show("Group Box Invisible");

            if (cmb_client.SelectedIndex < 0)
            {
                MessageBox.Show("Select Client Name");
                return;
            }
            if (cmb_serial_no.SelectedIndex < 0)
            {
                MessageBox.Show("Select Serial No");
                return;
            }
            if (cmb_payment_mode.SelectedIndex < 0)
            {
                MessageBox.Show("Select Payment mode");
                return;
            }
            if (txt_amount.Text == "")
            {
                MessageBox.Show("Enter Payment");
                return;
            }
            if (groupBox_cheque_dd.Visible == true)
            {
                if (txt_bank_name.Text == "")
                {
                    MessageBox.Show("Enter Bank Name");
                    return;
                }
                if (txt_cheque_dd_no.Text == "")
                {
                    MessageBox.Show("Enter Cheque/DD No ");
                    return;
                }
            }
            if (cmb_adjust.SelectedIndex < 0)
            {
                MessageBox.Show("Select Adjustment");
                return;
            }
            if (txt_remark.Visible == true && txt_remark.Text == "")
            {
                MessageBox.Show("Enter Remark");
                return;
            }
            else
            {

                
                serial_no = cmb_serial_no.SelectedItem.ToString();
                bill_no += 1;
                TOTAL_AMOUNT_RECEIVED += Convert.ToInt32(txt_amount.Text);
                INSTALLMENTS_PAID += 1;

                next_install_date = dateTimePicker_next_installement.Value.Day.ToString() + "/" + dateTimePicker_next_installement.Value.Month.ToString() + "/" + dateTimePicker_next_installement.Value.Year.ToString();
                payment_date = dateTimePicker_payment_date.Value.Day.ToString() + "/" + dateTimePicker_payment_date.Value.Month.ToString() + "/" + dateTimePicker_payment_date.Value.Year.ToString();
                cheque_dd_date = dateTimePicker_cheque_dd.Value.Day.ToString() + "/" + dateTimePicker_cheque_dd.Value.Month.ToString() + "/" + dateTimePicker_cheque_dd.Value.Year.ToString();

                conn = ConnectionManager.getDatabaseConnection();

                transaction = conn.BeginTransaction();
                if (txt_remark.Visible == true)
                {
                    remark = txt_remark.Text;
                    cmd = new OracleCommand("insert into ADJUSTMENT_PAYMENT values(" + bill_no + "," + Convert.ToInt32(txt_amount.Text) + ",'" + txt_remark.Text + "') ", conn);
                    cmd.ExecuteNonQuery();
                }

                if (groupBox_cheque_dd.Visible == true)
                {
                    Ch_DD_No = txt_cheque_dd_no.Text;
                    Ch_DD_Date = cheque_dd_date;
                    bank_name = txt_bank_name.Text;
                    payment_mode = 1;
                    cmd = new OracleCommand("insert into CHEQUT_DD_DETAILS values(" + org_id + "," + Convert.ToInt32(txt_cheque_dd_no.Text) + ",'" + cheque_dd_date + "'," + Convert.ToInt32(txt_amount.Text) + ",'" + txt_bank_name.Text + "'," + bill_no + ")", conn);
                    cmd.ExecuteNonQuery();
                    //conn.Close();
                }
                cmd = new OracleCommand("insert into PAYMENT_DETAILS values(" + org_id + "," + bill_no + ",to_date('" + payment_date + "','DD/MM/YYYY')," + Convert.ToInt32(txt_amount.Text) + ",'" + cmb_payment_mode.SelectedItem.ToString() + "'," + decided_installement + "," + INSTALLMENTS_PAID + ",'" + cmb_serial_no.SelectedItem.ToString() + "'," + machine_id + ")", conn);
                cmd.ExecuteNonQuery();
                //conn.Close();

                //conn = getDatabaseConnection();
                cmd = new OracleCommand("update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT_RECEIVED = " + TOTAL_AMOUNT_RECEIVED + ",INSTALLMENTS_PAID = " + INSTALLMENTS_PAID + ",NEXT_INSTALLEMENT_DATE = '" + next_install_date + "' where SERIAL_NUMBER = '" + cmb_serial_no.SelectedItem.ToString() + "'and id=" + machine_id + "", conn);
                cmd.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Data Saved");

                cmb_client.Text = "Select Client Name";
                cmb_payment_mode.Text = "Select Payment Mode";
                cmb_serial_no.Text = "Select Serial No.";
                txt_amount.Text = "";
                txt_bank_name.Text = "";
                txt_cheque_dd_no.Text = "";
                cmb_adjust.Text = "Select Adjustment";


                txt_amc_amount.Text = "";
                txt_due_install.Text = "";
                txt_install_amount.Text = "";
                txt_paid_install.Text = "";
                txt_total_due_amount.Text = "";
                txt_total_install.Text = "";
                txt_total_submited_amount.Text = "";
                txt_interval.Text = "";

                conn.Close();
                PaymentEntryBill obj = new PaymentEntryBill((cmb_client.SelectedItem.ToString()), Ch_DD_No, Ch_DD_Date, bank_name, next_install_date, INSTALLMENTS_PAID, payment_mode, serial_no,remark);
                obj.Show();
            }
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            txt_interval.Enabled = false;
            txt_amc_amount.Enabled = false;
            txt_due_install.Enabled = false;
            txt_install_amount.Enabled = false;
            txt_paid_install.Enabled = false;
            txt_total_due_amount.Enabled = false;
            txt_total_install.Enabled = false;
            txt_total_submited_amount.Enabled = false;
            cmb_adjust.SelectedItem = "No";



            groupBox_cheque_dd.Visible = false;
            cmb_client.Text = "Select Client Name";
            cmb_payment_mode.Text = "Select Payment Mode";
            cmb_serial_no.Text = "Select Serial No.";
            txt_amount.Text = "";
            //cmb_adjust.Text = "Select Adjustment";

            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select max(BILL_NO) from PAYMENT_DETAILS ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                try
                {
                    bill_no = Convert.ToInt32(datareader[0].ToString());
                }
                catch (Exception ex)
                {
                    bill_no = 0;
                }
            }
            datareader.Close();
            conn.Close();


            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select distinct(ORG_NAME) from CLIENT_DETAILS  ", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_client.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();
        }

        private void cmb_payment_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment_mode.SelectedIndex == 0)
            { groupBox_cheque_dd.Visible = false; }
            if (cmb_payment_mode.SelectedIndex == 1)
            {
                groupBox_cheque_dd.Visible = true;
                lb_dd_cheque_neft_no.Text = "Cheque/DD No";
                lb_date.Text = "Cheque/DD Date";
            }
            if (cmb_payment_mode.SelectedIndex == 2)
            {
                lb_dd_cheque_neft_no.Text = "General Transaction No";
                lb_date.Text = "RTGS/NEFT Date";
                groupBox_cheque_dd.Visible = true;
            }
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client.SelectedItem.ToString() + "' ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
                org_id = Convert.ToInt32(datareader[0].ToString());
            //MessageBox.Show(org_id.ToString());
            datareader.Close();
            conn.Close();

            //conn = ConnectionManager.getDatabaseConnection();
            //cmd = new OracleCommand("Select e.SERIAL_NUMBER from EQUIPMENTT_DETAILS e,CLIENT_INSTALLEMENTS_DETAILS c where e.ORGANISATION_ID = " + org_id + " and e.SERIAL_NUMBER = c.SERIAL_NUMBER", conn);
            //datareader = cmd.ExecuteReader();
            //while (datareader.Read())
            //{
            //    cmb_serial_no.Items.Add(datareader[0].ToString());
            //}
            //datareader.Close();
            conn.Close();
        }


        private void cmb_serial_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
            {
                bt_submit.Visible = true;
                OracleDataReader dr;
                string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {

                    cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from EQUIPMENTT_DETAILS where SERIAL_NUMBER='" + cmb_serial_no.SelectedItem.ToString() + "' and  ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY') and IS_ACTIVE=1";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        while (dr.Read())
                        {
                            // total_amount = Convert.ToInt32(dr["AMC_UNIT_PRICE"].ToString());
                            machine_id = dr["ID"].ToString();
                            //txt_amount.Text = total_amount+"";
                            //serial_no = serialNumber.SelectedItem.ToString();
                        }

                    }


                    dr.Close();
                }

                conn = ConnectionManager.getDatabaseConnection();
                cmd = new OracleCommand("select DECIDED_INSTALLEMENT,TOTAL_AMOUNT_RECEIVED,INSTALLMENTS_PAID,TOTAL_AMOUNT,TOTAL_NUMBER_INSTALLMENT,INSTALLEMENT_INTERVAL from CLIENT_INSTALLEMENTS_DETAILS where SERIAL_NUMBER = '" + cmb_serial_no.SelectedItem.ToString() + "' and  ID=" + machine_id + "", conn);
                datareader = cmd.ExecuteReader();
                if (datareader.Read())
                {
                    decided_installement = Convert.ToInt32(datareader[0].ToString());
                    TOTAL_AMOUNT_RECEIVED = Convert.ToInt32(datareader[1].ToString());
                    INSTALLMENTS_PAID = Convert.ToInt32(datareader[2].ToString());
                    amc_price = Convert.ToInt32(datareader[3].ToString());
                    total_install = Convert.ToInt32(datareader[4]);
                    install_interval = Convert.ToInt32(datareader[5]);

                }
               
                
                //MessageBox.Show(TOTAL_AMOUNT_RECEIVED.ToString());

                txt_amc_amount.Text = amc_price.ToString();
                txt_due_install.Text = (total_install - INSTALLMENTS_PAID).ToString();
                txt_install_amount.Text = decided_installement.ToString();
                txt_paid_install.Text = INSTALLMENTS_PAID.ToString();
                txt_total_due_amount.Text = (amc_price - TOTAL_AMOUNT_RECEIVED).ToString();
                txt_total_install.Text = total_install.ToString();
                txt_total_submited_amount.Text = TOTAL_AMOUNT_RECEIVED.ToString();
                txt_interval.Text = install_interval.ToString();
                if (Convert.ToInt32(txt_total_due_amount.Text) <= 0)
                {
                    MessageBox.Show("All Installment Covered or Total Due Amount Covered");
                    bt_submit.Visible = false;
                }

                datareader.Close();
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
            getserial("Select SERIAL_NUMBER from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY')  and IS_ACTIVE=1");
        }
        public void getserial(string query)
        {
            OracleDataReader dr;

            cmb_serial_no.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        cmb_serial_no.Items.Add(dr["SERIAL_NUMBER"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
            getserial("Select SERIAL_NUMBER from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY')  and IS_ACTIVE=1");
        }

        private void cmb_adjust_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (cmb_adjust.SelectedIndex == 0)
            {
                txt_remark.Visible = false;
                label7.Visible = false;
            }
              if (cmb_adjust.SelectedIndex == 1)
              {
                  txt_remark.Visible = true;
                  label7.Visible = true;
              }
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void txt_cheque_dd_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

       
    }
}
