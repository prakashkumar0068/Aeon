namespace AeonNew
{
    partial class Equpiment_Archive
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
            this.bt_archive = new System.Windows.Forms.Button();
            this.cmb_serial_no = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_org_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_archive);
            this.groupBox1.Controls.Add(this.cmb_serial_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_org_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archive Equipment Details";
            // 
            // bt_archive
            // 
            this.bt_archive.Location = new System.Drawing.Point(752, 38);
            this.bt_archive.Name = "bt_archive";
            this.bt_archive.Size = new System.Drawing.Size(185, 23);
            this.bt_archive.TabIndex = 4;
            this.bt_archive.Text = "ADD TO ARICHVE";
            this.bt_archive.UseVisualStyleBackColor = true;
            this.bt_archive.Click += new System.EventHandler(this.bt_archive_Click);
            // 
            // cmb_serial_no
            // 
            this.cmb_serial_no.FormattingEnabled = true;
            this.cmb_serial_no.Location = new System.Drawing.Point(525, 40);
            this.cmb_serial_no.Name = "cmb_serial_no";
            this.cmb_serial_no.Size = new System.Drawing.Size(184, 21);
            this.cmb_serial_no.TabIndex = 3;
            this.cmb_serial_no.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select serial Number";
            // 
            // cmb_org_name
            // 
            this.cmb_org_name.FormattingEnabled = true;
            this.cmb_org_name.Location = new System.Drawing.Point(184, 39);
            this.cmb_org_name.Name = "cmb_org_name";
            this.cmb_org_name.Size = new System.Drawing.Size(193, 21);
            this.cmb_org_name.TabIndex = 1;
            this.cmb_org_name.SelectedIndexChanged += new System.EventHandler(this.cmb_org_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Oranization";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(17, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data For Archive";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(989, 246);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_close);
            this.groupBox3.Location = new System.Drawing.Point(20, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(989, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(457, 19);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // Equpiment_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Equpiment_Archive";
            this.Text = "Equpiment_Archive";
            this.Load += new System.EventHandler(this.Equpiment_Archive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_serial_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_org_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bt_archive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_close;
    }
}