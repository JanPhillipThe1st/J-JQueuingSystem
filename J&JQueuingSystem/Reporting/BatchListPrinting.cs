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
    public partial class BatchListPrinting : Form
    {
        J_JQueuingSystem.Models.Queue queue = new J_JQueuingSystem.Models.Queue();
        DataTable dataTable = new DataTable();
        String school_name = "";
        public BatchListPrinting( DataTable dataTable,String school_name)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.school_name = school_name;
        }

        private void TrustReceiptPrinting_Load(object sender, EventArgs e)
        {
            BatchListReportViewer.LocalReport.DataSources.Clear();
            BatchListReportViewer.LocalReport.EnableExternalImages = true;

            BatchListReportViewer.LocalReport.DataSources.Add(new ReportDataSource("BatchListDataSet", dataTable));
            BatchListReportViewer.LocalReport.SetParameters(new ReportParameter("school", school_name));
            BatchListReportViewer.RefreshReport();
        }
    }
}
