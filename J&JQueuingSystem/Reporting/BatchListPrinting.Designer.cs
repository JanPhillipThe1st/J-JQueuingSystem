namespace J_JQueuingSystem.Reporting
{
    partial class BatchListPrinting
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
            this.BatchListReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BatchListReportViewer
            // 
            this.BatchListReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BatchListReportViewer.LocalReport.ReportEmbeddedResource = "J_JQueuingSystem.Reporting.BatchList.rdlc";
            this.BatchListReportViewer.Location = new System.Drawing.Point(0, 0);
            this.BatchListReportViewer.Name = "BatchListReportViewer";
            this.BatchListReportViewer.ServerReport.BearerToken = null;
            this.BatchListReportViewer.Size = new System.Drawing.Size(1343, 608);
            this.BatchListReportViewer.TabIndex = 0;
            // 
            // BatchListPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 608);
            this.Controls.Add(this.BatchListReportViewer);
            this.Name = "BatchListPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrustReceiptPrinting";
            this.Load += new System.EventHandler(this.TrustReceiptPrinting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BatchListReportViewer;
    }
}