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
    public partial class NotResolve : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader datareader;
        OracleDataAdapter dataAdapter;
        String s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12;
        public NotResolve()
        {
            InitializeComponent();
        }

        private void NotResolve_Load(object sender, EventArgs e)
        {
            cmb_client.Text = "Select Client Name";
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("Select DISTINCT(ORG_NAME) from CLIENT_DETAILS ", conn);
            datareader = cmd.ExecuteReader();
            while (datareader.Read())
            {
                cmb_client.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
            conn.Clone();
        }

        private void cmb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("select c.EQUIP_NAME, c.EQUIP_BRAND, c.EQUIP_CAPACITY, c.MACHINE_UNDER, c.SERIAL_NUMBER, c.STATUS, c.NATURE_OF_COMPLAINT, c.PERSON_LOG_COMPLAINT, c.DATE_OF_COMPLAINT, c.TIME_OF_COMPLAINT,e.ENGINEER_SCHEDULE from  COMPLAINT_TABLE c, ENG_SCHEDULE e where STATUS = 0 and c.COMPLAINT_ID=e.COMPLAINT_ID and ORGANISATION_ID = (select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME ='" + cmb_client.SelectedItem.ToString() + "' )", conn);
            DataTable datatable = new DataTable();
            dataAdapter.Fill(datatable);
            dataGridView.DataSource = datatable;
            conn.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            s2 = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            s3 = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            s4 = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            s5 = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            s6 = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            s7 = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            s8 = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            s9 = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            s10 = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            s11 = dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            s12 = cmb_client.SelectedItem.ToString();

            NotResolveReport obj = new NotResolveReport(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11 ,s12);

            obj.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
