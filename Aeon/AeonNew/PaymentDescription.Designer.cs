namespace AeonNew
{
    partial class PaymentDescription
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
            this.cmb_serial_no = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_serial_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_client);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmb_serial_no
            // 
            this.cmb_serial_no.FormattingEnabled = true;
            this.cmb_serial_no.Location = new System.Drawing.Point(412, 46);
            this.cmb_serial_no.Name = "cmb_serial_no";
            this.cmb_serial_no.Size = new System.Drawing.Size(221, 21);
            this.cmb_serial_no.TabIndex = 3;
            this.cmb_serial_no.SelectedIndexChanged += new System.EventHandler(this.cmb_serial_no_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial No";
            // 
            // cmb_client
            // 
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(412, 15);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(221, 21);
            this.cmb_client.TabIndex = 1;
            this.cmb_client.SelectedIndexChanged += new System.EventHandler(this.cmb_client_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(9, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(947, 342);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_close);
            this.groupBox3.Controls.Add(this.bt_show);
            this.groupBox3.Location = new System.Drawing.Point(8, 463);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(953, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(459, 15);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(363, 15);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 0;
            this.bt_show.Text = "Show";
            this.bt_show.UseVisualStyleBackColor = true;
         
            // 
            // PaymentDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentDescription";
            this.Text = "Payment Description";
            this.Load += new System.EventHandler(this.PaymentDescription_Load);
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
        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmb_serial_no;
        private System.Windows.Forms.Label label2;
    }
}