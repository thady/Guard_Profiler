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
    public partial class frm_staff_payroll_summary : Form
    {
        public frm_staff_payroll_summary()
        {
            InitializeComponent();
        }

        private void frm_staff_payroll_summary_Load(object sender, EventArgs e)
        {
            LoadPaymentPeriods();
            GET_BRANCHES();
        }

        protected void LoadPaymentPeriods()
        {
            DataTable dt = StaffProfiles.Return_staff_list("select_accounts_payment_periods");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["payment_period_id"] = -1;
                dtRow["pay_year"] = "select year";
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_deploy_period.DisplayMember = "pay_year";
                this.cbo_deploy_period.ValueMember = "payment_period_id";
                this.cbo_deploy_period.DataSource = dt;
                //this.cbo_deploy_period.Enabled = false;
            }
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["auto_id"] = -1;
                dtRow["accounts_code"] = "-1";
                dtRow["branch"] = "select branch";
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_branch.DataSource = dt;
                this.cbo_branch.DisplayMember = "branch";
                this.cbo_branch.ValueMember = "accounts_code";

                cbo_branch.SelectedIndex = 0;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            StaffPayrollReports._payment_period_id = Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString());
            StaffPayrollReports._branch_id = cbo_branch.SelectedValue.ToString() != "-1" ? cbo_branch.SelectedValue.ToString() : string.Empty;
            StaffPayrollReports._payment_month = cbo_payment_month.Text;
           
            frm_staff_payroll_summary_view summ = new frm_staff_payroll_summary_view();
            summ.ShowDialog();
        }
    }
}
