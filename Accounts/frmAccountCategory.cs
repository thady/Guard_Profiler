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
    public partial class frmAccountCategory : Form
    {
        DataTable dt = new DataTable();
        public frmAccountCategory()
        {
            InitializeComponent();
        }

        private void frmAccountCategory_Load(object sender, EventArgs e)
        {
            LoadYesNo();
            LoadAccountCategoryReport();
            LoadAccountCategoryList();
        }

        protected void LoadYesNo()
        {
            dt = Lookups.LoadLookup("select_yes_no_list");
            DataRow dtRow = dt.NewRow();
            dtRow["yn_id"] = string.Empty;
            dtRow["yn_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboActive.DataSource = dt;
            cboActive.ValueMember = "yn_id";
            cboActive.DisplayMember = "yn_name";
        }

        protected void LoadAccountCategoryReport()
        {
            dt = Lookups.LoadLookup("select_account_category_report");
            DataRow dtRow = dt.NewRow();
            dtRow["report_id"] = string.Empty;
            dtRow["report_name"] = "select one";
            dt.Rows.InsertAt(dtRow, 0);

            cboAccountReport.DataSource = dt;
            cboAccountReport.ValueMember = "report_id";
            cboAccountReport.DisplayMember = "report_name";
        }

        protected void LoadAccountCategoryList()
        {
            dt = Lookups.LoadLookup("select_account_category_listing");
            gdvList.DataSource = dt;
            gdvList.Columns["acc_type_id"].Visible = false;
            gdvList.Columns["acc_type_number"].HeaderText = "Account Category Number";
            gdvList.Columns["acc_type_name"].HeaderText = "Account Category Name";
            gdvList.Columns["yn_name"].HeaderText = "Account Category Active";
            gdvList.Columns["report_name"].HeaderText = "Financial Report";

            gdvList.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            gdvList.DefaultCellStyle.SelectionForeColor = Color.Black;
            foreach (DataGridViewColumn c in this.gdvList.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
            }
            this.gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvList.EnableHeadersVisualStyles = false;
        }

        protected void save()
        {
            #region variables

            Lookups.acc_type_number = txtAccountNumber.Text;
            Lookups.acc_type_name = txtAccountName.Text;
            Lookups.active = cboActive.SelectedValue.ToString();
            Lookups.report_id = cboAccountReport.SelectedValue.ToString();
            Lookups.usr_id_create = SystemConst._user_id;
            Lookups.usr_id_update = SystemConst._user_id;
            Lookups.usr_date_create = DateTime.Now;
            Lookups.usr_date_update = DateTime.Now;
            #endregion
            if (lblID.Text == Globals.EmptyID)
            {
                Lookups.acc_type_id = Guid.NewGuid().ToString();
                Lookups.save_Accounts_lst_account_type("save_account_category_details");
                MessageBox.Show("Succefully saved new account category details", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountCategoryList();
            }
            else
            {
                Lookups.acc_type_id = lblID.Text;
                Lookups.save_Accounts_lst_account_type("update_account_category_details");
                MessageBox.Show("Succefully updated account category details", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountCategoryList();
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtAccountName.Text == string.Empty || txtAccountNumber.Text == string.Empty || cboActive.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Please fill in all required values marked with a star(*)", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                save();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDataEntry.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void Clear()
        {
            txtAccountName.Clear();
            txtAccountNumber.Clear();
            cboActive.SelectedValue = Globals.EmptySelection;
            lblID.Text = Globals.EmptyID;
            pnlDataEntry.Enabled = true;
            cboAccountReport.SelectedValue = Globals.EmptySelection;
        }

        private void gdvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gdvList.Rows.Count > 0)
            {
                lblID.Text = gdvList.CurrentRow.Cells[0].Value.ToString();
                txtAccountName.Text = gdvList.CurrentRow.Cells[2].Value.ToString();
                txtAccountNumber.Text = gdvList.CurrentRow.Cells[1].Value.ToString();
                cboActive.Text = gdvList.CurrentRow.Cells[3].Value.ToString();
                cboAccountReport.Text = gdvList.CurrentRow.Cells[4].Value.ToString();
                pnlDataEntry.Enabled = false;
            }
        }
    }
}
