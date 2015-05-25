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
    public partial class DateWiseNotSolve : Form
    {
        String from_date, to_date;
        OracleConnection conn;
        OracleDataAdapter dataAdatpter;
        String s1, s2, s3, s4, s5, s6, s7, s8, s9;
        public DateWiseNotSolve()
        {
            InitializeComponent();
        }

       
        private void bt_generate_report_Click(object sender, EventArgs e)
        {
            from_date = form_dateTimePicker.Value.Day.ToString() + "/" + form_dateTimePicker.Value.Month.ToString() + "/" + form_dateTimePicker.Value.Year.ToString();
            to_date = to_dateTimePicker.Value.Day.ToString() + "/" + to_dateTimePicker.Value.Month.ToString() + "/" + to_dateTimePicker.Value.Year.ToString();

            conn = ConnectionManager.getDatabaseConnection();
            dataAdatpter = new OracleDataAdapter("select g.ORG_NAME,d.COMPLAINT_ID,d.PERSON_LOG_COMPLAINT,d.EQUIP_NAME,d.EQUIP_BRAND,d.DATE_OF_COMPLAINT,d.NATURE_OF_COMPLAINT, e.ENGINEER_SCHEDULE from ENG_SCHEDULE e ,COMPLAINT_TABLE d,CLIENT_DETAILS g  Where  d.DATE_OF_COMPLAINT between to_date('" + from_date + "','DD/MM/YYYY') and to_date('" + to_date + "','DD/MM/YYYY') and d.COMPLAINT_ID = e.COMPLAINT_ID  and g.ORGANISATION_ID = d.ORGANISATION_ID and d.STATUS = '0'", conn);
            DataTable datatable = new DataTable();
           
            dataAdatpter.Fill(datatable);
            if (datatable.Rows.Count == 0)
            {
                MessageBox.Show("Data Not Found");
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
