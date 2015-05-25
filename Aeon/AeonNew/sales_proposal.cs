using Oracle.DataAccess.Client;
using System;
using System.Data;

using System.Windows.Forms;

namespace AeonNew
{
     
    public partial class sales_proposal : Form
    {
        
        DataTable datatable = new DataTable();
        double subtotal = 0;
        int srno = 0;
        string Mystring, Firststring, Quote_no_of_database;
        string Serial_number, description, Unit, Quantityamount, Taxallow, Amount;
        public sales_proposal()
        {
            InitializeComponent();
            datatable.Columns.Add("SRNO", typeof(String));
            datatable.Columns.Add("description", typeof(String));
            datatable.Columns.Add("Unit", typeof(String));
            datatable.Columns.Add("Quantity", typeof(String));
            datatable.Columns.Add("Tax", typeof(String));
            datatable.Columns.Add("Amount", typeof(String));
            Quote_no_of_database = "AME/2015-16/000";
        }

         
        private void sales_proposal_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Customer will be billed after indicating acceptance of this quote");
            listBox1.Items.Add(" 100% Payment along with PO");
            listBox1.Items.Add(" Deshaped/Bulged Battery will not be replaced");
            listBox1.Items.Add(" Any civil work for site preparation is not in the scope of this proposal");
            listBox1.Items.Add(" Input/Output wiring, Phase changer, Changeover Switch, Main switch is not under our quoted scope of work & will be Charged extra");
            listBox1.Items.Add(" Goods once sold are not returnable");
            listBox1.Items.Add(" All disputes are subject to Lucknow jurisdation only");


            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ORG_NAME from CLIENT_DETAILS";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        Custnametxt.Items.Add(dr[0].ToString());
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (Termstxt.Text.Trim() != string.Empty)
            {
                listBox1.Items.Add(Termstxt.Text.TrimStart());
                listBox1.Sorted = true;
            }
            Termstxt.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.GetItemText(listBox1.SelectedItem));   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srno = 0;
            
            string Quote_no, Customername ,Warrenty, Valid_until, Delivery, Invoice_to, Deliver_to,  Terms_and_conditions,instllation_charge,Extra_charges;

           
           
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT QUOTE_NO FROM SALES_PROPOSAL_DETAILS ORDER BY QUOTE_NO  DESC ";
               
                cmd.CommandType = CommandType.Text;
                OracleDataReader odr = cmd.ExecuteReader();


                try
                {
                    if (odr.Read())
                    {
                        Quote_no_of_database = odr[0].ToString();

                    }
                }
                catch { return; }
                
             }

           

            Firststring = Quote_no_of_database.Remove(14);

            Mystring = Quote_no_of_database.Substring(12);

            int NewString = int.Parse(Mystring) + 1;

            Quote_no = Firststring + NewString;
            Customername = Custnametxt.Text;
            Warrenty = warrentytxt.Text;
            Valid_until = Validtxt.Text;
            Delivery = Deliverytxt.Text;
            
            Invoice_to = Invoicetxt.Text;
            Deliver_to = Delivertotxt.Text;
            
            instllation_charge = Intallation.Text;
            Extra_charges = Extra_charge.Text;

            string TimeslotItems = "";
            foreach (string item in listBox1.Items)
            {
                TimeslotItems += item + ",\n";
                
            }

            Terms_and_conditions = TimeslotItems;
            

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleTransaction transaction;
                OracleCommand cmd = con.CreateCommand();
                transaction = con.BeginTransaction();
                try
                {

                   cmd.CommandText = "insert into SALES_PROPOSAL_DETAILS VALUES ('" + Quote_no + "','" +Valid_until + "','" +Delivery + "','" +Invoice_to+"','"+Deliver_to + "','" +instllation_charge + "','" +Extra_charges + "', '" +Warrenty + "','"+Customername+"')";
                   cmd.CommandType = CommandType.Text;
                   cmd.ExecuteNonQuery();
                   cmd.CommandText = "insert into SALES_TERMS_AND_CONDITION VALUES ('" + Quote_no + "','"+Terms_and_conditions+"') ";
                   cmd.ExecuteNonQuery();

                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                     Serial_number = datatable.Rows[i].ItemArray[0].ToString();
                     description = datatable.Rows[i].ItemArray[1].ToString();
                     Unit = datatable.Rows[i].ItemArray[2].ToString();
                     Quantityamount = datatable.Rows[i].ItemArray[3].ToString();
                     Taxallow =datatable.Rows[i].ItemArray[4].ToString();
                     Amount =datatable.Rows[i].ItemArray[5].ToString();


                    cmd.CommandText = "insert into SALES_QUANTITY_DESCRITION  VALUES ('" +Quote_no+ "','" + description+ "','" + Unit+ "','" + Quantityamount+ "','" + Taxallow+ "','" + Amount+ "','" + Serial_number+ "')";
                    cmd.ExecuteNonQuery();
                    }
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (OracleException OracleError)
                {

                    transaction.Rollback();
                    MessageBox.Show(OracleError.Message);

                }

                sales_perposal_report open = new sales_perposal_report(Quote_no, Customername, Warrenty, Valid_until, Delivery, Invoice_to, Deliver_to, Terms_and_conditions, instllation_charge, Extra_charges, subtotal, datatable);
                open.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             
            DialogResult result = MessageBox.Show("Do you want Add more records?", "Information", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                button1.Enabled = false;
            }
            DataRow dtrow;
            double amount=Convert.ToDouble( Quantity.Text) * Convert.ToInt64( Unittxt.Text);
            try
            {
                amount += amount *(Convert.ToDouble(Taxtxt.Text) / 100.0);

             subtotal = subtotal + amount;
            }
            catch
            {

            }
            srno += 1;
            dtrow = datatable.NewRow();
            dtrow["SRNO"] = srno;
            dtrow["description"] = descriptiontext.Text;
            dtrow["Unit"] = Unittxt.Text;
            dtrow["Quantity"] = Quantity.Text;
            dtrow["Tax"] = Taxtxt.Text;

            dtrow["Amount"] = amount;
            datatable.Rows.Add(dtrow);


            listBox2.Items.Add(descriptiontext.Text);
            descriptiontext.Text="";
            Unittxt.Text="";
            Quantity.Text="";
            
            Taxtxt.Text = "";
                      
        }
        
    }
}
