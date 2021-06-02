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
    public partial class frmLegacyReportFilter : Form
    {
      
        public frmLegacyReportFilter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dtPickerStart.Checked || !dtPickerEnd.Checked)
            {
                MessageBox.Show("Start and end dates are required", "Legacy Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                switch (LegacyReports.reportType)
                {
                    case "Legacy_DebtorsList":
                        LegacyReports.station_code = cboBranch.SelectedValue.ToString();
                        LegacyReports.begin_date = dtPickerStart.Value;
                        LegacyReports.end_date = dtPickerEnd.Value;
                        StaffPayrollReports.reportType = "Legacy_DebtorsList";
                        Guard_profiler.frm_staff_payroll_report_export Legacy_DebtorsList_export = new Guard_profiler.frm_staff_payroll_report_export();
                        Legacy_DebtorsList_export.ShowDialog();
                        break;
                    case "Legacy_income_and_expenditure_statement":
                        LegacyReports.station_code = cboBranch.SelectedValue.ToString() != "-1"? cboBranch.SelectedValue.ToString().Remove(cboBranch.SelectedValue.ToString().Length - 1, 1):"-1";
                        LegacyReports.begin_date = dtPickerStart.Value;
                        LegacyReports.end_date = dtPickerEnd.Value;
                        StaffPayrollReports.reportType = "Legacy_income_and_expenditure_statement";
                        Guard_profiler.frm_staff_payroll_report_export Legacy_Client_statement_export = new Guard_profiler.frm_staff_payroll_report_export();
                        Legacy_Client_statement_export.ShowDialog();
                        break;
                    case "Legacy_trial_balance":
                        LegacyReports.station_code = cboBranch.SelectedValue.ToString().Remove(cboBranch.SelectedValue.ToString().Length - 1, 1);
                        LegacyReports.begin_date = dtPickerStart.Value;
                        LegacyReports.end_date = dtPickerEnd.Value;
                        StaffPayrollReports.reportType = "Legacy_trial_balance";
                        Guard_profiler.frm_staff_payroll_report_export Legacy_trial_balance_export = new Guard_profiler.frm_staff_payroll_report_export();
                        Legacy_trial_balance_export.ShowDialog();
                        break;
                }

            }

        }

        protected void Load_stations()
        {
        DataTable dt = new DataTable();
        dt =   LegacyReports.LoadBranches("select_station_list");

            DataRow emptyRow = dt.NewRow();
            emptyRow["branch"] = "All";
            emptyRow["accounts_code"] = "-1";
            dt.Rows.InsertAt(emptyRow, 0);

            cboBranch.DataSource = dt;
            cboBranch.DisplayMember = "branch";
            cboBranch.ValueMember = "accounts_code";


            DataTable _dt = new DataTable();
            _dt = LegacyReports.LoadBranches("select_station_list");

            DataRow _emptyRow = _dt.NewRow();
            _emptyRow["branch"] = "select one";
            _emptyRow["accounts_code"] = "-1";
            _dt.Rows.InsertAt(_emptyRow, 0);

            cbostation.DataSource = _dt;
            cbostation.DisplayMember = "branch";
            cbostation.ValueMember = "accounts_code";
        }

        private void frmLegacyReportFilter_Load(object sender, EventArgs e)
        {
            EnableDisableFilters();
            Load_stations();
        }

        private void btnExportStatement_Click(object sender, EventArgs e)
        {
            if(cbostation.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Please select a station", "Client statement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!statement_start_date.Checked || !statement_end_date.Checked)
                {
                    MessageBox.Show("Start and end dates are required", "Legacy Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
            {
                LegacyReports.client_code = cboclient.SelectedValue.ToString();
                LegacyReports.begin_date = dtPickerStart.Value;
                LegacyReports.end_date = dtPickerEnd.Value;
                StaffPayrollReports.reportType = "Legacy_Client_statement";
                Guard_profiler.frm_staff_payroll_report_export Legacy_Client_statement_export = new Guard_profiler.frm_staff_payroll_report_export();
                Legacy_Client_statement_export.ShowDialog();
            }
        }

        private void cbostation_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LegacyReports.LoadClients("select_client_list",cbostation.SelectedValue.ToString());

            DataRow emptyRow = dt.NewRow();
            emptyRow["stitle"] = "All";
            emptyRow["scode"] = "-1";
            dt.Rows.InsertAt(emptyRow, 0);

            cboclient.DataSource = dt;
            cboclient.DisplayMember = "stitle";
            cboclient.ValueMember = "scode";
        }

        protected void EnableDisableFilters()
        {
            switch (LegacyReports.reportType)
            {
                case "Legacy_DebtorsList":
                    grpDebtorsList.Enabled = true;
                    grpDebtorsList.Text = "Debtors List Report Filter";
                    grpclientstatement.Enabled = false;
                    break;
                case "Legacy_income_and_expenditure_statement":
                    grpDebtorsList.Enabled = true;
                    grpDebtorsList.Text = "Income and Expenditure Report Filter";
                    grpclientstatement.Enabled = false;
                    break;
                case "Legacy_Client_statement":
                    grpDebtorsList.Enabled = false;
                    grpclientstatement.Enabled = true;
                    break;
                case "Legacy_trial_balance":
                    grpDebtorsList.Enabled = true;
                    grpDebtorsList.Text = "Trial Balance Report Filter";
                    grpclientstatement.Enabled = false;
                    break;
            }
        }
    }
}
