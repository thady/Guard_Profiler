namespace Guard_profiler
{
    partial class frm_staff_payroll_reports_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_staff_payroll_reports_dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpaye = new System.Windows.Forms.Button();
            this.btnNssf = new System.Windows.Forms.Button();
            this.btnlst = new System.Windows.Forms.Button();
            this.btnbank_payment_report = new System.Windows.Forms.Button();
            this.btn_detailed_reports = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 33);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF PAYROLL FINANCE REPORTS DASHBOARD";
            // 
            // btnpaye
            // 
            this.btnpaye.Location = new System.Drawing.Point(463, 97);
            this.btnpaye.Margin = new System.Windows.Forms.Padding(4);
            this.btnpaye.Name = "btnpaye";
            this.btnpaye.Size = new System.Drawing.Size(223, 47);
            this.btnpaye.TabIndex = 11;
            this.btnpaye.Text = "Employee Paye Report";
            this.btnpaye.UseVisualStyleBackColor = true;
            this.btnpaye.Click += new System.EventHandler(this.btnpaye_Click);
            // 
            // btnNssf
            // 
            this.btnNssf.Location = new System.Drawing.Point(232, 97);
            this.btnNssf.Margin = new System.Windows.Forms.Padding(4);
            this.btnNssf.Name = "btnNssf";
            this.btnNssf.Size = new System.Drawing.Size(223, 47);
            this.btnNssf.TabIndex = 10;
            this.btnNssf.Text = "Employee Nssf Report";
            this.btnNssf.UseVisualStyleBackColor = true;
            this.btnNssf.Click += new System.EventHandler(this.btnNssf_Click);
            // 
            // btnlst
            // 
            this.btnlst.Location = new System.Drawing.Point(2, 97);
            this.btnlst.Margin = new System.Windows.Forms.Padding(4);
            this.btnlst.Name = "btnlst";
            this.btnlst.Size = new System.Drawing.Size(223, 47);
            this.btnlst.TabIndex = 9;
            this.btnlst.Text = "Local Service Tax Reports";
            this.btnlst.UseVisualStyleBackColor = true;
            this.btnlst.Click += new System.EventHandler(this.btnlst_Click);
            // 
            // btnbank_payment_report
            // 
            this.btnbank_payment_report.Location = new System.Drawing.Point(232, 43);
            this.btnbank_payment_report.Margin = new System.Windows.Forms.Padding(4);
            this.btnbank_payment_report.Name = "btnbank_payment_report";
            this.btnbank_payment_report.Size = new System.Drawing.Size(223, 47);
            this.btnbank_payment_report.TabIndex = 8;
            this.btnbank_payment_report.Text = "Bankl Schedule Reports";
            this.btnbank_payment_report.UseVisualStyleBackColor = true;
            this.btnbank_payment_report.Click += new System.EventHandler(this.btnbank_payment_report_Click);
            // 
            // btn_detailed_reports
            // 
            this.btn_detailed_reports.Location = new System.Drawing.Point(2, 43);
            this.btn_detailed_reports.Margin = new System.Windows.Forms.Padding(4);
            this.btn_detailed_reports.Name = "btn_detailed_reports";
            this.btn_detailed_reports.Size = new System.Drawing.Size(223, 47);
            this.btn_detailed_reports.TabIndex = 7;
            this.btn_detailed_reports.Text = "Payroll Reports";
            this.btn_detailed_reports.UseVisualStyleBackColor = true;
            this.btn_detailed_reports.Click += new System.EventHandler(this.btn_detailed_reports_Click);
            // 
            // frm_staff_payroll_reports_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnpaye);
            this.Controls.Add(this.btnNssf);
            this.Controls.Add(this.btnlst);
            this.Controls.Add(this.btnbank_payment_report);
            this.Controls.Add(this.btn_detailed_reports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_staff_payroll_reports_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Payroll Reporting";
            this.Load += new System.EventHandler(this.frm_staff_payroll_reports_dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpaye;
        private System.Windows.Forms.Button btnNssf;
        private System.Windows.Forms.Button btnlst;
        private System.Windows.Forms.Button btnbank_payment_report;
        private System.Windows.Forms.Button btn_detailed_reports;
    }
}