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
	public class frm_assign_salary_scales_to_guards : Form
	{
		private IContainer components;

		//private ReSize reSize1;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private DataGridView gdv_guard_salaries;

		private DataGridView gdv_salary_scales;

		private Panel panel4;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Panel panel5;

		private Label label6;

		private Label label7;

		private CheckBox chk_check_all;

		private Label label8;

		private TextBox txt_scale_name;

		private Label label9;

		private TextBox txt_amount;

		private Label lbl_scale_global_id;

		private Panel panel6;

		private Button btn_assign_scales;

		private Label label10;

		private TextBox txt_auto_id;

		private Button btn_scale_change_reports;

		private Label label11;

		private ComboBox cbo_station_name;

		private Label label12;

		private TextBox txt_guard_name;

		private TextBox txt_guard_number;

		private Label label13;
        private ReSize reSize1;
        private Button btnsearch;

		public frm_assign_salary_scales_to_guards()
		{
			this.InitializeComponent();
		}

		private void btn_assign_scales_Click(object sender, EventArgs e)
		{
			if (this.txt_scale_name.Text == string.Empty)
			{
				MessageBox.Show("No scale selected", "save scales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
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
			this.Save_or_update_guard_salary_scale();
			this.Cursor = Cursors.Default;
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			if (!(this.cbo_station_name.Text != string.Empty) && !(this.txt_guard_name.Text != string.Empty) && !(this.txt_guard_number.Text != string.Empty))
			{
				this.gdv_guard_salaries.DataSource = null;
				this.gdv_guard_salaries.Rows.Clear();
				this.gdv_guard_salaries.Refresh();
				if (this.gdv_guard_salaries.Columns.Count > 0)
				{
					this.gdv_guard_salaries.Columns.RemoveAt(0);
				}
				this.Return_guard_salary_mappings();
				return;
			}
			this.gdv_guard_salaries.DataSource = null;
			this.gdv_guard_salaries.Rows.Clear();
			this.gdv_guard_salaries.Refresh();
			if (this.gdv_guard_salaries.Columns.Count > 0)
			{
				this.gdv_guard_salaries.Columns.RemoveAt(0);
			}
			this.return_manual_guard_salary_scale_mappings_search();
		}

		private void chk_check_all_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.chk_check_all.Checked)
			{
				foreach (DataGridViewRow row in (IEnumerable)this.gdv_guard_salaries.Rows)
				{
					row.Cells["column_select"].Value = false;
				}
			}
			else
			{
				foreach (DataGridViewRow row in (IEnumerable)this.gdv_guard_salaries.Rows)
				{
					row.Cells["column_select"].Value = true;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_assign_salary_scales_to_guards_Load(object sender, EventArgs e)
		{
			this.get_list_of_salary_scales_for_guards();
			this.Return_guard_salary_mappings();
			this.GET_BRANCHES();
			base.WindowState = FormWindowState.Maximized;
		}

		private void gdv_salary_scales_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_salary_scales.Rows.Count != 0)
			{
				this.txt_scale_name.Text = this.gdv_salary_scales.CurrentRow.Cells[3].Value.ToString();
				this.txt_amount.Text = this.gdv_salary_scales.CurrentRow.Cells[4].Value.ToString();
				this.lbl_scale_global_id.Text = this.gdv_salary_scales.CurrentRow.Cells[0].Value.ToString();
				this.txt_auto_id.Text = this.gdv_salary_scales.CurrentRow.Cells[1].Value.ToString();
			}
		}

		protected void GET_BRANCHES()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -1;
				dtRow["branch"] = string.Empty;
				dtRow["active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_station_name.DataSource = dt;
				this.cbo_station_name.DisplayMember = "branch";
				this.cbo_station_name.ValueMember = "branch_code";
			}
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
				this.gdv_salary_scales.Columns["scale_name"].Width = 220;
				this.gdv_salary_scales.Columns["salary_amount"].DefaultCellStyle.ForeColor = Color.Blue;
				this.gdv_salary_scales.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_salary_scales.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_salary_scales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_salary_scales.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_salary_scales.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_salary_scales.EnableHeadersVisualStyles = false;
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_assign_salary_scales_to_guards));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_auto_id = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_scale_change_reports = new System.Windows.Forms.Button();
            this.btn_assign_scales = new System.Windows.Forms.Button();
            this.lbl_scale_global_id = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_scale_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chk_check_all = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_guard_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_station_name = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdv_salary_scales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_guard_salaries = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_salary_scales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_auto_id);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lbl_scale_global_id);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_scale_name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chk_check_all);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 696);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(875, 621);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Auto ID";
            // 
            // txt_auto_id
            // 
            this.txt_auto_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auto_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_auto_id.Location = new System.Drawing.Point(878, 644);
            this.txt_auto_id.Name = "txt_auto_id";
            this.txt_auto_id.ReadOnly = true;
            this.txt_auto_id.Size = new System.Drawing.Size(61, 26);
            this.txt_auto_id.TabIndex = 14;
            this.txt_auto_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.btn_scale_change_reports);
            this.panel6.Controls.Add(this.btn_assign_scales);
            this.panel6.Location = new System.Drawing.Point(561, 26);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(537, 45);
            this.panel6.TabIndex = 3;
            // 
            // btn_scale_change_reports
            // 
            this.btn_scale_change_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_scale_change_reports.ForeColor = System.Drawing.Color.Blue;
            this.btn_scale_change_reports.Location = new System.Drawing.Point(216, 3);
            this.btn_scale_change_reports.Name = "btn_scale_change_reports";
            this.btn_scale_change_reports.Size = new System.Drawing.Size(144, 39);
            this.btn_scale_change_reports.TabIndex = 1;
            this.btn_scale_change_reports.Text = "SCALE CHANGE REPORT";
            this.btn_scale_change_reports.UseVisualStyleBackColor = false;
            // 
            // btn_assign_scales
            // 
            this.btn_assign_scales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_assign_scales.ForeColor = System.Drawing.Color.Blue;
            this.btn_assign_scales.Location = new System.Drawing.Point(3, 3);
            this.btn_assign_scales.Name = "btn_assign_scales";
            this.btn_assign_scales.Size = new System.Drawing.Size(207, 39);
            this.btn_assign_scales.TabIndex = 0;
            this.btn_assign_scales.Text = "EXECUTE SALARY SCALE MAPPINGS";
            this.btn_assign_scales.UseVisualStyleBackColor = false;
            this.btn_assign_scales.Click += new System.EventHandler(this.btn_assign_scales_Click);
            // 
            // lbl_scale_global_id
            // 
            this.lbl_scale_global_id.AutoSize = true;
            this.lbl_scale_global_id.ForeColor = System.Drawing.Color.Blue;
            this.lbl_scale_global_id.Location = new System.Drawing.Point(552, 673);
            this.lbl_scale_global_id.Name = "lbl_scale_global_id";
            this.lbl_scale_global_id.Size = new System.Drawing.Size(46, 13);
            this.lbl_scale_global_id.TabIndex = 13;
            this.lbl_scale_global_id.Text = "global id";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.ForeColor = System.Drawing.Color.Blue;
            this.txt_amount.Location = new System.Drawing.Point(956, 644);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(142, 26);
            this.txt_amount.TabIndex = 12;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(952, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Amount";
            // 
            // txt_scale_name
            // 
            this.txt_scale_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_scale_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_scale_name.Location = new System.Drawing.Point(549, 644);
            this.txt_scale_name.Name = "txt_scale_name";
            this.txt_scale_name.ReadOnly = true;
            this.txt_scale_name.Size = new System.Drawing.Size(323, 26);
            this.txt_scale_name.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(643, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Salary scale";
            // 
            // chk_check_all
            // 
            this.chk_check_all.AutoSize = true;
            this.chk_check_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chk_check_all.Location = new System.Drawing.Point(11, 75);
            this.chk_check_all.Name = "chk_check_all";
            this.chk_check_all.Size = new System.Drawing.Size(70, 17);
            this.chk_check_all.TabIndex = 0;
            this.chk_check_all.Text = "Select All";
            this.chk_check_all.UseVisualStyleBackColor = false;
            this.chk_check_all.CheckedChanged += new System.EventHandler(this.chk_check_all_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(549, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(559, 23);
            this.panel5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Warning:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(432, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "For security Purposes,all salary scale changes made are being tracked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "(Tick to map guard to salary scale)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(787, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Tick to map salary to guard)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currently approved salary scales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assign salary scales to guards[Use Search Options below to narrow down results]";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnsearch);
            this.panel4.Controls.Add(this.txt_guard_number);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt_guard_name);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cbo_station_name);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 45);
            this.panel4.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(486, 3);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(66, 39);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(356, 19);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(124, 22);
            this.txt_guard_number.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Guard Number";
            // 
            // txt_guard_name
            // 
            this.txt_guard_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_name.Location = new System.Drawing.Point(192, 19);
            this.txt_guard_name.Name = "txt_guard_name";
            this.txt_guard_name.Size = new System.Drawing.Size(162, 22);
            this.txt_guard_name.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Guard Name";
            // 
            // cbo_station_name
            // 
            this.cbo_station_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_station_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_station_name.FormattingEnabled = true;
            this.cbo_station_name.Location = new System.Drawing.Point(11, 19);
            this.cbo_station_name.Name = "cbo_station_name";
            this.cbo_station_name.Size = new System.Drawing.Size(175, 23);
            this.cbo_station_name.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Station Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gdv_salary_scales);
            this.panel3.Location = new System.Drawing.Point(541, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 526);
            this.panel3.TabIndex = 1;
            // 
            // gdv_salary_scales
            // 
            this.gdv_salary_scales.AllowUserToAddRows = false;
            this.gdv_salary_scales.AllowUserToDeleteRows = false;
            this.gdv_salary_scales.AllowUserToResizeColumns = false;
            this.gdv_salary_scales.AllowUserToResizeRows = false;
            this.gdv_salary_scales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_salary_scales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_salary_scales.Location = new System.Drawing.Point(3, 3);
            this.gdv_salary_scales.Name = "gdv_salary_scales";
            this.gdv_salary_scales.Size = new System.Drawing.Size(551, 520);
            this.gdv_salary_scales.TabIndex = 0;
            this.gdv_salary_scales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_salary_scales_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdv_guard_salaries);
            this.panel2.Location = new System.Drawing.Point(11, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 598);
            this.panel2.TabIndex = 0;
            // 
            // gdv_guard_salaries
            // 
            this.gdv_guard_salaries.AllowUserToAddRows = false;
            this.gdv_guard_salaries.AllowUserToDeleteRows = false;
            this.gdv_guard_salaries.AllowUserToResizeColumns = false;
            this.gdv_guard_salaries.AllowUserToResizeRows = false;
            this.gdv_guard_salaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guard_salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guard_salaries.Location = new System.Drawing.Point(3, 3);
            this.gdv_guard_salaries.Name = "gdv_guard_salaries";
            this.gdv_guard_salaries.Size = new System.Drawing.Size(517, 592);
            this.gdv_guard_salaries.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 699D;
            this.reSize1.InitialHostContainerWidth = 1111D;
            this.reSize1.Tag = null;
            // 
            // frm_assign_salary_scales_to_guards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1111, 699);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_assign_salary_scales_to_guards";
            this.Text = "Salary scales & Guards Mapping";
            this.Load += new System.EventHandler(this.frm_assign_salary_scales_to_guards_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_salary_scales)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).EndInit();
            this.ResumeLayout(false);

		}

		protected void Return_guard_salary_mappings()
		{
			DataTable dt = Salary_scales.return_guard_salary_mappings("return_manual_guard_salary_scale_mappings");
			if (dt.Rows.Count > 0)
			{
				this.gdv_guard_salaries.DataSource = dt;
				this.gdv_guard_salaries.Columns["full_name"].HeaderText = "Guard Name";
				this.gdv_guard_salaries.Columns["branch"].HeaderText = "Branch";
				this.gdv_guard_salaries.Columns["Duration"].HeaderText = "Duration Served(Years)";
				this.gdv_guard_salaries.Columns["salary_amount"].HeaderText = "Salary Amt";
				this.gdv_guard_salaries.Columns["auto_id"].Visible = false;
				this.gdv_guard_salaries.Columns["guard_number"].Visible = false;
				this.gdv_guard_salaries.Columns["scale_auto_id"].Visible = false;
				this.gdv_guard_salaries.Columns["full_name"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["branch"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["Duration"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["salary_amount"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["full_name"].Width = 200;
				this.gdv_guard_salaries.Columns["salary_amount"].DefaultCellStyle.ForeColor = Color.Blue;
				DataGridViewCheckBoxColumn chk_select_guard = new DataGridViewCheckBoxColumn()
				{
					Name = "column_select",
					HeaderText = "Select Guard",
					FalseValue = 0,
					TrueValue = 1
				};
				this.gdv_guard_salaries.Columns.Insert(0, chk_select_guard);
				this.gdv_guard_salaries.Columns["column_select"].ReadOnly = false;
				this.gdv_guard_salaries.Columns["column_select"].Width = 50;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guard_salaries.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guard_salaries.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_guard_salaries.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_guard_salaries.EnableHeadersVisualStyles = false;
			}
		}

		protected void return_manual_guard_salary_scale_mappings_search()
		{
			DataTable dt = Salary_scales.return_manual_guard_salary_scale_mappings_search("return_manual_guard_salary_scale_mappings_search", this.txt_guard_name.Text, this.cbo_station_name.Text, this.txt_guard_number.Text);
			if (dt.Rows.Count > 0)
			{
				this.gdv_guard_salaries.DataSource = dt;
				this.gdv_guard_salaries.Columns["full_name"].HeaderText = "Guard Name";
				this.gdv_guard_salaries.Columns["branch"].HeaderText = "Branch";
				this.gdv_guard_salaries.Columns["Duration"].HeaderText = "Duration Served(Years)";
				this.gdv_guard_salaries.Columns["salary_amount"].HeaderText = "Salary Amt";
				this.gdv_guard_salaries.Columns["auto_id"].Visible = false;
				this.gdv_guard_salaries.Columns["guard_number"].Visible = false;
				this.gdv_guard_salaries.Columns["scale_auto_id"].Visible = false;
				this.gdv_guard_salaries.Columns["full_name"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["branch"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["Duration"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["salary_amount"].ReadOnly = true;
				this.gdv_guard_salaries.Columns["full_name"].Width = 200;
				this.gdv_guard_salaries.Columns["salary_amount"].DefaultCellStyle.ForeColor = Color.Blue;
				DataGridViewCheckBoxColumn chk_select_guard = new DataGridViewCheckBoxColumn()
				{
					Name = "column_select",
					HeaderText = "Select Guard",
					FalseValue = 0,
					TrueValue = 1
				};
				this.gdv_guard_salaries.Columns.Insert(0, chk_select_guard);
				this.gdv_guard_salaries.Columns["column_select"].ReadOnly = false;
				this.gdv_guard_salaries.Columns["column_select"].Width = 50;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guard_salaries.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guard_salaries.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_guard_salaries.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_guard_salaries.EnableHeadersVisualStyles = false;
			}
		}

		protected void Save_or_update_guard_salary_scale()
		{
			for (int i = 0; i < this.gdv_guard_salaries.Rows.Count; i++)
			{
				if (Convert.ToBoolean(this.gdv_guard_salaries.Rows[i].Cells[0].Value))
				{
                    int previous_scale_id = 0;
                    int guard_auto_id = Convert.ToInt32(this.gdv_guard_salaries.Rows[i].Cells[1].Value.ToString());
					string guard_number = this.gdv_guard_salaries.Rows[i].Cells[3].Value.ToString();

                    if (this.gdv_guard_salaries.Rows[i].Cells[7].Value.ToString() == string.Empty) { previous_scale_id = Convert.ToInt32(this.txt_auto_id.Text);  }
                    else { previous_scale_id = Convert.ToInt32(this.gdv_guard_salaries.Rows[i].Cells[7].Value.ToString()); }
                     
                    int scale_id = Convert.ToInt32(this.txt_auto_id.Text);
					Salary_scales.Salary_scale_manual_assigment_query("salary_scale_manual_assigment_query", guard_auto_id, guard_number, scale_id, SystemConst._username, previous_scale_id);
				}
			}
			MessageBox.Show("All selected guards salary scales succesfully updated", "save scales", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}