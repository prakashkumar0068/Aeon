namespace AeonNew
{
    partial class PaymentEntryBill
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
            this.grp_Bill_Reciept = new System.Windows.Forms.GroupBox();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grp_Bill_Reciept.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Bill_Reciept
            // 
            this.grp_Bill_Reciept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Bill_Reciept.Controls.Add(this.crystalReportViewer);
            this.grp_Bill_Reciept.Location = new System.Drawing.Point(12, 6);
            this.grp_Bill_Reciept.Name = "grp_Bill_Reciept";
            this.grp_Bill_Reciept.Size = new System.Drawing.Size(934, 511);
            this.grp_Bill_Reciept.TabIndex = 5;
            this.grp_Bill_Reciept.TabStop = false;
            this.grp_Bill_Reciept.Text = "Bill Reciept";
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(928, 492);
            this.crystalReportViewer.TabIndex = 5;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PaymentEntryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.grp_Bill_Reciept);
            this.Name = "PaymentEntryBill";
            this.Text = "Reciept";
            this.Load += new System.EventHandler(this.PaymentEntryBill_Load);
            this.grp_Bill_Reciept.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Bill_Reciept;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}