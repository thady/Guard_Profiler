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
    public partial class frm_setup_payroll_staff : Form
    {
        private static decimal _Total_cash_deductions;
        private static string staff_id = string.Empty;
        private decimal advance_paid_amt_to_be_updated = 0;
        public frm_setup_payroll_staff()
        {
            InitializeComponent();
        }

        private void frm_setup_payroll_staff_Load(object sender, EventArgs e)
        {
            Get_staff_profiles();
            LoadPaymentPeriods();
            LoadPaymentPeriods_search();
            select_staff_list_payroll_search();
        }

        protected void Get_staff_profiles()
        {
            DataTable dt = StaffProfiles.Return_staff_list("select_staff_list");
            if (dt != null)
            {
                gdv_staff.DataSource = dt;
                gdv_staff.Columns["st_id"].Visible = false;
                gdv_staff.Columns["branch_id"].Visible = false;
                gdv_staff.Columns["st_position"].Visible = false;
                gdv_staff.Columns["bank_id"].Visible = false;
                gdv_staff.Columns["bank_branch_id"].Visible = false;
                gdv_staff.Columns["basic_amt"].Visible = false;
                gdv_staff.Columns["transport_amt"].Visible = false;
                gdv_staff.Columns["housing_amt"].Visible = false;

                gdv_staff.Columns["st_name"].HeaderText = "Name";
                gdv_staff.Columns["st_number"].HeaderText = "Personal Number";
                gdv_staff.Columns["st_gender"].HeaderText = "Sex";
                gdv_staff.Columns["st_status"].HeaderText = "Employee Status";
                gdv_staff.Columns["nss_number"].HeaderText = "NSSF Number";
                gdv_staff.Columns["bank_acc_number"].HeaderText = "Bank Account Number";
                gdv_staff.Columns["tin_number"].HeaderText = "Tin Number";


                gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                gdv_staff.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                gdv_staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_staff.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in this.gdv_staff.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 13f, GraphicsUnit.Pixel);
                }
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_staff.EnableHeadersVisualStyles = false;
            }
        }

        protected void select_staff_payroll(string st_id,int payment_period_id,string pay_month)
        {
            
            DataTable dt = StaffProfiles.Return_staff_payroll("select_staff_payroll_details", st_id, payment_period_id, pay_month);
            
            if (dt.Rows.Count > 0)
            {
                DataRow dtrow = dt.Rows[0];

                txt_record_guid.Text = dtrow["record_guid"].ToString();
                txt_personal_number.Text = dtrow["st_number"].ToString();
                txt_staff_name.Text = dtrow["st_name"].ToString();
                txt_bank_code.Text = dtrow["bank_code"].ToString();
                txt_bank_name.Text = dtrow["bank_name"].ToString();
                txt_bank_branch.Text = dtrow["branch_name"].ToString();
                txt_account_number.Text = dtrow["bank_acc_number"].ToString();
                txt_nssf.Text = dtrow["nss_number"].ToString();
               
                string payment_month = dtrow["payment_month"].ToString();
                if (payment_month != string.Empty)
                {
                    cbo_deploy_period.SelectedValue = Convert.ToInt32(dtrow["payment_period_id"]).ToString();
                    cbo_payment_month.Text = dtrow["payment_month"].ToString();
                    txt_basic_amt.Text = decimal.Parse(dtrow["basic_amt"].ToString()).ToString();
                    txt_transport_amt.Text = decimal.Parse(dtrow["transport_amt"].ToString()).ToString();
                    txt_housing_amt.Text = decimal.Parse(dtrow["HousingAmt"].ToString()).ToString();
                    txt_over_time_amt.Text = decimal.Parse(dtrow["overtime_amt"].ToString()).ToString();
                    txt_special_amt.Text = decimal.Parse(dtrow["special_amt"].ToString()).ToString();
                    txt_leave_amt.Text = decimal.Parse(dtrow["leave_amt"].ToString()).ToString();
                    txt_lst_amt.Text = decimal.Parse(dtrow["local_service_tax_amt"].ToString()).ToString();
                    txt_loan_amt.Text = decimal.Parse(dtrow["loan_amt"].ToString()).ToString();
                    txt_advance_amt_paid.Text = decimal.Parse(dtrow["advance_amt"].ToString()).ToString();
                    advance_paid_amt_to_be_updated = decimal.Parse(dtrow["advance_amt"].ToString());
                    txt_gross_amt.Text = decimal.Parse(dtrow["gross_pay_amt"].ToString()).ToString();
                    txt_paye_amt.Text = decimal.Parse(dtrow["total_paye_amt"].ToString()).ToString();
                    txt_nssf_amt.Text = decimal.Parse(dtrow["total_nssf_amt"].ToString()).ToString();
                    txt_total_deductions.Text = decimal.Parse(dtrow["total_deductions"].ToString()).ToString();
                    txt_net_pay.Text = decimal.Parse(dtrow["staff_net_pay_amt"].ToString()).ToString();
                    chk_pay_paye.Checked = Convert.ToBoolean(dtrow["pay_paye"]);
                    chk_pay_nssf.Checked = Convert.ToBoolean(dtrow["pay_nssf"]);
                    chk_pay_advance.Checked = Convert.ToBoolean(dtrow["pay_advance"]);
                    chk_print_bank_schedule.Checked = Convert.ToBoolean(dtrow["print_bank_schedule"]);
                    chk_print_payroll.Checked = Convert.ToBoolean(dtrow["print_pay_roll"]);
                    txt_ovt_days.Text = dtrow["over_time_days"].ToString();
                }
                else
                {
                    cbo_deploy_period.SelectedValue = -1;
                    cbo_payment_month.Text = string.Empty;
                    txt_basic_amt.Clear();
                    txt_transport_amt.Clear();
                    txt_housing_amt.Clear();
                    txt_over_time_amt.Clear();
                    txt_special_amt.Clear();
                    txt_leave_amt.Clear();
                    txt_lst_amt.Clear();
                    txt_loan_amt.Clear();
                    txt_advance_amt_paid.Clear();
                    txt_gross_amt.Clear();
                    txt_paye_amt.Clear();
                    txt_nssf_amt.Clear();
                    txt_total_deductions.Clear();
                    txt_net_pay.Clear();
                    chk_pay_paye.Checked = false;
                    chk_pay_nssf.Checked = false;
                    chk_pay_advance.Checked = false;
                    chk_print_bank_schedule.Checked = true;
                    chk_print_payroll.Checked = true;
                    txt_ovt_days.Clear();
                }
            }
            else
            {
               
                DataTable _dt = StaffProfiles.select_staff_details_payroll_setup("select_staff_details_payroll_setup",st_id);
                if (_dt.Rows.Count > 0)
                {
                    DataRow _dtRow = _dt.Rows[0];

                    txt_personal_number.Text = _dtRow["st_number"].ToString();
                    txt_staff_name.Text = _dtRow["st_name"].ToString();
                    txt_bank_code.Text = _dtRow["bank_code"].ToString();
                    txt_bank_name.Text = _dtRow["bank_name"].ToString();
                    txt_bank_branch.Text = _dtRow["branch_name"].ToString();
                    txt_account_number.Text = _dtRow["bank_acc_number"].ToString();
                    txt_nssf.Text = _dtRow["nss_number"].ToString();
                   // MessageBox.Show(_dtRow["basicAmt"].ToString());
                    txt_basic_amt.Text = decimal.Parse(_dtRow["basicAmt"].ToString()).ToString();
                    txt_transport_amt.Text = decimal.Parse(_dtRow["TransportAmt"].ToString()).ToString();
                    txt_housing_amt.Text = decimal.Parse(_dtRow["HousingAmt"].ToString()).ToString();
                }

                txt_record_guid.Clear();
                cbo_deploy_period.SelectedValue = -1;
                cbo_payment_month.Text = string.Empty;
                //txt_basic_amt.Clear();
                //txt_transport_amt.Clear();
                //txt_housing_amt.Clear();
                txt_over_time_amt.Clear();
                txt_special_amt.Clear();
                txt_leave_amt.Clear();
                txt_lst_amt.Clear();
                txt_loan_amt.Clear();
                txt_advance_amt_paid.Clear();
                txt_gross_amt.Clear();
                txt_paye_amt.Clear();
                txt_nssf_amt.Clear();
                txt_total_deductions.Clear();
                txt_net_pay.Clear();
                chk_pay_paye.Checked = false;
                chk_pay_nssf.Checked = false;
                chk_pay_advance.Checked = false;
                chk_print_bank_schedule.Checked = true;
                chk_print_payroll.Checked = true;
                txt_ovt_days.Clear();
            }
        }

        protected void select_staff_advance(string st_id)
        {
            DataTable dt = StaffProfiles.Return_staff_advance("select_staff_advance_details", st_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtrow = dt.Rows[0];
                txt_advance_amt.Text = decimal.Parse(dtrow["ad_balance_amount"].ToString()).ToString();
                txt_advace_amt_principle.Text = decimal.Parse(dtrow["ad_amount"].ToString()).ToString();
                txt_advance_paid.Text = decimal.Parse(dtrow["ad_paid_amount"].ToString()).ToString();
            }
            else
            {
                txt_advance_amt.Text = "0";
                txt_advace_amt_principle.Text = "0";
                txt_advance_paid.Text = "0";
            }
        }

        private void gdv_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_staff.Rows.Count > 0)
            {
                string st_id = gdv_staff.CurrentRow.Cells[0].Value.ToString();
                staff_id = st_id;
               
                select_staff_payroll(st_id,Convert.ToInt32(cbo_deploy_period_search.SelectedValue.ToString()),cbo_payment_month_search.Text);
                ResetLoanDetails();
                lblTotalLoansBalance.Text = StaffProfiles.select_staff_loan_balance("select_staff_loan_balance", st_id);
               // select_staff_advance(st_id);


            }
        }



        protected void Calculate_guard_salary_amounts()
        {
            bool flag;
            decimal basic_amt = (this.txt_basic_amt.Text != string.Empty ? decimal.Parse(this.txt_basic_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal transport_amt = (this.txt_transport_amt.Text != string.Empty ? decimal.Parse(this.txt_transport_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal bonus_amt = (this.txt_housing_amt.Text != string.Empty ? decimal.Parse(this.txt_housing_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal leave_amt = (this.txt_leave_amt.Text != string.Empty ? decimal.Parse(this.txt_leave_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal over_time_amt = (this.txt_over_time_amt.Text != string.Empty ? decimal.Parse(this.txt_over_time_amt.Text) : new decimal(0, 0, 0, false, 1));            
            decimal special_amt = (this.txt_special_amt.Text != string.Empty ? decimal.Parse(this.txt_special_amt.Text) : new decimal(0, 0, 0, false, 1));
            
            decimal _Gross_amount = ((((((basic_amt + transport_amt)) + bonus_amt) + leave_amt) + over_time_amt)) + special_amt;
            

            decimal lst_amt = (this.txt_lst_amt.Text != string.Empty ? decimal.Parse(this.txt_lst_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal advance_amt = (this.txt_advance_amt_paid.Text != string.Empty ? decimal.Parse(this.txt_advance_amt_paid.Text) : new decimal(0, 0, 0, false, 1));
            decimal loan_amt = (this.txt_loan_amt.Text != string.Empty ? decimal.Parse(this.txt_loan_amt.Text) : new decimal(0, 0, 0, false, 1));

            _Total_cash_deductions = ((((loan_amt + lst_amt)) + advance_amt)); 
            decimal PAYE_amt = chk_pay_paye.Checked? this.Calculate_PAYE(_Gross_amount):0;
            decimal Nssf_amt = chk_pay_nssf.Checked ? this.Calculate_NSSF(_Gross_amount) : 0;
            _Total_cash_deductions = (_Total_cash_deductions + PAYE_amt) + Nssf_amt;
            decimal _Net_Pay = _Gross_amount - _Total_cash_deductions;
            this.txt_gross_amt.Text = _Gross_amount.ToString();
            this.txt_paye_amt.Text = PAYE_amt.ToString();
            this.txt_nssf_amt.Text = Nssf_amt.ToString();
            this.txt_total_deductions.Text = _Total_cash_deductions.ToString();
            this.txt_net_pay.Text = _Net_Pay.ToString();
            CheckBox chkPayAdvance = this.chk_pay_advance;
            if (this.txt_advance_amt_paid.Text != string.Empty)
            {
                flag = (float.Parse(this.txt_advance_amt_paid.Text) > 0f ? true : false);
            }
            else
            {
                flag = false;
            }
            chkPayAdvance.Checked = flag;
            this.chk_pay_nssf.Checked = (Nssf_amt > new decimal(0) ? true : false);
            this.chk_pay_paye.Checked = (PAYE_amt > new decimal(0) ? true : false);
        }

        protected void Calculate_guard_salary_amounts_exclude_nssf()
        {
            bool flag;
            decimal basic_amt = (this.txt_basic_amt.Text != string.Empty ? decimal.Parse(this.txt_basic_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal transport_amt = (this.txt_transport_amt.Text != string.Empty ? decimal.Parse(this.txt_transport_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal bonus_amt = (this.txt_housing_amt.Text != string.Empty ? decimal.Parse(this.txt_housing_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal leave_amt = (this.txt_leave_amt.Text != string.Empty ? decimal.Parse(this.txt_leave_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal over_time_amt = (this.txt_over_time_amt.Text != string.Empty ? decimal.Parse(this.txt_over_time_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal special_amt = (this.txt_special_amt.Text != string.Empty ? decimal.Parse(this.txt_special_amt.Text) : new decimal(0, 0, 0, false, 1));

            decimal _Gross_amount = ((((((basic_amt + transport_amt)) + bonus_amt) + leave_amt) + over_time_amt)) + special_amt;


            decimal lst_amt = (this.txt_lst_amt.Text != string.Empty ? decimal.Parse(this.txt_lst_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal advance_amt = (this.txt_advance_amt_paid.Text != string.Empty ? decimal.Parse(this.txt_advance_amt_paid.Text) : new decimal(0, 0, 0, false, 1));
            decimal loan_amt = (this.txt_loan_amt.Text != string.Empty ? decimal.Parse(this.txt_loan_amt.Text) : new decimal(0, 0, 0, false, 1));

            _Total_cash_deductions = ((((loan_amt + lst_amt)) + advance_amt));
            decimal PAYE_amt = this.Calculate_PAYE(_Gross_amount);
            decimal Nssf_amt = 0;
            _Total_cash_deductions = (_Total_cash_deductions + PAYE_amt) + Nssf_amt;
            decimal _Net_Pay = _Gross_amount - _Total_cash_deductions;
            this.txt_gross_amt.Text = _Gross_amount.ToString();
            this.txt_paye_amt.Text = PAYE_amt.ToString();
            this.txt_nssf_amt.Text = Nssf_amt.ToString();
            this.txt_total_deductions.Text = _Total_cash_deductions.ToString();
            this.txt_net_pay.Text = _Net_Pay.ToString();
            CheckBox chkPayAdvance = this.chk_pay_advance;
            if (this.txt_advance_amt_paid.Text != string.Empty)
            {
                flag = (float.Parse(this.txt_advance_amt_paid.Text) > 0f ? true : false);
            }
            else
            {
                flag = false;
            }
            chkPayAdvance.Checked = flag;
            this.chk_pay_nssf.Checked = (Nssf_amt > new decimal(0) ? true : false);
            this.chk_pay_paye.Checked = (PAYE_amt > new decimal(0) ? true : false);
        }

        protected void Calculate_guard_salary_amounts_exclude_payee()
        {
            bool flag;
            decimal basic_amt = (this.txt_basic_amt.Text != string.Empty ? decimal.Parse(this.txt_basic_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal transport_amt = (this.txt_transport_amt.Text != string.Empty ? decimal.Parse(this.txt_transport_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal bonus_amt = (this.txt_housing_amt.Text != string.Empty ? decimal.Parse(this.txt_housing_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal leave_amt = (this.txt_leave_amt.Text != string.Empty ? decimal.Parse(this.txt_leave_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal over_time_amt = (this.txt_over_time_amt.Text != string.Empty ? decimal.Parse(this.txt_over_time_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal special_amt = (this.txt_special_amt.Text != string.Empty ? decimal.Parse(this.txt_special_amt.Text) : new decimal(0, 0, 0, false, 1));

            decimal _Gross_amount = ((((((basic_amt + transport_amt)) + bonus_amt) + leave_amt) + over_time_amt)) + special_amt;


            decimal lst_amt = (this.txt_lst_amt.Text != string.Empty ? decimal.Parse(this.txt_lst_amt.Text) : new decimal(0, 0, 0, false, 1));
            decimal advance_amt = (this.txt_advance_amt_paid.Text != string.Empty ? decimal.Parse(this.txt_advance_amt_paid.Text) : new decimal(0, 0, 0, false, 1));
            decimal loan_amt = (this.txt_loan_amt.Text != string.Empty ? decimal.Parse(this.txt_loan_amt.Text) : new decimal(0, 0, 0, false, 1));

            _Total_cash_deductions = ((((loan_amt + lst_amt)) + advance_amt));
            decimal PAYE_amt = 0;
            decimal Nssf_amt = 0;
            _Total_cash_deductions = (_Total_cash_deductions + PAYE_amt) + Nssf_amt;
            decimal _Net_Pay = _Gross_amount - _Total_cash_deductions;
            this.txt_gross_amt.Text = _Gross_amount.ToString();
            this.txt_paye_amt.Text = PAYE_amt.ToString();
            this.txt_nssf_amt.Text = Nssf_amt.ToString();
            this.txt_total_deductions.Text = _Total_cash_deductions.ToString();
            this.txt_net_pay.Text = _Net_Pay.ToString();
            CheckBox chkPayAdvance = this.chk_pay_advance;
            if (this.txt_advance_amt_paid.Text != string.Empty)
            {
                flag = (float.Parse(this.txt_advance_amt_paid.Text) > 0f ? true : false);
            }
            else
            {
                flag = false;
            }
            chkPayAdvance.Checked = flag;
            this.chk_pay_nssf.Checked = (Nssf_amt > new decimal(0) ? true : false);
            this.chk_pay_paye.Checked = (PAYE_amt > new decimal(0) ? true : false);
        }

        protected decimal Calculate_NSSF(decimal gross_amt)
        {
            decimal Nssf_amout = new decimal(0);
            Nssf_amout = new decimal(5, 0, 0, false, 2) * gross_amt;
            return Nssf_amout;
        }

        protected decimal Calculate_PAYE(decimal gross_amt)
        {
            decimal PAYE_amt = new decimal(0);
            decimal exceed_amt = 0;

            if (gross_amt < new decimal(235000))
            {
                PAYE_amt = new decimal(0);
            }
            else if (gross_amt > new decimal(235000) && gross_amt <= new decimal(335000))
            {
                exceed_amt = gross_amt - 235000;
                PAYE_amt = 0.1M * exceed_amt;
            }
            else if (gross_amt > new decimal(335000) && gross_amt <= new decimal(410000))
            {
                exceed_amt = gross_amt - 335000;
                PAYE_amt = 0.2M * exceed_amt;
                PAYE_amt = PAYE_amt + 10000;
            }
            else if (gross_amt > new decimal(410000) && gross_amt <= new decimal(10000000))
            {
                exceed_amt = gross_amt - 410000;
                PAYE_amt = 0.3M * exceed_amt;
                PAYE_amt = PAYE_amt + 25000;
            }
            else if (gross_amt > new decimal(10000000))
            {
                exceed_amt = gross_amt - 10000000;
                PAYE_amt = 0.1M * exceed_amt;
            }
            return PAYE_amt;
        }

        private void txt_basic_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_transport_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_bonus_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_over_time_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_special_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_leave_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_lst_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_advance_amt_TextChanged(object sender, EventArgs e)
        {
            if (txt_advance_amt.Text == "0")
            {
                txt_advance_amt_paid.ReadOnly = true;
            }
            else
            {
                txt_advance_amt_paid.ReadOnly = false;
            }
        }

        private void txt_loan_amt_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_advance_amt_paid_TextChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void txt_basic_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_transport_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_bonus_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_over_time_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_special_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_leave_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_lst_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_loan_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_advance_amt_paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
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

        protected void LoadPaymentPeriods_search()
        {
            DataTable dt = StaffProfiles.Return_staff_list("select_accounts_payment_periods");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["payment_period_id"] = -1;
                dtRow["pay_year"] = "select year";
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_deploy_period_search.DisplayMember = "pay_year";
                this.cbo_deploy_period_search.ValueMember = "payment_period_id";
                this.cbo_deploy_period_search.DataSource = dt;
                //this.cbo_deploy_period.Enabled = false;
            }
        }

        protected void select_staff_list_payroll_search()
        {
            DataTable dt = StaffProfiles.select_staff_list_payroll_search("select_staff_list_payroll_search");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["st_id"] = "-1";
                dtRow["st_name"] = "select Employee";
                dt.Rows.InsertAt(dtRow, 0);
                cbo_staff.DisplayMember = "st_name";
                cbo_staff.ValueMember = "st_id";
                cbo_staff.DataSource = dt;

                this.cbo_staff.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_staff.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        protected void save_staff_payroll()
        {
            if (txt_record_guid.Text == string.Empty)
            {
                StaffProfiles.save_staff_payroll("save_staff_payroll", staff_id, SystemConst._username, Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString()), cbo_payment_month.Text, txt_basic_amt.Text != string.Empty ? decimal.Parse(txt_basic_amt.Text) : 0, txt_transport_amt.Text != string.Empty ? decimal.Parse(txt_transport_amt.Text) : 0, txt_housing_amt.Text != string.Empty ? decimal.Parse(txt_housing_amt.Text) : 0, txt_leave_amt.Text != string.Empty ? decimal.Parse(txt_leave_amt.Text) : 0, txt_over_time_amt.Text != string.Empty ? decimal.Parse(txt_over_time_amt.Text) : 0, txt_special_amt.Text != string.Empty ? decimal.Parse(txt_special_amt.Text) : 0
                , txt_lst_amt.Text != string.Empty ? decimal.Parse(txt_lst_amt.Text) : 0, txt_loan_amt.Text != string.Empty ? decimal.Parse(txt_loan_amt.Text) : 0, txt_advance_amt_paid.Text != string.Empty ? decimal.Parse(txt_advance_amt_paid.Text) : 0, txt_nssf_amt.Text != string.Empty ? decimal.Parse(txt_nssf_amt.Text) : 0, txt_paye_amt.Text != string.Empty ? decimal.Parse(txt_paye_amt.Text) : 0, txt_gross_amt.Text != string.Empty ? decimal.Parse(txt_gross_amt.Text) : 0, txt_total_deductions.Text != string.Empty ? decimal.Parse(txt_total_deductions.Text) : 0, txt_net_pay.Text != string.Empty ? decimal.Parse(txt_net_pay.Text) : 0, chk_pay_salary.Checked == true ? true : false, chk_pay_paye.Checked == true ? true : false
                , chk_pay_nssf.Checked == true ? true : false, chk_pay_advance.Checked == true ? true : false, chk_print_bank_schedule.Checked == true ? true : false, chk_print_payroll.Checked == true ? true : false,txt_ovt_days.Text);

               
                //update advance payment
                if (txt_advance_amt_paid.Text != "0" && txt_advance_amt_paid.Text != string.Empty)
                {
                    UpdateEmployeeAdvanceDetails(txt_record_guid.Text);
                }


                string message = "Payroll for " + txt_staff_name.Text + " saved successfully";
                MessageBox.Show(message, "Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StaffProfiles.update_staff_payroll("update_staff_payroll", txt_record_guid.Text, SystemConst._username, Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString()), cbo_payment_month.Text, txt_basic_amt.Text != string.Empty ? decimal.Parse(txt_basic_amt.Text) : 0, txt_transport_amt.Text != string.Empty ? decimal.Parse(txt_transport_amt.Text) : 0, txt_housing_amt.Text != string.Empty ? decimal.Parse(txt_housing_amt.Text) : 0, txt_leave_amt.Text != string.Empty ? decimal.Parse(txt_leave_amt.Text) : 0, txt_over_time_amt.Text != string.Empty ? decimal.Parse(txt_over_time_amt.Text) : 0, txt_special_amt.Text != string.Empty ? decimal.Parse(txt_special_amt.Text) : 0
                , txt_lst_amt.Text != string.Empty ? decimal.Parse(txt_lst_amt.Text) : 0, txt_loan_amt.Text != string.Empty ? decimal.Parse(txt_loan_amt.Text) : 0, txt_advance_amt_paid.Text != string.Empty ? decimal.Parse(txt_advance_amt_paid.Text) : 0, txt_nssf_amt.Text != string.Empty ? decimal.Parse(txt_nssf_amt.Text) : 0, txt_paye_amt.Text != string.Empty ? decimal.Parse(txt_paye_amt.Text) : 0, txt_gross_amt.Text != string.Empty ? decimal.Parse(txt_gross_amt.Text) : 0, txt_total_deductions.Text != string.Empty ? decimal.Parse(txt_total_deductions.Text) : 0, txt_net_pay.Text != string.Empty ? decimal.Parse(txt_net_pay.Text) : 0, chk_pay_salary.Checked == true ? true : false, chk_pay_paye.Checked == true ? true : false
                , chk_pay_nssf.Checked == true ? true : false, chk_pay_advance.Checked == true ? true : false, chk_print_bank_schedule.Checked == true ? true : false, chk_print_payroll.Checked == true ? true : false,txt_ovt_days.Text);

                //update advance payment
                if (txt_advance_amt_paid.Text != "0")
                {
                    UpdateEmployeeAdvanceDetails(txt_record_guid.Text);
                }

                string message = "Payroll for " + txt_staff_name.Text + " updated successfully";
                MessageBox.Show(message,"Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void SavePayroll()
        {
            if (cbo_deploy_period.SelectedValue.ToString() == "-1" || cbo_payment_month.Text == string.Empty)
            {
                MessageBox.Show("Payment Year and Month cannot be empty", "Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_bank_code.Text == string.Empty || txt_bank_name.Text == string.Empty || txt_account_number.Text == string.Empty || txt_nssf.Text == string.Empty)
            {
                MessageBox.Show("Please select a staff member to save payroll", "Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_record_guid.Text == string.Empty &&  StaffProfiles.Validate_payroll("validate_payroll", staff_id, Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString()), cbo_payment_month.Text) > 0)
            {
                MessageBox.Show("There is already payroll saved for " + txt_staff_name.Text + " for this period", "Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((txt_gross_amt.Text == string.Empty || txt_gross_amt.Text == "0") && (txt_net_pay.Text == string.Empty || txt_net_pay.Text == "0") )
            {
                MessageBox.Show("Gross Pay and Net Pay cannot be empty", "Staff Payroll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                save_staff_payroll();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SavePayroll();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbo_staff.SelectedValue.ToString() == "-1")
            {
                Get_staff_profiles();
            }
            else
            {
                DataTable dt = StaffProfiles.select_staff_list_search("select_staff_list_search", cbo_staff.SelectedValue.ToString());
                if (dt != null)
                {
                    gdv_staff.DataSource = dt;
                    gdv_staff.Columns["st_id"].Visible = false;
                    gdv_staff.Columns["branch_id"].Visible = false;
                    gdv_staff.Columns["st_position"].Visible = false;
                    gdv_staff.Columns["bank_id"].Visible = false;
                    gdv_staff.Columns["bank_branch_id"].Visible = false;

                    gdv_staff.Columns["st_name"].HeaderText = "Name";
                    gdv_staff.Columns["st_number"].HeaderText = "Personal Number";
                    gdv_staff.Columns["st_gender"].HeaderText = "Sex";
                    gdv_staff.Columns["st_status"].HeaderText = "Employee Status";
                    gdv_staff.Columns["nss_number"].HeaderText = "NSSF Number";
                    gdv_staff.Columns["bank_acc_number"].HeaderText = "Bank Account Number";
                    gdv_staff.Columns["tin_number"].HeaderText = "Tin Number";

                    gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                    gdv_staff.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                    gdv_staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_staff.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                }

            }
        }


        protected void UpdateEmployeeAdvanceDetails(string record_guid)
        {
            if (record_guid == string.Empty)
            {
                decimal advance_principle = decimal.Parse(txt_advace_amt_principle.Text);
                decimal advance_current_balance = decimal.Parse(txt_advance_amt.Text);
                decimal advance_amount_paid = txt_advance_amt_paid.Text != string.Empty? decimal.Parse(txt_advance_amt_paid.Text):0;

                advance_amount_paid = advance_amount_paid + decimal.Parse(txt_advance_paid.Text);

                decimal new_advance_balance = advance_principle - advance_amount_paid;

                StaffProfiles.update_staff_advance_payment("update_staff_advance_payment", staff_id,lblloanid.Text, advance_amount_paid, new_advance_balance);
            }
            else
            {
                //MessageBox.Show(advance_paid_amt_to_be_updated.ToString());
                decimal advance_principle = decimal.Parse(txt_advace_amt_principle.Text);
                decimal _balance = decimal.Parse(txt_advance_amt.Text) + advance_paid_amt_to_be_updated;
                decimal amount_paid = decimal.Parse(txt_advance_amt_paid.Text);
                decimal new_advance_balance = _balance - amount_paid;

                decimal prev_total_advance_amt_paid = decimal.Parse(txt_advance_paid.Text) - advance_paid_amt_to_be_updated;
                decimal current_total_advance_amt_paid = prev_total_advance_amt_paid + decimal.Parse(txt_advance_amt_paid.Text);

                StaffProfiles.update_staff_advance_payment("update_staff_advance_payment", staff_id,lblloanid.Text, current_total_advance_amt_paid, new_advance_balance);
               
               
            }

        }

        public void ResetLoanDetails()
        {
            #region ResetLoanDetails

            SystemConst.advace_amt_principle = string.Empty;
            SystemConst.advance_paid = string.Empty;
            SystemConst.advance_amt = string.Empty;
            SystemConst.lblloanid = string.Empty;

            txt_advace_amt_principle.Text = string.Empty;
            txt_advance_paid.Text = string.Empty;
            txt_advance_amt.Text = string.Empty;
            lblloanid.Text = string.Empty;
            #endregion
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            frm_staff_payroll_reports_dashboard dashboard = new frm_staff_payroll_reports_dashboard();
            dashboard.ShowDialog();
        }

        private void btnpayroll_summary_Click(object sender, EventArgs e)
        {
            frm_staff_payroll_summary summ = new frm_staff_payroll_summary();
            summ.ShowDialog();
        }

        private void gdv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_ovt_days_TextChanged(object sender, EventArgs e)
        {
            if (txt_ovt_days.Text != string.Empty)
            {
                decimal ovt = (decimal.Parse(txt_basic_amt.Text) / 30) * decimal.Parse(txt_ovt_days.Text);
                txt_over_time_amt.Text = Math.Round(ovt, 2).ToString();
            }
            else
            {
                decimal ovt = 0;
                txt_over_time_amt.Text = ovt.ToString();
            }
        }

        private void txt_ovt_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void chk_pay_nssf_CheckedChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }

        private void btnLoadAdvance_Click(object sender, EventArgs e)
        {
            StaffProfiles.staff_id = staff_id;
            StaffProfiles.staff_name = txt_staff_name.Text;
            SystemConst.staff_advance_action = "Payroll";
            frmstaffAdvance ad = new frmstaffAdvance();
            ad.ShowDialog();
        }

        private void frm_setup_payroll_staff_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void gdv_staff_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            if (SystemConst.staff_advance_action == "Payroll")
            {
                txt_advace_amt_principle.Text = SystemConst.advace_amt_principle;
                txt_advance_paid.Text = SystemConst.advance_paid;
                txt_advance_amt.Text = SystemConst.advance_amt;
                lblloanid.Text = SystemConst.lblloanid;
            }
        }

        private void chk_pay_paye_CheckedChanged(object sender, EventArgs e)
        {
            Calculate_guard_salary_amounts();
        }
    }
}
