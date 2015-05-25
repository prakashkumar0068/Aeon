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
    public partial class updateEqpDialog : Form
    {
        public static int orgId = 0;
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

        public static int totalNoInstalments = 0;
        public static int instPaid = 0;

        int max = 0;

        public updateEqpDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterInstallmentPatern.orgId = orgId;
            AlterInstallmentPatern.eqpName = eqpName;
            AlterInstallmentPatern.eqpType = eqpType;
            AlterInstallmentPatern.eqpSerial = eqpSerial;
            AlterInstallmentPatern.eqpLocation = eqpLocation;
            AlterInstallmentPatern.eqpCapacity = eqpCapacity;
            AlterInstallmentPatern.eqpBrand = eqpBrand;
            AlterInstallmentPatern.eqpAMCCost = eqpAMCCost;

            AlterInstallmentPatern.eqpInstDate = eqpInstDate;
            AlterInstallmentPatern.eqpAMCStart = eqpAMCStart;
            AlterInstallmentPatern.eqpAMCEnd = eqpAMCEnd;

            AlterInstallmentPatern.totalAMCCost = totalAMCCost;
            AlterInstallmentPatern.totalPaid = totalPaid;

            AlterInstallmentPatern.altTotalNoInst = totalNoInstalments;
            AlterInstallmentPatern.altInstPaid = instPaid;

            AlterInstallmentPatern alterInstallmentPatern = new AlterInstallmentPatern();
            alterInstallmentPatern.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totalNoInstalments == instPaid)
            {
                MessageBox.Show("Total number of installments decided has already reached to is maximum limit. You will have to increase the number of installments to add this machine.");

            }
            else
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
                this.Close();
            }
        }

        public void calculateAndMakeEntry()
        {
            int amtRemaining = totalAMCCost - totalPaid;
            int instRemaining = totalNoInstalments - instPaid;
            amtRemaining = amtRemaining + eqpAMCCost;
            totalAMCCost = totalAMCCost + eqpAMCCost;

            double newInstallment = amtRemaining / instRemaining;
            int roundedAmount = (int)Math.Truncate(newInstallment);
            if (roundedAmount < newInstallment)
            {
                roundedAmount = roundedAmount + 1;
            }

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
            
                        _cmdObjj.CommandText = "update CLIENT_INSTALLEMENTS_DETAILS set TOTAL_AMOUNT=" + totalAMCCost + ", DECIDED_INSTALLEMENT=" + roundedAmount + ", PREV_INST_ADJ_AMOUNT=0, NEXT_INSTALLMENT_AMOUNT=" + roundedAmount + " where ORGANISATION_ID=" + orgId + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        tranObj.Commit();
                        MessageBox.Show("Data Inserted");
                    }
                    catch(Exception ex)
                    { 
                        MessageBox.Show("Rollback initiated.");
                        tranObj.Rollback();
                    }
                 }
                catch(Exception ex)
                {
                
                }
            }
        }

        private void updateEqpDialog_Load(object sender, EventArgs e)
        {
            label1.Text = eqpInstDate;
            label2.Text = eqpAMCStart;
        }



    }
}
