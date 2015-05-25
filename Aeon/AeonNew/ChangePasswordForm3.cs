using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AeonNew
{
    public partial class ChangePasswordForm3 : Form
    {
        public ChangePasswordForm3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
              //  try
                {
                    if (textBox3.Text == textBox1.Text)
                    {
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update USERLOGIN set PASSWORD='" + textBox3.Text + "' where UserID=" + LoginForm.UserID + "";
                      int i=  cmd.ExecuteNonQuery();
                        MessageBox.Show("Password successfully changed And Relogin");
                        Application.Exit();
                            
                     
                    }
                }
              
            }
        }
    }
}
