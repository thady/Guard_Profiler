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
    public partial class frm_staffprofiles : Form
    {
        public frm_staffprofiles()
        {
            InitializeComponent();
        }

        private void frm_staffprofiles_Load(object sender, EventArgs e)
        {
            get_bank_list();
            GET_BRANCHES();
            Get_staff_profiles();
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
                cbo_bank.DisplayMember = "bank_name";
                cbo_bank.ValueMember = "record_id";
                cbo_bank.DataSource = dt;
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

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = "-1";
                dtRow["auto_id"] = -1;
                dtRow["accounts_code"] = "-1";
                dtRow["branch"] = "select branch";
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_branch.DataSource = dt;
                this.cbo_branch.DisplayMember = "branch";
                this.cbo_branch.ValueMember = "record_guid";

                cbo_branch.SelectedIndex = 0;
            }
        }

        private void cbo_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_bank.SelectedValue.ToString() != "-1")
            {
                this.get_bank_branches(Convert.ToInt32(cbo_bank.SelectedValue.ToString()));
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }


        protected bool ValidateInput()
        {
            bool isValid = false;

            if (txt_staff_name.Text == string.Empty || cbo_sex.Text == string.Empty || cbo_status.Text == string.Empty || cbo_branch.Text == string.Empty ||
                txt_personal_number.Text == string.Empty || txt_nssf.Text == string.Empty || txt_acc_number.Text == string.Empty || cbo_bank.Text == string.Empty ||
                cbo_bank_branch.Text == string.Empty || txtbasicAmt.Text == string.Empty || txtTransportAmt.Text == string.Empty || txtHousingAmt.Text == string.Empty)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }
        protected void save()
        {
            if (ValidateInput())
            {
                if (lblstaffid.Text == ".")
                {
                    StaffProfiles.save_staff_details("save_staff_details", string.Empty, txt_personal_number.Text, cbo_branch.SelectedValue.ToString(), txt_staff_name.Text, cbo_sex.Text, cbo_status.Text, cbo_position.Text, txt_nssf.Text, txt_acc_number.Text, cbo_bank.SelectedValue.ToString(), 
                    cbo_bank_branch.SelectedValue.ToString() != "-1" ? cbo_bank_branch.SelectedValue.ToString() : cbo_bank_branch.SelectedValue.ToString(), txt_tin_number.Text, SystemConst._username,Convert.ToDecimal(txtbasicAmt.Text),Convert.ToDecimal(txtTransportAmt.Text),Convert.ToDecimal(txtHousingAmt.Text));
                    MessageBox.Show("Success!", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Get_staff_profiles();
                }
                else
                {
                    StaffProfiles.save_staff_details("update_staff_details", lblstaffid.Text, txt_personal_number.Text, cbo_branch.SelectedValue.ToString(), txt_staff_name.Text, cbo_sex.Text, cbo_status.Text, cbo_position.Text, txt_nssf.Text, txt_acc_number.Text, cbo_bank.SelectedValue.ToString(), 
                        cbo_bank_branch.SelectedValue.ToString() != "-1" ? cbo_bank_branch.SelectedValue.ToString() : cbo_bank_branch.SelectedValue.ToString(), txt_tin_number.Text, SystemConst._username,Convert.ToDecimal(txtbasicAmt.Text), Convert.ToDecimal(txtTransportAmt.Text), Convert.ToDecimal(txtHousingAmt.Text));
                    MessageBox.Show("Success!", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Get_staff_profiles();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required values", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


           
           
        }

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.SelectedValue.ToString() != "-1" && cbo_branch.SelectedValue.ToString() != string.Empty)
            {

                txt_personal_number.Text = StaffProfiles.AccountsCode("select_staff_branch_code", cbo_branch.SelectedValue.ToString()) + "-";
            }
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

                gdv_staff.Columns["st_name"].HeaderText = "Name";
                gdv_staff.Columns["st_number"].HeaderText = "Personal Number";
                gdv_staff.Columns["st_gender"].HeaderText = "Sex";
                gdv_staff.Columns["st_status"].HeaderText = "Employee Status";
                gdv_staff.Columns["nss_number"].HeaderText = "NSSF Number";
                gdv_staff.Columns["bank_acc_number"].HeaderText = "Bank Account Number";
                gdv_staff.Columns["tin_number"].HeaderText = "Tin Number";
                gdv_staff.Columns["basic_amt"].HeaderText = "Basic Amount";
                gdv_staff.Columns["transport_amt"].HeaderText = "Transport Amount";
                gdv_staff.Columns["housing_amt"].HeaderText = "Housing Amount";


                this.gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                this.gdv_staff.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_staff.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in this.gdv_staff.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 13f, GraphicsUnit.Pixel);
                }
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_staff.EnableHeadersVisualStyles = false;
            }
        }


        protected void Search_staff_profiles()
        {
            DataTable dt = StaffProfiles.Return_staff_list_search("search_staff_list", txtstaff_name.Text);
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
                gdv_staff.Columns["basic_amt"].HeaderText = "Basic Amount";
                gdv_staff.Columns["transport_amt"].HeaderText = "Transport Amount";
                gdv_staff.Columns["housing_amt"].HeaderText = "Housing Amount";

                this.gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                this.gdv_staff.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_staff.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in this.gdv_staff.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 13f, GraphicsUnit.Pixel);
                }
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_staff.EnableHeadersVisualStyles = false;
            }
        }


        private void gdv_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_staff.Rows.Count > 0)
            {
               
                lblstaffid.Text = gdv_staff.CurrentRow.Cells[0].Value.ToString();
                txt_staff_name.Text = gdv_staff.CurrentRow.Cells[5].Value.ToString();
                cbo_sex.Text = gdv_staff.CurrentRow.Cells[7].Value.ToString();
                cbo_status.Text = gdv_staff.CurrentRow.Cells[8].Value.ToString();
                cbo_branch.SelectedValue = gdv_staff.CurrentRow.Cells[1].Value.ToString();
                txt_personal_number.Text = gdv_staff.CurrentRow.Cells[6].Value.ToString();
                cbo_position.Text = gdv_staff.CurrentRow.Cells[2].Value.ToString();
                txt_nssf.Text = gdv_staff.CurrentRow.Cells[9].Value.ToString();
                txt_acc_number.Text = gdv_staff.CurrentRow.Cells[10].Value.ToString();
                cbo_bank.SelectedValue = gdv_staff.CurrentRow.Cells[3].Value.ToString();
                cbo_bank_branch.SelectedValue = gdv_staff.CurrentRow.Cells[4].Value.ToString();
                txt_tin_number.Text = gdv_staff.CurrentRow.Cells[11].Value.ToString();
                txtbasicAmt.Text = gdv_staff.CurrentRow.Cells[12].Value.ToString();
                txtTransportAmt.Text = gdv_staff.CurrentRow.Cells[13].Value.ToString();
                txtHousingAmt.Text = gdv_staff.CurrentRow.Cells[14].Value.ToString();

                grpbox_staffprofiles.Enabled = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            grpbox_staffprofiles.Enabled = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void clear()
        {
            lblstaffid.Text = ".";
            txt_staff_name.Clear();
            cbo_sex.Text = string.Empty;
            cbo_status.Text = string.Empty;
            cbo_branch.SelectedValue = "-1";
            txt_personal_number.Clear();
            cbo_position.Text = string.Empty;
            txt_nssf.Clear();
            txt_acc_number.Clear();
            cbo_bank.SelectedValue = "-1";
            cbo_bank_branch.SelectedValue = "-1";
            txt_tin_number.Clear();
            txtbasicAmt.Clear();
            txtTransportAmt.Clear();
            txtHousingAmt.Clear();

            grpbox_staffprofiles.Enabled = true;
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            if (lblstaffid.Text == ".")
            {
                MessageBox.Show("Please select a staff member to add advance details","Advance",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                StaffProfiles.staff_id = lblstaffid.Text;
                StaffProfiles.staff_name = txt_staff_name.Text;
                SystemConst.staff_advance_action = "Profiles";
                frmstaffAdvance ad = new frmstaffAdvance();
                ad.ShowDialog();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search_staff_profiles();
        }

        private void txtbasicAmt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTransportAmt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHousingAmt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
