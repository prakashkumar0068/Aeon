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
    public partial class Inward : Form
    {
        int product_id;
        int active;
        int inward_id = 0;
        public Inward()
        {
            InitializeComponent();
        }

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd1 = new OracleCommand("SELECT product_id FROM PRODUCT WHERE product_NAME='" + productname.SelectedItem.ToString() + "'  ", con);

            OracleDataReader dr1 = cmd1.ExecuteReader();

            dr1.Read();

            product_id = Convert.ToInt32(dr1["product_id"].ToString());
            con.Close(); 


        }

        private void Inward_Load(object sender, EventArgs e)
        {
            //productname.Text = "select name";
            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd1 = new OracleCommand("SELECT max(INNWARD_ID) from INWARD_TABLE",con);
            
            OracleDataReader dr1 = cmd1.ExecuteReader();

            dr1.Read();

             inward_id = Convert.ToInt32(dr1[0].ToString());
            con.Close();
            con.Open();
            OracleCommand cmd2 = new OracleCommand("SELECT distinct(PRODUCT_NAME) FROM PRODUCT", con);
            OracleDataReader dr = cmd2.ExecuteReader();

            while (dr.Read())//
            {
                productname.Items.Add(dr[0].ToString());

            }
            con.Close(); 

        }

        private void producttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string date = inwarddate.Value.Day + "/" + inwarddate.Value.Month + "/" + inwarddate.Value.Year;
            active = 1;

            inward_id++;
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("insert into INWARD_TABLE values(" + inward_id + "," + product_id + ",'" + modal.Text + "','" + capacity.Text + "','" + producttype.Text + "','" + brand.Text + "','" + serialno.Text + "',to_date('" + date + "','DD/MM/YYYY')," + active + ")", con);
            OracleCommand cmd_update = new OracleCommand(("update PRODUCT set QTY=QTY+1 WHERE PRODUCT_ID=" + product_id + " "), con);
           // OracleCommand cmd_update1 = new OracleCommand(("update INWARD_TABLE set INWARD_ID=INWARD_ID+1 "), con);
            OracleTransaction transaction = con.BeginTransaction();   // Start a local transaction.

            // active = 0;
            cmd.Transaction = transaction;
            try
            {
                if (productname.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Product Name");
                    return;
                }
                if(producttype.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Product Type");
                    return;
                }
                if(modal.Text == "")
                {
                    MessageBox.Show("Enetr Model Number");
                    return;
                }
                if(brand.Text == "")
                {
                    MessageBox.Show("Enetr Brand Name");
                    return;
                }
                if(capacity.Text == "")
                {
                    MessageBox.Show("Enetr Capacity");
                    return;
                }
                if(serialno.Text == "")
                {
                    MessageBox.Show("Enetr Serial Number");
                    return;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    cmd_update.ExecuteNonQuery();
                    //  cmd_update1.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("successful");
                }



            }
            catch (OracleException ex)
            {
                MessageBox.Show("Not Successful" + ex.ToString());
                try { transaction.Rollback(); }
                catch (OracleException roll_ex)
                {
                    MessageBox.Show(roll_ex.ToString());
                }
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
