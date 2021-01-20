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
    public partial class frmSubLedgerCategory : Form
    {
        DataTable dt = new DataTable();
        public frmSubLedgerCategory()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        protected void save()
        {
            if(txt_name.Text.Trim() == string.Empty || txtCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill in all required missing values","Save",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                SubLedgerCategory.sub_ledger_category_name = txt_name.Text.Trim();
                SubLedgerCategory.sub_ledger_category_id = txtCode.Text.Trim();
                SubLedgerCategory.active = chkActive.Checked ? true : false;
                SubLedgerCategory.usr_date_create = DateTime.Now;
                SubLedgerCategory.usr_date_update = DateTime.Now;
                SubLedgerCategory.usr_id_create = SystemConst._user_id;
                SubLedgerCategory.usr_id_update = SystemConst._user_id;

                if (SubLedgerCategory.LoadRecord("select_sub_ledger_category_details", txtCode.Text.Trim()).Rows.Count > 0)
                {
                    SubLedgerCategory.save("update_sub_ledger_category");
                    MessageBox.Show("Succefully updated sub ledger category", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListing();
                }
                else
                {
                    SubLedgerCategory.save("save_sub_ledger_category");
                    MessageBox.Show("Succefully created sub ledger category", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListing();
                }
            }
        }

        protected void LoadListing()
        {
            dt = SubLedgerCategory.LoadRecord("select_sub_ledger_category_details", string.Empty);
            if (dt != null)
            {
                this.gdv_List.DataSource = dt;
                this.gdv_List.Columns["usr_id_create"].Visible = false;
                this.gdv_List.Columns["usr_id_update"].Visible = false;
                this.gdv_List.Columns["usr_date_create"].Visible = false;
                this.gdv_List.Columns["usr_date_update"].Visible = false;
                this.gdv_List.Columns["sub_ledger_category_id"].HeaderText = "SubLedger Category Code";
                this.gdv_List.Columns["sub_ledger_category_name"].HeaderText = "SubLedger Category Name";
                this.gdv_List.Columns["active"].HeaderText = "Active";
                this.gdv_List.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_List.DefaultCellStyle.SelectionForeColor = Color.Black;
                this.gdv_List.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_List.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_List.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_List.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_List.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_List.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void frmSubLedgerCategory_Load(object sender, EventArgs e)
        {
            LoadListing();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txt_name.Clear();
            chkActive.Checked = false;
            pnlEntry.Enabled = true;
        }

        private void gdv_List_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            pnlEntry.Enabled = true;
        }

        private void gdv_List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_List.Rows.Count > 0)
            {
                txtCode.Text = gdv_List.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = gdv_List.CurrentRow.Cells[1].Value.ToString();
                chkActive.Checked = Convert.ToBoolean(gdv_List.CurrentRow.Cells[2].Value);
                pnlEntry.Enabled = false;
            }
        }
    }
}
