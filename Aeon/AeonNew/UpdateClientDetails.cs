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
    public partial class UpdateClientDetails : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        public UpdateClientDetails()
        {
            InitializeComponent();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateClientDetails_Load(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("Select ORG_NAME from CLIENT_DETAILS", conn);
            datareader = cmd.ExecuteReader();
            while(datareader.Read())
            {
                cmb_client.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Close();
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select BRANCH_ADDRESS,SEGMENT,CITY,ORG_WEBSITE,ADDRESS,FACTORY_ADDRESS,STATE,PIN,CODE from CLIENT_DETAILS where ORG_NAME = '" + cmb_client.SelectedItem.ToString() + "'", conn);
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                txt_code.Text = datareader[8].ToString();
                branchOffice.Text = datareader[0].ToString();
                segementtextbox.Text = datareader[1].ToString();
                citytextbox.Text = datareader[2].ToString();
                websiteTextbox.Text = datareader[3].ToString();
                addressTextBox.Text = datareader[4].ToString();
                factoryoffice.Text = datareader[5].ToString();
                statetextbox.Text = datareader[6].ToString();
                pintetxt.Text = datareader[7].ToString();
            }
            datareader.Close();
            conn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (cmb_client.SelectedIndex < 0)
            {
                MessageBox.Show("Select Client Name");
                return;
            }
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("update CLIENT_DETAILS set  ORG_WEBSITE='" + websiteTextbox.Text + "',ORG_NAME='" + cmb_client.SelectedItem.ToString() + "',ADDRESS='" + addressTextBox.Text + "' , BRANCH_ADDRESS='" + branchOffice.Text + "' , FACTORY_ADDRESS='" + factoryoffice.Text + "', CODE='" + txt_code.Text + "',SEGMENT='" + segementtextbox.Text + "',DATEOFJOINING='" + todaydate.Value.Day.ToString()+"/"+todaydate.Value.Month.ToString()+"/" +todaydate.Value.Year.ToString()+ "',CITY='" + citytextbox.Text + "',STATE='" + statetextbox.Text + "' , Pin ='" + pintetxt.Text + "' where ORGANISATION_ID = (select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME = '" + cmb_client.SelectedItem.ToString() + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Clone();
            MessageBox.Show("Information Updated");
        }
    }
}
