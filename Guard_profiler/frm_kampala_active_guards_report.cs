using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_kampala_active_guards_report : Form
	{
		private static string SQLConnection;

		private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(frm_kampala_active_guards_report.SQLConnection);

		private IContainer components;

		private Panel panel1;
        private ReSize reSize1;

        //private ReSize reSize1;

        private CrystalReportViewer cr_active_kampala_guards_report;

		static frm_kampala_active_guards_report()
		{
			frm_kampala_active_guards_report.SQLConnection = ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString();
		}

		public frm_kampala_active_guards_report()
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

		private void frm_kampala_active_guards_report_Load(object sender, EventArgs e)
		{
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            cr_kampala_report report = new cr_kampala_report();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                Set_Report_logons.SetTableLogin(tbCurrent);

            report.SetDataSource(sg_Reports.SELECT_ACTIVE_GUARDS_KAMPALA("", SystemConst._branch));
            //check if user selected kampala
            if (SystemConst._branch == "KAMPALA")
            {
                report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_KAMPALA_COMBINED");
                report.SetParameterValue("branch", SystemConst._branch);
                report.SetParameterValue("update_month", SystemConst._Report_update_month);
                cr_active_kampala_guards_report.ParameterFieldInfo = paramFields;


                this.cr_active_kampala_guards_report.ReportSource = report;
            }
            else
            {
                report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_KAMPALA");
                report.SetParameterValue("branch", SystemConst._branch);
                report.SetParameterValue("update_month", SystemConst._Report_update_month);
                cr_active_kampala_guards_report.ParameterFieldInfo = paramFields;


                this.cr_active_kampala_guards_report.ReportSource = report;

            }
        }

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kampala_active_guards_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_active_kampala_guards_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cr_active_kampala_guards_report);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 599);
            this.panel1.TabIndex = 0;
            // 
            // cr_active_kampala_guards_report
            // 
            this.cr_active_kampala_guards_report.ActiveViewIndex = -1;
            this.cr_active_kampala_guards_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_active_kampala_guards_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_active_kampala_guards_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_active_kampala_guards_report.Location = new System.Drawing.Point(0, 0);
            this.cr_active_kampala_guards_report.Name = "cr_active_kampala_guards_report";
            this.cr_active_kampala_guards_report.Size = new System.Drawing.Size(848, 599);
            this.cr_active_kampala_guards_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 602D;
            this.reSize1.InitialHostContainerWidth = 850D;
            this.reSize1.Tag = null;
            // 
            // frm_kampala_active_guards_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(850, 602);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_kampala_active_guards_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kampala Active Guards Report by Division";
            this.Load += new System.EventHandler(this.frm_kampala_active_guards_report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}