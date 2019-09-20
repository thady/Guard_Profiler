using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class _frm_guard_deployment_additional_data : Form
    {
        public _frm_guard_deployment_additional_data()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            //Add code to process your data
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(10); //Simulator
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Get_guard_list();
        }

        private void _frm_guard_deployment_additional_data_Load(object sender, EventArgs e)
        {
            lblLoad.Visible = false;
            pgBar.Visible = false;

            this.GET_BRANCHES();
            base.WindowState = FormWindowState.Maximized;
            return_deployment_periods();
            setDeploymentPeriod();
            setWagesAccessRights();
        }

        protected void setWagesAccessRights()
        {
            if (!SystemConst.is_admin)
            {
                if (SystemConst._user_department == "Accounts")
                {
                    cbo_deploy_period.Visible = true;
                    cbo_deploy_period.Enabled = true;
                    lblAccountsHeader.Visible = true;
                }
                else
                {
                    cbo_deploy_period.Visible = false;
                    cbo_deploy_period.Enabled = false;
                    lblAccountsHeader.Visible = false;
                }
            }
            else
            {
                cbo_deploy_period.Visible = true;
                cbo_deploy_period.Enabled = true;
                lblAccountsHeader.Visible = true;
            }
        }

        protected void return_deployment_periods()
        {
            DataTable dt = Guard_deployment.Return_list_of_deployment_periods("return_list_of_deployment_periods_for_accounts_reports_selector");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["deploy_id"] = -1;
                dtRow["period"] = string.Empty;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_deploy_period.DisplayMember = "period";
                this.cbo_deploy_period.ValueMember = "deploy_id";
                this.cbo_deploy_period.DataSource = dt;
            }
        }

        protected void setDeploymentPeriod()
        {
            if (SystemConst._active_deployment_id == string.Empty)
            {
                MessageBox.Show("You havent set any deployment period yet.You will not be able to deploy any guards if you haven't set a deployment period.You can do this from your active deployments panel.", "Message Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_save.Enabled = false;
                btn_search.Enabled = false;
            }
            else
            {

                this.dt_start_date.Value = SystemConst._deployment_start_date;
                this.dt_end_date.Value = SystemConst._deployment_end_date;

                btn_save.Enabled = true;
                btn_search.Enabled = true;
            }
        }

        private void gvAppSummary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void gdv_guards_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.gdv_guards.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 10)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 11)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 12)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 13)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 14)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
                return;
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 15)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
            }
            if (this.gdv_guards.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += new KeyPressEventHandler(this.gvAppSummary_KeyPress);
            }
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = string.Empty;
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_branch.DataSource = dt;
                this.cbo_branch.DisplayMember = "branch";
                this.cbo_branch.ValueMember = "branch_code";
            }
        }

        protected void Get_guard_list()
        {
            Thread.Sleep(500);
            DataTable dt = new DataTable();

            if (this.cbo_branch.Text == string.Empty)
            {
                MessageBox.Show("Select a branch to search", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (SystemConst._user_department == "Accounts" && cbo_deploy_period.Text == string.Empty)
            {
                MessageBox.Show("Please select a payment period to proceed with search", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string text = this.cbo_branch.Text;
            string str = this.txt_guard_number.Text;
            DateTime date = this.dt_start_date.Value.Date;
            DateTime value = this.dt_end_date.Value;

            if (SystemConst._user_department == "Accounts")
            {
                lblLoad.Visible = true;
                pgBar.Visible = true;
                //dt = Guard_deployment.select_list_of_guards_for_additional_deployment_data_entry("select_list_of_guards_for_additional_deployment_data_entry_accounts", text, str, Guard_deployment.deploy_start_date, Guard_deployment.deploy_end_date, SystemConst._user_id);
            }
            else
            {
                lblLoad.Visible = true;
                pgBar.Visible = true;
                //dt = Guard_deployment.select_list_of_guards_for_additional_deployment_data_entry("select_list_of_guards_for_additional_deployment_data_entry", text, str, date, value.Date, SystemConst._user_id);
            }


            if (dt.Rows.Count <= 0)
            {
                this.gdv_guards.DataSource = null;
                return;
            }
            this.gdv_guards.DataSource = dt;
            lblLoad.Visible = true;
            pgBar.Visible = true;

            this.gdv_guards.Columns["auto_id"].Visible = false;
            this.gdv_guards.Columns["payment_month"].Visible = false;
            this.gdv_guards.Columns["branch"].ReadOnly = true;
            this.gdv_guards.Columns["guard_number"].ReadOnly = true;
            this.gdv_guards.Columns["days_worked"].ReadOnly = true;
            //this.gdv_guards.Columns["overtime"].ReadOnly = true;
            this.gdv_guards.Columns["days_absent"].ReadOnly = true;
            this.gdv_guards.Columns["full_name"].ReadOnly = true;
            this.gdv_guards.Columns["guard_number"].HeaderText = "Guard No.";
            this.gdv_guards.Columns["full_name"].HeaderText = "Name";
            this.gdv_guards.Columns["branch"].HeaderText = "Branch";
            this.gdv_guards.Columns["days_worked"].HeaderText = "Days";
            this.gdv_guards.Columns["overtime"].HeaderText = "Ovt";
            this.gdv_guards.Columns["days_absent"].HeaderText = "Absent";
            this.gdv_guards.Columns["total_advance_in_month"].HeaderText = "Advance";
            this.gdv_guards.Columns["total_arrears_in_month"].HeaderText = "Arrears";
            this.gdv_guards.Columns["special_cash_additions"].HeaderText = "Special";
            this.gdv_guards.Columns["residential_cost"].HeaderText = "Residential";
            this.gdv_guards.Columns["uniform_costs"].HeaderText = "Uniform";
            this.gdv_guards.Columns["local_service_tax_cost"].HeaderText = "LST";
            this.gdv_guards.Columns["other_penalties_cost"].HeaderText = "Penalty";
            this.gdv_guards.Columns["other_refunds"].HeaderText = "Refund";
            this.gdv_guards.Columns["full_name"].Width = 250;
            this.gdv_guards.Columns["guard_number"].Width = 120;
            this.gdv_guards.Columns["residential_cost"].Width = 100;

            if (!SystemConst.is_admin)
            {
                if (SystemConst._user_department == "Accounts")
                {
                    this.gdv_guards.Columns["overtime"].Visible = true;
                    this.gdv_guards.Columns["total_advance_in_month"].Visible = true;
                    this.gdv_guards.Columns["total_arrears_in_month"].Visible = true;
                    this.gdv_guards.Columns["special_cash_additions"].Visible = true;
                    this.gdv_guards.Columns["residential_cost"].Visible = true;
                    this.gdv_guards.Columns["uniform_costs"].Visible = true;
                    this.gdv_guards.Columns["local_service_tax_cost"].Visible = true;
                    this.gdv_guards.Columns["other_penalties_cost"].Visible = true;
                    this.gdv_guards.Columns["other_refunds"].Visible = true;
                }
                else
                {
                    this.gdv_guards.Columns["overtime"].Visible = false;
                    this.gdv_guards.Columns["total_advance_in_month"].Visible = false;
                    this.gdv_guards.Columns["total_arrears_in_month"].Visible = false;
                    this.gdv_guards.Columns["special_cash_additions"].Visible = false;
                    this.gdv_guards.Columns["residential_cost"].Visible = false;
                    this.gdv_guards.Columns["uniform_costs"].Visible = false;
                    this.gdv_guards.Columns["local_service_tax_cost"].Visible = false;
                    this.gdv_guards.Columns["other_penalties_cost"].Visible = false;
                    this.gdv_guards.Columns["other_refunds"].Visible = false;
                }
            }
            else
            {
                this.gdv_guards.Columns["overtime"].Visible = true;
                this.gdv_guards.Columns["days_absent"].Visible = true;
                this.gdv_guards.Columns["total_advance_in_month"].Visible = true;
                this.gdv_guards.Columns["total_arrears_in_month"].Visible = true;
                this.gdv_guards.Columns["special_cash_additions"].Visible = true;
                this.gdv_guards.Columns["residential_cost"].Visible = true;
                this.gdv_guards.Columns["uniform_costs"].Visible = true;
                this.gdv_guards.Columns["local_service_tax_cost"].Visible = true;
                this.gdv_guards.Columns["other_penalties_cost"].Visible = true;
                this.gdv_guards.Columns["other_refunds"].Visible = true;
            }

            this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.gdv_guards.BorderStyle = BorderStyle.FixedSingle;

            foreach (DataGridViewColumn c in this.gdv_guards.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
            }
            this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdv_guards.EnableHeadersVisualStyles = false;
        }

        private void cbo_deploy_period_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cbo_deploy_period.Text != string.Empty)
            {
                Guard_deployment.select_deployment_date_by_deploy_id("select_deployment_date_by_deploy_id", Convert.ToInt32(cbo_deploy_period.SelectedValue.ToString()));
            }
        }

        private void bgWorkerImport_DoWork(object sender, DoWorkEventArgs e)
        {
            Get_guard_list();
        }

        private void bgWorkerImport_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBar.Value = e.ProgressPercentage;
            pgBar.Text = e.ProgressPercentage.ToString();
        }

        delegate void SetProgressBarMaxCallback(int value);
        private void SetProgressBarMaxValue(int value)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.pgBar.InvokeRequired)
            {
                SetProgressBarMaxCallback d = new SetProgressBarMaxCallback(SetProgressBarMaxValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                pgBar.Maximum = value;
            }


        }
    }
}
