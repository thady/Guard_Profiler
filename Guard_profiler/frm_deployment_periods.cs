using Guard_profiler.App_code;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_deployment_periods : Form
	{
		private IContainer components;

		private Panel panel1;

		private DataGridView gdv_deployment_periods;

		private Panel panel2;

		private Label label1;

		private Label label2;

		private DateTimePicker dt_end_date;

		private DateTimePicker dt_start_date;

		private CheckBox chk_active;

		private Panel panel3;

		private Button btnsave;

		private Button btn_new;

		private Panel panel4;

		private Label lbl_guid;

		public frm_deployment_periods()
		{
			this.InitializeComponent();
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			this.dt_start_date.Value = DateTime.Today;
			this.dt_end_date.Value = DateTime.Today;
			this.chk_active.Checked = false;
			this.lbl_guid.Text = "lbl_guid";
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			this.Save_deployment_periods();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_deployment_periods_Load(object sender, EventArgs e)
		{
			this.return_deployment_periods();
		}

		private void gdv_deployment_periods_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_deployment_periods.Rows.Count > 0)
			{
				this.dt_start_date.Value = Convert.ToDateTime(this.gdv_deployment_periods.CurrentRow.Cells[1].Value);
				this.dt_end_date.Value = Convert.ToDateTime(this.gdv_deployment_periods.CurrentRow.Cells[2].Value);
				this.chk_active.Checked = Convert.ToBoolean(this.gdv_deployment_periods.CurrentRow.Cells[4].Value);
				this.lbl_guid.Text = this.gdv_deployment_periods.CurrentRow.Cells[0].Value.ToString();
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_deployment_periods));
			this.panel1 = new Panel();
			this.gdv_deployment_periods = new DataGridView();
			this.panel2 = new Panel();
			this.chk_active = new CheckBox();
			this.label2 = new Label();
			this.dt_end_date = new DateTimePicker();
			this.dt_start_date = new DateTimePicker();
			this.label1 = new Label();
			this.panel3 = new Panel();
			this.btnsave = new Button();
			this.btn_new = new Button();
			this.panel4 = new Panel();
			this.lbl_guid = new Label();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.gdv_deployment_periods).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.gdv_deployment_periods);
			this.panel1.Location = new Point(2, 120);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 362);
			this.panel1.TabIndex = 0;
			this.gdv_deployment_periods.AllowUserToAddRows = false;
			this.gdv_deployment_periods.AllowUserToDeleteRows = false;
			this.gdv_deployment_periods.AllowUserToResizeColumns = false;
			this.gdv_deployment_periods.AllowUserToResizeRows = false;
			this.gdv_deployment_periods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_deployment_periods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_deployment_periods.Location = new Point(0, 3);
			this.gdv_deployment_periods.Name = "gdv_deployment_periods";
			this.gdv_deployment_periods.ReadOnly = true;
			this.gdv_deployment_periods.Size = new System.Drawing.Size(599, 368);
			this.gdv_deployment_periods.TabIndex = 0;
			this.gdv_deployment_periods.CellClick += new DataGridViewCellEventHandler(this.gdv_deployment_periods_CellClick);
			this.panel2.BackColor = SystemColors.GradientInactiveCaption;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.chk_active);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dt_end_date);
			this.panel2.Controls.Add(this.dt_start_date);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new Point(2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(602, 84);
			this.panel2.TabIndex = 1;
			this.chk_active.AutoSize = true;
			this.chk_active.BackColor = Color.Yellow;
			this.chk_active.Location = new Point(270, 24);
			this.chk_active.Name = "chk_active";
			this.chk_active.Size = new System.Drawing.Size(145, 17);
			this.chk_active.TabIndex = 7;
			this.chk_active.Text = "Active deployment period";
			this.chk_active.UseVisualStyleBackColor = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 192, 128);
			this.label2.Location = new Point(10, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Deployment end date";
			this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_end_date.Location = new Point(13, 58);
			this.dt_end_date.Name = "dt_end_date";
			this.dt_end_date.ShowCheckBox = true;
			this.dt_end_date.Size = new System.Drawing.Size(225, 21);
			this.dt_end_date.TabIndex = 5;
			this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_start_date.Location = new Point(13, 20);
			this.dt_start_date.Name = "dt_start_date";
			this.dt_start_date.ShowCheckBox = true;
			this.dt_start_date.Size = new System.Drawing.Size(227, 21);
			this.dt_start_date.TabIndex = 4;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 192, 128);
			this.label1.Location = new Point(10, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Deployment start date";
			this.panel3.BackColor = Color.FromArgb(255, 192, 128);
			this.panel3.Controls.Add(this.btn_new);
			this.panel3.Controls.Add(this.btnsave);
			this.panel3.Location = new Point(421, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(178, 77);
			this.panel3.TabIndex = 8;
			this.btnsave.BackColor = Color.FromArgb(192, 255, 255);
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnsave.Location = new Point(3, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(170, 34);
			this.btnsave.TabIndex = 0;
			this.btnsave.Text = "SAVE DEPLOYMENT PERIOD";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.btn_new.BackColor = Color.FromArgb(192, 255, 192);
			this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btn_new.Location = new Point(3, 38);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(170, 34);
			this.btn_new.TabIndex = 1;
			this.btn_new.Text = "NEW DEPLOYMENT PERIOD";
			this.btn_new.UseVisualStyleBackColor = false;
			this.btn_new.Click += new EventHandler(this.btn_new_Click);
			this.panel4.BackColor = Color.White;
			this.panel4.Controls.Add(this.lbl_guid);
			this.panel4.Location = new Point(2, 87);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(602, 27);
			this.panel4.TabIndex = 1;
			this.lbl_guid.AutoSize = true;
			this.lbl_guid.ForeColor = Color.Blue;
			this.lbl_guid.Location = new Point(245, 7);
			this.lbl_guid.Name = "lbl_guid";
			this.lbl_guid.Size = new System.Drawing.Size(43, 13);
			this.lbl_guid.TabIndex = 0;
			this.lbl_guid.Text = "lbl_guid";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 224, 192);
			base.ClientSize = new System.Drawing.Size(608, 483);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_deployment_periods";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Manage deployment periods";
			base.Load += new EventHandler(this.frm_deployment_periods_Load);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.gdv_deployment_periods).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}

		protected void return_deployment_periods()
		{
			DataTable dt = Guard_deployment.Return_list_of_deployment_periods("return_list_of_deployment_periods");
			if (dt.Rows.Count > 0)
			{
				this.gdv_deployment_periods.DataSource = dt;
				this.gdv_deployment_periods.Columns["deploy_id"].Visible = false;
				this.gdv_deployment_periods.Columns["deploy_start_date"].HeaderText = "Deployment start date";
				this.gdv_deployment_periods.Columns["deploy_end_date"].HeaderText = "Deployment end date";
				this.gdv_deployment_periods.Columns["created_by"].HeaderText = "Created by";
				this.gdv_deployment_periods.Columns["active_deployment"].HeaderText = "Active Deployment";
				this.gdv_deployment_periods.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_deployment_periods.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_deployment_periods.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_deployment_periods.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_deployment_periods.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_deployment_periods.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
				}
				this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_deployment_periods.EnableHeadersVisualStyles = false;
			}
		}

		protected void Save_deployment_periods()
		{
			if (this.dt_start_date.Value.Date.Day != 1 && (this.dt_end_date.Value.Date.Day != 30 || this.dt_end_date.Value.Date.Day != 31))
			{
				MessageBox.Show("Please select first and last days of the month only", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!(this.lbl_guid.Text == "lbl_guid") || !this.chk_active.Checked)
			{
				if (this.lbl_guid.Text == "lbl_guid" && !this.chk_active.Checked)
				{
					if (Guard_deployment.check_if_deployment_period_already_exists("check_if_deployment_period_already_exists", this.dt_start_date.Value.Date, this.dt_end_date.Value.Date) > 0)
					{
						MessageBox.Show("Deployment period already exists!!", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					Guard_deployment.Save_new_deployment_period("save_new_deployment_period", this.dt_start_date.Value.Date, this.dt_end_date.Value.Date, (this.chk_active.Checked ? true : false));
					this.return_deployment_periods();
					return;
				}
				if (this.lbl_guid.Text != "lbl_guid" && this.chk_active.Checked)
				{
					System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure to set this as the current deployment period?", "Deployments", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						Guard_deployment.Set_active_deployment("set_active_deployment", Convert.ToInt32(this.lbl_guid.Text), (this.chk_active.Checked ? true : false));
						this.return_deployment_periods();
						this.Set_current_deployment_periods();
						return;
					}
					if (dialogResult == System.Windows.Forms.DialogResult.No)
					{
						base.Visible = true;
						return;
					}
				}
				else if (this.lbl_guid.Text != "lbl_guid")
				{
					bool @checked = this.chk_active.Checked;
				}
			}
			else
			{
				if (Guard_deployment.check_if_deployment_period_already_exists("check_if_deployment_period_already_exists", this.dt_start_date.Value.Date, this.dt_end_date.Value.Date) > 0)
				{
					MessageBox.Show("Deployment period already exists!!", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("This will save and set this deployment period as the active deployment,are you sure to proceed?", "Deployments", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Guard_deployment.Save_new_deployment_period("save_new_deployment_period", this.dt_start_date.Value.Date, this.dt_end_date.Value.Date, (this.chk_active.Checked ? true : false));
					this.return_deployment_periods();
					this.Set_current_deployment_periods();
					return;
				}
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
					return;
				}
			}
		}

		protected void Set_current_deployment_periods()
		{
			DataTable dt = Guard_deployment.Select_active_deployment_period("select_active_deployment_period");
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.Rows[0];
				int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
				SystemConst._active_deployment_id = num.ToString();
				SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
				SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
			}
		}
	}
}