namespace Guard_profiler
{
    partial class frm_staff_payroll_summary_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_staff_payroll_summary_view));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdv_staff = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdv_staff);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 682);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Payroll Summary";
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
            // frm_staff_payroll_summary_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 697);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_staff_payroll_summary_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Reporting-View Payroll Summary";
            this.Load += new System.EventHandler(this.frm_staff_payroll_summary_view_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdv_staff;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}