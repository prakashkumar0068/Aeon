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
using System.Net.Mail;

namespace AeonNew
{
    public partial class ChangePasswordForm1 : Form
    {
        Random rnd = new Random();
        int code;
        public ChangePasswordForm1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            code = rnd.Next(1111111, 9999999);
            label6.Text = code.ToString();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                try
                {
                    string query = "select USERID, E_MAIL from USERLOGIN where USERNAME = '" + textBox1.Text + "'";
                    OracleDataAdapter adp = new OracleDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    label7.Text = dt.Rows[0].ItemArray[0].ToString();

                    if (textBox2.Text == dt.Rows[0].ItemArray[1].ToString())
                    {
                        string from = "bajpai.anadi.bajpai@gmail.com";
                        string to = textBox2.Text;
                        string title = "Verification Code";
                        string body = "Verification Code :   " + label6.Text;
                        MailMessage mailIns = new MailMessage(from, to, title, body);
                        //MailAddress cc = new MailAddress("kunwarjaishankar@gmail.com");
                        //mailIns.CC.Add(cc);
                        SmtpClient mailSenderInstance = new SmtpClient("smtp.gmail.com", 25);
                        mailSenderInstance.Credentials = new System.Net.NetworkCredential("kunwarjaishankar@gmail.com", "jaishankar");
                        mailSenderInstance.EnableSsl = true;
                        mailSenderInstance.Send(mailIns);
                        mailIns.Dispose();

                        ChangePasswordForm2 cpf2 = new ChangePasswordForm2();
                        cpf2.Show();
                        cpf2.label1.Text = this.label7.Text;
                        cpf2.label5.Text = this.label6.Text;
                        this.Close();
                     }
                }
                catch(Exception)
                { 
                
                }
            }
        }

        private void ChangePasswordForm1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
