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
    public partial class frmReceipts : Form
    {
        DataTable dt = new DataTable();
        public frmReceipts()
        {
            InitializeComponent();
            setFont();
        }

        #region setFont
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        protected void setFont()
        {
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font("Microsoft Sans Serif", 14));
        }
        #endregion

        private void frmReceipts_Load(object sender, EventArgs e)
        {
            LoadListings();

            base.WindowState = FormWindowState.Maximized;
        }

        protected void LoadListings()
        {
            LoadSubLedgerCategoryListing();
            LoadDebitCreditListing();
            LoadChartofAccountsListings();
            LoadListingSearch("select_receipt_listing");
        }

        protected void LoadSubLedgerCategoryListing()
        {
            dt = AccountsBackEnd.Lookups.LoadLookup("select_subLedger_accounts_listing");
            DataRow dtRow = dt.NewRow();
            dtRow["sub_ledger_category_id"] = string.Empty;
            dtRow["sub_ledger_category_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboSubAccount.DataSource = dt;
            cboSubAccount.ValueMember = "sub_ledger_category_id";
            cboSubAccount.DisplayMember = "sub_ledger_category_name";
            cboSubAccount.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboSubAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadDebitCreditListing()
        {
            dt = AccountsBackEnd.Lookups.LoadLookup("select_debit_credit_listing");
            DataRow dtRow = dt.NewRow();
            dtRow["ent_id"] = string.Empty;
            dtRow["ent_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboDrCr.DataSource = dt;
            cboDrCr.ValueMember = "ent_id";
            cboDrCr.DisplayMember = "ent_name";
            cboDrCr.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboDrCr.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadSubsidiaryAccountListing(string sub_category_id)
        {
            dt = AccountsBackEnd.Lookups.LoadSubsidiaryAccountByCategory("select_subcidiary_account_by_category", sub_category_id);
            DataRow dtRow = dt.NewRow();
            dtRow["sub_id"] = string.Empty;
            dtRow["sub_title"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboPayee.DataSource = dt;
            cboPayee.ValueMember = "sub_id";
            cboPayee.DisplayMember = "sub_title";
            cboPayee.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboPayee.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadChartofAccountsListings()
        {
            dt = Lookups.LoadLookup("select_account_listing");
            DataRow dtRow = dt.NewRow();
            dtRow["acc_id"] = string.Empty;
            dtRow["acc_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboDebitAccount.DataSource = dt;
            cboDebitAccount.ValueMember = "acc_id";
            cboDebitAccount.DisplayMember = "acc_name";
            cboDebitAccount.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboDebitAccount.AutoCompleteSource = AutoCompleteSource.ListItems;


            dt = Lookups.LoadLookup("select_account_listing");
            DataRow _dtRow = dt.NewRow();
            _dtRow["acc_id"] = string.Empty;
            _dtRow["acc_name"] = "select one";
            dt.Rows.InsertAt(_dtRow, 0);

            cboCreditAccount.DataSource = dt;
            cboCreditAccount.ValueMember = "acc_id";
            cboCreditAccount.DisplayMember = "acc_name";
            cboCreditAccount.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCreditAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cboSubAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubsidiaryAccountListing(cboSubAccount.SelectedValue.ToString());
        }

        #region save
        protected void save()
        {
            #region Variables
            InvoiceManager.date = dtPickerDate.Value.Date;
            InvoiceManager.cat_id = Globals.Ereceipt;
            InvoiceManager.reference_number = txt_refference_number.Text;
            InvoiceManager.cheque_number = txt_cheque_number.Text;
            InvoiceManager.entry_desc = txt_description.Text;
            InvoiceManager.transaction_amt = decimal.Parse(txtAmount.Text);
            InvoiceManager.dr_account = cboDebitAccount.SelectedValue.ToString();
            InvoiceManager.cr_account = cboCreditAccount.SelectedValue.ToString();
            InvoiceManager.sub_ledger_id = cboSubAccount.SelectedValue.ToString();
            InvoiceManager.sub_ledger_item_id = cboPayee.SelectedValue.ToString();
            InvoiceManager.sub_ledger_dr_cr = cboDrCr.SelectedValue.ToString();
            InvoiceManager.transaction_month = dtPickerDate.Value.Month.ToString();
            InvoiceManager.client_rate = txtrate.Text != string.Empty ? decimal.Parse(txtrate.Text) : 0;
            InvoiceManager.record_audited = chkAudited.Checked == true ? true : false;
            InvoiceManager.audit_comment = string.Empty;
            InvoiceManager.branch_id = InvoiceManager.LoadSubsidiaryAccountBranchID("select_subsidiary_account_branch_id", cboPayee.SelectedValue.ToString());
            InvoiceManager.is_on_hold = chkOnHold.Checked ? true : false;
            InvoiceManager.is_posted = chkPosted.Checked ? true : false;
            InvoiceManager.usr_id_create = SystemConst._user_id;
            InvoiceManager.usr_id_update = SystemConst._user_id;
            InvoiceManager.usr_date_create = DateTime.Now;
            InvoiceManager.usr_date_update = DateTime.Now;
            #endregion

            #region save
            if (lblID.Text == Globals.EmptyID)
            {
                InvoiceManager.journal_entry_id = Guid.NewGuid().ToString();
                lblID.Text = InvoiceManager.journal_entry_id;
                InvoiceManager.save("save_journal_details");
                MessageBox.Show("Succefully saved new invoice details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPickersearchfrom.Checked = false;
                dtPickersearchTo.Checked = false;
                LoadListingSearch("select_receipt_listing");


            }
            else
            {
                InvoiceManager.journal_entry_id = lblID.Text;
                InvoiceManager.save("update_journal_details");
                MessageBox.Show("Succefully updated invoice details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListingSearch("select_receipt_listing");
            }
            #endregion
        }

        #endregion

        #region ValidateInput
        protected string ValidateInput()
        {
            string message = string.Empty;

            if (!dtPickerDate.Checked || cboPayee.SelectedValue.ToString() == Globals.EmptySelection || txt_description.Text.Trim() == string.Empty || txtAmount.Text.Trim() == string.Empty ||
                cboDebitAccount.SelectedValue.ToString() == Globals.EmptySelection || cboCreditAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                message = "Please fill in all required fields labelled in red,save failed";
            }
            else if (dtPickerDate.Value > DateTime.Now)
            {
                message = "Transaction date cannot be a future date";
            }
            else if (cboCreditAccount.SelectedValue.ToString() == cboDebitAccount.SelectedValue.ToString())
            {
                message = "Credit & Debit Accounts cannot be the same";
            }
            else
            {
                message = string.Empty;
            }

            return message;
        }
        #endregion

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (ValidateInput().Length == 0)
            {
                save();
            }
            else
            {
                MessageBox.Show(ValidateInput(), "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void LoadListing(string query)
        {

            dt = InvoiceManager.LoadListing(query);

            gdvList.DataSource = dt;
            gdvList.Columns["journal_entry_id"].Visible = false;
            gdvList.Columns["date"].HeaderText = "Date";
            gdvList.Columns["reference_number"].HeaderText = "Ref";
            gdvList.Columns["cheque_number"].HeaderText = "Cheque";
            gdvList.Columns["batch_id"].HeaderText = "Batch";
            gdvList.Columns["transaction_amt"].HeaderText = "Amount";
            gdvList.Columns["dr_account"].HeaderText = "Dr Acc";
            gdvList.Columns["cr_account"].HeaderText = "Cr Acc";
            gdvList.Columns["is_on_hold"].HeaderText = "On Hold";
            gdvList.Columns["is_posted"].HeaderText = "Posted";

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


        protected void LoadListingSearch(string query)
        {
            DateTime? date_from = null;
            DateTime? date_to = null;
            #region dates
            if (!dtPickersearchfrom.Checked)
            {
                date_from = null;
            }
            else
            {
                date_from = dtPickersearchfrom.Value;
            }

            if (!dtPickersearchTo.Checked)
            {
                date_to = null;
            }
            else
            {
                date_to = dtPickersearchTo.Value;
            }
            #endregion

            if (dtPickersearchfrom.Value > dtPickersearchTo.Value)
            {
                MessageBox.Show("Start date cannot be greater than end date", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtPickersearchfrom.Checked && !dtPickersearchTo.Checked)
            {
                MessageBox.Show("Please select an end date", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!dtPickersearchfrom.Checked && dtPickersearchTo.Checked)
            {
                MessageBox.Show("Please select a start date", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt = JournalEntry.LoadListingSearch(query, date_from, date_to, txtrefsearch.Text, txtchequesearch.Text);

                gdvList.DataSource = dt;
                gdvList.Columns["journal_entry_id"].Visible = false;
                gdvList.Columns["date"].HeaderText = "Date";
                gdvList.Columns["reference_number"].HeaderText = "Ref";
                gdvList.Columns["cheque_number"].HeaderText = "Cheque";
                gdvList.Columns["batch_id"].HeaderText = "Batch";
                gdvList.Columns["transaction_amt"].HeaderText = "Amount";
                gdvList.Columns["dr_account"].HeaderText = "Dr Acc";
                gdvList.Columns["cr_account"].HeaderText = "Cr Acc";
                gdvList.Columns["is_on_hold"].HeaderText = "On Hold";
                gdvList.Columns["is_posted"].HeaderText = "Posted";

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
        protected void LoadDetails(string journal_entry_id)
        {
            dt = JournalEntry.LoadRecordDetails("select_journal_entry_details", journal_entry_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];

                dtPickerDate.Value = Convert.ToDateTime(dtRow["date"]);
                dtPickerDate.Checked = true;
                txt_refference_number.Text = dtRow["reference_number"].ToString();
                txt_cheque_number.Text = dtRow["cheque_number"].ToString();
                cboSubAccount.SelectedValue = dtRow["sub_ledger_id"].ToString();
                cboDrCr.SelectedValue = dtRow["sub_ledger_dr_cr"].ToString();
                cboPayee.SelectedValue = dtRow["sub_ledger_item_id"].ToString();
                txt_description.Text = dtRow["entry_desc"].ToString();
                txtAmount.Text = decimal.Parse(dtRow["transaction_amt"].ToString()).ToString();
                cboDebitAccount.SelectedValue = dtRow["dr_account"].ToString();
                cboCreditAccount.SelectedValue = dtRow["cr_account"].ToString();
                chkOnHold.Checked = Convert.ToBoolean(dtRow["is_on_hold"]);
                chkPosted.Checked = Convert.ToBoolean(dtRow["is_posted"]);
                chkAudited.Checked = Convert.ToBoolean(dtRow["record_audited"]);
                lblID.Text = journal_entry_id;
                grpboxEntry.Enabled = false;
            }
        }

        protected void ClearContent()
        {
            dtPickerDate.Value = DateTime.Today;
            dtPickerDate.Checked = false;
            txt_refference_number.Clear();
            txt_cheque_number.Clear();
            cboSubAccount.SelectedValue = Globals.EmptySelection;
            cboDrCr.SelectedValue = Globals.EmptySelection;
            cboPayee.SelectedValue = Globals.EmptySelection;
            txt_description.Clear();
            txtAmount.Clear();
            cboDebitAccount.SelectedValue = Globals.EmptySelection;
            cboCreditAccount.SelectedValue = Globals.EmptySelection;
            chkOnHold.Checked = false;
            chkPosted.Checked = false;
            lblID.Text = Globals.EmptyID;
            grpboxEntry.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpboxEntry.Enabled = true;
        }

        private void gdvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (gdvList.Rows.Count > 0)
            {
                LoadDetails(gdvList.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadListingSearch("select_receipt_listing");
        }

        private void txtchequesearch_TextChanged(object sender, EventArgs e)
        {
            LoadListingSearch("select_receipt_listing");
        }

        private void txtrefsearch_TextChanged(object sender, EventArgs e)
        {
            LoadListingSearch("select_receipt_listing");
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lblID.Text == "--")
            {
                MessageBox.Show("Please select a record from the list to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete these record?This cannot be undone but it will still be tracked as deleted.", "Delete Record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    JournalEntry.ApplySoftDelete("update_apply_soft_delete", lblID.Text);
                    LoadListingSearch("select_receipt_listing");
                    MessageBox.Show("Record successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }


            }
        }
    }
}
