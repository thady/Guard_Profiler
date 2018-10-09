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
    public partial class frmDeploymentscheduleReport : Form
    {
        public frmDeploymentscheduleReport()
        {
            this.InitializeComponent();
        }

        private void frmDeploymentscheduleReport_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            if (cbo_branch.Text == string.Empty || !this.dt_start_date.Checked || !this.dt_end_date.Checked)
            {
                MessageBox.Show("All values are required", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            SystemConst._station_name = cbo_branch.Text;
            SystemConst._finance_crystal_report_type = "DEPLOYMENT_SCHEDULE";
            (new frm_finance_detailed_guard_pay_roll_report()).Show();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = string.Empty;
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_branch.DataSource = dt;
                this.cbo_branch.DisplayMember = "branch";
                this.cbo_branch.ValueMember = "branch_code";

                this.cbo_branch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_branch.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
    }
}
