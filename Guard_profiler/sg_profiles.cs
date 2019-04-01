using Guard_profiler.App_code;
using Guard_profiler.Properties;
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
	public class sg_profiles : Form
	{
		private IContainer components;

		private Panel panel1;

		private GroupBox groupBox1;

		private Label label1;

		private TextBox txt_sg_l_name;

		private Label label2;

		private TextBox txt_sg_f_name;

		private Label label3;

		private Label label4;

		private TextBox txt_sg_phone;

		private ComboBox cbo_branch;

		private Label label5;

		private Label label6;

		private ComboBox cbo_position;

		private Label label7;

		private Panel panel6;

		private DateTimePicker dt_registration_date;

		private CheckBox chk_registration_date;

		private ComboBox cbo_dept;

		private Label label8;

		private Label label9;

		private TextBox txt_place_of_birth;

		private Panel panel2;

		private DateTimePicker dt_birthdate;

		private CheckBox chk_birthdate;

		private Label label10;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel contents_panel;

		private TextBox txt_age;

		private Label label11;

		private ComboBox cbo_gender;

		private GroupBox groupBox2;

		private Label label12;

		private ComboBox cbo_home_district;

		private Label label13;

		private Label label15;

		private TextBox txt_home_subcounty;

		private Label label14;

		private TextBox txt_home_county;

		private TextBox txt_home_village;

		private Label label16;

		private TextBox txt_home_parish;

		private Label label17;

		private Label label18;

		private ComboBox cbo_religion;

		private ComboBox cbo_marital_status;

		private Label label19;

		private TextBox txt_partners_name;

		private Label label41;

		private TabControl tab_container;

		private TabPage tabPage1;

		private GroupBox groupBox5;

		private TextBox txt_c_landlord;

		private Label label24;

		private TextBox txt_c_zone;

		private Label label25;

		private TextBox txt_c_parish;

		private Label label26;

		private TextBox txt_c_subcounty;

		private Label label27;

		private Label label28;

		private TabPage tabPage3;

		private Panel panel5;

		private GroupBox groupBox3;

		private TextBox txt_f_zone;

		private Label label20;

		private TextBox txt_f_village;

		private Label label21;

		private TextBox txt_f_county;

		private Label label22;

		private Label label23;

		private Label label29;

		private TextBox txt_f_name;

		private TabPage tabPage4;

		private GroupBox groupBox4;

		private Panel panel8;

		private DateTimePicker dtHire_date;

		private CheckBox chk_hiredate;

		private Label label30;

		private TextBox txt_salary;

		private Label label31;

		private TextBox txt_tin_number;

		private Label label32;

		private TextBox txt_departure_reason;

		private Label label33;

		private TextBox txt_e_adress;

		private Label label34;

		private Label label35;

		private TextBox txt_e_name;

		private TabPage tabPage5;

		private GroupBox groupBox6;

		private RichTextBox txt_i_referees;

		private Label label36;

		private Panel panel12;

		private DateTimePicker dt_i_to;

		private CheckBox chk_i_to;

		private Panel panel11;

		private DateTimePicker dt_i_from;

		private CheckBox chk_i_from;

		private Label label37;

		private Label label38;

		private TextBox txt_i_award;

		private Label label39;

		private Label label40;

		private TextBox txt_i_name;

		//private ReSize reSize1;

		private Panel panel14;

		private DataGridView gdv_guards;

		private Panel panel10;

		private Button btn_e_edit;

		private Button btn_e_new;

		private Button btn_e_save;

		private ComboBox cbo_current_residence_district;

		private ComboBox cbo_f_district;

		private TextBox txt_guid;

		private Label label42;

		private TextBox txt_guard_number;

		private Button btnImage;

		private Button btnReport;

		private Button btnReport_single;

		private Panel panel3;

		private ComboBox cbo_branch_search;

		private RichTextBox txt_name_search;

		private Label label43;

		private Label label44;

		private Panel panel_guard_status;

		private Label label45;

		private ComboBox cbo_guard_status;

		private Label label46;

		private TextBox txt_guard_number_static_code;

		private TextBox txt_guard_number_auto_code;

		private TextBox txt_guard_number_complete;

		private Label label47;

		private Label label49;

		private Label label48;

		private Label label50;

		private CheckBox chk_add;

		private CheckBox chk_edit;

		private Button btn_large_photo;

		private Button btn_large_img_rpt;

		private Button btn_edit_guard_number;

		private TabPage tabPage2;

		private Label label52;

		private ComboBox cbo_bank_name;

		private Label label51;

		private TextBox txt_account_number;

		private Label label53;
        private ReSize reSize1;
        private Label label54;
        private Button btn_name_search;
        private RichTextBox txt_guard_number_search;
        private Button btnSearch;
        private TextBox txt_nssf_number;

		public sg_profiles()
		{
			this.InitializeComponent();
		}

		protected void ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD()
		{
			sg_Profiles.UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS("UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS", this.txt_guid.Text);
			MessageBox.Show("All guard details have been successfully archieved,you can access them from the archived guards module");
		}



		private void btn_e_edit_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number_complete.Text != string.Empty)
			{
				this.contents_panel.Enabled = true;
				this.tab_container.Enabled = true;
				this.groupBox2.Enabled = true;
				this.panel_guard_status.Enabled = true;
				this.txt_guard_number_static_code.ReadOnly = true;
				this.chk_edit.Checked = true;
				this.chk_add.Checked = false;
			}
		}

		private void btn_e_new_Click(object sender, EventArgs e)
		{
			this.CLEAR_FEILDS();
			this.chk_add.Checked = true;
			this.chk_edit.Checked = false;
		}

		private void btn_e_save_Click(object sender, EventArgs e)
		{
			if (this.txt_guid.Text != string.Empty)
			{
				this.UPDATE_GUARD_DETAILS(this.txt_guid.Text);
				return;
			}
			if (sg_Profiles.CHECK_IF_GUARD_NUMBER_IS_ASSIGNED("CHECK_IF_GUARD_NUMBER_IS_ASSIGNED", this.txt_guard_number_complete.Text) <= 0)
			{
				this.SAVE_GUARD_DETAILS();
				return;
			}
			MessageBox.Show(string.Concat("The guard number you have selected already belongs to an active guard in ", this.cbo_branch.Text, " Branch.Use the guard number assignment screen to free up this number"));
		}

		private void btn_edit_guard_number_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number_complete.Text == string.Empty || this.txt_guid.Text == string.Empty)
			{
				MessageBox.Show("No guard selected");
				return;
			}
			SystemConst._branch_name = this.cbo_branch.Text;
			SystemConst.guard_number = this.txt_guard_number_complete.Text;
			SystemConst.record_guid = this.txt_guid.Text;
			(new frm_pre_login()).ShowDialog();
		}

		private void btn_large_img_rpt_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Select an officer to view report");
				return;
			}
			SystemConst.guard_number = this.txt_guard_number.Text;
			(new frm_officer_large_img_report()).ShowDialog();
		}

		private void btn_large_photo_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Select an Officer to upload an image");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = string.Concat(this.txt_sg_f_name.Text, " ", this.txt_sg_l_name.Text);
			SystemConst.record_guid = this.txt_guid.Text;
			(new frm_officer_img_large()).ShowDialog();
		}

		private void btn_name_search_Click(object sender, EventArgs e)
		{
			if (this.txt_name_search.Text == string.Empty)
			{
				this.GET_GUARD_LIST();
			}
			else
			{
				DataTable dt = sg_Profiles.RETURN_SEARCH_RESULTS("RETURN_SEARCH_RESULTS", this.txt_name_search.Text);
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

		private void btnImage_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Select an Officer to upload an image");
				return;
			}
			SystemConst.OfficerID = this.txt_guard_number.Text;
			SystemConst.OfficerName = string.Concat(this.txt_sg_f_name.Text, " ", this.txt_sg_l_name.Text);
			SystemConst.record_guid = this.txt_guid.Text;
			(new frmImages()).ShowDialog();
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			(new frm_sg_list_report()).ShowDialog();
		}

		private void btnReport_single_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Select an officer to view report");
				return;
			}
			SystemConst.guard_number = this.txt_guard_number.Text;
			SystemConst._Single_report_type = "Active";
			(new frmcrystal_report_single()).ShowDialog();
		}

		private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_branch.Text == string.Empty)
			{
				this.txt_guard_number_auto_code.Clear();
				return;
			}
			this.txt_guard_number_auto_code.Text = this.cbo_branch.SelectedValue.ToString();
		}

		private void cbo_guard_status_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_guard_status.Text != string.Empty && this.cbo_guard_status.Text != "Active")
			{
				this.BackColor = Color.Red;
			}
		}

		private void cbo_marital_status_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txt_partners_name.Enabled = (!(this.cbo_marital_status.Text != string.Empty) || !(this.cbo_marital_status.Text != "Single") ? false : true);
			if (this.cbo_marital_status.Text == "Single")
			{
				this.txt_partners_name.Clear();
			}
		}

		protected void CLEAR_FEILDS()
		{
			this.txt_sg_f_name.Clear();
			this.txt_sg_l_name.Clear();
			this.txt_sg_phone.Clear();
			this.cbo_branch.Text = string.Empty;
			this.cbo_position.Text = string.Empty;
			this.cbo_dept.Text = string.Empty;
			this.dt_registration_date.Value = DateTime.Today;
			this.txt_place_of_birth.Clear();
			this.dt_birthdate.Value = DateTime.Today;
			this.txt_age.Clear();
			this.cbo_gender.Text = string.Empty;
			this.cbo_home_district.Text = string.Empty;
			this.cbo_religion.Text = string.Empty;
			this.txt_home_county.Clear();
			this.cbo_marital_status.Text = string.Empty;
			this.txt_home_subcounty.Clear();
			this.txt_partners_name.Clear();
			this.txt_home_parish.Clear();
			this.txt_home_village.Clear();
			this.cbo_current_residence_district.Text = string.Empty;
			this.txt_c_subcounty.Clear();
			this.txt_c_parish.Clear();
			this.txt_c_zone.Clear();
			this.txt_c_landlord.Clear();
			this.txt_f_name.Clear();
			this.cbo_f_district.Text = string.Empty;
			this.txt_f_county.Clear();
			this.txt_f_village.Clear();
			this.txt_f_zone.Clear();
			this.txt_e_name.Clear();
			this.txt_e_adress.Clear();
			this.txt_departure_reason.Clear();
			this.txt_tin_number.Clear();
			this.txt_salary.Clear();
			this.dtHire_date.Value = DateTime.Today;
			this.txt_i_name.Clear();
			this.txt_i_award.Clear();
			this.dt_i_from.Value = DateTime.Today;
			this.dt_i_to.Value = DateTime.Today;
			this.txt_i_referees.Clear();
			this.txt_guid.Clear();
			this.txt_guard_number.Clear();
			this.txt_guard_number_complete.Clear();
			this.txt_guard_number_static_code.ReadOnly = false;
			this.txt_account_number.Clear();
			this.txt_nssf_number.Clear();
			this.contents_panel.Enabled = true;
			this.tab_container.Enabled = true;
			this.groupBox2.Enabled = true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void dt_birthdate_ValueChanged(object sender, EventArgs e)
		{
			int age = DateTime.Today.Year - this.dt_birthdate.Value.Date.Year;
			this.txt_age.Text = age.ToString();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_guards.Rows.Count != 0)
			{
				string record_guid = this.gdv_guards.CurrentRow.Cells[0].Value.ToString();
				this.txt_guid.Text = record_guid;
				this.GET_GUARD_DETAILS("SELECT_GUARD_DETAILS", record_guid);
				this.GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", record_guid);
				this.contents_panel.Enabled = false;
				this.tab_container.Enabled = false;
				this.groupBox2.Enabled = false;
				this.panel_guard_status.Enabled = false;
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
				this.cbo_branch.DataSource = dt;
				this.cbo_branch.DisplayMember = "branch";
				this.cbo_branch.ValueMember = "branch_code";
			}
		}

		protected void GET_BRANCHES_SEARCH()
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
				this.cbo_branch_search.ValueMember = "auto_id";
			}
		}

		protected void GET_DEPARTMENTS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_DEPARTMENTS");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -1;
				dtRow["department_name"] = string.Empty;
				dtRow["department_active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_dept.DataSource = dt;
				this.cbo_dept.ValueMember = "auto_id";
				this.cbo_dept.DisplayMember = "department_name";
			}
		}

		protected void GET_GUARD_DETAILS(string Query, string record_guid)
		{
			string str;
			DataTable dt = sg_Profiles.RETURN_GUARD_DETAILS(Query, record_guid);
			if (dt != null && dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				this.txt_sg_f_name.Text = (dtRow["f_name"] != DBNull.Value ? (string)dtRow["f_name"] : string.Empty);
				this.txt_sg_l_name.Text = (dtRow["l_name"] != DBNull.Value ? (string)dtRow["l_name"] : string.Empty);
				this.txt_sg_phone.Text = (dtRow["phone"] != DBNull.Value ? (string)dtRow["phone"] : string.Empty);
				this.cbo_branch.Text = (dtRow["branch"] != DBNull.Value ? (string)dtRow["branch"] : string.Empty);
				this.cbo_position.Text = (dtRow["position"] != DBNull.Value ? (string)dtRow["position"] : string.Empty);
				this.cbo_dept.Text = (dtRow["department"] != DBNull.Value ? (string)dtRow["department"] : string.Empty);
				this.dt_registration_date.Value = (dtRow["registered_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["registered_date"]) : DateTime.Today);
				this.txt_place_of_birth.Text = (dtRow["birth_place"] != DBNull.Value ? (string)dtRow["birth_place"] : string.Empty);
				this.dt_birthdate.Value = (dtRow["dob"] != DBNull.Value ? Convert.ToDateTime(dtRow["dob"]) : DateTime.Today);
				TextBox txtAge = this.txt_age;
				if (dtRow["age"] != DBNull.Value)
				{
					int num = Convert.ToInt32(dtRow["age"]);
					str = num.ToString();
				}
				else
				{
					str = string.Empty;
				}
				txtAge.Text = str;
				this.cbo_gender.Text = (dtRow["gender"] != DBNull.Value ? (string)dtRow["gender"] : string.Empty);
				this.cbo_home_district.Text = (dtRow["home_district"] != DBNull.Value ? (string)dtRow["home_district"] : string.Empty);
				this.cbo_religion.Text = (dtRow["religion"] != DBNull.Value ? (string)dtRow["religion"] : string.Empty);
				this.txt_home_county.Text = (dtRow["home_county"] != DBNull.Value ? (string)dtRow["home_county"] : string.Empty);
				this.cbo_marital_status.Text = (dtRow["marital_status"] != DBNull.Value ? (string)dtRow["marital_status"] : string.Empty);
				this.txt_home_subcounty.Text = (dtRow["home_sub_county"] != DBNull.Value ? (string)dtRow["home_sub_county"] : string.Empty);
				this.txt_partners_name.Text = (dtRow["partners_name"] != DBNull.Value ? (string)dtRow["partners_name"] : string.Empty);
				this.txt_home_parish.Text = (dtRow["home_parish"] != DBNull.Value ? (string)dtRow["home_parish"] : string.Empty);
				this.txt_home_village.Text = (dtRow["home_village_lc1"] != DBNull.Value ? (string)dtRow["home_village_lc1"] : string.Empty);
				this.cbo_current_residence_district.Text = (dtRow["current_residence_district"] != DBNull.Value ? (string)dtRow["current_residence_district"] : string.Empty);
				this.txt_c_subcounty.Text = (dtRow["current_residence_sub_county"] != DBNull.Value ? (string)dtRow["current_residence_sub_county"] : string.Empty);
				this.txt_c_parish.Text = (dtRow["current_residence_parish"] != DBNull.Value ? (string)dtRow["current_residence_parish"] : string.Empty);
				this.txt_c_zone.Text = (dtRow["current_residence_zone"] != DBNull.Value ? (string)dtRow["current_residence_zone"] : string.Empty);
				this.txt_c_landlord.Text = (dtRow["current_landlord_name"] != DBNull.Value ? (string)dtRow["current_landlord_name"] : string.Empty);
				this.txt_f_name.Text = (dtRow["father_name"] != DBNull.Value ? (string)dtRow["father_name"] : string.Empty);
				this.cbo_f_district.Text = (dtRow["father_district"] != DBNull.Value ? (string)dtRow["father_district"] : string.Empty);
				this.txt_f_county.Text = (dtRow["father_county"] != DBNull.Value ? (string)dtRow["father_county"] : string.Empty);
				this.txt_f_village.Text = (dtRow["father_village"] != DBNull.Value ? (string)dtRow["father_village"] : string.Empty);
				this.txt_f_zone.Text = (dtRow["father_zone"] != DBNull.Value ? (string)dtRow["father_zone"] : string.Empty);
				this.txt_e_name.Text = (dtRow["prev_employer_name"] != DBNull.Value ? (string)dtRow["prev_employer_name"] : string.Empty);
				this.txt_e_adress.Text = (dtRow["prev_employer_address"] != DBNull.Value ? (string)dtRow["prev_employer_address"] : string.Empty);
				this.txt_departure_reason.Text = (dtRow["cause_of_departure"] != DBNull.Value ? (string)dtRow["cause_of_departure"] : string.Empty);
				this.txt_tin_number.Text = (dtRow["tin_number"] != DBNull.Value ? (string)dtRow["tin_number"] : string.Empty);
				this.txt_salary.Text = (dtRow["previous_salary"] != DBNull.Value ? (string)dtRow["previous_salary"] : string.Empty);
				this.dtHire_date.Value = (dtRow["start_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["start_date"]) : DateTime.Today);
				this.chk_hiredate.Checked = true;
				this.txt_i_name.Text = (dtRow["institution_name"] != DBNull.Value ? (string)dtRow["institution_name"] : string.Empty);
				this.txt_i_award.Text = (dtRow["award_name"] != DBNull.Value ? (string)dtRow["award_name"] : string.Empty);
				this.dt_i_from.Value = (dtRow["study_start_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["study_start_date"]) : DateTime.Today);
				this.dt_i_to.Value = (dtRow["study_end_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["study_end_date"]) : DateTime.Today);
				this.chk_i_from.Checked = true;
				this.chk_i_to.Checked = true;
				this.txt_i_referees.Text = (dtRow["refferees"] != DBNull.Value ? (string)dtRow["refferees"] : string.Empty);
				this.cbo_guard_status.Text = (dtRow["guard_status"] != DBNull.Value ? (string)dtRow["guard_status"] : string.Empty);
				this.txt_guard_number.Text = (string)dtRow["guard_number"];
				this.txt_guard_number_complete.Text = (string)dtRow["guard_number"];
				this.txt_account_number.Text = (dtRow["account_number"] != DBNull.Value ? (string)dtRow["account_number"] : string.Empty);
				this.txt_nssf_number.Text = (dtRow["nssf_number"] != DBNull.Value ? (string)dtRow["nssf_number"] : string.Empty);
				this.cbo_marital_status_SelectedIndexChanged(this.cbo_marital_status, null);
			}
		}

		protected void GET_GUARD_LIST()
		{
			try
			{
				DataTable dt = sg_Profiles.RETURN_OFFICER_LIST("SELECT_GUARD_LISTS");
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
			if (dt != null && dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				if (dtRow["image_data"] != DBNull.Value)
				{
					MemoryStream stream = new MemoryStream((byte[])dtRow["image_data"]);
					this.picBoxImage.Image = Image.FromStream(stream);
					return;
				}
				this.picBoxImage.Image = null;
				this.picBoxImage.Image = Resources.image_placeholder;
			}
		}

		protected void GET_POSITIONS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_POSITIONS");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -1;
				dtRow["position_name"] = string.Empty;
				dtRow["active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_position.DataSource = dt;
				this.cbo_position.ValueMember = "auto_id";
				this.cbo_position.DisplayMember = "position_name";
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sg_profiles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_large_photo = new System.Windows.Forms.Button();
            this.chk_edit = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.chk_add = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.panel_guard_status = new System.Windows.Forms.Panel();
            this.cbo_guard_status = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt_guard_number_search = new System.Windows.Forms.RichTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.btn_large_img_rpt = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_name_search = new System.Windows.Forms.Button();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.txt_name_search = new System.Windows.Forms.RichTextBox();
            this.btnReport_single = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_partners_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbo_marital_status = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbo_religion = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_home_village = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_home_parish = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_home_subcounty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_home_county = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_home_district = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_e_edit = new System.Windows.Forms.Button();
            this.btn_e_new = new System.Windows.Forms.Button();
            this.btn_e_save = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.label41 = new System.Windows.Forms.Label();
            this.tab_container = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbo_current_residence_district = new System.Windows.Forms.ComboBox();
            this.txt_c_landlord = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_c_zone = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_c_parish = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_c_subcounty = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_f_district = new System.Windows.Forms.ComboBox();
            this.txt_f_zone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_f_village = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_f_county = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_f_name = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtHire_date = new System.Windows.Forms.DateTimePicker();
            this.chk_hiredate = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_tin_number = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_departure_reason = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_e_adress = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_e_name = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_i_referees = new System.Windows.Forms.RichTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dt_i_to = new System.Windows.Forms.DateTimePicker();
            this.chk_i_to = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dt_i_from = new System.Windows.Forms.DateTimePicker();
            this.chk_i_from = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_i_award = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_i_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_nssf_number = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.txt_account_number = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cbo_bank_name = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.contents_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_edit_guard_number = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_guard_number_complete = new System.Windows.Forms.TextBox();
            this.txt_guard_number_static_code = new System.Windows.Forms.TextBox();
            this.txt_guard_number_auto_code = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dt_birthdate = new System.Windows.Forms.DateTimePicker();
            this.chk_birthdate = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_place_of_birth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dt_registration_date = new System.Windows.Forms.DateTimePicker();
            this.chk_registration_date = new System.Windows.Forms.CheckBox();
            this.cbo_dept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sg_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sg_l_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sg_f_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel_guard_status.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.tab_container.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.contents_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_large_photo);
            this.panel1.Controls.Add(this.chk_edit);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.chk_add);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.panel_guard_status);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.txt_guard_number);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.txt_guid);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.tab_container);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.contents_panel);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 900);
            this.panel1.TabIndex = 0;
            // 
            // btn_large_photo
            // 
            this.btn_large_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_large_photo.Location = new System.Drawing.Point(1360, 212);
            this.btn_large_photo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_large_photo.Name = "btn_large_photo";
            this.btn_large_photo.Size = new System.Drawing.Size(164, 30);
            this.btn_large_photo.TabIndex = 67;
            this.btn_large_photo.Text = "Attach Large Photo";
            this.btn_large_photo.UseVisualStyleBackColor = false;
            this.btn_large_photo.Click += new System.EventHandler(this.btn_large_photo_Click);
            // 
            // chk_edit
            // 
            this.chk_edit.AutoSize = true;
            this.chk_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chk_edit.Enabled = false;
            this.chk_edit.Location = new System.Drawing.Point(1311, 878);
            this.chk_edit.Margin = new System.Windows.Forms.Padding(4);
            this.chk_edit.Name = "chk_edit";
            this.chk_edit.Size = new System.Drawing.Size(218, 21);
            this.chk_edit.TabIndex = 66;
            this.chk_edit.Text = "You are Editing Guard Details";
            this.chk_edit.UseVisualStyleBackColor = false;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Yellow;
            this.label50.Location = new System.Drawing.Point(879, 844);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(100, 17);
            this.label50.TabIndex = 65;
            this.label50.Text = "Action Tracker";
            // 
            // chk_add
            // 
            this.chk_add.AutoSize = true;
            this.chk_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chk_add.Enabled = false;
            this.chk_add.Location = new System.Drawing.Point(1085, 876);
            this.chk_add.Margin = new System.Windows.Forms.Padding(4);
            this.chk_add.Name = "chk_add";
            this.chk_add.Size = new System.Drawing.Size(213, 21);
            this.chk_add.TabIndex = 64;
            this.chk_add.Text = "You are Adding a new Guard";
            this.chk_add.UseVisualStyleBackColor = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(697, 257);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(154, 17);
            this.label45.TabIndex = 63;
            this.label45.Text = "Select Guard Status";
            // 
            // panel_guard_status
            // 
            this.panel_guard_status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_guard_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_guard_status.Controls.Add(this.cbo_guard_status);
            this.panel_guard_status.Location = new System.Drawing.Point(697, 277);
            this.panel_guard_status.Margin = new System.Windows.Forms.Padding(4);
            this.panel_guard_status.Name = "panel_guard_status";
            this.panel_guard_status.Size = new System.Drawing.Size(167, 79);
            this.panel_guard_status.TabIndex = 58;
            // 
            // cbo_guard_status
            // 
            this.cbo_guard_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_guard_status.FormattingEnabled = true;
            this.cbo_guard_status.Items.AddRange(new object[] {
            "",
            "Active",
            "Confined",
            "Deserted",
            "Died",
            "Dismissed",
            "Resigned",
            "Retired",
            "Sick",
            "Terminated"});
            this.cbo_guard_status.Location = new System.Drawing.Point(3, 9);
            this.cbo_guard_status.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_guard_status.Name = "cbo_guard_status";
            this.cbo_guard_status.Size = new System.Drawing.Size(155, 28);
            this.cbo_guard_status.TabIndex = 0;
            this.cbo_guard_status.SelectedIndexChanged += new System.EventHandler(this.cbo_guard_status_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txt_guard_number_search);
            this.panel3.Controls.Add(this.label54);
            this.panel3.Controls.Add(this.btn_large_img_rpt);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.btn_name_search);
            this.panel3.Controls.Add(this.cbo_branch_search);
            this.panel3.Controls.Add(this.txt_name_search);
            this.panel3.Controls.Add(this.btnReport_single);
            this.panel3.Controls.Add(this.btnReport);
            this.panel3.Location = new System.Drawing.Point(873, 254);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 123);
            this.panel3.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(229, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 45);
            this.btnSearch.TabIndex = 66;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txt_guard_number_search
            // 
            this.txt_guard_number_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_search.Location = new System.Drawing.Point(229, 26);
            this.txt_guard_number_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number_search.Name = "txt_guard_number_search";
            this.txt_guard_number_search.Size = new System.Drawing.Size(150, 31);
            this.txt_guard_number_search.TabIndex = 65;
            this.txt_guard_number_search.Text = "";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Yellow;
            this.label54.Location = new System.Drawing.Point(217, 6);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(102, 17);
            this.label54.TabIndex = 64;
            this.label54.Text = "Guard Number";
            // 
            // btn_large_img_rpt
            // 
            this.btn_large_img_rpt.Location = new System.Drawing.Point(535, 6);
            this.btn_large_img_rpt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_large_img_rpt.Name = "btn_large_img_rpt";
            this.btn_large_img_rpt.Size = new System.Drawing.Size(109, 52);
            this.btn_large_img_rpt.TabIndex = 63;
            this.btn_large_img_rpt.Text = "Large Image Report";
            this.btn_large_img_rpt.UseVisualStyleBackColor = true;
            this.btn_large_img_rpt.Click += new System.EventHandler(this.btn_large_img_rpt_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Yellow;
            this.label44.Location = new System.Drawing.Point(9, 63);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(171, 17);
            this.label44.TabIndex = 62;
            this.label44.Text = "Select a Branch to search";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Yellow;
            this.label43.Location = new System.Drawing.Point(9, 6);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(162, 17);
            this.label43.TabIndex = 61;
            this.label43.Text = "Enter First or Last Name";
            // 
            // btn_name_search
            // 
            this.btn_name_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_name_search.Location = new System.Drawing.Point(487, 9);
            this.btn_name_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_name_search.Name = "btn_name_search";
            this.btn_name_search.Size = new System.Drawing.Size(27, 34);
            this.btn_name_search.TabIndex = 59;
            this.btn_name_search.Text = "Search";
            this.btn_name_search.UseVisualStyleBackColor = false;
            this.btn_name_search.Visible = false;
            this.btn_name_search.Click += new System.EventHandler(this.btn_name_search_Click);
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(9, 80);
            this.cbo_branch_search.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(212, 33);
            this.cbo_branch_search.TabIndex = 58;
            // 
            // txt_name_search
            // 
            this.txt_name_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_search.Location = new System.Drawing.Point(9, 26);
            this.txt_name_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name_search.Name = "txt_name_search";
            this.txt_name_search.Size = new System.Drawing.Size(212, 31);
            this.txt_name_search.TabIndex = 57;
            this.txt_name_search.Text = "";
            // 
            // btnReport_single
            // 
            this.btnReport_single.BackColor = System.Drawing.Color.Cyan;
            this.btnReport_single.Location = new System.Drawing.Point(387, 61);
            this.btnReport_single.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport_single.Name = "btnReport_single";
            this.btnReport_single.Size = new System.Drawing.Size(140, 55);
            this.btnReport_single.TabIndex = 56;
            this.btnReport_single.Text = "Individual Guard Report";
            this.btnReport_single.UseVisualStyleBackColor = false;
            this.btnReport_single.Click += new System.EventHandler(this.btnReport_single_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReport.Location = new System.Drawing.Point(535, 64);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 55);
            this.btnReport.TabIndex = 55;
            this.btnReport.Text = "All Guards Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.txt_partners_name);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.cbo_marital_status);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cbo_religion);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_home_village);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_home_parish);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_home_subcounty);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_home_county);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbo_home_district);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(697, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(627, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details of place of birth";
            // 
            // txt_partners_name
            // 
            this.txt_partners_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partners_name.Location = new System.Drawing.Point(316, 150);
            this.txt_partners_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_partners_name.Name = "txt_partners_name";
            this.txt_partners_name.Size = new System.Drawing.Size(301, 29);
            this.txt_partners_name.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(315, 127);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "Partners Name";
            // 
            // cbo_marital_status
            // 
            this.cbo_marital_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_marital_status.FormattingEnabled = true;
            this.cbo_marital_status.Items.AddRange(new object[] {
            "",
            "Single",
            "Married"});
            this.cbo_marital_status.Location = new System.Drawing.Point(319, 94);
            this.cbo_marital_status.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_marital_status.Name = "cbo_marital_status";
            this.cbo_marital_status.Size = new System.Drawing.Size(301, 32);
            this.cbo_marital_status.TabIndex = 31;
            this.cbo_marital_status.SelectedIndexChanged += new System.EventHandler(this.cbo_marital_status_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(319, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "Marital Status";
            // 
            // cbo_religion
            // 
            this.cbo_religion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_religion.FormattingEnabled = true;
            this.cbo_religion.Items.AddRange(new object[] {
            "",
            "ADVENTIST",
            "BORN AGAIN CHRISTIAN",
            "Christian Catholic",
            "Christian Protestant",
            "Muslim",
            "PENTECOSTAL",
            "R/C",
            ""});
            this.cbo_religion.Location = new System.Drawing.Point(316, 37);
            this.cbo_religion.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_religion.Name = "cbo_religion";
            this.cbo_religion.Size = new System.Drawing.Size(301, 32);
            this.cbo_religion.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(319, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Religion";
            // 
            // txt_home_village
            // 
            this.txt_home_village.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home_village.Location = new System.Drawing.Point(319, 206);
            this.txt_home_village.Margin = new System.Windows.Forms.Padding(4);
            this.txt_home_village.Name = "txt_home_village";
            this.txt_home_village.Size = new System.Drawing.Size(301, 29);
            this.txt_home_village.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(315, 186);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Home Village LC1";
            // 
            // txt_home_parish
            // 
            this.txt_home_parish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home_parish.Location = new System.Drawing.Point(8, 206);
            this.txt_home_parish.Margin = new System.Windows.Forms.Padding(4);
            this.txt_home_parish.Name = "txt_home_parish";
            this.txt_home_parish.Size = new System.Drawing.Size(301, 29);
            this.txt_home_parish.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(4, 186);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Home Parish";
            // 
            // txt_home_subcounty
            // 
            this.txt_home_subcounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home_subcounty.Location = new System.Drawing.Point(9, 150);
            this.txt_home_subcounty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_home_subcounty.Name = "txt_home_subcounty";
            this.txt_home_subcounty.Size = new System.Drawing.Size(301, 29);
            this.txt_home_subcounty.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(8, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Home Sub- County";
            // 
            // txt_home_county
            // 
            this.txt_home_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_home_county.Location = new System.Drawing.Point(8, 94);
            this.txt_home_county.Margin = new System.Windows.Forms.Padding(4);
            this.txt_home_county.Name = "txt_home_county";
            this.txt_home_county.Size = new System.Drawing.Size(301, 29);
            this.txt_home_county.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(8, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Home County";
            // 
            // cbo_home_district
            // 
            this.cbo_home_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_home_district.FormattingEnabled = true;
            this.cbo_home_district.Items.AddRange(new object[] {
            "",
            "Abim",
            "Adjumani",
            "Agago",
            "Alebtong",
            "Amolatar",
            "Amudat",
            "Amuria",
            "Amuru",
            "Apac",
            "Arua",
            "Budaka",
            "Bududa",
            "Bugiri",
            "Buhweju",
            "Buikwe",
            "Bukedea",
            "Bukomansimbi",
            "Bukwa",
            "Bulambuli",
            "Buliisa",
            "Bundibugyo",
            "Bushenyi",
            "Busia",
            "Butaleja",
            "Butambala",
            "Buvuma",
            "Buyende",
            "Dokolo",
            "Gomba",
            "Gulu",
            "Hoima",
            "Ibanda",
            "Iganga",
            "Isingiro",
            "Jinja",
            "Kaabong",
            "Kabale",
            "Kabarole",
            "Kaberamaido",
            "Kalangala",
            "Kaliro",
            "Kalungu",
            "Kampala",
            "Kamuli",
            "Kamwenge",
            "Kanungu",
            "Kapchorwa",
            "Kasese",
            "Katakwi",
            "Kayunga",
            "Kibaale",
            "Kiboga",
            "Kibuku",
            "Kiruhura",
            "Kiryandongo",
            "Kisoro",
            "Kitgum",
            "Koboko",
            "Kole",
            "Kotido",
            "Kumi",
            "Kween",
            "Kyankwanzi",
            "Kyegegwa",
            "Kyenjojo",
            "Lamwo",
            "Lira",
            "Luuka",
            "Luweero",
            "Lwengo",
            "Lyantonde",
            "Manafwa",
            "Maracha",
            "Masaka",
            "Masindi",
            "Mayuge",
            "Mbale",
            "Mbarara",
            "Mitooma",
            "Mityana",
            "Moroto",
            "Moyo",
            "Mpigi",
            "Mubende",
            "Mukono",
            "Nakapiripirit",
            "Nakaseke",
            "Nakasongola",
            "Namayingo",
            "Namutumba",
            "Napak",
            "Nebbi",
            "Ngora",
            "Ntoroko",
            "Ntungamo",
            "Nwoya",
            "Otuke",
            "Oyam",
            "Pader",
            "Pallisa",
            "Rakai",
            "Rubirizi",
            "Rukungiri",
            "Sembabule",
            "Serere",
            "Sheema",
            "Sironko",
            "Soroti",
            "Tororo",
            "Wakiso",
            "Yumbe",
            "Zombo"});
            this.cbo_home_district.Location = new System.Drawing.Point(8, 37);
            this.cbo_home_district.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_home_district.Name = "cbo_home_district";
            this.cbo_home_district.Size = new System.Drawing.Size(301, 32);
            this.cbo_home_district.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(5, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Home District";
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.LightGreen;
            this.btnImage.Location = new System.Drawing.Point(1360, 181);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(164, 30);
            this.btnImage.TabIndex = 54;
            this.btnImage.Text = "Passport Photo";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(8, 865);
            this.txt_guard_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.ReadOnly = true;
            this.txt_guard_number.Size = new System.Drawing.Size(255, 26);
            this.txt_guard_number.TabIndex = 53;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Red;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label42.Location = new System.Drawing.Point(5, 842);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 20);
            this.label42.TabIndex = 20;
            this.label42.Text = "Guard Number";
            // 
            // txt_guid
            // 
            this.txt_guid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guid.Location = new System.Drawing.Point(1145, 842);
            this.txt_guid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.ReadOnly = true;
            this.txt_guid.Size = new System.Drawing.Size(377, 26);
            this.txt_guid.TabIndex = 53;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel10.Controls.Add(this.btn_e_edit);
            this.panel10.Controls.Add(this.btn_e_new);
            this.panel10.Controls.Add(this.btn_e_save);
            this.panel10.Location = new System.Drawing.Point(357, 837);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(495, 55);
            this.panel10.TabIndex = 46;
            // 
            // btn_e_edit
            // 
            this.btn_e_edit.Location = new System.Drawing.Point(203, 4);
            this.btn_e_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_e_edit.Name = "btn_e_edit";
            this.btn_e_edit.Size = new System.Drawing.Size(104, 48);
            this.btn_e_edit.TabIndex = 46;
            this.btn_e_edit.Text = "Edit";
            this.btn_e_edit.UseVisualStyleBackColor = true;
            this.btn_e_edit.Click += new System.EventHandler(this.btn_e_edit_Click);
            // 
            // btn_e_new
            // 
            this.btn_e_new.Location = new System.Drawing.Point(4, 4);
            this.btn_e_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_e_new.Name = "btn_e_new";
            this.btn_e_new.Size = new System.Drawing.Size(176, 48);
            this.btn_e_new.TabIndex = 45;
            this.btn_e_new.Text = "Add New";
            this.btn_e_new.UseVisualStyleBackColor = true;
            this.btn_e_new.Click += new System.EventHandler(this.btn_e_new_Click);
            // 
            // btn_e_save
            // 
            this.btn_e_save.Location = new System.Drawing.Point(315, 4);
            this.btn_e_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_e_save.Name = "btn_e_save";
            this.btn_e_save.Size = new System.Drawing.Size(176, 48);
            this.btn_e_save.TabIndex = 44;
            this.btn_e_save.Text = "Save Details";
            this.btn_e_save.UseVisualStyleBackColor = true;
            this.btn_e_save.Click += new System.EventHandler(this.btn_e_save_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel14.Controls.Add(this.gdv_guards);
            this.panel14.Location = new System.Drawing.Point(883, 384);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(640, 450);
            this.panel14.TabIndex = 35;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(4, 4);
            this.gdv_guards.Margin = new System.Windows.Forms.Padding(4);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.ReadOnly = true;
            this.gdv_guards.Size = new System.Drawing.Size(632, 443);
            this.gdv_guards.TabIndex = 0;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Yellow;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(4, 404);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(241, 20);
            this.label41.TabIndex = 34;
            this.label41.Text = "Fill in more guard details below";
            // 
            // tab_container
            // 
            this.tab_container.Controls.Add(this.tabPage1);
            this.tab_container.Controls.Add(this.tabPage3);
            this.tab_container.Controls.Add(this.tabPage4);
            this.tab_container.Controls.Add(this.tabPage5);
            this.tab_container.Controls.Add(this.tabPage2);
            this.tab_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_container.Location = new System.Drawing.Point(9, 427);
            this.tab_container.Margin = new System.Windows.Forms.Padding(4);
            this.tab_container.Name = "tab_container";
            this.tab_container.SelectedIndex = 0;
            this.tab_container.Size = new System.Drawing.Size(848, 402);
            this.tab_container.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(840, 369);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Current residence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Azure;
            this.groupBox5.Controls.Add(this.cbo_current_residence_district);
            this.groupBox5.Controls.Add(this.txt_c_landlord);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txt_c_zone);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.txt_c_parish);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txt_c_subcounty);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Location = new System.Drawing.Point(11, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(788, 348);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current residence Details";
            // 
            // cbo_current_residence_district
            // 
            this.cbo_current_residence_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_current_residence_district.FormattingEnabled = true;
            this.cbo_current_residence_district.Location = new System.Drawing.Point(172, 27);
            this.cbo_current_residence_district.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_current_residence_district.Name = "cbo_current_residence_district";
            this.cbo_current_residence_district.Size = new System.Drawing.Size(493, 32);
            this.cbo_current_residence_district.TabIndex = 20;
            // 
            // txt_c_landlord
            // 
            this.txt_c_landlord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_landlord.Location = new System.Drawing.Point(172, 197);
            this.txt_c_landlord.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_landlord.Name = "txt_c_landlord";
            this.txt_c_landlord.Size = new System.Drawing.Size(493, 26);
            this.txt_c_landlord.TabIndex = 43;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(65, 197);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 20);
            this.label24.TabIndex = 42;
            this.label24.Text = "LandLord";
            // 
            // txt_c_zone
            // 
            this.txt_c_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_zone.Location = new System.Drawing.Point(172, 154);
            this.txt_c_zone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_zone.Name = "txt_c_zone";
            this.txt_c_zone.Size = new System.Drawing.Size(493, 26);
            this.txt_c_zone.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 158);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 20);
            this.label25.TabIndex = 40;
            this.label25.Text = "Residence Zone";
            // 
            // txt_c_parish
            // 
            this.txt_c_parish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_parish.Location = new System.Drawing.Point(172, 112);
            this.txt_c_parish.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_parish.Name = "txt_c_parish";
            this.txt_c_parish.Size = new System.Drawing.Size(493, 26);
            this.txt_c_parish.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1, 116);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(141, 20);
            this.label26.TabIndex = 38;
            this.label26.Text = "Residence Parish";
            // 
            // txt_c_subcounty
            // 
            this.txt_c_subcounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c_subcounty.Location = new System.Drawing.Point(172, 69);
            this.txt_c_subcounty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_subcounty.Name = "txt_c_subcounty";
            this.txt_c_subcounty.Size = new System.Drawing.Size(493, 26);
            this.txt_c_subcounty.TabIndex = 37;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(52, 76);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 20);
            this.label27.TabIndex = 36;
            this.label27.Text = "Sub-County";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(91, 33);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 20);
            this.label28.TabIndex = 34;
            this.label28.Text = "District";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(840, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Father\'s Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1152, 440);
            this.panel5.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_f_district);
            this.groupBox3.Controls.Add(this.txt_f_zone);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_f_village);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_f_county);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.txt_f_name);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1140, 428);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Father\'s Details";
            // 
            // cbo_f_district
            // 
            this.cbo_f_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_f_district.FormattingEnabled = true;
            this.cbo_f_district.Items.AddRange(new object[] {
            "",
            "Abim",
            "Adjumani",
            "Agago",
            "Alebtong",
            "Amolatar",
            "Amudat",
            "Amuria",
            "Amuru",
            "Apac",
            "Arua",
            "Budaka",
            "Bududa",
            "Bugiri",
            "Buhweju",
            "Buikwe",
            "Bukedea",
            "Bukomansimbi",
            "Bukwa",
            "Bulambuli",
            "Buliisa",
            "Bundibugyo",
            "Bushenyi",
            "Busia",
            "Butaleja",
            "Butambala",
            "Buvuma",
            "Buyende",
            "Dokolo",
            "Gomba",
            "Gulu",
            "Hoima",
            "Ibanda",
            "Iganga",
            "Isingiro",
            "Jinja",
            "Kaabong",
            "Kabale",
            "Kabarole",
            "Kaberamaido",
            "Kalangala",
            "Kaliro",
            "Kalungu",
            "Kampala",
            "Kamuli",
            "Kamwenge",
            "Kanungu",
            "Kapchorwa",
            "Kasese",
            "Katakwi",
            "Kayunga",
            "Kibaale",
            "Kiboga",
            "Kibuku",
            "Kiruhura",
            "Kiryandongo",
            "Kisoro",
            "Kitgum",
            "Koboko",
            "Kole",
            "Kotido",
            "Kumi",
            "Kween",
            "Kyankwanzi",
            "Kyegegwa",
            "Kyenjojo",
            "Lamwo",
            "Lira",
            "Luuka",
            "Luweero",
            "Lwengo",
            "Lyantonde",
            "Manafwa",
            "Maracha",
            "Masaka",
            "Masindi",
            "Mayuge",
            "Mbale",
            "Mbarara",
            "Mitooma",
            "Mityana",
            "Moroto",
            "Moyo",
            "Mpigi",
            "Mubende",
            "Mukono",
            "Nakapiripirit",
            "Nakaseke",
            "Nakasongola",
            "Namayingo",
            "Namutumba",
            "Napak",
            "Nebbi",
            "Ngora",
            "Ntoroko",
            "Ntungamo",
            "Nwoya",
            "Otuke",
            "Oyam",
            "Pader",
            "Pallisa",
            "Rakai",
            "Rubirizi",
            "Rukungiri",
            "Sembabule",
            "Serere",
            "Sheema",
            "Sironko",
            "Soroti",
            "Tororo",
            "Wakiso",
            "Yumbe",
            "Zombo"});
            this.cbo_f_district.Location = new System.Drawing.Point(172, 70);
            this.cbo_f_district.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_f_district.Name = "cbo_f_district";
            this.cbo_f_district.Size = new System.Drawing.Size(493, 32);
            this.cbo_f_district.TabIndex = 45;
            // 
            // txt_f_zone
            // 
            this.txt_f_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_zone.Location = new System.Drawing.Point(172, 197);
            this.txt_f_zone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_f_zone.Name = "txt_f_zone";
            this.txt_f_zone.Size = new System.Drawing.Size(493, 26);
            this.txt_f_zone.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(99, 201);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 42;
            this.label20.Text = "Zone";
            // 
            // txt_f_village
            // 
            this.txt_f_village.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_village.Location = new System.Drawing.Point(172, 154);
            this.txt_f_village.Margin = new System.Windows.Forms.Padding(4);
            this.txt_f_village.Name = "txt_f_village";
            this.txt_f_village.Size = new System.Drawing.Size(493, 26);
            this.txt_f_village.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(80, 158);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 20);
            this.label21.TabIndex = 40;
            this.label21.Text = "Village ";
            // 
            // txt_f_county
            // 
            this.txt_f_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_county.Location = new System.Drawing.Point(172, 112);
            this.txt_f_county.Margin = new System.Windows.Forms.Padding(4);
            this.txt_f_county.Name = "txt_f_county";
            this.txt_f_county.Size = new System.Drawing.Size(493, 26);
            this.txt_f_county.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(80, 116);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "County";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(87, 76);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 20);
            this.label23.TabIndex = 36;
            this.label23.Text = "District";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(91, 33);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 20);
            this.label29.TabIndex = 34;
            this.label29.Text = "Name";
            // 
            // txt_f_name
            // 
            this.txt_f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_f_name.Location = new System.Drawing.Point(172, 26);
            this.txt_f_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_f_name.Name = "txt_f_name";
            this.txt_f_name.Size = new System.Drawing.Size(493, 26);
            this.txt_f_name.TabIndex = 35;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Azure;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(840, 369);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Previous Employer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.txt_salary);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.txt_tin_number);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.txt_departure_reason);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.txt_e_adress);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.txt_e_name);
            this.groupBox4.Location = new System.Drawing.Point(11, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1140, 428);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Previous Employer Details";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.dtHire_date);
            this.panel8.Controls.Add(this.chk_hiredate);
            this.panel8.Location = new System.Drawing.Point(264, 245);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(495, 39);
            this.panel8.TabIndex = 48;
            // 
            // dtHire_date
            // 
            this.dtHire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHire_date.Location = new System.Drawing.Point(32, 5);
            this.dtHire_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtHire_date.Name = "dtHire_date";
            this.dtHire_date.Size = new System.Drawing.Size(457, 29);
            this.dtHire_date.TabIndex = 4;
            // 
            // chk_hiredate
            // 
            this.chk_hiredate.AutoSize = true;
            this.chk_hiredate.Location = new System.Drawing.Point(4, 15);
            this.chk_hiredate.Margin = new System.Windows.Forms.Padding(4);
            this.chk_hiredate.Name = "chk_hiredate";
            this.chk_hiredate.Size = new System.Drawing.Size(18, 17);
            this.chk_hiredate.TabIndex = 3;
            this.chk_hiredate.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(143, 245);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 20);
            this.label30.TabIndex = 46;
            this.label30.Text = "Start Date";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(264, 204);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(493, 26);
            this.txt_salary.TabIndex = 43;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(55, 208);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(167, 20);
            this.label31.TabIndex = 42;
            this.label31.Text = "Prev. Salary in words";
            // 
            // txt_tin_number
            // 
            this.txt_tin_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tin_number.Location = new System.Drawing.Point(264, 161);
            this.txt_tin_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tin_number.Name = "txt_tin_number";
            this.txt_tin_number.Size = new System.Drawing.Size(493, 26);
            this.txt_tin_number.TabIndex = 41;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(132, 165);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(93, 20);
            this.label32.TabIndex = 40;
            this.label32.Text = "Tin number";
            // 
            // txt_departure_reason
            // 
            this.txt_departure_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departure_reason.Location = new System.Drawing.Point(264, 119);
            this.txt_departure_reason.Margin = new System.Windows.Forms.Padding(4);
            this.txt_departure_reason.Name = "txt_departure_reason";
            this.txt_departure_reason.Size = new System.Drawing.Size(493, 26);
            this.txt_departure_reason.TabIndex = 39;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(67, 123);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(156, 20);
            this.label33.TabIndex = 38;
            this.label33.Text = "Cause of Departure";
            // 
            // txt_e_adress
            // 
            this.txt_e_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_e_adress.Location = new System.Drawing.Point(264, 76);
            this.txt_e_adress.Margin = new System.Windows.Forms.Padding(4);
            this.txt_e_adress.Name = "txt_e_adress";
            this.txt_e_adress.Size = new System.Drawing.Size(493, 26);
            this.txt_e_adress.TabIndex = 37;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(83, 80);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(137, 20);
            this.label34.TabIndex = 36;
            this.label34.Text = "Employer Adress";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(172, 37);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 20);
            this.label35.TabIndex = 34;
            this.label35.Text = "Name";
            // 
            // txt_e_name
            // 
            this.txt_e_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_e_name.Location = new System.Drawing.Point(264, 33);
            this.txt_e_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_e_name.Name = "txt_e_name";
            this.txt_e_name.Size = new System.Drawing.Size(493, 26);
            this.txt_e_name.TabIndex = 35;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(840, 369);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Academic Records";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Azure;
            this.groupBox6.Controls.Add(this.txt_i_referees);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.panel12);
            this.groupBox6.Controls.Add(this.panel11);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.txt_i_award);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.txt_i_name);
            this.groupBox6.Location = new System.Drawing.Point(11, 10);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(788, 346);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Institution Details";
            // 
            // txt_i_referees
            // 
            this.txt_i_referees.Location = new System.Drawing.Point(264, 214);
            this.txt_i_referees.Margin = new System.Windows.Forms.Padding(4);
            this.txt_i_referees.Name = "txt_i_referees";
            this.txt_i_referees.Size = new System.Drawing.Size(493, 85);
            this.txt_i_referees.TabIndex = 52;
            this.txt_i_referees.Text = "";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(143, 214);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 20);
            this.label36.TabIndex = 51;
            this.label36.Text = "Refferees";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel12.Controls.Add(this.dt_i_to);
            this.panel12.Controls.Add(this.chk_i_to);
            this.panel12.Location = new System.Drawing.Point(264, 158);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(495, 39);
            this.panel12.TabIndex = 50;
            // 
            // dt_i_to
            // 
            this.dt_i_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_i_to.Location = new System.Drawing.Point(32, 5);
            this.dt_i_to.Margin = new System.Windows.Forms.Padding(4);
            this.dt_i_to.Name = "dt_i_to";
            this.dt_i_to.Size = new System.Drawing.Size(457, 29);
            this.dt_i_to.TabIndex = 4;
            // 
            // chk_i_to
            // 
            this.chk_i_to.AutoSize = true;
            this.chk_i_to.Location = new System.Drawing.Point(4, 15);
            this.chk_i_to.Margin = new System.Windows.Forms.Padding(4);
            this.chk_i_to.Name = "chk_i_to";
            this.chk_i_to.Size = new System.Drawing.Size(18, 17);
            this.chk_i_to.TabIndex = 3;
            this.chk_i_to.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel11.Controls.Add(this.dt_i_from);
            this.panel11.Controls.Add(this.chk_i_from);
            this.panel11.Location = new System.Drawing.Point(264, 111);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(495, 39);
            this.panel11.TabIndex = 49;
            // 
            // dt_i_from
            // 
            this.dt_i_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_i_from.Location = new System.Drawing.Point(32, 5);
            this.dt_i_from.Margin = new System.Windows.Forms.Padding(4);
            this.dt_i_from.Name = "dt_i_from";
            this.dt_i_from.Size = new System.Drawing.Size(457, 29);
            this.dt_i_from.TabIndex = 4;
            // 
            // chk_i_from
            // 
            this.chk_i_from.AutoSize = true;
            this.chk_i_from.Location = new System.Drawing.Point(4, 15);
            this.chk_i_from.Margin = new System.Windows.Forms.Padding(4);
            this.chk_i_from.Name = "chk_i_from";
            this.chk_i_from.Size = new System.Drawing.Size(18, 17);
            this.chk_i_from.TabIndex = 3;
            this.chk_i_from.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(199, 170);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(28, 20);
            this.label37.TabIndex = 40;
            this.label37.Text = "To";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(180, 123);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 20);
            this.label38.TabIndex = 38;
            this.label38.Text = "From";
            // 
            // txt_i_award
            // 
            this.txt_i_award.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_award.Location = new System.Drawing.Point(264, 76);
            this.txt_i_award.Margin = new System.Windows.Forms.Padding(4);
            this.txt_i_award.Name = "txt_i_award";
            this.txt_i_award.Size = new System.Drawing.Size(493, 26);
            this.txt_i_award.TabIndex = 37;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(99, 80);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(124, 20);
            this.label39.TabIndex = 36;
            this.label39.Text = "Name of Award";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(96, 41);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(130, 20);
            this.label40.TabIndex = 34;
            this.label40.Text = "Institution Name";
            // 
            // txt_i_name
            // 
            this.txt_i_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_name.Location = new System.Drawing.Point(264, 33);
            this.txt_i_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_i_name.Name = "txt_i_name";
            this.txt_i_name.Size = new System.Drawing.Size(493, 26);
            this.txt_i_name.TabIndex = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.txt_nssf_number);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.txt_account_number);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.cbo_bank_name);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(840, 369);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Bank Acc. & NSSF";
            // 
            // txt_nssf_number
            // 
            this.txt_nssf_number.Enabled = false;
            this.txt_nssf_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nssf_number.Location = new System.Drawing.Point(20, 153);
            this.txt_nssf_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nssf_number.Name = "txt_nssf_number";
            this.txt_nssf_number.Size = new System.Drawing.Size(368, 29);
            this.txt_nssf_number.TabIndex = 71;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Yellow;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(16, 129);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(117, 20);
            this.label53.TabIndex = 70;
            this.label53.Text = "NSSF Number";
            // 
            // txt_account_number
            // 
            this.txt_account_number.Enabled = false;
            this.txt_account_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account_number.Location = new System.Drawing.Point(20, 96);
            this.txt_account_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_account_number.Name = "txt_account_number";
            this.txt_account_number.Size = new System.Drawing.Size(368, 29);
            this.txt_account_number.TabIndex = 68;
            this.txt_account_number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_account_number_KeyDown);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Yellow;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(20, 73);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(134, 20);
            this.label51.TabIndex = 69;
            this.label51.Text = "Account Number";
            // 
            // cbo_bank_name
            // 
            this.cbo_bank_name.Enabled = false;
            this.cbo_bank_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_bank_name.FormattingEnabled = true;
            this.cbo_bank_name.Items.AddRange(new object[] {
            "Stanbic Bank"});
            this.cbo_bank_name.Location = new System.Drawing.Point(20, 37);
            this.cbo_bank_name.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_bank_name.Name = "cbo_bank_name";
            this.cbo_bank_name.Size = new System.Drawing.Size(365, 32);
            this.cbo_bank_name.TabIndex = 68;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Yellow;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(16, 14);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(96, 20);
            this.label52.TabIndex = 68;
            this.label52.Text = "Bank Name";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.picBoxImage);
            this.panel9.Location = new System.Drawing.Point(1323, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(205, 175);
            this.panel9.TabIndex = 32;
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Location = new System.Drawing.Point(4, 4);
            this.picBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(193, 163);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 0;
            this.picBoxImage.TabStop = false;
            // 
            // contents_panel
            // 
            this.contents_panel.BackColor = System.Drawing.Color.MintCream;
            this.contents_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contents_panel.Controls.Add(this.groupBox1);
            this.contents_panel.Location = new System.Drawing.Point(4, 4);
            this.contents_panel.Margin = new System.Windows.Forms.Padding(4);
            this.contents_panel.Name = "contents_panel";
            this.contents_panel.Size = new System.Drawing.Size(684, 395);
            this.contents_panel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_edit_guard_number);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.txt_guard_number_complete);
            this.groupBox1.Controls.Add(this.txt_guard_number_static_code);
            this.groupBox1.Controls.Add(this.txt_guard_number_auto_code);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.cbo_gender);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_place_of_birth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.cbo_dept);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbo_position);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbo_branch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_sg_phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sg_l_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sg_f_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(664, 388);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guard Bio Data";
            // 
            // btn_edit_guard_number
            // 
            this.btn_edit_guard_number.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_edit_guard_number.Location = new System.Drawing.Point(589, 346);
            this.btn_edit_guard_number.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit_guard_number.Name = "btn_edit_guard_number";
            this.btn_edit_guard_number.Size = new System.Drawing.Size(41, 36);
            this.btn_edit_guard_number.TabIndex = 67;
            this.btn_edit_guard_number.Text = "....";
            this.btn_edit_guard_number.UseVisualStyleBackColor = false;
            this.btn_edit_guard_number.Click += new System.EventHandler(this.btn_edit_guard_number_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Yellow;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(283, 325);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(78, 20);
            this.label49.TabIndex = 66;
            this.label49.Text = "Assigned";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Yellow;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(428, 325);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(116, 20);
            this.label48.TabIndex = 65;
            this.label48.Text = "Guard number";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Yellow;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(184, 322);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 20);
            this.label47.TabIndex = 64;
            this.label47.Text = "Auto";
            // 
            // txt_guard_number_complete
            // 
            this.txt_guard_number_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_complete.Location = new System.Drawing.Point(428, 345);
            this.txt_guard_number_complete.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number_complete.Name = "txt_guard_number_complete";
            this.txt_guard_number_complete.ReadOnly = true;
            this.txt_guard_number_complete.Size = new System.Drawing.Size(157, 34);
            this.txt_guard_number_complete.TabIndex = 23;
            // 
            // txt_guard_number_static_code
            // 
            this.txt_guard_number_static_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_static_code.Location = new System.Drawing.Point(287, 345);
            this.txt_guard_number_static_code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number_static_code.Name = "txt_guard_number_static_code";
            this.txt_guard_number_static_code.Size = new System.Drawing.Size(139, 34);
            this.txt_guard_number_static_code.TabIndex = 22;
            this.txt_guard_number_static_code.TextAlignChanged += new System.EventHandler(this.txt_guard_number_static_code_TextAlignChanged);
            this.txt_guard_number_static_code.TextChanged += new System.EventHandler(this.txt_guard_number_static_code_TextChanged);
            this.txt_guard_number_static_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_guard_number_static_code_KeyPress);
            // 
            // txt_guard_number_auto_code
            // 
            this.txt_guard_number_auto_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_auto_code.Location = new System.Drawing.Point(188, 345);
            this.txt_guard_number_auto_code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number_auto_code.Name = "txt_guard_number_auto_code";
            this.txt_guard_number_auto_code.ReadOnly = true;
            this.txt_guard_number_auto_code.Size = new System.Drawing.Size(93, 34);
            this.txt_guard_number_auto_code.TabIndex = 21;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Yellow;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label46.Location = new System.Drawing.Point(12, 350);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(152, 25);
            this.label46.TabIndex = 20;
            this.label46.Text = "Guard Number";
            // 
            // cbo_gender
            // 
            this.cbo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "",
            "Male ",
            "Female"});
            this.cbo_gender.Location = new System.Drawing.Point(435, 286);
            this.cbo_gender.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(193, 32);
            this.cbo_gender.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(432, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Gender";
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(329, 287);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(96, 29);
            this.txt_age.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(323, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Age";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.dt_birthdate);
            this.panel2.Controls.Add(this.chk_birthdate);
            this.panel2.Location = new System.Drawing.Point(12, 277);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 42);
            this.panel2.TabIndex = 5;
            // 
            // dt_birthdate
            // 
            this.dt_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_birthdate.Location = new System.Drawing.Point(32, 7);
            this.dt_birthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dt_birthdate.Name = "dt_birthdate";
            this.dt_birthdate.Size = new System.Drawing.Size(272, 29);
            this.dt_birthdate.TabIndex = 4;
            this.dt_birthdate.ValueChanged += new System.EventHandler(this.dt_birthdate_ValueChanged);
            // 
            // chk_birthdate
            // 
            this.chk_birthdate.AutoSize = true;
            this.chk_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_birthdate.ForeColor = System.Drawing.Color.Red;
            this.chk_birthdate.Location = new System.Drawing.Point(4, 15);
            this.chk_birthdate.Margin = new System.Windows.Forms.Padding(4);
            this.chk_birthdate.Name = "chk_birthdate";
            this.chk_birthdate.Size = new System.Drawing.Size(18, 17);
            this.chk_birthdate.TabIndex = 4;
            this.chk_birthdate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Birth Date";
            // 
            // txt_place_of_birth
            // 
            this.txt_place_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_place_of_birth.Location = new System.Drawing.Point(327, 222);
            this.txt_place_of_birth.Margin = new System.Windows.Forms.Padding(4);
            this.txt_place_of_birth.Name = "txt_place_of_birth";
            this.txt_place_of_birth.Size = new System.Drawing.Size(301, 29);
            this.txt_place_of_birth.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(323, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Place of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registration Date";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.dt_registration_date);
            this.panel6.Controls.Add(this.chk_registration_date);
            this.panel6.Location = new System.Drawing.Point(12, 212);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 42);
            this.panel6.TabIndex = 4;
            // 
            // dt_registration_date
            // 
            this.dt_registration_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_registration_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_registration_date.Location = new System.Drawing.Point(32, 7);
            this.dt_registration_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_registration_date.Name = "dt_registration_date";
            this.dt_registration_date.Size = new System.Drawing.Size(272, 29);
            this.dt_registration_date.TabIndex = 4;
            // 
            // chk_registration_date
            // 
            this.chk_registration_date.AutoSize = true;
            this.chk_registration_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_registration_date.ForeColor = System.Drawing.Color.Red;
            this.chk_registration_date.Location = new System.Drawing.Point(4, 15);
            this.chk_registration_date.Margin = new System.Windows.Forms.Padding(4);
            this.chk_registration_date.Name = "chk_registration_date";
            this.chk_registration_date.Size = new System.Drawing.Size(18, 17);
            this.chk_registration_date.TabIndex = 4;
            this.chk_registration_date.UseVisualStyleBackColor = true;
            // 
            // cbo_dept
            // 
            this.cbo_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dept.FormattingEnabled = true;
            this.cbo_dept.Items.AddRange(new object[] {
            "",
            "Canine Department",
            "SP Department"});
            this.cbo_dept.Location = new System.Drawing.Point(327, 156);
            this.cbo_dept.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_dept.Name = "cbo_dept";
            this.cbo_dept.Size = new System.Drawing.Size(301, 32);
            this.cbo_dept.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(323, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Department";
            // 
            // cbo_position
            // 
            this.cbo_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_position.FormattingEnabled = true;
            this.cbo_position.Items.AddRange(new object[] {
            "",
            "Seargent",
            "Commander"});
            this.cbo_position.Location = new System.Drawing.Point(12, 156);
            this.cbo_position.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_position.Name = "cbo_position";
            this.cbo_position.Size = new System.Drawing.Size(301, 32);
            this.cbo_position.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position";
            // 
            // cbo_branch
            // 
            this.cbo_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(327, 96);
            this.cbo_branch.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(301, 32);
            this.cbo_branch.TabIndex = 7;
            this.cbo_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_branch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(323, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch";
            // 
            // txt_sg_phone
            // 
            this.txt_sg_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sg_phone.Location = new System.Drawing.Point(12, 96);
            this.txt_sg_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sg_phone.Name = "txt_sg_phone";
            this.txt_sg_phone.Size = new System.Drawing.Size(301, 29);
            this.txt_sg_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone";
            // 
            // txt_sg_l_name
            // 
            this.txt_sg_l_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sg_l_name.Location = new System.Drawing.Point(327, 43);
            this.txt_sg_l_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sg_l_name.Name = "txt_sg_l_name";
            this.txt_sg_l_name.Size = new System.Drawing.Size(301, 29);
            this.txt_sg_l_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(323, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txt_sg_f_name
            // 
            this.txt_sg_f_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sg_f_name.Location = new System.Drawing.Point(12, 43);
            this.txt_sg_f_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sg_f_name.Name = "txt_sg_f_name";
            this.txt_sg_f_name.Size = new System.Drawing.Size(301, 29);
            this.txt_sg_f_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 897D;
            this.reSize1.InitialHostContainerWidth = 1539D;
            this.reSize1.Tag = null;
            // 
            // sg_profiles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1539, 897);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sg_profiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE GUARD PROFILES";
            this.Load += new System.EventHandler(this.sg_profiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_guard_status.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.tab_container.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.contents_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

		}

		protected void SAVE_GUARD_DETAILS()
		{
			if (this.txt_sg_f_name.Text == string.Empty || this.txt_sg_l_name.Text == string.Empty || this.cbo_guard_status.Text == string.Empty)
			{
				MessageBox.Show("Fields Marked red are mandatory");
				return;
			}
			if (this.txt_guard_number_complete.Text == string.Empty)
			{
				MessageBox.Show("Guard Number cannot never be empty");
				return;
			}
			try
			{
				string text = this.txt_guard_number_complete.Text;
				string str = this.txt_sg_f_name.Text;
				string text1 = this.txt_sg_l_name.Text;
				string str1 = this.txt_sg_phone.Text;
				string text2 = this.cbo_branch.Text;
				string str2 = this.cbo_position.Text;
				string text3 = this.cbo_dept.Text;
				DateTime date = this.dt_registration_date.Value.Date;
				string str3 = this.txt_place_of_birth.Text;
				DateTime dateTime = this.dt_birthdate.Value.Date;
				int num = Convert.ToInt32(this.txt_age.Text);
				string text4 = this.cbo_gender.Text;
				string str4 = this.cbo_home_district.Text;
				string text5 = this.txt_home_county.Text;
				string str5 = this.txt_home_subcounty.Text;
				string text6 = this.txt_home_parish.Text;
				string str6 = this.txt_home_village.Text;
				string text7 = this.cbo_religion.Text;
				string str7 = this.cbo_marital_status.Text;
				string text8 = this.txt_partners_name.Text;
				string str8 = this.cbo_current_residence_district.Text;
				string text9 = this.txt_c_subcounty.Text;
				string str9 = this.txt_c_parish.Text;
				string text10 = this.txt_c_zone.Text;
				string str10 = this.txt_c_landlord.Text;
				string text11 = this.txt_f_name.Text;
				string str11 = this.cbo_f_district.Text;
				string text12 = this.txt_f_county.Text;
				string str12 = this.txt_f_village.Text;
				string text13 = this.txt_f_zone.Text;
				string str13 = this.txt_e_name.Text;
				string text14 = this.txt_e_adress.Text;
				string str14 = this.txt_departure_reason.Text;
				string text15 = this.txt_tin_number.Text;
				string str15 = this.txt_salary.Text;
				DateTime date1 = this.dtHire_date.Value.Date;
				string text16 = this.txt_i_name.Text;
				string str16 = this.txt_i_award.Text;
				DateTime dateTime1 = this.dt_i_from.Value.Date;
				DateTime value = this.dt_i_to.Value;
				sg_Profiles.SAVE_NEW_SG_PROFILE("SAVE_NEW_SG_PROFILE", text, str, text1, str1, text2, str2, text3, date, str3, dateTime, num, text4, str4, text5, str5, text6, str6, text7, str7, text8, str8, text9, str9, text10, str10, text11, str11, text12, str12, text13, str13, text14, str14, text15, str15, date1, text16, str16, dateTime1, value.Date, this.txt_i_referees.Text, this.cbo_guard_status.Text, this.cbo_bank_name.Text, this.txt_account_number.Text, this.txt_nssf_number.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
			MessageBox.Show("Successfully created SG Profile");
			this.GET_GUARD_LIST();
		}

		private void sg_profiles_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.GET_GUARD_LIST();
			this.GET_BRANCHES();
			this.GET_DEPARTMENTS();
			this.GET_POSITIONS();
			this.GET_BRANCHES_SEARCH();
			this.cbo_marital_status_SelectedIndexChanged(this.cbo_marital_status, null);
			this.chk_add.Checked = true;
			this.chk_edit.Checked = false;
			this.cbo_bank_name.SelectedIndex = 0;
		}

		private void txt_account_number_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.cbo_bank_name.Text == string.Empty)
			{
				MessageBox.Show("Bank name required", "Account Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.txt_account_number.Clear();
			}
		}

		private void txt_guard_number_static_code_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.txt_guard_number_auto_code.Text == string.Empty)
			{
				MessageBox.Show("Chose Guard Branch first");
				this.txt_guard_number_auto_code.Clear();
			}
		}

		private void txt_guard_number_static_code_TextAlignChanged(object sender, EventArgs e)
		{
		}

		private void txt_guard_number_static_code_TextChanged(object sender, EventArgs e)
		{
			if (!(this.txt_guard_number_auto_code.Text != string.Empty) || !(this.txt_guard_number_static_code.Text != string.Empty))
			{
				this.txt_guard_number_complete.Clear();
				return;
			}
			this.txt_guard_number_complete.Text = string.Concat(this.txt_guard_number_auto_code.Text, this.txt_guard_number_static_code.Text);
		}

		protected void UPDATE_GUARD_DETAILS(string record_guid)
		{
			if (this.txt_sg_f_name.Text == string.Empty || this.txt_sg_l_name.Text == string.Empty || this.cbo_guard_status.Text == string.Empty)
			{
				MessageBox.Show("Fields Marked red are mandatory");
				return;
			}
			if (this.cbo_guard_status.Text == "Deserted" || this.cbo_guard_status.Text == "Died" || this.cbo_guard_status.Text == "Dismissed" || this.cbo_guard_status.Text == "Resigned" || this.cbo_guard_status.Text == "Retired" || this.cbo_guard_status.Text == "Terminated" || this.cbo_guard_status.Text == "Confined")
			{
				System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(string.Concat("Setting guard status to ", this.cbo_guard_status.Text, " Will automatically archieve his/her details and will be removed from active guards.This cannot be undone.proceed??"), "Change Guard Status", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					try
					{
						string text = this.txt_sg_f_name.Text;
						string str = this.txt_sg_l_name.Text;
						string text1 = this.txt_sg_phone.Text;
						string str1 = this.cbo_branch.Text;
						string text2 = this.cbo_position.Text;
						string str2 = this.cbo_dept.Text;
						DateTime date = this.dt_registration_date.Value.Date;
						string text3 = this.txt_place_of_birth.Text;
						DateTime dateTime = this.dt_birthdate.Value.Date;
						int num = Convert.ToInt32(this.txt_age.Text);
						string str3 = this.cbo_gender.Text;
						string text4 = this.cbo_home_district.Text;
						string str4 = this.txt_home_county.Text;
						string text5 = this.txt_home_subcounty.Text;
						string str5 = this.txt_home_parish.Text;
						string text6 = this.txt_home_village.Text;
						string str6 = this.cbo_religion.Text;
						string text7 = this.cbo_marital_status.Text;
						string str7 = this.txt_partners_name.Text;
						string text8 = this.cbo_current_residence_district.Text;
						string str8 = this.txt_c_subcounty.Text;
						string text9 = this.txt_c_parish.Text;
						string str9 = this.txt_c_zone.Text;
						string text10 = this.txt_c_landlord.Text;
						string str10 = this.txt_f_name.Text;
						string text11 = this.cbo_f_district.Text;
						string str11 = this.txt_f_county.Text;
						string text12 = this.txt_f_village.Text;
						string str12 = this.txt_f_zone.Text;
						string text13 = this.txt_e_name.Text;
						string str13 = this.txt_e_adress.Text;
						string text14 = this.txt_departure_reason.Text;
						string str14 = this.txt_tin_number.Text;
						string text15 = this.txt_salary.Text;
						DateTime date1 = this.dtHire_date.Value.Date;
						string str15 = this.txt_i_name.Text;
						string text16 = this.txt_i_award.Text;
						DateTime dateTime1 = this.dt_i_from.Value.Date;
						DateTime value = this.dt_i_to.Value;
						sg_Profiles.UPDATE_GUARD_DETAILS("UPDATE_GUARD_DETAILS", record_guid, text, str, text1, str1, text2, str2, date, text3, dateTime, num, str3, text4, str4, text5, str5, text6, str6, text7, str7, text8, str8, text9, str9, text10, str10, text11, str11, text12, str12, text13, str13, text14, str14, text15, date1, str15, text16, dateTime1, value.Date, this.txt_i_referees.Text, this.cbo_guard_status.Text, this.cbo_bank_name.Text, this.txt_account_number.Text, this.txt_nssf_number.Text);
						this.ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD();
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.ToString());
					}
				}
				else if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
					return;
				}
			}
			else
			{
				try
				{
					string str16 = this.txt_sg_f_name.Text;
					string text17 = this.txt_sg_l_name.Text;
					string str17 = this.txt_sg_phone.Text;
					string text18 = this.cbo_branch.Text;
					string str18 = this.cbo_position.Text;
					string text19 = this.cbo_dept.Text;
					DateTime date2 = this.dt_registration_date.Value.Date;
					string str19 = this.txt_place_of_birth.Text;
					DateTime dateTime2 = this.dt_birthdate.Value.Date;
					int num1 = Convert.ToInt32(this.txt_age.Text);
					string text20 = this.cbo_gender.Text;
					string str20 = this.cbo_home_district.Text;
					string text21 = this.txt_home_county.Text;
					string str21 = this.txt_home_subcounty.Text;
					string text22 = this.txt_home_parish.Text;
					string str22 = this.txt_home_village.Text;
					string text23 = this.cbo_religion.Text;
					string str23 = this.cbo_marital_status.Text;
					string text24 = this.txt_partners_name.Text;
					string str24 = this.cbo_current_residence_district.Text;
					string text25 = this.txt_c_subcounty.Text;
					string str25 = this.txt_c_parish.Text;
					string text26 = this.txt_c_zone.Text;
					string str26 = this.txt_c_landlord.Text;
					string text27 = this.txt_f_name.Text;
					string str27 = this.cbo_f_district.Text;
					string text28 = this.txt_f_county.Text;
					string str28 = this.txt_f_village.Text;
					string text29 = this.txt_f_zone.Text;
					string str29 = this.txt_e_name.Text;
					string text30 = this.txt_e_adress.Text;
					string str30 = this.txt_departure_reason.Text;
					string text31 = this.txt_tin_number.Text;
					string str31 = this.txt_salary.Text;
					DateTime date3 = this.dtHire_date.Value.Date;
					string text32 = this.txt_i_name.Text;
					string str32 = this.txt_i_award.Text;
					DateTime dateTime3 = this.dt_i_from.Value.Date;
					DateTime value1 = this.dt_i_to.Value;
					sg_Profiles.UPDATE_GUARD_DETAILS("UPDATE_GUARD_DETAILS", record_guid, str16, text17, str17, text18, str18, text19, date2, str19, dateTime2, num1, text20, str20, text21, str21, text22, str22, text23, str23, text24, str24, text25, str25, text26, str26, text27, str27, text28, str28, text29, str29, text30, str30, text31, str31, date3, text32, str32, dateTime3, value1.Date, this.txt_i_referees.Text, this.cbo_guard_status.Text, this.cbo_bank_name.Text, this.txt_account_number.Text, this.txt_nssf_number.Text);
				}
				catch (Exception exception1)
				{
					MessageBox.Show(exception1.ToString());
				}
				MessageBox.Show("Successfully updated SG Profile");
			}
		}

        private void btn_branch_search_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbo_branch_search.Text == string.Empty && txt_name_search.Text == string.Empty && txt_guard_number_search.Text == string.Empty)
            {

                this.GET_GUARD_LIST();
            }
            else
            {
                DataTable dt = sg_Profiles.hr_SEARCH_GUARDS_BY_BRANCH("SEARCH_GUARDS_BY_BRANCH", cbo_branch_search.Text, txt_name_search.Text, txt_guard_number_search.Text);
          
                if (dt !=  null)
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
    }
}