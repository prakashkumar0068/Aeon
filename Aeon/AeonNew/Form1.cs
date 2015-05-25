using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using Oracle.DataAccess.Client;
using System.Diagnostics;

namespace AeonNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewClientDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientDetails clientDetails = new ClientDetails();
            clientDetails.MdiParent = this;
            clientDetails.Dock = DockStyle.Fill;
            clientDetails.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser createnew =new CreateUser();
            createnew.Show();
        }

        private void changePaaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm3 changepassword=new ChangePasswordForm3();
           
            changepassword.Show();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientEntry cliententry = new ClientEntry();
            cliententry.MdiParent = this;
            cliententry.Dock = DockStyle.Fill;
            cliententry.Show();
        }

        private void manageComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Complaintdetails a = new Complaintdetails();
            //a.Show();
        }

        private void dSRManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlyOutstandingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Month_Report report = new Month_Report();
            report.MdiParent = this;
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void carryforwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarryForward_Report report = new CarryForward_Report();
            report.MdiParent = this;
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void aMCExpiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMC_Expiry_Report report = new AMC_Expiry_Report();
            report.MdiParent = this;
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Complaintdetails_Report report = new Complaintdetails_Report();
            report.MdiParent = this;
            report.Dock = DockStyle.Fill;
            report.Show();
        }

        private void makeNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DSR_MakeEntryOld dSR_MakeEntry = new DSR_MakeEntryOld();
            //dSR_MakeEntry.MdiParent = this;
            //dSR_MakeEntry.Show();
        }

        private void viewMyVisitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSR_DayVisit dSR_DayVisit = new DSR_DayVisit();
            dSR_DayVisit.MdiParent = this;
            dSR_DayVisit.Dock = DockStyle.Fill;
            dSR_DayVisit.Show();
        }

        private void viewMyMonthReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_DSR dSR_DayVisit = new Report_DSR();
            dSR_DayVisit.MdiParent = this;
            dSR_DayVisit.Show();
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //Microsoft.Office.Interop.Excel. Workbook workbook = new Microsoft.Office.Interop.Excel.Workbook();
          //System.Data.DataTable dt = report("select * from USERLOGIN");
          //  workbook.Worksheets[0].InsertDataTable(dt, true, 1, 1);
          //  //dt = GetDataTableFromDB("select * from items");
          //  //workbook.Worksheets[1].InsertDataTable(dt, true, 1, 1);
          //  //dt = GetDataTableFromDB("select * from parts");
          //  //workbook.Worksheets[2].InsertDataTable(dt, true, 1, 1);
          ////  workbook.SaveToFile("sample.xlsx", ExcelVersion.Version2010);
          //  workbook.SaveAs("sample.xls");
          //  System.Diagnostics.Process.Start("sample.xls");
        }
        public System.Data.DataTable report(string command)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand com = new OracleCommand(command);
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataAdapter sdt = new OracleDataAdapter(com);
                System.Data.DataTable ds = new System.Data.DataTable();
                sdt.Fill(ds);
                return ds;
               
            }
            // crystalReportViewer1.Refresh();

        }

        private void viewDsrReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSRRepotAll dsr = new DSRRepotAll();
            dsr.MdiParent = this;
            dsr.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 sd = new Form2();
            sd.MdiParent = this;
            sd.Dock = DockStyle.Fill;
            sd.Show();
        }

        private void dataBaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emaitemplate sd = new Emaitemplate();
            sd.MdiParent = this;
           // sd.Dock = DockStyle.Fill;
            sd.Show();
        }

        private void inventoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void outWardProductFromInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inWardReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InwardReport inward = new InwardReport();
            inward.MdiParent = this;
            // sd.Dock = DockStyle.Fill;
            inward.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OutwardReport outward = new OutwardReport();
            outward.MdiParent = this;
            // sd.Dock = DockStyle.Fill;
            outward.Show();
        }

        private void aDDNewMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentDetails equipment = new EquipmentDetails();
            equipment.MdiParent = this;
             equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Installement equipment = new Installement();
            equipment.MdiParent = this;
            equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void paymentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDetails equipment = new PaymentDetails ();
            equipment.MdiParent = this;
            equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Equpiment_Archive equipment = new Equpiment_Archive();
            equipment.MdiParent = this;
            equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void logComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogComplaint obj = new LogComplaint();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();

        }

        private void resolveComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintResolve obj = new ComplaintResolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();

        }

        private void paymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaymentDetails obj = new PaymentDetails();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void dateWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintReportDateWiseSolve obj = new ComplaintReportDateWiseSolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void engineerWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerWiseSolveReport obj = new EngineerWiseSolveReport();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void notResolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotResolve obj = new NotResolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void resolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resolve obj = new Resolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void engineerWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EngineerWiseSolveReport obj = new EngineerWiseSolveReport();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintReportDateWiseSolve obj = new ComplaintReportDateWiseSolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ADD_Product obj = new ADD_Product();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void updateDSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDSR obj = new UpdateDSR();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void aMCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
