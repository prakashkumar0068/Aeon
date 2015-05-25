namespace AeonNew
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSRManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyVisitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMyMonthReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDSRReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketingPersonReportDateWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPaymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCLostDateWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCLostStatePinWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCLostCityWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCLostProductWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inwardProductToInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardProductFromInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseORderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logComplaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolveComplaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notResolveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.engineerWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.notResolveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notResolveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateComplaintByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.dSRManagementToolStripMenuItem,
            this.aMCToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.complainToolStripMenuItem,
            this.newUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.updateContactToolStripMenuItem});
            this.addNewClientToolStripMenuItem.Image = global::AeonNew.Properties.Resources.add_business_user;
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addNewClientToolStripMenuItem.Text = "Client";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // updateContactToolStripMenuItem
            // 
            this.updateContactToolStripMenuItem.Name = "updateContactToolStripMenuItem";
            this.updateContactToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.updateContactToolStripMenuItem.Text = "Update Contact";
            this.updateContactToolStripMenuItem.Click += new System.EventHandler(this.updateContactToolStripMenuItem_Click);
            // 
            // dSRManagementToolStripMenuItem
            // 
            this.dSRManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewEntryToolStripMenuItem,
            this.viewMyVisitsToolStripMenuItem,
            this.viewMyMonthReportToolStripMenuItem,
            this.viewDSRReportToolStripMenuItem,
            this.marketingPersonReportDateWiseToolStripMenuItem});
            this.dSRManagementToolStripMenuItem.Image = global::AeonNew.Properties.Resources.data_management;
            this.dSRManagementToolStripMenuItem.Name = "dSRManagementToolStripMenuItem";
            this.dSRManagementToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dSRManagementToolStripMenuItem.Text = "DSR Management";
            // 
            // makeNewEntryToolStripMenuItem
            // 
            this.makeNewEntryToolStripMenuItem.Name = "makeNewEntryToolStripMenuItem";
            this.makeNewEntryToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.makeNewEntryToolStripMenuItem.Text = "Make new entry";
            this.makeNewEntryToolStripMenuItem.Click += new System.EventHandler(this.makeNewEntryToolStripMenuItem_Click);
            // 
            // viewMyVisitsToolStripMenuItem
            // 
            this.viewMyVisitsToolStripMenuItem.Name = "viewMyVisitsToolStripMenuItem";
            this.viewMyVisitsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.viewMyVisitsToolStripMenuItem.Text = "View my visits";
            this.viewMyVisitsToolStripMenuItem.Click += new System.EventHandler(this.viewMyVisitsToolStripMenuItem_Click);
            // 
            // viewMyMonthReportToolStripMenuItem
            // 
            this.viewMyMonthReportToolStripMenuItem.Name = "viewMyMonthReportToolStripMenuItem";
            this.viewMyMonthReportToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.viewMyMonthReportToolStripMenuItem.Text = "View my month report";
            this.viewMyMonthReportToolStripMenuItem.Click += new System.EventHandler(this.viewMyMonthReportToolStripMenuItem_Click);
            // 
            // viewDSRReportToolStripMenuItem
            // 
            this.viewDSRReportToolStripMenuItem.Name = "viewDSRReportToolStripMenuItem";
            this.viewDSRReportToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.viewDSRReportToolStripMenuItem.Text = "View DSR Report";
            this.viewDSRReportToolStripMenuItem.Click += new System.EventHandler(this.viewDSRReportToolStripMenuItem_Click);
            // 
            // marketingPersonReportDateWiseToolStripMenuItem
            // 
            this.marketingPersonReportDateWiseToolStripMenuItem.Name = "marketingPersonReportDateWiseToolStripMenuItem";
            this.marketingPersonReportDateWiseToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.marketingPersonReportDateWiseToolStripMenuItem.Text = "Marketing Person report Date Wise";
            this.marketingPersonReportDateWiseToolStripMenuItem.Click += new System.EventHandler(this.marketingPersonReportDateWiseToolStripMenuItem_Click);
            // 
            // aMCToolStripMenuItem
            // 
            this.aMCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMachineToolStripMenuItem,
            this.setPaymentDetailsToolStripMenuItem,
            this.paymentEntryToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.reportToolStripMenuItem2,
            this.paymentHistoryToolStripMenuItem});
            this.aMCToolStripMenuItem.Image = global::AeonNew.Properties.Resources.images;
            this.aMCToolStripMenuItem.Name = "aMCToolStripMenuItem";
            this.aMCToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aMCToolStripMenuItem.Text = "AMC";
            // 
            // addNewMachineToolStripMenuItem
            // 
            this.addNewMachineToolStripMenuItem.Name = "addNewMachineToolStripMenuItem";
            this.addNewMachineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addNewMachineToolStripMenuItem.Text = "Add New Machine";
            this.addNewMachineToolStripMenuItem.Click += new System.EventHandler(this.addNewMachineToolStripMenuItem_Click);
            // 
            // setPaymentDetailsToolStripMenuItem
            // 
            this.setPaymentDetailsToolStripMenuItem.Name = "setPaymentDetailsToolStripMenuItem";
            this.setPaymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.setPaymentDetailsToolStripMenuItem.Text = "Set PaymentDetails";
            this.setPaymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.setPaymentDetailsToolStripMenuItem_Click);
            // 
            // paymentEntryToolStripMenuItem
            // 
            this.paymentEntryToolStripMenuItem.Name = "paymentEntryToolStripMenuItem";
            this.paymentEntryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.paymentEntryToolStripMenuItem.Text = "Payment Entry";
            this.paymentEntryToolStripMenuItem.Click += new System.EventHandler(this.paymentEntryToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem2
            // 
            this.reportToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aMCLostDateWiseToolStripMenuItem,
            this.aMCLostStatePinWiseToolStripMenuItem,
            this.aMCLostCityWiseToolStripMenuItem,
            this.aMCLostProductWiseToolStripMenuItem,
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem});
            this.reportToolStripMenuItem2.Name = "reportToolStripMenuItem2";
            this.reportToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.reportToolStripMenuItem2.Text = "Report";
            // 
            // aMCLostDateWiseToolStripMenuItem
            // 
            this.aMCLostDateWiseToolStripMenuItem.Name = "aMCLostDateWiseToolStripMenuItem";
            this.aMCLostDateWiseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aMCLostDateWiseToolStripMenuItem.Text = "AMC Lost Date Wise";
            this.aMCLostDateWiseToolStripMenuItem.Click += new System.EventHandler(this.aMCLostDateWiseToolStripMenuItem_Click);
            // 
            // aMCLostStatePinWiseToolStripMenuItem
            // 
            this.aMCLostStatePinWiseToolStripMenuItem.Name = "aMCLostStatePinWiseToolStripMenuItem";
            this.aMCLostStatePinWiseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aMCLostStatePinWiseToolStripMenuItem.Text = "AMC Lost State/Pin Wise";
            this.aMCLostStatePinWiseToolStripMenuItem.Click += new System.EventHandler(this.aMCLostStatePinWiseToolStripMenuItem_Click);
            // 
            // aMCLostCityWiseToolStripMenuItem
            // 
            this.aMCLostCityWiseToolStripMenuItem.Name = "aMCLostCityWiseToolStripMenuItem";
            this.aMCLostCityWiseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aMCLostCityWiseToolStripMenuItem.Text = "AMC Lost City Wise";
            this.aMCLostCityWiseToolStripMenuItem.Click += new System.EventHandler(this.aMCLostCityWiseToolStripMenuItem_Click);
            // 
            // aMCLostProductWiseToolStripMenuItem
            // 
            this.aMCLostProductWiseToolStripMenuItem.Name = "aMCLostProductWiseToolStripMenuItem";
            this.aMCLostProductWiseToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aMCLostProductWiseToolStripMenuItem.Text = "AMC Lost Product Wise";
            this.aMCLostProductWiseToolStripMenuItem.Click += new System.EventHandler(this.aMCLostProductWiseToolStripMenuItem_Click);
            // 
            // aMCLOSTORGANIZATIONWISEToolStripMenuItem
            // 
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem.Name = "aMCLOSTORGANIZATIONWISEToolStripMenuItem";
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem.Text = "AMC LOST ORGANIZATION WISE";
            this.aMCLOSTORGANIZATIONWISEToolStripMenuItem.Click += new System.EventHandler(this.aMCLOSTORGANIZATIONWISEToolStripMenuItem_Click);
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            this.paymentHistoryToolStripMenuItem.Click += new System.EventHandler(this.paymentHistoryToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.inwardProductToInventoryToolStripMenuItem,
            this.outwardProductFromInventoryToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.purchaseOrderToolStripMenuItem});
            this.inventoryToolStripMenuItem.Image = global::AeonNew.Properties.Resources.inventory_icon;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory Management";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // inwardProductToInventoryToolStripMenuItem
            // 
            this.inwardProductToInventoryToolStripMenuItem.Name = "inwardProductToInventoryToolStripMenuItem";
            this.inwardProductToInventoryToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.inwardProductToInventoryToolStripMenuItem.Text = "Inward Product To Inventory";
            this.inwardProductToInventoryToolStripMenuItem.Click += new System.EventHandler(this.inwardProductToInventoryToolStripMenuItem_Click);
            // 
            // outwardProductFromInventoryToolStripMenuItem
            // 
            this.outwardProductFromInventoryToolStripMenuItem.Name = "outwardProductFromInventoryToolStripMenuItem";
            this.outwardProductFromInventoryToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.outwardProductFromInventoryToolStripMenuItem.Text = "Outward Product From Inventory";
            this.outwardProductFromInventoryToolStripMenuItem.Click += new System.EventHandler(this.outwardProductFromInventoryToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inwardToolStripMenuItem,
            this.outwardToolStripMenuItem,
            this.quantityToolStripMenuItem,
            this.purchaseORderDetailsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // inwardToolStripMenuItem
            // 
            this.inwardToolStripMenuItem.Name = "inwardToolStripMenuItem";
            this.inwardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.inwardToolStripMenuItem.Text = "Inward";
            this.inwardToolStripMenuItem.Click += new System.EventHandler(this.inwardToolStripMenuItem_Click);
            // 
            // outwardToolStripMenuItem
            // 
            this.outwardToolStripMenuItem.Name = "outwardToolStripMenuItem";
            this.outwardToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.outwardToolStripMenuItem.Text = "Outward";
            this.outwardToolStripMenuItem.Click += new System.EventHandler(this.outwardToolStripMenuItem_Click);
            // 
            // quantityToolStripMenuItem
            // 
            this.quantityToolStripMenuItem.Name = "quantityToolStripMenuItem";
            this.quantityToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.quantityToolStripMenuItem.Text = "Quantity";
            this.quantityToolStripMenuItem.Click += new System.EventHandler(this.quantityToolStripMenuItem_Click);
            // 
            // purchaseORderDetailsToolStripMenuItem
            // 
            this.purchaseORderDetailsToolStripMenuItem.Name = "purchaseORderDetailsToolStripMenuItem";
            this.purchaseORderDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.purchaseORderDetailsToolStripMenuItem.Text = "Purchase_order_details";
            this.purchaseORderDetailsToolStripMenuItem.Click += new System.EventHandler(this.purchaseORderDetailsToolStripMenuItem_Click);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // complainToolStripMenuItem
            // 
            this.complainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logComplaintToolStripMenuItem,
            this.resolveComplaintToolStripMenuItem,
            this.reportToolStripMenuItem1,
            this.updateComplaintByIdToolStripMenuItem});
            this.complainToolStripMenuItem.Image = global::AeonNew.Properties.Resources.stock_photo_a_customer_support_operator_is_bombarded_with_questions_and_complaints_114029803;
            this.complainToolStripMenuItem.Name = "complainToolStripMenuItem";
            this.complainToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.complainToolStripMenuItem.Text = "Complain";
            // 
            // logComplaintToolStripMenuItem
            // 
            this.logComplaintToolStripMenuItem.Name = "logComplaintToolStripMenuItem";
            this.logComplaintToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.logComplaintToolStripMenuItem.Text = "Log Complaint";
            this.logComplaintToolStripMenuItem.Click += new System.EventHandler(this.logComplaintToolStripMenuItem_Click);
            // 
            // resolveComplaintToolStripMenuItem
            // 
            this.resolveComplaintToolStripMenuItem.Name = "resolveComplaintToolStripMenuItem";
            this.resolveComplaintToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.resolveComplaintToolStripMenuItem.Text = "Resolve Complaint";
            this.resolveComplaintToolStripMenuItem.Click += new System.EventHandler(this.resolveComplaintToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateWiseToolStripMenuItem,
            this.engineerWiseToolStripMenuItem,
            this.complaintToolStripMenuItem});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.reportToolStripMenuItem1.Text = "Report";
            // 
            // dateWiseToolStripMenuItem
            // 
            this.dateWiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolveToolStripMenuItem1,
            this.notResolveToolStripMenuItem1});
            this.dateWiseToolStripMenuItem.Name = "dateWiseToolStripMenuItem";
            this.dateWiseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dateWiseToolStripMenuItem.Text = "Date Wise";
            // 
            // resolveToolStripMenuItem1
            // 
            this.resolveToolStripMenuItem1.Name = "resolveToolStripMenuItem1";
            this.resolveToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.resolveToolStripMenuItem1.Text = "Resolve";
            this.resolveToolStripMenuItem1.Click += new System.EventHandler(this.resolveToolStripMenuItem1_Click);
            // 
            // notResolveToolStripMenuItem1
            // 
            this.notResolveToolStripMenuItem1.Name = "notResolveToolStripMenuItem1";
            this.notResolveToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.notResolveToolStripMenuItem1.Text = "Not Resolve";
            this.notResolveToolStripMenuItem1.Click += new System.EventHandler(this.notResolveToolStripMenuItem1_Click);
            // 
            // engineerWiseToolStripMenuItem
            // 
            this.engineerWiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolveToolStripMenuItem2,
            this.notResolveToolStripMenuItem2});
            this.engineerWiseToolStripMenuItem.Name = "engineerWiseToolStripMenuItem";
            this.engineerWiseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.engineerWiseToolStripMenuItem.Text = "Engineer Wise";
            // 
            // resolveToolStripMenuItem2
            // 
            this.resolveToolStripMenuItem2.Name = "resolveToolStripMenuItem2";
            this.resolveToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.resolveToolStripMenuItem2.Text = "Resolve";
            this.resolveToolStripMenuItem2.Click += new System.EventHandler(this.resolveToolStripMenuItem2_Click);
            // 
            // notResolveToolStripMenuItem2
            // 
            this.notResolveToolStripMenuItem2.Name = "notResolveToolStripMenuItem2";
            this.notResolveToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.notResolveToolStripMenuItem2.Text = "Not Resolve";
            this.notResolveToolStripMenuItem2.Click += new System.EventHandler(this.notResolveToolStripMenuItem2_Click);
            // 
            // complaintToolStripMenuItem
            // 
            this.complaintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resolveToolStripMenuItem,
            this.notResolveToolStripMenuItem});
            this.complaintToolStripMenuItem.Name = "complaintToolStripMenuItem";
            this.complaintToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.complaintToolStripMenuItem.Text = "Client Wise";
            // 
            // resolveToolStripMenuItem
            // 
            this.resolveToolStripMenuItem.Name = "resolveToolStripMenuItem";
            this.resolveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.resolveToolStripMenuItem.Text = "Resolve";
            this.resolveToolStripMenuItem.Click += new System.EventHandler(this.resolveToolStripMenuItem_Click);
            // 
            // notResolveToolStripMenuItem
            // 
            this.notResolveToolStripMenuItem.Name = "notResolveToolStripMenuItem";
            this.notResolveToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.notResolveToolStripMenuItem.Text = "Not Resolve";
            this.notResolveToolStripMenuItem.Click += new System.EventHandler(this.notResolveToolStripMenuItem_Click);
            // 
            // updateComplaintByIdToolStripMenuItem
            // 
            this.updateComplaintByIdToolStripMenuItem.Name = "updateComplaintByIdToolStripMenuItem";
            this.updateComplaintByIdToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.updateComplaintByIdToolStripMenuItem.Text = "Update Complaint By Id";
            this.updateComplaintByIdToolStripMenuItem.Click += new System.EventHandler(this.updateComplaintByIdToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Image = global::AeonNew.Properties.Resources.user_add;
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::AeonNew.Properties.Resources.thumb_User_Password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AeonNew.Properties.Resources.aeonLOGO1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 586);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSRManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwardProductToInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outwardProductFromInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logComplaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveComplaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notResolveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem engineerWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem notResolveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem complaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notResolveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPaymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCLostDateWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCLostStatePinWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCLostCityWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCLostProductWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyVisitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMyMonthReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDSRReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMCLOSTORGANIZATIONWISEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketingPersonReportDateWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseORderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateComplaintByIdToolStripMenuItem;
    }
}