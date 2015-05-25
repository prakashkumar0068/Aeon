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
using System.Text.RegularExpressions;


namespace AeonNew
{
    public partial class CreateUser : Form
    {
        int bill_no = 1;
        int count;
       // SpeechSynthesizer reader = new SpeechSynthesizer();
        Point loc;
        public CreateUser()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox1.Text.Trim() == "")
            {
                string message = "You have not specified the Name.";
               // reader.Dispose();
               // reader = new SpeechSynthesizer();
               // reader.SpeakAsync(message);
                MessageBox.Show(message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "" || textBox2.Text.Trim() == "")
            {
                string message = "You have not specified the User_Name.";
               
                MessageBox.Show(message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox3.Text == "" || textBox3.Text.Trim() == "")
            {
                string message = "You have not specified the Password.";
               
                MessageBox.Show(message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedItem.ToString() == "--------select---------")
            {
                string message = "You have not specified the EMail.";
               
                MessageBox.Show(message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox5.Text == "" || textBox5.Text.Trim() == "")
            {
                string message = "You have not specified the amount Email.";
               
                MessageBox.Show(message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox3.TextLength < 6)
            {
                label9.Text = "Password must contains 6 Letter";
                label9.Visible = true;

                textBox3.Text = "";
                textBox4.Text = "";
                textBox3.Focus();
                return;
            }

           try
            {

                using (OracleConnection con = ConnectionManager.getDatabaseConnection())
                {


                    OracleCommand _cmdObjj = con.CreateCommand();
                    if (textBox3.Text == textBox4.Text)
                    {
                        _cmdObjj.CommandText = "insert into USERLOGIN(USERID, NAME, USERNAME, PASSWORD, DESIGNATION, E_MAIL) values(" + label8.Text + ", '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' ,'" + comboBox1.SelectedItem.ToString() + "', '" + textBox5.Text + "')";
                        _cmdObjj.CommandType = CommandType.Text;
                        _cmdObjj.Parameters.Clear();
                        _cmdObjj.ExecuteNonQuery();
                        MessageBox.Show("Data inserted");
                        this.Close();
                    }
                    else
                    {
                        label9.Visible = true;
                        label9.Text = " Password Not Match";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox3.Focus();

                    }
                   
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("");
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd1 = new OracleCommand();
                OracleCommand cmd = new OracleCommand("SELECT COUNT(USERID) FROM USERLOGIN", con);
                count = Convert.ToInt32(cmd.ExecuteScalar());
               
                label8.Text = (bill_no + count).ToString();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUser_Move(object sender, EventArgs e)
        {


            
    
        }

       
        
    }
}
