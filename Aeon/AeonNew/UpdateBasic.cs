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
    public partial class UpdateBasic : Form
    {
        public static string clinetName;
        Form _frm;
        ClientDetails objMain;
         public string id = "0";
        public UpdateBasic(Form frm)
        {
           _frm = frm;
            InitializeComponent();
        }

        private void UpdateBasic_Load(object sender, EventArgs e)
        {
             objMain = (ClientDetails)_frm;
            OracleDataReader dr;
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
                        id = dr["ORGANISATION_ID"].ToString();
                        Nameclient.Text = clinetName;
                        websiteTextbox.Text = dr["ORG_WEBSITE"].ToString();
                        addressTextBox.Text = dr["ADDRESS"].ToString();
                        factoryoffice.Text = dr["FACTORY_ADDRESS"].ToString();
                        branchOffice.Text=dr["BRANCH_ADDRESS"].ToString();
                        categoryTextBox1.Text = dr["CODE"].ToString();
                        segementtextbox.Text = dr["SEGMENT"].ToString();
                        todaydate.Text = dr["DATEOFJOINING"].ToString();
                        statetextbox.Text = dr["STATE"].ToString(); ;
                        citytextbox.Text = dr["CITY"].ToString();
                        pintetxt.Text = dr["PIN"].ToString();
                    }

                }


                dr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Nameclient.Text == "" || Nameclient.Text.Trim() == "")
            {
                MessageBox.Show("Client Name Field is Empty");
                return;
            }
            if (categoryTextBox1.Text.Trim() == "" || categoryTextBox1.Text=="---select----")
            {
                MessageBox.Show("Category Field is Empty");
                return;
            }
            if (addressTextBox.Text.Trim() == "" || addressTextBox.Text == "")
            {
                MessageBox.Show("Address Field is Empty");
                return;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleCommand _cmdObjj = con.CreateCommand();

                    _cmdObjj.CommandText = "update CLIENT_DETAILS set  ORG_WEBSITE='" + websiteTextbox.Text + "',ORG_NAME='" + Nameclient.Text + "',ADDRESS='" + addressTextBox.Text + "' , BRANCH_ADDRESS='" + branchOffice.Text + "' , FACTORY_ADDRESS='" + factoryoffice.Text + "', CODE='" + categoryTextBox1.SelectedItem.ToString() + "',SEGMENT='" + segementtextbox.Text + "',DATEOFJOINING = to_date'" + todaydate.Value.Day.ToString()+"/"+todaydate.Value.Month.ToString()+"/"+todaydate.Value.Year.ToString() + "',CITY='"+citytextbox.Text+"',STATE='"+statetextbox.Text+"' , Pin ='"+pintetxt.Text+"' where ORGANISATION_ID=" + id + "";
                    _cmdObjj.CommandType = CommandType.Text;
                    _cmdObjj.Parameters.Clear();
                    _cmdObjj.ExecuteNonQuery();
                    MessageBox.Show("Updated!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error is occured!");
                }

            }
        }

        private void UpdateBasic_FormClosed(object sender, FormClosedEventArgs e)
        {

            objMain.clientdetails(clinetName);
        }

        private void websiteTextbox_TextChanged(object sender, EventArgs e)
        {
            int len = "http://www.".Length;
            if (websiteTextbox.TextLength < len)
            {
                MessageBox.Show("you can't  delete this");
                websiteTextbox.Text = "http://www.";
            }
        }
    }
}
