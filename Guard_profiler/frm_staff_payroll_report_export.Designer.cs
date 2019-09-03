namespace Guard_profiler
{
    partial class frm_staff_payroll_report_export
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_staff_payroll_report_export));
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.cr_finance_detailed_guard_pay_roll_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 655D;
            this.reSize1.InitialHostContainerWidth = 1100D;
            this.reSize1.Tag = null;
            // 
            // cr_finance_detailed_guard_pay_roll_report
            // 
            this.cr_finance_detailed_guard_pay_roll_report.ActiveViewIndex = -1;
            this.cr_finance_detailed_guard_pay_roll_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_finance_detailed_guard_pay_roll_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_finance_detailed_guard_pay_roll_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_finance_detailed_guard_pay_roll_report.Location = new System.Drawing.Point(0, 0);
            this.cr_finance_detailed_guard_pay_roll_report.Margin = new System.Windows.Forms.Padding(4);
            this.cr_finance_detailed_guard_pay_roll_report.Name = "cr_finance_detailed_guard_pay_roll_report";
            this.cr_finance_detailed_guard_pay_roll_report.Size = new System.Drawing.Size(1096, 650);
            this.cr_finance_detailed_guard_pay_roll_report.TabIndex = 0;
            this.cr_finance_detailed_guard_pay_roll_report.ToolPanelWidth = 267;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cr_finance_detailed_guard_pay_roll_report);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 650);
            this.panel1.TabIndex = 1;
            // 
            // frm_staff_payroll_report_export
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1100, 655);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_staff_payroll_report_export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Reporting";
            this.Load += new System.EventHandler(this.frm_staff_payroll_report_export_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_finance_detailed_guard_pay_roll_report;
    }
}