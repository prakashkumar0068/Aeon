namespace AeonNew
{
    partial class PaymentDetails
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
            this.dateTimePicker_payment_date = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.cmb_payment_mode = new System.Windows.Forms.ComboBox();
            this.cmb_serial_no = new System.Windows.Forms.ComboBox();
            this.txt_interval = new System.Windows.Forms.TextBox();
            this.txt_amc_amount = new System.Windows.Forms.TextBox();
            this.txt_total_submited_amount = new System.Windows.Forms.TextBox();
            this.txt_install_amount = new System.Windows.Forms.TextBox();
            this.txt_due_install = new System.Windows.Forms.TextBox();
            this.txt_paid_install = new System.Windows.Forms.TextBox();
            this.txt_total_due_amount = new System.Windows.Forms.TextBox();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_install = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.dateTimePicker_next_installement = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_adjust = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox_cheque_dd = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_cheque_dd = new System.Windows.Forms.DateTimePicker();
            this.txt_cheque_dd_no = new System.Windows.Forms.TextBox();
            this.lb_bank = new System.Windows.Forms.Label();
            this.txt_bank_name = new System.Windows.Forms.TextBox();
            this.lb_dd_cheque_neft_no = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_cheque_dd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_payment_date
            // 
            this.dateTimePicker_payment_date.Location = new System.Drawing.Point(148, 244);
            this.dateTimePicker_payment_date.Name = "dateTimePicker_payment_date";
            this.dateTimePicker_payment_date.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker_payment_date.TabIndex = 13;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(148, 213);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(214, 21);
            this.txt_amount.TabIndex = 11;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // cmb_payment_mode
            // 
            this.cmb_payment_mode.FormattingEnabled = true;
            this.cmb_payment_mode.Items.AddRange(new object[] {
            "Cash",
            "Cheque/DD",
            "RTGS/NEFT"});
            this.cmb_payment_mode.Location = new System.Drawing.Point(148, 180);
            this.cmb_payment_mode.Name = "cmb_payment_mode";
            this.cmb_payment_mode.Size = new System.Drawing.Size(214, 23);
            this.cmb_payment_mode.TabIndex = 10;
            this.cmb_payment_mode.SelectedIndexChanged += new System.EventHandler(this.cmb_payment_mode_SelectedIndexChanged);
            // 
            // cmb_serial_no
            // 
            this.cmb_serial_no.FormattingEnabled = true;
            this.cmb_serial_no.Location = new System.Drawing.Point(148, 147);
            this.cmb_serial_no.Name = "cmb_serial_no";
            this.cmb_serial_no.Size = new System.Drawing.Size(214, 23);
            this.cmb_serial_no.TabIndex = 9;
            this.cmb_serial_no.SelectedIndexChanged += new System.EventHandler(this.cmb_serial_no_SelectedIndexChanged);
            // 
            // txt_interval
            // 
            this.txt_interval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interval.Location = new System.Drawing.Point(878, 37);
            this.txt_interval.Name = "txt_interval";
            this.txt_interval.Size = new System.Drawing.Size(107, 21);
            this.txt_interval.TabIndex = 20;
            // 
            // txt_amc_amount
            // 
            this.txt_amc_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_amc_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amc_amount.Location = new System.Drawing.Point(878, 182);
            this.txt_amc_amount.Name = "txt_amc_amount";
            this.txt_amc_amount.Size = new System.Drawing.Size(107, 21);
            this.txt_amc_amount.TabIndex = 19;
            // 
            // txt_total_submited_amount
            // 
            this.txt_total_submited_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_total_submited_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_submited_amount.Location = new System.Drawing.Point(878, 212);
            this.txt_total_submited_amount.Name = "txt_total_submited_amount";
            this.txt_total_submited_amount.Size = new System.Drawing.Size(107, 21);
            this.txt_total_submited_amount.TabIndex = 17;
            // 
            // txt_install_amount
            // 
            this.txt_install_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_install_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_install_amount.Location = new System.Drawing.Point(878, 151);
            this.txt_install_amount.Name = "txt_install_amount";
            this.txt_install_amount.Size = new System.Drawing.Size(107, 21);
            this.txt_install_amount.TabIndex = 16;
            // 
            // txt_due_install
            // 
            this.txt_due_install.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_due_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_due_install.Location = new System.Drawing.Point(878, 93);
            this.txt_due_install.Name = "txt_due_install";
            this.txt_due_install.Size = new System.Drawing.Size(107, 21);
            this.txt_due_install.TabIndex = 15;
            // 
            // txt_paid_install
            // 
            this.txt_paid_install.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_paid_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid_install.Location = new System.Drawing.Point(878, 122);
            this.txt_paid_install.Name = "txt_paid_install";
            this.txt_paid_install.Size = new System.Drawing.Size(107, 21);
            this.txt_paid_install.TabIndex = 14;
            // 
            // txt_total_due_amount
            // 
            this.txt_total_due_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_total_due_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_due_amount.Location = new System.Drawing.Point(878, 242);
            this.txt_total_due_amount.Name = "txt_total_due_amount";
            this.txt_total_due_amount.Size = new System.Drawing.Size(107, 21);
            this.txt_total_due_amount.TabIndex = 13;
            // 
            // cmb_client
            // 
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(148, 36);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(214, 23);
            this.cmb_client.TabIndex = 8;
            this.cmb_client.SelectedIndexChanged += new System.EventHandler(this.cmb_client_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serial No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payment Mode";
            // 
            // txt_total_install
            // 
            this.txt_total_install.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_total_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_install.Location = new System.Drawing.Point(878, 66);
            this.txt_total_install.Name = "txt_total_install";
            this.txt_total_install.Size = new System.Drawing.Size(107, 21);
            this.txt_total_install.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_close);
            this.groupBox2.Controls.Add(this.bt_submit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(493, 17);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(392, 17);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 3;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // dateTimePicker_next_installement
            // 
            this.dateTimePicker_next_installement.Location = new System.Drawing.Point(148, 280);
            this.dateTimePicker_next_installement.Name = "dateTimePicker_next_installement";
            this.dateTimePicker_next_installement.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker_next_installement.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 15);
            this.label16.TabIndex = 24;
            this.label16.Text = "Next Installement Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_interval);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_amc_amount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txt_total_submited_amount);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_install_amount);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txt_due_install);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_paid_install);
            this.groupBox1.Controls.Add(this.groupBox_cheque_dd);
            this.groupBox1.Controls.Add(this.txt_total_due_amount);
            this.groupBox1.Controls.Add(this.dateTimePicker_next_installement);
            this.groupBox1.Controls.Add(this.txt_total_install);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimePicker_payment_date);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_payment_mode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_serial_no);
            this.groupBox1.Controls.Add(this.cmb_client);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 478);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox4.Controls.Add(this.txt_remark);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmb_adjust);
            this.groupBox4.Location = new System.Drawing.Point(369, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 278);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adjustment Details";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(75, 79);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(201, 177);
            this.txt_remark.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Remark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Adjustment Amount";
            // 
            // cmb_adjust
            // 
            this.cmb_adjust.FormattingEnabled = true;
            this.cmb_adjust.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmb_adjust.Location = new System.Drawing.Point(125, 24);
            this.cmb_adjust.Name = "cmb_adjust";
            this.cmb_adjust.Size = new System.Drawing.Size(139, 23);
            this.cmb_adjust.TabIndex = 32;
            this.cmb_adjust.SelectedIndexChanged += new System.EventHandler(this.cmb_adjust_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 111);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker2.TabIndex = 30;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "AMC END DATE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 21);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 15);
            this.label18.TabIndex = 27;
            this.label18.Text = "AMC START DATE";
            // 
            // groupBox_cheque_dd
            // 
            this.groupBox_cheque_dd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_cheque_dd.Controls.Add(this.dateTimePicker_cheque_dd);
            this.groupBox_cheque_dd.Controls.Add(this.txt_cheque_dd_no);
            this.groupBox_cheque_dd.Controls.Add(this.lb_bank);
            this.groupBox_cheque_dd.Controls.Add(this.txt_bank_name);
            this.groupBox_cheque_dd.Controls.Add(this.lb_dd_cheque_neft_no);
            this.groupBox_cheque_dd.Controls.Add(this.lb_date);
            this.groupBox_cheque_dd.Location = new System.Drawing.Point(130, 308);
            this.groupBox_cheque_dd.Name = "groupBox_cheque_dd";
            this.groupBox_cheque_dd.Size = new System.Drawing.Size(433, 115);
            this.groupBox_cheque_dd.TabIndex = 26;
            this.groupBox_cheque_dd.TabStop = false;
            this.groupBox_cheque_dd.Text = "Cheque/DD Detail";
            // 
            // dateTimePicker_cheque_dd
            // 
            this.dateTimePicker_cheque_dd.Location = new System.Drawing.Point(228, 84);
            this.dateTimePicker_cheque_dd.Name = "dateTimePicker_cheque_dd";
            this.dateTimePicker_cheque_dd.Size = new System.Drawing.Size(180, 21);
            this.dateTimePicker_cheque_dd.TabIndex = 30;
            // 
            // txt_cheque_dd_no
            // 
            this.txt_cheque_dd_no.Location = new System.Drawing.Point(228, 50);
            this.txt_cheque_dd_no.Name = "txt_cheque_dd_no";
            this.txt_cheque_dd_no.Size = new System.Drawing.Size(180, 21);
            this.txt_cheque_dd_no.TabIndex = 23;
            this.txt_cheque_dd_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cheque_dd_no_KeyPress);
            // 
            // lb_bank
            // 
            this.lb_bank.AutoSize = true;
            this.lb_bank.Location = new System.Drawing.Point(90, 23);
            this.lb_bank.Name = "lb_bank";
            this.lb_bank.Size = new System.Drawing.Size(72, 15);
            this.lb_bank.TabIndex = 14;
            this.lb_bank.Text = "Bank Name";
            // 
            // txt_bank_name
            // 
            this.txt_bank_name.Location = new System.Drawing.Point(228, 17);
            this.txt_bank_name.Name = "txt_bank_name";
            this.txt_bank_name.Size = new System.Drawing.Size(180, 21);
            this.txt_bank_name.TabIndex = 22;
            // 
            // lb_dd_cheque_neft_no
            // 
            this.lb_dd_cheque_neft_no.AutoSize = true;
            this.lb_dd_cheque_neft_no.Location = new System.Drawing.Point(90, 53);
            this.lb_dd_cheque_neft_no.Name = "lb_dd_cheque_neft_no";
            this.lb_dd_cheque_neft_no.Size = new System.Drawing.Size(119, 15);
            this.lb_dd_cheque_neft_no.TabIndex = 15;
            this.lb_dd_cheque_neft_no.Text = "Cheque/DD Number";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(90, 84);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(100, 15);
            this.lb_date.TabIndex = 16;
            this.lb_date.Text = "Cheque/DD Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(736, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Installements";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(739, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Due Installements";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(736, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Paid Installements";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(682, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Payable Amount As Installement";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(743, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Total Due Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(721, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Total Submited Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(762, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "AMC Amount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(729, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Installement Interval ";
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 497);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentDetails";
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_cheque_dd.ResumeLayout(false);
            this.groupBox_cheque_dd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_payment_date;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.ComboBox cmb_payment_mode;
        private System.Windows.Forms.ComboBox cmb_serial_no;
        private System.Windows.Forms.TextBox txt_interval;
        private System.Windows.Forms.TextBox txt_amc_amount;
        private System.Windows.Forms.TextBox txt_total_submited_amount;
        private System.Windows.Forms.TextBox txt_install_amount;
        private System.Windows.Forms.TextBox txt_due_install;
        private System.Windows.Forms.TextBox txt_paid_install;
        private System.Windows.Forms.TextBox txt_total_due_amount;
        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total_install;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_next_installement;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox_cheque_dd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cheque_dd;
        private System.Windows.Forms.TextBox txt_cheque_dd_no;
        private System.Windows.Forms.Label lb_bank;
        private System.Windows.Forms.TextBox txt_bank_name;
        private System.Windows.Forms.Label lb_dd_cheque_neft_no;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.ComboBox cmb_adjust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}