using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_edit_guard_deployment_record : Form
	{
		private IContainer components;

		private Panel panel1;

		private Label label5;

		private ComboBox cbo_customer_name;

		private TextBox txt_client_code;

		private Label label7;

		private Label label1;

		private ComboBox cbo_customer_location;

		private Label label2;

		private ComboBox cbo_working_shift;

		private Label label15;

		private TextBox txt_fire_arm_serial;

		private Label label16;

		private TextBox txt_ammunition_count;

		private CheckBox chk_public_holiday;

		private CheckBox chk_leave;

		private Label lbl_record_guid;

		private Button btn_save;

		private Button btn_close;

		private Label label4;

		private Label lbl_name;

		private Label label3;

		private Label lbl_branch;

		private Panel panel2;

		private CheckBox chk_absent;

		public frm_edit_guard_deployment_record()
		{
			this.InitializeComponent();
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(string.Concat("All unsaved changes for ", this.lbl_name.Text, " will be lost!sure to close??"), "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				base.Close();
				return;
			}
			if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				base.Visible = true;
			}
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (this.txt_client_code.Text == string.Empty || this.cbo_customer_location.Text == string.Empty || this.cbo_working_shift.Text == string.Empty)
			{
				MessageBox.Show("All values shaded red are required", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!this.chk_absent.Checked)
			{
				Guard_deployment.Update_guard_deployment_record("update_guard_deployment_record", this.lbl_record_guid.Text, this.txt_client_code.Text, this.cbo_customer_location.Text, this.txt_fire_arm_serial.Text, (this.txt_ammunition_count.Text != string.Empty ? Convert.ToInt32(this.txt_ammunition_count.Text) : 0), this.cbo_working_shift.Text, (this.chk_leave.Checked ? true : false));
				MessageBox.Show(string.Concat("Updated deployment record for ", this.lbl_name.Text, " successfully"), "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(string.Concat("Marking", this.lbl_name.Text, " as absent will delete this record from the deployment list for this date.sure to proceed?"), "Deploy guards", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Guard_deployment.delete_guard_marked_as_absent_from_deployment_list_per_date("delete_guard_marked_as_absent_from_deployment_list_per_date", this.lbl_record_guid.Text);
					return;
				}
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
					return;
				}
			}
		}

		private void cbo_customer_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txt_client_code.Text = (this.cbo_customer_name.Text != string.Empty ? this.cbo_customer_name.SelectedValue.ToString() : string.Empty);
            if (cbo_customer_name.Text != string.Empty)
            {
                this.Return_client_locations(Convert.ToInt32(this.cbo_customer_name.SelectedValue.ToString()));
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

		private void frm_edit_guard_deployment_record_Load(object sender, EventArgs e)
		{
            this.Return_list_of_clients();
            this.Get_guard_shift_types();
            this.Set_static_deploy_variables();
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_edit_guard_deployment_record));
			this.panel1 = new Panel();
			this.chk_absent = new CheckBox();
			this.panel2 = new Panel();
			this.label3 = new Label();
			this.lbl_name = new Label();
			this.lbl_branch = new Label();
			this.label4 = new Label();
			this.btn_save = new Button();
			this.btn_close = new Button();
			this.lbl_record_guid = new Label();
			this.chk_leave = new CheckBox();
			this.chk_public_holiday = new CheckBox();
			this.txt_ammunition_count = new TextBox();
			this.label16 = new Label();
			this.txt_fire_arm_serial = new TextBox();
			this.label15 = new Label();
			this.cbo_working_shift = new ComboBox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.cbo_customer_location = new ComboBox();
			this.label7 = new Label();
			this.txt_client_code = new TextBox();
			this.cbo_customer_name = new ComboBox();
			this.label5 = new Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.chk_absent);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btn_save);
			this.panel1.Controls.Add(this.btn_close);
			this.panel1.Controls.Add(this.lbl_record_guid);
			this.panel1.Controls.Add(this.chk_leave);
			this.panel1.Controls.Add(this.chk_public_holiday);
			this.panel1.Controls.Add(this.txt_ammunition_count);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.txt_fire_arm_serial);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.cbo_working_shift);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbo_customer_location);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txt_client_code);
			this.panel1.Controls.Add(this.cbo_customer_name);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(431, 266);
			this.panel1.TabIndex = 0;
			this.chk_absent.AutoSize = true;
			this.chk_absent.BackColor = Color.FromArgb(255, 255, 128);
			this.chk_absent.Location = new Point(249, 182);
			this.chk_absent.Name = "chk_absent";
			this.chk_absent.Size = new System.Drawing.Size(111, 17);
			this.chk_absent.TabIndex = 53;
			this.chk_absent.Text = "Marked as absent";
			this.chk_absent.UseVisualStyleBackColor = false;
			this.panel2.BackColor = Color.Silver;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.lbl_name);
			this.panel2.Controls.Add(this.lbl_branch);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(425, 43);
			this.panel2.TabIndex = 52;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(255, 192, 128);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(243, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 50;
			this.label3.Text = "Branch";
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbl_name.ForeColor = Color.Blue;
			this.lbl_name.Location = new Point(3, 20);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(63, 16);
			this.lbl_name.TabIndex = 49;
			this.lbl_name.Text = "lbl_name";
			this.lbl_branch.AutoSize = true;
			this.lbl_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lbl_branch.ForeColor = Color.Blue;
			this.lbl_branch.Location = new Point(243, 20);
			this.lbl_branch.Name = "lbl_branch";
			this.lbl_branch.Size = new System.Drawing.Size(70, 16);
			this.lbl_branch.TabIndex = 51;
			this.lbl_branch.Text = "lbl_branch";
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.FromArgb(255, 192, 128);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 15);
			this.label4.TabIndex = 48;
			this.label4.Text = "Guard Name";
			this.btn_save.BackColor = Color.Cyan;
			this.btn_save.Location = new Point(198, 230);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(125, 23);
			this.btn_save.TabIndex = 46;
			this.btn_save.Text = "Update";
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new EventHandler(this.btn_save_Click);
			this.btn_close.BackColor = Color.FromArgb(255, 192, 192);
			this.btn_close.Location = new Point(67, 230);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(125, 23);
			this.btn_close.TabIndex = 45;
			this.btn_close.Text = "Close";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new EventHandler(this.btn_close_Click);
			this.lbl_record_guid.AutoSize = true;
			this.lbl_record_guid.ForeColor = Color.Blue;
			this.lbl_record_guid.Location = new Point(113, 202);
			this.lbl_record_guid.Name = "lbl_record_guid";
			this.lbl_record_guid.Size = new System.Drawing.Size(79, 13);
			this.lbl_record_guid.TabIndex = 1;
			this.lbl_record_guid.Text = "lbl_record_guid";
			this.chk_leave.AutoSize = true;
			this.chk_leave.BackColor = Color.FromArgb(255, 255, 128);
			this.chk_leave.Location = new Point(116, 182);
			this.chk_leave.Name = "chk_leave";
			this.chk_leave.Size = new System.Drawing.Size(121, 17);
			this.chk_leave.TabIndex = 44;
			this.chk_leave.Text = "Guard was on leave";
			this.chk_leave.UseVisualStyleBackColor = false;
			this.chk_public_holiday.AutoSize = true;
			this.chk_public_holiday.BackColor = Color.FromArgb(255, 255, 128);
			this.chk_public_holiday.Enabled = false;
			this.chk_public_holiday.Location = new Point(13, 182);
			this.chk_public_holiday.Name = "chk_public_holiday";
			this.chk_public_holiday.Size = new System.Drawing.Size(93, 17);
			this.chk_public_holiday.TabIndex = 43;
			this.chk_public_holiday.Text = "Public Holiday";
			this.chk_public_holiday.UseVisualStyleBackColor = false;
			this.txt_ammunition_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_ammunition_count.Location = new Point(239, 155);
			this.txt_ammunition_count.Name = "txt_ammunition_count";
			this.txt_ammunition_count.Size = new System.Drawing.Size(126, 21);
			this.txt_ammunition_count.TabIndex = 42;
			this.label16.AutoSize = true;
			this.label16.BackColor = Color.Aqua;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label16.Location = new Point(236, 137);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(114, 15);
			this.label16.TabIndex = 41;
			this.label16.Text = "No. of Ammunitions";
			this.txt_fire_arm_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_fire_arm_serial.Location = new Point(3, 155);
			this.txt_fire_arm_serial.Name = "txt_fire_arm_serial";
			this.txt_fire_arm_serial.Size = new System.Drawing.Size(227, 21);
			this.txt_fire_arm_serial.TabIndex = 40;
			this.label15.AutoSize = true;
			this.label15.BackColor = Color.FromArgb(255, 192, 128);
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.Location = new Point(7, 137);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(185, 15);
			this.label15.TabIndex = 39;
			this.label15.Text = "Assigned Fire Arm serial number";
			this.cbo_working_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_working_shift.FormattingEnabled = true;
			this.cbo_working_shift.Location = new Point(239, 111);
			this.cbo_working_shift.Name = "cbo_working_shift";
			this.cbo_working_shift.Size = new System.Drawing.Size(135, 23);
			this.cbo_working_shift.TabIndex = 38;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 192, 128);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(236, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 15);
			this.label2.TabIndex = 37;
			this.label2.Text = "Shift type";
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 192, 128);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(10, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 36;
			this.label1.Text = "Client Location";
			this.cbo_customer_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_customer_location.FormattingEnabled = true;
			this.cbo_customer_location.Location = new Point(10, 111);
			this.cbo_customer_location.Name = "cbo_customer_location";
			this.cbo_customer_location.Size = new System.Drawing.Size(227, 23);
			this.cbo_customer_location.TabIndex = 35;
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.Aqua;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.Location = new Point(236, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 15);
			this.label7.TabIndex = 34;
			this.label7.Text = "Client Code";
			this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_client_code.Location = new Point(239, 69);
			this.txt_client_code.Name = "txt_client_code";
			this.txt_client_code.ReadOnly = true;
			this.txt_client_code.Size = new System.Drawing.Size(135, 21);
			this.txt_client_code.TabIndex = 32;
			this.cbo_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_customer_name.FormattingEnabled = true;
			this.cbo_customer_name.Location = new Point(10, 67);
			this.cbo_customer_name.Name = "cbo_customer_name";
			this.cbo_customer_name.Size = new System.Drawing.Size(227, 23);
			this.cbo_customer_name.TabIndex = 17;
			this.cbo_customer_name.SelectedIndexChanged += new EventHandler(this.cbo_customer_name_SelectedIndexChanged);
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.FromArgb(255, 192, 128);
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(10, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Client Name";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 128, 0);
			base.ClientSize = new System.Drawing.Size(435, 270);
			base.ControlBox = false;
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_edit_guard_deployment_record";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Edit guard deployment record";
			base.Load += new EventHandler(this.frm_edit_guard_deployment_record_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
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

		protected void Set_static_deploy_variables()
		{
            this.lbl_record_guid.Text = SystemConst._record_guid;
            //this.cbo_customer_name.SelectedValue = SystemConst._client_codee;
            this.cbo_customer_name.SelectedValue = SystemConst._client_ids;
            this.cbo_customer_location.Text = SystemConst._client_location;
            this.cbo_working_shift.Text = SystemConst._shift_type;
            this.txt_fire_arm_serial.Text = SystemConst._fire_arm_serial.ToString();
            this.txt_ammunition_count.Text = SystemConst._ammunition_count.ToString();
            this.chk_public_holiday.Checked = SystemConst._is_public_holiday;
            this.chk_leave.Checked = SystemConst._is_leave_day_for_guard;
            this.lbl_branch.Text = SystemConst._branch;
            this.lbl_name.Text = SystemConst._guard_name;
        }
	}
}