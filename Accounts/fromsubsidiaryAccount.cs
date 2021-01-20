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
    public partial class frmsubsidiaryAccount : Form
    {
        DataTable dt = new DataTable();
        public frmsubsidiaryAccount()
        {
            InitializeComponent();
        }

        private void fromsubsidiaryAccount_Load(object sender, EventArgs e)
        {
            LoadListings();
            base.WindowState = FormWindowState.Maximized;
        }

        protected void LoadNorminalAccountList()
        {
            dt = ChartofAccounts.LoadListing("select_chart_of_acounts_listing");
            DataRow dtRow = dt.NewRow();
            dtRow["acc_id"] = string.Empty;
            dtRow["acc_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboNorminalAcc.DataSource = dt;
            cboNorminalAcc.ValueMember = "acc_id";
            cboNorminalAcc.DisplayMember = "acc_name";

            cboNorminalAcc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboNorminalAcc.AutoCompleteSource = AutoCompleteSource.ListItems;


            dt = ChartofAccounts.LoadListing("select_chart_of_acounts_listing");
            DataRow _dtRow = dt.NewRow();
            _dtRow["acc_id"] = string.Empty;
            _dtRow["acc_name"] = "select one";
            dt.Rows.InsertAt(_dtRow, 0);

            cboControlAccSearch.DataSource = dt;
            cboControlAccSearch.ValueMember = "acc_id";
            cboControlAccSearch.DisplayMember = "acc_name";

            cboControlAccSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboControlAccSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        protected void LoadSubLedger()
        {
            dt = SubLedgerCategory.LoadRecord("select_sub_ledger_category_details", string.Empty);
            DataRow dtRow = dt.NewRow();
            dtRow["sub_ledger_category_id"] = string.Empty;
            dtRow["sub_ledger_category_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboLedgerCategory.DataSource = dt;
            cboLedgerCategory.ValueMember = "sub_ledger_category_id";
            cboLedgerCategory.DisplayMember = "sub_ledger_category_name";

            cboLedgerCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboLedgerCategory.AutoCompleteSource = AutoCompleteSource.ListItems;

            dt = SubLedgerCategory.LoadRecord("select_sub_ledger_category_details", string.Empty);
            DataRow _dtRow = dt.NewRow();
            _dtRow["sub_ledger_category_id"] = string.Empty;
            _dtRow["sub_ledger_category_name"] = "select one";
            dt.Rows.InsertAt(_dtRow, 0);

            cboSubLedgerSearch.DataSource = dt;
            cboSubLedgerSearch.ValueMember = "sub_ledger_category_id";
            cboSubLedgerSearch.DisplayMember = "sub_ledger_category_name";

            cboSubLedgerSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboSubLedgerSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadListings()
        {
            LoadNorminalAccountList();
            LoadBranchList();
            LoadSubLedger();
            LoadGridviewListing();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(ValidateInput().Length == 0)
            {
                save();
            }
            else
            {
                MessageBox.Show(ValidateInput(), "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        protected void save()
        {
            #region Variables
            SubcidiaryAccount.sub_code = txtcode.Text;
            SubcidiaryAccount.sub_title = txtTitle.Text;
            SubcidiaryAccount.sub_category_id = cboLedgerCategory.SelectedValue.ToString();
            SubcidiaryAccount.sub_opening_bal = txtOpeningBal.Text != string.Empty.Trim() ? decimal.Parse(txtOpeningBal.Text.Trim()) : 0;
            SubcidiaryAccount.nominal_acc_id = cboNorminalAcc.SelectedValue.ToString();
            SubcidiaryAccount.debit_credit = cboDebitCredit.Text;
            SubcidiaryAccount.active = chkActive.Checked ? true : false;
            SubcidiaryAccount.tel_contact = txtPhone.Text;
            SubcidiaryAccount.email_adress = txtEmail.Text;
            SubcidiaryAccount.adress = txtAddress.Text;
            SubcidiaryAccount.branch_id = cboBranch.SelectedValue.ToString();
            SubcidiaryAccount.usr_id_create = SystemConst._user_id;
            SubcidiaryAccount.usr_id_update = SystemConst._user_id;
            SubcidiaryAccount.usr_date_create = DateTime.Now;
            SubcidiaryAccount.usr_date_update = DateTime.Now;
            #endregion

            if(lblID.Text == Globals.EmptyID)
            {
                SubcidiaryAccount.sub_id = Guid.NewGuid().ToString();
                lblID.Text = SubcidiaryAccount.sub_id;
                SubcidiaryAccount.save("save_record");
                MessageBox.Show("Succefully saved new subsidiary account details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SubcidiaryAccount.sub_id = lblID.Text;
                SubcidiaryAccount.save("update_record");
                MessageBox.Show("Succefully updated subsidiary account details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected string ValidateInput()
        {
            string message = string.Empty;

            if (txtcode.Text.Trim() == string.Empty || txtTitle.Text.Trim() == string.Empty  || cboLedgerCategory.SelectedValue.ToString() == Globals.EmptySelection ||
              txtOpeningBal.Text.Trim() == string.Empty ||  cboDebitCredit.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty || 
              txtAddress.Text.Trim() == string.Empty)
            {
                message = "Please fill in all required values";
            }
            else
            {
                message = string.Empty;
            }

            return message;
        }

        protected void LoadGridviewListing()
        {
            dt = SubcidiaryAccount.LoadList("select_record_listing",string.Empty,string.Empty,string.Empty);
            if(dt != null)
            {
                gdvList.DataSource = dt;

                gdvList.Columns["sub_id"].Visible = false;
                gdvList.Columns["adress"].Visible = false;

                gdvList.Columns["sub_title"].HeaderText = "Account Title";
                gdvList.Columns["sub_code"].HeaderText = "Account Code";
                gdvList.Columns["sub_opening_bal"].HeaderText = "Opening Bal";
                gdvList.Columns["debit_credit"].HeaderText = "Dr/Cr";
                gdvList.Columns["sub_ledger_category_name"].HeaderText = "Sub Ledger";
                gdvList.Columns["acc_name"].HeaderText = "Control Acc Title";
                gdvList.Columns["active"].HeaderText = "Active";
                gdvList.Columns["tel_contact"].HeaderText = "Phone Number";
                gdvList.Columns["email_adress"].HeaderText = "Email Address";
                gdvList.Columns["branch"].HeaderText = "Branch";

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
        }

        protected void SearchGridviewListing()
        {
            dt = SubcidiaryAccount.LoadList("select_record_listing",txtCodeSearch.Text.Trim(),cboSubLedgerSearch.SelectedValue.ToString(),cboControlAccSearch.SelectedValue.ToString());
            if (dt != null)
            {
                gdvList.DataSource = dt;

                gdvList.Columns["sub_id"].Visible = false;
                gdvList.Columns["adress"].Visible = false;

                gdvList.Columns["sub_title"].HeaderText = "Account Title";
                gdvList.Columns["sub_code"].HeaderText = "Account Code";
                gdvList.Columns["sub_opening_bal"].HeaderText = "Opening Bal";
                gdvList.Columns["debit_credit"].HeaderText = "Dr/Cr";
                gdvList.Columns["sub_ledger_category_name"].HeaderText = "Sub Ledger";
                gdvList.Columns["acc_name"].HeaderText = "Control Acc Title";
                gdvList.Columns["active"].HeaderText = "Active";
                gdvList.Columns["tel_contact"].HeaderText = "Phone Number";
                gdvList.Columns["email_adress"].HeaderText = "Email Address";
                gdvList.Columns["branch"].HeaderText = "Branch";

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
        }

        protected void LoadRecordDetails(string id)
        {
            dt = SubcidiaryAccount.LoadRecord("select_record_details",id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];

                txtcode.Text = dtRow["sub_code"].ToString();
                txtTitle.Text = dtRow["sub_title"].ToString();
                cboLedgerCategory.SelectedValue = dtRow["sub_category_id"].ToString();
                txtOpeningBal.Text = decimal.Parse(dtRow["sub_opening_bal"].ToString()).ToString();
                cboNorminalAcc.SelectedValue = dtRow["nominal_acc_id"].ToString();
                cboDebitCredit.Text = dtRow["sub_category_id"].ToString();
                chkActive.Checked = Convert.ToBoolean(dtRow["active"]);
                txtPhone.Text = dtRow["tel_contact"].ToString();
                txtEmail.Text = dtRow["email_adress"].ToString();
                txtAddress.Text = dtRow["adress"].ToString();
                cboBranch.SelectedValue = dtRow["branch_id"].ToString();
                lblID.Text = id;
                pnlDataEntry.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDataEntry.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtcode.Clear();
            txtTitle.Clear();
            cboLedgerCategory.SelectedValue = Globals.EmptySelection;
            txtOpeningBal.Clear();
            cboNorminalAcc.SelectedValue = Globals.EmptySelection;
            cboDebitCredit.Text = string.Empty;
            chkActive.Checked = true;
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cboBranch.SelectedValue = Globals.EmptySelection;
            lblID.Text = Globals.EmptyID;
            pnlDataEntry.Enabled = true;
        }

        private void gdvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdvList.Rows.Count > 0)
            {
                LoadRecordDetails(gdvList.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            SearchGridviewListing();
        }

        private void cboSubLedgerSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboSubLedgerSearch.SelectedIndex != -1)
            //{
            //    SearchGridviewListing();
            //}
           
        }

        private void cboControlAccSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboControlAccSearch.SelectedIndex != -1)
            //{
            //    SearchGridviewListing();
            //}
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchGridviewListing();
        }
    }
}
