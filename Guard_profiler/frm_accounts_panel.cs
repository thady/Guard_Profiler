using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_accounts_panel : Form
	{
		private IContainer components;

		private MenuStrip menuStrip1;

		private Panel panel1;

		private Label label1;

		private Splitter splitter1;

		private Label label2;

		private Button btn_manage_scales;

		private Button btn_assign_scales;

		private Button btn_auto_scale;

		private Splitter splitter2;

		private Label label3;

		private Button btn_payroll_setup;

		private Button button2;

		private Button btn_bank_account_details;

		private Button btn_banks;
        private Label label5;
        private Splitter splitter3;
        private Label label6;
        private Button btnstaff_profiles;
        private Button btn_staff_finance_reports;
        private Button btn_staff_payroll;
        private Button btnreports;

		public frm_accounts_panel()
		{
			this.InitializeComponent();
		}

		private void btn_assign_scales_Click(object sender, EventArgs e)
		{
			(new frm_assign_salary_scales_to_guards()).Show();
		}

		private void btn_bank_account_details_Click(object sender, EventArgs e)
		{
			(new frm_guard_bank_details()).ShowDialog();
		}

		private void btn_banks_Click(object sender, EventArgs e)
		{
			(new frm_bank_lookups()).ShowDialog();
		}

		private void btn_manage_scales_Click(object sender, EventArgs e)
		{
			(new frm_salary_scale_guards()).ShowDialog();
		}

		private void btn_payroll_setup_Click(object sender, EventArgs e)
		{
			(new frm_setup_payroll()).Show();
		}

		private void btnreports_Click(object sender, EventArgs e)
		{
			(new frm_finance_reports_dashboard()).ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new frm_guards_salary_scale_mapping_dashboard()).ShowDialog();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_accounts_panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_staff_payroll = new System.Windows.Forms.Button();
            this.btn_staff_finance_reports = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnstaff_profiles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnreports = new System.Windows.Forms.Button();
            this.btn_banks = new System.Windows.Forms.Button();
            this.btn_bank_account_details = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_payroll_setup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_auto_scale = new System.Windows.Forms.Button();
            this.btn_assign_scales = new System.Windows.Forms.Button();
            this.btn_manage_scales = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_staff_payroll);
            this.panel1.Controls.Add(this.btn_staff_finance_reports);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnstaff_profiles);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.btnreports);
            this.panel1.Controls.Add(this.btn_banks);
            this.panel1.Controls.Add(this.btn_bank_account_details);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_payroll_setup);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_auto_scale);
            this.panel1.Controls.Add(this.btn_assign_scales);
            this.panel1.Controls.Add(this.btn_manage_scales);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 449);
            this.panel1.TabIndex = 1;
            // 
            // btn_staff_payroll
            // 
            this.btn_staff_payroll.Location = new System.Drawing.Point(568, 85);
            this.btn_staff_payroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_staff_payroll.Name = "btn_staff_payroll";
            this.btn_staff_payroll.Size = new System.Drawing.Size(199, 50);
            this.btn_staff_payroll.TabIndex = 18;
            this.btn_staff_payroll.Text = "Staff Payroll Setup";
            this.btn_staff_payroll.UseVisualStyleBackColor = true;
            this.btn_staff_payroll.Click += new System.EventHandler(this.btn_staff_payroll_Click);
            // 
            // btn_staff_finance_reports
            // 
            this.btn_staff_finance_reports.Location = new System.Drawing.Point(785, 85);
            this.btn_staff_finance_reports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_staff_finance_reports.Name = "btn_staff_finance_reports";
            this.btn_staff_finance_reports.Size = new System.Drawing.Size(237, 50);
            this.btn_staff_finance_reports.TabIndex = 17;
            this.btn_staff_finance_reports.Text = "Staff Finance Reports";
            this.btn_staff_finance_reports.UseVisualStyleBackColor = true;
            this.btn_staff_finance_reports.Click += new System.EventHandler(this.btn_staff_finance_reports_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(787, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Finance Reports";
            // 
            // btnstaff_profiles
            // 
            this.btnstaff_profiles.Location = new System.Drawing.Point(568, 27);
            this.btnstaff_profiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstaff_profiles.Name = "btnstaff_profiles";
            this.btnstaff_profiles.Size = new System.Drawing.Size(199, 50);
            this.btnstaff_profiles.TabIndex = 15;
            this.btnstaff_profiles.Text = "Staff Profiles";
            this.btnstaff_profiles.UseVisualStyleBackColor = true;
            this.btnstaff_profiles.Click += new System.EventHandler(this.btnstaff_profiles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Staff Pay-Roll Management";
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter3.Location = new System.Drawing.Point(554, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(221, 449);
            this.splitter3.TabIndex = 13;
            this.splitter3.TabStop = false;
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(785, 27);
            this.btnreports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(237, 50);
            this.btnreports.TabIndex = 12;
            this.btnreports.Text = "Guard Finance Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btn_banks
            // 
            this.btn_banks.Location = new System.Drawing.Point(201, 137);
            this.btn_banks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_banks.Name = "btn_banks";
            this.btn_banks.Size = new System.Drawing.Size(351, 50);
            this.btn_banks.TabIndex = 11;
            this.btn_banks.Text = "Banks";
            this.btn_banks.UseVisualStyleBackColor = true;
            this.btn_banks.Click += new System.EventHandler(this.btn_banks_Click);
            // 
            // btn_bank_account_details
            // 
            this.btn_bank_account_details.Location = new System.Drawing.Point(201, 194);
            this.btn_bank_account_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bank_account_details.Name = "btn_bank_account_details";
            this.btn_bank_account_details.Size = new System.Drawing.Size(351, 50);
            this.btn_bank_account_details.TabIndex = 10;
            this.btn_bank_account_details.Text = "Update Guard Bank and Nssf Details";
            this.btn_bank_account_details.UseVisualStyleBackColor = true;
            this.btn_bank_account_details.Click += new System.EventHandler(this.btn_bank_account_details_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guard salary advances";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_payroll_setup
            // 
            this.btn_payroll_setup.Location = new System.Drawing.Point(201, 27);
            this.btn_payroll_setup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_payroll_setup.Name = "btn_payroll_setup";
            this.btn_payroll_setup.Size = new System.Drawing.Size(351, 50);
            this.btn_payroll_setup.TabIndex = 7;
            this.btn_payroll_setup.Text = "Guard Payroll Setup";
            this.btn_payroll_setup.UseVisualStyleBackColor = true;
            this.btn_payroll_setup.Click += new System.EventHandler(this.btn_payroll_setup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Guard Pay-Roll Management";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(192, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(362, 449);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // btn_auto_scale
            // 
            this.btn_auto_scale.Location = new System.Drawing.Point(4, 143);
            this.btn_auto_scale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_auto_scale.Name = "btn_auto_scale";
            this.btn_auto_scale.Size = new System.Drawing.Size(177, 50);
            this.btn_auto_scale.TabIndex = 4;
            this.btn_auto_scale.Text = "View Auto Assigned scales  to guards";
            this.btn_auto_scale.UseVisualStyleBackColor = true;
            this.btn_auto_scale.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_assign_scales
            // 
            this.btn_assign_scales.Location = new System.Drawing.Point(4, 85);
            this.btn_assign_scales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_assign_scales.Name = "btn_assign_scales";
            this.btn_assign_scales.Size = new System.Drawing.Size(177, 50);
            this.btn_assign_scales.TabIndex = 3;
            this.btn_assign_scales.Text = "Assign scales to guards(Batch)";
            this.btn_assign_scales.UseVisualStyleBackColor = true;
            this.btn_assign_scales.Click += new System.EventHandler(this.btn_assign_scales_Click);
            // 
            // btn_manage_scales
            // 
            this.btn_manage_scales.Location = new System.Drawing.Point(4, 27);
            this.btn_manage_scales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manage_scales.Name = "btn_manage_scales";
            this.btn_manage_scales.Size = new System.Drawing.Size(177, 50);
            this.btn_manage_scales.TabIndex = 2;
            this.btn_manage_scales.Text = "Manage Salary scales";
            this.btn_manage_scales.UseVisualStyleBackColor = true;
            this.btn_manage_scales.Click += new System.EventHandler(this.btn_manage_scales_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary Scales";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(192, 449);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accounts Management";
            // 
            // frm_accounts_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1027, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_accounts_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Management Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void btnstaff_profiles_Click(object sender, EventArgs e)
        {
            frm_staffprofiles profiles = new frm_staffprofiles();
            profiles.ShowDialog();
        }

        private void btn_staff_payroll_Click(object sender, EventArgs e)
        {
            frm_setup_payroll_staff staff_payroll = new frm_setup_payroll_staff();
            staff_payroll.ResetLoanDetails();
            staff_payroll.ShowDialog();
        }

        private void btn_staff_finance_reports_Click(object sender, EventArgs e)
        {
            frm_staff_payroll_reports_dashboard Payroll = new frm_staff_payroll_reports_dashboard();
            Payroll.ShowDialog();
        }

        private void btnAdditional_Click(object sender, EventArgs e)
        {
            (new frm_guard_deployment_additional_data()).Show();
        }
    }
}