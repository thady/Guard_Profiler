using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Guard_profiler.App_code;
//using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Data;

namespace Guard_profiler
{
	public class frm_finance_detailed_guard_pay_roll_report : Form
	{
		private IContainer components;

		private Panel panel1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;

        //private ReSize reSize1;

        private CrystalReportViewer cr_finance_detailed_guard_pay_roll_report;

		public frm_finance_detailed_guard_pay_roll_report()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

        protected void Set_current_deployment_periods()
        {
            DataTable dt = Guard_deployment.select_my_active_deployment_period("select_my_active_deployment_period", SystemConst._user_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];
                int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
                SystemConst._active_deployment_id = num.ToString();
                SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
                SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
            }
            else
            {
                SystemConst._active_deployment_id = string.Empty;
            }
        }

        private void frm_finance_detailed_guard_pay_roll_report_Load(object sender, EventArgs e)
		{
			if (SystemConst._finance_crystal_report_type == "DEPLOY" || SystemConst._finance_crystal_report_type == "CLIENT" || SystemConst._finance_crystal_report_type == "GUARD")
			{
                this.Text = SystemConst.ClientName +  "-Deployment Reporting";
			}
			else
			{
				this.Text = SystemConst.ClientName +  "-Finance Reporting";
			}
            if (SystemConst._finance_crystal_report_type == "Detailed")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    finance_detailed_guard_pay_roll_report report = new finance_detailed_guard_pay_roll_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_guard_payroll_summary_details_by_station("select_guard_payroll_summary_details_by_station", Convert.ToInt32(SystemConst._active_deployment_id), SystemConst._station_code, SystemConst._station_name, SystemConst._guard_rank));
                    report.SetParameterValue("QueryName", "select_guard_payroll_summary_details_by_station");
                    report.SetParameterValue("guard_number", string.Empty);
                    report.SetParameterValue("station_code", SystemConst._station_code);
                    report.SetParameterValue("station_name", SystemConst._station_name);
                   
