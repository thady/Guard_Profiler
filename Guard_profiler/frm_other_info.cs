using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_other_info : Form
	{
		private DateTime? dt = null;

		private IContainer components;

		private Panel panel1;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel panel2;

		private TextBox txt_guard_number;

		private Label label1;

		private TextBox txt_name;

		private Label label13;

		private Panel panel3;

		private CheckBox chk_illness;

		private Label label2;

		private TextBox txt_illness_name;

		private Label label3;

		private Panel panel4;

		private DateTimePicker dt_illness_date;

		private CheckBox chk_illness_date;

		private CheckBox chk_premonia;

		private CheckBox chk_epilipsy;

		private CheckBox chk_TB;

		private Panel panel5;

		private Label label4;

		private Panel panel6;

		private DateTimePicker dt_employment_date;

		private CheckBox checkBox6;

		private Label label5;

		private TextBox txt_recruitment_officer;

		private Label label6;

		private RichTextBox txt_salary;

		private Label label7;

		private TextBox txt_nssf_no;

		private Label label8;

		private ComboBox cbo_bank_name;

		private Label label9;

		private TextBox txt_acc_no;

		private Label label10;

		private ComboBox cbo_position;

		private Label label11;

		private RichTextBox txt_general_conduct;

		private Button btnEdit;

		private Button btnsave;

		private Panel panel_details;

		public frm_other_info()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_OTHER_GUARD_DETAILS_AND_OFFICIAL_DATA("UPDATE_OTHER_GUARD_DETAILS_AND_OFFICIAL_DATA", this.txt_guard_number.Text, (this.chk_illness.Checked ? true : false), (this.txt_illness_name.Text != string.Empty ? this.txt_illness_name.Text : string.Empty), this.dt, (this.chk_premonia.Checked ? true : false), (this.chk_epilipsy.Checked ? true : false), (this.chk_TB.Checked ? true : false), this.dt_employment_date.Value.Date, (this.txt_recruitment_officer.Text != string.Empty ? this.txt_recruitment_officer.Text : string.Empty), (this.txt_salary.Text != string.Empty ? this.txt_salary.Text : string.Empty), this.txt_nssf_no.Text, this.cbo_bank_name.Text, this.txt_acc_no.Text, this.cbo_position.Text, this.txt_general_conduct.Text);
			this.panel_details.Enabled = false;
		}

		private void cbo_bank_name_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txt_acc_no.Enabled = (this.cbo_bank_name.Text != string.Empty ? true : false);
		}

		private void chk_illness_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_illness_name.Enabled = (this.chk_illness.Checked ? true : false);
			if (!this.chk_illness.Checked)
			{
				this.txt_illness_name.Clear();
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

		private void dt_illness_date_ValueChanged(object sender, EventArgs e)
		{
			this.dt = new DateTime?(this.dt_illness_date.Value.Date);
		}

		private void frm_other_info_Load(object sender, EventArgs e)
		{
			this.txt_name.Text = SystemConst.GET_OfficerName();
			this.txt_guard_number.Text = SystemConst.OfficerID;
			this.RETURN_GUARD_DETAILS(this.txt_guard_number.Text);
			this.GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", SystemConst.record_guid);
			this.chk_illness_CheckedChanged(this.chk_illness, null);
			this.cbo_bank_name_SelectedIndexChanged(this.cbo_bank_name, null);
			this.GET_POSITIONS();
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_other_info));
			this.panel1 = new Panel();
			this.panel_details = new Panel();
			this.panel3 = new Panel();
			this.chk_TB = new CheckBox();
			this.chk_epilipsy = new CheckBox();
			this.chk_premonia = new CheckBox();
			this.panel4 = new Panel();
			this.dt_illness_date = new DateTimePicker();
			this.chk_illness_date = new CheckBox();
			this.label3 = new Label();
			this.txt_illness_name = new TextBox();
			this.label2 = new Label();
			this.chk_illness = new CheckBox();
			this.panel5 = new Panel();
			this.txt_general_conduct = new RichTextBox();
			this.label11 = new Label();
			this.cbo_position = new ComboBox();
			this.label10 = new Label();
			this.txt_acc_no = new TextBox();
			this.label9 = new Label();
			this.cbo_bank_name = new ComboBox();
			this.label8 = new Label();
			this.txt_nssf_no = new TextBox();
			this.label7 = new Label();
			this.txt_salary = new RichTextBox();
			this.label6 = new Label();
			this.txt_recruitment_officer = new TextBox();
			this.label5 = new Label();
			this.panel6 = new Panel();
			this.dt_employment_date = new DateTimePicker();
			this.checkBox6 = new CheckBox();
			this.label4 = new Label();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel9 = new Panel();
			this.picBoxImage = new PictureBox();
			this.panel2 = new Panel();
			this.txt_guard_number = new TextBox();
			this.label1 = new Label();
			this.txt_name = new TextBox();
			this.label13 = new Label();
			this.panel1.SuspendLayout();
			this.panel_details.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Gainsboro;
			this.panel1.Controls.Add(this.panel_details);
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(928, 548);
			this.panel1.TabIndex = 0;
			this.panel_details.Controls.Add(this.panel3);
			this.panel_details.Controls.Add(this.panel5);
			this.panel_details.Location = new Point(6, 152);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(919, 337);
			this.panel_details.TabIndex = 52;
			this.panel3.BackColor = Color.Azure;
			this.panel3.Controls.Add(this.chk_TB);
			this.panel3.Controls.Add(this.chk_epilipsy);
			this.panel3.Controls.Add(this.chk_premonia);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txt_illness_name);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.chk_illness);
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(911, 144);
			this.panel3.TabIndex = 40;
			this.chk_TB.AutoSize = true;
			this.chk_TB.BackColor = Color.Yellow;
			this.chk_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_TB.Location = new Point(349, 109);
			this.chk_TB.Name = "chk_TB";
			this.chk_TB.Size = new System.Drawing.Size(215, 20);
			this.chk_TB.TabIndex = 38;
			this.chk_TB.Text = "Guard has ever had TB incident";
			this.chk_TB.UseVisualStyleBackColor = false;
			this.chk_epilipsy.AutoSize = true;
			this.chk_epilipsy.BackColor = Color.Yellow;
			this.chk_epilipsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_epilipsy.Location = new Point(349, 61);
			this.chk_epilipsy.Name = "chk_epilipsy";
			this.chk_epilipsy.Size = new System.Drawing.Size(244, 20);
			this.chk_epilipsy.TabIndex = 37;
			this.chk_epilipsy.Text = "Guard has ever had epilipsy incident";
			this.chk_epilipsy.UseVisualStyleBackColor = false;
			this.chk_premonia.AutoSize = true;
			this.chk_premonia.BackColor = Color.Yellow;
			this.chk_premonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_premonia.Location = new Point(349, 15);
			this.chk_premonia.Name = "chk_premonia";
			this.chk_premonia.Size = new System.Drawing.Size(313, 20);
			this.chk_premonia.TabIndex = 36;
			this.chk_premonia.Text = "Guard has ever had pnemonia or Athma Incident";
			this.chk_premonia.UseVisualStyleBackColor = false;
			this.panel4.BackColor = Color.FromArgb(255, 224, 192);
			this.panel4.Controls.Add(this.dt_illness_date);
			this.panel4.Controls.Add(this.chk_illness_date);
			this.panel4.Location = new Point(6, 103);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 34);
			this.panel4.TabIndex = 35;
			this.dt_illness_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_illness_date.Format = DateTimePickerFormat.Short;
			this.dt_illness_date.Location = new Point(24, 6);
			this.dt_illness_date.Name = "dt_illness_date";
			this.dt_illness_date.Size = new System.Drawing.Size(205, 24);
			this.dt_illness_date.TabIndex = 4;
			this.dt_illness_date.ValueChanged += new EventHandler(this.dt_illness_date_ValueChanged);
			this.chk_illness_date.AutoSize = true;
			this.chk_illness_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_illness_date.ForeColor = Color.Red;
			this.chk_illness_date.Location = new Point(3, 12);
			this.chk_illness_date.Name = "chk_illness_date";
			this.chk_illness_date.Size = new System.Drawing.Size(15, 14);
			this.chk_illness_date.TabIndex = 4;
			this.chk_illness_date.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Red;
			this.label3.Location = new Point(3, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "Estimate illness date";
			this.txt_illness_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_illness_name.Location = new Point(6, 57);
			this.txt_illness_name.Name = "txt_illness_name";
			this.txt_illness_name.Size = new System.Drawing.Size(310, 24);
			this.txt_illness_name.TabIndex = 27;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(3, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Type in Illness below if yes";
			this.chk_illness.AutoSize = true;
			this.chk_illness.BackColor = Color.Yellow;
			this.chk_illness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_illness.Location = new Point(3, 15);
			this.chk_illness.Name = "chk_illness";
			this.chk_illness.Size = new System.Drawing.Size(313, 20);
			this.chk_illness.TabIndex = 0;
			this.chk_illness.Text = "Guard has ever had a serious accident or illness";
			this.chk_illness.UseVisualStyleBackColor = false;
			this.chk_illness.CheckedChanged += new EventHandler(this.chk_illness_CheckedChanged);
			this.panel5.BackColor = Color.Azure;
			this.panel5.Controls.Add(this.txt_general_conduct);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.cbo_position);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.txt_acc_no);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.cbo_bank_name);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.txt_nssf_no);
			this.panel5.Controls.Add(this.label7);
			this.panel5.Controls.Add(this.txt_salary);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.txt_recruitment_officer);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Location = new Point(5, 153);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(909, 177);
			this.panel5.TabIndex = 41;
			this.txt_general_conduct.Location = new Point(588, 85);
			this.txt_general_conduct.Name = "txt_general_conduct";
			this.txt_general_conduct.Size = new System.Drawing.Size(307, 70);
			this.txt_general_conduct.TabIndex = 51;
			this.txt_general_conduct.Text = "";
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = SystemColors.ActiveCaptionText;
			this.label11.Location = new Point(585, 66);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(148, 16);
			this.label11.TabIndex = 50;
			this.label11.Text = "General Guard Conduct";
			this.cbo_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_position.FormattingEnabled = true;
			this.cbo_position.Location = new Point(588, 37);
			this.cbo_position.Name = "cbo_position";
			this.cbo_position.Size = new System.Drawing.Size(233, 26);
			this.cbo_position.TabIndex = 49;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = SystemColors.ActiveCaptionText;
			this.label10.Location = new Point(585, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(162, 16);
			this.label10.TabIndex = 48;
			this.label10.Text = "Position held at discharge";
			this.txt_acc_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_acc_no.Location = new Point(346, 131);
			this.txt_acc_no.Name = "txt_acc_no";
			this.txt_acc_no.Size = new System.Drawing.Size(233, 24);
			this.txt_acc_no.TabIndex = 47;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ActiveCaptionText;
			this.label9.Location = new Point(343, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 16);
			this.label9.TabIndex = 46;
			this.label9.Text = "Account Number";
			this.cbo_bank_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_bank_name.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_bank_name.Items;
			object[] objArray = new object[] { "", "Bank of Afica", "Equity Bank", "Centenary Bank", "Stanbic Bank", "Crane Bank", "DTB", "Barclays Bank", "Housing Finance Bank", "Bank of Baroda", "KTB" };
//			items.AddRange(objArray);
			this.cbo_bank_name.Location = new Point(346, 85);
			this.cbo_bank_name.Name = "cbo_bank_name";
			this.cbo_bank_name.Size = new System.Drawing.Size(233, 26);
			this.cbo_bank_name.TabIndex = 45;
			this.cbo_bank_name.SelectedIndexChanged += new EventHandler(this.cbo_bank_name_SelectedIndexChanged);
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(343, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 16);
			this.label8.TabIndex = 44;
			this.label8.Text = "Bank Name";
			this.txt_nssf_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_nssf_no.Location = new Point(346, 37);
			this.txt_nssf_no.Name = "txt_nssf_no";
			this.txt_nssf_no.Size = new System.Drawing.Size(233, 24);
			this.txt_nssf_no.TabIndex = 43;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(343, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 16);
			this.label7.TabIndex = 42;
			this.label7.Text = "NSSF Number";
			this.txt_salary.Location = new Point(6, 127);
			this.txt_salary.Name = "txt_salary";
			this.txt_salary.Size = new System.Drawing.Size(307, 47);
			this.txt_salary.TabIndex = 41;
			this.txt_salary.Text = "";
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(4, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 16);
			this.label6.TabIndex = 40;
			this.label6.Text = "Commence salary";
			this.txt_recruitment_officer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_recruitment_officer.Location = new Point(6, 85);
			this.txt_recruitment_officer.Name = "txt_recruitment_officer";
			this.txt_recruitment_officer.Size = new System.Drawing.Size(233, 24);
			this.txt_recruitment_officer.TabIndex = 39;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(3, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 16);
			this.label5.TabIndex = 37;
			this.label5.Text = "Recruiting Officer";
			this.panel6.BackColor = Color.FromArgb(255, 224, 192);
			this.panel6.Controls.Add(this.dt_employment_date);
			this.panel6.Controls.Add(this.checkBox6);
			this.panel6.Location = new Point(7, 29);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(232, 34);
			this.panel6.TabIndex = 36;
			this.dt_employment_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dt_employment_date.Format = DateTimePickerFormat.Short;
			this.dt_employment_date.Location = new Point(24, 6);
			this.dt_employment_date.Name = "dt_employment_date";
			this.dt_employment_date.Size = new System.Drawing.Size(205, 24);
			this.dt_employment_date.TabIndex = 4;
			this.checkBox6.AutoSize = true;
			this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.checkBox6.ForeColor = Color.Red;
			this.checkBox6.Location = new Point(3, 12);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(15, 14);
			this.checkBox6.TabIndex = 4;
			this.checkBox6.UseVisualStyleBackColor = true;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(4, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Employment Date";
			this.btnEdit.Location = new Point(687, 495);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 51;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(804, 494);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 50;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(770, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(155, 143);
			this.panel9.TabIndex = 39;
			this.picBoxImage.BackColor = Color.LightCyan;
			this.picBoxImage.BorderStyle = BorderStyle.FixedSingle;
			this.picBoxImage.Location = new Point(3, 3);
			this.picBoxImage.Name = "picBoxImage";
			this.picBoxImage.Size = new System.Drawing.Size(145, 133);
			this.picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picBoxImage.TabIndex = 0;
			this.picBoxImage.TabStop = false;
			this.panel2.BackColor = Color.FromArgb(255, 224, 192);
			this.panel2.BorderStyle = BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txt_guard_number);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txt_name);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Enabled = false;
			this.panel2.Location = new Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(766, 100);
			this.panel2.TabIndex = 38;
			this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number.Location = new Point(8, 69);
			this.txt_guard_number.Name = "txt_guard_number";
			this.txt_guard_number.Size = new System.Drawing.Size(350, 24);
			this.txt_guard_number.TabIndex = 26;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ActiveCaptionText;
			this.label1.Location = new Point(5, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "Guard Number";
			this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_name.Location = new Point(8, 28);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(350, 24);
			this.txt_name.TabIndex = 24;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.ForeColor = SystemColors.ActiveCaptionText;
			this.label13.Location = new Point(5, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 16);
			this.label13.TabIndex = 23;
			this.label13.Text = "Guard Name";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Lime;
			base.ClientSize = new System.Drawing.Size(932, 552);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_other_info";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "OTHER GUARD INFORMATION";
			base.Load += new EventHandler(this.frm_other_info_Load);
			this.panel1.ResumeLayout(false);
			this.panel_details.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel9.ResumeLayout(false);
			((ISupportInitialize)this.picBoxImage).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		protected void RETURN_GUARD_DETAILS(string guard_number)
		{
			DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				this.chk_illness.Checked = (dtRow["serious_illness_or_accident"] != DBNull.Value ? (bool)dtRow["serious_illness_or_accident"] : false);
				this.txt_illness_name.Text = (dtRow["nature_of_illness"] != DBNull.Value ? (string)dtRow["nature_of_illness"] : string.Empty);
				this.dt_illness_date.Value = (dtRow["illness_or_accident_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["illness_or_accident_date"]) : DateTime.Today);
				this.chk_premonia.Checked = (dtRow["premonia_or_athma_incident"] != DBNull.Value ? (bool)dtRow["premonia_or_athma_incident"] : false);
				this.chk_epilipsy.Checked = (dtRow["epilipsy_incident"] != DBNull.Value ? (bool)dtRow["epilipsy_incident"] : false);
				this.chk_TB.Checked = (dtRow["tb_incident"] != DBNull.Value ? (bool)dtRow["tb_incident"] : false);
				this.dt_employment_date.Value = (dtRow["date_employed"] != DBNull.Value ? Convert.ToDateTime(dtRow["date_employed"]) : DateTime.Today);
				this.txt_recruitment_officer.Text = (dtRow["recruiting_officer_name"] != DBNull.Value ? (string)dtRow["recruiting_officer_name"] : string.Empty);
				this.txt_salary.Text = (dtRow["commence_salary"] != DBNull.Value ? (string)dtRow["commence_salary"] : string.Empty);
				this.txt_nssf_no.Text = (dtRow["nssf_number"] != DBNull.Value ? (string)dtRow["nssf_number"] : string.Empty);
				this.cbo_bank_name.Text = (dtRow["bank_name"] != DBNull.Value ? (string)dtRow["bank_name"] : string.Empty);
				this.txt_acc_no.Text = (dtRow["account_number"] != DBNull.Value ? (string)dtRow["account_number"] : string.Empty);
				this.cbo_position.Text = (dtRow["position_held_at_discharge"] != DBNull.Value ? (string)dtRow["position_held_at_discharge"] : string.Empty);
				this.txt_general_conduct.Text = (dtRow["general_conduct"] != DBNull.Value ? (string)dtRow["general_conduct"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}