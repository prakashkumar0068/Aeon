using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using SplashCreation.classes;
using System.Threading;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AeonNew
{
    public partial class LoginForm : Form
    {
        public static int i = 1;
        public static String desgi = "";
        public static String Username = "";
        public static String UserID= "";
        public LoginForm()
        {
            InitializeComponent();
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                string query = "select  DESIGNATION, USERID,NAME from USERLOGIN where USERNAME = '" + textBox1.Text + "' and PASSWORD='"+textBox2.Text+"'";
                OracleDataAdapter adp = new OracleDataAdapter(query, con);
                adp.Fill(dt);
              
            }
            if (dt.Rows.Count > 0)
            {
                //old_LogComplaint.logcomplaint = textBox1.Text;
                desgi = dt.Rows[0][0].ToString();
                UserID=dt.Rows[0][1].ToString();
                Username = dt.Rows[0][2].ToString();
                MainWindow obj = new MainWindow();

                MenuStrip me = (MenuStrip)obj.Controls["menuStrip"];
                ToolStripMenuItem ti = (ToolStripMenuItem)me.Items["addNewClientToolStripMenuItem"];
                ToolStripMenuItem Amc1 = (ToolStripMenuItem)me.Items["dSRManagementToolStripMenuItem"];
                ToolStripMenuItem Amc2 = (ToolStripMenuItem)me.Items["aMCToolStripMenuItem"];
                ToolStripMenuItem Amc3 = (ToolStripMenuItem)me.Items["inventoryToolStripMenuItem"];

                ToolStripMenuItem Amc4 = (ToolStripMenuItem)me.Items["complainToolStripMenuItem"];
                ToolStripMenuItem Amc5 = (ToolStripMenuItem)me.Items["newUserToolStripMenuItem"];
                ToolStripMenuItem Amc6 = (ToolStripMenuItem)me.Items["changePasswordToolStripMenuItem"];

                if (desgi.Equals("Engineer"))
                {
                    ti.Enabled = false;
                    Amc1.Enabled = false;
                    Amc3.Enabled = false;
                    Amc2.Enabled = false;
                    Amc5.Enabled = false;
                   
                }
                if (desgi.Equals("Sales Person"))
                {
                   // ti.Enabled = false;
                 
                    Amc2.Enabled = false;
                    Amc3.Enabled = false;
                    Amc4.Enabled = false;
                    Amc5.Enabled = false;
                    

                }
               // Amc3.Enabled = false;
                this.Hide();
                obj.Show();
            }
            else
            {
                label4.Text = "User is not Valid";
                label4.Visible = true;
            }
            
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            

            ChangePasswordForm1 cpf1 = new ChangePasswordForm1();
            i++;
            cpf1.Show();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