                    report.SetParameterValue("guard_rank", SystemConst._guard_rank);
                    report.SetParameterValue("rank_name", SystemConst._rank_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "bank_payment")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    finance_bank_salary_payment_report report = new finance_bank_salary_payment_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField1 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_bank_payment_report("select_bank_payment_report", SystemConst._station_name, Convert.ToInt32(SystemConst._payment_deployment_id)));
                    report.SetParameterValue("QueryName", "select_bank_payment_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._payment_deployment_id));
                    report.SetParameterValue("bank_branch", "STANBIC BANK-" +  SystemConst._bank_branch);
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "LST")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    finance_local_service_tax_report report = new finance_local_service_tax_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField2 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue2 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_local_service_tax_nssf_andpaye_report("select_local_service_tax_report", SystemConst._station_name, SystemConst._station_code, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_local_service_tax_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "NSSF")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    finance_employee_nssf_report report = new finance_employee_nssf_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField3 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue3 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_local_service_tax_nssf_andpaye_report("select_nssf_report", SystemConst._station_name, SystemConst._station_code, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_nssf_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("branch_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception3)
                {
                    MessageBox.Show(exception3.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "PAYE")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    finance_employee_paye_report report = new finance_employee_paye_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField4 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue4 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_local_service_tax_nssf_andpaye_report("select_paye_tax_report", SystemConst._station_name, SystemConst._station_code, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_paye_tax_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception4)
                {
                    MessageBox.Show(exception4.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "DEPLOY")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    cr_deployment_summary_report report = new cr_deployment_summary_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField5 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue5 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_local_service_tax_nssf_andpaye_report("select_deployment_summary_report", SystemConst._station_name, SystemConst._station_code, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_paye_tax_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception5)
                {
                    MessageBox.Show(exception5.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "CLIENT")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    cr_deployment_client_guard_mapping_report report = new cr_deployment_client_guard_mapping_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField6 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue6 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_client_guard_mapping_report("select_client_guard_mapping_report", SystemConst._client_code, SystemConst._deployment_start_date, SystemConst._deployment_end_date));
                    report.SetParameterValue("QueryName", "select_client_guard_mapping_report");
                    report.SetParameterValue("client_code", SystemConst._client_code);
                    report.SetParameterValue("deploy_date_from", SystemConst._deployment_start_date);
                    report.SetParameterValue("deploy_date_to", SystemConst._deployment_end_date);
                    report.SetParameterValue("date_from", SystemConst._deployment_start_date);
                    report.SetParameterValue("date_to", SystemConst._deployment_end_date);
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception6)
                {
                    MessageBox.Show(exception6.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "GUARD")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    cr_deployment_guard_client_mapping_report report = new cr_deployment_guard_client_mapping_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField7 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue7 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_guard_client_mapping_report("select_guard_client_mapping_report", SystemConst.guard_number, SystemConst._deployment_start_date, SystemConst._deployment_end_date));
                    report.SetParameterValue("QueryName", "select_guard_client_mapping_report");
                    report.SetParameterValue("guard_number", SystemConst.guard_number);
                    report.SetParameterValue("deploy_date_from", SystemConst._deployment_start_date);
                    report.SetParameterValue("deploy_date_to", SystemConst._deployment_end_date);
                    report.SetParameterValue("date_from", SystemConst._deployment_start_date);
                    report.SetParameterValue("date_to", SystemConst._deployment_end_date);
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception7)
                {
                    MessageBox.Show(exception7.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "DEPLOYMENT_SCHEDULE")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    cr_guard_deployment_schedule_report report = new cr_guard_deployment_schedule_report();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField7 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue7 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }
                    report.SetDataSource(Finance_Reports.select_guard_deployment_schedule_report("select_deployment_schedule_report_by_branch", SystemConst._station_name, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_deployment_schedule_report_by_branch");
                    report.SetParameterValue("branch_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception7)
                {
                    MessageBox.Show(exception7.ToString());
                }
            }
            else if (SystemConst._finance_crystal_report_type == "customer_bill")
            {
                try
                {
                    base.WindowState = FormWindowState.Maximized;
                    cr_client_billing report = new cr_client_billing();
                    ParameterFields paramFields = new ParameterFields();
                    ParameterField parameterField7 = new ParameterField();
                    ParameterDiscreteValue parameterDiscreteValue7 = new ParameterDiscreteValue();
                    foreach (Table tbCurrent in report.Database.Tables)
                    {
                        Set_Report_logons.SetTableLogin(tbCurrent);
                    }

                    report.SetDataSource(Finance_Reports.select_client_billing_report("select_client_billing_report", SystemConst._station_name, Convert.ToInt32(SystemConst._active_deployment_id)));
                    report.SetParameterValue("QueryName", "select_client_billing_report");
                    report.SetParameterValue("station_name", SystemConst._station_name);
                    report.SetParameterValue("deploy_period_id", Convert.ToInt32(SystemConst._active_deployment_id));
                    report.SetParameterValue("client_name", SystemConst.ClientName);
                    this.cr_finance_detailed_guard_pay_roll_report.ParameterFieldInfo = paramFields;
                    this.cr_finance_detailed_guard_pay_roll_report.ReportSource = report;

                    Set_current_deployment_periods();
                }
                catch (Exception exception7)
                {
                    MessageBox.Show(exception7.ToString());
                }
            }
        }

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_finance_detailed_guard_pay_roll_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_finance_detailed_guard_pay_roll_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cr_finance_detailed_guard_pay_roll_report);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 528);
            this.panel1.TabIndex = 0;
            // 
            // cr_finance_detailed_guard_pay_roll_report
            // 
            this.cr_finance_detailed_guard_pay_roll_report.ActiveViewIndex = -1;
            this.cr_finance_detailed_guard_pay_roll_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_finance_detailed_guard_pay_roll_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_finance_detailed_guard_pay_roll_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_finance_detailed_guard_pay_roll_report.Location = new System.Drawing.Point(0, 0);
            this.cr_finance_detailed_guard_pay_roll_report.Name = "cr_finance_detailed_guard_pay_roll_report";
            this.cr_finance_detailed_guard_pay_roll_report.Size = new System.Drawing.Size(822, 528);
            this.cr_finance_detailed_guard_pay_roll_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 532D;
            this.reSize1.InitialHostContainerWidth = 825D;
            this.reSize1.Tag = null;
            // 
            // frm_finance_detailed_guard_pay_roll_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(825, 532);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_finance_detailed_guard_pay_roll_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Reporting";
            this.Load += new System.EventHandler(this.frm_finance_detailed_guard_pay_roll_report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}