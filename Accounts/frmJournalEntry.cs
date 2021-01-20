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

        private void frmJournalEntry_Load(object sender, EventArgs e)
        {
            LoadListings();
            LoadJournalEntryListingSearch("select_journal_entry_listing");
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
        }

        protected void save()
        {
            #region Variables
            JournalEntry.date = dtPickerDate.Value.Date;
            JournalEntry.cat_id = Globals.EJiurnalEntry;
            JournalEntry.reference_number = txt_refference_number.Text;
            JournalEntry.cheque_number = txt_cheque_number.Text;
            JournalEntry.batch_id = txt_batch.Text;
            JournalEntry.payee_desc = txtPayee.Text;
            JournalEntry.entry_desc = txt_description.Text;
            JournalEntry.transaction_amt = decimal.Parse(txtAmount.Text);
            JournalEntry.dr_account = cboDebitAccount.SelectedValue.ToString();
            JournalEntry.cr_account = cboCreditAccount.SelectedValue.ToString();
            JournalEntry.sub_ledger_id = string.Empty;
            JournalEntry.sub_ledger_item_id = string.Empty;
            JournalEntry.sub_ledger_dr_cr = string.Empty;
            JournalEntry.transaction_month = string.Empty;
            JournalEntry.guard_count = 0;
            JournalEntry.guard_days_worked = 0;
            JournalEntry.client_rate = 0;
            JournalEntry.record_audited = chkAudited.Checked == true ? true : false;
            JournalEntry.audit_comment = string.Empty;
            JournalEntry.branch_id = string.Empty;
            JournalEntry.is_on_hold = chkOnHold.Checked ? true : false;
            JournalEntry.is_posted = chkPosted.Checked ? true : false;
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
                JournalEntry.save("save_journal_details");
                MessageBox.Show("Succefully saved new journal entry details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtPickersearchfrom.Checked = false;
                dtPickersearchTo.Checked = false;
                LoadJournalEntryListingSearch("select_journal_entry_listing");


            }
            else
            {
                JournalEntry.journal_entry_id = lblID.Text;
                JournalEntry.save("update_journal_details");
                MessageBox.Show("Succefully updated journal entry details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJournalEntryListingSearch("select_journal_entry_listing");
            }
            #endregion
        }

        protected string ValidateInput()
        {
            string message = string.Empty;

            if (!dtPickerDate.Checked || txtPayee.Text.Trim() == string.Empty || txt_description.Text.Trim() == string.Empty || txtAmount.Text.Trim() ==string.Empty ||
                cboDebitAccount.SelectedValue.ToString() == Globals.EmptySelection || cboCreditAccount.SelectedValue.ToString() == Globals.EmptySelection)
            {
                message = "Please fill in all required fields labelled in red,save failed";
            }
            else if(dtPickerDate.Value > DateTime.Today)
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
        protected void LoadJournalEntryDetails(string journal_entry_id)
        {
            dt = JournalEntry.LoadRecordDetails("select_journal_entry_details", journal_entry_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];

                dtPickerDate.Value = Convert.ToDateTime(dtRow["date"]);
                txt_refference_number.Text = dtRow["reference_number"].ToString();
                txt_cheque_number.Text = dtRow["cheque_number"].ToString();
                txt_batch.Text = dtRow["batch_id"].ToString();
                txtPayee.Text = dtRow["payee_desc"].ToString();
                txt_description.Text = dtRow["entry_desc"].ToString();
               txtAmount.Text =  decimal.Parse(dtRow["transaction_amt"].ToString()).ToString();
                cboDebitAccount.SelectedValue = dtRow["dr_account"].ToString();
                cboCreditAccount.SelectedValue = dtRow["cr_account"].ToString();
                chkOnHold.Checked = Convert.ToBoolean(dtRow["is_on_hold"]);
                chkPosted.Checked = Convert.ToBoolean(dtRow["is_posted"]);
                chkAudited.Checked = Convert.ToBoolean(dtRow["record_audited"]);
                lblID.Text = journal_entry_id;
                grpboxJournalEntry.Enabled = false;
            }
        }

        protected void ClearContent()
        {
            dtPickerDate.Value = DateTime.Today;
            dtPickerDate.Checked = false;
            txt_refference_number.Clear();
            txt_cheque_number.Clear();
            txt_batch.Clear();
            txtPayee.Clear();
            txt_description.Clear();
            txtAmount.Clear();
            cboDebitAccount.SelectedValue = Globals.EmptySelection;
            cboCreditAccount.SelectedValue = Globals.EmptySelection;
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
        }

        private void txtrefsearch_TextChanged(object sender, EventArgs e)
        {
            LoadJournalEntryListingSearch("select_journal_entry_listing");
        }

        private void txtchequesearch_TextChanged(object sender, EventArgs e)
        {
            LoadJournalEntryListingSearch("select_journal_entry_listing");
        }
    }
}
