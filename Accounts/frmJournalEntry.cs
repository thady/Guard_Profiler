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
    public partial class frmJournalEntry : Form
    {
        DataTable dt = new DataTable();
        public frmJournalEntry()
        {
            InitializeComponent();
            //setFont();
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

        private void frmJournalEntry_Load(object sender, EventArgs e)
        {
            LoadListings();
            LoadSubLedgerCategoryListing();
            LoadDebitCreditListing();
            //LoadJournalEntryListingSearch("select_journal_entry_listing");
            LoadDebitCreditTotals();
            base.WindowState = FormWindowState.Maximized;
        }

        protected void LoadListings()
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

            dt = Lookups.LoadLookup("select_financial_year_listing");
            DataRow fydtRow = dt.NewRow();
            fydtRow["fy_id"] = string.Empty;
            fydtRow["fy_name"] = "select one";
            dt.Rows.InsertAt(fydtRow, 0);

            cboFy.DataSource = dt;
            cboFy.ValueMember = "fy_id";
            cboFy.DisplayMember = "fy_name";


            dt = Lookups.LoadLookup("select_financial_year_listing");
            DataRow _fydtRow = dt.NewRow();
            _fydtRow["fy_id"] = string.Empty;
            _fydtRow["fy_name"] = "select one";
            dt.Rows.InsertAt(_fydtRow, 0);

            cboYearPost.DataSource = dt;
            cboYearPost.ValueMember = "fy_id";
            cboYearPost.DisplayMember = "fy_name";

            cboMonthPost.DataSource = CreateMonthsTable();
            cboMonthPost.DisplayMember = "month_name";
            cboMonthPost.ValueMember = "month_id";
        }


        static DataTable CreateMonthsTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("month_id", typeof(string));
            table.Columns.Add("month_name", typeof(string));

            table.Rows.Add("", "select month");
            table.Rows.Add("1", "January");
            table.Rows.Add("2", "February");
            table.Rows.Add("3", "March");
            table.Rows.Add("4", "April");
            table.Rows.Add("5", "May");
            table.Rows.Add("6", "June");
            table.Rows.Add("7", "July");
            table.Rows.Add("8", "August");
            table.Rows.Add("9", "September");
            table.Rows.Add("10", "October");
            table.Rows.Add("11", "November");
            table.Rows.Add("12", "December");
            return table;
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

        protected void save()
        {
            #region Variables
            JournalEntry.date = dtPickerDate.Value.Date;
            JournalEntry.cat_id = Globals.EJiurnalEntry;
            JournalEntry.reference_number = txt_refference_number.Text;
            JournalEntry.cheque_number = txt_cheque_number.Text;
            JournalEntry.payee_desc = txtPayee.Text;
            JournalEntry.entry_desc = txt_description.Text;
            JournalEntry.transaction_amt = decimal.Parse(txtAmount.Text);
            JournalEntry.dr_account = cboDebitAccount.SelectedValue.ToString();
            JournalEntry.cr_account = cboCreditAccount.SelectedValue.ToString();
            JournalEntry.sub_ledger_id = cboSubAccount.SelectedValue.ToString() != Globals.EmptySelection ? cboSubAccount.SelectedValue.ToString() : string.Empty;
            JournalEntry.sub_ledger_item_id = cboPayee.SelectedValue.ToString() != Globals.EmptySelection ? cboPayee.SelectedValue.ToString() : string.Empty;
            JournalEntry.sub_ledger_dr_cr = cboDrCr.SelectedValue.ToString() != Globals.EmptySelection ? cboDrCr.SelectedValue.ToString() : string.Empty;
            JournalEntry.transaction_month = dtPickerDate.Value.Month.ToString();
            JournalEntry.guard_count = 0;
            JournalEntry.guard_days_worked = 0;
            JournalEntry.client_rate = 0;
            JournalEntry.record_audited = chkAudited.Checked == true ? true : false;
            JournalEntry.audit_comment = string.Empty;
            JournalEntry.branch_id = string.Empty;
            JournalEntry.is_on_hold = chkOnHold.Checked ? true : false;
            JournalEntry.is_posted = chkPosted.Checked ? true : false;
            JournalEntry.fy_id = cboFy.SelectedValue.ToString();
            JournalEntry.usr_id_create = SystemConst._user_id;
            JournalEntry.usr_id_update = SystemConst._user_id;
            JournalEntry.usr_date_create = DateTime.Now;
            JournalEntry.usr_date_update = DateTime.Now;
            #endregion

            #region save
            if (lblID.Text == Globals.EmptyID)
            {
                JournalEntry.journal_entry_id = Guid.NewGuid().ToString();
                lblID.Text = JournalEntry.journal_entry_id;
                JournalEntry.is_deleted = false;
                JournalEntry.save("save_journal_details");
                MessageBox.Show("Succefully saved new journal entry details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPickersearchfrom.Checked = false;
                dtPickersearchTo.Checked = false;
                LoadJournalEntryListingSearch("select_journal_entry_listing");
                LoadDebitCreditTotals();


            }
            else
            {
                JournalEntry.journal_entry_id = lblID.Text;
                JournalEntry.save("update_journal_details");
                MessageBox.Show("Succefully updated journal entry details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJournalEntryListingSearch("select_journal_entry_listing");
                LoadDebitCreditTotals();
            }
            #endregion
        }

        protected string ValidateInput()
        {
            string message = string.Empty;

            if (!dtPickerDate.Checked ||  txt_description.Text.Trim() == string.Empty || txtAmount.Text.Trim() ==string.Empty ||
                (!chksimultaneousoffOnDebit.Checked && !chksimultaneousoffOnCredit.Checked && (cboDebitAccount.SelectedValue.ToString() == Globals.EmptySelection || cboCreditAccount.SelectedValue.ToString() == Globals.EmptySelection))  || cboFy.SelectedValue.ToString() == Globals.EmptySelection)
            {
                message = "Please fill in all required fields labelled in red,save failed";
            }
            else if(chksimultaneousoffOnDebit.Checked & cboDebitAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                message = "Debit account is required Debit non simultaneous journal entry";
            }
            else if (chksimultaneousoffOnCredit.Checked & cboCreditAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                message = "Credit account is required Credit non simultaneous journal entry";
            }
            else if(dtPickerDate.Value > DateTime.Now)
            {
                message = "Transaction date cannot be a future date";
            }
            else if (cboCreditAccount.SelectedValue.ToString() == cboDebitAccount.SelectedValue.ToString())
            {
                message = "Credit & Debit Accounts cannot be the same";
            }
            else if(JournalEntry.ValidateJournalEntryDate("validate_journal_date_range",dtPickerDate.Value, cboFy.SelectedValue.ToString()) == 0)
            {
                message = "The selected journal date does not fall in the range of the selected financial year";
            }
            else if (cboSubAccount.SelectedValue.ToString() != Globals.EmptySelection)
            {
                if(cboPayee.SelectedValue.ToString() == Globals.EmptySelection)
                {
                    message = "Please select a payee";
                }
                else if(cboDrCr.SelectedValue.ToString() == Globals.EmptySelection)
                {
                    message = "Please select either debit or credit";
                }
            }
            else if(cboSubAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                if(txtPayee.Text.Trim() == string.Empty)
                {
                    message = "Please enter payee name in the textbox";
                }
            }
            else
            {
                message = string.Empty;
            }

            return message;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (ValidateInput().Length == 0)
            {
                save();
                ClearPartialContent();
            }
            else
            {
                MessageBox.Show(ValidateInput(), "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            btnsave_Click(btnsave,null); 
        }

        protected void LoadJournalEntryListing(string query)
        {
             
                dt = JournalEntry.LoadListing(query);

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

        protected void LoadDebitCreditTotals()
        {
            dt = JournalEntry.LoadDebitCreditTotals("select_debit_credit_totals");
            DataRow dtRow = dt.Rows[0];
            txtTotalDebit.Text = float.Parse(dtRow["Debit"].ToString()) > 0? float.Parse(dtRow["Debit"].ToString()).ToString():string.Empty;
            txtTotalCredit.Text = float.Parse(dtRow["Credit"].ToString()) > 0? float.Parse(dtRow["Credit"].ToString()).ToString():string.Empty;
        }

        protected void LoadDebitCreditTotals(string query,int year,int month)
        {
            dt = JournalEntry.LoadDebitCreditTotalsByMonth(query, year, month);
            DataRow dtRow = dt.Rows[0];
            txtTotalDebit.Text = float.Parse(dtRow["Debit"].ToString()) > 0 ? float.Parse(dtRow["Debit"].ToString()).ToString() : string.Empty;
            txtTotalCredit.Text = float.Parse(dtRow["Credit"].ToString()) > 0 ? float.Parse(dtRow["Credit"].ToString()).ToString() : string.Empty;
        }


        protected void LoadJournalEntryListingSearch(string query)
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

            if (dtPickersearchfrom.Value.Date > dtPickersearchTo.Value.Date )
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
                gdvList.Columns["date"].Width = 50;
                gdvList.Columns["reference_number"].HeaderText = "Ref";
                gdvList.Columns["reference_number"].Width = 50;
                gdvList.Columns["cheque_number"].HeaderText = "Cheque";
                gdvList.Columns["cheque_number"].Width = 50;
                gdvList.Columns["batch_id"].HeaderText = "Batch";
                gdvList.Columns["batch_id"].Width = 50;
                gdvList.Columns["transaction_amt"].HeaderText = "Amount";
                gdvList.Columns["transaction_amt"].Width = 50;
                gdvList.Columns["dr_account"].HeaderText = "Dr Acc";
                gdvList.Columns["cr_account"].HeaderText = "Cr Acc";
                gdvList.Columns["dr_account"].Width = 170;
                gdvList.Columns["cr_account"].Width = 170;

                gdvList.Columns["is_on_hold"].HeaderText = "Hold";
                gdvList.Columns["is_on_hold"].Width = 70;
                gdvList.Columns["is_posted"].HeaderText = "Posted";
                gdvList.Columns["is_posted"].Width = 50;

                gdvList.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdvList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                gdvList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdvList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                gdvList.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                gdvList.DefaultCellStyle.SelectionForeColor = Color.Black;
                foreach (DataGridViewColumn c in this.gdvList.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9f, GraphicsUnit.Pixel);
                }
                this.gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdvList.EnableHeadersVisualStyles = false;
            }


        }


        protected void LoadJournalEntryListing_for_posting(string query)
        {

            dt = JournalEntry.LoadListingPost(query,Convert.ToInt32(cboYearPost.Text), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));

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
        protected void LoadJournalEntryDetails(string journal_entry_id)
        {
            dt = JournalEntry.LoadRecordDetails("select_journal_entry_details", journal_entry_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];

                dtPickerDate.Value = Convert.ToDateTime(dtRow["date"]);
                txt_refference_number.Text = dtRow["reference_number"].ToString();
                txt_cheque_number.Text = dtRow["cheque_number"].ToString();
                txtPayee.Text = dtRow["payee_desc"].ToString();
                txt_description.Text = dtRow["entry_desc"].ToString();
                txtAmount.Text = decimal.Parse(dtRow["transaction_amt"].ToString()).ToString();
                cboDebitAccount.SelectedValue = dtRow["dr_account"].ToString();
                cboCreditAccount.SelectedValue = dtRow["cr_account"].ToString();
                chkOnHold.Checked = Convert.ToBoolean(dtRow["is_on_hold"]);
                chkPosted.Checked = Convert.ToBoolean(dtRow["is_posted"]);
                chkAudited.Checked = Convert.ToBoolean(dtRow["record_audited"]);

                cboSubAccount.SelectedValue = dtRow["sub_ledger_id"].ToString();
                cboPayee.SelectedValue = dtRow["sub_ledger_item_id"].ToString();
                cboDrCr.SelectedValue = dtRow["sub_ledger_dr_cr"].ToString();
                cboFy.SelectedValue = dtRow["fy_id"].ToString();

                lblID.Text = journal_entry_id;
                grpboxJournalEntry.Enabled = false;

                if(dtRow["dr_account"].ToString() == string.Empty)
                {
                    chksimultaneousoffOnCredit.Checked = true;
                }

                if (dtRow["cr_account"].ToString() == string.Empty)
                {
                    chksimultaneousoffOnDebit.Checked = true;
                }

            }
        }

        protected void ClearContent()
        {
            dtPickerDate.Value = DateTime.Today;
            dtPickerDate.Checked = false;
            txt_refference_number.Clear();
            txt_cheque_number.Clear();
            txtPayee.Clear();
            txt_description.Clear();
            txtAmount.Clear();
            cboDebitAccount.SelectedValue = Globals.EmptySelection;
            cboCreditAccount.SelectedValue = Globals.EmptySelection;
            cboDrCr.SelectedValue = Globals.EmptySelection;
            cboSubAccount.SelectedValue = Globals.EmptySelection;
            cboPayee.SelectedValue = Globals.EmptySelection;
            cboDrCr.SelectedValue = Globals.EmptySelection;
            cboFy.SelectedValue = Globals.EmptySelection;
            chkOnHold.Checked = false;
            chkPosted.Checked = false;
            chksimultaneousoffOnDebit.Enabled = true;
            chksimultaneousoffOnDebit.Checked = false;
            chksimultaneousoffOnCredit.Enabled = true;
            chksimultaneousoffOnCredit.Checked = false;
            chkLockFields.Checked = false;
            lblID.Text = Globals.EmptyID;
            grpboxJournalEntry.Enabled = true;
        }

        protected void ClearPartialContent()
        {
            if (!chkLockFields.Checked)
            {
                dtPickerDate.Value = DateTime.Today;
                dtPickerDate.Checked = false;
                txt_refference_number.Clear();
                txt_cheque_number.Clear();
                txtPayee.Clear();
                cboFy.SelectedValue = Globals.EmptySelection;
            }

            txt_description.Clear();
            txtAmount.Clear();
            cboDebitAccount.SelectedValue = Globals.EmptySelection;
            cboCreditAccount.SelectedValue = Globals.EmptySelection;
            cboDrCr.SelectedValue = Globals.EmptySelection;
            cboSubAccount.SelectedValue = Globals.EmptySelection;
            cboPayee.SelectedValue = Globals.EmptySelection;
            cboDrCr.SelectedValue = Globals.EmptySelection;
            chkOnHold.Checked = false;
            chkPosted.Checked = false;
            lblID.Text = Globals.EmptyID;
            grpboxJournalEntry.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpboxJournalEntry.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void gdvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdvList.Rows.Count > 0)
            {
                LoadJournalEntryDetails(gdvList.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadJournalEntryListingSearch("select_journal_entry_listing");
            ClearContent();
        }

        private void txtrefsearch_TextChanged(object sender, EventArgs e)
        {
            LoadJournalEntryListingSearch("select_journal_entry_listing");
        }

        private void txtchequesearch_TextChanged(object sender, EventArgs e)
        {
            LoadJournalEntryListingSearch("select_journal_entry_listing");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lblID.Text == "--")
            {
                MessageBox.Show("Please select a record from the list to delete", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete these record?This cannot be undone but it will still be tracked as deleted.", "Delete Record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    JournalEntry.ApplySoftDelete("update_apply_soft_delete", lblID.Text);
                    LoadJournalEntryListingSearch("select_journal_entry_listing");
                    MessageBox.Show("Record successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                }

               
            }
        }

        private void cboSubAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubsidiaryAccountListing(cboSubAccount.SelectedValue.ToString());

            if(cboSubAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                cboPayee.SelectedValue = Globals.EmptySelection;
                cboPayee.Enabled = false;
                cboDrCr.SelectedValue = Globals.EmptySelection;
                cboDrCr.Enabled = false;

                txtPayee.Enabled = true;
            }
            else
            {
                cboPayee.SelectedValue = Globals.EmptySelection;
                cboPayee.Enabled = true;
                cboDrCr.SelectedValue = Globals.EmptySelection;
                cboDrCr.Enabled = true;

                txtPayee.Enabled = false;
                txtPayee.Clear();
            }
        }

        private void chksimultaneousoffOn_CheckedChanged(object sender, EventArgs e)
        {
            if (chksimultaneousoffOnDebit.Checked)
            {
                chksimultaneousoffOnCredit.Checked = false;
                cboCreditAccount.Enabled = false;
                cboCreditAccount.SelectedIndex = 0;
                cboDebitAccount.Enabled = true;
            }
            else
            {
                cboDebitAccount.Enabled = false;
                cboDebitAccount.SelectedIndex = 0;
                cboCreditAccount.Enabled = true;
            }

            if(!chksimultaneousoffOnDebit.Checked & !chksimultaneousoffOnCredit.Checked)
            {
                cboDebitAccount.Enabled = true;
                cboCreditAccount.Enabled = true;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (cboYearPost.SelectedValue.ToString() ==Globals.EmptySelection || cboMonthPost.SelectedValue.ToString() == Globals.EmptySelection)
            {
                MessageBox.Show("Please select a year and month before posting", "Post Journal Entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((txtTotalDebit.Text !=string.Empty? Convert.ToInt32(txtTotalDebit.Text) : 0) != (txtTotalCredit.Text !=string.Empty?  Convert.ToInt32(txtTotalCredit.Text):0))
            {
                MessageBox.Show("Total Debits must be equal to total credits for the selected period.", "Post Journal Entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (gdvList.Rows.Count > 0)
                {

                    DialogResult dialogResult = MessageBox.Show("You are about to run a batch post for your journal entries.Are you sure you want to post these transactions for Date:" + cboMonthPost + " : " + cboYearPost.Text + " ? Please make sure to have reviewed and confirmed that all transactions are correct.", "Post Journal Entries", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int x = 0; x < gdvList.Rows.Count; x++)
                        {
                            string id = gdvList.Rows[x].Cells[0].Value.ToString();
                            JournalEntry.PostJournalEntry("post_journal_entry", id);
                        }
                        MessageBox.Show("All journal entries for " + cboMonthPost.Text + " : " + cboYearPost.Text + " have been posted.", "Post Journal Entries", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadJournalEntryListing_for_posting("select_journal_entry_listing_posting");
                        LoadDebitCreditTotals("select_debit_credit_totals_posting", Convert.ToInt32(cboYearPost.Text), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
                else
                {
                    MessageBox.Show("No journal entries available to post for the selected date", "Post Journal Entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
        }

        private void chksimultaneousoffOnCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (chksimultaneousoffOnCredit.Checked)
            {
                chksimultaneousoffOnDebit.Checked = false;
            }
           
            chksimultaneousoffOn_CheckedChanged(chksimultaneousoffOnDebit, null);
        }

        private void cboYearPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboYearPost.SelectedIndex != -1 & cboMonthPost.SelectedIndex != -1)
            //{
            //   LoadJournalEntryListing_for_posting("select_journal_entry_listing_posting");
            //    LoadDebitCreditTotals("select_debit_credit_totals_posting", Convert.ToInt32(cboYearPost.SelectedValue.ToString()), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));
            //}
           
        }

        private void cboMonthPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMonthPost.SelectedIndex != -1 & cboYearPost.SelectedIndex != -1)
            //{
            //    LoadJournalEntryListing_for_posting("select_journal_entry_listing_posting");
            //    LoadDebitCreditTotals("select_debit_credit_totals_posting", Convert.ToInt32(cboYearPost.SelectedValue.ToString()), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));
            //} 
        }

        private void cboYearPost_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboYearPost.SelectedValue.ToString() != Globals.EmptySelection & cboMonthPost.SelectedValue.ToString() != Globals.EmptySelection)
            {
                LoadJournalEntryListing_for_posting("select_journal_entry_listing_posting");
                LoadDebitCreditTotals("select_debit_credit_totals_posting", Convert.ToInt32(cboYearPost.Text), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));
            }
        }

        private void cboMonthPost_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboYearPost.SelectedValue.ToString() != Globals.EmptySelection & cboMonthPost.SelectedValue.ToString() != Globals.EmptySelection)
            {
                LoadJournalEntryListing_for_posting("select_journal_entry_listing_posting");
                LoadDebitCreditTotals("select_debit_credit_totals_posting", Convert.ToInt32(cboYearPost.Text), Convert.ToInt32(cboMonthPost.SelectedValue.ToString()));
            }
        }
    }
}
