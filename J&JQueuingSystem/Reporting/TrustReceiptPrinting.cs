using J_JQueuingSystem.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_JQueuingSystem.Reporting
{
    public partial class TrustReceiptPrinting : Form
    {
        J_JQueuingSystem.Models.Queue queue = new J_JQueuingSystem.Models.Queue();
        Customer customer = new Customer();
        public TrustReceiptPrinting(J_JQueuingSystem.Models.Queue queue, Customer customer)
        {
            InitializeComponent();
            this.queue = queue;
            this.customer = customer;
        }

        private void TrustReceiptPrinting_Load(object sender, EventArgs e)
        {
            TrustReceiptReportViewer.LocalReport.DataSources.Clear();
            TrustReceiptReportViewer.LocalReport.EnableExternalImages = true;
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("school", customer.school));
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("name", customer.name));
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("contact", customer.contact));
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("account_name", customer.account_name));
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("section", customer.school));
            TrustReceiptReportViewer.LocalReport.SetParameters(new ReportParameter("course", customer.course));
            TrustReceiptReportViewer.RefreshReport();
        }
    }
}
