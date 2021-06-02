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
    public partial class frmChartofAccounts : Form
    {
        DataTable dt = new DataTable();
        public frmChartofAccounts()
        {
            InitializeComponent();
        }

        private void frmChartofAccounts_Load(object sender, EventArgs e)
        {
            LoadYesNo();
            LoadAccountCategoryListing();
            LoadChartofAccountsListing();
            LoadBranchList();
            this.WindowState = FormWindowState.Maximized;
        }

        protected void LoadYesNo()
        {
            dt = Lookups.LoadLookup("select_yes_no_list");
            DataRow dtRow = dt.NewRow();
            dtRow["yn_id"] = string.Empty;
            dtRow["yn_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboBank.DataSource = dt;
            cboBank.ValueMember = "yn_id";
            cboBank.DisplayMember = "yn_name";
        }

        protected void LoadAccountCategoryListing()
        {
            dt = Lookups.LoadLookup("select_account_category_listing");
            DataRow dtRow = dt.NewRow();
            dtRow["acc_type_id"] = string.Empty;
            dtRow["acc_type_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboAccountType.DataSource = dt;
            cboAccountType.ValueMember = "acc_type_id";
            cboAccountType.DisplayMember = "acc_type_name";
        }

        protected void LoadBranchList()
        {
            dt = Branches.LoadLookup("select_branch_list");
            DataRow dtRow = dt.NewRow();
            dtRow["record_guid"] = string.Empty;
            dtRow["branch"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboBranch.DataSource = dt;
            cboBranch.ValueMember = "record_guid";
            cboBranch.DisplayMember = "branch";

            cboBranch.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboBranch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadChartofAccountsListing()
        {
            dt = ChartofAccounts.LoadListing("select_chart_of_acounts_listing");
            gdvList.DataSource = dt;

            gdvList.Columns["acc_id"].Visible = false;
            gdvList.Columns["acc_type_name"].HeaderText = "Account Type";
            gdvList.Columns["acc_name"].HeaderText = "Account Name";
            gdvList.Columns["acc_number"].HeaderText = "Account Number";
            gdvList.Columns["opening_bal"].HeaderText = "Opening Balance";
            gdvList.Columns["Bank"].HeaderText = "Bank";
            gdvList.Columns["debit_credit"].HeaderText = "Debit/Credit";

            gdvList.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            gdvList.DefaultCellStyle.SelectionForeColor = Color.Black;
            foreach (DataGridViewColumn c in this.gdvList.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12f, GraphicsUnit.Pixel);
            }
            this.gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvList.EnableHeadersVisualStyles = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                save();
            }
            else
            {
                MessageBox.Show("Please fill in all missing values,save failed", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void save()
        {
            #region SetVariables
            ChartofAccounts.acc_type_id = cboAccountType.SelectedValue.ToString();
            ChartofAccounts.acc_number = txtAccountNumber.Text;
            ChartofAccounts.bank = cboBank.SelectedValue.ToString();
            ChartofAccounts.acc_name = txtAccountTitle.Text + "-" + txtAccountNumber.Text;
            ChartofAccounts.opening_bal = decimal.Parse(txtOpeningBal.Text);
            ChartofAccounts.debit_credit = cboCreditDebit.Text;
            ChartofAccounts.branch_id = cboBranch.SelectedValue.ToString();
            ChartofAccounts.usr_id_create = SystemConst._user_id;
            ChartofAccounts.usr_id_update = SystemConst._user_id;
            ChartofAccounts.usr_date_create = DateTime.Now;
            ChartofAccounts.usr_date_update = DateTime.Now;
            #endregion

            if(lblID.Text == Globals.EmptyID)
            {
                ChartofAccounts.acc_id = Guid.NewGuid().ToString();
                ChartofAccounts.save("save_account_details");
                MessageBox.Show("Succefully saved new account details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChartofAccountsListing();
            }
            else
            {
                ChartofAccounts.acc_id = lblID.Text;
                ChartofAccounts.save("update_account_details");
                MessageBox.Show("Succefully updated account details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChartofAccountsListing();
            }
        }

        protected bool ValidateInput()
        {
            bool isValid = false;
            if(cboAccountType.SelectedValue.ToString() == Globals.EmptySelection || txtAccountTitle.Text == string.Empty || txtAccountNumber.Text == string.Empty || 
                cboBank.SelectedValue.ToString() == Globals.EmptySelection || txtOpeningBal.Text == string.Empty || cboCreditDebit.Text == Globals.EmptySelection)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void gdvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdvList.Rows.Count > 0)
            {
                lblID.Text = gdvList.CurrentRow.Cells[0].Value.ToString();
                cboAccountType.Text = gdvList.CurrentRow.Cells[1].Value.ToString();
                txtAccountTitle.Text = gdvList.CurrentRow.Cells[2].Value.ToString();
                txtAccountNumber.Text = gdvList.CurrentRow.Cells[3].Value.ToString();
                cboBank.Text = gdvList.CurrentRow.Cells[5].Value.ToString();
                txtOpeningBal.Text = gdvList.CurrentRow.Cells[4].Value.ToString();
                cboCreditDebit.Text = gdvList.CurrentRow.Cells[6].Value.ToString();
                cboBranch.Text = gdvList.CurrentRow.Cells[7].Value.ToString();
                pnlDataEntry.Enabled = false;
            }
        }

        protected void Clear()
        {
            lblID.Text = Globals.EmptyID;
            cboAccountType.SelectedValue = string.Empty;
            txtAccountTitle.Clear();
            txtAccountNumber.Clear();
            cboBank.SelectedValue = Globals.EmptySelection;
            txtOpeningBal.Clear();
            cboCreditDebit.Text = string.Empty;
            cboBranch.SelectedValue = Globals.EmptySelection;
            pnlDataEntry.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDataEntry.Enabled = true;
        }

        private void txtOpeningBal_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
