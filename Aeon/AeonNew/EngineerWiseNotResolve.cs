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
    public partial class EngineerWiseNotResolve : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter dataAdapter;
        OracleDataReader dataReader;
        DataTable dataTable;
        public EngineerWiseNotResolve()
        {
            InitializeComponent();
        }

        private void EngineerWiseNotResolve_Load(object sender, EventArgs e)
        {
            cmb_report_type.Text = "Select Engineer Name";
            cmb_report_type.Items.Clear();
            conn = ConnectionManager.getDatabaseConnection();
            cmd = new OracleCommand("select DISTINCT (ENGINEER_SCHEDULE) from ENG_SCHEDULE ", conn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_report_type.Items.Add(dataReader[0].ToString());
            }
            conn.Close();
        }

        private void cmb_report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("select g.ORG_NAME,d.COMPLAINT_ID,d.EQUIP_NAME,d.EQUIP_BRAND,d.DATE_OF_COMPLAINT,d.NATURE_OF_COMPLAINT,d.STATUS  from ENG_SCHEDULE e ,COMPLAINT_TABLE d,CLIENT_DETAILS g  Where  ENGINEER_SCHEDULE='" + cmb_report_type.SelectedItem.ToString() + "' and d.COMPLAINT_ID = e.COMPLAINT_ID and g.ORGANISATION_ID=d.ORGANISATION_ID and d.STATUS = '0'", conn);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Data Not Found");
                bt_generate.Visible = false;
                return;
            }

            Engineer_dataGridView.DataSource = dataTable;
            bt_generate.Visible = true;
            conn.Close();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            
            EngineerWiseNotResolveReport obj = new EngineerWiseNotResolveReport(dataTable,cmb_report_type.SelectedItem.ToString());
            obj.Show();
        }
    }
}
