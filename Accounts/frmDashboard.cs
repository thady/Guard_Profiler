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

namespace Accounts
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAccountCategory_Click(object sender, EventArgs e)
        {
            frmAccountCategory frmCategory = new frmAccountCategory();
            frmCategory.ShowDialog();
        }

        private void btnAccountsChart_Click(object sender, EventArgs e)
        {
            frmChartofAccounts frmChart = new frmChartofAccounts();
            frmChart.Show();
        }

        private void btnJournalEntry_Click(object sender, EventArgs e)
        {
            frmJournalEntry jEntry = new frmJournalEntry();
            jEntry.ShowDialog();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            frmBranches frmbranch = new frmBranches();
            frmbranch.ShowDialog();
        }

        private void btnsubLedger_Click(object sender, EventArgs e)
        {
            frmSubLedgerCategory frmNew = new frmSubLedgerCategory();
            frmNew.ShowDialog();
        }

        private void btnsubsidiaryAcc_Click(object sender, EventArgs e)
        {
            frmsubsidiaryAccount frmNew = new frmsubsidiaryAccount();
            frmNew.ShowDialog();

        }

        private void btnvoice_Click(object sender, EventArgs e)
        {
            frmInvoice inv = new frmInvoice();
            inv.ShowDialog();
        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            frmReceipts frmReceipt = new frmReceipts();
            frmReceipt.ShowDialog();
        }

        private void btnLeagacyApp_Click(object sender, EventArgs e)
        {
            frmLeagacyReports frmLegacy = new frmLeagacyReports();
            frmLegacy.ShowDialog();
        }

        private void btnAccountsReports_Click(object sender, EventArgs e)
        {
            frmAccountsReportFilter frmNew = new frmAccountsReportFilter();
            frmNew.ShowDialog();
        }
    }
}
