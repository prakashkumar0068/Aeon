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
    public partial class Bill_Details : Form
    {
        public static int bill_no=0;
        public Bill_Details()
        {
            InitializeComponent();
        }

        private void Bill_Details_Load(object sender, EventArgs e)
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from PAYMENT_DETAILS where BILL_NO = " + bill_no + "";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        BillNumberLabel.Text = bill_no.ToString();
                        BillDateLabel.Text = dr["BILL_DATE"].ToString();
                        BillDecidedLabel.Text = dr["DECIDED_INSTALLMENT"].ToString();
                        BillAmountLabel.Text = dr["AMT_RECEIVED"].ToString();
                        BillNoOfInsLabel.Text = dr["NUM_INST_COVERED"].ToString();
                        BillRecInLabel.Text = dr["AMT_REC_IN"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
