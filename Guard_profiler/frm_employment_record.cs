using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_employment_record : Form
	{
		private IContainer components;

		//private ReSize reSize1;

		private Panel panel1;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel panel3;

		private Panel panel_details;

		private Panel panel2;

		private DataGridView gdv_guards;

		private Button btn_present_adress;

		private Button btn_origin_adress;

		private Button btn_father_details;

		private Button btn_children;

		private Button btn_relatives;

		private Button btn_prev_employer;

		private Button btn_refferees;

		private Button btn_education_history;

		private Button button8;

		private GroupBox grpbox_personal_data;

		private Label label13;

		private TextBox txt_name;

		private Label label1;

		private ComboBox cbo_nationality;

		private Label label2;

		private Label label3;

		private ComboBox cbo_religion;

		private ComboBox cbo_gender;

		private Label label4;

		private ComboBox cbo_tribe;

		private Label label5;

		private Panel panel5;

		private DateTimePicker dt_birthdate;

		private CheckBox chk_birthdate;

		private Label label6;

		private TextBox txt_birth_place;

		private Label label7;

		private TextBox txt_phone_primary;

		private Label label8;

		private TextBox txt_phone_secondary;

		private Label label9;

		private TextBox txt_national_id_number;

		private Button btn_attach_nin;

		private GroupBox grpbox_marital_status;

		private Label label10;

		private Label label11;

		private ComboBox cbo_marital_status;

		private TextBox txt_partner_birth_place;

		private Label label12;

		private TextBox txt_partner_name;

		private Label label14;

		private TextBox txt_partner_parents_names;

		private Label label15;

		private TextBox txt_partners_residential_adres;

		private Label label16;

		private TextBox txt_partner_phone;

		private Button btnsave;

		private Button btnEdit;

		private Label label17;

		private TextBox txt_guard_number;

		private TextBox txt_record_guid;

		private Button btntest_report;

		private Panel panel4;

		private Label label44;

		private Label label43;

		private Button btn_branch_search;

		private Button btn_name_search;

		private ComboBox cbo_branch_search;
        private ReSize reSize1;
        private RichTextBox txt_name_search;

		public frm_employment_record()
		{
			this.InitializeComponent();
		}

		private void btn_branch_search_Click(object sender, EventArgs e)
		{
			if (this.cbo_branch_search.Text == string.Empty)
			{
				this.GET_GUARD_LIST();
			}
			else
			{
				DataTable dt = sg_Profiles.SEARCH_GUARDS_BY_BRANCH("SEARCH_GUARDS_BY_BRANCH_EMP_RECORD_FORM", this.cbo_branch_search.Text);
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.Columns[1].HeaderText = "NAME";
					this.gdv_guards.Columns[2].HeaderText = "BRANCH";
					this.gdv_guards.Columns[3].HeaderText = "DEPARTMENT";
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
					this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					return;
				}
			}
		}

		private void btn_children_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_children()).ShowDialog();
		}

		private void btn_education_history_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_education_history()).ShowDialog();
		}

		private void btn_father_details_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_father_details()).ShowDialog();
		}

		private void btn_name_search_Click(object sender, EventArgs e)
		{
			if (this.txt_name_search.Text == string.Empty)
			{
				this.GET_GUARD_LIST();
			}
			else
			{
				DataTable dt = sg_Profiles.RETURN_SEARCH_RESULTS("RETURN_SEARCH_RESULTS_EMP_RECORD_BY_NAME", this.txt_name_search.Text);
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.Columns[1].HeaderText = "NAME";
					this.gdv_guards.Columns[2].HeaderText = "BRANCH";
					this.gdv_guards.Columns[3].HeaderText = "DEPARTMENT";
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
					this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					return;
				}
			}
		}

		private void btn_origin_adress_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_home_adress_of_origin()).ShowDialog();
		}

		private void btn_present_adress_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_current_residential_adress()).ShowDialog();
		}

		private void btn_prev_employer_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_prev_employer()).ShowDialog();
		}

		private void btn_refferees_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_referees()).ShowDialog();
		}

		private void btn_relatives_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_relatives()).ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_OR_INSERT_GUARD_EMP_RECORD_HEADER("UPDATE_OR_INSERT_GUARD_EMP_RECORD_HEADER", this.txt_guard_number.Text, this.cbo_nationality.Text, this.cbo_tribe.Text, this.txt_phone_primary.Text, this.txt_phone_secondary.Text, this.txt_national_id_number.Text, this.txt_partner_birth_place.Text, this.txt_partner_parents_names.Text, this.txt_partners_residential_adres.Text, this.txt_partner_phone.Text);
			MessageBox.Show("Guard profile has been updated");
		}

		private void btntest_report_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Select an officer to view report");
				return;
			}
			SystemConst.guard_number = this.txt_guard_number.Text;
			(new frm_employment_record_report()).Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Please select a guard from the list");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = this.txt_name.Text;
			(new frm_other_info()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_employment_record_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.GET_GUARD_LIST();
			this.GET_BRANCHES();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_guards.Rows.Count != 0)
			{
				string record_guid = this.gdv_guards.CurrentRow.Cells[0].Value.ToString();
				string guard_number = this.gdv_guards.CurrentRow.Cells[1].Value.ToString();
				SystemConst.record_guid = record_guid;
				this.RETURN_GUARD_DETAILS(guard_number);
				this.GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", record_guid);
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
				this.cbo_branch_search.DataSource = dt;
				this.cbo_branch_search.DisplayMember = "branch";
				this.cbo_branch_search.ValueMember = "branch_code";
			}
		}

		protected void GET_GUARD_LIST()
		{
			try
			{
				DataTable dt = sg_Profiles.RETURN_OFFICER_LIST("SELECT_GUARD_LIST_FOR_EMPLOYMENT_RECORDS_FORM");
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.Columns[1].Visible = false;
					this.gdv_guards.Columns[2].HeaderText = "NAME";
					this.gdv_guards.Columns[3].HeaderText = "BRANCH";
					this.gdv_guards.Columns[4].HeaderText = "DEPARTMENT";
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
					this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}

		protected void GET_OFFICER_HEADSHOT(string query, string record_guid)
		{
			DataTable dt = HeadShotEngine.SELECT_OFFICER_HEAD_SHOT(query, record_guid);
			if (dt == null || dt.Rows.Count == 0)
			{
				this.picBoxImage.Image = null;
			}
			else
			{
				DataRow dtRow = dt.Rows[0];
				if (dtRow["image_data"] != DBNull.Value)
				{
					MemoryStream stream = new MemoryStream((byte[])dtRow["image_data"]);
					this.picBoxImage.Image = Image.FromStream(stream);
					return;
				}
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employment_record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_branch_search = new System.Windows.Forms.Button();
            this.btn_name_search = new System.Windows.Forms.Button();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.txt_name_search = new System.Windows.Forms.RichTextBox();
            this.btntest_report = new System.Windows.Forms.Button();
            this.txt_record_guid = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel_details = new System.Windows.Forms.Panel();
            this.grpbox_marital_status = new System.Windows.Forms.GroupBox();
            this.txt_partner_phone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_partners_residential_adres = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_partner_parents_names = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_partner_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_partner_birth_place = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_marital_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpbox_personal_data = new System.Windows.Forms.GroupBox();
            this.btn_attach_nin = new System.Windows.Forms.Button();
            this.txt_national_id_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_phone_secondary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone_primary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_birth_place = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dt_birthdate = new System.Windows.Forms.DateTimePicker();
            this.chk_birthdate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_tribe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_religion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_nationality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_education_history = new System.Windows.Forms.Button();
            this.btn_refferees = new System.Windows.Forms.Button();
            this.btn_prev_employer = new System.Windows.Forms.Button();
            this.btn_relatives = new System.Windows.Forms.Button();
            this.btn_children = new System.Windows.Forms.Button();
            this.btn_father_details = new System.Windows.Forms.Button();
            this.btn_origin_adress = new System.Windows.Forms.Button();
            this.btn_present_adress = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.grpbox_marital_status.SuspendLayout();
            this.grpbox_personal_data.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btntest_report);
            this.panel1.Controls.Add(this.txt_record_guid);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txt_guard_number);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.panel_details);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 745);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label44);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.btn_branch_search);
            this.panel4.Controls.Add(this.btn_name_search);
            this.panel4.Controls.Add(this.cbo_branch_search);
            this.panel4.Controls.Add(this.txt_name_search);
            this.panel4.Location = new System.Drawing.Point(741, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 100);
            this.panel4.TabIndex = 58;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Yellow;
            this.label44.Location = new System.Drawing.Point(7, 52);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(130, 13);
            this.label44.TabIndex = 62;
            this.label44.Text = "Select a Branch to search";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Yellow;
            this.label43.Location = new System.Drawing.Point(7, 5);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(120, 13);
            this.label43.TabIndex = 61;
            this.label43.Text = "Enter First or Last Name";
            // 
            // btn_branch_search
            // 
            this.btn_branch_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_branch_search.Location = new System.Drawing.Point(219, 65);
            this.btn_branch_search.Name = "btn_branch_search";
            this.btn_branch_search.Size = new System.Drawing.Size(65, 28);
            this.btn_branch_search.TabIndex = 60;
            this.btn_branch_search.Text = "Search";
            this.btn_branch_search.UseVisualStyleBackColor = false;
            this.btn_branch_search.Click += new System.EventHandler(this.btn_branch_search_Click);
            // 
            // btn_name_search
            // 
            this.btn_name_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_name_search.Location = new System.Drawing.Point(219, 19);
            this.btn_name_search.Name = "btn_name_search";
            this.btn_name_search.Size = new System.Drawing.Size(65, 28);
            this.btn_name_search.TabIndex = 59;
            this.btn_name_search.Text = "Search";
            this.btn_name_search.UseVisualStyleBackColor = false;
            this.btn_name_search.Click += new System.EventHandler(this.btn_name_search_Click);
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(7, 65);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(210, 28);
            this.cbo_branch_search.TabIndex = 58;
            // 
            // txt_name_search
            // 
            this.txt_name_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_search.Location = new System.Drawing.Point(7, 21);
            this.txt_name_search.Name = "txt_name_search";
            this.txt_name_search.Size = new System.Drawing.Size(210, 26);
            this.txt_name_search.TabIndex = 57;
            this.txt_name_search.Text = "";
            // 
            // btntest_report
            // 
            this.btntest_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btntest_report.Location = new System.Drawing.Point(1041, 115);
            this.btntest_report.Name = "btntest_report";
            this.btntest_report.Size = new System.Drawing.Size(136, 47);
            this.btntest_report.TabIndex = 45;
            this.btntest_report.Text = "Employment Record Report";
            this.btntest_report.UseVisualStyleBackColor = false;
            this.btntest_report.Click += new System.EventHandler(this.btntest_report_Click);
            // 
            // txt_record_guid
            // 
            this.txt_record_guid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_record_guid.Location = new System.Drawing.Point(3, 718);
            this.txt_record_guid.Name = "txt_record_guid";
            this.txt_record_guid.ReadOnly = true;
            this.txt_record_guid.Size = new System.Drawing.Size(479, 22);
            this.txt_record_guid.TabIndex = 44;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(482, 674);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(599, 673);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 45);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "SAVE DETAILS";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(106, 71);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.ReadOnly = true;
            this.txt_guard_number.Size = new System.Drawing.Size(181, 24);
            this.txt_guard_number.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(4, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "Guard Number";
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.Azure;
            this.panel_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_details.Controls.Add(this.grpbox_marital_status);
            this.panel_details.Controls.Add(this.grpbox_personal_data);
            this.panel_details.Location = new System.Drawing.Point(7, 97);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(708, 563);
            this.panel_details.TabIndex = 37;
            // 
            // grpbox_marital_status
            // 
            this.grpbox_marital_status.Controls.Add(this.txt_partner_phone);
            this.grpbox_marital_status.Controls.Add(this.label16);
            this.grpbox_marital_status.Controls.Add(this.txt_partners_residential_adres);
            this.grpbox_marital_status.Controls.Add(this.label15);
            this.grpbox_marital_status.Controls.Add(this.txt_partner_parents_names);
            this.grpbox_marital_status.Controls.Add(this.label14);
            this.grpbox_marital_status.Controls.Add(this.txt_partner_name);
            this.grpbox_marital_status.Controls.Add(this.label12);
            this.grpbox_marital_status.Controls.Add(this.txt_partner_birth_place);
            this.grpbox_marital_status.Controls.Add(this.label11);
            this.grpbox_marital_status.Controls.Add(this.cbo_marital_status);
            this.grpbox_marital_status.Controls.Add(this.label10);
            this.grpbox_marital_status.Location = new System.Drawing.Point(3, 327);
            this.grpbox_marital_status.Name = "grpbox_marital_status";
            this.grpbox_marital_status.Size = new System.Drawing.Size(698, 205);
            this.grpbox_marital_status.TabIndex = 1;
            this.grpbox_marital_status.TabStop = false;
            this.grpbox_marital_status.Text = "Guard Marital Status";
            // 
            // txt_partner_phone
            // 
            this.txt_partner_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partner_phone.Location = new System.Drawing.Point(9, 175);
            this.txt_partner_phone.Name = "txt_partner_phone";
            this.txt_partner_phone.Size = new System.Drawing.Size(280, 24);
            this.txt_partner_phone.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(6, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "Partner\'s Phone contact";
            // 
            // txt_partners_residential_adres
            // 
            this.txt_partners_residential_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partners_residential_adres.Location = new System.Drawing.Point(295, 129);
            this.txt_partners_residential_adres.Name = "txt_partners_residential_adres";
            this.txt_partners_residential_adres.Size = new System.Drawing.Size(334, 24);
            this.txt_partners_residential_adres.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(292, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "Partner\'s Residential Adress";
            // 
            // txt_partner_parents_names
            // 
            this.txt_partner_parents_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partner_parents_names.Location = new System.Drawing.Point(9, 129);
            this.txt_partner_parents_names.Name = "txt_partner_parents_names";
            this.txt_partner_parents_names.Size = new System.Drawing.Size(280, 24);
            this.txt_partner_parents_names.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "Partner\'s Parents Names";
            // 
            // txt_partner_name
            // 
            this.txt_partner_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partner_name.Location = new System.Drawing.Point(9, 83);
            this.txt_partner_name.Name = "txt_partner_name";
            this.txt_partner_name.ReadOnly = true;
            this.txt_partner_name.Size = new System.Drawing.Size(280, 24);
            this.txt_partner_name.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(295, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Partner\'s place of birth";
            // 
            // txt_partner_birth_place
            // 
            this.txt_partner_birth_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partner_birth_place.Location = new System.Drawing.Point(295, 83);
            this.txt_partner_birth_place.Name = "txt_partner_birth_place";
            this.txt_partner_birth_place.Size = new System.Drawing.Size(334, 24);
            this.txt_partner_birth_place.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(9, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Partner\'s Name";
            // 
            // cbo_marital_status
            // 
            this.cbo_marital_status.Enabled = false;
            this.cbo_marital_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_marital_status.FormattingEnabled = true;
            this.cbo_marital_status.Location = new System.Drawing.Point(9, 35);
            this.cbo_marital_status.Name = "cbo_marital_status";
            this.cbo_marital_status.Size = new System.Drawing.Size(160, 26);
            this.cbo_marital_status.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Marital Status";
            // 
            // grpbox_personal_data
            // 
            this.grpbox_personal_data.Controls.Add(this.btn_attach_nin);
            this.grpbox_personal_data.Controls.Add(this.txt_national_id_number);
            this.grpbox_personal_data.Controls.Add(this.label9);
            this.grpbox_personal_data.Controls.Add(this.txt_phone_secondary);
            this.grpbox_personal_data.Controls.Add(this.label8);
            this.grpbox_personal_data.Controls.Add(this.txt_phone_primary);
            this.grpbox_personal_data.Controls.Add(this.label7);
            this.grpbox_personal_data.Controls.Add(this.txt_birth_place);
            this.grpbox_personal_data.Controls.Add(this.label6);
            this.grpbox_personal_data.Controls.Add(this.panel5);
            this.grpbox_personal_data.Controls.Add(this.label5);
            this.grpbox_personal_data.Controls.Add(this.cbo_gender);
            this.grpbox_personal_data.Controls.Add(this.label4);
            this.grpbox_personal_data.Controls.Add(this.cbo_tribe);
            this.grpbox_personal_data.Controls.Add(this.label3);
            this.grpbox_personal_data.Controls.Add(this.cbo_religion);
            this.grpbox_personal_data.Controls.Add(this.label2);
            this.grpbox_personal_data.Controls.Add(this.cbo_nationality);
            this.grpbox_personal_data.Controls.Add(this.label1);
            this.grpbox_personal_data.Controls.Add(this.txt_name);
            this.grpbox_personal_data.Controls.Add(this.label13);
            this.grpbox_personal_data.Location = new System.Drawing.Point(3, 12);
            this.grpbox_personal_data.Name = "grpbox_personal_data";
            this.grpbox_personal_data.Size = new System.Drawing.Size(698, 309);
            this.grpbox_personal_data.TabIndex = 0;
            this.grpbox_personal_data.TabStop = false;
            this.grpbox_personal_data.Text = "Personal Data";
            // 
            // btn_attach_nin
            // 
            this.btn_attach_nin.Location = new System.Drawing.Point(241, 279);
            this.btn_attach_nin.Name = "btn_attach_nin";
            this.btn_attach_nin.Size = new System.Drawing.Size(48, 25);
            this.btn_attach_nin.TabIndex = 42;
            this.btn_attach_nin.Text = "Attach";
            this.btn_attach_nin.UseVisualStyleBackColor = true;
            // 
            // txt_national_id_number
            // 
            this.txt_national_id_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_national_id_number.Location = new System.Drawing.Point(9, 279);
            this.txt_national_id_number.Name = "txt_national_id_number";
            this.txt_national_id_number.Size = new System.Drawing.Size(232, 24);
            this.txt_national_id_number.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(9, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "National ID Number(NIN)";
            // 
            // txt_phone_secondary
            // 
            this.txt_phone_secondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_secondary.Location = new System.Drawing.Point(244, 234);
            this.txt_phone_secondary.Name = "txt_phone_secondary";
            this.txt_phone_secondary.Size = new System.Drawing.Size(244, 24);
            this.txt_phone_secondary.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(239, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Phone-Secondary";
            // 
            // txt_phone_primary
            // 
            this.txt_phone_primary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone_primary.Location = new System.Drawing.Point(9, 234);
            this.txt_phone_primary.Name = "txt_phone_primary";
            this.txt_phone_primary.Size = new System.Drawing.Size(232, 24);
            this.txt_phone_primary.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Phone-Primary";
            // 
            // txt_birth_place
            // 
            this.txt_birth_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birth_place.Location = new System.Drawing.Point(244, 180);
            this.txt_birth_place.Name = "txt_birth_place";
            this.txt_birth_place.ReadOnly = true;
            this.txt_birth_place.Size = new System.Drawing.Size(241, 24);
            this.txt_birth_place.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(239, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Place of Birth";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.dt_birthdate);
            this.panel5.Controls.Add(this.chk_birthdate);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(9, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 34);
            this.panel5.TabIndex = 33;
            // 
            // dt_birthdate
            // 
            this.dt_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_birthdate.Location = new System.Drawing.Point(24, 6);
            this.dt_birthdate.Name = "dt_birthdate";
            this.dt_birthdate.Size = new System.Drawing.Size(205, 24);
            this.dt_birthdate.TabIndex = 4;
            // 
            // chk_birthdate
            // 
            this.chk_birthdate.AutoSize = true;
            this.chk_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_birthdate.ForeColor = System.Drawing.Color.Red;
            this.chk_birthdate.Location = new System.Drawing.Point(3, 12);
            this.chk_birthdate.Name = "chk_birthdate";
            this.chk_birthdate.Size = new System.Drawing.Size(15, 14);
            this.chk_birthdate.TabIndex = 4;
            this.chk_birthdate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Date of Birth";
            // 
            // cbo_gender
            // 
            this.cbo_gender.Enabled = false;
            this.cbo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "",
            "Male ",
            "Female"});
            this.cbo_gender.Location = new System.Drawing.Point(242, 130);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(160, 26);
            this.cbo_gender.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(239, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gender";
            // 
            // cbo_tribe
            // 
            this.cbo_tribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tribe.FormattingEnabled = true;
            this.cbo_tribe.Location = new System.Drawing.Point(242, 82);
            this.cbo_tribe.Name = "cbo_tribe";
            this.cbo_tribe.Size = new System.Drawing.Size(246, 26);
            this.cbo_tribe.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Religion";
            // 
            // cbo_religion
            // 
            this.cbo_religion.Enabled = false;
            this.cbo_religion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_religion.FormattingEnabled = true;
            this.cbo_religion.Location = new System.Drawing.Point(9, 130);
            this.cbo_religion.Name = "cbo_religion";
            this.cbo_religion.Size = new System.Drawing.Size(227, 26);
            this.cbo_religion.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nationality";
            // 
            // cbo_nationality
            // 
            this.cbo_nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nationality.FormattingEnabled = true;
            this.cbo_nationality.Location = new System.Drawing.Point(9, 82);
            this.cbo_nationality.Name = "cbo_nationality";
            this.cbo_nationality.Size = new System.Drawing.Size(227, 26);
            this.cbo_nationality.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(239, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tribe";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(9, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(479, 24);
            this.txt_name.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdv_guards);
            this.panel2.Location = new System.Drawing.Point(741, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 574);
            this.panel2.TabIndex = 36;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(3, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.ReadOnly = true;
            this.gdv_guards.Size = new System.Drawing.Size(611, 568);
            this.gdv_guards.TabIndex = 1;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.btn_education_history);
            this.panel3.Controls.Add(this.btn_refferees);
            this.panel3.Controls.Add(this.btn_prev_employer);
            this.panel3.Controls.Add(this.btn_relatives);
            this.panel3.Controls.Add(this.btn_children);
            this.panel3.Controls.Add(this.btn_father_details);
            this.panel3.Controls.Add(this.btn_origin_adress);
            this.panel3.Controls.Add(this.btn_present_adress);
            this.panel3.Location = new System.Drawing.Point(7, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 60);
            this.panel3.TabIndex = 35;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1057, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "Other Official Info";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_education_history
            // 
            this.btn_education_history.Location = new System.Drawing.Point(944, 1);
            this.btn_education_history.Name = "btn_education_history";
            this.btn_education_history.Size = new System.Drawing.Size(112, 54);
            this.btn_education_history.TabIndex = 7;
            this.btn_education_history.Text = "Education History";
            this.btn_education_history.UseVisualStyleBackColor = true;
            this.btn_education_history.Click += new System.EventHandler(this.btn_education_history_Click);
            // 
            // btn_refferees
            // 
            this.btn_refferees.Location = new System.Drawing.Point(829, 1);
            this.btn_refferees.Name = "btn_refferees";
            this.btn_refferees.Size = new System.Drawing.Size(112, 54);
            this.btn_refferees.TabIndex = 6;
            this.btn_refferees.Text = "Update Guard Referees";
            this.btn_refferees.UseVisualStyleBackColor = true;
            this.btn_refferees.Click += new System.EventHandler(this.btn_refferees_Click);
            // 
            // btn_prev_employer
            // 
            this.btn_prev_employer.Location = new System.Drawing.Point(714, 1);
            this.btn_prev_employer.Name = "btn_prev_employer";
            this.btn_prev_employer.Size = new System.Drawing.Size(112, 54);
            this.btn_prev_employer.TabIndex = 5;
            this.btn_prev_employer.Text = "Previous Employer Details";
            this.btn_prev_employer.UseVisualStyleBackColor = true;
            this.btn_prev_employer.Click += new System.EventHandler(this.btn_prev_employer_Click);
            // 
            // btn_relatives
            // 
            this.btn_relatives.Location = new System.Drawing.Point(600, 1);
            this.btn_relatives.Name = "btn_relatives";
            this.btn_relatives.Size = new System.Drawing.Size(112, 54);
            this.btn_relatives.TabIndex = 4;
            this.btn_relatives.Text = "Relatives and Next of Kin";
            this.btn_relatives.UseVisualStyleBackColor = true;
            this.btn_relatives.Click += new System.EventHandler(this.btn_relatives_Click);
            // 
            // btn_children
            // 
            this.btn_children.Location = new System.Drawing.Point(487, 1);
            this.btn_children.Name = "btn_children";
            this.btn_children.Size = new System.Drawing.Size(112, 54);
            this.btn_children.TabIndex = 3;
            this.btn_children.Text = "Update Children Details";
            this.btn_children.UseVisualStyleBackColor = true;
            this.btn_children.Click += new System.EventHandler(this.btn_children_Click);
            // 
            // btn_father_details
            // 
            this.btn_father_details.Location = new System.Drawing.Point(373, 1);
            this.btn_father_details.Name = "btn_father_details";
            this.btn_father_details.Size = new System.Drawing.Size(112, 54);
            this.btn_father_details.TabIndex = 2;
            this.btn_father_details.Text = "Update Father\'s Details";
            this.btn_father_details.UseVisualStyleBackColor = true;
            this.btn_father_details.Click += new System.EventHandler(this.btn_father_details_Click);
            // 
            // btn_origin_adress
            // 
            this.btn_origin_adress.Location = new System.Drawing.Point(190, 1);
            this.btn_origin_adress.Name = "btn_origin_adress";
            this.btn_origin_adress.Size = new System.Drawing.Size(181, 54);
            this.btn_origin_adress.TabIndex = 1;
            this.btn_origin_adress.Text = "Update Home Adress of Origin";
            this.btn_origin_adress.UseVisualStyleBackColor = true;
            this.btn_origin_adress.Click += new System.EventHandler(this.btn_origin_adress_Click);
            // 
            // btn_present_adress
            // 
            this.btn_present_adress.Location = new System.Drawing.Point(3, 1);
            this.btn_present_adress.Name = "btn_present_adress";
            this.btn_present_adress.Size = new System.Drawing.Size(181, 54);
            this.btn_present_adress.TabIndex = 0;
            this.btn_present_adress.Text = "Update Current Residential Adress Details";
            this.btn_present_adress.UseVisualStyleBackColor = true;
            this.btn_present_adress.Click += new System.EventHandler(this.btn_present_adress_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.picBoxImage);
            this.panel9.Location = new System.Drawing.Point(1208, -2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(155, 143);
            this.panel9.TabIndex = 33;
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Location = new System.Drawing.Point(3, 3);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(145, 133);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 0;
            this.picBoxImage.TabStop = false;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 749D;
            this.reSize1.InitialHostContainerWidth = 1370D;
            this.reSize1.Tag = null;
            // 
            // frm_employment_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_employment_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUARD EMPLOYMENT RECORDS";
            this.Load += new System.EventHandler(this.frm_employment_record_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_details.ResumeLayout(false);
            this.grpbox_marital_status.ResumeLayout(false);
            this.grpbox_marital_status.PerformLayout();
            this.grpbox_personal_data.ResumeLayout(false);
            this.grpbox_personal_data.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);

		}

		protected void RETURN_GUARD_DETAILS(string guard_number)
		{
			DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				this.txt_guard_number.Text = (dtRow["guard_number"] != DBNull.Value ? (string)dtRow["guard_number"] : string.Empty);
				this.txt_name.Text = (dtRow["full_name"] != DBNull.Value ? (string)dtRow["full_name"] : string.Empty);
				this.cbo_religion.Text = (dtRow["religion"] != DBNull.Value ? (string)dtRow["religion"] : string.Empty);
				this.cbo_gender.Text = (dtRow["gender"] != DBNull.Value ? (string)dtRow["gender"] : string.Empty);
				this.dt_birthdate.Value = (dtRow["dob"] != DBNull.Value ? Convert.ToDateTime(dtRow["dob"]) : DateTime.Today);
				this.txt_birth_place.Text = (dtRow["birth_place"] != DBNull.Value ? (string)dtRow["birth_place"] : string.Empty);
				this.cbo_nationality.Text = (dtRow["nationality"] != DBNull.Value ? (string)dtRow["nationality"] : string.Empty);
				this.cbo_tribe.Text = (dtRow["tribe"] != DBNull.Value ? (string)dtRow["tribe"] : string.Empty);
				this.txt_phone_primary.Text = (dtRow["phone_primary"] != DBNull.Value ? (string)dtRow["phone_primary"] : string.Empty);
				this.txt_phone_secondary.Text = (dtRow["phone_secondary"] != DBNull.Value ? (string)dtRow["phone_secondary"] : string.Empty);
				this.txt_national_id_number.Text = (dtRow["national_id"] != DBNull.Value ? (string)dtRow["national_id"] : string.Empty);
				this.txt_partner_birth_place.Text = (dtRow["partner_birth_place"] != DBNull.Value ? (string)dtRow["partner_birth_place"] : string.Empty);
				this.txt_partner_parents_names.Text = (dtRow["partner_parents_names"] != DBNull.Value ? (string)dtRow["partner_parents_names"] : string.Empty);
				this.txt_partners_residential_adres.Text = (dtRow["partner_parents_resident_adress"] != DBNull.Value ? (string)dtRow["partner_parents_resident_adress"] : string.Empty);
				this.txt_partner_phone.Text = (dtRow["partner_contact"] != DBNull.Value ? (string)dtRow["partner_contact"] : string.Empty);
				this.txt_record_guid.Text = (dtRow["record_guid"] != DBNull.Value ? (string)dtRow["record_guid"] : string.Empty);
				this.cbo_marital_status.Text = (dtRow["marital_status"] != DBNull.Value ? (string)dtRow["marital_status"] : string.Empty);
				this.txt_partner_name.Text = (dtRow["partners_name"] != DBNull.Value ? (string)dtRow["partners_name"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}