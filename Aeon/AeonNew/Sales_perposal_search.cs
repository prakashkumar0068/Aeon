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
    public partial class Sales_perposal_search : Form
    {
        double subtotal;
        public Sales_perposal_search()
        {
            InitializeComponent();
            datatable.Columns.Add("SRNO", typeof(String));
            datatable.Columns.Add("description", typeof(String));
            datatable.Columns.Add("Unit", typeof(String));
            datatable.Columns.Add("Quantity", typeof(String));
            datatable.Columns.Add("Tax", typeof(String));
            datatable.Columns.Add("Amount", typeof(String));
        }
       
       
        DataTable datatable = new DataTable();
       


        string Quote_no, Customername, Warrenty, Valid_until, Delivery, Invoice_to, Deliver_to, Terms_and_conditions, instllation_charge, Extra_charges ;
       

        private void Search_Click(object sender, EventArgs e)
        {

          

           using (OracleConnection con = ConnectionManager.getDatabaseConnection())
           {
               OracleCommand cmd = con.CreateCommand();
               cmd.CommandText = "select * from SALES_QUANTITY_DESCRITION where QUOTE_NO='" + textBox1.Text + "'";
               cmd.CommandType = CommandType.Text;

               OracleDataReader odr = cmd.ExecuteReader();
              
               DataRow dtrow;
               
                   while (odr.Read())
                   {

                       dtrow = datatable.NewRow();

                       dtrow["description"] = odr[1].ToString();
                       dtrow["Unit"] = odr[2].ToString();
                       dtrow["Quantity"] = odr[4].ToString();
                       dtrow["Tax"] = odr[3].ToString();

                       dtrow["Amount"] = odr[5].ToString();
                       dtrow["SRNO"] = odr[6].ToString();
                       datatable.Rows.Add(dtrow);

                       subtotal = subtotal + Convert.ToDouble(odr[5].ToString());

                   }
               



               cmd.CommandText = "SELECT * FROM SALES_TERMS_AND_CONDITION where QUOTE_NO='" + textBox1.Text + "' ";
               cmd.CommandType = CommandType.Text;
               OracleDataReader odr1 = cmd.ExecuteReader();
               if (odr1.Read())
               {
                   Quote_no = odr1[0].ToString();
                   Terms_and_conditions = odr1[1].ToString();
               }

               cmd.CommandText = "SELECT * FROM SALES_PROPOSAL_DETAILS where QUOTE_NO='" + textBox1.Text + "' ";
               cmd.CommandType = CommandType.Text;
               OracleDataReader odr2 = cmd.ExecuteReader();
               if (odr2.Read())
               {

                   Quote_no = odr2[0].ToString();
                   Valid_until = odr2[1].ToString();
                   Delivery = odr2[2].ToString();
                   Invoice_to = odr2[3].ToString();
                   Deliver_to = odr2[4].ToString();
                   instllation_charge = odr2[5].ToString();
                   Extra_charges = odr2[6].ToString();
                   Warrenty = odr2[7].ToString();
                   Customername = odr2[8].ToString();


               }
           }
           this.Hide();

           sales_perposal_report open = new sales_perposal_report(Quote_no, Customername, Warrenty, Valid_until, Delivery, Invoice_to, Deliver_to, Terms_and_conditions, instllation_charge, Extra_charges, subtotal, datatable);
           open.Show();
        }
    }
}
