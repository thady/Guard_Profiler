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
	public class frm_officer_large_img_report : Form
	{
		private IContainer components;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalReportViewer cr_large_image_report;

		public frm_officer_large_img_report()
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

		private void frm_officer_large_img_report_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			cr_guard_large_img report = new cr_guard_large_img();
			ParameterFields paramFields = new ParameterFields();
			ParameterField parameterField = new ParameterField();
			ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
			foreach (Table tbCurrent in report.Database.Tables)
			{
				Set_Report_logons.SetTableLogin(tbCurrent);
			}
			report.SetDataSource(sg_Reports.SELECT_GUARD_LARGE_IMAGE_RPT("", SystemConst.guard_number));
			report.SetParameterValue("QueryName", "SELECT_GUARD_LARGE_IMAGE_RPT");
			report.SetParameterValue("guard_number", SystemConst.guard_number);
			this.cr_large_image_report.ParameterFieldInfo = paramFields;
            this.cr_large_image_report.ReportSource = report;
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_officer_large_img_report));
            this.cr_large_image_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.SuspendLayout();
            // 
            // cr_large_image_report
            // 
            this.cr_large_image_report.ActiveViewIndex = -1;
            this.cr_large_image_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_large_image_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_large_image_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_large_image_report.Location = new System.Drawing.Point(0, 0);
            this.cr_large_image_report.Name = "cr_large_image_report";
            this.cr_large_image_report.Size = new System.Drawing.Size(890, 607);
            this.cr_large_image_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 607D;
            this.reSize1.InitialHostContainerWidth = 890D;
            this.reSize1.Tag = null;
            // 
            // frm_officer_large_img_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 607);
            this.Controls.Add(this.cr_large_image_report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_officer_large_img_report";
            this.Text = "New Uganda Security Ltd- Export guard large photo";
            this.Load += new System.EventHandler(this.frm_officer_large_img_report_Load);
            this.ResumeLayout(false);

		}
	}
}