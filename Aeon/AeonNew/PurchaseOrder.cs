using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AeonNew
{
    public partial class PurchaseOrder : Form
    {
        DataRow datarow;
        int po_no = 1, org_id =1 , desc_id = 1;
        DataTable datatable ;
        OracleConnection conn;
        OracleDataAdapter dataAdapter;
        OracleCommand cmd = new OracleCommand();
        OracleDataReader datareader;
        String date;
         OracleTransaction transaction;
         string Address;
         int subtotal = 0;
        public PurchaseOrder()
        {
            InitializeComponent();
            datatable = new DataTable();
            datatable.Columns.Add("Ponumber", typeof(Int32));
            datatable.Columns.Add("desc_id", typeof(Int32));
            datatable.Columns.Add("desc", typeof(String));
            datatable.Columns.Add("Qty", typeof(Int32));
            datatable.Columns.Add("unitprice", typeof(Int32));
            datatable.Columns.Add("totalamount", typeof(Int32));
        }

        private void bt_add_items_Click(object sender, EventArgs e)
        {
            desc_id++;
            datarow = datatable.NewRow();
            datarow[0] = po_no;
            datarow[1] = desc_id;
            datarow[2] = txt_desc.Text;
            datarow[3] = txt_quantity.Text;
            datarow[4] = txt_unit_price.Text;
            datarow[5] = Convert.ToInt32(txt_quantity.Text) * Convert.ToInt32(txt_unit_price.Text);
            subtotal += Convert.ToInt32(datarow[5].ToString());
            lst_add_items.Items.Add(datarow[2]);

            datatable.Rows.Add(datarow);
            DialogResult result = MessageBox.Show("Do you want to Add More Records ", "information", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                bt_add_items.Enabled = false;
            }
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
           cmd = new OracleCommand("SELECT ORG_NAME FROM CLIENT_DETAILS ", conn);
           datareader = cmd.ExecuteReader();
           while (datareader.Read())
            {
                cmb_org_name.Items.Add(datareader[0].ToString());

            }
           datareader.Close();
           cmd = new OracleCommand("SELECT MAX(PO_NUMBER) FROM PURCHASE_ORDER ", conn);          
           datareader = cmd.ExecuteReader();         
           if (datareader.Read())
           {
               try
               {
                   po_no = Convert.ToInt32(datareader[0].ToString());
               }
               catch(Exception ex)
               {
                   po_no = 1;
               }
           }      
         
            cmd = new OracleCommand("SELECT MAX(DESCRIPTION_ID) FROM PURCHASE_ORDER_DESCRIPTION ", conn);

            datareader = cmd.ExecuteReader();

            if (datareader.Read())
            {
                try
                {
                    desc_id = Convert.ToInt32(datareader[0].ToString());
                }
                catch (Exception ex)
                {
                    desc_id = 1;
                }
            }
           
            conn.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
             date = orderdate.Value.Day + "/" + orderdate.Value.Month + "/" + orderdate.Value.Year;
          


            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand();
          
            transaction = conn.BeginTransaction();   // Start a local transaction.

            
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            
          
            try
            {
                if(cmb_org_name.SelectedIndex < 0)
                {
                    MessageBox.Show("Select Client Name");
                    return;
                }
                if(txt_tax.Text == "")
                {
                    MessageBox.Show("Enter Tax");
                    return;
                }
                if(txt_quantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity");
                    return;

                } 
                if(txt_unit_price.Text == "")
                {
                    MessageBox.Show("Enter Unit Price");
                    return;
                }
                if (txt_desc.Text == "")
                {
                    MessageBox.Show("Enter Description Of Product");
                    return;
                }
                else
                {


                    cmd.CommandText = "insert into PURCHASE_ORDER values(" + datatable.Rows[0][0].ToString() + ",TO_DATE('" + date + "','DD/MM/YYYY')," + org_id + ",'" + txt_tax.Text + "' )";
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        cmd.CommandText = "insert into PURCHASE_ORDER_DESCRIPTION values(" + datatable.Rows[i][0].ToString() + "," + datatable.Rows[i][1].ToString() + ",'" + datatable.Rows[i][2].ToString() + "'," + datatable.Rows[i][3].ToString() + "," + datatable.Rows[i][4].ToString() + " )";
                        cmd.ExecuteNonQuery();
                    }
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
            DataTable client_info_table = new DataTable();
            cmd.CommandText = "select ORG_NAME,ADDRESS,CITY,PIN,STATE from CLIENT_DETAILS where ORG_NAME = '"+cmb_org_name.SelectedItem.ToString()+"'";
            datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                Address = datareader[0].ToString() + Environment.NewLine + "\t" + datareader[1].ToString() + Environment.NewLine + "\t" + datareader[2].ToString() + Environment.NewLine + "\t" + datareader[3].ToString() + Environment.NewLine + "\t" + datareader[4].ToString();
            }
            conn.Close();
            GeneratePurchaseOrderReport obj = new GeneratePurchaseOrderReport(datatable,Address, Convert.ToInt32(txt_tax.Text), subtotal);
            obj.Show();
        }

        private void cmb_org_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            subtotal = 0;
            
            datatable.Rows.Clear();
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void txt_tax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        }
    }

