namespace AeonNew
{
    partial class EngineerWiseNotResolve
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
            this.cmb_report_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Engineer_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_generate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engineer_dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_report_type
            // 
            this.cmb_report_type.FormattingEnabled = true;
            this.cmb_report_type.Location = new System.Drawing.Point(352, 19);
            this.cmb_report_type.Name = "cmb_report_type";
            this.cmb_report_type.Size = new System.Drawing.Size(181, 21);
            this.cmb_report_type.TabIndex = 5;
            this.cmb_report_type.SelectedIndexChanged += new System.EventHandler(this.cmb_report_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Engineers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Engineer_dataGridView);
            this.groupBox1.Controls.Add(this.cmb_report_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 391);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Engineer Wise Report";
            // 
            // Engineer_dataGridView
            // 
            this.Engineer_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Engineer_dataGridView.Location = new System.Drawing.Point(40, 60);
            this.Engineer_dataGridView.Name = "Engineer_dataGridView";
            this.Engineer_dataGridView.Size = new System.Drawing.Size(872, 284);
            this.Engineer_dataGridView.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_close);
            this.groupBox2.Controls.Add(this.bt_generate);
            this.groupBox2.Location = new System.Drawing.Point(16, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 65);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(555, 27);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(430, 27);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(103, 23);
            this.bt_generate.TabIndex = 2;
            this.bt_generate.Text = "Generate Report";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // EngineerWiseNotResolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "EngineerWiseNotResolve";
            this.Text = "EngineerWiseNotResolve";
            this.Load += new System.EventHandler(this.EngineerWiseNotResolve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Engineer_dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_report_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Engineer_dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_generate;
    }
}