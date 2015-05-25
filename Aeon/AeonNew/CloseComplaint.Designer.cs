namespace AeonNew
{
    partial class CloseComplaint
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
            this.complaintGridview = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timecloseText = new System.Windows.Forms.Label();
            this.personclosedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.faultTextbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.actiontakenText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintGridview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.complaintGridview);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.timecloseText);
            this.groupBox1.Controls.Add(this.personclosedLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // complaintGridview
            // 
            this.complaintGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintGridview.Location = new System.Drawing.Point(479, 38);
            this.complaintGridview.Name = "complaintGridview";
            this.complaintGridview.Size = new System.Drawing.Size(445, 94);
            this.complaintGridview.TabIndex = 9;
            this.complaintGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.complaintGridview_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(611, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Select Complaint To Close";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time Of Closing Complaint : ";
            // 
            // timecloseText
            // 
            this.timecloseText.AutoSize = true;
            this.timecloseText.Location = new System.Drawing.Point(232, 83);
            this.timecloseText.Name = "timecloseText";
            this.timecloseText.Size = new System.Drawing.Size(38, 19);
            this.timecloseText.TabIndex = 6;
            this.timecloseText.Text = "time";
            // 
            // personclosedLabel
            // 
            this.personclosedLabel.AutoSize = true;
            this.personclosedLabel.Location = new System.Drawing.Point(232, 113);
            this.personclosedLabel.Name = "personclosedLabel";
            this.personclosedLabel.Size = new System.Drawing.Size(49, 19);
            this.personclosedLabel.TabIndex = 5;
            this.personclosedLabel.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Person Closing Complaint : ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(232, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(49, 19);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "label4";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(232, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Closing Complaint : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Of The Client : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.faultTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fault Reported";
            // 
            // faultTextbox
            // 
            this.faultTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultTextbox.Location = new System.Drawing.Point(3, 23);
            this.faultTextbox.Multiline = true;
            this.faultTextbox.Name = "faultTextbox";
            this.faultTextbox.Size = new System.Drawing.Size(449, 211);
            this.faultTextbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.actiontakenText);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(492, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action Taken";
            // 
            // actiontakenText
            // 
            this.actiontakenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actiontakenText.Location = new System.Drawing.Point(3, 23);
            this.actiontakenText.Multiline = true;
            this.actiontakenText.Name = "actiontakenText";
            this.actiontakenText.Size = new System.Drawing.Size(457, 211);
            this.actiontakenText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 27);
            this.textBox1.TabIndex = 10;
            // 
            // CloseComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CloseComplaint";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Close Complaint";
            this.Load += new System.EventHandler(this.CloseComplaint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintGridview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView complaintGridview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timecloseText;
        private System.Windows.Forms.Label personclosedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox faultTextbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox actiontakenText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}