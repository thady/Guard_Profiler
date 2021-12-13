using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts
{
    public partial class frmAccountsReportFilter : Form
    {
        public frmAccountsReportFilter()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoiceReportFilter frmInvoice = new frmInvoiceReportFilter();
            frmInvoice.ShowDialog();
        }

        private void btnAgedDebtorsReport_Click(object sender, EventArgs e)
        {
            frmAgedDebtorsReportFilter frmDebtors = new frmAgedDebtorsReportFilter();
            frmDebtors.ShowDialog();
        }
    }
}
