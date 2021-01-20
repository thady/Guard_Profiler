namespace Guard_profiler
{
    partial class nssf_payroll_temp_report_selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nssf_payroll_temp_report_selector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.cbobranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPaymentMonth = new System.Windows.Forms.ComboBox();
            this.cboPaymentYear = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboReportType);
            this.panel1.Controls.Add(this.cbobranch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExportReport);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboPaymentMonth);
            this.panel1.Controls.Add(this.cboPaymentYear);
            this.panel1.Location = new System.Drawing.Point(5, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 230);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Select  report type";
            // 
            // cboReportType
            // 
            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReportType.FormattingEnabled = true;
            this.cboReportType.Items.AddRange(new object[] {
            "",
            "Payroll Report",
            "NSSF Contribution Report"});
            this.cboReportType.Location = new System.Drawing.Point(8, 27);
            this.cboReportType.Margin = new System.Windows.Forms.Padding(4);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Size = new System.Drawing.Size(245, 23);
            this.cboReportType.TabIndex = 60;
            // 
            // cbobranch
            // 
            this.cbobranch.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "JAN",
            "FEB",
            "MAR",
            "APRIL",
            "MAY",
            "JUNE",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cbobranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobranch.FormattingEnabled = true;
            this.cbobranch.Items.AddRange(new object[] {
            "",
            "JAN",
            "FEB",
            "MAR",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cbobranch.Location = new System.Drawing.Point(8, 162);
            this.cbobranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbobranch.Name = "cbobranch";
            this.cbobranch.Size = new System.Drawing.Size(241, 23);
            this.cbobranch.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Branch";
            // 
            // btnExportReport
            // 
            this.btnExportReport.ForeColor = System.Drawing.Color.Blue;
            this.btnExportReport.Location = new System.Drawing.Point(83, 194);
            this.btnExportReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(169, 24);
            this.btnExportReport.TabIndex = 57;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Payment Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Payment Year";
            // 
            // cboPaymentMonth
            // 
            this.cboPaymentMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "JAN",
            "FEB",
            "MAR",
            "APRIL",
            "MAY",
            "JUNE",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cboPaymentMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentMonth.FormattingEnabled = true;
            this.cboPaymentMonth.Items.AddRange(new object[] {
            "",
            "JAN",
            "FEB",
            "MAR",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cboPaymentMonth.Location = new System.Drawing.Point(8, 118);
            this.cboPaymentMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cboPaymentMonth.Name = "cboPaymentMonth";
            this.cboPaymentMonth.Size = new System.Drawing.Size(241, 23);
            this.cboPaymentMonth.TabIndex = 54;
            // 
            // cboPaymentYear
            // 
            this.cboPaymentYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentYear.FormattingEnabled = true;
            this.cboPaymentYear.Items.AddRange(new object[] {
            "",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2000"});
            this.cboPaymentYear.Location = new System.Drawing.Point(8, 73);
            this.cboPaymentYear.Margin = new System.Windows.Forms.Padding(4);
            this.cboPaymentYear.Name = "cboPaymentYear";
            this.cboPaymentYear.Size = new System.Drawing.Size(245, 23);
            this.cboPaymentYear.TabIndex = 53;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblHeader.Location = new System.Drawing.Point(5, 8);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(72, 13);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Export Report";
            // 
            // nssf_payroll_temp_report_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 255);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nssf_payroll_temp_report_selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Report";
            this.Load += new System.EventHandler(this.nssf_payroll_temp_report_selector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentMonth;
        private System.Windows.Forms.ComboBox cboPaymentYear;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbobranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReportType;
    }
}