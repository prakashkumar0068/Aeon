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
    public partial class EngineerWiseSolveReport : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataAdapter dataAdapter;
        OracleDataReader dataReader;
        String s1, s2, s3, s4, s5, s6, s7, s8, s9;
        public EngineerWiseSolveReport()
        {
            InitializeComponent();
        }

        private void EngineerWiseReportForm_Load(object sender, EventArgs e)
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
            conn =ConnectionManager.getDatabaseConnection();
            dataAdapter = new OracleDataAdapter("select d.EQUIP_NAME,d.EQUIP_BRAND,d.DATE_OF_COMPLAINT,d.NATURE_OF_COMPLAINT,c.CLOSING_DATE , c.CLOSING_TIME ,c.FAULT_REPORTED , c.ACTION_TAKEN, g.ORG_NAME  from COMPLAINTCLOSINGDETAILS c , ENG_SCHEDULE e ,COMPLAINT_TABLE d,CLIENT_DETAILS g  Where  ENGINEER_SCHEDULE='" + cmb_report_type.SelectedItem.ToString() + "' and  c.COMPLAINT_ID = e.COMPLAINT_ID and c.COMPLAINT_ID = d.COMPLAINT_ID and d.COMPLAINT_ID = e.COMPLAINT_ID and g.ORGANISATION_ID=d.ORGANISATION_ID", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            Engineer_dataGridView.DataSource = dataTable;

            conn.Close();
        }

        private void Engineer_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = Engineer_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            s2 = Engineer_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            s3 = Engineer_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            s4 = Engineer_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            s5 = Engineer_dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            s6 = Engineer_dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            s7 = Engineer_dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            s8 = Engineer_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            s9 = Engineer_dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            GenerateEngineerReport obj = new GenerateEngineerReport(s1, s2, s3, s4, s5, s6, s7, s8, s9);
            obj.Show();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;

                xlApp = new Microsoft.Office.Interop.Excel.Application();

             xlWorkBook = xlApp.Workbooks.Add(misValue);

             xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int i = 0;    
            int j = 0; 

                for (i = 0; i <= Engineer_dataGridView.RowCount  - 1; i++)    
                 {    
                for (j = 0; j <= Engineer_dataGridView.ColumnCount  - 1; j++)    
                {    
                 DataGridViewCell cell = Engineer_dataGridView[j, i];

             xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
             }    
            }


                xlWorkBook.SaveAs(@"d:Engineers Resolve Complains.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
         xlWorkBook.Close(true, misValue, misValue);

         xlApp.Quit();


        releaseObject(xlWorkSheet);    
        releaseObject(xlWorkBook);    
        releaseObject(xlApp);

        MessageBox.Show("Excel file created , you can find the file d:Engineers Resolve Complains.xls");



        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);

                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;

                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
