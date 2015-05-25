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
    public partial class Emaitemplate : Form
    {
        public Emaitemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO emailbody (msgsubject, Body) VALUES ('" + richTextBox1.Text + "','" + richTextBox2.Text + "') ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("tamplate created");
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Exception");

                }
            }
        }
    }
}
