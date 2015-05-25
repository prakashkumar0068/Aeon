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
    public partial class OutWard_Product : Form
    {
        int outward_id = 0;
        int Product_id = 0;

        public OutWard_Product()
        {
            InitializeComponent();
        }

        private void productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            modal.Items.Clear();

            OracleCommand cmd6 = new OracleCommand("select PRODUCT_ID FROM PRODUCT Where PRODUCT_NAME ='" + productname.SelectedItem.ToString() + "' ", con);
            OracleDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                Product_id = Convert.ToInt32(dr6[0].ToString());

            }


            OracleCommand cmd1 = new OracleCommand("SELECT Distinct(MODAL_NUMBER) FROM INWARD_TABLE  Where PRODUCT_ID= " + Product_id + " and Active=1 ", con);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                modal.Items.Add(dr1[0].ToString());

            }

        }

        private void modal_SelectedIndexChanged(object sender, EventArgs e)
        {
            brand.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd2 = new OracleCommand("select Distinct(BRAND) from INWARD_TABLE Where  MODAL_NUMBER='" + modal.SelectedItem.ToString() + "' and Product_id=" + Product_id + " and Active =1", con);


            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                brand.Items.Add(dr2[0].ToString());

            }
            con.Close();
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            capacity.Items.Clear();
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd3 = new OracleCommand("select Distinct(CAPCITY) from INWARD_TABLE Where BRAND='" + brand.SelectedItem.ToString() + "' and MODAL_NUMBER='" + modal.SelectedItem.ToString() + "' and Product_id=" + Product_id + " and Active=1 ", con);


            OracleDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                capacity.Items.Add(dr3[0].ToString());

            }
            con.Close();
        }

        private void capacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd4 = new OracleCommand("select SERIAL_NUMBER from INWARD_TABLE Where CAPCITY='" + capacity.SelectedItem.ToString() + "' and BRAND='" + brand.SelectedItem.ToString() + "' and MODAL_NUMBER='" + modal.SelectedItem.ToString() + "' and Product_id=" + Product_id + " and Active=1 ", con);
            OracleDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())//
            {
                serialno.Items.Add(dr4[0].ToString());

            }
            con.Close();
        }

        private void serialno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string date = outwardddate.Value.Day + " / " + outwardddate.Value.Month + " / " + outwardddate.Value.Year;
            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd5 = new OracleCommand("select MAX(OUTWARD_ID) FROM OUTWARD_TABLE", con);
            OracleDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                try
                {
                    outward_id = Convert.ToInt32(dr5[0].ToString());
                }
                catch
                {

                }

            }
            ++outward_id;


            OracleCommand cmd1 = new OracleCommand("insert into OUTWARD_TABLE values('" + outward_id + "','" + serialno.Text + "','" + remark.Text + "','" + customername.Text + "','" + personcarrygoods.Text + "',to_date('" + date + "','DD/MM/YYYY'),'" + brand.Text + "','" + modal.Text + "','" + Product_id + "' )", con);
            OracleCommand cmd2 = new OracleCommand(("UPDATE INWARD_TABLE SET ACTIVE=0  WHERE PRODUCT_ID = " + Product_id + " "), con);
            OracleCommand cmd_update = new OracleCommand(("update PRODUCT set QTY=QTY-1 "), con);

            OracleTransaction transaction = con.BeginTransaction();   // Start a local transaction.


            cmd5.Transaction = transaction;
            try
            {
                if(customername.Text == "")
                {
                    MessageBox.Show("Enter Customer Name");
                    return;
                }
                if(productname.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Product ");
                    return;
                }
                if(brand.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Brand");
                    return;
                }
                if (capacity.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Capacity");
                    return;
                }
                if(serialno.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Serial Number");
                    return;
                }
                if (personcarrygoods.Text == "")
                {
                    MessageBox.Show("Enter Person Name");
                }
                else
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd_update.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("successful");
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Not Successful" + ex.ToString());
                try
                {
                    transaction.Rollback();
                }
                catch (OracleException roll_ex)
                {
                    MessageBox.Show(roll_ex.ToString());
                }
            }

            con.Close();
        }

        private void OutWard_Product_Load(object sender, EventArgs e)
        {
            OracleConnection con = ConnectionManager.getDatabaseConnection();

            OracleCommand cmd = new OracleCommand("SELECT distinct(PRODUCT_NAME) FROM PRODUCT  ", con);

            OracleDataReader dr = cmd.ExecuteReader();


            while (dr.Read())//
            {
                productname.Items.Add(dr[0].ToString());

            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
