using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_finance_reports_dashboard : Form
	{
		private IContainer components;

		private Panel panel1;

		private Button btn_detailed_reports;

		private Label label1;

		private Button btnbank_payment_report;

		private Button btnlst;

		private Button btnNssf;

		private Button btnpaye;

		public frm_finance_reports_dashboard()
		{
			this.InitializeComponent();
		}

		private void btn_detailed_reports_Click(object sender, EventArgs e)
		{
			SystemConst._finance_report_type = "Detailed Payroll Report";
			(new frm_finance_reports_parameter_selector()).ShowDialog();
		}

		private void btnbank_payment_report_Click(object sender, EventArgs e)
		{
            SystemConst.finance_report_type = string.Empty;
            SystemConst.finance_report_type = "bank_payment";
            (new frm_finance_bank_salary_payment_sheet_report_selector()).ShowDialog();
           
        }

		private void btnlst_Click(object sender, EventArgs e)
		{
			SystemConst._finance_report_type = "Local Service Tax Report";
			(new frm_finance_reports_parameter_selector()).ShowDialog();
		}

		private void btnNssf_Click(object sender, EventArgs e)
		{
			SystemConst._finance_report_type = "NSSF Report";
			(new frm_finance_reports_parameter_selector()).ShowDialog();
		}

		private void btnpaye_Click(object sender, EventArgs e)
		{
            SystemConst.finance_report_type = string.Empty;
            SystemConst.finance_report_type = "paye_payment";
            (new frm_finance_bank_salary_payment_sheet_report_selector()).ShowDialog();
            

           // SystemConst._finance_report_type = "PAYE Report";
			//(new frm_finance_reports_parameter_selector()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_finance_reports_dashboard));
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.btn_detailed_reports = new Button();
			this.btnbank_payment_report = new Button();
			this.btnlst = new Button();
			this.btnNssf = new Button();
			this.btnpaye = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = SystemColors.ActiveCaptionText;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 27);
			this.panel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(161, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "FINANCE REPORTS DASHBOARD";
			this.btn_detailed_reports.Location = new Point(2, 36);
			this.btn_detailed_reports.Name = "btn_detailed_reports";
			this.btn_detailed_reports.Size = new System.Drawing.Size(167, 38);
			this.btn_detailed_reports.TabIndex = 1;
			this.btn_detailed_reports.Text = "Detailed Guard Payroll Report";
			this.btn_detailed_reports.UseVisualStyleBackColor = true;
			this.btn_detailed_reports.Click += new EventHandler(this.btn_detailed_reports_Click);
			this.btnbank_payment_report.Location = new Point(175, 36);
			this.btnbank_payment_report.Name = "btnbank_payment_report";
			this.btnbank_payment_report.Size = new System.Drawing.Size(167, 38);
			this.btnbank_payment_report.TabIndex = 2;
			this.btnbank_payment_report.Text = "Bank Salary Payment Sheet";
			this.btnbank_payment_report.UseVisualStyleBackColor = true;
			this.btnbank_payment_report.Click += new EventHandler(this.btnbank_payment_report_Click);
			this.btnlst.Location = new Point(2, 80);
			this.btnlst.Name = "btnlst";
			this.btnlst.Size = new System.Drawing.Size(167, 38);
			this.btnlst.TabIndex = 3;
			this.btnlst.Text = "Local Service Tax Report";
			this.btnlst.UseVisualStyleBackColor = true;
			this.btnlst.Click += new EventHandler(this.btnlst_Click);
			this.btnNssf.Location = new Point(175, 80);
			this.btnNssf.Name = "btnNssf";
			this.btnNssf.Size = new System.Drawing.Size(167, 38);
			this.btnNssf.TabIndex = 4;
			this.btnNssf.Text = "Employee Nssf Report";
			this.btnNssf.UseVisualStyleBackColor = true;
			this.btnNssf.Click += new EventHandler(this.btnNssf_Click);
			this.btnpaye.Location = new Point(348, 80);
			this.btnpaye.Name = "btnpaye";
			this.btnpaye.Size = new System.Drawing.Size(167, 38);
			this.btnpaye.TabIndex = 5;
			this.btnpaye.Text = "Employee Paye Report";
			this.btnpaye.UseVisualStyleBackColor = true;
			this.btnpaye.Click += new EventHandler(this.btnpaye_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(554, 362);
			base.Controls.Add(this.btnpaye);
			base.Controls.Add(this.btnNssf);
			base.Controls.Add(this.btnlst);
			base.Controls.Add(this.btnbank_payment_report);
			base.Controls.Add(this.btn_detailed_reports);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_finance_reports_dashboard";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "frm_finance_reports_dashboard";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}