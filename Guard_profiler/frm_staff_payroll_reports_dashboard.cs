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
    public partial class frm_staff_payroll_reports_dashboard : Form
    {
        public frm_staff_payroll_reports_dashboard()
        {
            InitializeComponent(); 
        }

        private void btn_detailed_reports_Click(object sender, EventArgs e)
        {
            StaffPayrollReports.reportType = "Payroll Report";
            frm_staff_payroll_report_selector pay = new frm_staff_payroll_report_selector();
            pay.ShowDialog();

        }

        private void frm_staff_payroll_reports_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnbank_payment_report_Click(object sender, EventArgs e)
        {
            StaffPayrollReports.reportType = "Bank Payment Schedule";
            frm_staff_payroll_report_selector pay = new frm_staff_payroll_report_selector();
            pay.ShowDialog();
        }

        private void btnNssf_Click(object sender, EventArgs e)
        {
            StaffPayrollReports.reportType = "NSSF";
            frm_staff_payroll_report_selector pay = new frm_staff_payroll_report_selector();
            pay.ShowDialog();
        }

        private void btnpaye_Click(object sender, EventArgs e)
        {
            StaffPayrollReports.reportType = "PAYE";
            frm_staff_payroll_report_selector pay = new frm_staff_payroll_report_selector();
            pay.ShowDialog();
        }

        private void btnlst_Click(object sender, EventArgs e)
        {
            StaffPayrollReports.reportType = "LST";
            frm_staff_payroll_report_selector pay = new frm_staff_payroll_report_selector();
            pay.ShowDialog();
        }
    }
}
