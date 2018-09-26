using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_deployment_guard_client_mapping_report_selector : Form
	{
		private IContainer components;

		private Panel panel1;

		private Button btnreport;

		private Label label3;

		private Label label2;

		private DateTimePicker dt_end_date;

		private DateTimePicker dt_start_date;

		private Label label1;

		private TextBox txt_guard_number;

		public frm_deployment_guard_client_mapping_report_selector()
		{
			this.InitializeComponent();
		}

		private void btnreport_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty || !this.dt_start_date.Checked || !this.dt_end_date.Checked)
			{
				MessageBox.Show("All values are required", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			SystemConst.guard_number = this.txt_guard_number.Text;
			SystemConst._deployment_start_date = this.dt_start_date.Value.Date;
			SystemConst._deployment_end_date = this.dt_end_date.Value.Date;
			SystemConst._finance_crystal_report_type = "GUARD";
			(new frm_finance_detailed_guard_pay_roll_report()).Show();
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_deployment_guard_client_mapping_report_selector));
			this.panel1 = new Panel();
			this.btnreport = new Button();
			this.label3 = new Label();
			this.label2 = new Label();
			this.dt_end_date = new DateTimePicker();
			this.dt_start_date = new DateTimePicker();
			this.label1 = new Label();
			this.txt_guard_number = new TextBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.AliceBlue;
			this.panel1.Controls.Add(this.txt_guard_number);
			this.panel1.Controls.Add(this.btnreport);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dt_end_date);
			this.panel1.Controls.Add(this.dt_start_date);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(356, 258);
			this.panel1.TabIndex = 1;
			this.btnreport.Location = new Point(118, 154);
			this.btnreport.Name = "btnreport";
			this.btnreport.Size = new System.Drawing.Size(146, 31);
			this.btnreport.TabIndex = 7;
			this.btnreport.Text = "Generate Report";
			this.btnreport.UseVisualStyleBackColor = true;
			this.btnreport.Click += new EventHandler(this.btnreport_Click);
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Yellow;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(59, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Enter Guard Number";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Yellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(59, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "End date";
			this.dt_end_date.Format = DateTimePickerFormat.Short;
			this.dt_end_date.Location = new Point(59, 85);
			this.dt_end_date.Name = "dt_end_date";
			this.dt_end_date.ShowCheckBox = true;
			this.dt_end_date.Size = new System.Drawing.Size(205, 20);
			this.dt_end_date.TabIndex = 3;
			this.dt_start_date.Format = DateTimePickerFormat.Short;
			this.dt_start_date.Location = new Point(62, 43);
			this.dt_start_date.Name = "dt_start_date";
			this.dt_start_date.ShowCheckBox = true;
			this.dt_start_date.Size = new System.Drawing.Size(202, 20);
			this.dt_start_date.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Yellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(59, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Start date";
			this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number.Location = new Point(62, 127);
			this.txt_guard_number.Name = "txt_guard_number";
			this.txt_guard_number.Size = new System.Drawing.Size(202, 22);
			this.txt_guard_number.TabIndex = 8;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 192, 128);
			base.ClientSize = new System.Drawing.Size(362, 261);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_deployment_guard_client_mapping_report_selector";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Deployment Reporting";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}