using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_deployment_reports_ : Form
	{
		private IContainer components;

		private Button btnguard_clientreport;

		private Button btnclientreport;

		private Button btnreport;

		public frm_deployment_reports_()
		{
			this.InitializeComponent();
		}

		private void btnclientreport_Click(object sender, EventArgs e)
		{
			(new frm_clients_guards_mapping_report_selector()).ShowDialog();
		}

		private void btnguard_clientreport_Click(object sender, EventArgs e)
		{
			(new frm_deployment_guard_client_mapping_report_selector()).ShowDialog();
		}

		private void btnreport_Click(object sender, EventArgs e)
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

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_deployment_reports_));
			this.btnguard_clientreport = new Button();
			this.btnclientreport = new Button();
			this.btnreport = new Button();
			base.SuspendLayout();
			this.btnguard_clientreport.ForeColor = Color.Blue;
			this.btnguard_clientreport.Location = new Point(2, 100);
			this.btnguard_clientreport.Name = "btnguard_clientreport";
			this.btnguard_clientreport.Size = new System.Drawing.Size(239, 45);
			this.btnguard_clientreport.TabIndex = 17;
			this.btnguard_clientreport.Text = "Guard-Client Mapping Report";
			this.btnguard_clientreport.UseVisualStyleBackColor = true;
			this.btnguard_clientreport.Click += new EventHandler(this.btnguard_clientreport_Click);
			this.btnclientreport.ForeColor = Color.FromArgb(255, 128, 0);
			this.btnclientreport.Location = new Point(2, 49);
			this.btnclientreport.Name = "btnclientreport";
			this.btnclientreport.Size = new System.Drawing.Size(239, 45);
			this.btnclientreport.TabIndex = 16;
			this.btnclientreport.Text = "Client - Guard Mapping Report";
			this.btnclientreport.UseVisualStyleBackColor = true;
			this.btnclientreport.Click += new EventHandler(this.btnclientreport_Click);
			this.btnreport.ForeColor = Color.Blue;
			this.btnreport.Location = new Point(2, 2);
			this.btnreport.Name = "btnreport";
			this.btnreport.Size = new System.Drawing.Size(239, 45);
			this.btnreport.TabIndex = 15;
			this.btnreport.Text = "Deployment summary report";
			this.btnreport.UseVisualStyleBackColor = true;
			this.btnreport.Click += new EventHandler(this.btnreport_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Azure;
			base.ClientSize = new System.Drawing.Size(246, 147);
			base.Controls.Add(this.btnguard_clientreport);
			base.Controls.Add(this.btnclientreport);
			base.Controls.Add(this.btnreport);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frm_deployment_reports_";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Quick Reports";
			base.ResumeLayout(false);
		}
	}
}