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
        private Panel panelRanks;
        private Label label4;
        private ComboBox cboRank;
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
                SystemConst._guard_rank = this.cboRank.SelectedValue.ToString();
                SystemConst._rank_name = cboRank.SelectedValue.ToString() != string.Empty ? cboRank.Text : "All Ranks";
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

            if (this.lblreport_type.Text == "customer_bill")
            {
                SystemConst._station_code = this.cbo_station.SelectedValue.ToString();
                SystemConst._station_name = this.cbo_station.Text;
                SystemConst._active_deployment_id = this.cbo_deploy_period.SelectedValue.ToString();
                SystemConst._finance_crystal_report_type = "customer_bill";
                (new frm_finance_detailed_guard_pay_roll_report()).Show();
            }
        }

		private void chk_current_period_CheckedChanged(object sender, EventArgs e)
		{
			//if (!this.chk_current_period.Checked)
			//{
			//	this.cbo_deploy_period.Text = string.Empty;
			//	this.cbo_deploy_period.Enabled = true;
			//	return;
			//}
			//this.Set_current_deployment_periods();
			//this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
			//this.cbo_deploy_period.Enabled = false;
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
            GET_POSITIONS();

            if (SystemConst._finance_report_type == "Preview summary")
            {
                btn_execute.Text = "Preview Payroll";
            }

            if (SystemConst._finance_report_type == "Detailed Payroll Report")
            {
                panelRanks.Visible = true;
            }
            else
            {
                panelRanks.Visible = false;
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

        protected void GET_POSITIONS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_POSITIONS");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = string.Empty;
                dtRow["auto_id"] = -1;
                dtRow["position_code"] = string.Empty;
                dtRow["active"] = true;
                dt.Rows.InsertAt(dtRow, 0);
                this.cboRank.DataSource = dt;
                this.cboRank.ValueMember = "position_code";
                this.cboRank.DisplayMember = "position_name";
            }
        }

        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_finance_reports_parameter_selector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRanks = new System.Windows.Forms.Panel();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblreport_type = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.chk_current_period = new System.Windows.Forms.CheckBox();
            this.cbo_deploy_period = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_station = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelRanks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panelRanks);
            this.panel1.Controls.Add(this.lblreport_type);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_execute);
            this.panel1.Controls.Add(this.chk_current_period);
            this.panel1.Controls.Add(this.cbo_deploy_period);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_station);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 271);
            this.panel1.TabIndex = 0;
            // 
            // panelRanks
            // 
            this.panelRanks.Controls.Add(this.cboRank);
            this.panelRanks.Controls.Add(this.label4);
            this.panelRanks.Location = new System.Drawing.Point(16, 163);
            this.panelRanks.Name = "panelRanks";
            this.panelRanks.Size = new System.Drawing.Size(321, 73);
            this.panelRanks.TabIndex = 8;
            // 
            // cboRank
            // 
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Location = new System.Drawing.Point(8, 31);
            this.cboRank.Margin = new System.Windows.Forms.Padding(4);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(301, 33);
            this.cboRank.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guard Rank";
            // 
            // lblreport_type
            // 
            this.lblreport_type.AutoSize = true;
            this.lblreport_type.ForeColor = System.Drawing.Color.Red;
            this.lblreport_type.Location = new System.Drawing.Point(113, 7);
            this.lblreport_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreport_type.Name = "lblreport_type";
            this.lblreport_type.Size = new System.Drawing.Size(46, 17);
            this.lblreport_type.TabIndex = 7;
            this.lblreport_type.Text = "report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Report Type:";
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_execute.ForeColor = System.Drawing.Color.Blue;
            this.btn_execute.Location = new System.Drawing.Point(354, 224);
            this.btn_execute.Margin = new System.Windows.Forms.Padding(4);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(143, 43);
            this.btn_execute.TabIndex = 5;
            this.btn_execute.Text = "Generate Report";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // chk_current_period
            // 
            this.chk_current_period.AutoSize = true;
            this.chk_current_period.Enabled = false;
            this.chk_current_period.Location = new System.Drawing.Point(335, 118);
            this.chk_current_period.Margin = new System.Windows.Forms.Padding(4);
            this.chk_current_period.Name = "chk_current_period";
            this.chk_current_period.Size = new System.Drawing.Size(147, 38);
            this.chk_current_period.TabIndex = 4;
            this.chk_current_period.Text = "use current \r\ndeployment period";
            this.chk_current_period.UseVisualStyleBackColor = true;
            this.chk_current_period.CheckedChanged += new System.EventHandler(this.chk_current_period_CheckedChanged);
            // 
            // cbo_deploy_period
            // 
            this.cbo_deploy_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deploy_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_deploy_period.FormattingEnabled = true;
            this.cbo_deploy_period.Location = new System.Drawing.Point(13, 118);
            this.cbo_deploy_period.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_deploy_period.Name = "cbo_deploy_period";
            this.cbo_deploy_period.Size = new System.Drawing.Size(312, 33);
            this.cbo_deploy_period.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a deployment period";
            // 
            // cbo_station
            // 
            this.cbo_station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_station.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_station.FormattingEnabled = true;
            this.cbo_station.Location = new System.Drawing.Point(13, 57);
            this.cbo_station.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_station.Name = "cbo_station";
            this.cbo_station.Size = new System.Drawing.Size(312, 33);
            this.cbo_station.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a station";
            // 
            // frm_finance_reports_parameter_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(508, 278);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_finance_reports_parameter_selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Branch & Deployment period";
            this.Load += new System.EventHandler(this.frm_finance_reports_parameter_selector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRanks.ResumeLayout(false);
            this.panelRanks.PerformLayout();
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
				//this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
				//this.cbo_deploy_period.Enabled = false;
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