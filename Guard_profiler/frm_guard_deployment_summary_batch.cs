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
	public class frm_guard_deployment_summary_batch : Form
	{
		private static bool _is_weekend;

		private static bool _is_public_holiday;

		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private Label label2;

		private Label label5;

		private DateTimePicker dt_deployment_date;

		private Label label1;

		private Label label3;

		private ComboBox cbo_branch;

		private ComboBox cbo_working_shift;

		private Button btn_guard_list;

		private Button btn_update;

		private Button button1;

		private Label label4;

		private Label label6;

		private DateTimePicker dt_start_date;

		private DateTimePicker dt_end_date;

		private Panel panel3;

		private DataGridView gdv_deployment_summary;

		private Label label7;

		private Label label8;

		private TextBox txt_guard_number;

		private Button btn_search;

		//private ReSize reSize1;

		private Button button3;

		private CheckBox chk_apply_to_all;
        private ReSize reSize1;
        private CheckBox chk_save_status;

		static frm_guard_deployment_summary_batch()
		{
		}

		public frm_guard_deployment_summary_batch()
		{
			this.InitializeComponent();
		}

		private void btn_guard_list_Click(object sender, EventArgs e)
		{
			if (this.cbo_branch.Text != string.Empty)
			{
				this.get_list_of_guards_for_batch_deploy();
				return;
			}
			MessageBox.Show("No Branch selected", "Batch Deploy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			this.Save_or_Update_batch_deployment();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Get_list_of_guards_for_selected_deploy_date();
		}

		private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void cbo_working_shift_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_working_shift.Text != string.Empty && this.chk_apply_to_all.Checked)
			{
				this.chk_apply_to_all_CheckedChanged(this.chk_apply_to_all, null);
			}
		}

		private void chk_apply_to_all_CheckedChanged(object sender, EventArgs e)
		{
			if (!(this.chk_apply_to_all.Checked & (this.cbo_working_shift.Text != string.Empty)))
			{
				this.btn_guard_list_Click(this.btn_guard_list, null);
				return;
			}
			for (int i = 0; i < this.gdv_deployment_summary.Rows.Count; i++)
			{
				this.gdv_deployment_summary.Rows[i].Cells[7].Value = this.cbo_working_shift.Text;
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

		private void dt_deployment_date_ValueChanged(object sender, EventArgs e)
		{
			if (this.dt_deployment_date.Value.Date.DayOfWeek == DayOfWeek.Saturday || this.dt_deployment_date.Value.Date.DayOfWeek == DayOfWeek.Sunday)
			{
				frm_guard_deployment_summary_batch._is_weekend = true;
			}
			else
			{
				frm_guard_deployment_summary_batch._is_weekend = false;
			}
			if (Guard_deployment.check_if_deployment_date_is_public_holiday("check_if_deployment_date_is_public_holiday", this.dt_deployment_date.Value.Date) > 0)
			{
				frm_guard_deployment_summary_batch._is_public_holiday = true;
				return;
			}
			frm_guard_deployment_summary_batch._is_public_holiday = false;
		}

		private void frm_guard_deployment_summary_batch_Load(object sender, EventArgs e)
		{
			this.dt_start_date.Value = SystemConst._deployment_start_date;
			this.dt_end_date.Value = SystemConst._deployment_end_date;
			this.Get_guard_shift_types();
			this.GET_BRANCHES();
			base.WindowState = FormWindowState.Maximized;
		}

		private void gdv_deployment_summary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (!this.chk_save_status.Checked)
			{
				MessageBox.Show("Save deployment batch before editing", "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
            //SystemConst._client_codee = this.gdv_deployment_summary.CurrentRow.Cells[4].Value.ToString();
            SystemConst._client_ids = Convert.ToInt32(this.gdv_deployment_summary.CurrentRow.Cells[4].Value.ToString());
            SystemConst._client_location = this.gdv_deployment_summary.CurrentRow.Cells[5].Value.ToString();
            SystemConst._fire_arm_serial = this.gdv_deployment_summary.CurrentRow.Cells[10].Value.ToString();
            SystemConst._ammunition_count = Convert.ToInt32(this.gdv_deployment_summary.CurrentRow.Cells[11].Value.ToString());
            SystemConst._shift_type = this.gdv_deployment_summary.CurrentRow.Cells[6].Value.ToString();
            SystemConst._is_leave_day_for_guard = Convert.ToBoolean(this.gdv_deployment_summary.CurrentRow.Cells[12].Value);
            SystemConst._is_public_holiday = Convert.ToBoolean(this.gdv_deployment_summary.CurrentRow.Cells[13].Value);
            SystemConst._record_guid = this.gdv_deployment_summary.CurrentRow.Cells[14].Value.ToString();
            SystemConst._guard_name = this.gdv_deployment_summary.CurrentRow.Cells[0].Value.ToString();
            SystemConst._branch = this.gdv_deployment_summary.CurrentRow.Cells[8].Value.ToString();

            (new frm_edit_guard_deployment_record()).ShowDialog();
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
				this.cbo_branch.DataSource = dt;
				this.cbo_branch.DisplayMember = "branch";
				this.cbo_branch.ValueMember = "branch_code";
			}
		}

		protected void Get_guard_shift_types()
		{
			DataTable dt = Guard_deployment.Return_guard_shift_types("return_guard_shift_types");
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["shift_name"] = string.Empty;
				dtRow["shift_id"] = -1;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_working_shift.DataSource = dt;
				this.cbo_working_shift.DisplayMember = "shift_name";
				this.cbo_working_shift.ValueMember = "shift_id";
			}
		}

		protected void get_list_of_guards_for_batch_deploy()
		{
			DataTable dt = Guard_deployment.select_list_of_guards_by_branch_and_date_for_batch_deployment("select_list_of_guards_by_branch_and_date_for_batch_deployment", this.cbo_branch.Text);
			if (dt.Rows.Count <= 0)
			{
				this.gdv_deployment_summary.DataSource = dt;
				return;
			}
			DataRow dtRow = dt.Rows[0];
			this.dt_deployment_date.Value = Convert.ToDateTime(dtRow["next_deploy_date"]);
			this.gdv_deployment_summary.DataSource = dt;
			this.gdv_deployment_summary.Columns["deploy_type"].Visible = false;
			this.gdv_deployment_summary.Columns["branch_name"].Visible = false;
			this.gdv_deployment_summary.Columns["guard_auto_id"].Visible = false;
			this.gdv_deployment_summary.Columns["firearm_serial"].Visible = false;
			this.gdv_deployment_summary.Columns["number_of_ammunitions"].Visible = false;
			this.gdv_deployment_summary.Columns["is_leave_day_for_guard"].Visible = false;
			this.gdv_deployment_summary.Columns["is_public_holiday"].Visible = false;
			this.gdv_deployment_summary.Columns["deploy_date"].Visible = false;
			this.gdv_deployment_summary.Columns["is_weekend"].Visible = false;
			this.gdv_deployment_summary.Columns["guard_name"].HeaderText = "Guard";
			this.gdv_deployment_summary.Columns["guard_number"].HeaderText = "Guard Number";
			this.gdv_deployment_summary.Columns["next_deploy_date"].HeaderText = "Day";
			this.gdv_deployment_summary.Columns["client_name"].HeaderText = "Client";
			this.gdv_deployment_summary.Columns["client_code"].HeaderText = "Client Code";
			this.gdv_deployment_summary.Columns["client_location"].HeaderText = "Location";
			this.gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";
			this.gdv_deployment_summary.Columns["guard_name"].Width = 250;
			this.gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;
			foreach (DataGridViewColumn c in this.gdv_deployment_summary.Columns)
			{
				c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
			}
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
			this.gdv_deployment_summary.EnableHeadersVisualStyles = false;
			this.chk_save_status.Checked = false;
		}

		protected void Get_list_of_guards_for_selected_deploy_date()
		{
			if (!this.dt_deployment_date.Checked)
			{
				MessageBox.Show("Select a deployment date", "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text = this.cbo_branch.Text;
			DateTime value = this.dt_deployment_date.Value;
			DataTable dt = Guard_deployment.select_list_of_guards_by_branch_and_date_for_selected_date("select_list_of_guards_by_branch_and_date_for_selected_date", text, value.Date);
			if (dt.Rows.Count <= 0)
			{
				this.gdv_deployment_summary.DataSource = dt;
				return;
			}
			DataRow item = dt.Rows[0];
			this.gdv_deployment_summary.DataSource = dt;
			this.gdv_deployment_summary.Columns["deploy_type"].Visible = false;
			this.gdv_deployment_summary.Columns["branch_name"].Visible = false;
			this.gdv_deployment_summary.Columns["guard_auto_id"].Visible = false;
			this.gdv_deployment_summary.Columns["firearm_serial"].Visible = false;
			this.gdv_deployment_summary.Columns["number_of_ammunitions"].Visible = false;
			this.gdv_deployment_summary.Columns["is_leave_day_for_guard"].Visible = false;
			this.gdv_deployment_summary.Columns["is_public_holiday"].Visible = false;
			this.gdv_deployment_summary.Columns["record_guid"].Visible = false;
			this.gdv_deployment_summary.Columns["is_weekend"].Visible = false;
			this.gdv_deployment_summary.Columns["guard_name"].HeaderText = "Guard";
			this.gdv_deployment_summary.Columns["guard_number"].HeaderText = "Guard Number";
			this.gdv_deployment_summary.Columns["next_deploy_date"].HeaderText = "Day";
			this.gdv_deployment_summary.Columns["client_name"].HeaderText = "Client";
			this.gdv_deployment_summary.Columns["client_code"].HeaderText = "Client Code";
			this.gdv_deployment_summary.Columns["client_location"].HeaderText = "Location";
			this.gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";
			this.gdv_deployment_summary.Columns["guard_name"].Width = 250;
			this.gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;
			foreach (DataGridViewColumn c in this.gdv_deployment_summary.Columns)
			{
				c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
			}
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
			this.gdv_deployment_summary.EnableHeadersVisualStyles = false;
			this.chk_save_status.Checked = true;
		}

        protected void Search_Guards_by_guard_number()
        {
            if (txt_guard_number.Text == string.Empty)
            {
                MessageBox.Show("Guard Number cannot be empty", "Search Guards", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string text = this.cbo_branch.Text;
            DateTime value = this.dt_deployment_date.Value;
            DataTable dt = Guard_deployment.select_list_of_deployed_guards_by_guard_number("select_list_of_deployed_guards_by_guard_number", txt_guard_number.Text);
            if (dt.Rows.Count <= 0)
            {
                this.gdv_deployment_summary.DataSource = dt;
                return;
            }
            DataRow item = dt.Rows[0];
            this.gdv_deployment_summary.DataSource = dt;
            this.gdv_deployment_summary.Columns["deploy_type"].Visible = false;
            this.gdv_deployment_summary.Columns["branch_name"].Visible = false;
            this.gdv_deployment_summary.Columns["guard_auto_id"].Visible = false;
            this.gdv_deployment_summary.Columns["firearm_serial"].Visible = false;
            this.gdv_deployment_summary.Columns["number_of_ammunitions"].Visible = false;
            this.gdv_deployment_summary.Columns["is_leave_day_for_guard"].Visible = false;
            this.gdv_deployment_summary.Columns["is_public_holiday"].Visible = false;
            this.gdv_deployment_summary.Columns["record_guid"].Visible = false;
            this.gdv_deployment_summary.Columns["is_weekend"].Visible = false;
            this.gdv_deployment_summary.Columns["guard_name"].HeaderText = "Guard";
            this.gdv_deployment_summary.Columns["guard_number"].HeaderText = "Guard";
            this.gdv_deployment_summary.Columns["next_deploy_date"].HeaderText = "Day";
            this.gdv_deployment_summary.Columns["client_name"].HeaderText = "Client";
            this.gdv_deployment_summary.Columns["client_code"].HeaderText = "Client Code";
            this.gdv_deployment_summary.Columns["client_location"].HeaderText = "Location";
            this.gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";
            this.gdv_deployment_summary.Columns["guard_name"].Width = 250;
            this.gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            this.gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;
            foreach (DataGridViewColumn c in this.gdv_deployment_summary.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
            }
            this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdv_deployment_summary.EnableHeadersVisualStyles = false;
            this.chk_save_status.Checked = true;
        }

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_deployment_summary_batch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_save_status = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdv_deployment_summary = new System.Windows.Forms.DataGridView();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_apply_to_all = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_guard_list = new System.Windows.Forms.Button();
            this.cbo_working_shift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_deployment_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_summary)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.chk_save_status);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_guard_number);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dt_end_date);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_start_date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 703);
            this.panel1.TabIndex = 0;
            // 
            // chk_save_status
            // 
            this.chk_save_status.AutoSize = true;
            this.chk_save_status.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chk_save_status.ForeColor = System.Drawing.Color.Black;
            this.chk_save_status.Location = new System.Drawing.Point(916, 107);
            this.chk_save_status.Margin = new System.Windows.Forms.Padding(4);
            this.chk_save_status.Name = "chk_save_status";
            this.chk_save_status.Size = new System.Drawing.Size(205, 21);
            this.chk_save_status.TabIndex = 36;
            this.chk_save_status.Text = "Records saved successfully";
            this.chk_save_status.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_search.Location = new System.Drawing.Point(448, 100);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(279, 105);
            this.txt_guard_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(160, 24);
            this.txt_guard_number.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Guard Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Search Guards";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.gdv_deployment_summary);
            this.panel3.Location = new System.Drawing.Point(13, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 560);
            this.panel3.TabIndex = 9;
            // 
            // gdv_deployment_summary
            // 
            this.gdv_deployment_summary.AllowUserToAddRows = false;
            this.gdv_deployment_summary.AllowUserToDeleteRows = false;
            this.gdv_deployment_summary.AllowUserToResizeColumns = false;
            this.gdv_deployment_summary.AllowUserToResizeRows = false;
            this.gdv_deployment_summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_deployment_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_deployment_summary.Location = new System.Drawing.Point(4, 4);
            this.gdv_deployment_summary.Margin = new System.Windows.Forms.Padding(4);
            this.gdv_deployment_summary.Name = "gdv_deployment_summary";
            this.gdv_deployment_summary.Size = new System.Drawing.Size(1140, 553);
            this.gdv_deployment_summary.TabIndex = 1;
            this.gdv_deployment_summary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_deployment_summary_CellDoubleClick);
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(883, 4);
            this.dt_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(155, 24);
            this.dt_end_date.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "To";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start_date.Location = new System.Drawing.Point(648, 4);
            this.dt_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(169, 24);
            this.dt_start_date.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Deployment Period From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deploy Guards";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.chk_apply_to_all);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_guard_list);
            this.panel2.Controls.Add(this.cbo_working_shift);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbo_branch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dt_deployment_date);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 63);
            this.panel2.TabIndex = 0;
            // 
            // chk_apply_to_all
            // 
            this.chk_apply_to_all.AutoSize = true;
            this.chk_apply_to_all.BackColor = System.Drawing.Color.Lime;
            this.chk_apply_to_all.Location = new System.Drawing.Point(520, 33);
            this.chk_apply_to_all.Margin = new System.Windows.Forms.Padding(4);
            this.chk_apply_to_all.Name = "chk_apply_to_all";
            this.chk_apply_to_all.Size = new System.Drawing.Size(99, 21);
            this.chk_apply_to_all.TabIndex = 35;
            this.chk_apply_to_all.Text = "Apply to all";
            this.chk_apply_to_all.UseVisualStyleBackColor = false;
            this.chk_apply_to_all.CheckedChanged += new System.EventHandler(this.chk_apply_to_all_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(771, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 46);
            this.button3.TabIndex = 34;
            this.button3.Text = "Load Guard List for selected date";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(1069, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 33;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Lime;
            this.btn_update.Location = new System.Drawing.Point(920, 14);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(152, 46);
            this.btn_update.TabIndex = 32;
            this.btn_update.Text = "Save Deployment";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_guard_list
            // 
            this.btn_guard_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_guard_list.Location = new System.Drawing.Point(621, 14);
            this.btn_guard_list.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guard_list.Name = "btn_guard_list";
            this.btn_guard_list.Size = new System.Drawing.Size(152, 46);
            this.btn_guard_list.TabIndex = 31;
            this.btn_guard_list.Text = "Load Guard List for next deployment";
            this.btn_guard_list.UseVisualStyleBackColor = false;
            this.btn_guard_list.Click += new System.EventHandler(this.btn_guard_list_Click);
            // 
            // cbo_working_shift
            // 
            this.cbo_working_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_working_shift.FormattingEnabled = true;
            this.cbo_working_shift.Location = new System.Drawing.Point(411, 28);
            this.cbo_working_shift.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_working_shift.Name = "cbo_working_shift";
            this.cbo_working_shift.Size = new System.Drawing.Size(107, 26);
            this.cbo_working_shift.TabIndex = 30;
            this.cbo_working_shift.SelectedIndexChanged += new System.EventHandler(this.cbo_working_shift_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Shift";
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(195, 26);
            this.cbo_branch.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(207, 26);
            this.cbo_branch.TabIndex = 13;
            this.cbo_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_branch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Station";
            // 
            // dt_deployment_date
            // 
            this.dt_deployment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_deployment_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_deployment_date.Location = new System.Drawing.Point(4, 26);
            this.dt_deployment_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_deployment_date.Name = "dt_deployment_date";
            this.dt_deployment_date.ShowCheckBox = true;
            this.dt_deployment_date.Size = new System.Drawing.Size(179, 24);
            this.dt_deployment_date.TabIndex = 5;
            this.dt_deployment_date.ValueChanged += new System.EventHandler(this.dt_deployment_date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deployment Date";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 709D;
            this.reSize1.InitialHostContainerWidth = 1169D;
            this.reSize1.Tag = null;
            // 
            // frm_guard_deployment_summary_batch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1169, 709);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_guard_deployment_summary_batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Uganda Securiko Ltd-Guard Deployment";
            this.Load += new System.EventHandler(this.frm_guard_deployment_summary_batch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_summary)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		protected void Save_or_Update_batch_deployment()
		{
			if (this.gdv_deployment_summary.Rows.Count > 0)
			{
				System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("This might take a while.Save Batch Deploy?", " Batch Deploy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					for (int i = 0; i < this.gdv_deployment_summary.Rows.Count; i++)
					{
						string guard_number = this.gdv_deployment_summary.Rows[i].Cells[1].Value.ToString();
						string guard_name = this.gdv_deployment_summary.Rows[i].Cells[0].Value.ToString();
						DateTime deployment_date = Convert.ToDateTime(this.gdv_deployment_summary.Rows[i].Cells[2].Value);
						string deploy_type = this.gdv_deployment_summary.Rows[i].Cells[8].Value.ToString();
						string branch_name = this.gdv_deployment_summary.Rows[i].Cells[9].Value.ToString();
						string client_code = this.gdv_deployment_summary.Rows[i].Cells[5].Value.ToString();
						string client_location = this.gdv_deployment_summary.Rows[i].Cells[6].Value.ToString();
						string fire_arm_serial = this.gdv_deployment_summary.Rows[i].Cells[11].Value.ToString();
						int ammunition_count = Convert.ToInt32(this.gdv_deployment_summary.Rows[i].Cells[12].Value.ToString());
						string shift_type = this.gdv_deployment_summary.Rows[i].Cells[7].Value.ToString();
						bool is_leave_day_for_guard = Convert.ToBoolean(this.gdv_deployment_summary.Rows[i].Cells[13].Value);
						DateTime date = this.dt_start_date.Value.Date;
						DateTime value = this.dt_end_date.Value;
						Guard_deployment.Save_new_deployment_record("save_new_deployment_record", date, value.Date, SystemConst._username, guard_number, deployment_date, deploy_type, branch_name, client_code, client_location, guard_name, fire_arm_serial, ammunition_count, shift_type, is_leave_day_for_guard, frm_guard_deployment_summary_batch._is_public_holiday, frm_guard_deployment_summary_batch._is_weekend);
                        Guard_deployment.Save_deployment_schedule(deployment_date, Convert.ToInt32(SystemConst._active_deployment_id), guard_number);
                    }
				}
				else if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
				}
				MessageBox.Show(string.Concat("Successfully deployed all guards in ", this.cbo_branch.Text, " for this date"), "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.chk_save_status.Checked = true;
			}
		}

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search_Guards_by_guard_number();
        }
    }
}