namespace AeonNew
{
    partial class ChangeEngineer
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
            this.complaintgridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previousLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintgridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.complaintgridView);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Complaint";
            // 
            // complaintgridView
            // 
            this.complaintgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintgridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complaintgridView.Location = new System.Drawing.Point(3, 23);
            this.complaintgridView.Name = "complaintgridView";
            this.complaintgridView.Size = new System.Drawing.Size(679, 109);
            this.complaintgridView.TabIndex = 0;
            this.complaintgridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.complaintgridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name : ";
            // 
            // clientNamelabel
            // 
            this.clientNamelabel.AutoSize = true;
            this.clientNamelabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNamelabel.Location = new System.Drawing.Point(121, 9);
            this.clientNamelabel.Name = "clientNamelabel";
            this.clientNamelabel.Size = new System.Drawing.Size(101, 19);
            this.clientNamelabel.TabIndex = 2;
            this.clientNamelabel.Text = "Client Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of previous engineer : ";
            // 
            // previousLabel
            // 
            this.previousLabel.AutoSize = true;
            this.previousLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousLabel.Location = new System.Drawing.Point(342, 187);
            this.previousLabel.Name = "previousLabel";
            this.previousLabel.Size = new System.Drawing.Size(101, 19);
            this.previousLabel.TabIndex = 4;
            this.previousLabel.Text = "Client Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "New engineer : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(346, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 27);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeEngineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.previousLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientNamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeEngineer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Change Engineer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChangeEngineer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complaintgridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView complaintgridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clientNamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label previousLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}