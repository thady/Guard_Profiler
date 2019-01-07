using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_finance_reports_parameter_selector : Form
	{
		private IContainer components;

		private Panel panel1;

		private Label label1;

		private Label label2;

		private ComboBox cbo_station;

		private ComboBox cbo_deploy_period;

		private CheckBox chk_current_period;

		private Button btn_execute;

		private Label label3;

		private Label lblreport_type;

		public frm_finance_reports_parameter_selector()
		{
			this.InitializeComponent();
		}

		private void btn_execute_Click(object sender, EventArgs e)
		{
			if (this.cbo_station.Text == string.Empty)
			{
				MessageBox.Show("Station cannot be blank", "Finance Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.lblreport_type.Text == "Detailed Payroll Report")
			{
				SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
				SystemConst._station_name = this.cbo_station.Text;
				SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
				SystemConst._finance_crystal_report_type = "Detailed";
				(new frm_finance_detailed_guard_pay_roll_report()).Show();
				return;
			}
			if (this.lblreport_type.Text == "Local Service Tax Report")
			{
				SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
				SystemConst._station_name = this.cbo_station.Text;
				SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
				SystemConst._finance_crystal_report_type = "LST";
				(new frm_finance_detailed_guard_pay_roll_report()).Show();
				return;
			}
			if (this.lblreport_type.Text == "NSSF Report")
			{
				SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
				SystemConst._station_name = this.cbo_station.Text;
				SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
				SystemConst._finance_crystal_report_type = "NSSF";
				(new frm_finance_detailed_guard_pay_roll_report()).Show();
				return;
			}
			if (this.lblreport_type.Text == "PAYE Report")
			{
				SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
				SystemConst._station_name = this.cbo_station.Text;
				SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
				SystemConst._finance_crystal_report_type = "PAYE";
				(new frm_finance_detailed_guard_pay_roll_report()).Show();
				return;
			}
			if (this.lblreport_type.Text == "Deployment summary report")
			{
				SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
				SystemConst._station_name = this.cbo_station.Text;
				SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
				SystemConst._finance_crystal_report_type = "DEPLOY";
				(new frm_finance_detailed_guard_pay_roll_report()).Show();
			}
            if (this.lblreport_type.Text == "Preview summary")
            {
               
                SystemConst._station_name = this.cbo_station.Text;
                SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();

                frm_guard_payroll_summary summ = new frm_guard_payroll_summary();
                summ.ShowDialog();
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

		private void frm_finance_reports_parameter_selector_Load(object sender, EventArgs e)
		{
			this.lblreport_type.Text = SystemConst._finance_report_type;
			this.GET_BRANCHES();
			this.return_deployment_periods();

            if (SystemConst._finance_report_type == "Preview summary")
            {
                btn_execute.Text = "Preview Payroll";
            }
		}

		protected void GET_BRANCHES()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -99;
				dtRow["branch"] = string.Empty;
				dtRow["active"] = true;
				dtRow["branch_code"] = string.Empty;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_station.DisplayMember = "branch";
				this.cbo_station.ValueMember = "branch_code";
				this.cbo_station.DataSource = dt;
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_finance_reports_parameter_selector));
			this.panel1 = new Panel();
			this.lblreport_type = new Label();
			this.label3 = new Label();
			this.btn_execute = new Button();
			this.chk_current_period = new CheckBox();
			this.cbo_deploy_period = new ComboBox();
			this.label2 = new Label();
			this.cbo_station = new ComboBox();
			this.label1 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.lblreport_type);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btn_execute);
			this.panel1.Controls.Add(this.chk_current_period);
			this.panel1.Controls.Add(this.cbo_deploy_period);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_station);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 220);
			this.panel1.TabIndex = 0;
			this.lblreport_type.AutoSize = true;
			this.lblreport_type.ForeColor = Color.Red;
			this.lblreport_type.Location = new Point(85, 6);
			this.lblreport_type.Name = "lblreport_type";
			this.lblreport_type.Size = new System.Drawing.Size(34, 13);
			this.lblreport_type.TabIndex = 7;
			this.lblreport_type.Text = "report";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(10, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Report Type:";
			this.btn_execute.Location = new Point(52, 123);
			this.btn_execute.Name = "btn_execute";
			this.btn_execute.Size = new System.Drawing.Size(163, 35);
			this.btn_execute.TabIndex = 5;
			this.btn_execute.Text = "Generate Report";
			this.btn_execute.UseVisualStyleBackColor = true;
			this.btn_execute.Click += new EventHandler(this.btn_execute_Click);
			this.chk_current_period.AutoSize = true;
			this.chk_current_period.Checked = true;
			this.chk_current_period.CheckState = CheckState.Checked;
			this.chk_current_period.Location = new Point(251, 96);
			this.chk_current_period.Name = "chk_current_period";
			this.chk_current_period.Size = new System.Drawing.Size(112, 30);
			this.chk_current_period.TabIndex = 4;
			this.chk_current_period.Text = "use current \r\ndeployment period";
			this.chk_current_period.UseVisualStyleBackColor = true;
			this.chk_current_period.CheckedChanged += new EventHandler(this.chk_current_period_CheckedChanged);
			this.cbo_deploy_period.FormattingEnabled = true;
			this.cbo_deploy_period.Location = new Point(10, 96);
			this.cbo_deploy_period.Name = "cbo_deploy_period";
			this.cbo_deploy_period.Size = new System.Drawing.Size(235, 21);
			this.cbo_deploy_period.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Yellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(7, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Select a deployment period";
			this.cbo_station.FormattingEnabled = true;
			this.cbo_station.Location = new Point(10, 53);
			this.cbo_station.Name = "cbo_station";
			this.cbo_station.Size = new System.Drawing.Size(235, 21);
			this.cbo_station.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Yellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(7, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select a station";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 192, 128);
			base.ClientSize = new System.Drawing.Size(381, 226);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_finance_reports_parameter_selector";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Select Branch & Deployment period";
			base.Load += new EventHandler(this.frm_finance_reports_parameter_selector_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
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