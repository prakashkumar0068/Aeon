using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class sales_perposal_report : Form
    {
        string Quote_no;
        string Customername;
        string warrenty;
        string Valid_until;
        string Delivery;
        
        string Invoice_to;
        string Deliver_to;
        
        string Terms_and_conditions;
        string instllation_charge;
        string Extra_charges;
        double subtotal;
        DataTable dt;
        
        

        

        

        public sales_perposal_report(string Quote_no,string Customername,string warrenty,string Valid_until,string Delivery,string Invoice_to,string Deliver_to,string Terms_and_conditions,string instllation_charge,string Extra_charges,double subtotal,DataTable dt)
        {
            InitializeComponent();
            this.Quote_no = Quote_no;
            this.Customername = Customername;
            this.warrenty=warrenty;
           
            this.Valid_until=Valid_until;
            this.Delivery=Delivery;
            
            this.Invoice_to=Invoice_to;
            this.Deliver_to=Deliver_to;
            
            this.Terms_and_conditions =Terms_and_conditions;
            this.instllation_charge = instllation_charge;
            this.Extra_charges = Extra_charges;
            this.subtotal = subtotal;
            this.dt = dt;

            
           
            
        }

         

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

           

            salespuposal_report sales=new salespuposal_report();
            sales.SetDataSource(dt);
            
            this.crystalReportViewer1.ReportSource = sales;
            sales.SetParameterValue("Quote_no", Quote_no);
            sales.SetParameterValue("Customer Name", Customername);
            sales.SetParameterValue("Warrenty",warrenty);
            sales.SetParameterValue("Valid_until",Valid_until);
            sales.SetParameterValue("Delivery",Delivery);
            
            sales.SetParameterValue("Invoice_to",Invoice_to);
            sales.SetParameterValue("Deliver_to",Deliver_to);
            
            sales.SetParameterValue("Terms_and_conditions",Terms_and_conditions);
            sales.SetParameterValue("Installation Charges", instllation_charge);
            sales.SetParameterValue("Other Charges", Extra_charges);
            sales.SetParameterValue("Sub_Total", subtotal);
            double Total = subtotal + Convert.ToDouble(instllation_charge) + Convert.ToDouble(Extra_charges);
            sales.SetParameterValue("Total", Total);
            
              
        }

        private void sales_perposal_report_Load(object sender, EventArgs e)
        {
        
        }

        

               
               
               
        }
    }

