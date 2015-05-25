using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class DSRRepotAll : Form
    {
        BindingSource bindingSource1 = new BindingSource();
        DataTable dt = new DataTable("DSR");
        public DSRRepotAll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select MARKETING_PERSON_NAME, ENTRY_STATUS, PARTY_NAME, CONTACTED_PERSON, NEXT_CALL_DATE, ORDER_BOOKED_AME, PAYMENT_COLLECTED_AME, ORDER_BOOKED_AE, PAYMENT_COLLECTED_AE from DSR";
            loaddata(query);
        }
        public void loaddata(string query)
        {
            dt.Clear();
            
             using (OracleConnection con = ConnectionManager.getDatabaseConnection())
             {
                 OracleDataAdapter oracleDataAdapter1 = new OracleDataAdapter(query, con);
                 OracleCommandBuilder oracleCommandBuilder1 = new OracleCommandBuilder(oracleDataAdapter1);
             
                
                 oracleDataAdapter1.Fill(dt);
                 //ds = dt;
                 if (dt.Rows.Count == 0)
                 {
                     MessageBox.Show("Data Not Found Select Another Date");
                     return;
                 }
                 bindingSource1.DataSource = dt;
                 dataGridView1.DataSource = bindingSource1;
                
                 dataGridView1.Columns["MARKETING_PERSON_NAME"].HeaderText = "MARKETING PERSON NAME";
                 dataGridView1.Columns["MARKETING_PERSON_NAME"].Width = 250;
                 dataGridView1.Columns["ENTRY_STATUS"].HeaderText = "PAYMENT ENTRY";
                 dataGridView1.Columns["ENTRY_STATUS"].Width = 200;
                 dataGridView1.Columns["PARTY_NAME"].HeaderText = "PARTY NAME";
                 dataGridView1.Columns["PARTY_NAME"].Width = 250;
                 dataGridView1.Columns["CONTACTED_PERSON"].HeaderText = "PERSON CONTECTED";
                 dataGridView1.Columns["CONTACTED_PERSON"].Width = 250;
                 dataGridView1.Columns["NEXT_CALL_DATE"].HeaderText = "NEXT CALL DATE";
                 dataGridView1.Columns["NEXT_CALL_DATE"].Width = 200;
                 dataGridView1.Columns["ORDER_BOOKED_AME"].HeaderText = "ORDER BOOKED FOR AME";
                 dataGridView1.Columns["ORDER_BOOKED_AME"].Width = 250;
                 dataGridView1.Columns["PAYMENT_COLLECTED_AME"].HeaderText = "PAYMENT COLLECTED FOR AME";
                 dataGridView1.Columns["PAYMENT_COLLECTED_AME"].Width = 250;
                 dataGridView1.Columns["ORDER_BOOKED_AE"].HeaderText = "ORDER BOOKED FOR AE";
                 dataGridView1.Columns["ORDER_BOOKED_AE"].Width = 250;
                 dataGridView1.Columns["PAYMENT_COLLECTED_AE"].HeaderText = "PAYMENT COLLECTED FOR AE";
                 dataGridView1.Columns["PAYMENT_COLLECTED_AE"].Width = 250;
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.FileName = "Clients`.xlsx";
            saveFileDialog1.Filter = "Excel 2007 files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = false;

            //  If the user hit Cancel, then abort!
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string targetFilename = saveFileDialog1.FileName;


            //  Step 1: Create a DataSet, and put some sample data in it
            DataSet ds = sampledata();

            //  Step 2: Create the Excel file
            try
            {
                //CreateExcelFile.CreateExcelDocument(ds, targetFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create Excel file.\r\nException: " + ex.Message);
                return;
            }

            //  Step 3:  Let's open our new Excel file and shut down this application.
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(targetFilename);
            p.Start();

            this.Close();
        }

        private DataSet sampledata()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bindingSource1.Filter = string.Format("PARTY_NAME LIKE '%{0}%'", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select MARKETING_PERSON_NAME,ENTRY_STATUS, PARTY_NAME, CONTACTED_PERSON, NEXT_CALL_DATE, ORDER_BOOKED_AME, PAYMENT_COLLECTED_AME, ORDER_BOOKED_AE, PAYMENT_COLLECTED_AE from DSR Where   DATE_OF_VISIT >= to_date('" + dateTimePicker1.Text + "') and DATE_OF_VISIT <= to_date('" + dateTimePicker2.Text + "')";
            loaddata(query);
        }

        private void DSRRepotAll_Load(object sender, EventArgs e)
        {
            string query = "select Distinct(MARKETING_PERSON_NAME) from DSR";
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select Product Name");
                return;
            }
            string query = "select MARKETING_PERSON_NAME,ENTRY_STATUS, PARTY_NAME, CONTACTED_PERSON, NEXT_CALL_DATE, ORDER_BOOKED_AME, PAYMENT_COLLECTED_AME, ORDER_BOOKED_AE, PAYMENT_COLLECTED_AE from DSR Where  MARKETING_PERSON_NAME='"+comboBox1.SelectedItem.ToString()+"'";
            loaddata(query);
        }
    }
}
