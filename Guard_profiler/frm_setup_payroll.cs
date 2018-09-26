using Guard_profiler.App_code;
using Guard_profiler.Properties;
using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_setup_payroll : Form
	{
		private static decimal _Total_cash_deductions;

		private IContainer components;

		private Panel panel1;

		private Label label5;

		private DateTimePicker dt_end_date;

		private Label label4;

		private Label label6;

		private DateTimePicker dt_start_date;

		private Panel panel2;

		private Panel panel3;

		private Button btn_search;

		private Label label1;

		private TextBox txt_guard_number;

		private ComboBox cbo_branch;

		private Label label9;

		private Panel panel4;

		private DataGridView gdv_guards;

		private Label label2;

		private Panel panel5;

		//private ReSize reSize1;

		private GroupBox groupBox1;

		private TextBox txt_salary_scale_code;

		private Label label12;

		private TextBox txt_guard_name;

		private Label label11;

		private TextBox txt_guard_num;

		private Label label10;

		private TextBox txt_station_name;

		private Label label8;

		private TextBox txt_station_code;

		private Label label7;

		private Label label13;

		private TextBox textBox6;

		private GroupBox groupBox2;

		private Label label14;

		private TextBox txt_bank_code;

		private Label label15;

		private TextBox txt_bank_name;

		private TextBox txt_bank_branch;

		private Label label16;

		private Label label17;

		private TextBox txt_account_number;

		private Label label18;

		private TextBox txt_grade;

		private Label label19;

		private TextBox txt_nssf;

		private Label label20;

		private Panel panel6;

		private Label label21;

		private TextBox txt_basic_amt;

		private Label label22;

		private TextBox txt_over_time_amt;

		private Label label23;

		private TextBox txt_transport_amt;

		private Label label24;

		private TextBox txt_housing_amt;

		private Label label25;

		private TextBox txt_resident_amt;

		private Label label26;

		private TextBox txt_special_amt;

		private Label label27;

		private TextBox txt_bonus_amt;

		private Label label28;

		private TextBox txt_arrears_amt;

		private Label label29;

		private TextBox txt_leave_amt;

		private Label label30;

		private TextBox txt_advance_amt;

		private Panel panel7;

		private Label label31;

		private Label label32;

		private TextBox txt_uniform_amt;

		private Label label33;

		private TextBox txt_penalty_amt;

		private Label label34;

		private TextBox txt_lst_amt;

		private Label label35;

		private TextBox txt_absentism_amt;

		private Label label36;

		private TextBox txt_days_worked;

		private Label label37;

		private TextBox txt_overtime_days;

		private Label label38;

		private TextBox txt_days_resident;

		private Label label39;

		private TextBox txt_penalty_days;

		private Label label40;

		private Panel panel8;

		private CheckBox chk_pay_salary;

		private CheckBox chk_pay_nssf;

		private CheckBox chk_pay_paye;

		private CheckBox chk_pay_advance;

		private Label label41;

		private Panel panel9;

		private Label label42;

		private TextBox txt_gross_amt;

		private Label label43;

		private TextBox txt_paye_amt;

		private Label label44;

		private TextBox txt_nssf_amt;

		private Label label46;

		private TextBox txt_total_deductions;

		private Label label47;

		private TextBox txt_net_pay;

		private Panel panel10;

		private Button btn_save;

		private Button btn_report;

		private TextBox txt_tax_relief;

		private Label label48;

		private Panel panel11;

		private PictureBox picBoxImage;
        private ReSize reSize1;
        private TextBox txt_record_guid;

		static frm_setup_payroll()
		{
		}

		public frm_setup_payroll()
		{
			this.InitializeComponent();
		}

		private void btn_report_Click(object sender, EventArgs e)
		{
			(new frm_finance_reports_dashboard()).ShowDialog();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_num.Text == string.Empty)
			{
				MessageBox.Show("Select a guard and make sure to enter all required fields.save faild!!", "Payroll setup", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(string.Concat("Are sure you want to save payroll details for ", this.txt_guard_name.Text, "?.You can still edit after saving"), "Payroll setup", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				this.save_update_guard_payment_details();
				return;
			}
			if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				base.Visible = true;
			}
		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			if (this.cbo_branch.Text == string.Empty && this.txt_guard_number.Text == string.Empty)
			{
				this.select_list_of_guards_for_payroll_setup_all();
				return;
			}
			this.select_list_of_guards_for_payroll_setup(this.cbo_branch.Text);
		}

		protected void Calculate_guard_salary_amounts()
		{
			bool flag;
			decimal basic_amt = (this.txt_basic_amt.Text != string.Empty ? decimal.Parse(this.txt_basic_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal transport_amt = (this.txt_transport_amt.Text != string.Empty ? decimal.Parse(this.txt_transport_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal resident_amt = (this.txt_resident_amt.Text != string.Empty ? decimal.Parse(this.txt_resident_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal bonus_amt = (this.txt_bonus_amt.Text != string.Empty ? decimal.Parse(this.txt_bonus_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal leave_amt = (this.txt_leave_amt.Text != string.Empty ? decimal.Parse(this.txt_leave_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal over_time_amt = (this.txt_over_time_amt.Text != string.Empty ? decimal.Parse(this.txt_over_time_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal housing_amt = (this.txt_housing_amt.Text != string.Empty ? decimal.Parse(this.txt_housing_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal special_amt = (this.txt_special_amt.Text != string.Empty ? decimal.Parse(this.txt_special_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal _Gross_amount = ((((((basic_amt + transport_amt) + resident_amt) + bonus_amt) + leave_amt) + over_time_amt) + housing_amt) + special_amt;
			decimal uniform_amt = (this.txt_uniform_amt.Text != string.Empty ? decimal.Parse(this.txt_uniform_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal lst_amt = (this.txt_lst_amt.Text != string.Empty ? decimal.Parse(this.txt_lst_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal arrears_amt = (this.txt_arrears_amt.Text != string.Empty ? decimal.Parse(this.txt_arrears_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal advance_amt = (this.txt_advance_amt.Text != string.Empty ? decimal.Parse(this.txt_advance_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal penalty_amt = (this.txt_penalty_amt.Text != string.Empty ? decimal.Parse(this.txt_penalty_amt.Text) : new decimal(0, 0, 0, false, 1));
			decimal absentism_amt = (this.txt_absentism_amt.Text != string.Empty ? decimal.Parse(this.txt_absentism_amt.Text) : new decimal(0, 0, 0, false, 1));
			frm_setup_payroll._Total_cash_deductions = ((((uniform_amt + lst_amt) + arrears_amt) + advance_amt) + penalty_amt) + absentism_amt;
			decimal PAYE_amt = this.Calculate_PAYE(_Gross_amount);
			decimal Nssf_amt = this.Calculate_NSSF(_Gross_amount);
			frm_setup_payroll._Total_cash_deductions = (frm_setup_payroll._Total_cash_deductions + PAYE_amt) + Nssf_amt;
			decimal _Net_Pay = _Gross_amount - frm_setup_payroll._Total_cash_deductions;
			this.txt_gross_amt.Text = _Gross_amount.ToString();
			this.txt_paye_amt.Text = PAYE_amt.ToString();
			this.txt_nssf_amt.Text = Nssf_amt.ToString();
			this.txt_total_deductions.Text = frm_setup_payroll._Total_cash_deductions.ToString();
			this.txt_net_pay.Text = _Net_Pay.ToString();
			CheckBox chkPayAdvance = this.chk_pay_advance;
			if (this.txt_advance_amt.Text != string.Empty)
			{
				flag = (float.Parse(this.txt_advance_amt.Text) > 0f ? true : false);
			}
			else
			{
				flag = false;
			}
			chkPayAdvance.Checked = flag;
			this.chk_pay_nssf.Checked = (Nssf_amt > new decimal(0) ? true : false);
			this.chk_pay_paye.Checked = (PAYE_amt > new decimal(0) ? true : false);
		}

		protected decimal Calculate_NSSF(decimal gross_amt)
		{
			decimal Nssf_amout = new decimal(0);
			Nssf_amout = new decimal(5, 0, 0, false, 2) * gross_amt;
			return Nssf_amout;
		}

		protected decimal Calculate_PAYE(decimal gross_amt)
		{
			decimal PAYE_amt = new decimal(0);
			if (gross_amt < new decimal(235000))
			{
				PAYE_amt = new decimal(0);
			}
			else if (gross_amt >= new decimal(235000) && gross_amt <= new decimal(335000))
			{
				PAYE_amt = new decimal(1, 0, 0, false, 1) * gross_amt;
			}
			else if (gross_amt >= new decimal(335000) && gross_amt <= new decimal(410000))
			{
				PAYE_amt = new decimal(2, 0, 0, false, 1) * gross_amt;
			}
			else if (gross_amt >= new decimal(410000) && gross_amt <= new decimal(10000000))
			{
				PAYE_amt = new decimal(3, 0, 0, false, 1) * gross_amt;
			}
			else if (gross_amt > new decimal(10000000))
			{
				PAYE_amt = new decimal(4, 0, 0, false, 1) * gross_amt;
			}
			return PAYE_amt;
		}

		protected void clear_fields()
		{
			this.txt_station_code.Clear();
			this.txt_station_name.Clear();
			this.txt_guard_num.Clear();
			this.txt_guard_name.Clear();
			this.txt_salary_scale_code.Clear();
			this.txt_record_guid.Clear();
			this.txt_bank_code.Clear();
			this.txt_bank_name.Clear();
			this.txt_bank_branch.Clear();
			this.txt_account_number.Clear();
			this.txt_grade.Clear();
			this.txt_nssf.Clear();
			this.txt_basic_amt.Clear();
			this.txt_transport_amt.Clear();
			this.txt_housing_amt.Clear();
			this.txt_over_time_amt.Clear();
			this.txt_resident_amt.Clear();
			this.txt_special_amt.Clear();
			this.txt_arrears_amt.Clear();
			this.txt_advance_amt.Clear();
			this.txt_uniform_amt.Clear();
			this.txt_penalty_amt.Clear();
			this.txt_days_worked.Clear();
			this.txt_overtime_days.Clear();
			this.txt_penalty_days.Clear();
			this.txt_absentism_amt.Clear();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_setup_payroll_Load(object sender, EventArgs e)
		{
			this.dt_start_date.Value = SystemConst._deployment_start_date;
			this.dt_end_date.Value = SystemConst._deployment_end_date;
			base.WindowState = FormWindowState.Maximized;
			this.GET_BRANCHES();
			this.select_list_of_guards_for_payroll_setup_all();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_guards.Rows.Count > 0)
			{
				string guard_number = this.gdv_guards.CurrentRow.Cells[1].Value.ToString();
				DataTable dt_guard_pay_roll_details = Payroll_Engine.select_guard_payroll_details_by_deploy_id("select_guard_payroll_details_by_deploy_id", guard_number, Convert.ToInt32(SystemConst._active_deployment_id));
				if (dt_guard_pay_roll_details.Rows.Count > 0)
				{
					this.clear_fields();
					DataRow dtrow = dt_guard_pay_roll_details.Rows[0];
					this.txt_station_code.Text = dtrow["station_code"].ToString();
					this.txt_station_name.Text = dtrow["station_name"].ToString();
					this.txt_guard_num.Text = dtrow["guard_number"].ToString();
					this.txt_guard_name.Text = dtrow["guard_name"].ToString();
					this.txt_salary_scale_code.Text = dtrow["salary_scale_code"].ToString();
					this.txt_record_guid.Text = dtrow["record_guid"].ToString();
					this.txt_bank_code.Text = dtrow["bank_code"].ToString();
					this.txt_bank_name.Text = dtrow["bank_name"].ToString();
					this.txt_bank_branch.Text = dtrow["bank_branch"].ToString();
					this.txt_account_number.Text = dtrow["bank_account_number"].ToString();
					this.txt_grade.Text = dtrow["grade"].ToString();
					this.txt_nssf.Text = dtrow["nssf_number"].ToString();
					TextBox txtBasicAmt = this.txt_basic_amt;
					decimal num = decimal.Parse(dtrow["basic_amt"].ToString());
					txtBasicAmt.Text = num.ToString();
					TextBox txtTransportAmt = this.txt_transport_amt;
					decimal num1 = decimal.Parse(dtrow["transport_amt"].ToString());
					txtTransportAmt.Text = num1.ToString();
					TextBox txtHousingAmt = this.txt_housing_amt;
					decimal num2 = decimal.Parse(dtrow["housing_amt"].ToString());
					txtHousingAmt.Text = num2.ToString();
					TextBox txtOverTimeAmt = this.txt_over_time_amt;
					decimal num3 = decimal.Parse(dtrow["overtime_amt"].ToString());
					txtOverTimeAmt.Text = num3.ToString();
					TextBox txtResidentAmt = this.txt_resident_amt;
					decimal num4 = decimal.Parse(dtrow["resident_amt"].ToString());
					txtResidentAmt.Text = num4.ToString();
					TextBox txtSpecialAmt = this.txt_special_amt;
					decimal num5 = decimal.Parse(dtrow["special_amt"].ToString());
					txtSpecialAmt.Text = num5.ToString();
					TextBox txtArrearsAmt = this.txt_arrears_amt;
					decimal num6 = decimal.Parse(dtrow["arrears_amt"].ToString());
					txtArrearsAmt.Text = num6.ToString();
					TextBox txtAdvanceAmt = this.txt_advance_amt;
					decimal num7 = decimal.Parse(dtrow["advance_amt"].ToString());
					txtAdvanceAmt.Text = num7.ToString();
					TextBox txtUniformAmt = this.txt_uniform_amt;
					decimal num8 = decimal.Parse(dtrow["uniform_amt"].ToString());
					txtUniformAmt.Text = num8.ToString();
					TextBox txtPenaltyAmt = this.txt_penalty_amt;
					decimal num9 = decimal.Parse(dtrow["penalty_amt"].ToString());
					txtPenaltyAmt.Text = num9.ToString();
					TextBox txtDaysWorked = this.txt_days_worked;
					int num10 = Convert.ToInt32(dtrow["total_days_worked"].ToString());
					txtDaysWorked.Text = num10.ToString();
					TextBox txtOvertimeDays = this.txt_overtime_days;
					int num11 = Convert.ToInt32(dtrow["total_overtime_days_worked"].ToString());
					txtOvertimeDays.Text = num11.ToString();
					TextBox txtPenaltyDays = this.txt_penalty_days;
					int num12 = Convert.ToInt32(dtrow["total_penalty_days"].ToString());
					txtPenaltyDays.Text = num12.ToString();
					TextBox txtAbsentismAmt = this.txt_absentism_amt;
					decimal num13 = decimal.Parse(dtrow["absentism_amt"].ToString());
					txtAbsentismAmt.Text = num13.ToString();
					this.GET_OFFICER_HEADSHOT("select_officer_headshot_by_guard_number", guard_number);
					return;
				}
				this.clear_fields();
				this.return_guard_details_for_payroll_setup(guard_number);
				this.GET_OFFICER_HEADSHOT("select_officer_headshot_by_guard_number", guard_number);
			}
		}

		private void gdv_guards_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
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

		protected void GET_OFFICER_HEADSHOT(string query, string guard_number)
		{
			DataTable dt = HeadShotEngine.select_officer_headshot_by_guard_number(query, guard_number);
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

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_setup_payroll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_record_guid = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_net_pay = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_total_deductions = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txt_nssf_amt = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_paye_amt = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txt_gross_amt = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_tax_relief = new System.Windows.Forms.TextBox();
            this.chk_pay_advance = new System.Windows.Forms.CheckBox();
            this.chk_pay_nssf = new System.Windows.Forms.CheckBox();
            this.chk_pay_paye = new System.Windows.Forms.CheckBox();
            this.chk_pay_salary = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_penalty_days = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_days_resident = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_overtime_days = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_days_worked = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_absentism_amt = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_lst_amt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_penalty_amt = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_uniform_amt = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_advance_amt = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_leave_amt = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_arrears_amt = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_bonus_amt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_special_amt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_resident_amt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_housing_amt = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_transport_amt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_over_time_amt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_basic_amt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nssf = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_account_number = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_bank_branch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_bank_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_bank_code = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_salary_scale_code = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_guard_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_guard_num = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_station_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_station_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dt_end_date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_start_date);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 39);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Always confirm all guard\'s deployment records have\r\n been fully entered by the WA" +
    "GES department";
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(745, 4);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(117, 21);
            this.dt_end_date.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pay-roll setup for the period of:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(712, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start_date.Location = new System.Drawing.Point(569, 4);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(128, 21);
            this.dt_start_date.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_record_guid);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(1, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 603);
            this.panel2.TabIndex = 2;
            // 
            // txt_record_guid
            // 
            this.txt_record_guid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_record_guid.Location = new System.Drawing.Point(716, 236);
            this.txt_record_guid.Name = "txt_record_guid";
            this.txt_record_guid.ReadOnly = true;
            this.txt_record_guid.Size = new System.Drawing.Size(282, 20);
            this.txt_record_guid.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.Controls.Add(this.label48);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label41);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(6, 255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(995, 355);
            this.panel5.TabIndex = 28;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(371, 259);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(62, 15);
            this.label48.TabIndex = 85;
            this.label48.Text = "Tax Relief";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.btn_report);
            this.panel10.Controls.Add(this.btn_save);
            this.panel10.Location = new System.Drawing.Point(8, 305);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(455, 43);
            this.panel10.TabIndex = 46;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.Orange;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.Location = new System.Drawing.Point(155, 3);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(159, 38);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "VIEW OR EXPORT REPORTS";
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(147, 38);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE PAYROLL RECORD";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Controls.Add(this.txt_net_pay);
            this.panel9.Controls.Add(this.label47);
            this.panel9.Controls.Add(this.txt_total_deductions);
            this.panel9.Controls.Add(this.label46);
            this.panel9.Controls.Add(this.txt_nssf_amt);
            this.panel9.Controls.Add(this.label44);
            this.panel9.Controls.Add(this.txt_paye_amt);
            this.panel9.Controls.Add(this.label43);
            this.panel9.Controls.Add(this.txt_gross_amt);
            this.panel9.Controls.Add(this.label42);
            this.panel9.Location = new System.Drawing.Point(469, 277);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 70);
            this.panel9.TabIndex = 45;
            // 
            // txt_net_pay
            // 
            this.txt_net_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_net_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_net_pay.ForeColor = System.Drawing.Color.White;
            this.txt_net_pay.Location = new System.Drawing.Point(425, 24);
            this.txt_net_pay.Name = "txt_net_pay";
            this.txt_net_pay.Size = new System.Drawing.Size(94, 31);
            this.txt_net_pay.TabIndex = 95;
            this.txt_net_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(439, 6);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(56, 15);
            this.label47.TabIndex = 94;
            this.label47.Text = "NET PAY";
            // 
            // txt_total_deductions
            // 
            this.txt_total_deductions.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_total_deductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_deductions.ForeColor = System.Drawing.Color.White;
            this.txt_total_deductions.Location = new System.Drawing.Point(329, 24);
            this.txt_total_deductions.Name = "txt_total_deductions";
            this.txt_total_deductions.ReadOnly = true;
            this.txt_total_deductions.Size = new System.Drawing.Size(96, 31);
            this.txt_total_deductions.TabIndex = 93;
            this.txt_total_deductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(326, 6);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(80, 15);
            this.label46.TabIndex = 92;
            this.label46.Text = "T-Deductions";
            // 
            // txt_nssf_amt
            // 
            this.txt_nssf_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_nssf_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nssf_amt.ForeColor = System.Drawing.Color.White;
            this.txt_nssf_amt.Location = new System.Drawing.Point(230, 24);
            this.txt_nssf_amt.Name = "txt_nssf_amt";
            this.txt_nssf_amt.ReadOnly = true;
            this.txt_nssf_amt.Size = new System.Drawing.Size(99, 31);
            this.txt_nssf_amt.TabIndex = 89;
            this.txt_nssf_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(227, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(39, 15);
            this.label44.TabIndex = 88;
            this.label44.Text = "NSSF";
            // 
            // txt_paye_amt
            // 
            this.txt_paye_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_paye_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paye_amt.ForeColor = System.Drawing.Color.White;
            this.txt_paye_amt.Location = new System.Drawing.Point(120, 24);
            this.txt_paye_amt.Name = "txt_paye_amt";
            this.txt_paye_amt.ReadOnly = true;
            this.txt_paye_amt.Size = new System.Drawing.Size(104, 31);
            this.txt_paye_amt.TabIndex = 87;
            this.txt_paye_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(117, 5);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 15);
            this.label43.TabIndex = 86;
            this.label43.Text = "PAYE";
            // 
            // txt_gross_amt
            // 
            this.txt_gross_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_gross_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gross_amt.ForeColor = System.Drawing.Color.White;
            this.txt_gross_amt.Location = new System.Drawing.Point(3, 24);
            this.txt_gross_amt.Name = "txt_gross_amt";
            this.txt_gross_amt.ReadOnly = true;
            this.txt_gross_amt.Size = new System.Drawing.Size(111, 31);
            this.txt_gross_amt.TabIndex = 85;
            this.txt_gross_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(10, 5);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(63, 15);
            this.label42.TabIndex = 85;
            this.label42.Text = "Gross Amt";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Lime;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(464, 259);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(138, 15);
            this.label41.TabIndex = 44;
            this.label41.Text = "Staff Payment Summary";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.txt_tax_relief);
            this.panel8.Controls.Add(this.chk_pay_advance);
            this.panel8.Controls.Add(this.chk_pay_nssf);
            this.panel8.Controls.Add(this.chk_pay_paye);
            this.panel8.Controls.Add(this.chk_pay_salary);
            this.panel8.Location = new System.Drawing.Point(8, 277);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(455, 25);
            this.panel8.TabIndex = 43;
            // 
            // txt_tax_relief
            // 
            this.txt_tax_relief.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_tax_relief.ForeColor = System.Drawing.Color.White;
            this.txt_tax_relief.Location = new System.Drawing.Point(365, 3);
            this.txt_tax_relief.Name = "txt_tax_relief";
            this.txt_tax_relief.Size = new System.Drawing.Size(87, 20);
            this.txt_tax_relief.TabIndex = 47;
            this.txt_tax_relief.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_pay_advance
            // 
            this.chk_pay_advance.AutoSize = true;
            this.chk_pay_advance.BackColor = System.Drawing.Color.Gray;
            this.chk_pay_advance.Enabled = false;
            this.chk_pay_advance.Location = new System.Drawing.Point(269, 3);
            this.chk_pay_advance.Name = "chk_pay_advance";
            this.chk_pay_advance.Size = new System.Drawing.Size(90, 17);
            this.chk_pay_advance.TabIndex = 3;
            this.chk_pay_advance.Text = "Pay Advance";
            this.chk_pay_advance.UseVisualStyleBackColor = false;
            // 
            // chk_pay_nssf
            // 
            this.chk_pay_nssf.AutoSize = true;
            this.chk_pay_nssf.BackColor = System.Drawing.Color.Gray;
            this.chk_pay_nssf.Enabled = false;
            this.chk_pay_nssf.Location = new System.Drawing.Point(188, 3);
            this.chk_pay_nssf.Name = "chk_pay_nssf";
            this.chk_pay_nssf.Size = new System.Drawing.Size(75, 17);
            this.chk_pay_nssf.TabIndex = 2;
            this.chk_pay_nssf.Text = "Pay NSSF";
            this.chk_pay_nssf.UseVisualStyleBackColor = false;
            // 
            // chk_pay_paye
            // 
            this.chk_pay_paye.AutoSize = true;
            this.chk_pay_paye.BackColor = System.Drawing.Color.Gray;
            this.chk_pay_paye.Enabled = false;
            this.chk_pay_paye.Location = new System.Drawing.Point(101, 3);
            this.chk_pay_paye.Name = "chk_pay_paye";
            this.chk_pay_paye.Size = new System.Drawing.Size(75, 17);
            this.chk_pay_paye.TabIndex = 1;
            this.chk_pay_paye.Text = "Pay PAYE";
            this.chk_pay_paye.UseVisualStyleBackColor = false;
            // 
            // chk_pay_salary
            // 
            this.chk_pay_salary.AutoSize = true;
            this.chk_pay_salary.BackColor = System.Drawing.Color.Gray;
            this.chk_pay_salary.Checked = true;
            this.chk_pay_salary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_pay_salary.Enabled = false;
            this.chk_pay_salary.Location = new System.Drawing.Point(9, 3);
            this.chk_pay_salary.Name = "chk_pay_salary";
            this.chk_pay_salary.Size = new System.Drawing.Size(76, 17);
            this.chk_pay_salary.TabIndex = 0;
            this.chk_pay_salary.Text = "Pay Salary";
            this.chk_pay_salary.UseVisualStyleBackColor = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Yellow;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(7, 259);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(102, 15);
            this.label40.TabIndex = 42;
            this.label40.Text = "Payment Settings";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Yellow;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(767, 135);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(149, 15);
            this.label31.TabIndex = 41;
            this.label31.Text = "Guard Deployment details";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.txt_penalty_days);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Controls.Add(this.txt_days_resident);
            this.panel7.Controls.Add(this.label38);
            this.panel7.Controls.Add(this.txt_overtime_days);
            this.panel7.Controls.Add(this.label37);
            this.panel7.Controls.Add(this.txt_days_worked);
            this.panel7.Controls.Add(this.label36);
            this.panel7.Location = new System.Drawing.Point(770, 153);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 103);
            this.panel7.TabIndex = 40;
            // 
            // txt_penalty_days
            // 
            this.txt_penalty_days.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_penalty_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penalty_days.ForeColor = System.Drawing.Color.White;
            this.txt_penalty_days.Location = new System.Drawing.Point(109, 69);
            this.txt_penalty_days.Name = "txt_penalty_days";
            this.txt_penalty_days.Size = new System.Drawing.Size(56, 26);
            this.txt_penalty_days.TabIndex = 91;
            this.txt_penalty_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(96, 51);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(77, 15);
            this.label39.TabIndex = 90;
            this.label39.Text = "Penalty Days";
            // 
            // txt_days_resident
            // 
            this.txt_days_resident.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_days_resident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days_resident.ForeColor = System.Drawing.Color.White;
            this.txt_days_resident.Location = new System.Drawing.Point(15, 69);
            this.txt_days_resident.Name = "txt_days_resident";
            this.txt_days_resident.Size = new System.Drawing.Size(56, 26);
            this.txt_days_resident.TabIndex = 89;
            this.txt_days_resident.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(3, 51);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 15);
            this.label38.TabIndex = 88;
            this.label38.Text = "Days Resident";
            // 
            // txt_overtime_days
            // 
            this.txt_overtime_days.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_overtime_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtime_days.ForeColor = System.Drawing.Color.White;
            this.txt_overtime_days.Location = new System.Drawing.Point(109, 22);
            this.txt_overtime_days.Name = "txt_overtime_days";
            this.txt_overtime_days.Size = new System.Drawing.Size(56, 26);
            this.txt_overtime_days.TabIndex = 87;
            this.txt_overtime_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(96, 4);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(86, 15);
            this.label37.TabIndex = 86;
            this.label37.Text = "Overtime Days";
            // 
            // txt_days_worked
            // 
            this.txt_days_worked.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_days_worked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_days_worked.ForeColor = System.Drawing.Color.White;
            this.txt_days_worked.Location = new System.Drawing.Point(15, 22);
            this.txt_days_worked.Name = "txt_days_worked";
            this.txt_days_worked.Size = new System.Drawing.Size(56, 26);
            this.txt_days_worked.TabIndex = 58;
            this.txt_days_worked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(3, 4);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 15);
            this.label36.TabIndex = 85;
            this.label36.Text = "Days worked";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Yellow;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(243, 15);
            this.label20.TabIndex = 29;
            this.label20.Text = "Payment Details(Additions and Deductions)";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.txt_absentism_amt);
            this.panel6.Controls.Add(this.label35);
            this.panel6.Controls.Add(this.txt_lst_amt);
            this.panel6.Controls.Add(this.label34);
            this.panel6.Controls.Add(this.txt_penalty_amt);
            this.panel6.Controls.Add(this.label33);
            this.panel6.Controls.Add(this.txt_uniform_amt);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Controls.Add(this.txt_advance_amt);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.txt_leave_amt);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.txt_arrears_amt);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.txt_bonus_amt);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.txt_special_amt);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.txt_resident_amt);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.txt_housing_amt);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.txt_transport_amt);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.txt_over_time_amt);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.txt_basic_amt);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Location = new System.Drawing.Point(8, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 103);
            this.panel6.TabIndex = 39;
            // 
            // txt_absentism_amt
            // 
            this.txt_absentism_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_absentism_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_absentism_amt.ForeColor = System.Drawing.Color.White;
            this.txt_absentism_amt.Location = new System.Drawing.Point(641, 69);
            this.txt_absentism_amt.Name = "txt_absentism_amt";
            this.txt_absentism_amt.ReadOnly = true;
            this.txt_absentism_amt.Size = new System.Drawing.Size(100, 26);
            this.txt_absentism_amt.TabIndex = 84;
            this.txt_absentism_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_absentism_amt.TextChanged += new System.EventHandler(this.txt_absentism_amt_TextChanged);
            this.txt_absentism_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_absentism_amt_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(638, 51);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(64, 15);
            this.label35.TabIndex = 83;
            this.label35.Text = "Absentism";
            // 
            // txt_lst_amt
            // 
            this.txt_lst_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_lst_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lst_amt.ForeColor = System.Drawing.Color.White;
            this.txt_lst_amt.Location = new System.Drawing.Point(641, 22);
            this.txt_lst_amt.Name = "txt_lst_amt";
            this.txt_lst_amt.Size = new System.Drawing.Size(100, 26);
            this.txt_lst_amt.TabIndex = 82;
            this.txt_lst_amt.Text = "0";
            this.txt_lst_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lst_amt.TextChanged += new System.EventHandler(this.txt_lst_amt_TextChanged);
            this.txt_lst_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lst_amt_KeyPress);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(638, 4);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(103, 15);
            this.label34.TabIndex = 81;
            this.label34.Text = "Local Service Tax";
            // 
            // txt_penalty_amt
            // 
            this.txt_penalty_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_penalty_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_penalty_amt.ForeColor = System.Drawing.Color.White;
            this.txt_penalty_amt.Location = new System.Drawing.Point(540, 69);
            this.txt_penalty_amt.Name = "txt_penalty_amt";
            this.txt_penalty_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_penalty_amt.TabIndex = 80;
            this.txt_penalty_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_penalty_amt.TextChanged += new System.EventHandler(this.txt_penalty_amt_TextChanged);
            this.txt_penalty_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_penalty_amt_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(537, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 15);
            this.label33.TabIndex = 79;
            this.label33.Text = "Penalty";
            // 
            // txt_uniform_amt
            // 
            this.txt_uniform_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_uniform_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uniform_amt.ForeColor = System.Drawing.Color.White;
            this.txt_uniform_amt.Location = new System.Drawing.Point(540, 22);
            this.txt_uniform_amt.Name = "txt_uniform_amt";
            this.txt_uniform_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_uniform_amt.TabIndex = 78;
            this.txt_uniform_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_uniform_amt.TextChanged += new System.EventHandler(this.txt_uniform_amt_TextChanged);
            this.txt_uniform_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_uniform_amt_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(539, 4);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 15);
            this.label32.TabIndex = 77;
            this.label32.Text = "Uniform";
            // 
            // txt_advance_amt
            // 
            this.txt_advance_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_advance_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_advance_amt.ForeColor = System.Drawing.Color.White;
            this.txt_advance_amt.Location = new System.Drawing.Point(442, 69);
            this.txt_advance_amt.Name = "txt_advance_amt";
            this.txt_advance_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_advance_amt.TabIndex = 76;
            this.txt_advance_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_advance_amt.TextChanged += new System.EventHandler(this.txt_advance_amt_TextChanged);
            this.txt_advance_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_advance_amt_KeyPress);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(439, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 15);
            this.label30.TabIndex = 75;
            this.label30.Text = "Advance";
            // 
            // txt_leave_amt
            // 
            this.txt_leave_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_leave_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leave_amt.ForeColor = System.Drawing.Color.White;
            this.txt_leave_amt.Location = new System.Drawing.Point(442, 22);
            this.txt_leave_amt.Name = "txt_leave_amt";
            this.txt_leave_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_leave_amt.TabIndex = 74;
            this.txt_leave_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_leave_amt.TextChanged += new System.EventHandler(this.txt_leave_amt_TextChanged);
            this.txt_leave_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_leave_amt_KeyPress);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(444, 4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 15);
            this.label29.TabIndex = 73;
            this.label29.Text = "Leave";
            // 
            // txt_arrears_amt
            // 
            this.txt_arrears_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_arrears_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_arrears_amt.ForeColor = System.Drawing.Color.White;
            this.txt_arrears_amt.Location = new System.Drawing.Point(346, 69);
            this.txt_arrears_amt.Name = "txt_arrears_amt";
            this.txt_arrears_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_arrears_amt.TabIndex = 72;
            this.txt_arrears_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_arrears_amt.TextChanged += new System.EventHandler(this.txt_arrears_amt_TextChanged);
            this.txt_arrears_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_arrears_amt_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(346, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 15);
            this.label28.TabIndex = 71;
            this.label28.Text = "Arrears";
            // 
            // txt_bonus_amt
            // 
            this.txt_bonus_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_bonus_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bonus_amt.ForeColor = System.Drawing.Color.White;
            this.txt_bonus_amt.Location = new System.Drawing.Point(346, 22);
            this.txt_bonus_amt.Name = "txt_bonus_amt";
            this.txt_bonus_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_bonus_amt.TabIndex = 70;
            this.txt_bonus_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bonus_amt.TextChanged += new System.EventHandler(this.txt_bonus_amt_TextChanged);
            this.txt_bonus_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bonus_amt_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(346, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 15);
            this.label27.TabIndex = 69;
            this.label27.Text = "Bonus";
            // 
            // txt_special_amt
            // 
            this.txt_special_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_special_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_special_amt.ForeColor = System.Drawing.Color.White;
            this.txt_special_amt.Location = new System.Drawing.Point(248, 69);
            this.txt_special_amt.Name = "txt_special_amt";
            this.txt_special_amt.ReadOnly = true;
            this.txt_special_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_special_amt.TabIndex = 68;
            this.txt_special_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_special_amt.TextChanged += new System.EventHandler(this.txt_special_amt_TextChanged);
            this.txt_special_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_special_amt_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(243, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 15);
            this.label26.TabIndex = 67;
            this.label26.Text = "Special";
            // 
            // txt_resident_amt
            // 
            this.txt_resident_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_resident_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resident_amt.ForeColor = System.Drawing.Color.White;
            this.txt_resident_amt.Location = new System.Drawing.Point(248, 22);
            this.txt_resident_amt.Name = "txt_resident_amt";
            this.txt_resident_amt.ReadOnly = true;
            this.txt_resident_amt.Size = new System.Drawing.Size(92, 26);
            this.txt_resident_amt.TabIndex = 66;
            this.txt_resident_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_resident_amt.TextChanged += new System.EventHandler(this.txt_resident_amt_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(243, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 15);
            this.label25.TabIndex = 65;
            this.label25.Text = "Resident";
            // 
            // txt_housing_amt
            // 
            this.txt_housing_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_housing_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_housing_amt.ForeColor = System.Drawing.Color.White;
            this.txt_housing_amt.Location = new System.Drawing.Point(127, 69);
            this.txt_housing_amt.Name = "txt_housing_amt";
            this.txt_housing_amt.ReadOnly = true;
            this.txt_housing_amt.Size = new System.Drawing.Size(115, 26);
            this.txt_housing_amt.TabIndex = 64;
            this.txt_housing_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(124, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 15);
            this.label24.TabIndex = 63;
            this.label24.Text = "Housing";
            // 
            // txt_transport_amt
            // 
            this.txt_transport_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_transport_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_transport_amt.ForeColor = System.Drawing.Color.White;
            this.txt_transport_amt.Location = new System.Drawing.Point(127, 22);
            this.txt_transport_amt.Name = "txt_transport_amt";
            this.txt_transport_amt.ReadOnly = true;
            this.txt_transport_amt.Size = new System.Drawing.Size(115, 26);
            this.txt_transport_amt.TabIndex = 62;
            this.txt_transport_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(126, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 15);
            this.label23.TabIndex = 61;
            this.label23.Text = "Transport Amt";
            // 
            // txt_over_time_amt
            // 
            this.txt_over_time_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_over_time_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_over_time_amt.ForeColor = System.Drawing.Color.White;
            this.txt_over_time_amt.Location = new System.Drawing.Point(5, 69);
            this.txt_over_time_amt.Name = "txt_over_time_amt";
            this.txt_over_time_amt.ReadOnly = true;
            this.txt_over_time_amt.Size = new System.Drawing.Size(115, 26);
            this.txt_over_time_amt.TabIndex = 60;
            this.txt_over_time_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 15);
            this.label22.TabIndex = 59;
            this.label22.Text = "Overtime Amt";
            // 
            // txt_basic_amt
            // 
            this.txt_basic_amt.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_basic_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_basic_amt.ForeColor = System.Drawing.Color.White;
            this.txt_basic_amt.Location = new System.Drawing.Point(5, 22);
            this.txt_basic_amt.Name = "txt_basic_amt";
            this.txt_basic_amt.ReadOnly = true;
            this.txt_basic_amt.Size = new System.Drawing.Size(115, 26);
            this.txt_basic_amt.TabIndex = 49;
            this.txt_basic_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 15);
            this.label21.TabIndex = 58;
            this.label21.Text = "Basic Amt";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.txt_nssf);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_grade);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txt_account_number);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txt_bank_branch);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_bank_name);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_bank_code);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 67);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank Details";
            // 
            // txt_nssf
            // 
            this.txt_nssf.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_nssf.Enabled = false;
            this.txt_nssf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nssf.ForeColor = System.Drawing.Color.White;
            this.txt_nssf.Location = new System.Drawing.Point(729, 34);
            this.txt_nssf.Name = "txt_nssf";
            this.txt_nssf.Size = new System.Drawing.Size(164, 26);
            this.txt_nssf.TabIndex = 57;
            this.txt_nssf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(726, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 56;
            this.label19.Text = "NSSF";
            // 
            // txt_grade
            // 
            this.txt_grade.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_grade.Enabled = false;
            this.txt_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grade.ForeColor = System.Drawing.Color.White;
            this.txt_grade.Location = new System.Drawing.Point(664, 34);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(56, 26);
            this.txt_grade.TabIndex = 55;
            this.txt_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(661, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 54;
            this.label18.Text = "Grade";
            // 
            // txt_account_number
            // 
            this.txt_account_number.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_account_number.Enabled = false;
            this.txt_account_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account_number.ForeColor = System.Drawing.Color.White;
            this.txt_account_number.Location = new System.Drawing.Point(461, 34);
            this.txt_account_number.Name = "txt_account_number";
            this.txt_account_number.Size = new System.Drawing.Size(200, 26);
            this.txt_account_number.TabIndex = 53;
            this.txt_account_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(294, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 15);
            this.label17.TabIndex = 52;
            this.label17.Text = "Bank Branch";
            // 
            // txt_bank_branch
            // 
            this.txt_bank_branch.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_bank_branch.Enabled = false;
            this.txt_bank_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bank_branch.ForeColor = System.Drawing.Color.White;
            this.txt_bank_branch.Location = new System.Drawing.Point(297, 34);
            this.txt_bank_branch.Name = "txt_bank_branch";
            this.txt_bank_branch.Size = new System.Drawing.Size(158, 26);
            this.txt_bank_branch.TabIndex = 49;
            this.txt_bank_branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(456, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "Bank A/C ";
            // 
            // txt_bank_name
            // 
            this.txt_bank_name.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_bank_name.Enabled = false;
            this.txt_bank_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bank_name.ForeColor = System.Drawing.Color.White;
            this.txt_bank_name.Location = new System.Drawing.Point(102, 34);
            this.txt_bank_name.Name = "txt_bank_name";
            this.txt_bank_name.Size = new System.Drawing.Size(192, 26);
            this.txt_bank_name.TabIndex = 49;
            this.txt_bank_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(99, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 50;
            this.label15.Text = "Bank Name";
            // 
            // txt_bank_code
            // 
            this.txt_bank_code.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_bank_code.Enabled = false;
            this.txt_bank_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bank_code.ForeColor = System.Drawing.Color.White;
            this.txt_bank_code.Location = new System.Drawing.Point(6, 34);
            this.txt_bank_code.Name = "txt_bank_code";
            this.txt_bank_code.Size = new System.Drawing.Size(67, 26);
            this.txt_bank_code.TabIndex = 49;
            this.txt_bank_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Bank Code";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_salary_scale_code);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_guard_name);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_guard_num);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_station_name);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_station_code);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 63);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guard Details";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(732, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 26);
            this.textBox6.TabIndex = 48;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(729, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 15);
            this.label13.TabIndex = 47;
            this.label13.Text = "Station Code";
            // 
            // txt_salary_scale_code
            // 
            this.txt_salary_scale_code.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_salary_scale_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary_scale_code.ForeColor = System.Drawing.Color.White;
            this.txt_salary_scale_code.Location = new System.Drawing.Point(812, 33);
            this.txt_salary_scale_code.Name = "txt_salary_scale_code";
            this.txt_salary_scale_code.ReadOnly = true;
            this.txt_salary_scale_code.Size = new System.Drawing.Size(84, 26);
            this.txt_salary_scale_code.TabIndex = 46;
            this.txt_salary_scale_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(812, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "Salary(A..F)";
            // 
            // txt_guard_name
            // 
            this.txt_guard_name.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_guard_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_name.ForeColor = System.Drawing.Color.White;
            this.txt_guard_name.Location = new System.Drawing.Point(462, 33);
            this.txt_guard_name.Name = "txt_guard_name";
            this.txt_guard_name.ReadOnly = true;
            this.txt_guard_name.Size = new System.Drawing.Size(261, 26);
            this.txt_guard_name.TabIndex = 44;
            this.txt_guard_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(459, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Guard Name";
            // 
            // txt_guard_num
            // 
            this.txt_guard_num.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_guard_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_num.ForeColor = System.Drawing.Color.White;
            this.txt_guard_num.Location = new System.Drawing.Point(335, 33);
            this.txt_guard_num.Name = "txt_guard_num";
            this.txt_guard_num.ReadOnly = true;
            this.txt_guard_num.Size = new System.Drawing.Size(123, 26);
            this.txt_guard_num.TabIndex = 42;
            this.txt_guard_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(332, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Guard Number";
            // 
            // txt_station_name
            // 
            this.txt_station_name.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_station_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_station_name.ForeColor = System.Drawing.Color.White;
            this.txt_station_name.Location = new System.Drawing.Point(105, 33);
            this.txt_station_name.Name = "txt_station_name";
            this.txt_station_name.ReadOnly = true;
            this.txt_station_name.Size = new System.Drawing.Size(224, 26);
            this.txt_station_name.TabIndex = 40;
            this.txt_station_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(102, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Station Name";
            // 
            // txt_station_code
            // 
            this.txt_station_code.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_station_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_station_code.ForeColor = System.Drawing.Color.White;
            this.txt_station_code.Location = new System.Drawing.Point(3, 33);
            this.txt_station_code.Name = "txt_station_code";
            this.txt_station_code.ReadOnly = true;
            this.txt_station_code.Size = new System.Drawing.Size(84, 26);
            this.txt_station_code.TabIndex = 38;
            this.txt_station_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Station Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Set up payroll for selected guard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.gdv_guards);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 231);
            this.panel4.TabIndex = 4;
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
            this.gdv_guards.Size = new System.Drawing.Size(989, 224);
            this.gdv_guards.TabIndex = 0;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            this.gdv_guards.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_guard_number);
            this.panel3.Controls.Add(this.cbo_branch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 28);
            this.panel3.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.Location = new System.Drawing.Point(551, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 23);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Guard Number";
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(427, 5);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(118, 21);
            this.txt_guard_number.TabIndex = 24;
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(99, 2);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(227, 23);
            this.cbo_branch.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Select a station";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.picBoxImage);
            this.panel11.Location = new System.Drawing.Point(917, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(85, 73);
            this.panel11.TabIndex = 33;
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Location = new System.Drawing.Point(0, 2);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(79, 65);
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
            this.reSize1.InitialHostContainerHeight = 679D;
            this.reSize1.InitialHostContainerWidth = 1004D;
            this.reSize1.Tag = null;
            // 
            // frm_setup_payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_setup_payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Uganda Securiko Ltd(Accounts-Setup Payroll)";
            this.Load += new System.EventHandler(this.frm_setup_payroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);

		}

		protected void return_guard_details_for_payroll_setup(string guard_number)
		{
			DateTime date = this.dt_start_date.Value.Date;
			DateTime value = this.dt_end_date.Value;
			DataTable dt = Payroll_Engine.select_payroll_details_for_selected_guard("select_payroll_details_for_selected_guard", guard_number, date, value.Date);
			if (dt.Rows.Count != 0)
			{
				DataRow dtrow = dt.Rows[0];
				this.txt_station_code.Text = dtrow["branch_code"].ToString();
				this.txt_station_name.Text = dtrow["branch"].ToString();
				this.txt_guard_num.Text = dtrow["guard_number"].ToString();
				this.txt_guard_name.Text = dtrow["full_name"].ToString();
				this.txt_salary_scale_code.Text = dtrow["scale_name"].ToString();
				TextBox txtBasicAmt = this.txt_basic_amt;
				float single = float.Parse(dtrow["basic_amount"].ToString());
				txtBasicAmt.Text = single.ToString();
				TextBox txtTransportAmt = this.txt_transport_amt;
				float single1 = float.Parse(dtrow["transport_amount"].ToString());
				txtTransportAmt.Text = single1.ToString();
				TextBox txtHousingAmt = this.txt_housing_amt;
				float single2 = float.Parse(dtrow["housing_amount"].ToString());
				txtHousingAmt.Text = single2.ToString();
				TextBox txtOverTimeAmt = this.txt_over_time_amt;
				float single3 = float.Parse(dtrow["overtime_amt"].ToString());
				txtOverTimeAmt.Text = single3.ToString();
				TextBox txtResidentAmt = this.txt_resident_amt;
				float single4 = float.Parse(dtrow["residential_cost"].ToString());
				txtResidentAmt.Text = single4.ToString();
				TextBox txtSpecialAmt = this.txt_special_amt;
				float single5 = float.Parse(dtrow["special_cash_additions"].ToString());
				txtSpecialAmt.Text = single5.ToString();
				TextBox txtArrearsAmt = this.txt_arrears_amt;
				float single6 = float.Parse(dtrow["total_arrears_in_month"].ToString());
				txtArrearsAmt.Text = single6.ToString();
				TextBox txtAdvanceAmt = this.txt_advance_amt;
				float single7 = float.Parse(dtrow["total_advance_in_month"].ToString());
				txtAdvanceAmt.Text = single7.ToString();
				TextBox txtUniformAmt = this.txt_uniform_amt;
				float single8 = float.Parse(dtrow["uniform_costs"].ToString());
				txtUniformAmt.Text = single8.ToString();
				TextBox txtPenaltyAmt = this.txt_penalty_amt;
				float single9 = float.Parse(dtrow["other_penalties_cost"].ToString());
				txtPenaltyAmt.Text = single9.ToString();
				TextBox txtDaysWorked = this.txt_days_worked;
				int num = Convert.ToInt32(dtrow["days_worked"].ToString());
				txtDaysWorked.Text = num.ToString();
				TextBox txtOvertimeDays = this.txt_overtime_days;
				int num1 = Convert.ToInt32(dtrow["over_time_days_worked"].ToString());
				txtOvertimeDays.Text = num1.ToString();
				TextBox txtPenaltyDays = this.txt_penalty_days;
				int num2 = Convert.ToInt32(dtrow["days_absent"].ToString());
				txtPenaltyDays.Text = num2.ToString();
				TextBox txtAbsentismAmt = this.txt_absentism_amt;
				float single10 = float.Parse(dtrow["absentism_amt"].ToString());
				txtAbsentismAmt.Text = single10.ToString();
				DataTable dt_bank_details = Salary_scales.return_bank_and_nssf_details_by_guard_number("return_bank_and_nssf_details_by_guard_number", guard_number);
				if (dt_bank_details.Rows.Count > 0)
				{
					DataRow dtRowbank_details = dt_bank_details.Rows[0];
					this.txt_bank_code.Text = dtRowbank_details["bank_code"].ToString();
					this.txt_bank_name.Text = dtRowbank_details["bank_name"].ToString();
					this.txt_bank_branch.Text = dtRowbank_details["branch_name"].ToString();
					this.txt_account_number.Text = dtRowbank_details["account_number"].ToString();
					this.txt_nssf.Text = dtRowbank_details["nssf_number"].ToString();
				}
				this.Calculate_guard_salary_amounts();
			}
		}

		protected void save_update_guard_payment_details()
		{
			Payroll_Engine.save_or_update_guard_payroll_details("save_or_update_guard_payroll_details", (this.txt_record_guid.Text != string.Empty ? this.txt_record_guid.Text : string.Empty), SystemConst._username, this.txt_station_code.Text, Convert.ToInt32(SystemConst._active_deployment_id), this.txt_station_name.Text, this.txt_guard_num.Text, this.txt_guard_name.Text, this.txt_salary_scale_code.Text, this.txt_bank_code.Text, this.txt_bank_name.Text, this.txt_bank_branch.Text, this.txt_account_number.Text, this.txt_grade.Text, this.txt_nssf.Text, decimal.Parse(this.txt_basic_amt.Text), decimal.Parse(this.txt_transport_amt.Text), decimal.Parse(this.txt_housing_amt.Text), decimal.Parse(this.txt_resident_amt.Text), (this.txt_bonus_amt.Text != string.Empty ? decimal.Parse(this.txt_bonus_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_leave_amt.Text != string.Empty ? decimal.Parse(this.txt_leave_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_uniform_amt.Text != string.Empty ? decimal.Parse(this.txt_uniform_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_lst_amt.Text != string.Empty ? decimal.Parse(this.txt_lst_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_over_time_amt.Text != string.Empty ? decimal.Parse(this.txt_over_time_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_special_amt.Text != string.Empty ? decimal.Parse(this.txt_special_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_arrears_amt.Text != string.Empty ? decimal.Parse(this.txt_arrears_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_advance_amt.Text != string.Empty ? decimal.Parse(this.txt_advance_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_penalty_amt.Text != string.Empty ? decimal.Parse(this.txt_penalty_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_absentism_amt.Text != string.Empty ? decimal.Parse(this.txt_absentism_amt.Text) : new decimal(0, 0, 0, false, 1)), Convert.ToInt32(this.txt_days_worked.Text), Convert.ToInt32(this.txt_overtime_days.Text), (this.txt_days_resident.Text != string.Empty ? Convert.ToInt32(this.txt_days_resident.Text) : 0), Convert.ToInt32(this.txt_penalty_days.Text), (this.txt_tax_relief.Text != string.Empty ? decimal.Parse(this.txt_tax_relief.Text) : new decimal(0, 0, 0, false, 1)), decimal.Parse(this.txt_gross_amt.Text), (this.txt_paye_amt.Text != string.Empty ? decimal.Parse(this.txt_paye_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_nssf_amt.Text != string.Empty ? decimal.Parse(this.txt_nssf_amt.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_total_deductions.Text != string.Empty ? decimal.Parse(this.txt_total_deductions.Text) : new decimal(0, 0, 0, false, 1)), (this.txt_net_pay.Text != string.Empty ? decimal.Parse(this.txt_net_pay.Text) : new decimal(0, 0, 0, false, 1)), (this.chk_pay_salary.Checked ? true : false), (this.chk_pay_paye.Checked ? true : false), (this.chk_pay_nssf.Checked ? true : false), (this.chk_pay_advance.Checked ? true : false));
			if (this.txt_record_guid.Text == string.Empty)
			{
				MessageBox.Show(string.Concat("Successfully saved payroll details for ", this.txt_guard_name.Text), "Payroll setup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show(string.Concat("Successfully updated payroll details for ", this.txt_guard_name.Text), "Payroll setup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		protected void select_list_of_guards_for_payroll_setup(string branch_name)
		{
			string str;
			str = (branch_name != string.Empty ? branch_name : string.Empty);
			DateTime date = this.dt_start_date.Value.Date;
			DateTime value = this.dt_end_date.Value;
			DataTable dt = Payroll_Engine.Return_guard_shift_types("select_list_of_guards_for_payroll_setup_by_branch", str, date, value.Date);
			if (dt.Rows.Count <= 0)
			{
				this.gdv_guards.DataSource = null;
				return;
			}
			this.gdv_guards.DataSource = dt;
			this.gdv_guards.Columns["guard_auto_id"].Visible = false;
			this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.Cyan;
			this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
			this.gdv_guards.BorderStyle = BorderStyle.FixedSingle;
			foreach (DataGridViewColumn c in this.gdv_guards.Columns)
			{
				c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
			}
			this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
			this.gdv_guards.EnableHeadersVisualStyles = false;
		}

		protected void select_list_of_guards_for_payroll_setup_all()
		{
			DateTime date = this.dt_start_date.Value.Date;
			DateTime value = this.dt_end_date.Value;
			DataTable dt = Payroll_Engine.Return_guard_shift_types("select_list_of_guards_for_payroll_setup_all", date, value.Date);
			if (dt.Rows.Count > 0)
			{
				this.gdv_guards.DataSource = dt;
				this.gdv_guards.Columns["guard_auto_id"].Visible = false;
				this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.Cyan;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guards.BorderStyle = BorderStyle.FixedSingle;
				foreach (DataGridViewColumn c in this.gdv_guards.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
				}
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_guards.EnableHeadersVisualStyles = false;
			}
		}

		private void txt_absentism_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_absentism_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_advance_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_advance_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_arrears_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_arrears_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_bonus_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_bonus_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_leave_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_leave_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_lst_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_lst_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_penalty_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_penalty_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_resident_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_special_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_special_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}

		private void txt_uniform_amt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void txt_uniform_amt_TextChanged(object sender, EventArgs e)
		{
			this.Calculate_guard_salary_amounts();
		}
	}
}