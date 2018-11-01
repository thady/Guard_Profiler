using Guard_profiler.App_code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_finance_bank_salary_payment_sheet_report_selector : Form
	{
		private static DataTable dt_stations;

		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private CheckedListBox chklist_branches;

		private Label label1;

		private Label label2;

		private ComboBox cbo_deploy_period;

		private CheckBox chk_current_period;

		private Button btnextract;

		private Label label3;

		private Label label4;

		private ComboBox cbo_bank_name;
        private Label lblreportType;
        private ComboBox cbo_bank_branch;

		static frm_finance_bank_salary_payment_sheet_report_selector()
		{
		}

		public frm_finance_bank_salary_payment_sheet_report_selector()
		{
			this.InitializeComponent();
		}

		private void btnextract_Click(object sender, EventArgs e)
		{
            
            if (SystemConst.finance_report_type == "bank_payment")
            {
                
                if (!(this.cbo_bank_branch.Text == string.Empty) && !(this.cbo_bank_name.Text == string.Empty) && !(this.cbo_deploy_period.Text == string.Empty))
                {
                    this.generate_report();
                    return;
                }
                MessageBox.Show("All values are required", "Generate report", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (SystemConst.finance_report_type == "paye_payment")
            {
                this.generate_report();
                return;
            }
			
		}

		private void cbo_bank_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_bank_name.SelectedValue.ToString() != "-1")
			{
				this.get_bank_branches(Convert.ToInt32(this.cbo_bank_name.SelectedValue.ToString()));
			}
		}

		private void chk_current_period_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.chk_current_period.Checked)
			{
				this.cbo_deploy_period.Text = string.Empty;
				this.cbo_deploy_period.Enabled = true;
				return;
			}
			this.Set_current_deployment_periods();
			this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
			this.cbo_deploy_period.Enabled = false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_finance_bank_salary_payment_sheet_report_selector_Load(object sender, EventArgs e)
		{
			this.GET_BRANCHES();
			this.get_bank_list();
			this.return_deployment_periods();
            lblreportType.Text = string.Empty;
            lblreportType.Text = SystemConst.finance_report_type;
            if (SystemConst.finance_report_type == "paye_payment")
            {
                cbo_bank_branch.Enabled = false;
                cbo_bank_name.Enabled = false;
            }
            else
            {
                cbo_bank_branch.Enabled = true;
                cbo_bank_name.Enabled = true;
            }

        }

		protected void generate_report()
		{
			string station_name = string.Empty;
			StringBuilder stringBuilder = new StringBuilder();
			string branch_list = string.Empty;
			List<string> station_list = new List<string>();
			if (frm_finance_bank_salary_payment_sheet_report_selector.dt_stations.Rows.Count > 0)
			{
				for (int i = 0; i < frm_finance_bank_salary_payment_sheet_report_selector.dt_stations.Rows.Count; i++)
				{
					DataRow dtRow_station = frm_finance_bank_salary_payment_sheet_report_selector.dt_stations.Rows[i];
					station_name = dtRow_station["branch"].ToString();
					if (this.chklist_branches.CheckedItems.Contains(station_name))
					{
						station_list.Add(station_name);
					}
				}
				branch_list = string.Join(",", station_list.ToArray());
				char[] chrArray = new char[] { ',' };
				string.Join(",", (
					from x in branch_list.Split(chrArray)
					select string.Format("'{0}'", x)).ToList<string>());
                #region Report by bank or paye
                if (SystemConst.finance_report_type == "bank_payment")
                {
                    SystemConst._station_name = branch_list;
                    SystemConst._finance_crystal_report_type = "bank_payment";
                    SystemConst._bank_branch = this.cbo_bank_branch.Text;
                    (new frm_finance_detailed_guard_pay_roll_report()).Show();
                }
                else if (SystemConst.finance_report_type == "paye_payment")
                {
                    SystemConst._station_code = branch_list;
                    SystemConst._station_name = branch_list;
                    SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
                    SystemConst._finance_crystal_report_type = "PAYE";
                    (new frm_finance_detailed_guard_pay_roll_report()).Show();
                    return;
                }
                #endregion
               
			}
		}

		protected void get_bank_branches(int bank_id)
		{
			DataTable dt = Salary_scales.get_bank_branches("get_bank_branches", bank_id);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["branch_id"] = -1;
				dtRow["bank_id"] = -1;
				dtRow["branch_name"] = string.Empty;
				dtRow["branch_active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_bank_branch.DisplayMember = "branch_name";
				this.cbo_bank_branch.ValueMember = "branch_id";
				this.cbo_bank_branch.DataSource = dt;
			}
		}

		protected void get_bank_list()
		{
			DataTable dt = Salary_scales.return_bank_lists("return_bank_lists");
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_id"] = -1;
				dtRow["bank_code"] = string.Empty;
				dtRow["bank_name"] = string.Empty;
				dtRow["bank_active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_bank_name.DisplayMember = "bank_name";
				this.cbo_bank_name.ValueMember = "record_id";
				this.cbo_bank_name.DataSource = dt;
			}
		}

		protected void GET_BRANCHES()
		{
			frm_finance_bank_salary_payment_sheet_report_selector.dt_stations = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
			if (frm_finance_bank_salary_payment_sheet_report_selector.dt_stations != null)
			{
				for (int i = 0; i < frm_finance_bank_salary_payment_sheet_report_selector.dt_stations.Rows.Count; i++)
				{
					this.chklist_branches.Items.Add(frm_finance_bank_salary_payment_sheet_report_selector.dt_stations.Rows[i]["branch"].ToString());
				}
			}
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_finance_bank_salary_payment_sheet_report_selector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_bank_branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_bank_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnextract = new System.Windows.Forms.Button();
            this.chk_current_period = new System.Windows.Forms.CheckBox();
            this.cbo_deploy_period = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chklist_branches = new System.Windows.Forms.CheckedListBox();
            this.lblreportType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lblreportType);
            this.panel1.Controls.Add(this.cbo_bank_branch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo_bank_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnextract);
            this.panel1.Controls.Add(this.chk_current_period);
            this.panel1.Controls.Add(this.cbo_deploy_period);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 437);
            this.panel1.TabIndex = 0;
            // 
            // cbo_bank_branch
            // 
            this.cbo_bank_branch.FormattingEnabled = true;
            this.cbo_bank_branch.Location = new System.Drawing.Point(292, 265);
            this.cbo_bank_branch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_bank_branch.Name = "cbo_bank_branch";
            this.cbo_bank_branch.Size = new System.Drawing.Size(184, 24);
            this.cbo_bank_branch.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bank Branch";
            // 
            // cbo_bank_name
            // 
            this.cbo_bank_name.FormattingEnabled = true;
            this.cbo_bank_name.Location = new System.Drawing.Point(292, 213);
            this.cbo_bank_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_bank_name.Name = "cbo_bank_name";
            this.cbo_bank_name.Size = new System.Drawing.Size(184, 24);
            this.cbo_bank_name.TabIndex = 8;
            this.cbo_bank_name.SelectedIndexChanged += new System.EventHandler(this.cbo_bank_name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bank Name";
            // 
            // btnextract
            // 
            this.btnextract.Location = new System.Drawing.Point(347, 298);
            this.btnextract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnextract.Name = "btnextract";
            this.btnextract.Size = new System.Drawing.Size(131, 56);
            this.btnextract.TabIndex = 6;
            this.btnextract.Text = "Generate Report";
            this.btnextract.UseVisualStyleBackColor = true;
            this.btnextract.Click += new System.EventHandler(this.btnextract_Click);
            // 
            // chk_current_period
            // 
            this.chk_current_period.AutoSize = true;
            this.chk_current_period.Checked = true;
            this.chk_current_period.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_current_period.Location = new System.Drawing.Point(485, 144);
            this.chk_current_period.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_current_period.Name = "chk_current_period";
            this.chk_current_period.Size = new System.Drawing.Size(147, 38);
            this.chk_current_period.TabIndex = 5;
            this.chk_current_period.Text = "use current \r\ndeployment period";
            this.chk_current_period.UseVisualStyleBackColor = true;
            this.chk_current_period.CheckedChanged += new System.EventHandler(this.chk_current_period_CheckedChanged);
            // 
            // cbo_deploy_period
            // 
            this.cbo_deploy_period.FormattingEnabled = true;
            this.cbo_deploy_period.Location = new System.Drawing.Point(292, 150);
            this.cbo_deploy_period.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_deploy_period.Name = "cbo_deploy_period";
            this.cbo_deploy_period.Size = new System.Drawing.Size(184, 24);
            this.cbo_deploy_period.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Stations for your report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.chklist_branches);
            this.panel2.Location = new System.Drawing.Point(13, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 402);
            this.panel2.TabIndex = 0;
            // 
            // chklist_branches
            // 
            this.chklist_branches.FormattingEnabled = true;
            this.chklist_branches.Location = new System.Drawing.Point(4, 4);
            this.chklist_branches.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklist_branches.Name = "chklist_branches";
            this.chklist_branches.Size = new System.Drawing.Size(257, 378);
            this.chklist_branches.TabIndex = 1;
            // 
            // lblreportType
            // 
            this.lblreportType.AutoSize = true;
            this.lblreportType.Location = new System.Drawing.Point(315, 17);
            this.lblreportType.Name = "lblreportType";
            this.lblreportType.Size = new System.Drawing.Size(92, 17);
            this.lblreportType.TabIndex = 11;
            this.lblreportType.Text = "lblreportType";
            // 
            // frm_finance_bank_salary_payment_sheet_report_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(643, 443);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_finance_bank_salary_payment_sheet_report_selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Salary Payment Report";
            this.Load += new System.EventHandler(this.frm_finance_bank_salary_payment_sheet_report_selector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
				this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
				this.cbo_deploy_period.Enabled = false;
			}
		}

		protected void Set_current_deployment_periods()
		{
			DataTable dt = Guard_deployment.Select_active_deployment_period("select_active_deployment_period");
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.Rows[0];
				int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
				SystemConst._active_deployment_id = num.ToString();
				SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
				SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
			}
		}
	}
}