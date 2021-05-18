using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Accounts;
using AccountsBackEnd;

namespace Accounts
{
    public partial class frmLeagacyReports : Form
    {
        public frmLeagacyReports()
        {
            InitializeComponent();
        }

        private void btnDebtorsList_Click(object sender, EventArgs e)
        {
            frmLegacyReportFilter ReportFilter = new frmLegacyReportFilter();
            LegacyReports.reportType = "Legacy_DebtorsList";
            ReportFilter.ShowDialog();
        }

        private void btnClientstatement_Click(object sender, EventArgs e)
        {
            frmLegacyReportFilter ReportFilter = new frmLegacyReportFilter();
            LegacyReports.reportType = "Legacy_Client_statement";
            ReportFilter.ShowDialog();
        }

        private void btnIncomeExpenditure_Click(object sender, EventArgs e)
        {
            frmLegacyReportFilter ReportFilter = new frmLegacyReportFilter();
            LegacyReports.reportType = "Legacy_income_and_expenditure_statement";
            ReportFilter.ShowDialog();
        }

        private void btnTrialBalance_Click(object sender, EventArgs e)
        {
            frmLegacyReportFilter ReportFilter = new frmLegacyReportFilter();
            LegacyReports.reportType = "Legacy_trial_balance";
            ReportFilter.ShowDialog();
        }

        private void btnAccountEntries_Click(object sender, EventArgs e)
        {
            frmLegacyAccountEntries acc = new frmLegacyAccountEntries();
            acc.ShowDialog();
        }
    }
}
