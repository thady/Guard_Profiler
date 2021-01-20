namespace Guard_profiler
{
    partial class nssf_payroll_temp_paymentPeriodSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nssf_payroll_temp_paymentPeriodSelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsetupPayroll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPaymentMonth = new System.Windows.Forms.ComboBox();
            this.cboPaymentYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsetupPayroll);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboPaymentMonth);
            this.panel1.Controls.Add(this.cboPaymentYear);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 247);
            this.panel1.TabIndex = 0;
            // 
            // btnsetupPayroll
            // 
            this.btnsetupPayroll.ForeColor = System.Drawing.Color.Blue;
            this.btnsetupPayroll.Location = new System.Drawing.Point(109, 179);
            this.btnsetupPayroll.Name = "btnsetupPayroll";
            this.btnsetupPayroll.Size = new System.Drawing.Size(225, 30);
            this.btnsetupPayroll.TabIndex = 57;
            this.btnsetupPayroll.Text = "Proceed to payroll setup";
            this.btnsetupPayroll.UseVisualStyleBackColor = true;
            this.btnsetupPayroll.Click += new System.EventHandler(this.btnsetupPayroll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Payment Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
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
            this.cboPaymentMonth.Location = new System.Drawing.Point(14, 121);
            this.cboPaymentMonth.Margin = new System.Windows.Forms.Padding(5);
            this.cboPaymentMonth.Name = "cboPaymentMonth";
            this.cboPaymentMonth.Size = new System.Drawing.Size(320, 26);
            this.cboPaymentMonth.TabIndex = 54;
            // 
            // cboPaymentYear
            // 
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
            this.cboPaymentYear.Location = new System.Drawing.Point(9, 53);
            this.cboPaymentYear.Margin = new System.Windows.Forms.Padding(5);
            this.cboPaymentYear.Name = "cboPaymentYear";
            this.cboPaymentYear.Size = new System.Drawing.Size(325, 26);
            this.cboPaymentYear.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a payment period";
            // 
            // nssf_payroll_temp_paymentPeriodSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nssf_payroll_temp_paymentPeriodSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select payment period";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentMonth;
        private System.Windows.Forms.ComboBox cboPaymentYear;
        private System.Windows.Forms.Button btnsetupPayroll;
    }
}