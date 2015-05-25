namespace AeonNew
{
    partial class OutwardReport
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.brand = new System.Windows.Forms.ComboBox();
            this.modal = new System.Windows.Forms.ComboBox();
            this.capacity = new System.Windows.Forms.ComboBox();
            this.productname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outwardcrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.brand);
            this.groupBox2.Controls.Add(this.modal);
            this.groupBox2.Controls.Add(this.capacity);
            this.groupBox2.Controls.Add(this.productname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.todate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fromdate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 186);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHOW PRODUCT BETWEEN DATE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(335, 88);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(121, 21);
            this.brand.TabIndex = 15;
            this.brand.Text = "BRAND";
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // modal
            // 
            this.modal.FormattingEnabled = true;
            this.modal.Location = new System.Drawing.Point(60, 142);
            this.modal.Name = "modal";
            this.modal.Size = new System.Drawing.Size(121, 21);
            this.modal.TabIndex = 16;
            this.modal.Text = "MODAL";
            this.modal.SelectedIndexChanged += new System.EventHandler(this.modal_SelectedIndexChanged);
            // 
            // capacity
            // 
            this.capacity.FormattingEnabled = true;
            this.capacity.Location = new System.Drawing.Point(335, 142);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(121, 21);
            this.capacity.TabIndex = 17;
            this.capacity.Text = "CAPACITY";
            this.capacity.SelectedIndexChanged += new System.EventHandler(this.capacity_SelectedIndexChanged);
            // 
            // productname
            // 
            this.productname.FormattingEnabled = true;
            this.productname.Location = new System.Drawing.Point(60, 88);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(121, 21);
            this.productname.TabIndex = 14;
            this.productname.Text = "PRODUCT NAME";
            this.productname.SelectedIndexChanged += new System.EventHandler(this.productname_SelectedIndexChanged);
            this.productname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productname_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(335, 39);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(199, 20);
            this.todate.TabIndex = 8;
            this.todate.ValueChanged += new System.EventHandler(this.todate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FROM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(60, 42);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(199, 20);
            this.fromdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(687, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 180);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHOW PRODUCT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "SHOW ALL OUTWARD DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outwardcrystalReportViewer
            // 
            this.outwardcrystalReportViewer.ActiveViewIndex = -1;
            this.outwardcrystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outwardcrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outwardcrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.outwardcrystalReportViewer.DisplayStatusBar = false;
            this.outwardcrystalReportViewer.DisplayToolbar = false;
            this.outwardcrystalReportViewer.Location = new System.Drawing.Point(12, 216);
            this.outwardcrystalReportViewer.Name = "outwardcrystalReportViewer";
            this.outwardcrystalReportViewer.Size = new System.Drawing.Size(1050, 290);
            this.outwardcrystalReportViewer.TabIndex = 22;
            this.outwardcrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.outwardcrystalReportViewer.Load += new System.EventHandler(this.outwardcrystalReportViewer_Load);
            // 
            // OutwardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 518);
            this.Controls.Add(this.outwardcrystalReportViewer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "OutwardReport";
            this.Text = "OutwardReport";
            this.Load += new System.EventHandler(this.OutwardReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.ComboBox modal;
        private System.Windows.Forms.ComboBox capacity;
        private System.Windows.Forms.ComboBox productname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer outwardcrystalReportViewer;
    }
}