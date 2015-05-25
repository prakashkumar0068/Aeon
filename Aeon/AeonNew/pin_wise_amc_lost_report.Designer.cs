namespace AeonNew
{
    partial class pin_wise_amc_lost_report
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
            this.button1 = new System.Windows.Forms.Button();
            this.pin = new System.Windows.Forms.ComboBox();
            this.pinwise_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pin);
            this.groupBox1.Location = new System.Drawing.Point(505, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SHOW AMC REPORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pin
            // 
            this.pin.FormattingEnabled = true;
            this.pin.Location = new System.Drawing.Point(36, 57);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(135, 21);
            this.pin.TabIndex = 0;
            this.pin.Text = "-----CHOOSE PIN-----";
            this.pin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pinwise_crystalReportViewer
            // 
            this.pinwise_crystalReportViewer.ActiveViewIndex = -1;
            this.pinwise_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinwise_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.pinwise_crystalReportViewer.Location = new System.Drawing.Point(24, 192);
            this.pinwise_crystalReportViewer.Name = "pinwise_crystalReportViewer";
            this.pinwise_crystalReportViewer.Size = new System.Drawing.Size(946, 324);
            this.pinwise_crystalReportViewer.TabIndex = 1;
            this.pinwise_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Location = new System.Drawing.Point(24, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHOW AMC REPORT";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SHOW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // state
            // 
            this.state.FormattingEnabled = true;
            this.state.Location = new System.Drawing.Point(32, 55);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(148, 21);
            this.state.TabIndex = 0;
            this.state.Text = "-----CHOOSE STATE-----";
            // 
            // pin_wise_amc_lost_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pinwise_crystalReportViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "pin_wise_amc_lost_report";
            this.Text = "pin_wise_amc_lost_report";
            this.Load += new System.EventHandler(this.pin_wise_amc_lost_report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox pin;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer pinwise_crystalReportViewer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox state;
    }
}