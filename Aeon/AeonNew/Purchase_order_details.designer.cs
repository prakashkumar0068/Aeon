namespace AeonNew
{
    partial class Purchase_order_details
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchase_order_crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.po_number = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.org_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.purchase_order_crystalReportViewer1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // purchase_order_crystalReportViewer1
            // 
            this.purchase_order_crystalReportViewer1.ActiveViewIndex = -1;
            this.purchase_order_crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchase_order_crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchase_order_crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchase_order_crystalReportViewer1.Location = new System.Drawing.Point(0, 197);
            this.purchase_order_crystalReportViewer1.Name = "purchase_order_crystalReportViewer1";
            this.purchase_order_crystalReportViewer1.Size = new System.Drawing.Size(1212, 279);
            this.purchase_order_crystalReportViewer1.TabIndex = 3;
            this.purchase_order_crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.date);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(663, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 136);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report Date Wise";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(14, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 3;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "SHOW REPORT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.po_number);
            this.groupBox3.Location = new System.Drawing.Point(298, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 155);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report PO Number Wise";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "SHOW REPORT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // po_number
            // 
            this.po_number.FormattingEnabled = true;
            this.po_number.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.po_number.Location = new System.Drawing.Point(14, 54);
            this.po_number.Name = "po_number";
            this.po_number.Size = new System.Drawing.Size(177, 21);
            this.po_number.TabIndex = 0;
            this.po_number.Text = "----Select PO  Number----";
            this.po_number.SelectedIndexChanged += new System.EventHandler(this.po_number_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.org_name);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Organization Wise";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "SHOW REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // org_name
            // 
            this.org_name.FormattingEnabled = true;
            this.org_name.Location = new System.Drawing.Point(14, 30);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(177, 21);
            this.org_name.TabIndex = 0;
            this.org_name.Text = "----Select Organization Name----";
            this.org_name.SelectedIndexChanged += new System.EventHandler(this.org_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Order Report";
            // 
            // Purchase_order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Purchase_order_details";
            this.Text = "Purchase_order_details";
            this.Load += new System.EventHandler(this.Purchase_order_details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox org_name;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer purchase_order_crystalReportViewer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox po_number;
        private System.Windows.Forms.Label label2;
    }
}