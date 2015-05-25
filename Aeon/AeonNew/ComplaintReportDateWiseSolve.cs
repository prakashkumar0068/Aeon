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
    public partial class ComplaintReportDateWiseSolve : Form
    {
        String from_date, to_date;
        OracleConnection conn;
        OracleDataAdapter dataAdatpter;
        String s1, s2, s3, s4, s5, s6, s7, s8, s9,s10;
        public ComplaintReportDateWiseSolve()
        {
            InitializeComponent();
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
            GenerateDateReport obj = new GenerateDateReport(s1, s2, s3, s4, s5, s6, s7, s8, s9,s10);
            obj.Show();
        }

        private void bt_generate_report_Click(object sender, EventArgs e)
        {
            from_date = form_dateTimePicker.Value.Day.ToString() + "/" + form_dateTimePicker.Value.Month.ToString() + "/" + form_dateTimePicker.Value.Year.ToString();
            to_date = to_dateTimePicker.Value.Day.ToString() + "/" + to_dateTimePicker.Value.Month.ToString() + "/" + to_dateTimePicker.Value.Year.ToString();

            conn =ConnectionManager.getDatabaseConnection();
            dataAdatpter = new OracleDataAdapter("select g.ORG_NAME,d.COMPLAINT_ID,d.EQUIP_NAME,d.EQUIP_BRAND,d.DATE_OF_COMPLAINT,d.NATURE_OF_COMPLAINT,c.CLOSING_DATE , c.CLOSING_TIME ,c.FAULT_REPORTED , c.ACTION_TAKEN from COMPLAINTCLOSINGDETAILS c , ENG_SCHEDULE e ,COMPLAINT_TABLE d,CLIENT_DETAILS g  Where  d.DATE_OF_COMPLAINT between to_date('" + from_date + "','DD/MM/YYYY') and to_date('" + to_date + "','DD/MM/YYYY') and  c.COMPLAINT_ID = e.COMPLAINT_ID and c.COMPLAINT_ID = d.COMPLAINT_ID and d.COMPLAINT_ID = e.COMPLAINT_ID  and g.ORGANISATION_ID=d.ORGANISATION_ID and d.STATUS = '1'", conn);
            DataTable datatable = new DataTable();

            dataAdatpter.Fill(datatable);
            if(datatable.Rows.Count == 0)
            {
                MessageBox.Show("Data Not Found Select Another Dates");
                return;
            }
            dataGridView.DataSource = datatable;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
