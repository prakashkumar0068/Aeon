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
    public partial class NewContactDetails : Form
    {
        public static int contactid;
        //public static
        int orgid, max;
        public static int flag = 0;
        //List<string> id = new List<string>();
        public NewContactDetails()
        {
            InitializeComponent();
        }

        public void delete()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();
                _cmdObjj.CommandText = "delete from CLIENT_CONTACT_PERSON_DETAILS where MOBILE_NO = '" + Mobile.Text + "'";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                 MessageBox.Show("Records deleted successsfully");
                
                
            }
        }


        public int Validateit()
        {
            if (orgname.SelectedIndex < 0)
            {
                MessageBox.Show("Organization Filed is Empty");
                return 0;
            }
            if (cmb_name.Text == "" || cmb_name.Text.Trim() == "")
            {
                MessageBox.Show("Name Filed is Empty");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void NewContactDetails_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {


                OracleCommand cmd = new OracleCommand("select ORG_NAME from CLIENT_DETAILS ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    orgname.Items.Add(dr[0].ToString());

                }

                con.Close();


            }
        }

        private void orgname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_name.Items.Clear();
            cmb_name.Text = "";
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {


                //OracleCommand cmd = new OracleCommand("select CLIENT_CONTACT_PERSON_DETAILS.NAME,CLIENT_CONTACT_PERSON_DETAILS.ORGANISATION_ID FROM CLIENT_CONTACT_PERSON_DETAILS inner join CLIENT_DETAILS on CLIENT_CONTACT_PERSON_DETAILS.ORGANISATION_ID=CLIENT_DETAILS.ORGANISATION_ID where ORG_NAME='" + orgname.SelectedItem.ToString() + "'  ", con);
                OracleCommand cmd = new OracleCommand("select ORGANISATION_ID from CLIENT_DETAILS  where ORG_NAME = '"+orgname.SelectedItem.ToString()+"' ", con);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cmb_name.Items.Add(dr[0].ToString());
                    orgid = Convert.ToInt32(dr[0].ToString());
                }
                OracleCommand cmd1 = new OracleCommand("select NAME from CLIENT_CONTACT_PERSON_DETAILS  where ORGANISATION_ID = "+orgid+"  ", con);
                dr = cmd1.ExecuteReader();
                while(dr.Read())
                {
                    cmb_name.Items.Add(dr[0].ToString());
                }
                con.Close();



            }
        }

        private void cmb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
               // max = Convert.ToInt32(dr["ID"].ToString());
                phone.Text = "";
                Mobile.Text = "";
                email.Text = "";
                office.Text = "";
                fax.Text = "";
                desgi.Text = "";
                cmb_name.Text = "";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENT_CONTACT_PERSON_DETAILS where ORGANISATION_ID = " + orgid + " and NAME = '"+cmb_name.SelectedItem.ToString()+"'";
                dr = cmd.ExecuteReader();
                //if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        max = Convert.ToInt32(dr["ID"].ToString());
                        phone.Text = dr["RESIDENSE_NO"].ToString();
                        Mobile.Text = dr["MOBILE_NO"].ToString();
                        email.Text = dr["E_MAIL"].ToString();
                        office.Text = dr["OFFICE_NO"].ToString();
                        fax.Text = dr["FAX"].ToString();
                        desgi.Text = dr["DESIGNATION"].ToString();

                    }

                }
                


                dr.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int validat = Validateit();
            if (validat == 0)
            {
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();

                _cmdObjj.CommandText = "update CLIENT_CONTACT_PERSON_DETAILS set  NAME='" + cmb_name.Text + "', RESIDENSE_NO='" + phone.Text + "', OFFICE_NO='" + office.Text + "',MOBILE_NO='" + Mobile.Text + "', E_MAIL='" + email.Text + "',DESIGNATION='" + desgi.Text + "',FAX='" + fax.Text + "' Where ID=" + max + " ";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                MessageBox.Show("Records updated successsfully");
               // this.Close();
            }

            phone.Text = "";
            Mobile.Text = "";
            email.Text = "";
            office.Text = "";
            fax.Text = "";
            cmb_name.Text = "";
            desgi.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int max = 0;
            int validat = Validateit();
            if (validat == 0)
            {
                return;
            }
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
                        max = Int32.Parse((dr["max(ID)"].ToString()));
                    }
                    catch
                    {

                    }
                }
            }
            max++;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleCommand cmd = con.CreateCommand();


                    //cmd.CommandText = "select max(ORGANISATION_ID) from CLIENT_CONTACT_PERSON_DETAILS";
                    //OracleDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    orgid = Int32.Parse((dr["max(ORGANISATION_ID)"].ToString()));
                    //}

                    cmd.CommandText = "insert into CLIENT_CONTACT_PERSON_DETAILS(ORGANISATION_ID,NAME,RESIDENSE_NO,OFFICE_NO,MOBILE_NO,E_MAIL,DESIGNATION,FAX,ID) values (" + orgid + ", '" + cmb_name.Text + "','" + phone.Text + "','" + office.Text + "','" + Mobile.Text + "','" + email.Text + "','" + desgi.Text + "','" + fax.Text + "'," + max + " )";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved successsfully");
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            phone.Text = "";
            Mobile.Text = "";
            email.Text = "";
            office.Text = "";
            fax.Text = "";
            desgi.Text = "";
            cmb_name.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you Want to delete it", "Error message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                delete();

            }
            phone.Text = "";
            Mobile.Text = "";
            email.Text = "";
            office.Text = "";
            fax.Text = "";
            desgi.Text = "";
            cmb_name.Text = "";
        }
    }
}
