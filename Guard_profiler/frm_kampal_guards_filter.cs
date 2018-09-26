using Guard_profiler.App_code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_kampal_guards_filter : Form
	{
		private IContainer components;

		private Panel panel1;

		private Button btn_report;

		private ComboBox cbo_branch;

		private Label label1;

		private Label label2;

		private ComboBox cbo_months;

		private Label label3;

		public frm_kampal_guards_filter()
		{
			this.InitializeComponent();
		}

		private void btn_report_Click(object sender, EventArgs e)
		{
			if (this.cbo_branch.Text == string.Empty || this.cbo_months.Text == string.Empty)
			{
				MessageBox.Show("Select a branch & Month to display report", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SystemConst._branch = this.cbo_branch.Text;
			SystemConst._Report_update_month = this.cbo_months.Text;
			(new frm_kampala_active_guards_report()).ShowDialog();
		}

		protected void Create_Months()
		{
			List<string> Months = new List<string>()
			{
				string.Empty
			};
			int year = DateTime.Now.Year;
			Months.Add(string.Concat("January,", year.ToString()));
			int num = DateTime.Now.Year;
			Months.Add(string.Concat("February,", num.ToString()));
			int year1 = DateTime.Now.Year;
			Months.Add(string.Concat("March,", year1.ToString()));
			int num1 = DateTime.Now.Year;
			Months.Add(string.Concat("April,", num1.ToString()));
			int year2 = DateTime.Now.Year;
			Months.Add(string.Concat("May,", year2.ToString()));
			int num2 = DateTime.Now.Year;
			Months.Add(string.Concat("June,", num2.ToString()));
			int year3 = DateTime.Now.Year;
			Months.Add(string.Concat("July,", year3.ToString()));
			int num3 = DateTime.Now.Year;
			Months.Add(string.Concat("August,", num3.ToString()));
			int year4 = DateTime.Now.Year;
			Months.Add(string.Concat("September,", year4.ToString()));
			int num4 = DateTime.Now.Year;
			Months.Add(string.Concat("October,", num4.ToString()));
			int year5 = DateTime.Now.Year;
			Months.Add(string.Concat("November,", year5.ToString()));
			int num5 = DateTime.Now.Year;
			Months.Add(string.Concat("December,", num5.ToString()));
			this.cbo_months.DataSource = Months;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_kampal_guards_filter_Load(object sender, EventArgs e)
		{
			this.GET_BRANCHES();
			this.Create_Months();
		}

		protected void GET_BRANCHES()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_KAMAPALA_BRANCHES");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -1;
				dtRow["branch"] = string.Empty;
				dtRow["active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_branch.DataSource = dt;
				this.cbo_branch.DisplayMember = "branch";
				this.cbo_branch.ValueMember = "branch_code";
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_kampal_guards_filter));
			this.panel1 = new Panel();
			this.label2 = new Label();
			this.cbo_months = new ComboBox();
			this.btn_report = new Button();
			this.cbo_branch = new ComboBox();
			this.label1 = new Label();
			this.label3 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbo_months);
			this.panel1.Controls.Add(this.btn_report);
			this.panel1.Controls.Add(this.cbo_branch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(543, 328);
			this.panel1.TabIndex = 1;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Yellow;
			this.label2.Location = new Point(119, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "SELECT MONTH";
			this.cbo_months.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbo_months.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_months.FormattingEnabled = true;
			this.cbo_months.Location = new Point(120, 112);
			this.cbo_months.Name = "cbo_months";
			this.cbo_months.Size = new System.Drawing.Size(310, 33);
			this.cbo_months.TabIndex = 5;
			this.btn_report.BackColor = Color.FromArgb(255, 192, 128);
			this.btn_report.Location = new Point(228, 147);
			this.btn_report.Name = "btn_report";
			this.btn_report.Size = new System.Drawing.Size(202, 44);
			this.btn_report.TabIndex = 2;
			this.btn_report.Text = "GENERATE LIST";
			this.btn_report.UseVisualStyleBackColor = false;
			this.btn_report.Click += new EventHandler(this.btn_report_Click);
			this.cbo_branch.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_branch.FormattingEnabled = true;
			this.cbo_branch.Location = new Point(120, 52);
			this.cbo_branch.Name = "cbo_branch";
			this.cbo_branch.Size = new System.Drawing.Size(310, 33);
			this.cbo_branch.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Yellow;
			this.label1.Location = new Point(158, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(250, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Generate Kampala Active Guard reports by divistion";
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Yellow;
			this.label3.Location = new Point(117, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "SELECT BRANCH";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Yellow;
			base.ClientSize = new System.Drawing.Size(548, 333);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_kampal_guards_filter";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Generate Kampala Active Guards Reports";
			base.Load += new EventHandler(this.frm_kampal_guards_filter_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}