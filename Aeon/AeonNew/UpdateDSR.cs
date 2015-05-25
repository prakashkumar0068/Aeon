using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Forms.Integration;

namespace AeonNew
{
    public partial class UpdateDSR : Form
    {
       string id;
     int entry_id;
        System.Windows.Controls.TextBox RemarktextBox = new System.Windows.Controls.TextBox();
        public UpdateDSR(String id)
        {
            InitializeComponent();
            this.id = id;
            RemarktextBox.SpellCheck.IsEnabled = true;
            //elementHost1.Child = (RemarktextBox);
           
            InitializeComponent();
        }
        public UpdateDSR()
        {
            InitializeComponent();
            RemarktextBox.SpellCheck.IsEnabled = true;
            //elementHost1.Child = (RemarktextBox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string text = RemarktextBox.Text;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
              //  try
                {
                    OracleCommand _cmdObjj = con.CreateCommand();

                    _cmdObjj.CommandText = "update  DSR  set  PARTY_NAME='" + Partyname.Text + "',CONTACTED_PERSON='" + ContactPersontextBox.Text + "',PHONE_NUMBER='" + PhoneNumbertextBox.Text + "' , DATE_OF_VISIT='" + Datofvisit.Text + "' ,NEXT_CALL_DATE='" + NextCallDate.Text + "',  REMARK='" + text + "' where ENTRY_ID=" + id + "";
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();
                    MessageBox.Show("Updated!");
                    this.Close();
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Some error is occured!");
                //}
            }
        }

        private void UpdateDSR_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("select distinct(MARKETING_PERSON_NAME) from DSR", con);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxMRPersonName.Items.Add(dr[0].ToString());

                }
                con.Close();
            }
        }

        private void PhoneNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             string text = RemarktextBox.Text;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                //  try
                {
                    OracleCommand _cmdObjj = con.CreateCommand();

                    _cmdObjj.CommandText = "update  DSR  set  PARTY_NAME='" + Partyname.Text + "',CONTACTED_PERSON='" + ContactPersontextBox.Text + "',PHONE_NUMBER='" + PhoneNumbertextBox.Text + "' , DATE_OF_VISIT = to_date('" + Datofvisit.Value.Day.ToString()+"/"+Datofvisit.Value.Month.ToString()+"/"+Datofvisit.Value.Year.ToString() + "','DD/MM/YYYY') ,NEXT_CALL_DATE = to_date('" + NextCallDate.Value.Day.ToString()+"/"+NextCallDate.Value.Month.ToString()+"/"+NextCallDate.Value.Year.ToString() + "','DD/MM/YYYY'),  REMARK='" + text + "' where ENTRY_ID=" + entry_id + " ";
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();
                    MessageBox.Show("Updated!");
                    this.Close();
                }
               
            }
        }

        private void textBoxMRPersonName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partyname.Items.Clear();
             using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand("select PARTY_NAME,ENTRY_ID from DSR where MARKETING_PERSON_NAME='" + textBoxMRPersonName.SelectedItem.ToString() + "'", con);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Partyname.Items.Add(dr[0].ToString());
                    entry_id = Convert.ToInt32(dr[1].ToString());       

                }
                 
                con.Close();
            }
        }

        private void Partyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactPersontextBox.Text = "";
            PhoneNumbertextBox.Text = "";
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String query = "select * from DSR where  MARKETING_PERSON_NAME='" + textBoxMRPersonName.SelectedItem.ToString() + "'";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                  
                    Datofvisit.Text = dr["DATE_OF_VISIT"].ToString();
                    ContactPersontextBox.Text = dr["CONTACTED_PERSON"].ToString();
                    PhoneNumbertextBox.Text = dr["PHONE_NUMBER"].ToString();
                    NextCallDate.Text = dr["NEXT_CALL_DATE"].ToString();
                    textBoxOrderBookedAME.Text = dr["ORDER_BOOKED_AME"].ToString();
                    textBoxPaymentCollectedAME.Text = dr["PAYMENT_COLLECTED_AME"].ToString();
                    textBoxOrderBookedAE.Text = dr["ORDER_BOOKED_AE"].ToString();
                    textBoxPaymentCollectedAE.Text = dr["PAYMENT_COLLECTED_AE"].ToString();
                    RemarktextBox.Text = dr["REMARK"].ToString();
                }
                con.Close();
            }
        }

    

       
    }
}
