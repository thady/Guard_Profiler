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
    public partial class frm_staff_payroll_report_selector : Form
    {
        private static DataTable dt_stations;
        public frm_staff_payroll_report_selector()
        {
            InitializeComponent();
        }

        private void frm_staff_payroll_report_selector_Load(object sender, EventArgs e)
        {
            LoadPaymentPeriods();
            GET_BRANCHES();
            LoadReportType();
            get_bank_list();
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

        protected void LoadReportType()
        {
            lblReportType.Text = StaffPayrollReports.reportType;

            if (StaffPayrollReports.reportType == "Bank Payment Schedule")
            {
                grpboxBank_schedule.Visible = true;
            }
            else
            {
                grpboxBank_schedule.Visible = false;
            }
        }

        //protected void GET_BRANCHES()
        //{
        //    DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
        //    if (dt != null)
        //    {
        //        DataRow dtRow = dt.NewRow();
        //        dtRow["record_guid"] = string.Empty;
        //        dtRow["auto_id"] = -1;
        //        dtRow["accounts_code"] = "-1";
        //        dtRow["branch"] = "select branch";
        //        dtRow["active"] = true;
        //        dt.Rows.InsertAt(dtRow, 0);
        //        this.cbo_branch.DataSource = dt;
        //        this.cbo_branch.DisplayMember = "branch";
        //        this.cbo_branch.ValueMember = "accounts_code";

        //        cbo_branch.SelectedIndex = 0;
        //    }
        //}

        protected void GET_BRANCHES()
        {
            dt_stations = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt_stations != null)
            {
                for (int i = 0; i < dt_stations.Rows.Count; i++)
                {
                    this.chklist_branches.Items.Add(dt_stations.Rows[i]["branch"].ToString());
                }
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (ValidateReport(StaffPayrollReports.reportType))
            {
                StaffPayrollReports.reportType = lblReportType.Text;
                StaffPayrollReports._payment_period_id = Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString());
                StaffPayrollReports._branch_id = generate_branch_list();
                StaffPayrollReports._payment_month = cbo_payment_month.Text;

                #region set bank name
                if (grpboxBank_schedule.Visible == true)
                {
                    StaffPayrollReports.bank_name = cbo_bank.Text + "-" + cbo_bank_branch.Text;
                }

                #endregion

                frm_staff_payroll_report_export export = new frm_staff_payroll_report_export();
                export.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select all required values to generate report", "Finance Reporting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }

        private string generate_branch_list()
        {
            string station_name = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            string branch_list = string.Empty;
            List<string> station_list = new List<string>();
            if (dt_stations.Rows.Count > 0)
            {
                for (int i = 0; i < dt_stations.Rows.Count; i++)
                {
                    DataRow dtRow_station = dt_stations.Rows[i];
                    station_name = dtRow_station["branch"].ToString();
                    if (this.chklist_branches.CheckedItems.Contains(station_name))
                    {
                        station_list.Add(station_name);
                    }
                }
                branch_list = string.Join(",", station_list.ToArray());
                char[] chrArray = new char[] { ',' };
                string.Join(",", (
                    from x in branch_list.Split(chrArray)
                    select string.Format("'{0}'", x)).ToList<string>());
                
            }

            return branch_list;
        }

        protected bool ValidateReport(string reportType)
        {
            bool isvalid = false;
            if (reportType == "Bank Payment Schedule")
            {
                if (cbo_deploy_period.SelectedValue.ToString() == "-1" || cbo_payment_month.Text == string.Empty || cbo_bank.SelectedValue.ToString() == "-1" || cbo_bank_branch.SelectedValue.ToString() == "-1")
                {
                    isvalid = false;                   
                }
                else
                {
                    isvalid = true;
                } 
            }
            else
            {
                if (cbo_deploy_period.SelectedValue.ToString() == "-1" || cbo_payment_month.Text == string.Empty)
                {
                    isvalid = false;
                    
                }
                else
                {
                    isvalid = true;
                }
            }

            return isvalid;
        }

        protected void get_bank_list()
        {
            DataTable dt = Salary_scales.return_bank_lists("return_bank_lists");
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_id"] = -1;
                dtRow["bank_code"] = string.Empty;
                dtRow["bank_name"] = string.Empty;
                dtRow["bank_active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_bank.DisplayMember = "bank_name";
                this.cbo_bank.ValueMember = "record_id";
                this.cbo_bank.DataSource = dt;
            }
        }

        protected void get_bank_branches(int bank_id)
        {
            DataTable dt = Salary_scales.get_bank_branches("get_bank_branches", bank_id);
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["branch_id"] = -1;
                dtRow["bank_id"] = -1;
                dtRow["branch_name"] = string.Empty;
                dtRow["branch_active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_bank_branch.DisplayMember = "branch_name";
                this.cbo_bank_branch.ValueMember = "branch_id";
                this.cbo_bank_branch.DataSource = dt;
            }
        }

        private void cbo_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbo_bank.SelectedValue.ToString() != "-1")
            {
                this.get_bank_branches(Convert.ToInt32(this.cbo_bank.SelectedValue.ToString()));
            }
        }
    }
}
