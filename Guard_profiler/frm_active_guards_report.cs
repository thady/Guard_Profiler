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

namespace Guard_profiler
{
	public class frm_active_guards_report : Form
	{
		private IContainer components;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;

        //private ReSize reSize1;

        private CrystalReportViewer cr_active_guards;

		public frm_active_guards_report()
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

		private void frm_active_guards_report_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			cr_active_guards_by_station report = new cr_active_guards_by_station();
			ParameterFields paramFields = new ParameterFields();
			ParameterField parameterField = new ParameterField();
			ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
			foreach (Table tbCurrent in report.Database.Tables)
			{
				Set_Report_logons.SetTableLogin(tbCurrent);
			}
			report.SetDataSource(sg_Reports.SELECT_ACTIVE_GUARDS_BY_STATION("", SystemConst._branch));
			report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_BY_STATION");
			report.SetParameterValue("branch", SystemConst._branch);
			report.SetParameterValue("update_month", SystemConst._Report_update_month);
            report.SetParameterValue("client_name", SystemConst.ClientName);
            this.cr_active_guards.ParameterFieldInfo = paramFields;
            this.cr_active_guards.ReportSource = report;
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_active_guards_report));
            this.cr_active_guards = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.SuspendLayout();
            // 
            // cr_active_guards
            // 
            this.cr_active_guards.ActiveViewIndex = -1;
            this.cr_active_guards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_active_guards.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_active_guards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_active_guards.Location = new System.Drawing.Point(0, 0);
            this.cr_active_guards.Name = "cr_active_guards";
            this.cr_active_guards.Size = new System.Drawing.Size(847, 528);
            this.cr_active_guards.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 528D;
            this.reSize1.InitialHostContainerWidth = 847D;
            this.reSize1.Tag = null;
            // 
            // frm_active_guards_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 528);
            this.Controls.Add(this.cr_active_guards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_active_guards_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Guards by Branch Report";
            this.Load += new System.EventHandler(this.frm_active_guards_report_Load);
            this.ResumeLayout(false);

		}
	}
}