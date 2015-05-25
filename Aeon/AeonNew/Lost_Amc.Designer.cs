namespace AeonNew
{
    partial class Lost_Amc
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amc_unit_price = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.capacity = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orgname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.equipmentname = new System.Windows.Forms.ComboBox();
            this.lost_amc_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "LIST AMC REPORT FORM";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "LIST OF LOST AMC    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ORGANIZATION NAME  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "AMC UNIT PRICE       :";
            // 
            // amc_unit_price
            // 
            this.amc_unit_price.FormattingEnabled = true;
            this.amc_unit_price.Location = new System.Drawing.Point(457, 136);
            this.amc_unit_price.Name = "amc_unit_price";
            this.amc_unit_price.Size = new System.Drawing.Size(121, 21);
            this.amc_unit_price.TabIndex = 10;
            this.amc_unit_price.SelectedIndexChanged += new System.EventHandler(this.amc_unit_price_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "      BRAND                   :";
            // 
            // brand
            // 
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(457, 88);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(121, 21);
            this.brand.TabIndex = 8;
            this.brand.SelectedIndexChanged += new System.EventHandler(this.brand_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "      CAPACITY                :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "       TYPE                        :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW LIST AMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.end_date);
            this.groupBox2.Location = new System.Drawing.Point(603, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 199);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALL LOST AMC REPORT";
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(170, 35);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 20);
            this.end_date.TabIndex = 0;
            // 
            // capacity
            // 
            this.capacity.FormattingEnabled = true;
            this.capacity.Location = new System.Drawing.Point(454, 41);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(121, 21);
            this.capacity.TabIndex = 5;
            this.capacity.SelectedIndexChanged += new System.EventHandler(this.capacity_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(171, 136);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 4;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EQUIPMENT NAME        :";
            // 
            // orgname
            // 
            this.orgname.FormattingEnabled = true;
            this.orgname.Location = new System.Drawing.Point(171, 38);
            this.orgname.Name = "orgname";
            this.orgname.Size = new System.Drawing.Size(121, 21);
            this.orgname.TabIndex = 0;
            this.orgname.SelectedIndexChanged += new System.EventHandler(this.orgname_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.amc_unit_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.brand);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.capacity);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.equipmentname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orgname);
            this.groupBox1.Location = new System.Drawing.Point(-3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOR PARTICULAR ORGANIZATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // equipmentname
            // 
            this.equipmentname.FormattingEnabled = true;
            this.equipmentname.Location = new System.Drawing.Point(171, 85);
            this.equipmentname.Name = "equipmentname";
            this.equipmentname.Size = new System.Drawing.Size(121, 21);
            this.equipmentname.TabIndex = 1;
            this.equipmentname.SelectedIndexChanged += new System.EventHandler(this.equipmentname_SelectedIndexChanged);
            // 
            // lost_amc_crystalReportViewer
            // 
            this.lost_amc_crystalReportViewer.ActiveViewIndex = -1;
            this.lost_amc_crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lost_amc_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lost_amc_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lost_amc_crystalReportViewer.DisplayStatusBar = false;
            this.lost_amc_crystalReportViewer.DisplayToolbar = false;
            this.lost_amc_crystalReportViewer.Location = new System.Drawing.Point(-3, 269);
            this.lost_amc_crystalReportViewer.MaximumSize = new System.Drawing.Size(1013, 250);
            this.lost_amc_crystalReportViewer.MinimumSize = new System.Drawing.Size(1013, 250);
            this.lost_amc_crystalReportViewer.Name = "lost_amc_crystalReportViewer";
            this.lost_amc_crystalReportViewer.Size = new System.Drawing.Size(1013, 250);
            this.lost_amc_crystalReportViewer.TabIndex = 8;
            this.lost_amc_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 40);
            this.panel1.TabIndex = 19;
            // 
            // Lost_Amc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lost_amc_crystalReportViewer);
            this.Name = "Lost_Amc";
            this.Text = "Lost_Amc";
            this.Load += new System.EventHandler(this.Lost_Amc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox amc_unit_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.ComboBox capacity;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orgname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox equipmentname;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer lost_amc_crystalReportViewer;
        private System.Windows.Forms.Panel panel1;

    }
}