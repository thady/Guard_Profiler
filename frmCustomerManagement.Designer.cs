namespace Guard_profiler
{
    partial class frmCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBillingReport = new System.Windows.Forms.Button();
            this.btnCustomerProfiles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBillingReport);
            this.groupBox1.Controls.Add(this.btnCustomerProfiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Profiles";
            // 
            // btnBillingReport
            // 
            this.btnBillingReport.Location = new System.Drawing.Point(6, 71);
            this.btnBillingReport.Name = "btnBillingReport";
            this.btnBillingReport.Size = new System.Drawing.Size(193, 44);
            this.btnBillingReport.TabIndex = 1;
            this.btnBillingReport.Text = "Customer Billing Reports";
            this.btnBillingReport.UseVisualStyleBackColor = true;
            this.btnBillingReport.Click += new System.EventHandler(this.btnBillingReport_Click);
            // 
            // btnCustomerProfiles
            // 
            this.btnCustomerProfiles.Location = new System.Drawing.Point(6, 21);
            this.btnCustomerProfiles.Name = "btnCustomerProfiles";
            this.btnCustomerProfiles.Size = new System.Drawing.Size(193, 44);
            this.btnCustomerProfiles.TabIndex = 0;
            this.btnCustomerProfiles.Text = "Customer Profiles";
            this.btnCustomerProfiles.UseVisualStyleBackColor = true;
            this.btnCustomerProfiles.Click += new System.EventHandler(this.btnCustomerProfiles_Click);
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 378);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Uganda Securiko Ltd-Customer Management";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBillingReport;
        private System.Windows.Forms.Button btnCustomerProfiles;
    }
}