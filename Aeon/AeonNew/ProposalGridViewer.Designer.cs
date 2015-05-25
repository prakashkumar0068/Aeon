namespace AeonNew
{
    partial class ProposalGridViewer
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
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_items = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_client
            // 
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(399, 16);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(146, 21);
            this.cmb_client.TabIndex = 10;
            this.cmb_client.SelectedIndexChanged += new System.EventHandler(this.cmb_client_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Client Name";
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(9, 28);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(75, 23);
            this.bt_generate.TabIndex = 3;
            this.bt_generate.Text = "Generate";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(111, 28);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(49, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(831, 253);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(10, 49);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lst_items);
            this.groupBox1.Controls.Add(this.bt_add);
            this.groupBox1.Location = new System.Drawing.Point(595, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_items
            // 
            this.lst_items.FormattingEnabled = true;
            this.lst_items.Location = new System.Drawing.Point(136, 16);
            this.lst_items.Name = "lst_items";
            this.lst_items.Size = new System.Drawing.Size(132, 147);
            this.lst_items.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_generate);
            this.groupBox2.Controls.Add(this.bt_close);
            this.groupBox2.Location = new System.Drawing.Point(66, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // ProposalGridViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 505);
            this.Controls.Add(this.cmb_client);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProposalGridViewer";
            this.Text = "Proposal Grid Viewer";
            this.Load += new System.EventHandler(this.ProposalGridViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_items;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}