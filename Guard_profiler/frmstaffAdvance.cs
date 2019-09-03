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
    public partial class frmstaffAdvance : Form
    {
        public frmstaffAdvance()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        protected void save()
        {
            if (txtamount.Text != string.Empty)
            {
                if (decimal.Parse(txtamount.Text) < 1)
                {
                    MessageBox.Show("Advance Amount cannot be zero or blank!", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (StaffProfiles.check_if_staff_has_advance("check_if_staff_has_advance", lblstaffid.Text) > 0)
                    {
                        System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("There is already an outstanding advance for " + txt_staff_name.Text + ".Are you sure you want to add another advance to this staff member", "Staff Advance", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            StaffProfiles.save_staff_advance("save_staff_advance", lblstaffid.Text, dtAdvanceDate.Value.Date, Convert.ToDecimal(txtamount.Text), Convert.ToDecimal(txtamountPaid.Text), Convert.ToDecimal(txtAmountBalance.Text), txtAmountBalance.Text == "0" ? true : false);
                            MessageBox.Show("Success!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAdvances();
                        }
                        if (dialogResult == System.Windows.Forms.DialogResult.No)
                        {
                            base.Visible = true;
                        }
                    }
                    else
                    {
                        StaffProfiles.save_staff_advance("save_staff_advance", lblstaffid.Text, dtAdvanceDate.Value.Date, Convert.ToDecimal(txtamount.Text), Convert.ToDecimal(txtamountPaid.Text), Convert.ToDecimal(txtAmountBalance.Text), txtAmountBalance.Text == "0" ? true : false);
                        MessageBox.Show("Success!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdvances();
                    }
                }
            }
            else if (txtamount.Text == string.Empty)
            {
                MessageBox.Show("Advance Amount cannot be zero or blank!", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        protected void LoadAdvances()
        {
            DataTable dt = StaffProfiles.Return_advance_list("select_advance_list", StaffProfiles.staff_id);
            if (dt != null)
            {
                gdvAdvanceList.DataSource = dt;

                gdvAdvanceList.Columns["st_id"].Visible = false;
                gdvAdvanceList.Columns["ad_id"].Visible = false;

                gdvAdvanceList.Columns["st_name"].HeaderText = "Name";
                gdvAdvanceList.Columns["ad_date"].HeaderText = "Advance Date";
                gdvAdvanceList.Columns["ad_amount"].HeaderText = "Advance Amount";
                gdvAdvanceList.Columns["ad_paid_amount"].HeaderText = "Paid Amount";
                gdvAdvanceList.Columns["ad_balance_amount"].HeaderText = "Outstanding Amount";
                gdvAdvanceList.Columns["ad_fully_paid"].HeaderText = "Advance fully paid";

                gdvAdvanceList.DefaultCellStyle.SelectionBackColor = Color.White;
                gdvAdvanceList.DefaultCellStyle.SelectionForeColor = Color.Black;
                gdvAdvanceList.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdvAdvanceList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                gdvAdvanceList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdvAdvanceList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdvAdvanceList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                gdvAdvanceList.DefaultCellStyle.SelectionBackColor = Color.White;
                gdvAdvanceList.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void frmstaffAdvance_Load(object sender, EventArgs e)
        {
            LoadAdvances();
            lblstaffid.Text = StaffProfiles.staff_id;
            txt_staff_name.Text = StaffProfiles.staff_name;
        }

        private void gdvAdvanceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SystemConst.staff_advance_action == "Profiles")
            {
                Load_staffAdvance();
            }
            else
            {
                frm_setup_payroll_staff staff = new frm_setup_payroll_staff();
                SystemConst.advace_amt_principle = gdvAdvanceList.CurrentRow.Cells[4].Value.ToString();
                SystemConst.advance_paid = gdvAdvanceList.CurrentRow.Cells[5].Value.ToString();
                SystemConst.advance_amt = gdvAdvanceList.CurrentRow.Cells[6].Value.ToString();
                SystemConst.lblloanid = gdvAdvanceList.CurrentRow.Cells[0].Value.ToString();
                this.Visible = false;
            }
            
        }

        protected void Load_staffAdvance()
        {
            if (gdvAdvanceList.Rows.Count > 0)
            {
                txtamount.Text = gdvAdvanceList.CurrentRow.Cells[4].Value.ToString();
                txtamountPaid.Text = gdvAdvanceList.CurrentRow.Cells[5].Value.ToString();
                txtAmountBalance.Text = gdvAdvanceList.CurrentRow.Cells[6].Value.ToString();
                chkfullypaid.Checked = Convert.ToBoolean(gdvAdvanceList.CurrentRow.Cells[7].Value.ToString());

                dtAdvanceDate.Value = Convert.ToDateTime(gdvAdvanceList.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            if (txtamount.Text != string.Empty)
            {
                txtAmountBalance.Text = (decimal.Parse(txtamount.Text) - decimal.Parse(txtamountPaid.Text)).ToString();
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtamount.Text = "0";
            txtAmountBalance.Text = "0";
            txtamountPaid.Text = "0";
        }
    }
}
