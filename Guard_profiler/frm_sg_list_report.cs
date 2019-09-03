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
	public class frm_sg_list_report : Form
	{
		private IContainer components;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalReportViewer report_sg_lists;

		public frm_sg_list_report()
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

		private void frm_sg_list_report_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			cr_all_guards_list report = new cr_all_guards_list();
			ParameterFields paramFields = new ParameterFields();
			ParameterField parameterField = new ParameterField();
			ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
			foreach (Table tbCurrent in report.Database.Tables)
			{
				Set_Report_logons.SetTableLogin(tbCurrent);
			}
			report.SetDataSource(sg_Reports.SELECT_GUARD_LIST("SELECT_GUARD_LIST"));
			report.SetParameterValue("QueryName", "SELECT_GUARD_LIST");
            report.SetParameterValue("client_name",SystemConst.ClientName);
            this.report_sg_lists.ParameterFieldInfo = paramFields;
			this.report_sg_lists.ReportSource = report;
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sg_list_report));
            this.report_sg_lists = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.SuspendLayout();
            // 
            // report_sg_lists
            // 
            this.report_sg_lists.ActiveViewIndex = -1;
            this.report_sg_lists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report_sg_lists.Cursor = System.Windows.Forms.Cursors.Default;
            this.report_sg_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_sg_lists.Location = new System.Drawing.Point(0, 0);
            this.report_sg_lists.Name = "report_sg_lists";
            this.report_sg_lists.Size = new System.Drawing.Size(856, 545);
            this.report_sg_lists.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 545D;
            this.reSize1.InitialHostContainerWidth = 856D;
            this.reSize1.Tag = null;
            // 
            // frm_sg_list_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.report_sg_lists);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sg_list_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALL GUARDS REPORT";
            this.Load += new System.EventHandler(this.frm_sg_list_report_Load);
            this.ResumeLayout(false);

		}
	}
}