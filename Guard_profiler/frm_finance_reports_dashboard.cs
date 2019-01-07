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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_finance_reports_dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_detailed_reports = new System.Windows.Forms.Button();
            this.btnbank_payment_report = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.btnNssf = new System.Windows.Forms.Button();
            this.btnpaye = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUARD PAYROLL FINANCE REPORTS DASHBOARD";
            // 
            // btn_detailed_reports
            // 
            this.btn_detailed_reports.Location = new System.Drawing.Point(3, 44);
            this.btn_detailed_reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_detailed_reports.Name = "btn_detailed_reports";
            this.btn_detailed_reports.Size = new System.Drawing.Size(223, 47);
            this.btn_detailed_reports.TabIndex = 1;
            this.btn_detailed_reports.Text = "Detailed Guard Payroll Report";
            this.btn_detailed_reports.UseVisualStyleBackColor = true;
            this.btn_detailed_reports.Click += new System.EventHandler(this.btn_detailed_reports_Click);
            // 
            // btnbank_payment_report
            // 
            this.btnbank_payment_report.Location = new System.Drawing.Point(233, 44);
            this.btnbank_payment_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbank_payment_report.Name = "btnbank_payment_report";
            this.btnbank_payment_report.Size = new System.Drawing.Size(223, 47);
            this.btnbank_payment_report.TabIndex = 2;
            this.btnbank_payment_report.Text = "Bank Salary Payment Sheet";
            this.btnbank_payment_report.UseVisualStyleBackColor = true;
            this.btnbank_payment_report.Click += new System.EventHandler(this.btnbank_payment_report_Click);
            // 
            // btnlst
            // 
            this.btnlst.Location = new System.Drawing.Point(3, 98);
            this.btnlst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(223, 47);
            this.btnlst.TabIndex = 3;
            this.btnlst.Text = "Local Service Tax Report";
            this.btnlst.UseVisualStyleBackColor = true;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // btnNssf
            // 
            this.btnNssf.Location = new System.Drawing.Point(233, 98);
            this.btnNssf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNssf.Name = "btnNssf";
            this.btnNssf.Size = new System.Drawing.Size(223, 47);
            this.btnNssf.TabIndex = 4;
            this.btnNssf.Text = "Employee Nssf Report";
            this.btnNssf.UseVisualStyleBackColor = true;
            this.btnNssf.Click += new System.EventHandler(this.btnNssf_Click);
            // 
            // btnpaye
            // 
            this.btnpaye.Location = new System.Drawing.Point(464, 98);
            this.btnpaye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpaye.Name = "btnpaye";
            this.btnpaye.Size = new System.Drawing.Size(223, 47);
            this.btnpaye.TabIndex = 5;
            this.btnpaye.Text = "Employee Paye Report";
            this.btnpaye.UseVisualStyleBackColor = true;
            this.btnpaye.Click += new System.EventHandler(this.btnpaye_Click);
            // 
            // frm_finance_reports_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 446);
            this.Controls.Add(this.btnpaye);
            this.Controls.Add(this.btnNssf);
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.btnbank_payment_report);
            this.Controls.Add(this.btn_detailed_reports);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_finance_reports_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_finance_reports_dashboard";
            this.Load += new System.EventHandler(this.frm_finance_reports_dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void frm_finance_reports_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}