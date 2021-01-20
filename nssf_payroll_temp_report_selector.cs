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
    public partial class nssf_payroll_temp_report_selector : Form
    {
        public nssf_payroll_temp_report_selector()
        {
            InitializeComponent();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch_code"] = string.Empty;
                dtRow["branch"] = string.Empty;
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbobranch.DataSource = dt;
                this.cbobranch.DisplayMember = "branch";
                this.cbobranch.ValueMember = "branch_code";
            }
        }

        private void nssf_payroll_temp_report_selector_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            if (cboPaymentYear.Text == string.Empty || cboPaymentMonth.Text == string.Empty || cbobranch.Text == string.Empty || cboReportType.Text == string.Empty)
            {
                MessageBox.Show("Select all values to proceed", "Generate Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Nss_archive.Rbranch_name = cbobranch.Text;
                Nss_archive.Rpayment_month = cboPaymentMonth.Text;
                Nss_archive.Rpayment_year = cboPaymentYear.Text;
               

                if (cboReportType.Text == "NSSF Contribution Report")
                {
                    Nss_archive.QueryName = "select_nssf_report";
                    SystemConst._finance_crystal_report_type = "NSSF_Archive";
                }
                else
                {
                    SystemConst._finance_crystal_report_type = "Payroll_Archive";
                    Nss_archive.QueryName = "select_payroll_report";
                }
               
                frm_finance_detailed_guard_pay_roll_report frm = new frm_finance_detailed_guard_pay_roll_report();
                frm.ShowDialog();
            }
        }
    }
}
