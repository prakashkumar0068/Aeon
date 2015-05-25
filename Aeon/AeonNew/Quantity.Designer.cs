namespace AeonNew
{
    partial class Quantity
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.QuanitycrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(34, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 457);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUANTITY REPORT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.item);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(45, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHOW PARTICULAR PRODUCT";
            // 
            // item
            // 
            this.item.FormattingEnabled = true;
            this.item.Location = new System.Drawing.Point(153, 51);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(121, 21);
            this.item.TabIndex = 0;
            this.item.SelectedIndexChanged += new System.EventHandler(this.item_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT PRODUCT  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(40, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALL PRODUCT REPORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "SHOW ALL PRODUCT QUANTITY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRODUCT QUANTITY REPORT";
            // 
            // QuanitycrystalReportViewer
            // 
            this.QuanitycrystalReportViewer.ActiveViewIndex = -1;
            this.QuanitycrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuanitycrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.QuanitycrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanitycrystalReportViewer.Location = new System.Drawing.Point(3, 16);
            this.QuanitycrystalReportViewer.Name = "QuanitycrystalReportViewer";
            this.QuanitycrystalReportViewer.Size = new System.Drawing.Size(615, 438);
            this.QuanitycrystalReportViewer.TabIndex = 5;
            this.QuanitycrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.QuanitycrystalReportViewer);
            this.groupBox4.Location = new System.Drawing.Point(408, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(621, 457);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quantity Report";
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 506);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Quantity";
            this.Text = "Quantity";
            this.Load += new System.EventHandler(this.Quantity_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer QuanitycrystalReportViewer;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}