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
            }
        }
    }
}
