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
    public partial class expirydetailamc : Form
    {       string command="";
        public expirydetailamc()
        {
            InitializeComponent();
        }
        public void details()
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand com = new OracleCommand(command);
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataAdapter sdt = new OracleDataAdapter(com);
                DataTable ds = new DataTable();
                ds.Columns.Add("ORGANISATION_ID");
                ds.Columns.Add("EQUIPMENT_NAME");
                ds.Columns.Add("INSTALLATION_DATE");
                ds.Columns.Add("CAPASITY");
                ds.Columns.Add("AMC_UNIT_PRICE");
               

                
            }
        }
    }
}
