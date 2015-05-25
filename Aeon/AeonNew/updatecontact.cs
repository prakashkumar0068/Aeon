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
    public partial class updatecontact : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;

        public static int contactid;
        public static int orgid;
        public static int flag=0;
        ClientDetails objMain;
        Form _frm;
        public updatecontact(Form frm)
        {
            _frm = frm;
            InitializeComponent();
        }

        private void updatecontact_Load(object sender, EventArgs e)
        {
            objMain = (ClientDetails)_frm;
            if (orgid == -1)
            {
                button3.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;

            }

            getvalue();
            //conn = ConnectionManager.getDatabaseConnection();
            //cmd = new OracleCommand("select NAME from CLIENT_CONTACT_PERSON_DETAILS ", conn);
            //datareader = cmd.ExecuteReader();
            //while(datareader.Read())
            //{
            //    Namecontact.Items.Add(datareader[0].ToString());
            //}
            //datareader.Close();
            //conn.Close();
            
        }


        public void getvalue()
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENT_CONTACT_PERSON_DETAILS where ID=" + contactid + "";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Namecontact.Text = dr["NAME"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result=MessageBox.Show("Do you Want to delete it", "Error message", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                delete();

            }
            

        }
        public void delete()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();
                _cmdObjj.CommandText = "delete from CLIENT_CONTACT_PERSON_DETAILS where ID =" + contactid + "";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                 MessageBox.Show("Records deleted successsfully");
                 getvalue();
                
            }
        }

        private void updatecontact_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag = 0;
            objMain.contactperson();
            
        }
        public int Validateit()
        {
            if (Namecontact.Text == "" || Namecontact.Text.Trim() == "")
            {
                MessageBox.Show("Name Filed is Empty");
                return 0;
            }
            else
            {
                return 1;
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

                _cmdObjj.CommandText = "update CLIENT_CONTACT_PERSON_DETAILS set  NAME='" + Namecontact.Text + "', RESIDENSE_NO='" + phone.Text + "', OFFICE_NO='" + office.Text + "',MOBILE_NO='" + Mobile.Text + "', E_MAIL='" + email.Text + "',DESIGNATION='"+desgi.Text+"',FAX='"+fax.Text+"' Where ID=" + contactid + "";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                MessageBox.Show("Records updated successsfully");
                this.Close();
            }

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            int max = 0;
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
                    cmd.CommandText = "insert into CLIENT_CONTACT_PERSON_DETAILS(ORGANISATION_ID, NAME, RESIDENSE_NO, OFFICE_NO, MOBILE_NO, E_MAIL, DESIGNATION, FAX, ID) VALUES(" + orgid + ", '" + Namecontact.Text + "', '" + phone.Text + "', '" + office.Text + "', '" + Mobile.Text + "', '"+email.Text+"' ,'" + desgi.Text + "', '" + fax.Text + "', " + max + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Records saved successsfully");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
