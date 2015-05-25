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
    public partial class DSR_DayVisit : Form
    {
        public DSR_DayVisit()
        {
            InitializeComponent();
        }

        private void DSR_DayVisit_Load(object sender, EventArgs e)
        {
            NameLabel.Text = LoginForm.Username;
         
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String query = "select * from DSR where MARKETING_PERSON_NAME ='" + NameLabel.Text + "'";

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                OracleCommandBuilder oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                DataTable contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);

             //   BindingSource bindingSource = new BindingSource();
               // bindingSource.DataSource = contactTable;
                dataGridView1.DataSource = contactTable;

                contactTable.Columns["PARTY_NAME"].ColumnName = "PARTY NAME";
                contactTable.Columns[3].ColumnName = "CONTACTED PERSON";
                contactTable.Columns[4].ColumnName = "PHONE NUMBER";
                contactTable.Columns[5].ColumnName = "DATE OF VISIT";
                contactTable.Columns[6].ColumnName = "NEXT CALL DATE";
                contactTable.Columns[7].ColumnName = "ORDER BOOKED AME";
                contactTable.Columns[8].ColumnName = "PAYMENT COLLECTED AME";
                contactTable.Columns[9].ColumnName = "ORDER BOOKED AE";
                contactTable.Columns[10].ColumnName = "PAYMENT COLLECTED AE";
                contactTable.Columns[11].ColumnName = "REMARK";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[12].Visible = false;

                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[11].Width = 200;

                
               // dataGridView1.Columns[7].Width = 150;

                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String query = "select * from DSR where MARKETING_PERSON_NAME ='" + NameLabel.Text + "'";

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                OracleCommandBuilder oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                DataTable contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = contactTable;
                dataGridView1.DataSource = bindingSource;

                contactTable.Columns["PARTY_NAME"].ColumnName = "PARTY NAME";
                contactTable.Columns[3].ColumnName = "CONTACTED PERSON";
                contactTable.Columns[4].ColumnName = "PHONE NUMBER";
                contactTable.Columns[5].ColumnName = "DATE OF VISIT";
                contactTable.Columns[6].ColumnName = "NEXT CALL DATE";
                contactTable.Columns[7].ColumnName = "ORDER BOOKED AME";
                contactTable.Columns[8].ColumnName = "PAYMENT COLLECTED AME";
                contactTable.Columns[9].ColumnName = "ORDER BOOKED AE";
                contactTable.Columns[10].ColumnName = "PAYMENT COLLECTED AE";
                contactTable.Columns[11].ColumnName = "REMARK";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[12].Visible = false;

                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[11].Width = 200;
                // dataGridView1.Columns[7].Width = 150;

                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                String query = "select * from DSR where MARKETING_PERSON_NAME ='" + NameLabel.Text + "' and NEXT_CALL_DATE = '"+ dateTimePicker.Value.ToLongDateString() +"'";

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                OracleCommandBuilder oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                DataTable contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = contactTable;
                dataGridView1.DataSource = bindingSource;

                contactTable.Columns["PARTY_NAME"].ColumnName = "PARTY NAME";
                contactTable.Columns[3].ColumnName = "CONTACTED PERSON";
                contactTable.Columns[4].ColumnName = "PHONE NUMBER";
                contactTable.Columns[5].ColumnName = "DATE OF VISIT";
                contactTable.Columns[6].ColumnName = "NEXT CALL DATE";
                contactTable.Columns[7].ColumnName = "ORDER BOOKED AME";
                contactTable.Columns[8].ColumnName = "PAYMENT COLLECTED AME";
                contactTable.Columns[9].ColumnName = "ORDER BOOKED AE";
                contactTable.Columns[10].ColumnName = "PAYMENT COLLECTED AE";
                contactTable.Columns[11].ColumnName = "REMARK";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[12].Visible = false;

                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[11].Width = 200;
                // dataGridView1.Columns[7].Width = 150;

                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

          
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string id = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();

            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UpdateDSR updatedsr = new UpdateDSR(id);
                updatedsr.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
