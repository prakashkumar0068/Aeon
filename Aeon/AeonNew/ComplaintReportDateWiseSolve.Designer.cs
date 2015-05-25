namespace AeonNew
{
    partial class ComplaintReportDateWiseSolve
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
            this.to_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.form_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_generate_report = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.to_dateTimePicker);
            this.groupBox1.Controls.Add(this.form_dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Date";
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Location = new System.Drawing.Point(606, 30);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.to_dateTimePicker.TabIndex = 7;
            // 
            // form_dateTimePicker
            // 
            this.form_dateTimePicker.Location = new System.Drawing.Point(163, 36);
            this.form_dateTimePicker.Name = "form_dateTimePicker";
            this.form_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.form_dateTimePicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_close);
            this.groupBox2.Controls.Add(this.bt_generate_report);
            this.groupBox2.Location = new System.Drawing.Point(33, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(438, 17);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_generate_report
            // 
            this.bt_generate_report.Location = new System.Drawing.Point(325, 18);
            this.bt_generate_report.Name = "bt_generate_report";
            this.bt_generate_report.Size = new System.Drawing.Size(95, 23);
            this.bt_generate_report.TabIndex = 3;
            this.bt_generate_report.Text = "Show Data";
            this.bt_generate_report.UseVisualStyleBackColor = true;
            this.bt_generate_report.Click += new System.EventHandler(this.bt_generate_report_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(826, 325);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // ComplaintReportDateWiseSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Name = "ComplaintReportDateWiseSolve";
            this.Text = "ComplaintReportDateWise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.DateTimePicker form_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_generate_report;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}