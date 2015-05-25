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
    public partial class update_complain_by_id : Form
    {
        int id;
        String eng,cmp_date;
        OracleTransaction transaction;
        public update_complain_by_id()
        {
            InitializeComponent();
        }

        private void update_complain_by_id_Load(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("select COMPLAINT_ID from  COMPLAINT_TABLE", con);
            OracleDataReader datareader1 = cmd.ExecuteReader();
              while(datareader1.Read())
            {
                complain_id.Items.Add(datareader1[0]);

            }

               
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void complain_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            eng_name1.Items.Clear();
            eng_name1.Text = " ---SELECT ENGINEER---";
           

                OracleConnection con = ConnectionManager.getDatabaseConnection();
              
                OracleCommand cmd1 = new OracleCommand("select ENGINEER_SCHEDULE from  ENG_SCHEDULE where COMPLAINT_ID= '" + complain_id.SelectedItem.ToString() + "' ", con);
            
            OracleDataReader dr = cmd1.ExecuteReader();
              
                while (dr.Read())
                {

                    eng_name1.Items.Add(dr[0]);

                }
                con.Close();
           
        }

        private void eng_name1_SelectedIndexChanged(object sender, EventArgs e)
        {
            eng = eng_name1.SelectedItem.ToString();
            Equip_name.Text = "";
            brand.Text = "";
            modal.Text = "";
            capacity.Text = "";
            natureofcomplain.Text = "";
            

           // eng_name1.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd1 = new OracleCommand("select EQUIP_NAME,EQUIP_BRAND,EQUIP_MODEL,EQUIP_CAPACITY,NATURE_OF_COMPLAINT from  COMPLAINT_TABLE where COMPLAINT_ID= '" + complain_id.SelectedItem.ToString() + "' ", con);
            OracleDataReader dr = cmd1.ExecuteReader();

          if (dr.Read())
            {

                Equip_name.Text = dr["EQUIP_NAME"].ToString();
                brand.Text = dr["EQUIP_BRAND"].ToString();
                modal.Text = dr["EQUIP_MODEL"].ToString();
                capacity.Text = dr["EQUIP_CAPACITY"].ToString();
                

                natureofcomplain.Text = dr["NATURE_OF_COMPLAINT"].ToString();
          
            }
          //date.Value.Add();
      
          con.Close();




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (complain_id.SelectedIndex < 0)
            {
                MessageBox.Show("Select Complaint Id");
                return;
            }
            if (eng_name1.Text == " ---SELECT ENGINEER---" || eng_name1.Text == "")
            {
                MessageBox.Show("Select Engineer Name");
                return;
            }
          
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();

                transaction = con.BeginTransaction();
                cmd.CommandText = "update COMPLAINT_TABLE set  COMPLAINT_TABLE.EQUIP_NAME='" + Equip_name.Text + "', COMPLAINT_TABLE.EQUIP_BRAND='" + brand.Text + "', COMPLAINT_TABLE.EQUIP_MODEL='" + modal.Text + "',COMPLAINT_TABLE.EQUIP_CAPACITY='" + capacity.Text + "', COMPLAINT_TABLE.NATURE_OF_COMPLAINT='" + natureofcomplain.Text + "' Where COMPLAINT_TABLE.COMPLAINT_ID= " + Convert.ToInt32(complain_id.SelectedItem.ToString()) + " ";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update ENG_SCHEDULE set  ENGINEER_SCHEDULE = '" + eng_name1.Text + "' Where ENGINEER_SCHEDULE = '" + eng + "'";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Records updated successsfully");
                this.Close();
            }
        }
    }
}
