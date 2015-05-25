namespace AeonNew
{
    partial class ProductName_Wise_AMC_LostReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductNameWisecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT PRODUCT NAME   :";
            // 
            // productname
            // 
            this.productname.FormattingEnabled = true;
            this.productname.Location = new System.Drawing.Point(289, 34);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(121, 21);
            this.productname.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productname);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE PRODUCT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductNameWisecrystalReportViewer
            // 
            this.ProductNameWisecrystalReportViewer.ActiveViewIndex = -1;
            this.ProductNameWisecrystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductNameWisecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameWisecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductNameWisecrystalReportViewer.Location = new System.Drawing.Point(21, 134);
            this.ProductNameWisecrystalReportViewer.Name = "ProductNameWisecrystalReportViewer";
            this.ProductNameWisecrystalReportViewer.Size = new System.Drawing.Size(728, 324);
            this.ProductNameWisecrystalReportViewer.TabIndex = 5;
            this.ProductNameWisecrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ProductName_Wise_AMC_LostReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProductNameWisecrystalReportViewer);
            this.Name = "ProductName_Wise_AMC_LostReport";
            this.Text = "ProductName_Wise_AMC_LostReport";
            this.Load += new System.EventHandler(this.ProductName_Wise_AMC_LostReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductNameWisecrystalReportViewer;
    }
}