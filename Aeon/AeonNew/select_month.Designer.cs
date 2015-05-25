namespace AeonNew
{
    partial class select_month
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
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectmonth_crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.todate);
            this.groupBox1.Controls.Add(this.fromdate);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // todate
            // 
            this.todate.Location = new System.Drawing.Point(410, 24);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(179, 20);
            this.todate.TabIndex = 8;
            this.todate.ValueChanged += new System.EventHandler(this.todate_ValueChanged);
            // 
            // fromdate
            // 
            this.fromdate.Location = new System.Drawing.Point(121, 24);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(179, 20);
            this.fromdate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "SHOW REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(834, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(166, 21);
            this.name.TabIndex = 4;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SELECT MARKETING PERSON NAME  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TO DATE  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM DATE :";
            // 
            // selectmonth_crystalReportViewer
            // 
            this.selectmonth_crystalReportViewer.ActiveViewIndex = -1;
            this.selectmonth_crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectmonth_crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectmonth_crystalReportViewer.Location = new System.Drawing.Point(17, 164);
            this.selectmonth_crystalReportViewer.Name = "selectmonth_crystalReportViewer";
            this.selectmonth_crystalReportViewer.Size = new System.Drawing.Size(1072, 439);
            this.selectmonth_crystalReportViewer.TabIndex = 4;
            this.selectmonth_crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // select_month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectmonth_crystalReportViewer);
            this.Name = "select_month";
            this.Text = "select_month";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer selectmonth_crystalReportViewer;

    }
}