using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccountsBackEnd;
using Guard_profiler.App_code;

namespace Accounts
{
    public partial class frmInvoiceReportFilter : Form
    {
        DataTable dt = new DataTable();
        public frmInvoiceReportFilter()
        {
            InitializeComponent();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (!dtReportDate.Checked)
            {
                MessageBox.Show("Please select report date", "Invoice Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(cboClient.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a client tp generate invoice", "Invoice Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AccountsReportsEngine.reportName = "Invoice";
                AccountsReportsEngine.report_date = dtReportDate.Value.Date;
                AccountsReportsEngine.client_id = cboClient.SelectedValue.ToString();
                StaffPayrollReports.reportType = "Accounts_Invoice";
                Guard_profiler.frm_staff_payroll_report_export InvoiceReport = new Guard_profiler.frm_staff_payroll_report_export();
                InvoiceReport.ShowDialog();
            }
        }

        protected void LoadClients()
        {
            dt = AccountsReportsEngine.LoadClientListing("LoadClients");
            DataRow dtRow = dt.NewRow();
            dtRow["sub_title"] = "select client";
            dtRow["sub_id"] = string.Empty;
            dt.Rows.InsertAt(dtRow, 0);

            cboClient.DataSource = dt;
            cboClient.DisplayMember = "sub_title";
            cboClient.ValueMember = "sub_id";
        }

        private void frmInvoiceReportFilter_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
    }
}
