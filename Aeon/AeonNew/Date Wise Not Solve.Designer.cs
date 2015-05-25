namespace AeonNew
{
    partial class DateWiseNotSolve
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_generate_report = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.to_dateTimePicker);
            this.groupBox1.Controls.Add(this.form_dateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Date";
            // 
            // to_dateTimePicker
            // 
            this.to_dateTimePicker.Location = new System.Drawing.Point(618, 16);
            this.to_dateTimePicker.Name = "to_dateTimePicker";
            this.to_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.to_dateTimePicker.TabIndex = 11;
            // 
            // form_dateTimePicker
            // 
            this.form_dateTimePicker.Location = new System.Drawing.Point(220, 16);
            this.form_dateTimePicker.Name = "form_dateTimePicker";
            this.form_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.form_dateTimePicker.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(879, 365);
            this.dataGridView.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_generate_report);
            this.groupBox3.Controls.Add(this.bt_close);
            this.groupBox3.Location = new System.Drawing.Point(12, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // bt_generate_report
            // 
            this.bt_generate_report.Location = new System.Drawing.Point(385, 16);
            this.bt_generate_report.Name = "bt_generate_report";
            this.bt_generate_report.Size = new System.Drawing.Size(95, 23);
            this.bt_generate_report.TabIndex = 4;
            this.bt_generate_report.Text = "Show Data";
            this.bt_generate_report.UseVisualStyleBackColor = true;
            this.bt_generate_report.Click += new System.EventHandler(this.bt_generate_report_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(486, 16);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // DateWiseNotSolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateWiseNotSolve";
            this.Text = "Date_WiseNotSolve";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DateTimePicker to_dateTimePicker;
        private System.Windows.Forms.DateTimePicker form_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bt_generate_report;
    }
}