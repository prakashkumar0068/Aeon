namespace AeonNew
{
    partial class Installement
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
            this.dateTimePicker_installement = new System.Windows.Forms.DateTimePicker();
            this.cmb_installement_type = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialNumber = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orgNameListbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_installement);
            this.groupBox1.Controls.Add(this.cmb_installement_type);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installements Details";
            // 
            // dateTimePicker_installement
            // 
            this.dateTimePicker_installement.Location = new System.Drawing.Point(303, 121);
            this.dateTimePicker_installement.Name = "dateTimePicker_installement";
            this.dateTimePicker_installement.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_installement.TabIndex = 8;
            // 
            // cmb_installement_type
            // 
            this.cmb_installement_type.FormattingEnabled = true;
            this.cmb_installement_type.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Half Yearly",
            "Yearly "});
            this.cmb_installement_type.Location = new System.Drawing.Point(306, 79);
            this.cmb_installement_type.Name = "cmb_installement_type";
            this.cmb_installement_type.Size = new System.Drawing.Size(197, 26);
            this.cmb_installement_type.TabIndex = 7;
            this.cmb_installement_type.SelectedIndexChanged += new System.EventHandler(this.cmb_installement_type_SelectedIndexChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.SystemColors.Window;
            this.txt_amount.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(306, 41);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(197, 26);
            this.txt_amount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "InstallementsType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next Installement Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Amount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_close);
            this.groupBox2.Controls.Add(this.bt_submit);
            this.groupBox2.Location = new System.Drawing.Point(63, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 77);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(276, 29);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Cancel";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(165, 30);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 0;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serialNumber);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.orgNameListbox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(63, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 186);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // serialNumber
            // 
            this.serialNumber.FormattingEnabled = true;
            this.serialNumber.Location = new System.Drawing.Point(263, 148);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(197, 21);
            this.serialNumber.TabIndex = 15;
            this.serialNumber.SelectedIndexChanged += new System.EventHandler(this.serialNumber_SelectedIndexChanged);
            this.serialNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.serialNumber_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Serial Number";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "AMC END DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "AMC START DATE";
            // 
            // orgNameListbox
            // 
            this.orgNameListbox.FormattingEnabled = true;
            this.orgNameListbox.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Half Yearly",
            "Yearly "});
            this.orgNameListbox.Location = new System.Drawing.Point(263, 32);
            this.orgNameListbox.Name = "orgNameListbox";
            this.orgNameListbox.Size = new System.Drawing.Size(197, 21);
            this.orgNameListbox.TabIndex = 9;
            this.orgNameListbox.SelectedIndexChanged += new System.EventHandler(this.orgNameListbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Organization";
            // 
            // Installement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Installement";
            this.Text = "Installement";
            this.Load += new System.EventHandler(this.Installement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_installement;
        private System.Windows.Forms.ComboBox cmb_installement_type;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox serialNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox orgNameListbox;
        private System.Windows.Forms.Label label4;
    }
}