using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frmCustomerManagement : Form
    {
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void btnCustomerProfiles_Click(object sender, EventArgs e)
        {
            (new frm_manage_clients()).Show();
        }

        private void btnBillingReport_Click(object sender, EventArgs e)
        {
            SystemConst._finance_report_type = "customer_bill";

            (new frm_finance_reports_parameter_selector()).ShowDialog();
        }
    }
}
