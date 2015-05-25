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
    public partial class AlterInstallmentPatern : Form
    {
        public static int executionLineFlag = 0;

        public static int orgId = 0;
        public static int eqpId = 0;

        public static string eqpName = "";
        public static string eqpType = "";
        public static string eqpSerial = "";
        public static string eqpLocation = "";
        public static string eqpCapacity = "";
        public static string eqpBrand = "";
        public static int eqpAMCCost = 0;

        public static string eqpInstDate = "";
        public static string eqpAMCStart = "";
        public static string eqpAMCEnd = "";

        public static int totalAMCCost = 0;
        public static int totalPaid = 0;
        public static int altEqpAmount = 0;

        public static int altTotalNoInst = 0;
        public static int altInstPaid = 0;

        public static string altAMCEndDate = "";

        int noInst = 0;
        double newInstAmt = 0;
        int max = 0;

        public AlterInstallmentPatern()
        {
            InitializeComponent();
            this.newNoInstextBox.KeyPress += new KeyPressEventHandler(amountReceivedTextBox_KeyPress);
        }
        private void amountReceivedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void AlterInstallmentPatern_Load(object sender, EventArgs e)
        {
            int altRemainingAmt = totalAMCCost - totalPaid;
            altNetAmt.Text = (altRemainingAmt + eqpAMCCost).ToString();
            
            if (executionLineFlag == 3)
            {
                altNetAmt.Text = (totalAMCCost - totalPaid).ToString();
            }
            else if (executionLineFlag == 4)
            {
                int altTotlAMCWithoutUpdateMachineCost = totalAMCCost - altEqpAmount;
                altNetAmt.Text = (altTotlAMCWithoutUpdateMachineCost + eqpAMCCost - totalPaid).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "" || comboBox1.Text == "---select----")
            {
                MessageBox.Show("Installment Mode Field is Empty");
                return;
            }
            if(newNoInstextBox.Text=="" || newNoInstextBox.Text.Trim()=="")
            {
                MessageBox.Show("Number of Installment Field is Empty");
                return;
            }
            if (executionLineFlag == 0)
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select max(ID) from EQUIPMENTT_DETAILS";
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        try
                        {
                            max = Int32.Parse((dr["max(ID)"].ToString()));
                        }
                        catch
                        {

                        }
                    }
                }
                max++;
                calculateAndMakeEntry();
            }

            else if (executionLineFlag == 1)
            { 
                //This function will handle the case when Equipment details is modified and Equipment AMC Amount has been altered
                calculateAndMakeEntry1();
            }

            else if (executionLineFlag == 2)
            {
                calculateAndMakeEntry1();
            }

            else if (executionLineFlag == 3)
            {
                calculateAndMakeEntry3();
            }

            else if (executionLineFlag == 4)
            {
                calculateAndMakeEntry1();
            }

            else if (executionLineFlag == 5)
            {
                eqpAMCCost = 0;
                calculateAndMakeEntry1();
            }
        }

        public void calculateAndMakeEntry()
        {
            int noInst = altTotalNoInst + Convert.ToInt32(newNoInstextBox.Text);
            int noInstDist = noInst - altInstPaid;
            totalAMCCost = totalAMCCost + eqpAMCCost;

            newInstAmt = Convert.ToInt32(altNetAmt.Text) / noInstDist;
            int roundednewInstAmt = (int)Math.Truncate(newInstAmt);
            if (roundednewInstAmt < newInstAmt)
            {
                roundednewInstAmt = roundednewInstAmt + 1;
            }

            int interval = FindInterval(comboBox1.SelectedItem.ToString());

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleTransaction tranObj;
                    tranObj = con.BeginTransaction();
                    OracleCommand _cmdObjj = con.CreateCommand();
                    try
                    {
                        if (eqpName != "UPS")
                        {
                            _cmdObjj.CommandText = "insert into EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, SERIAL_NO, INSTALLATION_DATE, LOCATION, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER) VALUES (" + orgId + ", '" + eqpName + "', '" + eqpSerial + "', '" + eqpInstDate + "', '" + eqpLocation + "', '" + eqpCapacity + "', '" + eqpBrand + "', " + eqpAMCCost + ", '" + eqpAMCStart + "', '" + eqpAMCEnd + "', " + max + ", 'AMC')";
                        }
                        else
                        {
                            _cmdObjj.CommandText = "insert into EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, SERIAL_NO, INSTALLATION_DATE, LOCATION, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER) VALUES (" + orgId + ", '" + eqpName + "', '" + eqpSerial + "', '" + eqpInstDate + "', '" + eqpLocation + "', '" + eqpType + "', '" + eqpCapacity + "', '" + eqpBrand + "', " + eqpAMCCost + ", '" + eqpAMCStart + "', '" + eqpAMCEnd + "', " + max + ", 'AMC')";
                        }

                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT=" + totalAMCCost + ", DECIDED_INSTALLEMENT=" + roundednewInstAmt + ", INSTALLEMENT_INTERVAL=" + interval + ", NEXT_INSTALLEMENT_DATE='" + dateTimePicker1.Text + "', PREV_INST_ADJ_AMOUNT=0, TOTAL_NUMBER_INSTALLMENT=" + noInst + ", NEXT_INSTALLMENT_AMOUNT=" + roundednewInstAmt + " where ORGANISATION_ID=" + orgId + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        tranObj.Commit();
                        MessageBox.Show("Data Inserted");
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

        public void calculateAndMakeEntry1()
        {
            int newAMCTotal = totalAMCCost - altEqpAmount + eqpAMCCost;
            int newPayableAMCTotal = newAMCTotal - totalPaid;
            int instRemain = altTotalNoInst - altInstPaid + Convert.ToInt32(newNoInstextBox.Text);
            double newInstallmentAmt = (double)newPayableAMCTotal / instRemain;
            int TotalNumberOfInstallments = altTotalNoInst + Convert.ToInt32(newNoInstextBox.Text);
            int newRoundedInstallmentAmt = (int)Math.Truncate(newInstallmentAmt);

            if (newRoundedInstallmentAmt < newInstallmentAmt)
            {
                newRoundedInstallmentAmt = newRoundedInstallmentAmt + 1;
            }
            updateDatabase(newAMCTotal, TotalNumberOfInstallments, newRoundedInstallmentAmt);
        }

        public void calculateAndMakeEntry3()
        {
            int newAMCTotal = Convert.ToInt32(altNetAmt.Text);
            int numOfoIns = Convert.ToInt32(newNoInstextBox.Text);
            int totalNumberOfInstallments = altTotalNoInst + Convert.ToInt32(newNoInstextBox.Text);
            double newInstallmentAmt = (double)newAMCTotal / numOfoIns;
            int newRoundedInstallmentAmt = (int)Math.Truncate(newInstallmentAmt);
            if (newRoundedInstallmentAmt < newInstallmentAmt)
            {
                newRoundedInstallmentAmt = newRoundedInstallmentAmt + 1;
            }
            int newInterval = FindInterval(comboBox1.Text);
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();
                _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set DECIDED_INSTALLEMENT=" + newRoundedInstallmentAmt + ", INSTALLEMENT_INTERVAL=" + newInterval + ", NEXT_INSTALLEMENT_DATE='" + dateTimePicker1.Text + "', PREV_INST_ADJ_AMOUNT=0, TOTAL_NUMBER_INSTALLMENT=" + totalNumberOfInstallments + ", NEXT_INSTALLMENT_AMOUNT=" + newRoundedInstallmentAmt + " where ORGANISATION_ID=" + orgId + "";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.ExecuteNonQuery();
            }
            this.Close();
        }

        /*public void calculateAndMakeEntry4()
        {
            int newAMCTotal = Convert.ToInt32(altNetAmt.Text);
            int instRemain = altTotalNoInst - altInstPaid + Convert.ToInt32(newNoInstextBox.Text);
            int TotalNumberOfInstallments = altTotalNoInst + Convert.ToInt32(newNoInstextBox.Text);
            double newInstallmentAmt = (double)newAMCTotal / instRemain;
            int newRoundedInstallmentAmt = (int)Math.Truncate(newInstallmentAmt);
            if (newRoundedInstallmentAmt < newInstallmentAmt)
            {
                newRoundedInstallmentAmt = newRoundedInstallmentAmt + 1;
            }
            updateDatabase(newAMCTotal, TotalNumberOfInstallments, newRoundedInstallmentAmt);
        }*/
        public int FindInterval(string installmentMode)
        {
            int interval = 0;

            if (installmentMode == "Monthly")
                interval = 1;
            else if (installmentMode == "Quarterly")
                interval = 3;
            else if (installmentMode == "Halfyearly")
                interval = 6;
            else if (installmentMode == "Anually")
                interval = 12;

            return interval;
        }

        public void updateDatabase(int newAMCTotal, int TotalNumberOfInstallments, int newRoundedInstallmentAmt)
        {
            int newInterval = FindInterval(comboBox1.Text);
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleTransaction tranObj;
                    tranObj = con.BeginTransaction();
                    OracleCommand _cmdObjj = con.CreateCommand();
                    try
                    {
                        _cmdObjj.CommandText = "update EQUIPMENTT_DETAILS set EQUIPMENT_NAME = '" + eqpName + "', SERIAL_NO = '" + eqpSerial + "', INSTALLATION_DATE = '" + eqpInstDate + "', LOCATION = '" + eqpLocation + "', TYPE = '" + eqpType + "', CAPASITY = '" + eqpCapacity + "', BRAND = '" + eqpBrand + "', AMC_UNIT_PRICE = " + eqpAMCCost + ", AMC_START_DATE = '" + eqpAMCStart + "', AMC_END_DATE = '" + eqpAMCEnd + "' where ID = " + eqpId + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT=" + newAMCTotal + ", DECIDED_INSTALLEMENT=" + newRoundedInstallmentAmt + ", INSTALLEMENT_INTERVAL=" + newInterval + ", NEXT_INSTALLEMENT_DATE='" + dateTimePicker1.Text + "', PREV_INST_ADJ_AMOUNT=0, TOTAL_NUMBER_INSTALLMENT=" + TotalNumberOfInstallments + ", NEXT_INSTALLMENT_AMOUNT=" + newRoundedInstallmentAmt + " where ORGANISATION_ID=" + orgId + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        tranObj.Commit();
                        MessageBox.Show("Database Updated");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
