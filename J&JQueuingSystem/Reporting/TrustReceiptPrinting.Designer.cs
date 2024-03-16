namespace J_JQueuingSystem.Reporting
{
    partial class TrustReceiptPrinting
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
            this.TrustReceiptReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // TrustReceiptReportViewer
            // 
            this.TrustReceiptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrustReceiptReportViewer.LocalReport.ReportEmbeddedResource = "J_JQueuingSystem.Reporting.TrustReceipt.rdlc";
            this.TrustReceiptReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TrustReceiptReportViewer.Name = "TrustReceiptReportViewer";
            this.TrustReceiptReportViewer.ServerReport.BearerToken = null;
            this.TrustReceiptReportViewer.Size = new System.Drawing.Size(1343, 608);
            this.TrustReceiptReportViewer.TabIndex = 0;
            // 
            // TrustReceiptPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 608);
            this.Controls.Add(this.TrustReceiptReportViewer);
            this.Name = "TrustReceiptPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrustReceiptPrinting";
            this.Load += new System.EventHandler(this.TrustReceiptPrinting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TrustReceiptReportViewer;
    }
}