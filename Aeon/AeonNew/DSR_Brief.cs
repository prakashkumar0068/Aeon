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
    public partial class DSR_Brief : Form
    {
        public DSR_Brief()
        {
            InitializeComponent();
        }

        private void DSR_Brief_Load(object sender, EventArgs e)
        {
            
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand("select distinct MARKETING_PERSON_NAME from DSR", con);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.SelectCommand.CommandText = cmd.CommandText.ToString();
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "MARKETING_PERSON_NAME";
            }
        }

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            string query = "select ENTRY_STATUS, PARTY_NAME, CONTACTED_PERSON, NEXT_CALL_DATE, ORDER_BOOKED_AME, PAYMENT_COLLECTED_AME, ORDER_BOOKED_AE, PAYMENT_COLLECTED_AE from DSR where MARKETING_PERSON_NAME='" + comboBox1.Text + "' and DATE_OF_VISIT = '" + dateTimePicker1.Text + "'";
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleDataAdapter oracleDataAdapter1 = new OracleDataAdapter(query, con);
                OracleCommandBuilder oracleCommandBuilder1 = new OracleCommandBuilder(oracleDataAdapter1);
                DataTable dt = new DataTable();
                oracleDataAdapter1.Fill(dt);

                BindingSource bindingSource1 = new BindingSource();
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["ENTRY_STATUS"].HeaderText = "PAYMENT ANTRY";
                dataGridView1.Columns["ENTRY_STATUS"].Width = 100;
                dataGridView1.Columns["PARTY_NAME"].HeaderText = "PARTY NAME";
                dataGridView1.Columns["PARTY_NAME"].Width = 150;
                dataGridView1.Columns["CONTACTED_PERSON"].HeaderText = "PERSON CONTECTED";
                dataGridView1.Columns["CONTACTED_PERSON"].Width = 150;
                dataGridView1.Columns["NEXT_CALL_DATE"].HeaderText = "NEXT CALL DATE";
                dataGridView1.Columns["NEXT_CALL_DATE"].Width = 100;
                dataGridView1.Columns["ORDER_BOOKED_AME"].HeaderText = "ORDER BOOKED FOR AME";
                dataGridView1.Columns["ORDER_BOOKED_AME"].Width = 150;
                dataGridView1.Columns["PAYMENT_COLLECTED_AME"].HeaderText = "PAYMENT COLLECTED FOR AME";
                dataGridView1.Columns["PAYMENT_COLLECTED_AME"].Width = 150;
                dataGridView1.Columns["ORDER_BOOKED_AE"].HeaderText = "ORDER BOOKED FOR AE";
                dataGridView1.Columns["ORDER_BOOKED_AE"].Width = 150;
                dataGridView1.Columns["PAYMENT_COLLECTED_AE"].HeaderText = "PAYMENT COLLECTED FOR AE";
                dataGridView1.Columns["PAYMENT_COLLECTED_AE"].Width = 150;

                this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == this.dataGridView1.Columns["ENTRY_STATUS"].Index)
            {
                if (e.Value != null)
                {
                    string RepVisits = e.Value.ToString();
                    if (RepVisits == "Not Done")
                    {
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Turquoise;
                        this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

    }
}
