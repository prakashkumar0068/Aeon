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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void logComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewComplainLog obj = new NewComplainLog();
            obj.MdiParent = this;
            ////obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void resolveComplaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintResolve obj = new ComplaintResolve();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void resolveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ComplaintReportDateWiseSolve obj = new ComplaintReportDateWiseSolve();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void resolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resolve obj = new Resolve();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void notResolveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotResolve obj = new NotResolve();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void resolveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EngineerWiseSolveReport obj = new EngineerWiseSolveReport();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void inwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InwardReport inward = new InwardReport();
            inward.MdiParent = this;
            //sd.Dock = DockStyle.Fill;
            inward.Show();
        }

        private void outwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutwardReport outward = new OutwardReport();
            outward.MdiParent = this;
            //sd.Dock = DockStyle.Fill;
            outward.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Product obj = new ADD_Product();
            obj.MdiParent = this;
            //obj.Dock = DockStyle.Fill;
         
            obj.Show();
           
          
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equpiment_Archive equipment = new Equpiment_Archive();
            equipment.MdiParent = this;
            //equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void paymentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDetails equipment = new PaymentDetails();
            equipment.MdiParent = this;
            equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void setPaymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Installement equipment = new Installement();
            equipment.MdiParent = this;
            //equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void addNewMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentDetails equipment = new EquipmentDetails();
            equipment.MdiParent = this;
            equipment.Dock = DockStyle.Fill;
            equipment.Show();
        }

        private void inwardProductToInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inward obj = new Inward();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void outwardProductFromInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutWard_Product obj = new OutWard_Product();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void quantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quantity obj = new Quantity();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void makeNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSR_MakeEntry dSR_MakeEntry = new DSR_MakeEntry();
            dSR_MakeEntry.MdiParent = this;
            dSR_MakeEntry.Show();
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

        private void viewDSRReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSRRepotAll dsr = new DSRRepotAll();
            dsr.MdiParent = this;
            dsr.Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientEntry cliententry = new ClientEntry();
            cliententry.MdiParent = this;
            cliententry.Dock = DockStyle.Fill;
            cliententry.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateUser createnew = new CreateUser();
            createnew.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangePasswordForm3 changepassword = new ChangePasswordForm3();

            changepassword.Show();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClientDetails obj = new UpdateClientDetails();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentDescription obj = new PaymentDescription();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void aMCLostStatePinWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pin_wise_amc_lost_report obj = new pin_wise_amc_lost_report();
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

        private void aMCLostCityWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citywise_Amc_Lost_Report obj = new Citywise_Amc_Lost_Report();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();

        }

        private void aMCLostProductWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductName_Wise_AMC_LostReport obj = new ProductName_Wise_AMC_LostReport();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();


        }

        private void aMCLostDateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMC_Expiry_Report obj = new AMC_Expiry_Report();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();


        }

        private void aMCLOSTORGANIZATIONWISEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lost_Amc obj = new Lost_Amc();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();


        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder obj = new PurchaseOrder();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void notResolveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DateWiseNotSolve obj = new DateWiseNotSolve();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
           
            obj.Show();
        }

        private void notResolveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EngineerWiseNotResolve obj = new EngineerWiseNotResolve();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void marketingPersonReportDateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            select_month obj = new select_month();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContactDetails obj = new NewContactDetails();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           //LoginForm obj = new LoginForm();
           // obj.Show();
        }

        private void purchaseORderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_order_details obj = new Purchase_order_details();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateComplaintByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_complain_by_id obj = new update_complain_by_id();
            obj.Dock = DockStyle.Fill;
            obj.MdiParent = this;
            obj.Show();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
