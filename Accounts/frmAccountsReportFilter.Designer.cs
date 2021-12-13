
namespace Accounts
{
    partial class frmAccountsReportFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsReportFilter));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAgedDebtorsReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnAgedDebtorsReport);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.btnInvoice);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(961, 669);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAgedDebtorsReport
            // 
            this.btnAgedDebtorsReport.Location = new System.Drawing.Point(274, 9);
            this.btnAgedDebtorsReport.Name = "btnAgedDebtorsReport";
            this.btnAgedDebtorsReport.Size = new System.Drawing.Size(259, 63);
            this.btnAgedDebtorsReport.TabIndex = 2;
            this.btnAgedDebtorsReport.Text = "Aged Debtors Reports";
            this.btnAgedDebtorsReport.UseVisualStyleBackColor = true;
            this.btnAgedDebtorsReport.Click += new System.EventHandler(this.btnAgedDebtorsReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Receipt Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(9, 9);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(259, 63);
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "Invoice Reports";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmAccountsReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 674);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountsReportFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Name";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgedDebtorsReport;
    }
}