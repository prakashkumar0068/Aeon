namespace AeonNew
{
    partial class NewComplainLog
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmb_client_name = new System.Windows.Forms.ComboBox();
            this.txt_loging_person = new System.Windows.Forms.TextBox();
            this.lb_complain_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.ComboBox();
            this.txt_model = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_warranty = new System.Windows.Forms.TextBox();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.txt_equipment_name = new System.Windows.Forms.TextBox();
            this.cmb_serial_number = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_engineer_name = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_service_type = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lst_engineers = new System.Windows.Forms.ListBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.cmb_client_name);
            this.groupBox1.Controls.Add(this.txt_loging_person);
            this.groupBox1.Controls.Add(this.lb_complain_number);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 103);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(257, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // cmb_client_name
            // 
            this.cmb_client_name.FormattingEnabled = true;
            this.cmb_client_name.Location = new System.Drawing.Point(672, 17);
            this.cmb_client_name.Name = "cmb_client_name";
            this.cmb_client_name.Size = new System.Drawing.Size(186, 21);
            this.cmb_client_name.TabIndex = 13;
            this.cmb_client_name.SelectedIndexChanged += new System.EventHandler(this.cmb_client_name_SelectedIndexChanged);
            // 
            // txt_loging_person
            // 
            this.txt_loging_person.Location = new System.Drawing.Point(672, 51);
            this.txt_loging_person.Name = "txt_loging_person";
            this.txt_loging_person.Size = new System.Drawing.Size(186, 20);
            this.txt_loging_person.TabIndex = 7;
            // 
            // lb_complain_number
            // 
            this.lb_complain_number.AutoSize = true;
            this.lb_complain_number.Location = new System.Drawing.Point(259, 20);
            this.lb_complain_number.Name = "lb_complain_number";
            this.lb_complain_number.Size = new System.Drawing.Size(50, 13);
            this.lb_complain_number.TabIndex = 4;
            this.lb_complain_number.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name Of Person Loging Complaint :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Complaint :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complaint Number :";
            // 
            // txt_capacity
            // 
            this.txt_capacity.FormattingEnabled = true;
            this.txt_capacity.Location = new System.Drawing.Point(635, 55);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.Size = new System.Drawing.Size(136, 21);
            this.txt_capacity.TabIndex = 14;
            this.txt_capacity.SelectedIndexChanged += new System.EventHandler(this.txt_capacity_SelectedIndexChanged);
            // 
            // txt_model
            // 
            this.txt_model.FormattingEnabled = true;
            this.txt_model.Location = new System.Drawing.Point(478, 55);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(136, 21);
            this.txt_model.TabIndex = 13;
            this.txt_model.SelectedIndexChanged += new System.EventHandler(this.txt_model_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_capacity);
            this.groupBox2.Controls.Add(this.txt_model);
            this.groupBox2.Controls.Add(this.txt_warranty);
            this.groupBox2.Controls.Add(this.txt_brand);
            this.groupBox2.Controls.Add(this.txt_equipment_name);
            this.groupBox2.Controls.Add(this.cmb_serial_number);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 91);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipment Detail";
            // 
            // txt_warranty
            // 
            this.txt_warranty.Location = new System.Drawing.Point(796, 55);
            this.txt_warranty.Name = "txt_warranty";
            this.txt_warranty.Size = new System.Drawing.Size(152, 20);
            this.txt_warranty.TabIndex = 12;
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(307, 56);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(152, 20);
            this.txt_brand.TabIndex = 9;
            // 
            // txt_equipment_name
            // 
            this.txt_equipment_name.Location = new System.Drawing.Point(144, 56);
            this.txt_equipment_name.Name = "txt_equipment_name";
            this.txt_equipment_name.Size = new System.Drawing.Size(152, 20);
            this.txt_equipment_name.TabIndex = 8;
            this.txt_equipment_name.TextChanged += new System.EventHandler(this.txt_equipment_name_TextChanged);
            // 
            // cmb_serial_number
            // 
            this.cmb_serial_number.FormattingEnabled = true;
            this.cmb_serial_number.Location = new System.Drawing.Point(2, 55);
            this.cmb_serial_number.Name = "cmb_serial_number";
            this.cmb_serial_number.Size = new System.Drawing.Size(136, 21);
            this.cmb_serial_number.TabIndex = 6;
            this.cmb_serial_number.SelectedIndexChanged += new System.EventHandler(this.cmb_serial_number_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Name Of Equipment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(847, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Machine Under";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Capacity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Serial Number";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(17, 23);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(940, 96);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(545, 477);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 17;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(453, 477);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 16;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.richTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(970, 139);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nature Of Complaints";
            // 
            // txt_engineer_name
            // 
            this.txt_engineer_name.FormattingEnabled = true;
            this.txt_engineer_name.Location = new System.Drawing.Point(179, 41);
            this.txt_engineer_name.Name = "txt_engineer_name";
            this.txt_engineer_name.Size = new System.Drawing.Size(177, 21);
            this.txt_engineer_name.TabIndex = 22;
            this.txt_engineer_name.Text = "----Select Engineer----";
            this.txt_engineer_name.SelectedIndexChanged += new System.EventHandler(this.txt_engineer_name_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txt_engineer_name);
            this.groupBox4.Controls.Add(this.cmb_service_type);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lst_engineers);
            this.groupBox4.Controls.Add(this.bt_add);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 218);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(970, 106);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // cmb_service_type
            // 
            this.cmb_service_type.FormattingEnabled = true;
            this.cmb_service_type.Items.AddRange(new object[] {
            "Unpaid",
            "Paid"});
            this.cmb_service_type.Location = new System.Drawing.Point(179, 79);
            this.cmb_service_type.Name = "cmb_service_type";
            this.cmb_service_type.Size = new System.Drawing.Size(121, 21);
            this.cmb_service_type.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Service Type";
            // 
            // lst_engineers
            // 
            this.lst_engineers.FormattingEnabled = true;
            this.lst_engineers.Location = new System.Drawing.Point(539, 9);
            this.lst_engineers.Name = "lst_engineers";
            this.lst_engineers.Size = new System.Drawing.Size(205, 95);
            this.lst_engineers.TabIndex = 19;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(393, 41);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 18;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name Of Engineer Scheduled : ";
            // 
            // NewComplainLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "NewComplainLog";
            this.Text = "NewComplainLog";
            this.Load += new System.EventHandler(this.NewComplainLog_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewComplainLog_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewComplainLog_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmb_client_name;
        private System.Windows.Forms.TextBox txt_loging_person;
        private System.Windows.Forms.Label lb_complain_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_capacity;
        private System.Windows.Forms.ComboBox txt_model;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_warranty;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.TextBox txt_equipment_name;
        private System.Windows.Forms.ComboBox cmb_serial_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox txt_engineer_name;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_service_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lst_engineers;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label11;
    }
}