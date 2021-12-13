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
    public partial class frmAgedDebtorsReportFilter : Form
    {
        DataTable dt = new DataTable();
        public frmAgedDebtorsReportFilter()
        {
            InitializeComponent();
        }

        private void frmAgedDebtorsReportFilter_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        protected void LoadClients()
        {
            dt = AccountsReportsEngine.LoadClientListing("select_branch");
            DataRow dtRow = dt.NewRow();
            dtRow["branch"] = "select branch";
            dtRow["record_guid"] = string.Empty;
            dt.Rows.InsertAt(dtRow, 0);

            cboBranch.DataSource = dt;
            cboBranch.DisplayMember = "branch";
            cboBranch.ValueMember = "record_guid";
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {

            if (!dtstartDate.Checked || !dtEndDate.Checked)
            {
                MessageBox.Show("Please select start and end date", "Invoice Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cboBranch.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a branch to generate report", "Aged Debtors Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AccountsReportsEngine.reportName = "debtors_aged_report";
                AccountsReportsEngine.begin_date = dtstartDate.Value.Date;
                AccountsReportsEngine.end_date = dtEndDate.Value.Date;
                AccountsReportsEngine.branch = cboBranch.SelectedValue.ToString();
                StaffPayrollReports.reportType = "Accounts_Aged_Debtors";
                Guard_profiler.frm_staff_payroll_report_export InvoiceReport = new Guard_profiler.frm_staff_payroll_report_export();
                InvoiceReport.ShowDialog();
            }
        }
    }
}
