namespace AeonNew
{
    partial class ComplaintPaymentDetails
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
            this.dateTimePicker_cheque_dd = new System.Windows.Forms.DateTimePicker();
            this.txt_cheque_dd_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bank_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_cheque_dd = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_payment_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bill_no = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_payment_mode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_cheque_dd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_cheque_dd
            // 
            this.dateTimePicker_cheque_dd.Location = new System.Drawing.Point(228, 84);
            this.dateTimePicker_cheque_dd.Name = "dateTimePicker_cheque_dd";
            this.dateTimePicker_cheque_dd.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker_cheque_dd.TabIndex = 30;
            // 
            // txt_cheque_dd_no
            // 
            this.txt_cheque_dd_no.Location = new System.Drawing.Point(228, 50);
            this.txt_cheque_dd_no.Name = "txt_cheque_dd_no";
            this.txt_cheque_dd_no.Size = new System.Drawing.Size(180, 20);
            this.txt_cheque_dd_no.TabIndex = 23;
            this.txt_cheque_dd_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cheque_dd_no_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bank Name";
            // 
            // txt_bank_name
            // 
            this.txt_bank_name.Location = new System.Drawing.Point(228, 17);
            this.txt_bank_name.Name = "txt_bank_name";
            this.txt_bank_name.Size = new System.Drawing.Size(180, 20);
            this.txt_bank_name.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cheque/DD Date";
            // 
            // groupBox_cheque_dd
            // 
            this.groupBox_cheque_dd.Controls.Add(this.dateTimePicker_cheque_dd);
            this.groupBox_cheque_dd.Controls.Add(this.txt_cheque_dd_no);
            this.groupBox_cheque_dd.Controls.Add(this.label3);
            this.groupBox_cheque_dd.Controls.Add(this.txt_bank_name);
            this.groupBox_cheque_dd.Controls.Add(this.label4);
            this.groupBox_cheque_dd.Controls.Add(this.label5);
            this.groupBox_cheque_dd.Location = new System.Drawing.Point(219, 223);
            this.groupBox_cheque_dd.Name = "groupBox_cheque_dd";
            this.groupBox_cheque_dd.Size = new System.Drawing.Size(433, 115);
            this.groupBox_cheque_dd.TabIndex = 24;
            this.groupBox_cheque_dd.TabStop = false;
            this.groupBox_cheque_dd.Text = "Cheque/DD Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cheque/DD Number";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(363, 18);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(254, 19);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_cancel);
            this.groupBox3.Controls.Add(this.bt_submit);
            this.groupBox3.Location = new System.Drawing.Point(46, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 53);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // dateTimePicker_payment_date
            // 
            this.dateTimePicker_payment_date.Location = new System.Drawing.Point(254, 90);
            this.dateTimePicker_payment_date.Name = "dateTimePicker_payment_date";
            this.dateTimePicker_payment_date.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker_payment_date.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Bill Number";
            // 
            // txt_bill_no
            // 
            this.txt_bill_no.Location = new System.Drawing.Point(254, 124);
            this.txt_bill_no.Name = "txt_bill_no";
            this.txt_bill_no.Size = new System.Drawing.Size(180, 20);
            this.txt_bill_no.TabIndex = 27;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(254, 55);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(180, 20);
            this.txt_amount.TabIndex = 21;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // cmb_payment_mode
            // 
            this.cmb_payment_mode.FormattingEnabled = true;
            this.cmb_payment_mode.Items.AddRange(new object[] {
            "Cash",
            "Cheque/DD",
            "RTGS/NEFT"});
            this.cmb_payment_mode.Location = new System.Drawing.Point(253, 18);
            this.cmb_payment_mode.Name = "cmb_payment_mode";
            this.cmb_payment_mode.Size = new System.Drawing.Size(180, 21);
            this.cmb_payment_mode.TabIndex = 18;
            this.cmb_payment_mode.SelectedIndexChanged += new System.EventHandler(this.cmb_payment_mode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Payment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Payment Mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_payment_date);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_bill_no);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.cmb_payment_mode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 315);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // ComplaintPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 488);
            this.Controls.Add(this.groupBox_cheque_dd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComplaintPaymentDetails";
            this.Text = "Complaint Payment Details";
            this.Load += new System.EventHandler(this.ComplaintPaymentDetails_Load);
            this.groupBox_cheque_dd.ResumeLayout(false);
            this.groupBox_cheque_dd.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_cheque_dd;
        private System.Windows.Forms.TextBox txt_cheque_dd_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bank_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_cheque_dd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_payment_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bill_no;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cmb_payment_mode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}