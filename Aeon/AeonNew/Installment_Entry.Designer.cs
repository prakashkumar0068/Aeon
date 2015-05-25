namespace AeonNew
{
    partial class Installment_Entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnpaidAmountTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Next_Inst_Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Num_Of_Inst_TextBox = new System.Windows.Forms.TextBox();
            this.Total_Amount_Rec_textBox = new System.Windows.Forms.TextBox();
            this.Inst_Pay_Mode_comboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacity_label = new System.Windows.Forms.Label();
            this.equipment_name_label = new System.Windows.Forms.Label();
            this.total_cost_label = new System.Windows.Forms.Label();
            this.unit_price_label = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.start_end_lable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provide Installment details and payment mode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnpaidAmountTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Next_Inst_Date_dateTimePicker);
            this.groupBox1.Controls.Add(this.Num_Of_Inst_TextBox);
            this.groupBox1.Controls.Add(this.Total_Amount_Rec_textBox);
            this.groupBox1.Controls.Add(this.Inst_Pay_Mode_comboBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // UnpaidAmountTextBox
            // 
            this.UnpaidAmountTextBox.Location = new System.Drawing.Point(250, 55);
            this.UnpaidAmountTextBox.Name = "UnpaidAmountTextBox";
            this.UnpaidAmountTextBox.Size = new System.Drawing.Size(218, 24);
            this.UnpaidAmountTextBox.TabIndex = 10;
            this.UnpaidAmountTextBox.Text = "0";
            this.UnpaidAmountTextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Previous installment unpaid amount : ";
            this.label12.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next_Inst_Date_dateTimePicker
            // 
            this.Next_Inst_Date_dateTimePicker.Location = new System.Drawing.Point(250, 150);
            this.Next_Inst_Date_dateTimePicker.Name = "Next_Inst_Date_dateTimePicker";
            this.Next_Inst_Date_dateTimePicker.Size = new System.Drawing.Size(218, 24);
            this.Next_Inst_Date_dateTimePicker.TabIndex = 7;
            // 
            // Num_Of_Inst_TextBox
            // 
            this.Num_Of_Inst_TextBox.Location = new System.Drawing.Point(250, 118);
            this.Num_Of_Inst_TextBox.Name = "Num_Of_Inst_TextBox";
            this.Num_Of_Inst_TextBox.Size = new System.Drawing.Size(218, 24);
            this.Num_Of_Inst_TextBox.TabIndex = 6;
            // 
            // Total_Amount_Rec_textBox
            // 
            this.Total_Amount_Rec_textBox.Location = new System.Drawing.Point(250, 23);
            this.Total_Amount_Rec_textBox.Name = "Total_Amount_Rec_textBox";
            this.Total_Amount_Rec_textBox.Size = new System.Drawing.Size(218, 24);
            this.Total_Amount_Rec_textBox.TabIndex = 5;
            this.Total_Amount_Rec_textBox.Text = "0";
            this.Total_Amount_Rec_textBox.Visible = false;
            // 
            // Inst_Pay_Mode_comboBox
            // 
            this.Inst_Pay_Mode_comboBox.FormattingEnabled = true;
            this.Inst_Pay_Mode_comboBox.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Halfyearly",
            "Anually"});
            this.Inst_Pay_Mode_comboBox.Location = new System.Drawing.Point(250, 87);
            this.Inst_Pay_Mode_comboBox.Name = "Inst_Pay_Mode_comboBox";
            this.Inst_Pay_Mode_comboBox.Size = new System.Drawing.Size(218, 23);
            this.Inst_Pay_Mode_comboBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Next installment date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Number of installments : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Installment payment mode : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Amount received till date : ";
            this.label8.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.capacity_label);
            this.panel1.Controls.Add(this.equipment_name_label);
            this.panel1.Controls.Add(this.total_cost_label);
            this.panel1.Controls.Add(this.unit_price_label);
            this.panel1.Controls.Add(this.number_label);
            this.panel1.Controls.Add(this.start_end_lable);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 209);
            this.panel1.TabIndex = 2;
            // 
            // capacity_label
            // 
            this.capacity_label.AutoSize = true;
            this.capacity_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.capacity_label.Location = new System.Drawing.Point(207, 81);
            this.capacity_label.Name = "capacity_label";
            this.capacity_label.Size = new System.Drawing.Size(66, 17);
            this.capacity_label.TabIndex = 23;
            this.capacity_label.Text = "Capacity : ";
            // 
            // equipment_name_label
            // 
            this.equipment_name_label.AutoSize = true;
            this.equipment_name_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipment_name_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equipment_name_label.Location = new System.Drawing.Point(207, 50);
            this.equipment_name_label.Name = "equipment_name_label";
            this.equipment_name_label.Size = new System.Drawing.Size(130, 17);
            this.equipment_name_label.TabIndex = 22;
            this.equipment_name_label.Text = "Name of equipment : ";
            // 
            // total_cost_label
            // 
            this.total_cost_label.AutoSize = true;
            this.total_cost_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cost_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total_cost_label.Location = new System.Drawing.Point(207, 174);
            this.total_cost_label.Name = "total_cost_label";
            this.total_cost_label.Size = new System.Drawing.Size(116, 17);
            this.total_cost_label.TabIndex = 21;
            this.total_cost_label.Text = "Total cost of AMC : ";
            // 
            // unit_price_label
            // 
            this.unit_price_label.AutoSize = true;
            this.unit_price_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_price_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unit_price_label.Location = new System.Drawing.Point(207, 143);
            this.unit_price_label.Name = "unit_price_label";
            this.unit_price_label.Size = new System.Drawing.Size(103, 17);
            this.unit_price_label.TabIndex = 20;
            this.unit_price_label.Text = "AMC Unit Price : ";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.number_label.Location = new System.Drawing.Point(207, 112);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(176, 17);
            this.number_label.TabIndex = 19;
            this.number_label.Text = "Total number of equipments : ";
            // 
            // start_end_lable
            // 
            this.start_end_lable.AutoSize = true;
            this.start_end_lable.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_end_lable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_end_lable.Location = new System.Drawing.Point(207, 19);
            this.start_end_lable.Name = "start_end_lable";
            this.start_end_lable.Size = new System.Drawing.Size(153, 17);
            this.start_end_lable.TabIndex = 18;
            this.start_end_lable.Text = "AMC Start and End date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Capacity : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name of equipment : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total cost of AMC : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "AMC Unit Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total number of equipments : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "AMC Start and End date : ";
            // 
            // Installment_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Installment_Entry";
            this.ShowIcon = false;
            this.Text = "Installment Entry";
            this.Load += new System.EventHandler(this.Installment_Entry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label capacity_label;
        private System.Windows.Forms.Label equipment_name_label;
        private System.Windows.Forms.Label total_cost_label;
        private System.Windows.Forms.Label unit_price_label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Label start_end_lable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Next_Inst_Date_dateTimePicker;
        private System.Windows.Forms.TextBox Num_Of_Inst_TextBox;
        private System.Windows.Forms.TextBox Total_Amount_Rec_textBox;
        private System.Windows.Forms.ComboBox Inst_Pay_Mode_comboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UnpaidAmountTextBox;
        private System.Windows.Forms.Label label12;
    }
}