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
    public partial class AddNewMachine : Form
    {
        public static int equipmentid = 0;
        public static int orgid = 0;

        public static int groupID = 0;

        ClientDetails objMain;
        Form _frm;

        public AddNewMachine(Form frm)
        {
            _frm = frm;
            InitializeComponent();
            this.upAMCCosttextBox.KeyPress += new KeyPressEventHandler(upAMCCosttextBox_KeyPress);
            this.upQuantitytextBox.KeyPress += new KeyPressEventHandler(upAMCCosttextBox_KeyPress);
        }
        private void upAMCCosttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void AddNewMachine_Load(object sender, EventArgs e)
        {
            objMain = (ClientDetails)_frm;
            
            if (equipmentid > 0)
            {
                paymentButton.Visible = true;
                updatebutton.Visible = true;
                deleteButton.Visible = true;
                getEquipmentDetails();
                getOrgAMCTotal();
            }
            else
            {
                saveButton.Visible = true;
                getID();
                generateGroupId();
                getOrgAMCTotal();
            }

        }

        public int  Validateit()
        {
            if (upEqpNamecomboBox.Text == "---select----" || upEqpNamecomboBox.Text.Trim() =="")
            {
                string message = "You must select the equipment name.";

                MessageBox.Show(message);
                return 0;
            }

            else if (upEqpTypecomboBox.Text == "---select-----" && upEqpTypecomboBox.SelectedItem.ToString() == "UPS")
            {
                string message = "You must select type of machine.";
                MessageBox.Show(message);
                return 0;
            }
            else if (upQuantitytextBox.Text == "" || upQuantitytextBox.Text.Trim() == "")
            {
                string message = "You can't leave quantity field of the machine blank.";

                MessageBox.Show(message);
                return 0;
            }
            else if (upEqpCapacitytextBox.Text == "" || upEqpCapacitytextBox.Text.Trim() == "")
            {
                string message = "You can't leave capacity field of the machine blank.";

                MessageBox.Show(message);
                return 0;
            }
            else if (upAMCCosttextBox.Text == "" || upAMCCosttextBox.Text.Trim() == "")
            {
                string message = "You must give AMC value of the machine.";
                MessageBox.Show(message);
                return 0;
            }
            else
            {
                return 1;
            }
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            int vali = Validateit();
            if (vali == 0)
            {
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                if (upEqpNamecomboBox.SelectedItem.ToString() != "UPS")
                    cmd.CommandText = "insert into TEMP_EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, INSTALLATION_DATE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER, QUANTITY, GROUP_ID) VALUES (" + orgid + ", '" + upEqpNamecomboBox.SelectedItem.ToString() + "', '" + upEqpInstDatedateTimePicker.Text + "', '" + upEqpCapacitytextBox.Text + "', '" + upEqpBrandtextBox.Text + "', " + upAMCCosttextBox.Text + ", '" + upEqpStartDatedateTimePicker.Text + "', '" + upEqpEndDatedateTimePicker.Text + "', " + equipmentid + ", '" + UnderComboBox.Text + "', " + upQuantitytextBox.Text + ", " + groupID + ")";
                else
                    cmd.CommandText = "insert into TEMP_EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, INSTALLATION_DATE, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER, QUANTITY, GROUP_ID) VALUES (" + orgid + ", '" + upEqpNamecomboBox.SelectedItem.ToString() + "', '" + upEqpInstDatedateTimePicker.Text + "', '" + upEqpTypecomboBox.Text + "', '" + upEqpCapacitytextBox.Text + "', '" + upEqpBrandtextBox.Text + "', " + upAMCCosttextBox.Text + ", '" + upEqpStartDatedateTimePicker.Text + "', '" + upEqpEndDatedateTimePicker.Text + "', " + equipmentid + ", '" + UnderComboBox.Text + "', " + upQuantitytextBox.Text + ", " + groupID + ")";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            Installment_Entry._startDate = upEqpStartDatedateTimePicker.Text;
            Installment_Entry._endDate = upEqpEndDatedateTimePicker.Text;
            Installment_Entry._name = upEqpNamecomboBox.Text;
            Installment_Entry._capacity = upEqpCapacitytextBox.Text;
            Installment_Entry._number = Convert.ToInt32(upQuantitytextBox.Text);
            Installment_Entry._unitPrice = Convert.ToInt32(upAMCCosttextBox.Text);
            Installment_Entry._orgId = orgid;
            Installment_Entry._groupId = groupID;

            Installment_Entry installment_Entry = new Installment_Entry();
            installment_Entry.ShowDialog();

            if (installment_Entry.exeFlag == 1)
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    try
                    {
                        OracleTransaction tranObj;
                        tranObj = con.BeginTransaction();
                        OracleCommand _cmdObjj = con.CreateCommand();
                        try
                        {
                            _cmdObjj.CommandText = "insert into EQUIPMENTT_DETAILS select * from TEMP_EQUIPMENTT_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from TEMP_EQUIPMENTT_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();


                            _cmdObjj.CommandText = "insert into CLIENT_INSTALLEMENTS_DETAILS select * from TEMP_INSTALLEMENTS_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from TEMP_INSTALLEMENTS_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "update CLIENT_DETAILS set  CLIENT_OF='AMC' where ORGANISATION_ID =" + orgid + " ";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            tranObj.Commit();
                            MessageBox.Show("Data Inserted");

                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Some Value are not in correct format");
                            MessageBox.Show("Rollback Initiated");
                            tranObj.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the details of this Eqipment.", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                    {
                        OracleTransaction tranObj;
                        tranObj = con.BeginTransaction();
                        OracleCommand _cmdObjj = con.CreateCommand();
                        try
                        {
                            _cmdObjj.CommandText = "delete from EQUIPMENTT_DETAILS where ID =" + equipmentid + "";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from TEMP_EQUIPMENTT_DETAILS where ID =" + equipmentid + "";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from CLIENT_INSTALLEMENTS_DETAILS where ORGANISATION_ID =" + orgid + " and GROUP_ID = "+ groupID +"";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from PAYMENT_DETAILS where ORGANISATION_ID =" + orgid + " and GROUP_ID = " + groupID + "";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from EQP_SERIAL_LOCATION where ORGANISATION_ID =" + orgid + " and GROUP_ID = " + groupID + "";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();


                          
                             
                            tranObj.Commit();
                            MessageBox.Show("Equipment details deleted.");

                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            tranObj.Rollback();
                        }
                    }
                }
        }

        public void getEquipmentDetails()
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from EQUIPMENTT_DETAILS where ID = " + equipmentid + "";
                dr = cmd.ExecuteReader();
               
                {
                    while (dr.Read())
                    {
                        upEqpNamecomboBox.Text = dr["EQUIPMENT_NAME"].ToString();
                        upEqpTypecomboBox.Text = dr["TYPE"].ToString();
                        upEqpCapacitytextBox.Text = dr["CAPASITY"].ToString();
                        upEqpBrandtextBox.Text = dr["BRAND"].ToString();
                        upQuantitytextBox.Text = dr["QUANTITY"].ToString();
                        upAMCCosttextBox.Text = dr["AMC_UNIT_PRICE"].ToString();
                        upEqpInstDatedateTimePicker.Text = dr["INSTALLATION_DATE"].ToString();
                        upEqpStartDatedateTimePicker.Text = dr["AMC_START_DATE"].ToString();
                        upEqpEndDatedateTimePicker.Text = dr["AMC_END_DATE"].ToString();
                        UnderComboBox.Text = dr["UNDER"].ToString();

                        //tempEqpAmtLabel.Text = dr["AMC_UNIT_PRICE"].ToString();
                        tempAMCEndDate.Text = dr["AMC_END_DATE"].ToString();
                    }
                }
                dr.Close();
            }
        }

        public void getOrgAMCTotal()
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select TOTAL_AMOUNT, TOTAL_AMOUNT_RECEIVED, TOTAL_NUMBER_INSTALLMENT, INSTALLMENTS_PAID from CLIENT_INSTALLEMENTS_DETAILS where ORGANISATION_ID = " + orgid + "";
                dr = cmd.ExecuteReader();
                
            }
        }

        private void AddNewMachine_FormClosed(object sender, FormClosedEventArgs e)
        {
            objMain.contactperson();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            PaymentForm.pay_orgid = orgid;
            PaymentForm.pay_groupid = groupID;

            PaymentForm paymentForm = new PaymentForm(this);
            paymentForm.ShowDialog();
        }

        public void generateGroupId()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(GROUP_ID) from  EQUIPMENTT_DETAILS where ORGANISATION_ID = "+ orgid +"";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    try
                    {
                        groupID = Int32.Parse((dr["max(GROUP_ID)"].ToString()));
                    }
                    catch (Exception es)
                    {
                       // MessageBox.Show(es.ToString());
                    }
                }
            }
            groupID++;
        }

        public void getID()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(ID) from  EQUIPMENTT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        MessageBox.Show(dr[0].ToString());
                        equipmentid = Int32.Parse((dr[0].ToString()));
                    }
                    catch (Exception es)
                    {
                        equipmentid=1;
                    }
                }
            }
            equipmentid++;
        }

        private void SpecificationButton_Click(object sender, EventArgs e)
        {
            AddSerial addserial = new AddSerial();
            AddSerial.groupid = groupID;
            AddSerial.orgid = orgid;
            addserial.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();

                _cmdObjj.CommandText = "update EQUIPMENTT_DETAILS set  EQUIPMENT_NAME='" + upEqpNamecomboBox.Text + "', TYPE='" + upEqpTypecomboBox.Text + "' , CAPASITY='" + upEqpCapacitytextBox.Text + "' , BRAND='" + upEqpBrandtextBox.Text + "', UNDER='" + UnderComboBox.SelectedItem.ToString() + "' where GROUP_ID=" + groupID + " and ID="+equipmentid+"";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                MessageBox.Show("updated");
            }
        }

        private void upAMCCosttextBox_TextChanged(object sender, EventArgs e)
        {
            if (upAMCCosttextBox.Text.Length > 0 && upQuantitytextBox.Text.Length > 0)
            {
                totalprice.Text = Convert.ToInt32(upQuantitytextBox.Text) * Convert.ToInt32(upAMCCosttextBox.Text) + "";
            }
            else
            {
                totalprice.Text = "";
            }
        }

        private void upQuantitytextBox_TextChanged(object sender, EventArgs e)
        {
            if (upAMCCosttextBox.Text.Length > 0 && upQuantitytextBox.Text.Length > 0)
            {
                totalprice.Text = Convert.ToInt32(upQuantitytextBox.Text) * Convert.ToInt32(upAMCCosttextBox.Text) + "";
            }
            else
            {
                totalprice.Text = "";
            }
        }
    }
}
