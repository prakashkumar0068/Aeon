using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.Mime;


namespace AeonNew
{
    public partial class ClientDetails : Form
    {
        private string query;
        private OracleDataAdapter da;
        string headoffice, branchoffice, factoryoofice;

        private OracleCommandBuilder oracleCommandBuilder = null;
        List<string> orgname = new List<string>();
        private DataTable contactTable = null;
        private DataTable equipmentTable = null;
        DataTable paymenthistory_dt;
        DataSet complaint;
        updatecontact update;
        BindingSource bs = new BindingSource();
        List<string> mailid = new List<string>();
        public ClientDetails()
        {
            InitializeComponent();
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {
            update = new updatecontact(this);
            clientlist("select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc");
            delete();
            combobox();
        }

        public void clientlist(String query)
        {
            orgNameListbox.Items.Clear();
            orgname.Clear();
            OracleDataReader dr;
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
                        orgname.Add(dr["ORG_NAME"].ToString());
                        orgNameListbox.Items.Add(dr["ORG_NAME"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
            }
        }

        private void getData_Click(object sender, EventArgs e)
        {
            clientdetails(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            orgNameListbox.Items.Clear();

            foreach (string df in orgname)
            {
                if (df.StartsWith(textBox1.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    orgNameListbox.Items.Add(df);
                }
            }
        }

        private void orgNameListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clientdetails(orgNameListbox.SelectedItem.ToString());
            }
            catch
            {

            }
        }

        public void contactperson()
        {

            //tabControl1.Controls.Remove(tabPage4);
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                query = "select ID, NAME, DESIGNATION, RESIDENSE_NO, OFFICE_NO, MOBILE_NO, E_MAIL, FAX from CLIENT_CONTACT_PERSON_DETAILS where ORGANISATION_ID =" + id.Text +" order by ID asc";

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = contactTable;
                dataGridView1.DataSource = bindingSource;



                contactTable.Columns["RESIDENSE_NO"].ColumnName = "RESIDENTIAL NUMBER";
                contactTable.Columns["OFFICE_NO"].ColumnName = "OFFICE NUMBER";
                contactTable.Columns["MOBILE_NO"].ColumnName = "MOBILE NUMBER";
                contactTable.Columns["E_MAIL"].ColumnName = "E-MAIL ADDRESS";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 170;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 200;
                dataGridView1.Columns[7].Width = 150;

                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        public void equipmentdetails()
        {
            string queryGrid2 = "select ID, EQUIPMENT_NAME, TYPE, BRAND, CAPASITY, QUANTITY, INSTALLATION_DATE, AMC_START_DATE, AMC_END_DATE, AMC_UNIT_PRICE, GROUP_ID from EQUIPMENTT_DETAILS where ORGANISATION_ID =" + id.Text+" order by ID asc" ;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleDataAdapter oracleDataAdapter1 = new OracleDataAdapter(queryGrid2, con);
                OracleCommandBuilder oracleCommandBuilder1 = new OracleCommandBuilder(oracleDataAdapter1);
                equipmentTable = new DataTable();
                oracleDataAdapter1.Fill(equipmentTable);
                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = equipmentTable;
                dataGridView2.DataSource = bindingSource1;

                equipmentTable.Columns["EQUIPMENT_NAME"].ColumnName = "NAME";
                equipmentTable.Columns["INSTALLATION_DATE"].ColumnName = "INSTALLATION DATE";
                equipmentTable.Columns["AMC_UNIT_PRICE"].ColumnName = "UNIT PRICE";
                equipmentTable.Columns["AMC_START_DATE"].ColumnName = "AMC START DATE";
                equipmentTable.Columns["AMC_END_DATE"].ColumnName = "AMC END DATE";
                equipmentTable.Columns["CAPASITY"].ColumnName = "CAPACITY";


                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[7].DefaultCellStyle.ForeColor = Color.Green;
                dataGridView2.Columns[8].DefaultCellStyle.ForeColor = Color.Blue;

                dataGridView2.Columns[2].Width = 100;
                dataGridView2.Columns[3].Width = 105;
                dataGridView2.Columns[4].Width = 100;
                dataGridView2.Columns[5].Width = 100;
                dataGridView2.Columns[6].Width = 155;
                dataGridView2.Columns[7].Width = 155;
                dataGridView2.Columns[8].Width = 155;

                this.dataGridView2.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView2_CellFormatting);

            }
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                int currentyear = DateTime.Today.Year;
                int currentmonth = DateTime.Today.Month;

                if (e.RowIndex > -1 && e.ColumnIndex == this.dataGridView2.Columns["AMC END DATE"].Index)
                {
                    if (e.Value != null)
                    {
                        DateTime RepVisits = Convert.ToDateTime(e.Value);

                        if (RepVisits.CompareTo(today) <= -1)
                        {
                            this.dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                            this.dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                        }



                        else if (RepVisits.Year == currentyear && RepVisits.Month == currentmonth)
                        {
                            this.dataGridView2.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Purple;
                            this.dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                        }

                    }
                }
            }
            catch (Exception es)
            {

            }
        }



