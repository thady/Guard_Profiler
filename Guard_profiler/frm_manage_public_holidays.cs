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
	public class frm_manage_public_holidays : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private DateTimePicker dt_end_date;

		private DateTimePicker dt_start_date;

		private Label label6;

		private Label label4;

		private Panel panel3;

		private Label label1;

		private Label label2;

		private TextBox txt_public_holiday_name;

		private DateTimePicker dt_public_holiday_date;

		private Button btnsave;

		private Button btnedit;

		private TextBox txt_record_guid;

		private DataGridView gdv_public_holidays;

		private Button btnnew;

		private Button btndelete;

		public frm_manage_public_holidays()
		{
			this.InitializeComponent();
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure to delete this public holiday", "Delete Public holiday", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != System.Windows.Forms.DialogResult.Yes)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
				}
				return;
			}
			Guard_deployment.delete_public_holiday("delete_public_holiday", this.txt_record_guid.Text);
			this.get_list_of_public_holidays();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			if (this.txt_record_guid.Text == string.Empty)
			{
				MessageBox.Show("Select a record first", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.txt_public_holiday_name.ReadOnly = false;
			this.dt_public_holiday_date.Enabled = true;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_public_holiday_name.ReadOnly = false;
			this.dt_public_holiday_date.Enabled = true;
			this.txt_record_guid.Clear();
			this.txt_public_holiday_name.Clear();
			this.dt_public_holiday_date.Value = DateTime.Today;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.txt_public_holiday_name.Text == string.Empty)
			{
				MessageBox.Show("Missing public holiday name", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.txt_public_holiday_name.Text.Length < 2)
			{
				MessageBox.Show("Type in a valid public holiday name", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.dt_public_holiday_date.Value.Date < this.dt_start_date.Value.Date || this.dt_public_holiday_date.Value.Date > this.dt_end_date.Value.Date)
			{
				MessageBox.Show("Public holiday must be in range of current deployment period", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.txt_record_guid.Text == string.Empty)
			{
				int num = Convert.ToInt32(SystemConst._active_deployment_id);
				string text = this.txt_public_holiday_name.Text;
				DateTime value = this.dt_public_holiday_date.Value;
				Guard_deployment.save_new_public_holiday("save_new_public_holiday", num, text, value.Date);
				MessageBox.Show("Successfully saved public holiday", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.get_list_of_public_holidays();
				return;
			}
			string str = this.txt_record_guid.Text;
			string text1 = this.txt_public_holiday_name.Text;
			DateTime dateTime = this.dt_public_holiday_date.Value;
			Guard_deployment.update_public_holiday_details("update_public_holiday_details", str, text1, dateTime.Date);
			MessageBox.Show("Successfully updated public holiday", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.get_list_of_public_holidays();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_manage_public_holidays_Load(object sender, EventArgs e)
		{
			this.dt_start_date.Value = SystemConst._deployment_start_date;
			this.dt_end_date.Value = SystemConst._deployment_end_date;
			this.get_list_of_public_holidays();
		}

		private void gdv_public_holidays_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_public_holidays.Rows.Count > 0)
			{
				this.txt_public_holiday_name.Text = this.gdv_public_holidays.CurrentRow.Cells[2].Value.ToString();
				this.dt_public_holiday_date.Value = Convert.ToDateTime(this.gdv_public_holidays.CurrentRow.Cells[3].Value);
				this.txt_record_guid.Text = this.gdv_public_holidays.CurrentRow.Cells[0].Value.ToString();
				this.txt_public_holiday_name.ReadOnly = true;
				this.dt_public_holiday_date.Enabled = false;
			}
		}

		protected void get_list_of_public_holidays()
		{
			DataTable dt = Guard_deployment.return_list_of_public_holidays("return_list_of_public_holidays");
			if (dt.Rows.Count > 0)
			{
				this.gdv_public_holidays.DataSource = dt;
				this.gdv_public_holidays.Columns["record_guid"].Visible = false;
				this.gdv_public_holidays.Columns["deployment_period_id"].Visible = false;
				this.gdv_public_holidays.Columns["public_holiday_name"].HeaderText = "Public Holiday Name";
				this.gdv_public_holidays.Columns["public_holiday_date"].HeaderText = "Public Holiday Date";
				this.gdv_public_holidays.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_public_holidays.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_public_holidays.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_public_holidays.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_public_holidays.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_public_holidays.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_public_holidays.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_public_holidays.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
				}
				this.gdv_public_holidays.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_public_holidays.EnableHeadersVisualStyles = false;
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_manage_public_holidays));
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.dt_end_date = new DateTimePicker();
			this.label4 = new Label();
			this.label6 = new Label();
			this.dt_start_date = new DateTimePicker();
			this.panel3 = new Panel();
			this.label1 = new Label();
			this.txt_public_holiday_name = new TextBox();
			this.label2 = new Label();
			this.dt_public_holiday_date = new DateTimePicker();
			this.btnsave = new Button();
			this.btnedit = new Button();
			this.txt_record_guid = new TextBox();
			this.gdv_public_holidays = new DataGridView();
			this.btnnew = new Button();
			this.btndelete = new Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.gdv_public_holidays).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.gdv_public_holidays);
			this.panel1.Location = new Point(3, 115);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(598, 341);
			this.panel1.TabIndex = 0;
			this.panel2.BackColor = Color.Black;
			this.panel2.Controls.Add(this.dt_end_date);
			this.panel2.Controls.Add(this.dt_start_date);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Enabled = false;
			this.panel2.Location = new Point(3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(598, 28);
			this.panel2.TabIndex = 1;
			this.dt_end_date.Enabled = false;
			this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_end_date.Format = DateTimePickerFormat.Short;
			this.dt_end_date.Location = new Point(465, 3);
			this.dt_end_date.Name = "dt_end_date";
			this.dt_end_date.ShowCheckBox = true;
			this.dt_end_date.Size = new System.Drawing.Size(117, 21);
			this.dt_end_date.TabIndex = 16;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(157, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "For the period of:";
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(432, 7);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "To";
			this.dt_start_date.Enabled = false;
			this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_start_date.Format = DateTimePickerFormat.Short;
			this.dt_start_date.Location = new Point(289, 3);
			this.dt_start_date.Name = "dt_start_date";
			this.dt_start_date.ShowCheckBox = true;
			this.dt_start_date.Size = new System.Drawing.Size(128, 21);
			this.dt_start_date.TabIndex = 14;
			this.panel3.BackColor = SystemColors.GradientInactiveCaption;
			this.panel3.Controls.Add(this.btndelete);
			this.panel3.Controls.Add(this.btnnew);
			this.panel3.Controls.Add(this.btnedit);
			this.panel3.Controls.Add(this.btnsave);
			this.panel3.Controls.Add(this.dt_public_holiday_date);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txt_public_holiday_name);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new Point(3, 36);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(598, 55);
			this.panel3.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 192, 128);
			this.label1.Location = new Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Public holiday name";
			this.txt_public_holiday_name.Location = new Point(3, 19);
			this.txt_public_holiday_name.Name = "txt_public_holiday_name";
			this.txt_public_holiday_name.Size = new System.Drawing.Size(228, 20);
			this.txt_public_holiday_name.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 192, 128);
			this.label2.Location = new Point(232, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Public holiday date";
			this.dt_public_holiday_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_public_holiday_date.Format = DateTimePickerFormat.Short;
			this.dt_public_holiday_date.Location = new Point(235, 19);
			this.dt_public_holiday_date.Name = "dt_public_holiday_date";
			this.dt_public_holiday_date.ShowCheckBox = true;
			this.dt_public_holiday_date.Size = new System.Drawing.Size(128, 21);
			this.dt_public_holiday_date.TabIndex = 17;
			this.btnsave.BackColor = Color.FromArgb(192, 255, 255);
			this.btnsave.Location = new Point(369, 9);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(56, 37);
			this.btnsave.TabIndex = 18;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.btnedit.BackColor = Color.FromArgb(128, 255, 255);
			this.btnedit.Location = new Point(425, 9);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(60, 37);
			this.btnedit.TabIndex = 19;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = false;
			this.btnedit.Click += new EventHandler(this.btnedit_Click);
			this.txt_record_guid.BackColor = SystemColors.InactiveCaptionText;
			this.txt_record_guid.Enabled = false;
			this.txt_record_guid.Location = new Point(3, 93);
			this.txt_record_guid.Name = "txt_record_guid";
			this.txt_record_guid.Size = new System.Drawing.Size(598, 20);
			this.txt_record_guid.TabIndex = 3;
			this.txt_record_guid.TextAlign = HorizontalAlignment.Center;
			this.gdv_public_holidays.AllowUserToAddRows = false;
			this.gdv_public_holidays.AllowUserToDeleteRows = false;
			this.gdv_public_holidays.AllowUserToResizeColumns = false;
			this.gdv_public_holidays.AllowUserToResizeRows = false;
			this.gdv_public_holidays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_public_holidays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_public_holidays.Location = new Point(3, 3);
			this.gdv_public_holidays.Name = "gdv_public_holidays";
			this.gdv_public_holidays.Size = new System.Drawing.Size(592, 335);
			this.gdv_public_holidays.TabIndex = 0;
			this.gdv_public_holidays.CellClick += new DataGridViewCellEventHandler(this.gdv_public_holidays_CellClick);
			this.btnnew.BackColor = Color.FromArgb(128, 255, 128);
			this.btnnew.Location = new Point(486, 9);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(60, 37);
			this.btnnew.TabIndex = 20;
			this.btnnew.Text = "New";
			this.btnnew.UseVisualStyleBackColor = false;
			this.btnnew.Click += new EventHandler(this.btnnew_Click);
			this.btndelete.BackColor = Color.Red;
			this.btndelete.Enabled = false;
			this.btndelete.Location = new Point(546, 9);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(47, 37);
			this.btndelete.TabIndex = 21;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			this.btndelete.Click += new EventHandler(this.btndelete_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 224, 192);
			base.ClientSize = new System.Drawing.Size(602, 459);
			base.Controls.Add(this.txt_record_guid);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_manage_public_holidays";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Manage Public Holidays";
			base.Load += new EventHandler(this.frm_manage_public_holidays_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.gdv_public_holidays).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}