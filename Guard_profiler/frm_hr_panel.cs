using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_hr_panel : Form
	{
		private IContainer components;

		private Panel panel1;

		private Button btn_guard_profiles;

		private Button btn_emp_records;

		private Button btn_transfer_guards;

		private Button btn_archived_guards;

		private ToolStripMenuItem activeGuardsByBranchReportsToolStripMenuItem;

		private ToolStripMenuItem kampalaGuardsReportsToolStripMenuItem;

		private ToolStripMenuItem allGuardsReportToolStripMenuItem;

		private ToolStripMenuItem toolStripMenuItem1;

		private ToolStripMenuItem archivedGuardsReportsToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private Button btn_non_guard_profiles;

		public frm_hr_panel()
		{
			this.InitializeComponent();
		}

		private void activeGuardsByBranchReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_guard_lists()).ShowDialog();
		}

		private void allGuardsReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_sg_list_report()).ShowDialog();
		}

		private void archivedGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_archieve_lists()).ShowDialog();
		}

		private void btn_archived_guards_Click(object sender, EventArgs e)
		{
			(new frm_archieved_guards()).Show();
		}

		private void btn_emp_records_Click(object sender, EventArgs e)
		{
			(new frm_employment_record()).Show();
		}

		private void btn_guard_profiles_Click(object sender, EventArgs e)
		{
			(new sg_profiles()).Show();
		}

		private void btn_transfer_guards_Click(object sender, EventArgs e)
		{
			(new frm_transfer_guards()).Show();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hr_panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_non_guard_profiles = new System.Windows.Forms.Button();
            this.btn_archived_guards = new System.Windows.Forms.Button();
            this.btn_transfer_guards = new System.Windows.Forms.Button();
            this.btn_emp_records = new System.Windows.Forms.Button();
            this.btn_guard_profiles = new System.Windows.Forms.Button();
            this.activeGuardsByBranchReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampalaGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allGuardsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_non_guard_profiles);
            this.panel1.Controls.Add(this.btn_archived_guards);
            this.panel1.Controls.Add(this.btn_transfer_guards);
            this.panel1.Controls.Add(this.btn_emp_records);
            this.panel1.Controls.Add(this.btn_guard_profiles);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 281);
            this.panel1.TabIndex = 0;
            // 
            // btn_non_guard_profiles
            // 
            this.btn_non_guard_profiles.Location = new System.Drawing.Point(206, 14);
            this.btn_non_guard_profiles.Name = "btn_non_guard_profiles";
            this.btn_non_guard_profiles.Size = new System.Drawing.Size(190, 52);
            this.btn_non_guard_profiles.TabIndex = 4;
            this.btn_non_guard_profiles.Text = "Non-Guard Profiles";
            this.btn_non_guard_profiles.UseVisualStyleBackColor = true;
            // 
            // btn_archived_guards
            // 
            this.btn_archived_guards.Location = new System.Drawing.Point(10, 188);
            this.btn_archived_guards.Name = "btn_archived_guards";
            this.btn_archived_guards.Size = new System.Drawing.Size(190, 52);
            this.btn_archived_guards.TabIndex = 3;
            this.btn_archived_guards.Text = "View Arhived Guards(Guard History)";
            this.btn_archived_guards.UseVisualStyleBackColor = true;
            this.btn_archived_guards.Click += new System.EventHandler(this.btn_archived_guards_Click);
            // 
            // btn_transfer_guards
            // 
            this.btn_transfer_guards.Location = new System.Drawing.Point(10, 130);
            this.btn_transfer_guards.Name = "btn_transfer_guards";
            this.btn_transfer_guards.Size = new System.Drawing.Size(190, 52);
            this.btn_transfer_guards.TabIndex = 2;
            this.btn_transfer_guards.Text = "Transfer Guards";
            this.btn_transfer_guards.UseVisualStyleBackColor = true;
            this.btn_transfer_guards.Click += new System.EventHandler(this.btn_transfer_guards_Click);
            // 
            // btn_emp_records
            // 
            this.btn_emp_records.Location = new System.Drawing.Point(10, 72);
            this.btn_emp_records.Name = "btn_emp_records";
            this.btn_emp_records.Size = new System.Drawing.Size(190, 52);
            this.btn_emp_records.TabIndex = 1;
            this.btn_emp_records.Text = "Manage Guard Employment Records";
            this.btn_emp_records.UseVisualStyleBackColor = true;
            this.btn_emp_records.Click += new System.EventHandler(this.btn_emp_records_Click);
            // 
            // btn_guard_profiles
            // 
            this.btn_guard_profiles.Location = new System.Drawing.Point(10, 14);
            this.btn_guard_profiles.Name = "btn_guard_profiles";
            this.btn_guard_profiles.Size = new System.Drawing.Size(190, 52);
            this.btn_guard_profiles.TabIndex = 0;
            this.btn_guard_profiles.Text = "Manage Guard Profiles";
            this.btn_guard_profiles.UseVisualStyleBackColor = true;
            this.btn_guard_profiles.Click += new System.EventHandler(this.btn_guard_profiles_Click);
            // 
            // activeGuardsByBranchReportsToolStripMenuItem
            // 
            this.activeGuardsByBranchReportsToolStripMenuItem.Name = "activeGuardsByBranchReportsToolStripMenuItem";
            this.activeGuardsByBranchReportsToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.activeGuardsByBranchReportsToolStripMenuItem.Text = "Active Guards by branch Reports";
            this.activeGuardsByBranchReportsToolStripMenuItem.Click += new System.EventHandler(this.activeGuardsByBranchReportsToolStripMenuItem_Click);
            // 
            // kampalaGuardsReportsToolStripMenuItem
            // 
            this.kampalaGuardsReportsToolStripMenuItem.Name = "kampalaGuardsReportsToolStripMenuItem";
            this.kampalaGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.kampalaGuardsReportsToolStripMenuItem.Text = "Kampala Guards Reports";
            this.kampalaGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.kampalaGuardsReportsToolStripMenuItem_Click);
            // 
            // allGuardsReportToolStripMenuItem
            // 
            this.allGuardsReportToolStripMenuItem.Name = "allGuardsReportToolStripMenuItem";
            this.allGuardsReportToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.allGuardsReportToolStripMenuItem.Text = "All Guards Report";
            this.allGuardsReportToolStripMenuItem.Click += new System.EventHandler(this.allGuardsReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // archivedGuardsReportsToolStripMenuItem
            // 
            this.archivedGuardsReportsToolStripMenuItem.Name = "archivedGuardsReportsToolStripMenuItem";
            this.archivedGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.archivedGuardsReportsToolStripMenuItem.Text = "Archived Guards Reports";
            this.archivedGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.archivedGuardsReportsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 20);
            this.toolStripMenuItem2.Text = "Active Guards by branch Reports";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 20);
            this.toolStripMenuItem3.Text = "Kampala Guards Reports";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem4.Text = "All Guards Report";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 20);
            this.toolStripMenuItem6.Text = "Archived Guards Reports";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // frm_hr_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(631, 309);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_hr_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Control Dashboard";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void kampalaGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_kampal_guards_filter()).ShowDialog();
		}

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_guard_lists lists = new frm_guard_lists();
            lists.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_kampal_guards_filter kamp = new frm_kampal_guards_filter();
            kamp.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_sg_list_report report = new frm_sg_list_report();
            report.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_archieve_lists archieve = new frm_archieve_lists();
            archieve.ShowDialog();
        }
    }
}