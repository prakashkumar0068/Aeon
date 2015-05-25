using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AeonNew
{
    public partial class ClientEntry : Form
    {
        int personid = 0;
        int orgid = 0;
        int equipmentid = 0;
        int installmentsPaid = 0;
        int groupid = 0;
        int flag1 = 0;
        int flag2 = 0;
        int orgnameunigue = -1;
        List<string> organizationname = new List<string>();

        public ClientEntry()
        {
            InitializeComponent();
           
            //this.cost.KeyPress += new KeyPressEventHandler(amountReceivedTextBox_KeyPress);
            //this.QuantityTextBox.KeyPress += new KeyPressEventHandler(amountReceivedTextBox_KeyPress);
        }
        private void amountReceivedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }

        private void ClientEntry_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GetClientname();
            delete();
            GetID();
            getsegment();
            orgidLabel.Text = orgid.ToString();
        }

        private void getsegment()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Distinct (SEGMENT) from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        segmenttextbox.Items.Add(dr[0].ToString());
                    }
                    catch (Exception )
                    {

                    }
                }
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Distinct (pin) from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        pin.Items.Add(dr[0].ToString());
                    }
                    catch (Exception es)
                    {

                    }
                }
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Distinct (STATE) from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        statetextbox.Items.Add(dr[0].ToString());
                    }
                    catch (Exception es)
                    {

                    }
                }
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Distinct (CITY) from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        citytextbox.Items.Add(dr[0].ToString());
                    }
                    catch (Exception es)
                    {

                    }
                }
            }

        }
        public void GetClientname()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ORG_NAME from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        organizationname.Add(dr["ORG_NAME"].ToString());
                    }
                    catch (Exception es)
                    {

                    }
                }
            }
        }
        public void delete()
        {
            try
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    OracleCommand _cmdObjj = con.CreateCommand();

                   // OracleCommand _cmdObjj = new OracleCommand();
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.CommandText = "delete from TEMP_CONTACT_PERSON_DETAILS";
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();


                    _cmdObjj.CommandText = "delete from TEMP_EQUIPMENTT_DETAILS";
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();

                    _cmdObjj.CommandText = "delete from TEMP_INSTALLEMENTS_DETAILS";
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void GetID()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(ID) from CLIENT_CONTACT_PERSON_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        personid = Int32.Parse((dr["max(ID)"].ToString()));
                    }
                    catch (Exception es)
                    {

                    }
                }
            }
            personid++;

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(ORGANISATION_ID) from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                       orgid = Int32.Parse((dr["max(ORGANISATION_ID)"].ToString()));
                    }
                    catch (Exception es)
                    {

                    }

                }
            }
            orgid++;

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
                        equipmentid = Int32.Parse((dr["max(ID)"].ToString()));
                    }
                    catch (Exception es)
                    {

                    }
                }
            }
            equipmentid++;

            //using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            //{
            //    OracleCommand cmd = new OracleCommand();
            //    cmd.Connection = con;
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "select max(GROUP_ID) from TEMP_EQUIPMENTT_DETAILS";
            //    OracleDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        try
            //        {
            //            groupid = Int32.Parse((dr["max(GROUP_ID)"].ToString()));
            //        }
            //        catch (Exception es)
            //        {

            //        }
            //    }
            //}
            //groupid++;
         }


        private void button5_Click(object sender, EventArgs e)
        {
            flag1 = 0;
            if (NameText.Text == "" || NameText.Text.Trim() == "")
            {
                MessageBox.Show("Name Field is Empty");
                return;
            }
            DialogResult result;
            string message = "Do you want add more Records?";
            result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into TEMP_CONTACT_PERSON_DETAILS(ORGANISATION_ID, NAME, RESIDENSE_NO, OFFICE_NO, MOBILE_NO, E_MAIL, DESIGNATION, FAX, ID) VALUES(" + orgid + ", '" + NameText.Text + "', '" + ResidenceText.Text + "', '" +OfficeText.Text + "', '" + mobileText.Text + "', '" + emailText.Text + "', '" + desginationText.Text + "', '" + faxText.Text + "', " + personid + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    flag1 = 1;
                    ContactsAddedlist.Items.Add(NameText.Text);
                    personid++;
                    NameText.Clear();
                    ResidenceText.Clear();
                    mobileText.Clear();
                    faxText.Clear();
                    emailText.Clear();
                    desginationText.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
            if (result == DialogResult.No)
            {
                button5.Enabled = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //flag2 = 0;
            //if (equipmentCombox.Text == "---select----")
            //{
            //    string message = "You must select the equipment name.";
            //    MessageBox.Show(message);
            //    return;
            //}

            //else if (equipmenttypeCombo.Text == "---select-----" && equipmentCombox.SelectedItem.ToString() == "UPS")
            //{
            //    string message = "You must select type of machine.";
            //    MessageBox.Show(message);
            //    return;
            //}

            //else if (capacity.Text == "" || capacity.Text.Trim() == "")
            //{
            //    string message = "You can't leave capacity field of the machine blank.";

            //    MessageBox.Show(message);
            //    return;
            //}
            //else if (brand.Text == "" || brand.Text.Trim() == "")
            //{
            //    string message = "You can't leave brand field of the machine blank.";

            //    MessageBox.Show(message);
            //    return;
            //}
            //else if (cost.Text == "" || cost.Text.Trim() == "")
            //{
            //    string message = "You must give AMC value of the machine.";
            //    MessageBox.Show(message);
            //    return;
            //}
            //else if (QuantityTextBox.Text == "" || cost.Text.Trim() == "")
            //{
            //    string message = "You must fill number of equipments in Quantity field.";
            //    MessageBox.Show(message);
            //    return;
            //}

            //DialogResult result;
            //string message1 = "Do you want to add more records of machine?";
            //result = MessageBox.Show(message1, "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //try
            //{
            //  //  Installment_Entry._startDate = startdate.Text;
            //   // Installment_Entry._endDate = enddate.Text;
            // //   Installment_Entry._name = equipmentCombox.Text;
            // //   Installment_Entry._capacity = capacity.Text;
            //  //  Installment_Entry._number = Convert.ToInt32(QuantityTextBox.Text);
            //  //  Installment_Entry._unitPrice = Convert.ToInt32(cost.Text);
            //   // Installment_Entry._orgId = Convert.ToInt32(orgidLabel.Text);
            //  //  Installment_Entry._groupId = groupid;
            //}
            //catch
            //{
            //    MessageBox.Show("Error occur");
            //    this.Close();
            //}

            //Installment_Entry installment_Entry = new Installment_Entry();
            //installment_Entry.ShowDialog();

            //if (installment_Entry.exeFlag == 1)
            //{

            //    using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            //    {
            //     //   OracleCommand cmd = con.CreateCommand();
            //     //   if (equipmentCombox.SelectedItem.ToString() != "UPS")
            //     //       cmd.CommandText = "insert into TEMP_EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, INSTALLATION_DATE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER, QUANTITY, GROUP_ID) VALUES (" + orgid + ", '" + equipmentCombox.SelectedItem.ToString() + "', '" + install.Text + "', '" + capacity.Text + "', '" + brand.Text + "', " + cost.Text + ", '" + startdate.Text + "', '" + enddate.Text + "', " + equipmentid + ", '" + UnderComboBox.Text + "', " + QuantityTextBox.Text + ", " + groupid + ")";
            //     //   else
            //     //       cmd.CommandText = "insert into TEMP_EQUIPMENTT_DETAILS(ORGANISATION_ID, EQUIPMENT_NAME, INSTALLATION_DATE, TYPE, CAPASITY, BRAND, AMC_UNIT_PRICE, AMC_START_DATE, AMC_END_DATE, ID, UNDER, QUANTITY, GROUP_ID) VALUES (" + orgid + ", '" + equipmentCombox.SelectedItem.ToString() + "', '" + install.Text + "', '" + equipmenttypeCombo.Text + "', '" + capacity.Text + "', '" + brand.Text + "', " + cost.Text + ", '" + startdate.Text + "', '" + enddate.Text + "', " + equipmentid + ", '" + UnderComboBox.Text + "', " + QuantityTextBox.Text + ", " + groupid + ")";
            //     //   cmd.CommandType = CommandType.Text;
            //     //   cmd.ExecuteNonQuery();

            //     //   String query = "select GROUP_ID, EQUIPMENT_NAME, CAPASITY, AMC_START_DATE, AMC_END_DATE, QUANTITY, AMC_UNIT_PRICE from TEMP_EQUIPMENTT_DETAILS";
            //     //   OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
            //     //   OracleCommandBuilder oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
            //     //   DataTable dt = new DataTable();
            //     //   oracleDataAdapter.Fill(dt);
            //     //   BindingSource bindingSource = new BindingSource();
            //     //   bindingSource.DataSource = dt;
            //     ////   dataGridView1.DataSource = bindingSource;
            //     //   dt.Columns["GROUP_ID"].ColumnName = "GROUP";
            //     //   dt.Columns["EQUIPMENT_NAME"].ColumnName = "EQUIPMENT NAME";
            //     //   dt.Columns["AMC_START_DATE"].ColumnName = "AMC START DATE";
            //     //   dt.Columns["AMC_END_DATE"].ColumnName = "AMC END DATE";
            //     //   dt.Columns["QUANTITY"].ColumnName = "QUANTITY";
            //     //   dt.Columns["AMC_UNIT_PRICE"].ColumnName = "AMC UNIT PRICE";
            //     //   dt.Columns["CAPASITY"].ColumnName = "CAPACITY";
            //     // //  this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            //     // //  this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //     //   flag2 = 1;
            //     //   equipmentid++;
            //     //   groupid++;
            //    }
            //}

            ////if (result == DialogResult.No)
            ////{
            ////    button3.Enabled = false;
            ////    button1.Enabled = true;
            ////}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (orgnameunigue > -1)
            {
                MessageBox.Show("Client is already Present");
                return;
            }
            if (flag1 == 0 && flag2==0)
            {
                MessageBox.Show("Some Fileds are Empty ");
                return;
            }
            if (orgname.Text == "" || orgname.Text.Trim() == "")
            {
                MessageBox.Show("Organization is Empty ");
                return;
            }
            if (category.Text == "---select----" || category.Text == "")
            {
                MessageBox.Show("Category  Filed is Empty ");
                return;
            }
            if (Headoffice.Text == "" || Headoffice.Text.Trim() == "")
            {
                MessageBox.Show("Headoffice Address Filed is Empty ");
                return;
            }
            if (clientof.Text == "MASTER")
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
                            _cmdObjj.CommandText = "insert into CLIENT_DETAILS  values(" + orgid + ", '" + orgname.Text + "', '" + website.Text + "', '" + category.SelectedItem.ToString() + "', '" + Headoffice.Text + "', '" + branchoffice.Text + "', '" + factoryAddress.Text + "', '" + clientof.SelectedItem.ToString() + "','" + segmenttextbox.Text + "','" + todaydate.Text + "','" + statetextbox.Text + "','" + citytextbox.Text + "','" + pin.Text + "')";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "insert into CLIENT_CONTACT_PERSON_DETAILS select * from TEMP_CONTACT_PERSON_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "delete from TEMP_CONTACT_PERSON_DETAILS";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            tranObj.Commit();
                            MessageBox.Show("Data Inserted");
                            flag1 = 0;
                            flag2 = 0;
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
                    
                    }
                }
            }
            else if (clientof.Text == "AMC")
            {
                try
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
                                _cmdObjj.CommandText = "insert into CLIENT_DETAILS  values(" + orgid + ", '" + orgname.Text + "', '" + website.Text + "', '" + category.SelectedItem.ToString() + "', '" + Headoffice.Text + "', '" + branchoffice.Text + "', '" + factoryAddress.Text + "', '" + clientof.SelectedItem.ToString() + "','" + segmenttextbox.Text + "','" + todaydate.Text + "','" + statetextbox.Text + "','" + citytextbox.Text + "','"+pin.Text+"')";
                                _cmdObjj.CommandType = CommandType.Text;
                                _cmdObjj.Parameters.Clear();
                                _cmdObjj.ExecuteNonQuery();

                                _cmdObjj.CommandText = "insert into CLIENT_CONTACT_PERSON_DETAILS select * from TEMP_CONTACT_PERSON_DETAILS";
                                _cmdObjj.CommandType = CommandType.Text;
                                _cmdObjj.Parameters.Clear();
                                _cmdObjj.ExecuteNonQuery();

                                _cmdObjj.CommandText = "delete from TEMP_CONTACT_PERSON_DETAILS";
                                _cmdObjj.CommandType = CommandType.Text;
                                _cmdObjj.Parameters.Clear();
                                _cmdObjj.ExecuteNonQuery();

                                //if (clientof.SelectedItem.ToString() == "AMC")
                                //{
                                //    _cmdObjj.CommandText = "insert into EQUIPMENTT_DETAILS select * from TEMP_EQUIPMENTT_DETAILS";
                                //    _cmdObjj.CommandType = CommandType.Text;
                                //    _cmdObjj.Parameters.Clear();
                                //    _cmdObjj.ExecuteNonQuery();

                                //    _cmdObjj.CommandText = "delete from TEMP_EQUIPMENTT_DETAILS";
                                //    _cmdObjj.CommandType = CommandType.Text;
                                //    _cmdObjj.Parameters.Clear();
                                //    _cmdObjj.ExecuteNonQuery();


                                //    _cmdObjj.CommandText = "insert into CLIENT_INSTALLEMENTS_DETAILS select * from TEMP_INSTALLEMENTS_DETAILS";
                                //    _cmdObjj.CommandType = CommandType.Text;
                                //    _cmdObjj.Parameters.Clear();
                                //    _cmdObjj.ExecuteNonQuery();

                                //    _cmdObjj.CommandText = "delete from TEMP_INSTALLEMENTS_DETAILS";
                                //    _cmdObjj.CommandType = CommandType.Text;
                                //    _cmdObjj.Parameters.Clear();
                                //    _cmdObjj.ExecuteNonQuery();
                               // }

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
                            //MessageBox.Show(ex.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fields are missing.\n" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("You must select Customer type.");
            }
        }

        public double CalculateInstallment(double TotalAmount, double TotalAmountReceived, int NumberOfInstallment)
        {
            double amount = 0;
            int roundedAmt = 0;
            double remainingAmount = TotalAmount - TotalAmountReceived;
            amount = remainingAmount / NumberOfInstallment;
            roundedAmt = (int)Math.Truncate(amount);
            if(roundedAmt < amount)
            {
                amount = roundedAmt + 1;
            }
            return amount;
        }

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

        private void clientof_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabControl1.Enabled = true;
            //this.tabPage2.Enabled = true;
            //button1.Enabled = false;
            //if (clientof.SelectedItem.ToString() == "MASTER")
            //{
            //    this.tabPage2.Enabled = false;
            //    button1.Enabled = true;
            //}

        }

        private void website_TextChanged(object sender, EventArgs e)
        {
            int len = "http://www.".Length;
            if (website.TextLength < len)
            {
                MessageBox.Show("you can't  delete this");
                website.Text = "http://www.";
            }
          
        }

        private void orgname_TextChanged(object sender, EventArgs e)
        {
            orgnameunigue = organizationname.IndexOf(orgname.Text);

            if (orgnameunigue > -1)
            {
                MessageBox.Show("Client is already Present");
            }
        }

        private void orgname_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            //if (cost.Text.Length > 0 && QuantityTextBox.Text.Length > 0)
            //{
            //    Totalprice.Text = Convert.ToInt32(QuantityTextBox.Text) * Convert.ToInt32(cost.Text) + "";
            //}
            //else
            //{
            //    Totalprice.Text = "";
            //}
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (cost.Text.Length > 0 && QuantityTextBox.Text.Length > 0)
            //{
            //    Totalprice.Text = Convert.ToInt32(QuantityTextBox.Text) * Convert.ToInt32(cost.Text) + "";
            //}
            //else
            //{
            //    Totalprice.Text = "";
            //}
        }

    }
}
