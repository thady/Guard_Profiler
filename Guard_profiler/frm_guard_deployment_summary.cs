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
	public class frm_guard_deployment_summary : Form
	{
		private IContainer components;

		private Panel panel1;

		private Label label1;

		private Panel panel_deploy_details;

		private Label label2;

		private Panel panel3;

		private Label label4;

		private Label label3;

		private DateTimePicker dt_start_date;

		private DateTimePicker dt_end_date;

		private Label label5;

		private DateTimePicker dt_deployment_date;

		private Label label6;

		private ComboBox cbo_deploy_type;

		private CheckBox chk_leave;

		private CheckBox chk_public_holiday;

		private Label label9;

		private ComboBox cbo_branch;

		private Label label10;

		private TextBox txt_branch_code;

		private Label label11;

		private ComboBox cbo_customer_name;

		private Label label12;

		private ComboBox cbo_customer_location;

		private Label label13;

		private ComboBox cbo_guard_name;

		private Label label14;

		private TextBox txt_guard_number;

		private Label label15;

		private TextBox txt_fire_arm_serial;

		private Label label16;

		private TextBox txt_ammunition_count;

		private Label label17;

		private ComboBox cbo_working_shift;

		//private ReSize reSize1;

		private Panel panel4;

		private DataGridView gdv_deployment_summary;

		private Panel panel5;

		private Button btn_save;

		private Button btn_edit;

		private Button btn_new;

		private Button btn_save_and_new;

		private Panel panel6;

		private Button btn_reports;

		private Label label7;

		private TextBox txt_client_code;

		private Button btn_additional_data;

		private CheckBox chk_weekend;

		private Panel panel7;

		private Label label8;

		private Panel panel8;

		private TextBox txt_deploy_details_id;

		private CheckBox chk_current_period;

		private ComboBox cbo_deploy_period;

		private Label label18;

		private Label label19;

		private ComboBox cbo_branch_search;

		private Label label20;

		private TextBox txt_guard_number_search;
        private ReSize reSize1;
        private Button btnsearch;

		public frm_guard_deployment_summary()
		{
			this.InitializeComponent();
		}

		private void btn_additional_data_Click(object sender, EventArgs e)
		{
			(new frm_guard_deployment_additional_data()).Show();
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			this.panel_deploy_details.Enabled = true;
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
            ClearAll();

        }

        protected void Clear()
        {
            //this.dt_deployment_date.Value = DateTime.Today;
            //this.cbo_deploy_type.Text = string.Empty;
            this.chk_public_holiday.Checked = false;
            this.chk_weekend.Checked = false;
            this.chk_leave.Checked = false;
            //this.cbo_branch.Text = string.Empty;
            //this.cbo_customer_name.Text = string.Empty;
            this.cbo_customer_location.Text = string.Empty;
            //this.cbo_guard_name.Text = string.Empty;
            this.txt_ammunition_count.Text = string.Empty;
            this.txt_fire_arm_serial.Clear();
            this.cbo_working_shift.Text = string.Empty;
           // this.txt_guard_number.Clear();
            this.txt_deploy_details_id.Clear();
            this.panel_deploy_details.Enabled = true;
        }

        protected void ClearAll()
        {
            this.dt_deployment_date.Value = DateTime.Today;
            this.cbo_deploy_type.Text = string.Empty;
            this.chk_public_holiday.Checked = false;
            this.chk_weekend.Checked = false;
            this.chk_leave.Checked = false;
            this.cbo_branch.Text = string.Empty;
            this.cbo_customer_name.Text = string.Empty;
            this.cbo_customer_location.Text = string.Empty;
            this.cbo_guard_name.Text = string.Empty;
            this.txt_ammunition_count.Text = string.Empty;
            this.txt_fire_arm_serial.Clear();
            this.cbo_working_shift.Text = string.Empty;
            this.txt_guard_number.Clear();
            this.txt_deploy_details_id.Clear();
            this.panel_deploy_details.Enabled = true;
        }

        private void btn_reports_Click(object sender, EventArgs e)
		{
			(new frm_deployment_reports_()).ShowDialog();
		}

		private void btn_save_and_new_Click(object sender, EventArgs e)
		{
			this.btn_save_Click(this.btn_save, null);
			this.btn_new_Click(this.btn_new, null);
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (!(this.dt_deployment_date.Value.Date < this.dt_start_date.Value.Date) && !(this.dt_deployment_date.Value.Date > this.dt_end_date.Value.Date))
			{
				this.Save_guard_deployment_record();
                
				return;
			}
			MessageBox.Show("Selected date must be within the current deployment period", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			this.Return_list_of_deployments_by_deploy_id("Return_list_of_deployments_by_deploy_id", (this.cbo_deploy_period.Text != string.Empty ? Convert.ToInt32(this.cbo_deploy_period.SelectedValue.ToString()) : -1), this.cbo_branch_search.Text, this.txt_guard_number_search.Text);
		}

		private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (this.cbo_branch.Text == string.Empty)
            {
                this.txt_branch_code.Text = string.Empty;
                this.GET_ACTIVE_GUARDS();
                return;
            }
            else {
                this.txt_branch_code.Text = this.cbo_branch.SelectedValue.ToString();
                this.GET_ACTIVE_GUARDS_BY_BRANCH(this.cbo_branch.Text);
            }
			
		}

		private void cbo_customer_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txt_client_code.Text = (this.cbo_customer_name.Text != string.Empty ? Clients.Return_client_code("select_client_code",Convert.ToInt32(cbo_customer_name.SelectedValue.ToString())) : string.Empty);
            if (cbo_customer_name.Text != string.Empty) { this.Return_client_locations(Convert.ToInt32(this.cbo_customer_name.SelectedValue.ToString())); }
            else { this.Return_client_locations(-1); }
			
   //         MessageBox.Show(this.cbo_customer_name.SelectedValue.ToString());
        }

		private void cbo_guard_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_guard_name.Text == string.Empty)
			{
				this.txt_guard_number.Text = string.Empty;
				return;
			}
			this.txt_guard_number.Text = this.cbo_guard_name.SelectedValue.ToString();
		}

		private void chk_current_period_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chk_current_period.Checked)
			{
				this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
				this.cbo_deploy_period.Enabled = false;
				return;
			}
			this.cbo_deploy_period.Text = string.Empty;
			this.cbo_deploy_period.Enabled = true;
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
				this.chk_weekend.Checked = true;
			}
			else
			{
				this.chk_weekend.Checked = false;
			}
			if (Guard_deployment.check_if_deployment_date_is_public_holiday("check_if_deployment_date_is_public_holiday", this.dt_deployment_date.Value.Date) > 0)
			{
				this.chk_public_holiday.Checked = true;
				return;
			}
			this.chk_public_holiday.Checked = false;
		}

		private void frm_guard_deployment_summary_Load(object sender, EventArgs e)
		{
			this.GET_BRANCHES();
			this.GET_BRANCHES_search();
			this.GET_ACTIVE_GUARDS();
			this.Return_list_of_clients();
			this.Get_guard_shift_types();
			this.return_deployment_periods();
			this.Return_list_of_deployments_by_deploy_id("Return_list_of_deployments_by_deploy_id", (this.cbo_deploy_period.Text != string.Empty ? Convert.ToInt32(this.cbo_deploy_period.SelectedValue.ToString()) : -1), this.cbo_branch_search.Text, this.txt_guard_number_search.Text);
			this.cbo_deploy_type.Text = "Normal";
			base.WindowState = FormWindowState.Maximized;
			this.dt_start_date.Value = SystemConst._deployment_start_date;
			this.dt_end_date.Value = SystemConst._deployment_end_date;
		}

		private void gdv_deployment_summary_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_deployment_summary.Rows.Count > 0)
			{
				int deploy_details_id = Convert.ToInt32(this.gdv_deployment_summary.CurrentRow.Cells[0].Value.ToString());
				DataTable dt = Guard_deployment.return_deployment_record_details_by_deploy_details_id("return_deployment_record_details_by_deploy_details_id", deploy_details_id);
				if (dt.Rows.Count > 0)
				{
					DataRow dtRow = dt.Rows[0];
					this.dt_deployment_date.Value = Convert.ToDateTime(dtRow["deploy_date"]);
					this.cbo_deploy_type.Text = dtRow["deploy_type"].ToString();
					this.chk_public_holiday.Checked = Convert.ToBoolean(dtRow["is_public_holiday"]);
					this.chk_weekend.Checked = Convert.ToBoolean(dtRow["is_weekend"]);
					this.chk_leave.Checked = Convert.ToBoolean(dtRow["is_leave_day_for_guard"]);
					this.cbo_branch.Text = dtRow["branch_name"].ToString();

                    //if (!dtRow.IsNull("client_code")) { this.cbo_customer_name.SelectedValue = dtRow["client_code"].ToString(); }
                    //this.cbo_customer_name.SelectedValue = dtRow["client_code"].ToString() != string.Empty ? dtRow["client_code"].ToString() : string.Empty;

                    //this.cbo_customer_name.SelectedValue = dtRow["client_code"].ToString();
					this.cbo_customer_location.Text = dtRow["client_location"].ToString();
					this.cbo_guard_name.Text = dtRow["guard_name"].ToString();
					TextBox txtAmmunitionCount = this.txt_ammunition_count;
					int num = Convert.ToInt32(dtRow["number_of_ammunitions"].ToString());
					txtAmmunitionCount.Text = num.ToString();
					this.txt_fire_arm_serial.Text = dtRow["firearm_serial"].ToString();
					this.cbo_working_shift.Text = dtRow["shift_type"].ToString();
					this.txt_guard_number.Text = dtRow["guard_number"].ToString();
					this.txt_deploy_details_id.Text = deploy_details_id.ToString();
					this.panel_deploy_details.Enabled = false;
				}
			}
		}

		protected void GET_ACTIVE_GUARDS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_LIST_OF_ACTIVE_GUARDS");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["full_name"] = string.Empty;
				dtRow["guard_number"] = string.Empty;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_guard_name.DataSource = dt;
				this.cbo_guard_name.DisplayMember = "full_name";
				this.cbo_guard_name.ValueMember = "guard_number";

                this.cbo_guard_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_guard_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
		}

		protected void GET_ACTIVE_GUARDS_BY_BRANCH(string branch_name)
		{
			DataTable dt = System_lookups.SELECT_LIST_OF_ACTIVE_GUARDS_BY_BRANCH("SELECT_LIST_OF_ACTIVE_GUARDS_BY_BRANCH", branch_name);
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["full_name"] = string.Empty;
				dtRow["guard_number"] = string.Empty;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_guard_name.DataSource = dt;
				this.cbo_guard_name.DisplayMember = "full_name";
				this.cbo_guard_name.ValueMember = "guard_number";

                this.cbo_guard_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_guard_name.AutoCompleteSource = AutoCompleteSource.ListItems;
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

                this.cbo_branch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_branch.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
		}

		protected void GET_BRANCHES_search()
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

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_deployment_summary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txt_guard_number_search = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chk_current_period = new System.Windows.Forms.CheckBox();
            this.cbo_deploy_period = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_additional_data = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_save_and_new = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gdv_deployment_summary = new System.Windows.Forms.DataGridView();
            this.panel_deploy_details = new System.Windows.Forms.Panel();
            this.txt_deploy_details_id = new System.Windows.Forms.TextBox();
            this.chk_weekend = new System.Windows.Forms.CheckBox();
            this.txt_client_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_working_shift = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_ammunition_count = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_fire_arm_serial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_guard_name = new System.Windows.Forms.ComboBox();
            this.cbo_customer_location = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_customer_name = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_branch_code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chk_leave = new System.Windows.Forms.CheckBox();
            this.chk_public_holiday = new System.Windows.Forms.CheckBox();
            this.cbo_deploy_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_deployment_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_summary)).BeginInit();
            this.panel_deploy_details.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel_deploy_details);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 630);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.btnsearch);
            this.panel8.Controls.Add(this.txt_guard_number_search);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.cbo_branch_search);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.chk_current_period);
            this.panel8.Controls.Add(this.cbo_deploy_period);
            this.panel8.Location = new System.Drawing.Point(691, 4);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(519, 158);
            this.panel8.TabIndex = 32;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(391, 91);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(120, 58);
            this.btnsearch.TabIndex = 38;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txt_guard_number_search
            // 
            this.txt_guard_number_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_search.Location = new System.Drawing.Point(8, 123);
            this.txt_guard_number_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number_search.Name = "txt_guard_number_search";
            this.txt_guard_number_search.Size = new System.Drawing.Size(223, 24);
            this.txt_guard_number_search.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(4, 101);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 18);
            this.label20.TabIndex = 37;
            this.label20.Text = "Guard Number";
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(8, 71);
            this.cbo_branch_search.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(312, 24);
            this.cbo_branch_search.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(4, 49);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 18);
            this.label19.TabIndex = 35;
            this.label19.Text = "Branch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(4, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 18);
            this.label18.TabIndex = 34;
            this.label18.Text = "Deployment period";
            // 
            // chk_current_period
            // 
            this.chk_current_period.AutoSize = true;
            this.chk_current_period.Checked = true;
            this.chk_current_period.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_current_period.ForeColor = System.Drawing.Color.Blue;
            this.chk_current_period.Location = new System.Drawing.Point(325, 20);
            this.chk_current_period.Margin = new System.Windows.Forms.Padding(4);
            this.chk_current_period.Name = "chk_current_period";
            this.chk_current_period.Size = new System.Drawing.Size(147, 38);
            this.chk_current_period.TabIndex = 6;
            this.chk_current_period.Text = "use current \r\ndeployment period";
            this.chk_current_period.UseVisualStyleBackColor = true;
            this.chk_current_period.CheckedChanged += new System.EventHandler(this.chk_current_period_CheckedChanged);
            // 
            // cbo_deploy_period
            // 
            this.cbo_deploy_period.FormattingEnabled = true;
            this.cbo_deploy_period.Location = new System.Drawing.Point(4, 20);
            this.cbo_deploy_period.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_deploy_period.Name = "cbo_deploy_period";
            this.cbo_deploy_period.Size = new System.Drawing.Size(312, 24);
            this.cbo_deploy_period.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.btn_additional_data);
            this.panel6.Controls.Add(this.btn_reports);
            this.panel6.Location = new System.Drawing.Point(689, 572);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 47);
            this.panel6.TabIndex = 31;
            // 
            // btn_additional_data
            // 
            this.btn_additional_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_additional_data.Location = new System.Drawing.Point(1, 4);
            this.btn_additional_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_additional_data.Name = "btn_additional_data";
            this.btn_additional_data.Size = new System.Drawing.Size(311, 39);
            this.btn_additional_data.TabIndex = 1;
            this.btn_additional_data.Text = "ADDITIONAL GUARD DEPLOYMENT DATA";
            this.btn_additional_data.UseVisualStyleBackColor = false;
            this.btn_additional_data.Click += new System.EventHandler(this.btn_additional_data_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_reports.Location = new System.Drawing.Point(311, 4);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(205, 39);
            this.btn_reports.TabIndex = 0;
            this.btn_reports.Text = "DEPLOYMENT REPORTS";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.btn_save_and_new);
            this.panel5.Controls.Add(this.btn_new);
            this.panel5.Controls.Add(this.btn_edit);
            this.panel5.Controls.Add(this.btn_save);
            this.panel5.Location = new System.Drawing.Point(13, 572);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(641, 47);
            this.panel5.TabIndex = 30;
            // 
            // btn_save_and_new
            // 
            this.btn_save_and_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save_and_new.Enabled = false;
            this.btn_save_and_new.Location = new System.Drawing.Point(116, 4);
            this.btn_save_and_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save_and_new.Name = "btn_save_and_new";
            this.btn_save_and_new.Size = new System.Drawing.Size(129, 39);
            this.btn_save_and_new.TabIndex = 3;
            this.btn_save_and_new.Text = "Save and New";
            this.btn_save_and_new.UseVisualStyleBackColor = false;
            this.btn_save_and_new.Click += new System.EventHandler(this.btn_save_and_new_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_new.Location = new System.Drawing.Point(429, 4);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(189, 39);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "Clear All";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_edit.Location = new System.Drawing.Point(248, 4);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(179, 39);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit Deployment Record";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_save.Location = new System.Drawing.Point(8, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gdv_deployment_summary);
            this.panel4.Location = new System.Drawing.Point(685, 169);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(523, 396);
            this.panel4.TabIndex = 1;
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
            this.gdv_deployment_summary.ReadOnly = true;
            this.gdv_deployment_summary.Size = new System.Drawing.Size(511, 533);
            this.gdv_deployment_summary.TabIndex = 0;
            this.gdv_deployment_summary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_deployment_summary_CellClick);
            // 
            // panel_deploy_details
            // 
            this.panel_deploy_details.BackColor = System.Drawing.Color.LightCyan;
            this.panel_deploy_details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_deploy_details.Controls.Add(this.txt_deploy_details_id);
            this.panel_deploy_details.Controls.Add(this.chk_weekend);
            this.panel_deploy_details.Controls.Add(this.txt_client_code);
            this.panel_deploy_details.Controls.Add(this.label7);
            this.panel_deploy_details.Controls.Add(this.cbo_working_shift);
            this.panel_deploy_details.Controls.Add(this.label17);
            this.panel_deploy_details.Controls.Add(this.txt_ammunition_count);
            this.panel_deploy_details.Controls.Add(this.label16);
            this.panel_deploy_details.Controls.Add(this.txt_fire_arm_serial);
            this.panel_deploy_details.Controls.Add(this.label15);
            this.panel_deploy_details.Controls.Add(this.txt_guard_number);
            this.panel_deploy_details.Controls.Add(this.label14);
            this.panel_deploy_details.Controls.Add(this.label13);
            this.panel_deploy_details.Controls.Add(this.cbo_guard_name);
            this.panel_deploy_details.Controls.Add(this.cbo_customer_location);
            this.panel_deploy_details.Controls.Add(this.label12);
            this.panel_deploy_details.Controls.Add(this.cbo_customer_name);
            this.panel_deploy_details.Controls.Add(this.label11);
            this.panel_deploy_details.Controls.Add(this.txt_branch_code);
            this.panel_deploy_details.Controls.Add(this.label10);
            this.panel_deploy_details.Controls.Add(this.cbo_branch);
            this.panel_deploy_details.Controls.Add(this.label9);
            this.panel_deploy_details.Controls.Add(this.chk_leave);
            this.panel_deploy_details.Controls.Add(this.chk_public_holiday);
            this.panel_deploy_details.Controls.Add(this.cbo_deploy_type);
            this.panel_deploy_details.Controls.Add(this.label6);
            this.panel_deploy_details.Controls.Add(this.dt_deployment_date);
            this.panel_deploy_details.Controls.Add(this.label5);
            this.panel_deploy_details.Controls.Add(this.panel3);
            this.panel_deploy_details.Controls.Add(this.label2);
            this.panel_deploy_details.Location = new System.Drawing.Point(13, 20);
            this.panel_deploy_details.Margin = new System.Windows.Forms.Padding(4);
            this.panel_deploy_details.Name = "panel_deploy_details";
            this.panel_deploy_details.Size = new System.Drawing.Size(663, 545);
            this.panel_deploy_details.TabIndex = 0;
            // 
            // txt_deploy_details_id
            // 
            this.txt_deploy_details_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deploy_details_id.Location = new System.Drawing.Point(607, 513);
            this.txt_deploy_details_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_deploy_details_id.Name = "txt_deploy_details_id";
            this.txt_deploy_details_id.ReadOnly = true;
            this.txt_deploy_details_id.Size = new System.Drawing.Size(49, 24);
            this.txt_deploy_details_id.TabIndex = 33;
            // 
            // chk_weekend
            // 
            this.chk_weekend.AutoSize = true;
            this.chk_weekend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chk_weekend.Enabled = false;
            this.chk_weekend.Location = new System.Drawing.Point(543, 177);
            this.chk_weekend.Margin = new System.Windows.Forms.Padding(4);
            this.chk_weekend.Name = "chk_weekend";
            this.chk_weekend.Size = new System.Drawing.Size(90, 21);
            this.chk_weekend.TabIndex = 32;
            this.chk_weekend.Text = "Weekend";
            this.chk_weekend.UseVisualStyleBackColor = false;
            // 
            // txt_client_code
            // 
            this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_code.Location = new System.Drawing.Point(527, 281);
            this.txt_client_code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_client_code.Name = "txt_client_code";
            this.txt_client_code.ReadOnly = true;
            this.txt_client_code.Size = new System.Drawing.Size(127, 24);
            this.txt_client_code.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Client Code";
            // 
            // cbo_working_shift
            // 
            this.cbo_working_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_working_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_working_shift.FormattingEnabled = true;
            this.cbo_working_shift.Location = new System.Drawing.Point(8, 490);
            this.cbo_working_shift.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_working_shift.Name = "cbo_working_shift";
            this.cbo_working_shift.Size = new System.Drawing.Size(179, 26);
            this.cbo_working_shift.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 468);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 18);
            this.label17.TabIndex = 28;
            this.label17.Text = "Working Shift";
            // 
            // txt_ammunition_count
            // 
            this.txt_ammunition_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ammunition_count.Location = new System.Drawing.Point(8, 438);
            this.txt_ammunition_count.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ammunition_count.Name = "txt_ammunition_count";
            this.txt_ammunition_count.Size = new System.Drawing.Size(179, 24);
            this.txt_ammunition_count.TabIndex = 27;
            this.txt_ammunition_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ammunition_count_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Aqua;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 416);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 18);
            this.label16.TabIndex = 26;
            this.label16.Text = "No. of Ammunitions";
            // 
            // txt_fire_arm_serial
            // 
            this.txt_fire_arm_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fire_arm_serial.Location = new System.Drawing.Point(8, 386);
            this.txt_fire_arm_serial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fire_arm_serial.Name = "txt_fire_arm_serial";
            this.txt_fire_arm_serial.Size = new System.Drawing.Size(301, 24);
            this.txt_fire_arm_serial.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 364);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 18);
            this.label15.TabIndex = 24;
            this.label15.Text = "Assigned Fire Arm serial number";
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(319, 335);
            this.txt_guard_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.ReadOnly = true;
            this.txt_guard_number.Size = new System.Drawing.Size(127, 24);
            this.txt_guard_number.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 310);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 18);
            this.label14.TabIndex = 22;
            this.label14.Text = "Guard NUmber";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 310);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Guard Name";
            // 
            // cbo_guard_name
            // 
            this.cbo_guard_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_guard_name.FormattingEnabled = true;
            this.cbo_guard_name.Location = new System.Drawing.Point(8, 332);
            this.cbo_guard_name.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_guard_name.Name = "cbo_guard_name";
            this.cbo_guard_name.Size = new System.Drawing.Size(301, 26);
            this.cbo_guard_name.TabIndex = 20;
            this.cbo_guard_name.SelectedIndexChanged += new System.EventHandler(this.cbo_guard_name_SelectedIndexChanged);
            // 
            // cbo_customer_location
            // 
            this.cbo_customer_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_customer_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_customer_location.FormattingEnabled = true;
            this.cbo_customer_location.Location = new System.Drawing.Point(319, 278);
            this.cbo_customer_location.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_customer_location.Name = "cbo_customer_location";
            this.cbo_customer_location.Size = new System.Drawing.Size(201, 26);
            this.cbo_customer_location.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aqua;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 256);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Choose Customer Location";
            // 
            // cbo_customer_name
            // 
            this.cbo_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_customer_name.FormattingEnabled = true;
            this.cbo_customer_name.Location = new System.Drawing.Point(8, 278);
            this.cbo_customer_name.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_customer_name.Name = "cbo_customer_name";
            this.cbo_customer_name.Size = new System.Drawing.Size(301, 26);
            this.cbo_customer_name.TabIndex = 16;
            this.cbo_customer_name.SelectedIndexChanged += new System.EventHandler(this.cbo_customer_name_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Choose Customer";
            // 
            // txt_branch_code
            // 
            this.txt_branch_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_code.Location = new System.Drawing.Point(319, 226);
            this.txt_branch_code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_branch_code.Name = "txt_branch_code";
            this.txt_branch_code.ReadOnly = true;
            this.txt_branch_code.Size = new System.Drawing.Size(127, 24);
            this.txt_branch_code.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Station Code";
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(8, 224);
            this.cbo_branch.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(301, 26);
            this.cbo_branch.TabIndex = 12;
            this.cbo_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_branch_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Select a station";
            // 
            // chk_leave
            // 
            this.chk_leave.AutoSize = true;
            this.chk_leave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chk_leave.Location = new System.Drawing.Point(357, 175);
            this.chk_leave.Margin = new System.Windows.Forms.Padding(4);
            this.chk_leave.Name = "chk_leave";
            this.chk_leave.Size = new System.Drawing.Size(156, 21);
            this.chk_leave.TabIndex = 9;
            this.chk_leave.Text = "Guard was on leave";
            this.chk_leave.UseVisualStyleBackColor = false;
            // 
            // chk_public_holiday
            // 
            this.chk_public_holiday.AutoSize = true;
            this.chk_public_holiday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chk_public_holiday.Enabled = false;
            this.chk_public_holiday.Location = new System.Drawing.Point(200, 175);
            this.chk_public_holiday.Margin = new System.Windows.Forms.Padding(4);
            this.chk_public_holiday.Name = "chk_public_holiday";
            this.chk_public_holiday.Size = new System.Drawing.Size(119, 21);
            this.chk_public_holiday.TabIndex = 8;
            this.chk_public_holiday.Text = "Public Holiday";
            this.chk_public_holiday.UseVisualStyleBackColor = false;
            // 
            // cbo_deploy_type
            // 
            this.cbo_deploy_type.Enabled = false;
            this.cbo_deploy_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_deploy_type.FormattingEnabled = true;
            this.cbo_deploy_type.Items.AddRange(new object[] {
            "Normal"});
            this.cbo_deploy_type.Location = new System.Drawing.Point(12, 170);
            this.cbo_deploy_type.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_deploy_type.Name = "cbo_deploy_type";
            this.cbo_deploy_type.Size = new System.Drawing.Size(179, 26);
            this.cbo_deploy_type.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deployment Type";
            // 
            // dt_deployment_date
            // 
            this.dt_deployment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_deployment_date.Location = new System.Drawing.Point(8, 118);
            this.dt_deployment_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_deployment_date.Name = "dt_deployment_date";
            this.dt_deployment_date.ShowCheckBox = true;
            this.dt_deployment_date.Size = new System.Drawing.Size(301, 24);
            this.dt_deployment_date.TabIndex = 4;
            this.dt_deployment_date.ValueChanged += new System.EventHandler(this.dt_deployment_date_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Deployment Date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.dt_end_date);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dt_start_date);
            this.panel3.Location = new System.Drawing.Point(8, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 58);
            this.panel3.TabIndex = 1;
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Location = new System.Drawing.Point(311, 25);
            this.dt_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(299, 24);
            this.dt_end_date.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(307, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "From";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Location = new System.Drawing.Point(4, 25);
            this.dt_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(301, 24);
            this.dt_start_date.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deployment period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deploy Guards(Single)";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(191, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1025, 28);
            this.panel7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(153, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(765, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Remember to always set your public holidays for the current deployment period bef" +
    "ore deploying guards";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = true;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 661D;
            this.reSize1.InitialHostContainerWidth = 1224D;
            this.reSize1.Tag = null;
            // 
            // frm_guard_deployment_summary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1224, 661);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_guard_deployment_summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Securiko Uganda Ltd-Deploy Gaurds(Single Deploy)";
            this.Load += new System.EventHandler(this.frm_guard_deployment_summary_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_summary)).EndInit();
            this.panel_deploy_details.ResumeLayout(false);
            this.panel_deploy_details.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		protected void Return_client_locations(int client_code)
		{
			DataTable dt = Clients.Return_client_location_list("return_client_location_list_by_client_code", client_code);
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["location_name"] = string.Empty;
				dtRow["record_guid"] = string.Empty;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_customer_location.DataSource = dt;
				this.cbo_customer_location.DisplayMember = "location_name";
				this.cbo_customer_location.ValueMember = "record_guid";
			}
            else
            {
                DataRow dtRow = dt.NewRow();
                dtRow["location_name"] = string.Empty;
                dtRow["record_guid"] = string.Empty;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_customer_location.DataSource = dt;
                this.cbo_customer_location.DisplayMember = "location_name";
                this.cbo_customer_location.ValueMember = "record_guid";
            }
		}

		protected void return_deployment_periods()
		{
			DataTable dt = Guard_deployment.Return_list_of_deployment_periods("return_list_of_deployment_periods_for_accounts_reports_selector");
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["deploy_id"] = -1;
				dtRow["period"] = string.Empty;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_deploy_period.DisplayMember = "period";
				this.cbo_deploy_period.ValueMember = "deploy_id";
				this.cbo_deploy_period.DataSource = dt;
				this.cbo_deploy_period.SelectedValue = SystemConst._active_deployment_id;
				this.cbo_deploy_period.Enabled = false;
			}
		}

		protected void Return_list_of_clients()
		{
			DataTable dt = Clients.Return_list_of_clients("return_list_of_clients");
			if (dt.Rows.Count > 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["client_name"] = string.Empty;
                dtRow["client_id"] = -1;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_customer_name.DataSource = dt;
				this.cbo_customer_name.DisplayMember = "client_name";
				this.cbo_customer_name.ValueMember = "client_id";

                this.cbo_customer_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_customer_name.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
		}

		protected void Return_list_of_deployments_by_deploy_id(string myQuery, int deploy_period_id, string branch_name, string guard_number)
		{
			DataTable dt = Guard_deployment.Return_list_of_deployments_by_deploy_id(myQuery, deploy_period_id, branch_name, guard_number);
			this.gdv_deployment_summary.DataSource = dt;
			this.gdv_deployment_summary.Columns["deploy_details_id"].Visible = false;
			this.gdv_deployment_summary.Columns["guard_name"].HeaderText = "Guard";
			this.gdv_deployment_summary.Columns["branch_name"].HeaderText = "Branch";
			this.gdv_deployment_summary.Columns["guard_number"].HeaderText = "Guard No.";
			this.gdv_deployment_summary.Columns["deploy_date"].HeaderText = "Date";
			this.gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";
			this.gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.Brown;
			this.gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;
			foreach (DataGridViewColumn c in this.gdv_deployment_summary.Columns)
			{
				c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
			}
			this.gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
			this.gdv_deployment_summary.EnableHeadersVisualStyles = false;
		}

		protected void Save_guard_deployment_record()
		{
			if (!this.dt_start_date.Checked || !this.dt_end_date.Checked || !this.dt_deployment_date.Checked || this.cbo_deploy_type.Text == string.Empty || this.cbo_branch.Text == string.Empty || this.cbo_customer_name.Text == string.Empty || this.cbo_customer_location.Text == string.Empty || this.cbo_guard_name.Text == string.Empty || this.cbo_working_shift.Text == string.Empty)
			{
				MessageBox.Show("Fill in all required values", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

            if (Guard_deployment.check_if_guard_already_deployed_by_date("check_if_guard_already_deployed_by_date",cbo_guard_name.SelectedValue.ToString(), dt_deployment_date.Value.Date ) > 1)
            {
                MessageBox.Show("Guard already deployed for this date", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
			if (this.txt_deploy_details_id.Text == string.Empty)
			{
				Guard_deployment.Save_new_deployment_record("save_new_deployment_record", this.dt_start_date.Value.Date, this.dt_end_date.Value.Date, SystemConst._username, this.txt_guard_number.Text, this.dt_deployment_date.Value.Date, this.cbo_deploy_type.Text, this.cbo_branch.Text, cbo_customer_name.SelectedValue.ToString(), this.cbo_customer_location.Text, this.cbo_guard_name.Text, this.txt_fire_arm_serial.Text, (this.txt_ammunition_count.Text != string.Empty ? Convert.ToInt32(this.txt_ammunition_count.Text) : 0), this.cbo_working_shift.Text, (this.chk_leave.Checked ? true : false), (this.chk_public_holiday.Checked ? true : false), (this.chk_weekend.Checked ? true : false));
				MessageBox.Show("Successfully deployed guard for this date", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.Return_list_of_deployments_by_deploy_id("Return_list_of_deployments_by_deploy_id", (this.cbo_deploy_period.Text != string.Empty ? Convert.ToInt32(this.cbo_deploy_period.SelectedValue.ToString()) : -1), this.cbo_branch_search.Text, this.txt_guard_number_search.Text);
                Guard_deployment.Save_deployment_schedule(dt_deployment_date.Value, Convert.ToInt32( SystemConst._active_deployment_id),cbo_guard_name.SelectedValue.ToString());
                Clear();
                return;
			}
			Guard_deployment.update_deployment_record_single_deploy("update_deployment_record_single_deploy", Convert.ToInt32(this.txt_deploy_details_id.Text), this.dt_start_date.Value.Date, this.dt_end_date.Value.Date, SystemConst._username, this.txt_guard_number.Text, this.dt_deployment_date.Value.Date, this.cbo_deploy_type.Text, this.cbo_branch.Text,cbo_customer_name.SelectedValue.ToString(), this.cbo_customer_location.Text, this.cbo_guard_name.Text, this.txt_fire_arm_serial.Text, (this.txt_ammunition_count.Text != string.Empty ? Convert.ToInt32(this.txt_ammunition_count.Text) : 0), this.cbo_working_shift.Text, (this.chk_leave.Checked ? true : false), (this.chk_public_holiday.Checked ? true : false), (this.chk_weekend.Checked ? true : false));
			MessageBox.Show("Successfully updated deployment record", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.Return_list_of_deployments_by_deploy_id("Return_list_of_deployments_by_deploy_id", (this.cbo_deploy_period.Text != string.Empty ? Convert.ToInt32(this.cbo_deploy_period.SelectedValue.ToString()) : -1), this.cbo_branch_search.Text, this.txt_guard_number_search.Text);
            Guard_deployment.Save_deployment_schedule(dt_deployment_date.Value, Convert.ToInt32(SystemConst._active_deployment_id), cbo_guard_name.SelectedValue.ToString());
            Clear();
        }

        private void txt_ammunition_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}