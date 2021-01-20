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
    public partial class nssf_payroll_temp_paymentPeriodSelector : Form
    {
        public nssf_payroll_temp_paymentPeriodSelector()
        {
            InitializeComponent();
        }

        private void btnsetupPayroll_Click(object sender, EventArgs e)
        {
            if(cboPaymentMonth.Text == string.Empty || cboPaymentYear.Text == string.Empty)
            {
                MessageBox.Show("Please fill in both the payment year and month to proceed","SetUp Payroll",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                Nss_archive.payment_year = cboPaymentYear.Text;
                Nss_archive.payment_month = cboPaymentMonth.Text;

                nssf_payroll_temp frmNew = new nssf_payroll_temp();
                frmNew.ShowDialog();

               
            }
        }
    }
}
