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
	public class frmcrystal_report_single : Form
	{
		private IContainer components;

		private CrystalReportViewer crystalReportViewer1;

		public frmcrystal_report_single()
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

		private void frmcrystal_report_single_Load(object sender, EventArgs e)
		{
            if (SystemConst._Single_report_type == "Active")
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                guard_single_report report = new guard_single_report();

                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                    Set_Report_logons.SetTableLogin(tbCurrent);

                report.SetDataSource(sg_Reports.RETURN_OFFICER_DETAILS("", SystemConst.guard_number));
                report.SetParameterValue("QueryName", "SELECT_GUARD_REPORT_SINGLE");
                report.SetParameterValue("guard_number", SystemConst.guard_number);
                report.SetParameterValue("guard_status", String.Empty);
                crystalReportViewer1.ParameterFieldInfo = paramFields;


                this.crystalReportViewer1.ReportSource = report;
                //this.crystalReportViewer1.RefreshReport();
            }
            else if (SystemConst._Single_report_type == "Archieve")
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                guard_single_report report = new guard_single_report();

                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                    Set_Report_logons.SetTableLogin(tbCurrent);

                report.SetDataSource(sg_Reports.RETURN_OFFICER_DETAILS("", SystemConst.guard_number));
                report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_REPORT_SINGLE");
                report.SetParameterValue("guard_number", SystemConst.guard_number);
                report.SetParameterValue("guard_status", String.Empty);
                crystalReportViewer1.ParameterFieldInfo = paramFields;


                this.crystalReportViewer1.ReportSource = report;
                //this.crystalReportViewer1.RefreshReport();
            }
        }

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frmcrystal_report_single));
			this.crystalReportViewer1 = new CrystalReportViewer();
			base.SuspendLayout();
			//this.crystalReportViewer1.set_ActiveViewIndex(-1);
			this.crystalReportViewer1.BorderStyle = BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = Cursors.Default;
			this.crystalReportViewer1.Dock = DockStyle.Fill;
			this.crystalReportViewer1.Location = new Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.Size = new System.Drawing.Size(828, 578);
			this.crystalReportViewer1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(828, 578);
			base.Controls.Add(this.crystalReportViewer1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmcrystal_report_single";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "NEW SECURIKO UGANDA LTD-GUARD PROFILE REPORT";
			base.Load += new EventHandler(this.frmcrystal_report_single_Load);
			base.ResumeLayout(false);
		}

        protected void SET_CONNECTION_INFO(ConnectionInfo conn_info)
        {
            TableLogOnInfos my_info = new TableLogOnInfos();
            my_info = crystalReportViewer1.LogOnInfo;
            foreach (TableLogOnInfo myInfo in my_info)
            {
                myInfo.ConnectionInfo = conn_info;
            }
        }
    }
}