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
    public partial class PaymentForm : Form
    {
        int bill_no = 1000000;

        public static int pay_orgid = 0;
        public static int pay_groupid = 0;

        double netpaybletotal = 0;
        String NextInstallmentDate;
        String orgName;

        double installmentAmt = 0;
        double Next_installment = 0;
        double amtpaidtill = 0;
        double amountUnpaid = 0;
        double amountExtrapaid = 0;
        double adjAmount = 0;
        int instInterval = 0;
        int installmentsPaid = 0;
        public static int installmentDecided = 0;

        int quotent = 0;
        int numOfInsCov = 0;

        ClientDetails objMain;
        Form _frm;
        public PaymentForm(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(remainiingLabel.Text) < Convert.ToInt32(AmounttextBox.Text))
            {
                MessageBox.Show("Amount is exceed than net outstanding");
            }
            else
            {
                claculation();
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            getBillno();
            Amcsummery();
            //objMain = (ClientDetails)_frm;
            //orgName = objMain.clientNamelable.Text;
            //orgid = Convert.ToInt16(objMain.id.Text);
            //amtpaidtill = Convert.ToDouble(objMain.amtpaidtillLabel.Text);
            //amountUnpaid = Convert.ToDouble(objMain.amtunpaidLabel.Text);
            //amountExtrapaid = Convert.ToDouble(objMain.amtextrapaidLabel.Text);
            //installmentAmt = Convert.ToDouble(objMain.installmentamtLabel.Text);
            //netpaybletotal = Convert.ToDouble(objMain.netPaybleamtLabel.Text);
            //NextInstallmentDate = objMain.nextInstDate.Text;
            //instInterval = Convert.ToInt32(objMain.label9.Text);
            //installmentsPaid = Convert.ToInt32(objMain.installmentsPaid.Text);
        }

        public void getBillno()
        {
            groupBox1.Visible = false;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd1 = new OracleCommand();
                OracleCommand cmd = new OracleCommand("SELECT Max(BILL_NO) FROM PAYMENT_DETAILS", con);
                try
                {
                    bill_no = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch(Exception ex)
                {

                }

                bill_no++;
                BillNumber.Text = bill_no.ToString();
            }
        }


        public void claculation()
        {
            installmentAmt = Convert.ToInt32(installmentamtLabel.Text);
            amountUnpaid = Convert.ToInt32(amtunpaidLabel.Text);
            amountExtrapaid = Convert.ToInt32(amtextrapaidLabel.Text);
            netpaybletotal = Convert.ToInt32(netPaybleamtLabel.Text);
            installmentsPaid = Convert.ToInt32(installmentsPaidLable.Text);
            NextInstallmentDate = nextInstDate.Text;
            amtpaidtill = Convert.ToInt32(amtpaidtillLabel.Text);

            if (Convert.ToDouble(AmounttextBox.Text) >= 2 * (installmentAmt) + amountUnpaid - amountExtrapaid)
            {
                
                double tempAdjAmount = Convert.ToDouble(AmounttextBox.Text) - netpaybletotal;
                quotent = (int)Math.Truncate(tempAdjAmount / installmentAmt);
                int remendor = (int)(tempAdjAmount % installmentAmt);

                instInterval = instInterval + (quotent * instInterval);

                NextInstallmentDate = Convert.ToDateTime(nextInstDate.Text).AddMonths(instInterval).ToLongDateString();

                adjAmount = (-1) * (remendor);
                Next_installment = installmentAmt + adjAmount;
                amtpaidtill = amtpaidtill + Convert.ToDouble(AmounttextBox.Text);

                installmentsPaid = installmentsPaid + quotent + 1;

                numOfInsCov = quotent + 1;
            }
            else
            {
                
                adjAmount = netpaybletotal - Convert.ToDouble(AmounttextBox.Text);
                Next_installment = installmentAmt + adjAmount;
                NextInstallmentDate = Convert.ToDateTime(NextInstallmentDate).AddMonths(instInterval).ToLongDateString();
                amtpaidtill = amtpaidtill + Convert.ToDouble(AmounttextBox.Text);
                installmentsPaid = installmentsPaid + 1;
                numOfInsCov = quotent + 1;
            }

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleDataReader dr;
                    OracleTransaction tranObj;
                    tranObj = con.BeginTransaction();
                    OracleCommand _cmdObjj = con.CreateCommand();
                    try
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select ENTRY_STATUS from DSR where PARTY_NAME='" + orgName + "' ";
                        dr = cmd.ExecuteReader();
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows == true)
                        {
                            _cmdObjj.CommandText = "update DSR set ENTRY_STATUS = 'DONE' where PARTY_NAME='" + orgName + "'";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();
                        }
                        _cmdObjj.CommandText = "insert into PAYMENT_DETAILS(ORGANISATION_ID, BILL_NO, BILL_DATE, AMT_RECEIVED, AMT_REC_IN, DECIDED_INSTALLMENT, NUM_INST_COVERED, GROUP_ID) values(" + pay_orgid + ", " + BillNumber.Text + ", '" + Billdate.Text + "', " + AmounttextBox.Text + ", '" + PaymentmodecomboBox.SelectedItem.ToString() + "', "+ installmentAmt +", "+ numOfInsCov +", "+ pay_groupid +")";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        if (installmentsPaid != installmentDecided)
                        {
                            _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT_RECEIVED =" + amtpaidtill + ", NEXT_INSTALLEMENT_DATE='" + NextInstallmentDate + "', PREV_INST_ADJ_AMOUNT=" + adjAmount + ",  NEXT_INSTALLMENT_AMOUNT=" + Next_installment + ",  INSTALLMENTS_PAID=" + installmentsPaid + " where ORGANISATION_ID=" + pay_orgid + " and GROUP_ID="+ pay_groupid +"";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();
                        }
                        else
                        {
                            _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT_RECEIVED =" + amtpaidtill + ", DECIDED_INSTALLEMENT = 0, NEXT_INSTALLEMENT_DATE='" + NextInstallmentDate + "', PREV_INST_ADJ_AMOUNT=" + adjAmount + ",  NEXT_INSTALLMENT_AMOUNT=" + adjAmount + ",  INSTALLMENTS_PAID=" + installmentsPaid + " where ORGANISATION_ID=" + pay_orgid + " and GROUP_ID="+ pay_groupid +"";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();
                        }
                        
                        //CHEQUE_DD 
                        if (PaymentmodecomboBox.SelectedItem.ToString() == "Cheque / Demand Draft")
                        {
                            label4.Text = "Cheque / Demand Draft Number";

                            _cmdObjj.CommandText = "insert into CHEQUT_DD_DETAILS(ORGANISATION_ID,CHEQUE_DD_NO,CHEQUE_DATE,CHEQUE_AMT,BANK) values(" + pay_orgid + ", '" + chequetextBox.Text + "', '" + chequedateTimePicker.Text + "', " + AmounttextBox.Text + ", '" + bankNametextBox.Text + "')";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();
                         
                        }
                        if (PaymentmodecomboBox.SelectedItem.ToString() == "NEFT/RTGS")
                        {
                            label4.Text = "NEFT/RTGS Draft Number";

                            _cmdObjj.CommandText = "insert into CHEQUT_DD_DETAILS(ORGANISATION_ID,CHEQUE_DD_NO,CHEQUE_DATE,CHEQUE_AMT,BANK) values(" + pay_orgid + ", '" + chequetextBox.Text + "', '" + chequedateTimePicker.Text + "', " + AmounttextBox.Text + ", '" + bankNametextBox.Text + "')";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                        }
                        MessageBox.Show("Data Saved.");
                        tranObj.Commit();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rollback initiated.");
                        tranObj.Rollback();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void PaymentmodecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaymentmodecomboBox.SelectedItem.ToString().Equals("Cash") || PaymentmodecomboBox.SelectedItem.ToString().Equals("Tax"))
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            objMain.clientdetails(orgName);
        }



        public void Amcsummery()
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENT_INSTALLEMENTS_DETAILS where ORGANISATION_ID=" + pay_orgid + " and GROUP_ID="+ pay_groupid +"";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        label15.Text = dr["INSTALLEMENT_INTERVAL"].ToString();
                        totalAMCCostLable.Text = dr["TOTAL_AMOUNT"].ToString();
                        amtpaidtillLabel.Text = dr["TOTAL_AMOUNT_RECEIVED"].ToString();
                        paymentmodeLabel.Text = FindPaymentMode(Convert.ToInt32(dr["INSTALLEMENT_INTERVAL"].ToString()));
                        //downPaymentLabel.Text = dr["DOWN_PAYMENT"].ToString();
                        //amtReceivedTillDate.Text = dr["TOTAL_AMOUNT_RECEIVED"].ToString();
                        installmentsPaidLable.Text = dr["INSTALLMENTS_PAID"].ToString();
                        numberInstDeclabel.Text = dr["TOTAL_NUMBER_INSTALLMENT"].ToString();

                        instInterval = Convert.ToInt32(dr["INSTALLEMENT_INTERVAL"].ToString());

                        remainiingLabel.Text = (Convert.ToInt32(totalAMCCostLable.Text) - Convert.ToInt32(amtpaidtillLabel.Text)).ToString();
                        if (Convert.ToDecimal(dr[6].ToString()) < 0)
                        {
                            amtextrapaidLabel.Text = ((-1) * (Convert.ToDecimal(dr["PREV_INST_ADJ_AMOUNT"].ToString()))).ToString();
                            amtunpaidLabel.Text = "0";
                        }
                        else
                        {
                            amtextrapaidLabel.Text = "0";
                            amtunpaidLabel.Text = Convert.ToDecimal(dr["PREV_INST_ADJ_AMOUNT"]).ToString();
                        }

                        installmentamtLabel.Text = dr["DECIDED_INSTALLEMENT"].ToString();

                        if (Convert.ToDouble(remainiingLabel.Text) <= 0)
                        {
                            netPaybleamtLabel.Text = "0";
                            installmentLabel.Text = "0";
                        }
                        else
                        {
                            netPaybleamtLabel.Text = (Convert.ToDecimal(installmentamtLabel.Text) + Convert.ToDecimal(amtunpaidLabel.Text) - Convert.ToDecimal(amtextrapaidLabel.Text)).ToString();
                            installmentLabel.Text = netPaybleamtLabel.Text;
                        }

                        nextInstDate.Text = dr["NEXT_INSTALLEMENT_DATE"].ToString();
                    }
                }
            }
        }

        public string FindPaymentMode(int interval)
        {
            string strInterval = "";

            if (interval == 1)
                strInterval = "Monthly";
            else if (interval == 6)
                strInterval = "Halfyearly";
            else if (interval == 3)
                strInterval = "Quarterly";
            else
                strInterval = "Anually";

            return strInterval;
        }
    }
}
