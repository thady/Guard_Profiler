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
    public partial class nssf_payroll_temp : Form
    {
        DataTable dt = new DataTable();
        public nssf_payroll_temp()
        {
            InitializeComponent();
        }

        private void nssf_payroll_temp_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
           

            cboPaymentMonth.Text = Nss_archive.payment_month;
            cboPaymentYear.Text = Nss_archive.payment_year;
            cboPaymentMonthSearch.Text = Nss_archive.payment_month;
            cboPaymentYearSearch.Text = Nss_archive.payment_year;

            LoadLists();
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
                this.cbo_branch.DataSource = dt;
                this.cbo_branch.DisplayMember = "branch";
                this.cbo_branch.ValueMember = "branch_code";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                save_payroll();
            }
            else
            {
                MessageBox.Show("Fill in all required fields", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        protected void save_payroll()
        {
            #region variables
           
            Nss_archive.payment_year = cboPaymentYear.Text;
            Nss_archive.payment_month = cboPaymentMonth.Text;
            Nss_archive.branch_name = cbo_branch.Text;
            Nss_archive.guard_number = txt_guard_num.Text;
            Nss_archive.guard_name = txt_guard_name.Text;
            Nss_archive.nss_number = txt_nssf.Text;
            Nss_archive.days_worked = txt_days_worked.Text != string.Empty ? Convert.ToInt32(txt_days_worked.Text) : 0;
            Nss_archive.basic_amt = decimal.Parse(txt_basic_amt.Text);
            Nss_archive.overtime_amt = txt_over_time_amt.Text != string.Empty ? decimal.Parse(txt_over_time_amt.Text) : 0;
            Nss_archive.transport_amt = txt_transport_amt.Text != string.Empty ? decimal.Parse(txt_transport_amt.Text) : 0;
            Nss_archive.housing_amt = txt_housing_amt.Text != string.Empty ? decimal.Parse(txt_housing_amt.Text) : 0;
            Nss_archive.resident_amt = txt_resident_amt.Text != string.Empty ? decimal.Parse(txt_resident_amt.Text) : 0;
            Nss_archive.special_amt = txt_special_amt.Text != string.Empty ? decimal.Parse(txt_special_amt.Text) : 0;
            Nss_archive.bonus_amt = txt_bonus_amt.Text != string.Empty ? decimal.Parse(txt_bonus_amt.Text) : 0;
            Nss_archive.arrears_amt = txt_arrears_amt.Text != string.Empty ? decimal.Parse(txt_arrears_amt.Text) : 0;
            Nss_archive.leave_amt = txt_leave_amt.Text != string.Empty ? decimal.Parse(txt_leave_amt.Text) : 0;
            Nss_archive.gross_pay_amt = txt_gross_amt.Text != string.Empty ? decimal.Parse(txt_gross_amt.Text) : 0;
            Nss_archive.advance_amt = txt_advance_amt.Text != string.Empty ? decimal.Parse(txt_advance_amt.Text) : 0;
            Nss_archive.loan_amt = 0;
            Nss_archive.absentism_amt = txt_absentism_amt.Text != string.Empty ? decimal.Parse(txt_absentism_amt.Text) : 0;
            Nss_archive.uniform_amt = txt_uniform_amt.Text != string.Empty ? decimal.Parse(txt_uniform_amt.Text) : 0;
            Nss_archive.penalty_amt = txt_penalty_amt.Text != string.Empty ? decimal.Parse(txt_penalty_amt.Text) : 0;
            Nss_archive.lst_amt = txt_lst_amt.Text != string.Empty ? decimal.Parse(txt_lst_amt.Text) : 0;
            Nss_archive.paye_amt = txt_paye_amt.Text != string.Empty ? decimal.Parse(txt_paye_amt.Text) : 0;
            Nss_archive.nssf_amt = txt_nssf_amt.Text != string.Empty ? decimal.Parse(txt_nssf_amt.Text) : 0;
            Nss_archive.employer_nssf_amt = txt_nss_employer.Text != string.Empty ? decimal.Parse(txt_nss_employer.Text) : 0;
            Nss_archive.nssf_total_amt = Nss_archive.nssf_amt + Nss_archive.employer_nssf_amt;

            Nss_archive.net_pay_amt = Nss_archive.gross_pay_amt - (Nss_archive.advance_amt + Nss_archive.loan_amt + Nss_archive.absentism_amt + Nss_archive.uniform_amt + Nss_archive.penalty_amt + Nss_archive.lst_amt +
                  Nss_archive.paye_amt + Nss_archive.nssf_amt);
            Nss_archive.usr_id_create = SystemConst._username;
            Nss_archive.usr_id_update = SystemConst._username;
            Nss_archive.usr_date_create = DateTime.Today;
            Nss_archive.usr_date_update = DateTime.Today;
            #endregion

            #region save
            if(txt_record_guid.Text == string.Empty)
            {
                Nss_archive.record_id = Guid.NewGuid().ToString();
                Nss_archive.QueryName = "save_payroll_details";
                Nss_archive.save_guard_payroll_details();
                txt_record_guid.Text = Nss_archive.record_id;
                MessageBox.Show("Saved successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Nss_archive.record_id = txt_record_guid.Text;
                Nss_archive.QueryName = "update_payroll_details";
                Nss_archive.save_guard_payroll_details();
                MessageBox.Show("Updated successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
        }


        protected void LoadLists()
        {
            DataTable dt = new DataTable();
            dt = Nss_archive.select_list("select_payroll_summary", cboPaymentYearSearch.Text != string.Empty?cboPaymentYearSearch.Text:string.Empty,
                cboPaymentMonthSearch.Text != string.Empty?cboPaymentMonthSearch.Text:string.Empty,
                 txt_guard_name_search.Text != string.Empty ? txt_guard_name_search.Text : string.Empty);
            gdv_guards.DataSource = dt;
            gdv_guards.Columns["record_id"].Visible = false;
            gdv_guards.Columns["payment_year"].HeaderText = "Payment Year";
            gdv_guards.Columns["payment_month"].HeaderText = "Payment Year";
            gdv_guards.Columns["branch_name"].HeaderText = "Payment Year";
            gdv_guards.Columns["guard_number"].HeaderText = "Payment Year";
            gdv_guards.Columns["guard_name"].HeaderText = "Payment Year";
            gdv_guards.Columns["nss_number"].HeaderText = "Payment Year";

            this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.gdv_guards.BorderStyle = BorderStyle.FixedSingle;
            foreach (DataGridViewColumn c in this.gdv_guards.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
            }
            this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdv_guards.EnableHeadersVisualStyles = false;
        }

        protected void LoadDetails(string id)
        {
            if (gdv_guards.Rows.Count > 0)
            {
                dt = Nss_archive.select_payroll_details("select_payroll_details", id);
                if (dt.Rows.Count > 0)
                {
                    DataRow dtRow = dt.Rows[0];
                    cboPaymentYear.Text = dtRow["payment_year"].ToString();
                    cboPaymentMonth.Text = dtRow["payment_month"].ToString();
                    cbo_branch.Text = dtRow["branch_name"].ToString();
                    txt_guard_num.Text = dtRow["guard_number"].ToString();
                    txt_guard_name.Text = dtRow["guard_name"].ToString();
                    txt_nssf.Text = dtRow["nss_number"].ToString();
                    txt_days_worked.Text = Convert.ToInt32(dtRow["days_worked"].ToString()).ToString();
                    txt_basic_amt.Text = decimal.Parse(dtRow["basic_amt"].ToString()).ToString();
                    txt_over_time_amt.Text = decimal.Parse(dtRow["overtime_amt"].ToString()).ToString();
                    txt_transport_amt.Text = decimal.Parse(dtRow["transport_amt"].ToString()).ToString();
                    txt_housing_amt.Text = decimal.Parse(dtRow["housing_amt"].ToString()).ToString();
                    txt_resident_amt.Text = decimal.Parse(dtRow["resident_amt"].ToString()).ToString();
                    txt_special_amt.Text = decimal.Parse(dtRow["special_amt"].ToString()).ToString();
                    txt_bonus_amt.Text = decimal.Parse(dtRow["bonus_amt"].ToString()).ToString();
                    txt_arrears_amt.Text = decimal.Parse(dtRow["arrears_amt"].ToString()).ToString();
                    txt_leave_amt.Text = decimal.Parse(dtRow["leave_amt"].ToString()).ToString();
                    txt_gross_amt.Text = decimal.Parse(dtRow["gross_pay_amt"].ToString()).ToString();
                    txt_advance_amt.Text = decimal.Parse(dtRow["advance_amt"].ToString()).ToString();
                    txt_absentism_amt.Text = decimal.Parse(dtRow["absentism_amt"].ToString()).ToString();
                    txt_uniform_amt.Text = decimal.Parse(dtRow["uniform_amt"].ToString()).ToString();
                    txt_penalty_amt.Text = decimal.Parse(dtRow["penalty_amt"].ToString()).ToString();
                    txt_lst_amt.Text = decimal.Parse(dtRow["lst_amt"].ToString()).ToString();
                    txt_paye_amt.Text = decimal.Parse(dtRow["paye_amt"].ToString()).ToString();
                    txt_nssf_amt.Text = decimal.Parse(dtRow["nssf_amt"].ToString()).ToString();
                    txt_nss_employer.Text = decimal.Parse(dtRow["employer_nssf_amt"].ToString()).ToString();
                    txt_record_guid.Text = id;
                }
            }
        }

        protected void Clear()
        {
            cbo_branch.Text = string.Empty;
            txt_guard_num.Text = string.Empty;
            txt_guard_name.Text = string.Empty;
            txt_nssf.Text = string.Empty;
            txt_days_worked.Text = string.Empty;
            txt_basic_amt.Text = string.Empty;
            txt_over_time_amt.Text = string.Empty;
            txt_transport_amt.Text = string.Empty;
            txt_housing_amt.Text = string.Empty;
            txt_resident_amt.Text = string.Empty;
            txt_special_amt.Text = string.Empty;
            txt_bonus_amt.Text = string.Empty;
            txt_arrears_amt.Text = string.Empty;
            txt_leave_amt.Text = string.Empty;
            txt_gross_amt.Text = string.Empty;
            txt_advance_amt.Text = string.Empty;
            txt_absentism_amt.Text = string.Empty;
            txt_uniform_amt.Text = string.Empty;
            txt_penalty_amt.Text = string.Empty;
            txt_lst_amt.Text = string.Empty;
            txt_paye_amt.Text = string.Empty;
            txt_nssf_amt.Text = string.Empty;
            txt_nss_employer.Text = string.Empty;
            txt_record_guid.Text = string.Empty;
            Nss_archive.record_id = string.Empty;
        }

        protected bool ValidateInput()
        {
            bool isValid = false;
            if (cbo_branch.SelectedValue.ToString() == string.Empty || cboPaymentYear.Text == string.Empty || cboPaymentMonth.Text == string.Empty)
            {
                isValid = false;

            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void txt_basic_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_transport_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_resident_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_bonus_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_leave_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_uniform_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_lst_amt_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }

        private void txt_lst_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_over_time_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_housing_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_special_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_arrears_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_advance_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_penalty_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_absentism_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_days_worked_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_gross_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_paye_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_nssf_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_nss_employer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void gdv_guards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdv_guards.Rows.Count > 0)
            {
                LoadDetails(gdv_guards.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            nssf_payroll_temp_report_selector frm = new nssf_payroll_temp_report_selector();
            frm.ShowDialog();
        }
    }
}
