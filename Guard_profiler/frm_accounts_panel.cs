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

		private Label label4;

		private Button button2;

		private Button btn_bank_account_details;

		private Button btn_banks;

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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_accounts_panel));
			this.menuStrip1 = new MenuStrip();
			this.panel1 = new Panel();
			this.btn_banks = new Button();
			this.btn_bank_account_details = new Button();
			this.button2 = new Button();
			this.label4 = new Label();
			this.btn_payroll_setup = new Button();
			this.label3 = new Label();
			this.splitter2 = new Splitter();
			this.btn_auto_scale = new Button();
			this.btn_assign_scales = new Button();
			this.btn_manage_scales = new Button();
			this.label2 = new Label();
			this.splitter1 = new Splitter();
			this.label1 = new Label();
			this.btnreports = new Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.BackColor = SystemColors.AppWorkspace;
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(610, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.btnreports);
			this.panel1.Controls.Add(this.btn_banks);
			this.panel1.Controls.Add(this.btn_bank_account_details);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btn_payroll_setup);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.splitter2);
			this.panel1.Controls.Add(this.btn_auto_scale);
			this.panel1.Controls.Add(this.btn_assign_scales);
			this.panel1.Controls.Add(this.btn_manage_scales);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Location = new Point(0, 46);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 294);
			this.panel1.TabIndex = 1;
			this.btn_banks.Location = new Point(151, 116);
			this.btn_banks.Name = "btn_banks";
			this.btn_banks.Size = new System.Drawing.Size(149, 41);
			this.btn_banks.TabIndex = 11;
			this.btn_banks.Text = "Banks";
			this.btn_banks.UseVisualStyleBackColor = true;
			this.btn_banks.Click += new EventHandler(this.btn_banks_Click);
			this.btn_bank_account_details.Location = new Point(151, 163);
			this.btn_bank_account_details.Name = "btn_bank_account_details";
			this.btn_bank_account_details.Size = new System.Drawing.Size(149, 41);
			this.btn_bank_account_details.TabIndex = 10;
			this.btn_bank_account_details.Text = "Update Guard Bank and Nssf Details";
			this.btn_bank_account_details.UseVisualStyleBackColor = true;
			this.btn_bank_account_details.Click += new EventHandler(this.btn_bank_account_details_Click);
			this.button2.Location = new Point(151, 69);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 41);
			this.button2.TabIndex = 9;
			this.button2.Text = "Guard salary advances";
			this.button2.UseVisualStyleBackColor = true;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.FromArgb(255, 192, 128);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(315, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Finance Reports";
			this.btn_payroll_setup.Location = new Point(151, 22);
			this.btn_payroll_setup.Name = "btn_payroll_setup";
			this.btn_payroll_setup.Size = new System.Drawing.Size(149, 41);
			this.btn_payroll_setup.TabIndex = 7;
			this.btn_payroll_setup.Text = "Set up payroll";
			this.btn_payroll_setup.UseVisualStyleBackColor = true;
			this.btn_payroll_setup.Click += new EventHandler(this.btn_payroll_setup_Click);
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(255, 192, 128);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(151, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pay-Roll Management";
			this.splitter2.BackColor = Color.Gainsboro;
			this.splitter2.BorderStyle = BorderStyle.Fixed3D;
			this.splitter2.Location = new Point(145, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(164, 294);
			this.splitter2.TabIndex = 5;
			this.splitter2.TabStop = false;
			this.btn_auto_scale.Location = new Point(3, 116);
			this.btn_auto_scale.Name = "btn_auto_scale";
			this.btn_auto_scale.Size = new System.Drawing.Size(133, 41);
			this.btn_auto_scale.TabIndex = 4;
			this.btn_auto_scale.Text = "View Auto Assigned scales  to guards";
			this.btn_auto_scale.UseVisualStyleBackColor = true;
			this.btn_auto_scale.Click += new EventHandler(this.button1_Click);
			this.btn_assign_scales.Location = new Point(3, 69);
			this.btn_assign_scales.Name = "btn_assign_scales";
			this.btn_assign_scales.Size = new System.Drawing.Size(133, 41);
			this.btn_assign_scales.TabIndex = 3;
			this.btn_assign_scales.Text = "Assign scales to guards(Batch)";
			this.btn_assign_scales.UseVisualStyleBackColor = true;
			this.btn_assign_scales.Click += new EventHandler(this.btn_assign_scales_Click);
			this.btn_manage_scales.Location = new Point(3, 22);
			this.btn_manage_scales.Name = "btn_manage_scales";
			this.btn_manage_scales.Size = new System.Drawing.Size(133, 41);
			this.btn_manage_scales.TabIndex = 2;
			this.btn_manage_scales.Text = "Manage Salary scales";
			this.btn_manage_scales.UseVisualStyleBackColor = true;
			this.btn_manage_scales.Click += new EventHandler(this.btn_manage_scales_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 192, 128);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(3, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Salary Scales";
			this.splitter1.BackColor = Color.LightSteelBlue;
			this.splitter1.BorderStyle = BorderStyle.Fixed3D;
			this.splitter1.Location = new Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(145, 294);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 255, 128);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(0, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Accounts Management";
			this.btnreports.Location = new Point(315, 22);
			this.btnreports.Name = "btnreports";
			this.btnreports.Size = new System.Drawing.Size(292, 41);
			this.btnreports.TabIndex = 12;
			this.btnreports.Text = "Finance Reports";
			this.btnreports.UseVisualStyleBackColor = true;
			this.btnreports.Click += new EventHandler(this.btnreports_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 224, 192);
			base.ClientSize = new System.Drawing.Size(610, 343);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frm_accounts_panel";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Accounts Management Dashboard";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}