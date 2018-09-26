using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Guard_profiler.App_code;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_employment_record_report : Form
	{
		private IContainer components;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalReportViewer employment_report_reportviewer;

		public frm_employment_record_report()
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

		private void frm_employment_record_report_Load(object sender, EventArgs e)
		{
			this.Load_Report();
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employment_record_report));
            this.employment_report_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.SuspendLayout();
            // 
            // employment_report_reportviewer
            // 
            this.employment_report_reportviewer.ActiveViewIndex = -1;
            this.employment_report_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employment_report_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.employment_report_reportviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employment_report_reportviewer.Location = new System.Drawing.Point(0, 0);
            this.employment_report_reportviewer.Name = "employment_report_reportviewer";
            this.employment_report_reportviewer.Size = new System.Drawing.Size(857, 565);
            this.employment_report_reportviewer.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 565D;
            this.reSize1.InitialHostContainerWidth = 857D;
            this.reSize1.Tag = null;
            // 
            // frm_employment_record_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 565);
            this.Controls.Add(this.employment_report_reportviewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_employment_record_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUARD EMPLOYMENT RECORD REPORT";
            this.Load += new System.EventHandler(this.frm_employment_record_report_Load);
            this.ResumeLayout(false);

		}

		protected void Load_Report()
		{
			base.WindowState = FormWindowState.Maximized;
			guard_employment_record_report report = new guard_employment_record_report();
			ParameterFields paramFields = new ParameterFields();
			ParameterField parameterField = new ParameterField();
			ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
			foreach (Table tbCurrent in report.Database.Tables)
			{
				Set_Report_logons.SetTableLogin(tbCurrent);
			}
			report.SetParameterValue("QueryName", "SELECT_GUARD_EMPLOYMENT_RECORD_REPORT");
			report.SetParameterValue("guard_number", SystemConst.guard_number);
            this.employment_report_reportviewer.ParameterFieldInfo = paramFields;
            this.employment_report_reportviewer.ReportSource = report;
		}
	}
}