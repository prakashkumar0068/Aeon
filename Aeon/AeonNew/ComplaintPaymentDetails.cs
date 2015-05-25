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
    public partial class ComplaintPaymentDetails : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        int COMPLAINT_ID;
        String payment_date, cheque_dd_date, bill;

        public ComplaintPaymentDetails(int COMPLAINT_ID)
        {
            this.COMPLAINT_ID = COMPLAINT_ID;
            InitializeComponent();
        }
      
        private void ComplaintPaymentDetails_Load(object sender, EventArgs e)
        {
            cmb_payment_mode.Text = "Select Payment Mode";
            groupBox_cheque_dd.Visible = false;
            txt_amount.Text = "";
            txt_bank_name.Text = "";
            txt_bill_no.Text = "";
            txt_bill_no.Enabled = false;
            txt_cheque_dd_no.Text = "";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select max(BILL_NUMBER) from COMPLAINT_PAYMENT_DETAILS ", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                try
                {
                    bill = datareader[0].ToString();
                    txt_bill_no.Text = (Convert.ToInt32(bill) + 1).ToString();
                }
                catch (Exception ex)
                {
                    bill = "0";
                    txt_bill_no.Text = (Convert.ToInt32(bill) + 1).ToString();

                }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_payment_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_payment_mode.SelectedIndex == 0)
            {
                groupBox_cheque_dd.Visible = false;  
            }
            if (cmb_payment_mode.SelectedIndex == 1)
            {
                
                label4.Text = "Cheque/DD Number";
                label5.Text = "Cheque/DD Date";
                groupBox_cheque_dd.Visible = true;
            }
            if(cmb_payment_mode.SelectedIndex == 2)
            {
                label4.Text = "General Trasaction No";
                label5.Text = "NEFT/RTGS Date";
                groupBox_cheque_dd.Visible = true;

            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (cmb_payment_mode.SelectedIndex < 0)
            {
                MessageBox.Show("Select Payment Mode");
                return;
            }
            if (txt_amount.Text == "")
            {
                MessageBox.Show("Enter Amount");
                return;
            }


            if (groupBox_cheque_dd.Visible == true && txt_bank_name.Text == "")
            {
                MessageBox.Show("Enter Bank Name");
                return;
            }
            if (groupBox_cheque_dd.Visible == true && txt_cheque_dd_no.Text == "")
            {
                MessageBox.Show("Enter Date");
                return;
            }
            payment_date = dateTimePicker_payment_date.Value.Day.ToString() + "/" + dateTimePicker_payment_date.Value.Month.ToString() + "/" + dateTimePicker_payment_date.Value.Year.ToString();
            cheque_dd_date = dateTimePicker_cheque_dd.Value.Day.ToString() + "/" + dateTimePicker_cheque_dd.Value.Month.ToString() + "/" + dateTimePicker_cheque_dd.Value.Year.ToString();
            conn =ConnectionManager.getDatabaseConnection();
            try
            {
               

                    
                {
                    cmd = new OracleCommand("insert into COMPLAINT_PAYMENT_DETAILS values (" + Convert.ToInt32(txt_bill_no.Text) + "," + COMPLAINT_ID + "," + Convert.ToInt32(txt_amount.Text) + ",to_date('" + payment_date + "','DD/MM/YYYY'),'" + cmb_payment_mode.SelectedItem.ToString() + "','" + txt_cheque_dd_no.Text + "','" + txt_bank_name.Text + "',to_date('" + cheque_dd_date + "','DD/MM/YYYY'))", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved");
                    Close();
                }
            }
            catch (EntitySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
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
