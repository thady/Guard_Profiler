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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

using Accounts;
using Accounts.Legacy_Reports;
using AccountsBackEnd;


namespace Guard_profiler
{
    public partial class frm_staff_payroll_report_export : Form
    {
        public frm_staff_payroll_report_export()
        {
            InitializeComponent();
        }

        private void frm_staff_payroll_report_export_Load(object sender, EventArgs e)
        {
            LoadReports(StaffPayrollReports.reportType);
        }

        protected void LoadReports(string ReportType)
        {
            switch (ReportType)
            {
                case "Payroll Report":

                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        cr_staff_payroll report = new cr_staff_payroll();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(StaffPayrollReports.select_staff_payroll("select_staff_payroll", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month));
                        report.SetParameterValue("QueryName", "select_staff_payroll");
                        report.SetParameterValue("branch_id", StaffPayrollReports._branch_id);
                        report.SetParameterValue("branch_name", StaffPayrollReports._branch_id);
                        report.SetParameterValue("payment_month", StaffPayrollReports._payment_month);
                        report.SetParameterValue("payment_period_id", StaffPayrollReports._payment_period_id);
                        report.SetParameterValue("client_name", SystemConst.ClientName);

                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }

                    break;
                case "Bank Payment Schedule":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        cr_staff_bank_schedule report = new cr_staff_bank_schedule();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(StaffPayrollReports.select_staff_payroll("select_staff_bank_schedule", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month));
                        report.SetParameterValue("QueryName", "select_staff_bank_schedule");
                        report.SetParameterValue("branch_id", StaffPayrollReports._branch_id);
                        report.SetParameterValue("payment_month", StaffPayrollReports._payment_month);
                        report.SetParameterValue("payment_period_id", StaffPayrollReports._payment_period_id);
                        report.SetParameterValue("bank_name", StaffPayrollReports.bank_name);
                        report.SetParameterValue("client_name", SystemConst.ClientName);

                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "NSSF":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        cr_staff_nssf_report report = new cr_staff_nssf_report();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(StaffPayrollReports.select_staff_payroll("select_staff_nssf_report", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month));
                        report.SetParameterValue("QueryName", "select_staff_nssf_report");
                        report.SetParameterValue("branch_id", StaffPayrollReports._branch_id);
                        report.SetParameterValue("branch_name", StaffPayrollReports._branch_id);
                        report.SetParameterValue("payment_month", StaffPayrollReports._payment_month);
                        report.SetParameterValue("payment_period_id", StaffPayrollReports._payment_period_id);
                        report.SetParameterValue("client_name", SystemConst.ClientName);

                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "PAYE":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        cr_staff_paye_report report = new cr_staff_paye_report();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(StaffPayrollReports.select_staff_payroll("select_staff_paye_report", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month));
                        report.SetParameterValue("QueryName", "select_staff_paye_report");
                        report.SetParameterValue("branch_id", StaffPayrollReports._branch_id);
                        report.SetParameterValue("payment_month", StaffPayrollReports._payment_month);
                        report.SetParameterValue("payment_period_id", StaffPayrollReports._payment_period_id);
                        report.SetParameterValue("client_name", SystemConst.ClientName);

                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "LST":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        cr_staff_local_service_tax_report report = new cr_staff_local_service_tax_report();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(StaffPayrollReports.select_staff_payroll("select_staff_local_service_tax_report", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month));
                        report.SetParameterValue("QueryName", "select_staff_local_service_tax_report");
                        report.SetParameterValue("branch_id", StaffPayrollReports._branch_id);
                        report.SetParameterValue("payment_month", StaffPayrollReports._payment_month);
                        report.SetParameterValue("payment_period_id", StaffPayrollReports._payment_period_id);
                        report.SetParameterValue("client_name", SystemConst.ClientName);
                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;

                #region LegacyReports
                case "Legacy_DebtorsList":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        crDebtorsReport report = new crDebtorsReport();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(AccountsBackEnd.LegacyReports.LoadDebtorsListing("select_debtors_list", LegacyReports.station_code, LegacyReports.begin_date,LegacyReports.end_date));
                        report.SetParameterValue("queryname", "select_debtors_list");
                        report.SetParameterValue("station_code", LegacyReports.station_code);
                        report.SetParameterValue("begin_date", LegacyReports.begin_date);
                        report.SetParameterValue("end_date", LegacyReports.end_date);
                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "Legacy_Client_statement":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        crClientstatementReport report = new crClientstatementReport();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(AccountsBackEnd.LegacyReports.LoadClientStatement("select_client_account_statement", LegacyReports.client_code, LegacyReports.begin_date, LegacyReports.end_date));
                        report.SetParameterValue("queryname", "select_client_account_statement");
                        report.SetParameterValue("client_code", LegacyReports.client_code);
                        report.SetParameterValue("begin_date", LegacyReports.begin_date);
                        report.SetParameterValue("end_date", LegacyReports.end_date);
                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "Legacy_income_and_expenditure_statement":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        crIncomeExpenditureReport report = new crIncomeExpenditureReport();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(AccountsBackEnd.LegacyReports.LoadIncomeandExpenditureReport("income_and_expenditure", LegacyReports.station_code, LegacyReports.begin_date, LegacyReports.end_date));
                        report.SetParameterValue("queryname", "income_and_expenditure");
                        report.SetParameterValue("subpcode", LegacyReports.station_code);
                        report.SetParameterValue("begin_date", LegacyReports.begin_date);
                        report.SetParameterValue("end_date", LegacyReports.end_date);
                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                case "Legacy_trial_balance":
                    try
                    {
                        base.WindowState = FormWindowState.Maximized;
                        crTrialbalance report = new crTrialbalance();
                        ParameterFields paramFields = new ParameterFields();
                        ParameterField parameterField = new ParameterField();
                        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                        foreach (Table tbCurrent in report.Database.Tables)
                        {
                            Set_Report_logons.SetTableLogin(tbCurrent);
                        }
                        report.SetDataSource(AccountsBackEnd.LegacyReports.LoadIncomeandExpenditureReport("trial_balance", LegacyReports.station_code, LegacyReports.begin_date, LegacyReports.end_date));
                        report.SetParameterValue("queryname", "trial_balance");
                        report.SetParameterValue("subpcode", LegacyReports.station_code);
                        report.SetParameterValue("begin_date", LegacyReports.begin_date);
                        report.SetParameterValue("end_date", LegacyReports.end_date);
                        this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                        this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                    break;
                    #endregion
            }
        }
    }
}
