namespace Guard_profiler
{
    partial class frm_guard_payroll_summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_payroll_summary));
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.gdv_staff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 697D;
            this.reSize1.InitialHostContainerWidth = 1075D;
            this.reSize1.Tag = null;
            // 
            // gdv_staff
            // 
            this.gdv_staff.AllowUserToAddRows = false;
            this.gdv_staff.AllowUserToDeleteRows = false;
            this.gdv_staff.AllowUserToResizeColumns = false;
            this.gdv_staff.AllowUserToResizeRows = false;
            this.gdv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdv_staff.Location = new System.Drawing.Point(7, 20);
            this.gdv_staff.Margin = new System.Windows.Forms.Padding(4);
            this.gdv_staff.Name = "gdv_staff";
            this.gdv_staff.ReadOnly = true;
            this.gdv_staff.Size = new System.Drawing.Size(1043, 652);
            this.gdv_staff.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdv_staff);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 682);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guard Payroll Summary";
            // 
            // frm_guard_payroll_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 697);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_guard_payroll_summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Reporting-View Payroll Summary";
            this.Load += new System.EventHandler(this.frm_guard_payroll_summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdv_staff;
    }
}