        public void payment()
        {
            using (OracleConnection con1 = ConnectionManager.getDatabaseConnection())
            {
                query = "select * from PAYMENT_DETAILS where ORGANISATION_ID =" + id.Text + " order by BILL_NO ";
                da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand(query, con1);
                paymenthistory_dt = new DataTable();
                da.Fill(paymenthistory_dt);
                paymenthistory.DataSource = paymenthistory_dt;

                paymenthistory_dt.Columns[1].ColumnName = "BILL No.";
                paymenthistory_dt.Columns[2].ColumnName = "BILL DATE";
                paymenthistory_dt.Columns[3].ColumnName = "AMOUNT RECEIVED";
                paymenthistory_dt.Columns[4].ColumnName = "MODE";
                try
                {
                    paymenthistory.Columns[0].Visible = false;

                }
                catch (Exception rd)
                {

                }
                paymenthistory.Columns[2].Width = 150;
                paymenthistory.Columns[3].Width = 200;
                paymenthistory.Columns[4].Width = 100;

                this.paymenthistory.Columns["AMOUNT RECEIVED"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                this.paymenthistory.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.paymenthistory.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        public void complaintdetails()
        {

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleDataAdapter da = new OracleDataAdapter();
                complaint = new DataSet();
                da.SelectCommand = new OracleCommand();
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "select  c.DATE_OF_COMPLAINT, c.TIME_OF_COMPLAINT, c.PERSON_LOG_COMPLAINT, c.EQUIP_NAME, c.MACHINE_UNDER, c.ENGINEER_SCHEDULED, c.STATUS,d.CLOSING_DATE ,d.FAULT_REPORTED, d.ACTION_TAKEN FROM COMPLAINT_TABLE c Left JOIN COMPLAINTCLOSINGDETAILS d on c.COMPLAINT_ID=d.COMPLAINT_ID  Where c.ORGANISATION_ID='" + id.Text + "'";
                da.SelectCommand.Connection = con;
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(complaint, "t1");

                bs.DataSource = complaint.Tables["t1"];
                dataGridView3.DataSource = bs;
                this.dataGridView3.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                dataGridView3.Columns[0].HeaderText = "DATE OF COMPLAINT";
                dataGridView3.Columns[1].HeaderText = "TIME OF COMPLAINT";
                dataGridView3.Columns[2].HeaderText = "PERSON LOGED COMPLAINT";
                dataGridView3.Columns[3].HeaderText = "EQUIPMENT NAME";
                dataGridView3.Columns[4].HeaderText = "MACHINE UNDER";
                dataGridView3.Columns[5].HeaderText = "ENGINEER SCHEDULED";
                dataGridView3.Columns[6].HeaderText = "STATUS";
                dataGridView3.Columns[7].HeaderText = "CLOSING DATE";
                dataGridView3.Columns[8].HeaderText = "FAULT REPORTED";
                dataGridView3.Columns[9].HeaderText = "ACTION TAKEN";
                // dataGridView3.Columns[7].HeaderText = "STATUS";
            }
        }


        public string FindPaymentMode(int installmentMode)
        {
            string paymentMode = "";

            if (installmentMode == 1)
                paymentMode = "Monthly";
            else if (installmentMode == 3)
                paymentMode = "Quarterly";
            else if (installmentMode == 6)
                paymentMode = "Halfyearly";
            else if (installmentMode == 12)
                paymentMode = "Anually";

            return paymentMode;
        }

        public void clientdetails(String clinetName)
        {
            OracleDataReader dr;
            foreach (string df in orgname)
            {
                if (df.Equals(textBox1.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    clinetName = df;
                }
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENT_DETAILS where ORG_NAME='" + clinetName + "' ";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        id.Text = dr["ORGANISATION_ID"].ToString();
                        // UpdateBasic.id = id.Text;
                        clientNamelable.Text = clinetName;
                        websiteLabel.Text = dr["ORG_WEBSITE"].ToString();
                        headoffice = dr["ADDRESS"].ToString();
                        factoryoofice = dr["FACTORY_ADDRESS"].ToString();
                        branchoffice = dr["BRANCH_ADDRESS"].ToString();
                        addressLabel.Text = dr["ADDRESS"].ToString();
                        categoryLabel.Text = dr["CODE"].ToString();
                        pin.Text = dr["PIN"].ToString();
                    }

                }


                dr.Close();
                // a.paymentmanage(Convert.ToInt32(id.Text));
                contactperson();
                equipmentdetails();
                payment();
                complaintdetails();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBasic updateit = new UpdateBasic(this);
            UpdateBasic.clinetName = clientNamelable.Text;
            updateit.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                if (e.RowIndex < contactTable.Rows.Count)
                {
                    updatecontact.contactid = Convert.ToInt16(contactTable.Rows[e.RowIndex].ItemArray[0].ToString());
                    updatecontact.orgid = -1;
                }

                else
                {
                    updatecontact.orgid = Convert.ToInt16(id.Text);
                    updatecontact.contactid = -1;
                }

                if (updatecontact.flag == 1)
                {
                    update.Close();
                }
                updatecontact.flag = 1;
                update = new updatecontact(this);
                update.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            old_LogComplaint log = new old_LogComplaint(this);
            old_LogComplaint.orgname = clientNamelable.Text;
            old_LogComplaint.orgid = Convert.ToInt32(id.Text);
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeEngineer change = new ChangeEngineer();
            ChangeEngineer.orgname = clientNamelable.Text;
            ChangeEngineer.id = Convert.ToInt32(id.Text);
            change.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseComplaint closecomplaint = new CloseComplaint();
            CloseComplaint.orgname = clientNamelable.Text;
            CloseComplaint.id = Convert.ToInt32(id.Text);
            closecomplaint.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searching_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.SelectedIndex = -1;
                comboBox2.Items.Clear();
                if (searching.SelectedItem.ToString().Equals("Category"))
                {
                    comboBox2.Visible = true;
                    comboBox2.Items.Add("A");
                    comboBox2.Items.Add("B");
                    comboBox2.Items.Add("C");
                    comboBox2.Items.Add("X");
                }
                else if (searching.SelectedItem.ToString().Equals("Client Type"))
                {
                    comboBox2.Visible = true;
                    comboBox2.Items.Add("MASTER");
                    comboBox2.Items.Add("AMC");
                }
                else if (searching.SelectedItem.ToString().Equals("Segment"))
                {
                    segmentdetails("Select Distinct SEGMENT from CLIENT_DETAILS");
                }
                else if (searching.SelectedItem.ToString().Equals("State"))
                {
                    segmentdetails("Select Distinct STATE from CLIENT_DETAILS");
                }
                else if (searching.SelectedItem.ToString().Equals("City"))
                {
                    segmentdetails("Select Distinct CITY from CLIENT_DETAILS");
                }
                else if (searching.SelectedItem.ToString().Equals("Pin"))
                {
                   // comboBox2.Visible = false;
                    segmentdetails("Select Distinct Pin from CLIENT_DETAILS");
                }
                else if (searching.SelectedItem.ToString().Equals("All"))
                {
                    comboBox2.Visible = false;
                    clientlist("select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("asd" + ex.Message);
            }
        }

        private void segmentdetails(string qureylist)
        {
            comboBox2.Visible = true;
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qureylist;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        comboBox2.Items.Add(dr[0].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
            }
            // clientlist("select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (searching.SelectedItem.ToString().Equals("Category"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where CODE='" + comboBox2.SelectedItem.ToString() + "'");
                }
                else if (searching.SelectedItem.ToString().Equals("Client Type"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where CLIENT_OF='" + comboBox2.SelectedItem.ToString() + "'");
                }
                else if (searching.SelectedItem.ToString().Equals("Segment"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where Segment='" + comboBox2.SelectedItem.ToString() + "'");
                }
                else if (searching.SelectedItem.ToString().Equals("State"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where STATE='" + comboBox2.SelectedItem.ToString() + "'");
                }
                else if (searching.SelectedItem.ToString().Equals("City"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where CITY='" + comboBox2.SelectedItem.ToString() + "'");
                }
                else if (searching.SelectedItem.ToString().Equals("Pin"))
                {
                    clientlist("select ORG_NAME from CLIENT_DETAILS  where Pin='" + comboBox2.SelectedItem.ToString() + "'");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void AddressCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddressCombobox.SelectedItem.ToString().Equals("Head Office"))
            {
                addressLabel.Text = headoffice;

            }

            else if (AddressCombobox.SelectedItem.ToString().Equals("Branch Office"))
            {
                addressLabel.Text = branchoffice;
            }
            else
            {
                addressLabel.Text = factoryoofice;
            }

        }

        /* private void button2_Click(object sender, EventArgs e)
         {
            
             else if (Convert.ToInt32(numberInstDeclabel.Text) == Convert.ToInt32(installmentsPaid.Text))
             {
                 DialogResult dialogResult = MessageBox.Show("Number of Installments decided has already reached to its maximum limit, do you want to increase it?", "Confirm", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                     AlterInstallmentPatern.totalAMCCost = Convert.ToInt32(totalAMCCostLable.Text);
                     AlterInstallmentPatern.totalPaid = Convert.ToInt32(amtpaidtillLabel.Text);
                     AlterInstallmentPatern.altTotalNoInst = Convert.ToInt32(numberInstDeclabel.Text);
                     AlterInstallmentPatern.orgId = Convert.ToInt32(id.Text);

                     AlterInstallmentPatern.executionLineFlag = 3;

                     AlterInstallmentPatern altInsPat = new AlterInstallmentPatern();
                     altInsPat.Show();
                 }
                 else if (dialogResult == DialogResult.No)
                 { 
                    
                 }
             }
             else
             {
                 PaymentForm.installmentDecided = Convert.ToInt32(numberInstDeclabel.Text);
                 PaymentForm payment = new PaymentForm(this);
                 payment.Show();
             }
         }*/

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void paymenthistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Bill_Details billdetails = new Bill_Details();
                if (e.RowIndex < paymenthistory_dt.Rows.Count)
                {
                    Bill_Details.bill_no = Convert.ToInt32(paymenthistory_dt.Rows[e.RowIndex].ItemArray[1].ToString());
                    billdetails.Show();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DSR_Brief dSR_Brief = new DSR_Brief();
            dSR_Brief.Show();
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
                //MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this client?", "Confirm", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    OracleTransaction tranObj;
                    tranObj = con.BeginTransaction();
                    OracleCommand _cmdObjj = con.CreateCommand();
                    try
                    {
                        _cmdObjj.CommandText = "DELETE FROM CHEQUT_DD_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM PAYMENT_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM EQP_SERIAL_LOCATION WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM CLIENT_INSTALLEMENTS_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM EQUIPMENTT_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM COMPLAINTCLOSINGDETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM COMPLAINT_TABLE WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM CLIENT_CONTACT_PERSON_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        _cmdObjj.CommandText = "DELETE FROM CLIENT_DETAILS WHERE ORGANISATION_ID = " + id.Text + "";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();

                        tranObj.Commit();
                        MessageBox.Show("Client Deleted");

                    }
                    catch (Exception ex)
                    {
                        tranObj.Rollback();
                        MessageBox.Show("Something gone wrong");
                    }
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            clientlist("select ORG_NAME from CLIENT_DETAILS  Where ORGANISATION_ID=" + orginationidtextbox.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Clients`.xlsx";
            saveFileDialog1.Filter = "Excel 2007 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;

            //  If the user hit Cancel, then abort!
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string targetFilename = saveFileDialog1.FileName;


            //  Step 1: Create a DataSet, and put some sample data in it
            DataSet ds = sampledata();

            //  Step 2: Create the Excel file
            try
            {
              //  CreateExcelFile.CreateExcelDocument(ds, targetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            }

            //  Step 3:  Let's open our new Excel file and shut down this application.
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(targetFilename);
            p.Start();

            this.Close();
        }

        private DataSet sampledata()
        {
            DataSet ds = new DataSet();

            DataTable dt1 = new DataTable("Clients");
            dt1.Columns.Add("Organization ID");
            dt1.Columns.Add("Organization Name ");
            dt1.Columns.Add("Website");
            dt1.Columns.Add("Category");
            dt1.Columns.Add("Office ADDRESS");
            dt1.Columns.Add("Branch ADDRESS");
            dt1.Columns.Add("Factory ADDRESS");
            dt1.Columns.Add("Client Type");
            dt1.Columns.Add("Segment");
            dt1.Columns.Add("Date Of Joining");
            dt1.Columns.Add("STATE");
            dt1.Columns.Add("CITY");


            DataTable contactperson = new DataTable("Contact Number");
         
            contactperson.Columns.Add("Organization Name ");
            contactperson.Columns.Add("NAME");
            contactperson.Columns.Add("RESIDENSE NO");
            contactperson.Columns.Add("OFFICE NO");
            contactperson.Columns.Add("MOBILE NO");
            contactperson.Columns.Add("E MAIL");
            contactperson.Columns.Add("DESIGNATION");
            contactperson.Columns.Add("FAX");



             DataTable devicedetails = new DataTable("EQUIPMENTT DETAILS");
         
            devicedetails.Columns.Add("Organization Name ");
            devicedetails.Columns.Add("EQUIPMENT NAME");
            devicedetails.Columns.Add("INSTALLATION DATE");
            devicedetails.Columns.Add("TYPE");
            devicedetails.Columns.Add("CAPACITY");
            devicedetails.Columns.Add("BRAND");
            devicedetails.Columns.Add("AMC UNIT PRICE");
            devicedetails.Columns.Add("AMC START DATE");
            devicedetails.Columns.Add("AMC END DATE");
            devicedetails.Columns.Add("ID");
            devicedetails.Columns.Add("UNDER");
            devicedetails.Columns.Add("QUANTITY");
            devicedetails.Columns.Add("GROUP ID");


            DataTable INSTALLEMENTS = new DataTable("INSTALLEMENTS DETAILS");

            INSTALLEMENTS.Columns.Add("Organization Name ");
            INSTALLEMENTS.Columns.Add("BILL NO");
            INSTALLEMENTS.Columns.Add("BILL DATE");
            INSTALLEMENTS.Columns.Add("AMOUNT RECEIVED");
            INSTALLEMENTS.Columns.Add("AMOUNT RECVIEVE IN");
            INSTALLEMENTS.Columns.Add("DECIDED INSTALLMENT");
            INSTALLEMENTS.Columns.Add("GROUP ID");


            DataTable Check_details = new DataTable("CHEQUE");
            Check_details.Columns.Add("Organization Name ");
            Check_details.Columns.Add("CHEQUE NO");
            Check_details.Columns.Add("CHEQUE DATE");
            Check_details.Columns.Add("CHEQUE AMTOUNT");
            Check_details.Columns.Add("BANK");

            DataTable complaint_details = new DataTable("COMPLAINT");
            complaint_details.Columns.Add("Organization Name ");
            complaint_details.Columns.Add("COMPLAINT ID");
            complaint_details.Columns.Add("DATE OF COMPLAINT");
            complaint_details.Columns.Add("TIME OF COMPLAINT");
            complaint_details.Columns.Add("PERSON LOG COMPLAINT");
            complaint_details.Columns.Add("EQUIP NAME");
            complaint_details.Columns.Add("BRAND");
            complaint_details.Columns.Add("MODEL");
            complaint_details.Columns.Add("MACHINE UNDER");
            complaint_details.Columns.Add("ENGINEER SCHEDULED");
            complaint_details.Columns.Add("STATUS");
            complaint_details.Columns.Add("NATURE OF COMPLAINT");
         

            for (int i = 0; i < orgNameListbox.Items.Count; i++)
            {
                OracleDataReader dr,contactpersonread,devicedetailsread,paymentdetailsread,chexkdetails,complaintdetails;
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from CLIENT_DETAILS Where ORG_NAME='"+orgNameListbox.Items[i].ToString()+"'";
                    dr = cmd.ExecuteReader();
                   
                    
                        if (dr.Read())
                        {
                            dt1.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString() });
                            cmd.CommandText = "Select * from CLIENT_CONTACT_PERSON_DETAILS Where ORGANISATION_ID=" + dr[0].ToString();
                            contactpersonread = cmd.ExecuteReader();

                            while (contactpersonread.Read())
                            {
                                contactperson.Rows.Add(new object[] { dr[1].ToString(), contactpersonread[1].ToString(), contactpersonread[2].ToString(), contactpersonread[3].ToString(), contactpersonread[4].ToString(), contactpersonread[5].ToString(), contactpersonread[6].ToString() });
                            }

                            contactpersonread.Close();

                             cmd.CommandText = "Select * from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + dr[0].ToString();
                             devicedetailsread = cmd.ExecuteReader();
                             while (devicedetailsread.Read())
                             {
                                 devicedetails.Rows.Add(new object[] { dr[1].ToString(), devicedetailsread[1].ToString(), devicedetailsread[2].ToString(), devicedetailsread[3].ToString(), devicedetailsread[4].ToString(), devicedetailsread[5].ToString(), devicedetailsread[6].ToString(), devicedetailsread[7].ToString(), devicedetailsread[8].ToString(), devicedetailsread[9].ToString(), devicedetailsread[10].ToString(), devicedetailsread[11].ToString(), devicedetailsread[12].ToString() });
                             }
                             devicedetailsread.Close();

                             cmd.CommandText = "Select * from PAYMENT_DETAILS Where ORGANISATION_ID=" + dr[0].ToString();
                             paymentdetailsread = cmd.ExecuteReader();
                             while (paymentdetailsread.Read())
                             {
                                 INSTALLEMENTS.Rows.Add(new object[] { dr[1].ToString(), paymentdetailsread[1].ToString(), paymentdetailsread[2].ToString(), paymentdetailsread[3].ToString(), paymentdetailsread[4].ToString(), paymentdetailsread[5].ToString(), paymentdetailsread[7].ToString() });
                             }
                             paymentdetailsread.Close();

                             cmd.CommandText = "Select * from CHEQUT_DD_DETAILS Where ORGANISATION_ID=" + dr[0].ToString();
                             chexkdetails = cmd.ExecuteReader();
                             while (chexkdetails.Read())
                             {
                                 Check_details.Rows.Add(new object[] { dr[1].ToString(), chexkdetails[1].ToString(), chexkdetails[2].ToString(), chexkdetails[3].ToString(), chexkdetails[4].ToString() });
                             }
                             chexkdetails.Close();

                           cmd.CommandText = "Select * from COMPLAINT_TABLE Where ORGANISATION_ID=" + dr[0].ToString();
                            complaintdetails = cmd.ExecuteReader();
                            while (complaintdetails.Read())
                            {
                                complaint_details.Rows.Add(new object[] { dr[1].ToString(), complaintdetails[1].ToString(), complaintdetails[2].ToString(), complaintdetails[3].ToString(), complaintdetails[4].ToString(), complaintdetails[5].ToString(), complaintdetails[6].ToString(), complaintdetails[7].ToString(), complaintdetails[8].ToString(), complaintdetails[9].ToString(), complaintdetails[10].ToString(), complaintdetails[11].ToString() });
                            }
                            complaintdetails.Close();
                        }
                    
                   
                    dr.Close();
                }
            }
            ds.Tables.Add(dt1);
            ds.Tables.Add(contactperson);
            ds.Tables.Add(devicedetails);
            ds.Tables.Add(INSTALLEMENTS);
            ds.Tables.Add(Check_details);
            ds.Tables.Add(complaint_details);
            return ds;
        }

        private DataSet CreateSampleData()
        {
            
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Clients details");
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {


                OracleDataAdapter dp = new OracleDataAdapter("select * from CLIENT_DETAILS", con);
                dp.Fill(dt);
                ds.Tables.Add(dt);
                dp = new OracleDataAdapter("select * from EQUIPMENTT_DETAILS", con);
                dt = new DataTable("Device Details");
                dp.Fill(dt);

                ds.Tables.Add(dt);

               
                dp = new OracleDataAdapter("select * from CLIENT_CONTACT_PERSON_DETAILS", con);
                dt = new DataTable("Contact Details");
                dp.Fill(dt);

                ds.Tables.Add(dt);

                dp = new OracleDataAdapter("select * from PAYMENT_DETAILS", con);
                dt = new DataTable("PAYMENT_DETAILS");
                dp.Fill(dt);

                ds.Tables.Add(dt);
            }
            return ds;
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < equipmentTable.Rows.Count)
            {
                AddNewMachine.equipmentid = Convert.ToInt16(equipmentTable.Rows[e.RowIndex].ItemArray[0].ToString());
                AddNewMachine.groupID = Convert.ToInt32(equipmentTable.Rows[e.RowIndex].ItemArray[10].ToString());
                AddNewMachine.orgid = Convert.ToInt32(id.Text);

                AddNewMachine add = new AddNewMachine(this);

                add.upAMCCosttextBox.Enabled = false;

                add.upEqpEndDatedateTimePicker.Enabled = false;
                add.upEqpInstDatedateTimePicker.Enabled = false;

                add.upEqpStartDatedateTimePicker.Enabled = false;

                add.upQuantitytextBox.Enabled = false;


                add.Show();
            }

            else
            {
                AddNewMachine.orgid = Convert.ToInt32(id.Text);
                AddNewMachine.equipmentid = -1;

                AddNewMachine add = new AddNewMachine(this);

                add.Show();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                clientdetails(orgNameListbox.SelectedItem.ToString());
            }
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            msg();
        }
        private void combobox()
        {

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT msgsubject FROM emailbody";
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr[0].ToString());

                    }


                }

                catch (Exception)
                {
                    MessageBox.Show("Exception");
                }

            }
        }
        private void msg()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM emailbody where msgsubject='" + comboBox1.Text + "' ";
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        richTextBox1.Text = dr["msgsubject"].ToString();
                        richTextBox2.Text = dr["Body"].ToString();


                    }


                }

                catch (Exception)
                {
                    MessageBox.Show("Exception");
                }

            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            OracleDataReader dr;


            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select E_MAIL from CLIENT_CONTACT_PERSON_DETAILS where ORGANISATION_ID =" + id.Text + " ";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    mailid.Add(dr[0].ToString());
                }

            }



            // mailid.Add("bajpai.anadi.bajpai@gmail.com");
            // mailid.Add("prakash_kumar0068@hotmail.com");
            foreach (string mail in mailid)
            {
                sendmail_to(mail);
            }
        }
        public void sendmail_to(string mailemailid)
        {
            string serverPort = "587";

            try
            {
                //first by initializing a new SmtpClient and pass the server ip/hostname to it
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Timeout = 20000;
                //then initialize a mail message
                MailMessage message = new MailMessage();

                //lets set the from field to the from text field
                message.From = new MailAddress("service@srdt.co.in");

                //and the to field
                message.To.Add(mailemailid);

                // the body
                message.IsBodyHtml = true;

                message.Subject = richTextBox1.Text;

                if (textBox2.TextLength > 0)
                {
                    Attachment attachment = new Attachment(textBox2.Text, MediaTypeNames.Application.Octet);

                    message.Attachments.Add(attachment);
                }

                string Body = richTextBox2.Text;
                message.Body = Body;


                // the subject
                // message.Subject = "test";

                //now we create a networkcredential and pass our username and password for the smtp server
                client.Credentials = new System.Net.NetworkCredential("service@srdt.co.in", "gold@1234");
                // client.UseDefaultCredentials = false;
                //client.Credentials = new System.Net.NetworkCredential("bindash.killer@gmail.com", "eqfqq40h");
                //many smtp require ssl so we will enable it
                client.EnableSsl = true;

                //we will set the port
                if (serverPort != null)
                    client.Port = System.Convert.ToInt32(serverPort);

                // and finally, send the message
                client.Send(message);
                MessageBox.Show("Mail Send to :");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot send Mail.Try Again " + ex.Message + "");
            }
        }
    }
}