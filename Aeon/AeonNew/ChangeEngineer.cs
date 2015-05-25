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
    public partial class ChangeEngineer : Form
    {
        private DataTable contactTable = null;
        private OracleCommandBuilder oracleCommandBuilder = null;
        public static int id;
        public static string orgname;
        int complaintid;
        public ChangeEngineer()
        {
            InitializeComponent();
        }

        private void ChangeEngineer_Load(object sender, EventArgs e)
        {
            clientNamelabel.Text = orgname;
            complaintatn();

        }

        public void complaintatn()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                string query = "select * from COMPLAINT_TABLE where ORGANISATION_ID =" + id + " and STATUS='Unresolved'";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(query, con);
                oracleCommandBuilder = new OracleCommandBuilder(oracleDataAdapter);
                contactTable = new DataTable();
                oracleDataAdapter.Fill(contactTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = contactTable;
                complaintgridView.DataSource = bindingSource;
                complaintgridView.Columns[0].Visible = false;
                complaintgridView.RowsDefaultCellStyle.BackColor = Color.Bisque;
                complaintgridView.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                
            }
        }

        private void complaintgridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                previousLabel.Text = contactTable.Rows[e.RowIndex][10].ToString();
                complaintid = Convert.ToInt32(contactTable.Rows[e.RowIndex][1]);
            }
            catch (Exception ed)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="")
            {
                MessageBox.Show("Field is empty");
                return ;
            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand _cmdObjj = con.CreateCommand();
                _cmdObjj.CommandText = "update COMPLAINT_TABLE set ENGINEER_SCHEDULED='"+textBox1.Text+"' Where ORGANISATION_ID=" + id + " and COMPLAINT_ID=" + complaintid + "";
                _cmdObjj.CommandType = CommandType.Text;
                _cmdObjj.Parameters.Clear();
                _cmdObjj.ExecuteNonQuery();
                MessageBox.Show("Records updated successsfully");
                complaintatn();
            }
        }

    }
}
