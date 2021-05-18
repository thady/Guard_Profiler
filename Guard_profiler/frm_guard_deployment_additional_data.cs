using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;


namespace Guard_profiler
{
	public class frm_guard_deployment_additional_data : Form
	{
		private IContainer components;

		private Panel panel1;

		private DateTimePicker dt_end_date;

		private Label label4;

		private Label label6;

		private DateTimePicker dt_start_date;

		private Panel panel2;

		//private ReSize reSize1;

		private DataGridView gdv_guards;

		private Label label9;

		private Panel panel3;

		private ComboBox cbo_branch;

		private Label label1;

		private TextBox txt_guard_number;

		private Button btn_search;

		private Button btn_save;

		private Label label3;
        private ReSize reSize1;
        private ComboBox cbo_deploy_period;
        private Panel panel4;
        private Label lblAccountsHeader;
        private BackgroundWorker bgWorkerImport;
        private Button button1;

		public frm_guard_deployment_additional_data()
		{
			this.InitializeComponent();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
            if (gdv_guards.Rows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("This might take a while.Proceed?", " Message Centre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < gdv_guards.Rows.Count; i++)
                    {
                        int guard_auto_id = Convert.ToInt32(gdv_guards.Rows[i].Cells[1].Value.ToString());
                        DateTime pay_month = dt_start_date.Value.Date;
                        string guard_number = gdv_guards.Rows[i].Cells[2].Value.ToString();
                        int days_worked = gdv_guards.Rows[i].Cells[4].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[4].Value.ToString()) : 0;
                        int over_time_days_worked = gdv_guards.Rows[i].Cells[5].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[5].Value.ToString()) : 0;
                        int days_absent = gdv_guards.Rows[i].Cells[7].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[7].Value.ToString()) : 0;
                        float total_advance_in_month = gdv_guards.Rows[i].Cells[8].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[8].Value.ToString()) : 0;
                        float total_arrears_in_month = gdv_guards.Rows[i].Cells[9].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[9].Value.ToString()) : 0;
                        float special_cash_additions = gdv_guards.Rows[i].Cells[10].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[10].Value.ToString()) : 0;
                        float residential_cost = gdv_guards.Rows[i].Cells[11].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[11].Value.ToString()) : 0;
                        float uniform_costs = gdv_guards.Rows[i].Cells[12].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[12].Value.ToString()) : 0;
                        float local_service_tax_cost = gdv_guards.Rows[i].Cells[13].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[13].Value.ToString()) : 0;
                        float other_penalties_cost = gdv_guards.Rows[i].Cells[14].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[14].Value.ToString()) : 0;
                        float other_refunds = gdv_guards.Rows[i].Cells[15].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[15].Value.ToString()) : 0;

                        //save row records
                        Guard_deployment.Save_update_guard_additional_deployment_data("save_update_guard_additional_deployment_data", guard_number, pay_month, guard_auto_id, days_worked, over_time_days_worked, days_absent, total_advance_in_month,
                        total_arrears_in_month, special_cash_additions, residential_cost, uniform_costs, local_service_tax_cost, other_penalties_cost, other_refunds, Convert.ToInt32(SystemConst._active_deployment_id));
                    }

                    MessageBox.Show("All records saved successfully", "Message Centre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_search_Click(btn_search, null);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No records available to save", "Message Centre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

		private void btn_search_Click(object sender, EventArgs e)
		{
            Get_guard_list();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			SystemConst._finance_report_type = "Deployment summary report";
			(new frm_finance_reports_parameter_selector()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_guard_deployment_additional_data_Load(object sender, EventArgs e)
		{

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
            if (SystemConst._active_deployment_id == string.Empty && SystemConst._user_department == "Wages")
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
           
            //dt = Guard_deployment.select_list_of_guards_for_additional_deployment_data_entry("select_list_of_guards_for_additional_deployment_data_entry", text, str, date, value.Date, SystemConst._user_id);
            dt = Guard_deployment.select_list_of_guards_for_additional_deployment_data_entry(text, str, date, value.Date, SystemConst._user_id);
            MessageBox.Show(dt.Rows.Count.ToString() + " Records Found");

            if (dt.Rows.Count <= 0)
			{
				this.gdv_guards.DataSource = null;
				return;
			}
			this.gdv_guards.DataSource = dt;

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

		private void gvAppSummary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_deployment_additional_data));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccountsHeader = new System.Windows.Forms.Label();
            this.cbo_deploy_period = new System.Windows.Forms.ComboBox();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.bgWorkerImport = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblAccountsHeader);
            this.panel1.Controls.Add(this.cbo_deploy_period);
            this.panel1.Controls.Add(this.dt_end_date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_start_date);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblAccountsHeader
            // 
            this.lblAccountsHeader.AutoSize = true;
            this.lblAccountsHeader.BackColor = System.Drawing.Color.Black;
            this.lblAccountsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountsHeader.Location = new System.Drawing.Point(609, 11);
            this.lblAccountsHeader.Name = "lblAccountsHeader";
            this.lblAccountsHeader.Size = new System.Drawing.Size(118, 16);
            this.lblAccountsHeader.TabIndex = 30;
            this.lblAccountsHeader.Text = "Payment Period";
            // 
            // cbo_deploy_period
            // 
            this.cbo_deploy_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deploy_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_deploy_period.FormattingEnabled = true;
            this.cbo_deploy_period.Location = new System.Drawing.Point(777, 1);
            this.cbo_deploy_period.Name = "cbo_deploy_period";
            this.cbo_deploy_period.Size = new System.Drawing.Size(401, 33);
            this.cbo_deploy_period.TabIndex = 29;
            this.cbo_deploy_period.SelectionChangeCommitted += new System.EventHandler(this.cbo_deploy_period_SelectionChangeCommitted);
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(395, 6);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(208, 21);
            this.dt_end_date.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "For the period of:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start_date.Location = new System.Drawing.Point(135, 6);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(208, 21);
            this.dt_start_date.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(670, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter additional guard deployment data here for a given deployment period.Use the" +
    " search option to narrow down list";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdv_guards);
            this.panel2.Location = new System.Drawing.Point(2, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 443);
            this.panel2.TabIndex = 1;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToOrderColumns = true;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(3, 1);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.Size = new System.Drawing.Size(1175, 439);
            this.gdv_guards.TabIndex = 0;
            this.gdv_guards.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gdv_guards_EditingControlShowing);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Select a station";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_guard_number);
            this.panel3.Controls.Add(this.cbo_branch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(2, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 29);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1005, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Deployment summary report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Coral;
            this.btn_save.Location = new System.Drawing.Point(838, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save Batch Record";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.Location = new System.Drawing.Point(733, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 23);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Guard Number";
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(427, 5);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(300, 21);
            this.txt_guard_number.TabIndex = 24;
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(99, 2);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(227, 23);
            this.cbo_branch.TabIndex = 15;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 551D;
            this.reSize1.InitialHostContainerWidth = 1185D;
            this.reSize1.Tag = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 30);
            this.panel4.TabIndex = 3;
            // 
            // frm_guard_deployment_additional_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1185, 551);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_guard_deployment_additional_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional guard deployment details";
            this.Load += new System.EventHandler(this.frm_guard_deployment_additional_data_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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


        delegate void SetProgressBarMaxCallback(int value);

    }
}