namespace AeonNew
{
    partial class ComplaintResolve
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
            this.bt_close = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cmb_client_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(306, 364);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 8;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(731, 295);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // cmb_client_name
            // 
            this.cmb_client_name.FormattingEnabled = true;
            this.cmb_client_name.Location = new System.Drawing.Point(200, 24);
            this.cmb_client_name.Name = "cmb_client_name";
            this.cmb_client_name.Size = new System.Drawing.Size(174, 21);
            this.cmb_client_name.TabIndex = 6;
            this.cmb_client_name.SelectedIndexChanged += new System.EventHandler(this.cmb_client_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_close);
            this.groupBox1.Controls.Add(this.cmb_client_name);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 406);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ComplaintResolve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComplaintResolve";
            this.Text = "Complaint Resolve";
            this.Load += new System.EventHandler(this.ComplaintResolve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cmb_client_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}