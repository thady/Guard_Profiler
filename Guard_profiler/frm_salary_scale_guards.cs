using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_salary_scale_guards : Form
	{
		private IContainer components;

		private Panel panel1;

		private PictureBox pictureBox1;

		private Label label1;

		private TextBox txt_scale_name;

		private Label label2;

		private TextBox txt_year_minimum;

		private Label label3;

		private TextBox txt_year_maximum;

		private Label label4;

		private TextBox txt_amt;

		private Panel panel2;

		private DataGridView gdv_salary_scales;

		private TextBox txt_record_guid;

		private Panel panel3;

		private Button btnedit;

		private Button btn_save;

		private Panel panel4;

		private Button btn_update_salaries;

		//private ReSize reSize1;

		public frm_salary_scale_guards()
		{
			this.InitializeComponent();
		}

		protected void auto_assign_salary_scale_to_guard()
		{
			DataTable dt = Salary_scales.return_number_of_years_served_for_each_gaurd("return_number_of_years_served_for_each_gaurd");
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					DataRow dtRow = dt.Rows[i];
					int guard_auto_id = Convert.ToInt32(dtRow["auto_id"].ToString());
					string guard_number = (string)dtRow["guard_number"];
					int Duration = Convert.ToInt32(dtRow["Duration"].ToString());
					try
					{
						Salary_scales.auto_assign_salary_scale_to_guard("auto_assign_salary_scale_to_guard", Duration, guard_auto_id, guard_number);
					}
					catch (Exception exception)
					{
						throw exception;
					}
				}
				MessageBox.Show("All Guards salary scales successfully updated", "Update salary scales", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			this.save_or_update_salary_scale_guards();
		}

		private void btn_update_salaries_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("This might take a while,proceed?", "Update guard salary scales", MessageBoxButtons.YesNo);
			if (dialogResult != System.Windows.Forms.DialogResult.Yes)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					this.Cursor = Cursors.Default;
				}
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			this.auto_assign_salary_scale_to_guard();
			this.Cursor = Cursors.Default;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_salary_scale_guards_Load(object sender, EventArgs e)
		{
			this.get_list_of_salary_scales_for_guards();
		}

		protected void get_list_of_salary_scales_for_guards()
		{
			DataTable dt = Salary_scales.return_salary_scales("return_salary_scales");
			if (dt.Rows.Count > 0)
			{
				this.gdv_salary_scales.DataSource = dt;
				this.gdv_salary_scales.Columns[0].Visible = false;
				this.gdv_salary_scales.Columns[1].Visible = false;
				this.gdv_salary_scales.Columns[2].Visible = false;
				this.gdv_salary_scales.Columns["basic_amount"].HeaderText = "Basic Amount";
				this.gdv_salary_scales.Columns["salary_amount"].HeaderText = "Salary Amount";
				this.gdv_salary_scales.Columns["scale_name"].HeaderText = "Scale Name";
				this.gdv_salary_scales.Columns["transport_amount"].HeaderText = "Transport Amount";
				this.gdv_salary_scales.Columns["housing_amount"].HeaderText = "Housing Amount";
				this.gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_salary_scales.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_salary_scales.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_salary_scales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_salary_scales.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_salary_scales.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_salary_scale_guards));
			this.panel1 = new Panel();
			this.panel4 = new Panel();
			this.btn_update_salaries = new Button();
			this.panel3 = new Panel();
			this.btnedit = new Button();
			this.btn_save = new Button();
			this.txt_record_guid = new TextBox();
			this.panel2 = new Panel();
			this.gdv_salary_scales = new DataGridView();
			this.txt_amt = new TextBox();
			this.label4 = new Label();
			this.txt_year_maximum = new TextBox();
			this.label3 = new Label();
			this.txt_year_minimum = new TextBox();
			this.label2 = new Label();
			this.txt_scale_name = new TextBox();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			//this.reSize1 = new ReSize(this.components);
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.gdv_salary_scales).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.txt_record_guid);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.txt_amt);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txt_year_maximum);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txt_year_minimum);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txt_scale_name);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 485);
			this.panel1.TabIndex = 0;
			this.panel4.Controls.Add(this.btn_update_salaries);
			this.panel4.Location = new Point(587, 81);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(245, 36);
			this.panel4.TabIndex = 1;
			this.btn_update_salaries.Location = new Point(3, 3);
			this.btn_update_salaries.Name = "btn_update_salaries";
			this.btn_update_salaries.Size = new System.Drawing.Size(233, 30);
			this.btn_update_salaries.TabIndex = 0;
			this.btn_update_salaries.Text = "UPDATE ALL GUARDS SALARIES";
			this.btn_update_salaries.UseVisualStyleBackColor = true;
			this.btn_update_salaries.Click += new EventHandler(this.btn_update_salaries_Click);
			this.panel3.Controls.Add(this.btnedit);
			this.panel3.Controls.Add(this.btn_save);
			this.panel3.Location = new Point(500, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(332, 69);
			this.panel3.TabIndex = 11;
			this.btnedit.Location = new Point(118, 5);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(127, 60);
			this.btnedit.TabIndex = 1;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btn_save.Location = new Point(12, 4);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(100, 60);
			this.btn_save.TabIndex = 0;
			this.btn_save.Text = "SAVE";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new EventHandler(this.btn_save_Click);
			this.txt_record_guid.Location = new Point(429, 459);
			this.txt_record_guid.Name = "txt_record_guid";
			this.txt_record_guid.Size = new System.Drawing.Size(322, 20);
			this.txt_record_guid.TabIndex = 10;
			this.panel2.BackColor = SystemColors.GradientActiveCaption;
			this.panel2.Controls.Add(this.gdv_salary_scales);
			this.panel2.Location = new Point(3, 124);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(832, 332);
			this.panel2.TabIndex = 9;
			this.gdv_salary_scales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_salary_scales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_salary_scales.Location = new Point(3, 3);
			this.gdv_salary_scales.Name = "gdv_salary_scales";
			this.gdv_salary_scales.Size = new System.Drawing.Size(826, 326);
			this.gdv_salary_scales.TabIndex = 0;
			this.txt_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_amt.Location = new Point(285, 84);
			this.txt_amt.Name = "txt_amt";
			this.txt_amt.Size = new System.Drawing.Size(113, 22);
			this.txt_amt.TabIndex = 8;
			this.txt_amt.TextAlign = HorizontalAlignment.Center;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(282, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Gross Salary Amount";
			this.txt_year_maximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_year_maximum.Location = new Point(22, 84);
			this.txt_year_maximum.Name = "txt_year_maximum";
			this.txt_year_maximum.Size = new System.Drawing.Size(113, 22);
			this.txt_year_maximum.TabIndex = 6;
			this.txt_year_maximum.TextAlign = HorizontalAlignment.Center;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(19, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Maximum Number of Years Served";
			this.txt_year_minimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_year_minimum.Location = new Point(285, 40);
			this.txt_year_minimum.Name = "txt_year_minimum";
			this.txt_year_minimum.Size = new System.Drawing.Size(113, 22);
			this.txt_year_minimum.TabIndex = 4;
			this.txt_year_minimum.TextAlign = HorizontalAlignment.Center;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(282, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Minimum Number of Years Served";
			this.txt_scale_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_scale_name.Location = new Point(22, 40);
			this.txt_scale_name.Name = "txt_scale_name";
			this.txt_scale_name.Size = new System.Drawing.Size(249, 22);
			this.txt_scale_name.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(19, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Scale Name";
			this.pictureBox1.BackColor = Color.LightBlue;
			this.pictureBox1.Location = new Point(3, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(832, 108);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			//this.reSize1.About = null;
			//this.reSize1.AutoCenterFormOnLoad = false;
			//this.reSize1.Enabled = true;
			//this.reSize1.HostContainer = this;
			//this.reSize1.InitialHostContainerHeight = 488;
			//this.reSize1.InitialHostContainerWidth = 842;
			//this.reSize1.Tag = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 224, 192);
			base.ClientSize = new System.Drawing.Size(842, 488);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_salary_scale_guards";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Guard Salary Scales ";
			base.Load += new EventHandler(this.frm_salary_scale_guards_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.gdv_salary_scales).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		protected void save_or_update_salary_scale_guards()
		{
			string text;
			if (this.txt_scale_name.Text == string.Empty || this.txt_year_maximum.Text == string.Empty || this.txt_year_minimum.Text == string.Empty || this.txt_amt.Text == string.Empty)
			{
				MessageBox.Show("All fields are required", "save scale details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string str = this.txt_scale_name.Text;
			int num = Convert.ToInt32(this.txt_year_minimum.Text);
			int num1 = Convert.ToInt32(this.txt_year_maximum.Text);
			float single = float.Parse(this.txt_amt.Text);
			if (this.txt_record_guid.Text != string.Empty)
			{
				text = this.txt_record_guid.Text;
			}
			else
			{
				text = null;
			}
			Salary_scales.save_or_update_salary_scale_guards("save_or_update_salary_scale_guards", str, num, num1, single, text);
			MessageBox.Show("New salary saved successfully", "save scale details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}