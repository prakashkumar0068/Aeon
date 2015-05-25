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
    public partial class DSR_MakeEntry : Form
    {
        int entryId = 0;
        AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection contactcollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection phonecollection = new AutoCompleteStringCollection();
        System.Windows.Controls.TextBox RemarktextBox = new System.Windows.Controls.TextBox();
        public DSR_MakeEntry()
        {
            
            InitializeComponent();
            RemarktextBox.SpellCheck.IsEnabled = true;
            elementHost.Child = (RemarktextBox);
            
        }
        
        private void DSR_MakeEntry_Load(object sender, EventArgs e)
        {
            using (OracleConnection con1 = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = con1;
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select NAME from USERLOGIN where DESIGNATION ='Sales Person' ";
                OracleDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows == true)
                {
                    while (dr1.Read())
                        textBoxMRPersonName.Items.Add(dr1[0].ToString());
                }

                dr1.Close();


                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
                toolTip1.AutoPopDelay = 10000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                        nameCollection.Add(dr["ORG_NAME"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();

            }
            partyname.AutoCompleteMode = AutoCompleteMode.Suggest;
            partyname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            partyname.AutoCompleteCustomSource = nameCollection;

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(ENTRY_ID) from DSR";
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        entryId = Int32.Parse((dr[0].ToString()));
                    }
                    catch (Exception es)
                    {
                        entryId = 0;
                    }

                }
            }
            entryId++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxPaymentCollectedAME.Text) != 0 || Convert.ToInt32(textBoxPaymentCollectedAE.Text) != 0)
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    try
                    {
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandText = "insert into DSR values (" + entryId + ",'" + textBoxMRPersonName.Text + "','" + partyname.Text + "','" + ContactPersontextBox.Text + "','" + PhoneNumbertextBox.Text + "',to_date('" + DateOfVisit.Value.Day.ToString() + "/" + DateOfVisit.Value.Month.ToString() + "/" + DateOfVisit.Value.Year.ToString() + "','DD/MM/YYYY'),to_date('" + NextCallDate.Value.Day.ToString() + "/" + NextCallDate.Value.Month.ToString() + "/" + NextCallDate.Value.Year.ToString() + "','DD/MM/YYYY')," + Convert.ToInt32(textBoxOrderBookedAME.Text) + "," + Convert.ToInt32( textBoxPaymentCollectedAME.Text) + "," +Convert.ToInt32( textBoxOrderBookedAE.Text )+ ","+Convert.ToInt32(textBoxPaymentCollectedAE.Text)+ ",'" + RemarktextBox.Text + "','Not Done')";
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data is inserted!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error");
                    }
                }
            }
            else
            {
                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {
                    try
                    {
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandText = "insert into DSR values (" + entryId + ",'" + textBoxMRPersonName.Text + "','" + partyname.Text + "','" + ContactPersontextBox.Text + "','" + PhoneNumbertextBox.Text + "',to_date('" + DateOfVisit.Value.Day.ToString() + "/" + DateOfVisit.Value.Month.ToString() + "/" + DateOfVisit.Value.Year.ToString() + "','DD/MM/YYYY'),to_date('" + NextCallDate.Value.Day.ToString() + "/" + NextCallDate.Value.Month.ToString() + "/" + NextCallDate.Value.Year.ToString() + "','DD/MM/YYYY')," + Convert.ToInt32(textBoxOrderBookedAME.Text) + "," + Convert.ToInt32(textBoxPaymentCollectedAME.Text) + "," + Convert.ToInt32(textBoxOrderBookedAE.Text) + "," + Convert.ToInt32(textBoxPaymentCollectedAE.Text) + ",'" + RemarktextBox.Text + "','Done')";
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data is inserted!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error");
                    }

                }
            }
        }

        private void ContactPersontextBox_Leave(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "select CLIENT_CONTACT_PERSON_DETAILS.MOBILE_NO from CLIENT_CONTACT_PERSON_DETAILS INNER JOIN CLIENT_DETAILS ON CLIENT_CONTACT_PERSON_DETAILS.ORGANISATION_ID=CLIENT_DETAILS.ORGANISATION_ID where ORG_NAME='" + partyname.Text.ToString() + "' ";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //  MessageBox.Show("Data is inserted!");

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                        phonecollection.Add(dr[0].ToString());
                }
                else
                {
                    //MessageBox.Show("Data not found.");
                }

                dr.Close();
              
            }
            PhoneNumbertextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            PhoneNumbertextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            PhoneNumbertextBox.AutoCompleteCustomSource = phonecollection;

        }

        private void partyname_Leave(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "select CLIENT_CONTACT_PERSON_DETAILS.NAME from CLIENT_CONTACT_PERSON_DETAILS INNER JOIN CLIENT_DETAILS ON CLIENT_CONTACT_PERSON_DETAILS.ORGANISATION_ID=CLIENT_DETAILS.ORGANISATION_ID where ORG_NAME='" + partyname.Text.ToString() + "' ";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //  MessageBox.Show("Data is inserted!");

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                        contactcollection.Add(dr[0].ToString());
                }
                else
                {
                    //MessageBox.Show("Data not found.");
                }

                dr.Close();
              
            }
            ContactPersontextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ContactPersontextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ContactPersontextBox.AutoCompleteCustomSource = contactcollection;
        }

        private void PartyNameComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("You can't enter client's name manually.\nYou must select it from list.");
        }

        private void textBoxMRPersonName_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("You can't enter client's name manually.\nYou must select it from list.");
        }

     
    }
}
