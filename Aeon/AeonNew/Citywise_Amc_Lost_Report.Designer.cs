namespace AeonNew
{
    partial class Citywise_Amc_Lost_Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amc_unit_price = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.equipmentname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orgname = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showcity = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.citywise_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.equipmentname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orgname);
            this.groupBox1.Location = new System.Drawing.Point(41, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOR PARTICULAR  CITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
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
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "AMC UNIT PRICE           :";
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
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "      BRAND                     :";
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
            this.label4.Location = new System.Drawing.Point(23, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "          CITY                      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "       TYPE                        :";
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(171, 38);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 21);
            this.city.TabIndex = 5;
            this.city.SelectedIndexChanged += new System.EventHandler(this.city_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(457, 35);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 4;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // equipmentname
            // 
            this.equipmentname.FormattingEnabled = true;
            this.equipmentname.Location = new System.Drawing.Point(171, 136);
            this.equipmentname.Name = "equipmentname";
            this.equipmentname.Size = new System.Drawing.Size(121, 21);
            this.equipmentname.TabIndex = 1;
            this.equipmentname.SelectedIndexChanged += new System.EventHandler(this.equipmentname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "EQUIPMENT NAME        :";
            // 
            // orgname
            // 
            this.orgname.FormattingEnabled = true;
            this.orgname.Location = new System.Drawing.Point(171, 88);
            this.orgname.Name = "orgname";
            this.orgname.Size = new System.Drawing.Size(121, 21);
            this.orgname.TabIndex = 0;
            this.orgname.SelectedIndexChanged += new System.EventHandler(this.orgname_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showcity);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(651, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 202);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALL CITY LOST AMC REPORT";
            // 
            // showcity
            // 
            this.showcity.FormattingEnabled = true;
            this.showcity.Location = new System.Drawing.Point(162, 38);
            this.showcity.Name = "showcity";
            this.showcity.Size = new System.Drawing.Size(121, 21);
            this.showcity.TabIndex = 3;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "CHOOSE  CITY        :";
            // 
            // citywise_crystalReportViewer
            // 
            this.citywise_crystalReportViewer.ActiveViewIndex = -1;
            this.citywise_crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.citywise_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.citywise_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.citywise_crystalReportViewer.Location = new System.Drawing.Point(41, 271);
            this.citywise_crystalReportViewer.Name = "citywise_crystalReportViewer";
            this.citywise_crystalReportViewer.Size = new System.Drawing.Size(912, 208);
            this.citywise_crystalReportViewer.TabIndex = 4;
            this.citywise_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Citywise_Amc_Lost_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 505);
            this.Controls.Add(this.citywise_crystalReportViewer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Citywise_Amc_Lost_Report";
            this.Text = "Citywise_Amc_Lost_Report";
            this.Load += new System.EventHandler(this.Citywise_Amc_Lost_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox amc_unit_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox equipmentname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orgname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer citywise_crystalReportViewer;
        private System.Windows.Forms.ComboBox showcity;
    }
}