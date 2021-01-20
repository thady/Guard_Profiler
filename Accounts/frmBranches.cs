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
using AccountsBackEnd;

namespace Accounts
{
    public partial class frmBranches : Form
    {
        public frmBranches()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (this.txt_branch_name.Text == string.Empty)
            {
                MessageBox.Show("Branch name required");
                return;
            }
            if (lblID.Text == Globals.EmptyID)
            {
                Branches.save_branch("save_branch",Guid.NewGuid().ToString(), this.txt_branch_name.Text, (this.chk_branch_active.Checked ? true : false), this.txt_branch_code.Text);
                MessageBox.Show("Successfully saved branch details");
                this.GET_BRANCHES();
                return;
            }
            Branches.save_branch("update_branch",lblID.Text, this.txt_branch_name.Text, (this.chk_branch_active.Checked ? true : false), this.txt_branch_code.Text);
            MessageBox.Show("Successfully updated branch details");
            this.GET_BRANCHES();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = Branches.LoadLookup("select_branch_list");
            if (dt != null)
            {
                this.gdv_branches.DataSource = dt;
                this.gdv_branches.Columns[0].Visible = false;
                this.gdv_branches.Columns[1].Visible = false;
                this.gdv_branches.Columns[2].HeaderText = "Branch Name";
                this.gdv_branches.Columns[3].HeaderText = "Branch Active?";
                this.gdv_branches.Columns[4].HeaderText = "Branch Code";
                this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
                this.gdv_branches.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_branches.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_branches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_branches.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_branches.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void gdv_branches_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gdv_branches.Rows.Count != 0)
            {
                this.txt_branch_id.Text = this.gdv_branches.CurrentRow.Cells[1].Value.ToString();
                this.txt_branch_name.Text = this.gdv_branches.CurrentRow.Cells[2].Value.ToString();
                this.txt_branch_code.Text = this.gdv_branches.CurrentRow.Cells[4].Value.ToString();
                this.chk_branch_active.Checked = (bool)this.gdv_branches.CurrentRow.Cells[3].Value;
                lblID.Text = this.gdv_branches.CurrentRow.Cells[0].Value.ToString();
                this.pnlEntry.Enabled = false;
            }
        }

        private void frmBranches_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            pnlEntry.Enabled = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txt_branch_id.Clear();
            this.txt_branch_name.Clear();
            this.txt_branch_code.Clear();
            this.chk_branch_active.Checked = false;
            lblID.Text = Globals.EmptyID;
            pnlEntry.Enabled = true;
        }
    }
}
