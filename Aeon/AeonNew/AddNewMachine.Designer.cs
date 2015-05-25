namespace AeonNew
{
    partial class AddNewMachine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnderComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.upEqpTypecomboBox = new System.Windows.Forms.ComboBox();
            this.upEqpNamecomboBox = new System.Windows.Forms.ComboBox();
            this.upAMCCosttextBox = new System.Windows.Forms.TextBox();
            this.upEqpBrandtextBox = new System.Windows.Forms.TextBox();
            this.upEqpCapacitytextBox = new System.Windows.Forms.TextBox();
            this.upQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpecificationButton = new System.Windows.Forms.Button();
            this.tempAMCEndDate = new System.Windows.Forms.Label();
            this.upEqpEndDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upEqpStartDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.upEqpInstDatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 30);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(288, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide Equipment Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalprice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UnderComboBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.upEqpTypecomboBox);
            this.groupBox1.Controls.Add(this.upEqpNamecomboBox);
            this.groupBox1.Controls.Add(this.upAMCCosttextBox);
            this.groupBox1.Controls.Add(this.upEqpBrandtextBox);
            this.groupBox1.Controls.Add(this.upEqpCapacitytextBox);
            this.groupBox1.Controls.Add(this.upQuantitytextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment Details";
            // 
            // UnderComboBox
            // 
            this.UnderComboBox.FormattingEnabled = true;
            this.UnderComboBox.Items.AddRange(new object[] {
            "AMC",
            "WARRANTY",
            "OUT OF AMC",
            "OUT OF WARRANTY"});
            this.UnderComboBox.Location = new System.Drawing.Point(135, 181);
            this.UnderComboBox.Name = "UnderComboBox";
            this.UnderComboBox.Size = new System.Drawing.Size(252, 23);
            this.UnderComboBox.TabIndex = 6;
            this.UnderComboBox.Text = "---select----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Under : ";
            // 
            // upEqpTypecomboBox
            // 
            this.upEqpTypecomboBox.FormattingEnabled = true;
            this.upEqpTypecomboBox.Items.AddRange(new object[] {
            "On Line",
            "Off Line",
            "None"});
            this.upEqpTypecomboBox.Location = new System.Drawing.Point(135, 57);
            this.upEqpTypecomboBox.Name = "upEqpTypecomboBox";
            this.upEqpTypecomboBox.Size = new System.Drawing.Size(252, 23);
            this.upEqpTypecomboBox.TabIndex = 2;
            this.upEqpTypecomboBox.Text = "---select----";
            // 
            // upEqpNamecomboBox
            // 
            this.upEqpNamecomboBox.FormattingEnabled = true;
            this.upEqpNamecomboBox.Items.AddRange(new object[] {
            "UPS",
            "SERVO-STEBLIZER",
            "STEBLIZER",
            "CVTs",
            "INVERTER"});
            this.upEqpNamecomboBox.Location = new System.Drawing.Point(135, 28);
            this.upEqpNamecomboBox.Name = "upEqpNamecomboBox";
            this.upEqpNamecomboBox.Size = new System.Drawing.Size(252, 23);
            this.upEqpNamecomboBox.TabIndex = 1;
            this.upEqpNamecomboBox.Text = "---select----";
            // 
            // upAMCCosttextBox
            // 
            this.upAMCCosttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upAMCCosttextBox.Location = new System.Drawing.Point(135, 212);
            this.upAMCCosttextBox.Name = "upAMCCosttextBox";
            this.upAMCCosttextBox.Size = new System.Drawing.Size(252, 24);
            this.upAMCCosttextBox.TabIndex = 7;
            this.upAMCCosttextBox.TextChanged += new System.EventHandler(this.upAMCCosttextBox_TextChanged);
            // 
            // upEqpBrandtextBox
            // 
            this.upEqpBrandtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upEqpBrandtextBox.Location = new System.Drawing.Point(135, 118);
            this.upEqpBrandtextBox.Name = "upEqpBrandtextBox";
            this.upEqpBrandtextBox.Size = new System.Drawing.Size(252, 24);
            this.upEqpBrandtextBox.TabIndex = 4;
            // 
            // upEqpCapacitytextBox
            // 
            this.upEqpCapacitytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upEqpCapacitytextBox.Location = new System.Drawing.Point(135, 86);
            this.upEqpCapacitytextBox.Name = "upEqpCapacitytextBox";
            this.upEqpCapacitytextBox.Size = new System.Drawing.Size(252, 24);
            this.upEqpCapacitytextBox.TabIndex = 3;
            // 
            // upQuantitytextBox
            // 
            this.upQuantitytextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upQuantitytextBox.Location = new System.Drawing.Point(135, 149);
            this.upQuantitytextBox.Name = "upQuantitytextBox";
            this.upQuantitytextBox.Size = new System.Drawing.Size(252, 24);
            this.upQuantitytextBox.TabIndex = 5;
            this.upQuantitytextBox.TextChanged += new System.EventHandler(this.upQuantitytextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "AMC Unit Price : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Brand : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Capacity : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Equipment Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Equipment Name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpecificationButton);
            this.groupBox2.Controls.Add(this.tempAMCEndDate);
            this.groupBox2.Controls.Add(this.upEqpEndDatedateTimePicker);
            this.groupBox2.Controls.Add(this.upEqpStartDatedateTimePicker);
            this.groupBox2.Controls.Add(this.upEqpInstDatedateTimePicker);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(430, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AMC Details";
            // 
            // SpecificationButton
            // 
            this.SpecificationButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SpecificationButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpecificationButton.Location = new System.Drawing.Point(15, 185);
            this.SpecificationButton.Name = "SpecificationButton";
            this.SpecificationButton.Size = new System.Drawing.Size(322, 34);
            this.SpecificationButton.TabIndex = 13;
            this.SpecificationButton.Text = "Add Equipment Specification";
            this.SpecificationButton.UseVisualStyleBackColor = false;
            this.SpecificationButton.Click += new System.EventHandler(this.SpecificationButton_Click);
            // 
            // tempAMCEndDate
            // 
            this.tempAMCEndDate.AutoSize = true;
            this.tempAMCEndDate.Location = new System.Drawing.Point(12, 135);
            this.tempAMCEndDate.Name = "tempAMCEndDate";
            this.tempAMCEndDate.Size = new System.Drawing.Size(84, 17);
            this.tempAMCEndDate.TabIndex = 12;
            this.tempAMCEndDate.Text = "AMCEndDate";
            this.tempAMCEndDate.Visible = false;
            // 
            // upEqpEndDatedateTimePicker
            // 
            this.upEqpEndDatedateTimePicker.Location = new System.Drawing.Point(137, 98);
            this.upEqpEndDatedateTimePicker.Name = "upEqpEndDatedateTimePicker";
            this.upEqpEndDatedateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.upEqpEndDatedateTimePicker.TabIndex = 2;
            // 
            // upEqpStartDatedateTimePicker
            // 
            this.upEqpStartDatedateTimePicker.Location = new System.Drawing.Point(137, 62);
            this.upEqpStartDatedateTimePicker.Name = "upEqpStartDatedateTimePicker";
            this.upEqpStartDatedateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.upEqpStartDatedateTimePicker.TabIndex = 1;
            // 
            // upEqpInstDatedateTimePicker
            // 
            this.upEqpInstDatedateTimePicker.Location = new System.Drawing.Point(137, 26);
            this.upEqpInstDatedateTimePicker.Name = "upEqpInstDatedateTimePicker";
            this.upEqpInstDatedateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.upEqpInstDatedateTimePicker.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "AMC End Date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "AMC Start Date : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Installation Date : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.paymentButton);
            this.panel2.Location = new System.Drawing.Point(13, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 41);
            this.panel2.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(518, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(244, 34);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(264, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(244, 34);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.Teal;
            this.paymentButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentButton.Location = new System.Drawing.Point(10, 3);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(244, 34);
            this.paymentButton.TabIndex = 0;
            this.paymentButton.Text = "Make Payment";
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Visible = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.updatebutton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebutton.Location = new System.Drawing.Point(292, 330);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(244, 34);
            this.updatebutton.TabIndex = 5;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Visible = false;
            this.updatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalprice
            // 
            this.totalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalprice.Location = new System.Drawing.Point(135, 250);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(252, 24);
            this.totalprice.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Price : ";
            // 
            // AddNewMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 429);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewMachine";
            this.Text = "Add New Machine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewMachine_FormClosed);
            this.Load += new System.EventHandler(this.AddNewMachine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox upQuantitytextBox;
        public System.Windows.Forms.TextBox upEqpBrandtextBox;
        public System.Windows.Forms.TextBox upEqpCapacitytextBox;
        public System.Windows.Forms.ComboBox upEqpTypecomboBox;
        public System.Windows.Forms.ComboBox upEqpNamecomboBox;
        public System.Windows.Forms.TextBox upAMCCosttextBox;
        public System.Windows.Forms.DateTimePicker upEqpEndDatedateTimePicker;
        public System.Windows.Forms.DateTimePicker upEqpStartDatedateTimePicker;
        public System.Windows.Forms.DateTimePicker upEqpInstDatedateTimePicker;
        public System.Windows.Forms.ComboBox UnderComboBox;
        private System.Windows.Forms.Label tempAMCEndDate;
        private System.Windows.Forms.Button SpecificationButton;
        private System.Windows.Forms.Button updatebutton;
        public System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.Label label5;
    }
}