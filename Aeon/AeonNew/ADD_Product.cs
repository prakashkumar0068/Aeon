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
    public partial class ADD_Product : Form
    {
       
        public ADD_Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 1;
            int quantity = 0;

            OracleConnection con = ConnectionManager.getDatabaseConnection();
            OracleCommand cmd = new OracleCommand("select MAX(PRODUCT_ID) from PRODUCT ", con);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                try
                {
                    id = Convert.ToInt32(dr[0].ToString());
                }
                catch (Exception)
                {
                    id = 1;
                }
            }
            ++id;
            OracleCommand cmd1 = new OracleCommand("insert into PRODUCT values(" + id + ",'" + textBox1.Text + "'," + quantity + ")", con);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Product Name");
                return;
            }
            else
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Product Add");
            }
            con.Close();

            
        }

    }
}
