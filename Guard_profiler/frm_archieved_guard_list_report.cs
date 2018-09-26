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
	public class frm_archieved_guard_list_report : Form
	{
		private IContainer components;

		private Panel panel1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalReportViewer cr_viewer_archieved_guards_report;

		//private ReSize reSize1;

		public frm_archieved_guard_list_report()
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

		private void frm_archieved_guard_list_report_Load(object sender, EventArgs e)
		{
			string _guard_status = SystemConst._guard_status;
			if (_guard_status == string.Empty)
			{

                base.WindowState = FormWindowState.Maximized;
                cr_archived_guard_lists report = new cr_archived_guard_lists();
                ParameterFields paramFields = new ParameterFields();
                ParameterField parameterField1 = new ParameterField();
                ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
                foreach (Table tbCurrent in report.Database.Tables)
                {
                    Set_Report_logons.SetTableLogin(tbCurrent);
                }
                report.SetDataSource(Archieve_Lists.SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS("SELECT_ARCHIEVED_GUARD_LIST_ALL", _guard_status));
                report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_LIST_ALL");
                report.SetParameterValue("guard_status", SystemConst._guard_status);
                this.cr_viewer_archieved_guards_report.ParameterFieldInfo = paramFields;
                this.cr_viewer_archieved_guards_report.ReportSource = report;
            }
			else
			{
				try
				{
					base.WindowState = FormWindowState.Maximized;
					cr_archived_guard_lists report = new cr_archived_guard_lists();
					ParameterFields paramFields = new ParameterFields();
					ParameterField parameterField1 = new ParameterField();
					ParameterDiscreteValue parameterDiscreteValue1 = new ParameterDiscreteValue();
					foreach (Table tbCurrent in report.Database.Tables)
					{
						Set_Report_logons.SetTableLogin(tbCurrent);
					}
					report.SetDataSource(Archieve_Lists.SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS("SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS", _guard_status));
					report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS");
					report.SetParameterValue("guard_status", SystemConst._guard_status);
                    this.cr_viewer_archieved_guards_report.ParameterFieldInfo = paramFields;
                    this.cr_viewer_archieved_guards_report.ReportSource = report;
				}
				catch (Exception exception)
				{
					throw exception;
				}
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_archieved_guard_list_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_viewer_archieved_guards_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cr_viewer_archieved_guards_report);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 587);
            this.panel1.TabIndex = 0;
            // 
            // cr_viewer_archieved_guards_report
            // 
            this.cr_viewer_archieved_guards_report.ActiveViewIndex = -1;
            this.cr_viewer_archieved_guards_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_viewer_archieved_guards_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_viewer_archieved_guards_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_viewer_archieved_guards_report.Location = new System.Drawing.Point(0, 0);
            this.cr_viewer_archieved_guards_report.Name = "cr_viewer_archieved_guards_report";
            this.cr_viewer_archieved_guards_report.Size = new System.Drawing.Size(852, 587);
            this.cr_viewer_archieved_guards_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 589D;
            this.reSize1.InitialHostContainerWidth = 856D;
            this.reSize1.Tag = null;
            // 
            // frm_archieved_guard_list_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(856, 589);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_archieved_guard_list_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archieved Guards Reports";
            this.Load += new System.EventHandler(this.frm_archieved_guard_list_report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}