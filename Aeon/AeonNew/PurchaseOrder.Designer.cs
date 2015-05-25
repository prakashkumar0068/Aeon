namespace AeonNew
{
    partial class PurchaseOrder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_org_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.bt_add_items = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_add_items = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_unit_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb_org_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 53);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHOOSE ORGANIZATION";
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(635, 19);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(177, 20);
            this.txt_tax.TabIndex = 41;
            this.txt_tax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tax_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "TAX  :";
            // 
            // cmb_org_name
            // 
            this.cmb_org_name.FormattingEnabled = true;
            this.cmb_org_name.Location = new System.Drawing.Point(348, 19);
            this.cmb_org_name.Name = "cmb_org_name";
            this.cmb_org_name.Size = new System.Drawing.Size(200, 21);
            this.cmb_org_name.TabIndex = 1;
            this.cmb_org_name.Text = "---SELECT ORGANIZATION---";
            this.cmb_org_name.SelectedIndexChanged += new System.EventHandler(this.cmb_org_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.orderdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_unit_price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Location = new System.Drawing.Point(7, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 340);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTER PURCHASE DISCRIPTION";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_desc);
            this.groupBox5.Controls.Add(this.bt_add_items);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(14, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(519, 225);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(119, 42);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(368, 100);
            this.txt_desc.TabIndex = 35;
            // 
            // bt_add_items
            // 
            this.bt_add_items.Location = new System.Drawing.Point(220, 171);
            this.bt_add_items.Name = "bt_add_items";
            this.bt_add_items.Size = new System.Drawing.Size(86, 23);
            this.bt_add_items.TabIndex = 41;
            this.bt_add_items.Text = "Add Items";
            this.bt_add_items.UseVisualStyleBackColor = true;
            this.bt_add_items.Click += new System.EventHandler(this.bt_add_items_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Order Description";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_add_items);
            this.groupBox3.Location = new System.Drawing.Point(539, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 225);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // lst_add_items
            // 
            this.lst_add_items.FormattingEnabled = true;
            this.lst_add_items.Location = new System.Drawing.Point(9, 15);
            this.lst_add_items.Name = "lst_add_items";
            this.lst_add_items.Size = new System.Drawing.Size(349, 199);
            this.lst_add_items.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "ORDER DATE  :";
            // 
            // orderdate
            // 
            this.orderdate.Location = new System.Drawing.Point(180, 31);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(200, 20);
            this.orderdate.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "UNIT PRICE :";
            // 
            // txt_unit_price
            // 
            this.txt_unit_price.Location = new System.Drawing.Point(731, 28);
            this.txt_unit_price.Name = "txt_unit_price";
            this.txt_unit_price.Size = new System.Drawing.Size(187, 20);
            this.txt_unit_price.TabIndex = 32;
            this.txt_unit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unit_price_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "QUANTITY  :";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(465, 29);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(181, 20);
            this.txt_quantity.TabIndex = 26;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(373, 17);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(163, 25);
            this.bt_save.TabIndex = 39;
            this.bt_save.Text = "SAVE";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_save);
            this.groupBox4.Location = new System.Drawing.Point(7, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(934, 53);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseOrder";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_org_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Button bt_add_items;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_add_items;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_unit_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}