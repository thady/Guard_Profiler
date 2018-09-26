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
	public class frm_education_history : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel panel2;

		private TextBox txt_guard_number;

		private Label label1;

		private TextBox txt_name;

		private Label label13;

		private Panel panel_details;

		private GroupBox groupBox1;

		private Label label2;

		private TextBox txt_school_1_name;

		private Label label3;

		private Label label4;

		private Label label5;

		private ComboBox cbo_school_1_leve;

		private GroupBox groupBox4;

		private Label label15;

		private ComboBox cbo_school_4_leve;

		private Label label16;

		private Label label17;

		private TextBox txt_school_4_name;

		private Label label18;

		private GroupBox groupBox3;

		private Label label10;

		private ComboBox cbo_school_3_leve;

		private Label label11;

		private Label label12;

		private TextBox txt_school_3_name;

		private Label label14;

		private GroupBox groupBox2;

		private Label label6;

		private ComboBox cbo_school_2_leve;

		private Label label7;

		private Label label8;

		private TextBox txt_school_2_name;

		private Label label9;

		private Button btnEdit;

		private Button btnsave;

		private TextBox txt_school_4_year;

		private TextBox txt_school_3_year;

		private TextBox txt_school_2_year;

		private TextBox txt_school_1_year;

		private TextBox txt_school_4_qualification;

		private TextBox txt_school_3_qualification;

		private TextBox txt_school_2_qualification;

		private TextBox txt_school_1_qualification;

		public frm_education_history()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_GUARD_EDUCATION_HISTORY("UPDATE_GUARD_EDUCATION_HISTORY", this.txt_guard_number.Text, this.txt_school_1_name.Text, (this.txt_school_1_year.Text != string.Empty ? Convert.ToInt32(this.txt_school_1_year.Text) : -1), this.cbo_school_1_leve.Text, (this.txt_school_1_qualification.Text != string.Empty ? this.txt_school_1_qualification.Text : string.Empty), (this.txt_school_2_name.Text != string.Empty ? this.txt_school_2_name.Text : string.Empty), (this.txt_school_2_year.Text != string.Empty ? Convert.ToInt32(this.txt_school_2_year.Text) : -1), this.cbo_school_2_leve.Text, (this.txt_school_2_qualification.Text != string.Empty ? this.txt_school_2_qualification.Text : string.Empty), (this.txt_school_3_name.Text != string.Empty ? this.txt_school_3_name.Text : string.Empty), (this.txt_school_3_year.Text != string.Empty ? Convert.ToInt32(this.txt_school_3_year.Text) : -1), this.cbo_school_3_leve.Text, (this.txt_school_3_qualification.Text != string.Empty ? this.txt_school_3_qualification.Text : string.Empty), (this.txt_school_4_name.Text != string.Empty ? this.txt_school_4_name.Text : string.Empty), (this.txt_school_4_year.Text != string.Empty ? Convert.ToInt32(this.txt_school_4_year.Text) : -1), (this.cbo_school_4_leve.Text != string.Empty ? this.cbo_school_4_leve.Text : ""), (this.txt_school_4_qualification.Text != string.Empty ? this.txt_school_4_qualification.Text : string.Empty));
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_education_history_Load(object sender, EventArgs e)
		{
			this.txt_name.Text = SystemConst.GET_OfficerName();
			this.txt_guard_number.Text = SystemConst.OfficerID;
			this.RETURN_GUARD_DETAILS(this.txt_guard_number.Text);
			this.GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", SystemConst.record_guid);
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_education_history));
			this.panel1 = new Panel();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel_details = new Panel();
			this.groupBox4 = new GroupBox();
			this.txt_school_4_qualification = new TextBox();
			this.txt_school_4_year = new TextBox();
			this.label15 = new Label();
			this.cbo_school_4_leve = new ComboBox();
			this.label16 = new Label();
			this.label17 = new Label();
			this.txt_school_4_name = new TextBox();
			this.label18 = new Label();
			this.groupBox3 = new GroupBox();
			this.txt_school_3_qualification = new TextBox();
			this.txt_school_3_year = new TextBox();
			this.label10 = new Label();
			this.cbo_school_3_leve = new ComboBox();
			this.label11 = new Label();
			this.label12 = new Label();
			this.txt_school_3_name = new TextBox();
			this.label14 = new Label();
			this.groupBox2 = new GroupBox();
			this.txt_school_2_qualification = new TextBox();
			this.txt_school_2_year = new TextBox();
			this.label6 = new Label();
			this.cbo_school_2_leve = new ComboBox();
			this.label7 = new Label();
			this.label8 = new Label();
			this.txt_school_2_name = new TextBox();
			this.label9 = new Label();
			this.groupBox1 = new GroupBox();
			this.txt_school_1_qualification = new TextBox();
			this.txt_school_1_year = new TextBox();
			this.label5 = new Label();
			this.cbo_school_1_leve = new ComboBox();
			this.label4 = new Label();
			this.label3 = new Label();
			this.txt_school_1_name = new TextBox();
			this.label2 = new Label();
			this.panel9 = new Panel();
			this.picBoxImage = new PictureBox();
			this.panel2 = new Panel();
			this.txt_guard_number = new TextBox();
			this.label1 = new Label();
			this.txt_name = new TextBox();
			this.label13 = new Label();
			this.panel1.SuspendLayout();
			this.panel_details.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Gainsboro;
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.panel_details);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(865, 555);
			this.panel1.TabIndex = 0;
			this.btnEdit.Location = new Point(630, 500);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 49;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(747, 499);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 48;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.panel_details.BackColor = Color.Azure;
			this.panel_details.Controls.Add(this.groupBox4);
			this.panel_details.Controls.Add(this.groupBox3);
			this.panel_details.Controls.Add(this.groupBox2);
			this.panel_details.Controls.Add(this.groupBox1);
			this.panel_details.Location = new Point(3, 150);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(859, 344);
			this.panel_details.TabIndex = 40;
			this.groupBox4.Controls.Add(this.txt_school_4_qualification);
			this.groupBox4.Controls.Add(this.txt_school_4_year);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.cbo_school_4_leve);
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.txt_school_4_name);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Location = new Point(7, 258);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(845, 79);
			this.groupBox4.TabIndex = 42;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Fourth School";
			this.txt_school_4_qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_4_qualification.Location = new Point(639, 42);
			this.txt_school_4_qualification.Name = "txt_school_4_qualification";
			this.txt_school_4_qualification.Size = new System.Drawing.Size(203, 24);
			this.txt_school_4_qualification.TabIndex = 43;
			this.txt_school_4_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_4_year.Location = new Point(227, 45);
			this.txt_school_4_year.Name = "txt_school_4_year";
			this.txt_school_4_year.Size = new System.Drawing.Size(211, 24);
			this.txt_school_4_year.TabIndex = 41;
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.ForeColor = SystemColors.ActiveCaptionText;
			this.label15.Location = new Point(630, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(81, 16);
			this.label15.TabIndex = 38;
			this.label15.Text = "Qualification";
			this.cbo_school_4_leve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_school_4_leve.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_school_4_leve.Items;
			object[] objArray = new object[] { "", "Masters Degree", "Bachelors Degree", "A'Level ", "O'Level", "P.L.E" };
//			items.AddRange(objArray);
			this.cbo_school_4_leve.Location = new Point(473, 42);
			this.cbo_school_4_leve.Name = "cbo_school_4_leve";
			this.cbo_school_4_leve.Size = new System.Drawing.Size(160, 26);
			this.cbo_school_4_leve.TabIndex = 37;
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label16.ForeColor = SystemColors.ActiveCaptionText;
			this.label16.Location = new Point(469, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 16);
			this.label16.TabIndex = 36;
			this.label16.Text = "Level";
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label17.ForeColor = SystemColors.ActiveCaptionText;
			this.label17.Location = new Point(235, 16);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(37, 16);
			this.label17.TabIndex = 35;
			this.label17.Text = "Year";
			this.txt_school_4_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_4_name.Location = new Point(10, 45);
			this.txt_school_4_name.Name = "txt_school_4_name";
			this.txt_school_4_name.Size = new System.Drawing.Size(211, 24);
			this.txt_school_4_name.TabIndex = 27;
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label18.ForeColor = SystemColors.ActiveCaptionText;
			this.label18.Location = new Point(7, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(90, 16);
			this.label18.TabIndex = 27;
			this.label18.Text = "School Name";
			this.groupBox3.Controls.Add(this.txt_school_3_qualification);
			this.groupBox3.Controls.Add(this.txt_school_3_year);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.cbo_school_3_leve);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.txt_school_3_name);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Location = new Point(7, 173);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(845, 79);
			this.groupBox3.TabIndex = 41;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Third School";
			this.txt_school_3_qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_3_qualification.Location = new Point(636, 45);
			this.txt_school_3_qualification.Name = "txt_school_3_qualification";
			this.txt_school_3_qualification.Size = new System.Drawing.Size(203, 24);
			this.txt_school_3_qualification.TabIndex = 42;
			this.txt_school_3_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_3_year.Location = new Point(227, 45);
			this.txt_school_3_year.Name = "txt_school_3_year";
			this.txt_school_3_year.Size = new System.Drawing.Size(211, 24);
			this.txt_school_3_year.TabIndex = 41;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = SystemColors.ActiveCaptionText;
			this.label10.Location = new Point(630, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 16);
			this.label10.TabIndex = 38;
			this.label10.Text = "Qualification";
			this.cbo_school_3_leve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_school_3_leve.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.cbo_school_3_leve.Items;
			object[] objArray1 = new object[] { "", "Degree", "A'Level ", "O'Level" };
//			objectCollections.AddRange(objArray1);
			this.cbo_school_3_leve.Location = new Point(473, 42);
			this.cbo_school_3_leve.Name = "cbo_school_3_leve";
			this.cbo_school_3_leve.Size = new System.Drawing.Size(160, 26);
			this.cbo_school_3_leve.TabIndex = 37;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = SystemColors.ActiveCaptionText;
			this.label11.Location = new Point(469, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 16);
			this.label11.TabIndex = 36;
			this.label11.Text = "Level";
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = SystemColors.ActiveCaptionText;
			this.label12.Location = new Point(235, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 16);
			this.label12.TabIndex = 35;
			this.label12.Text = "Year";
			this.txt_school_3_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_3_name.Location = new Point(10, 45);
			this.txt_school_3_name.Name = "txt_school_3_name";
			this.txt_school_3_name.Size = new System.Drawing.Size(211, 24);
			this.txt_school_3_name.TabIndex = 27;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.ForeColor = SystemColors.ActiveCaptionText;
			this.label14.Location = new Point(7, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(90, 16);
			this.label14.TabIndex = 27;
			this.label14.Text = "School Name";
			this.groupBox2.Controls.Add(this.txt_school_2_qualification);
			this.groupBox2.Controls.Add(this.txt_school_2_year);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbo_school_2_leve);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txt_school_2_name);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new Point(7, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(845, 79);
			this.groupBox2.TabIndex = 40;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Second School";
			this.txt_school_2_qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_2_qualification.Location = new Point(639, 44);
			this.txt_school_2_qualification.Name = "txt_school_2_qualification";
			this.txt_school_2_qualification.Size = new System.Drawing.Size(203, 24);
			this.txt_school_2_qualification.TabIndex = 44;
			this.txt_school_2_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_2_year.Location = new Point(227, 44);
			this.txt_school_2_year.Name = "txt_school_2_year";
			this.txt_school_2_year.Size = new System.Drawing.Size(211, 24);
			this.txt_school_2_year.TabIndex = 41;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(630, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 16);
			this.label6.TabIndex = 38;
			this.label6.Text = "Qualification";
			this.cbo_school_2_leve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_school_2_leve.FormattingEnabled = true;
			ComboBox.ObjectCollection items1 = this.cbo_school_2_leve.Items;
			object[] objArray2 = new object[] { "", "Masters Degree", "Bachelors Degree", "A'Level ", "O'Level" };
//			items1.AddRange(objArray2);
			this.cbo_school_2_leve.Location = new Point(473, 42);
			this.cbo_school_2_leve.Name = "cbo_school_2_leve";
			this.cbo_school_2_leve.Size = new System.Drawing.Size(160, 26);
			this.cbo_school_2_leve.TabIndex = 37;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(469, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 16);
			this.label7.TabIndex = 36;
			this.label7.Text = "Level";
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(235, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 16);
			this.label8.TabIndex = 35;
			this.label8.Text = "Year";
			this.txt_school_2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_2_name.Location = new Point(10, 45);
			this.txt_school_2_name.Name = "txt_school_2_name";
			this.txt_school_2_name.Size = new System.Drawing.Size(211, 24);
			this.txt_school_2_name.TabIndex = 27;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ActiveCaptionText;
			this.label9.Location = new Point(7, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(90, 16);
			this.label9.TabIndex = 27;
			this.label9.Text = "School Name";
			this.groupBox1.Controls.Add(this.txt_school_1_qualification);
			this.groupBox1.Controls.Add(this.txt_school_1_year);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbo_school_1_leve);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_school_1_name);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new Point(7, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(845, 79);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "First School";
			this.txt_school_1_qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_1_qualification.Location = new Point(639, 42);
			this.txt_school_1_qualification.Name = "txt_school_1_qualification";
			this.txt_school_1_qualification.Size = new System.Drawing.Size(203, 24);
			this.txt_school_1_qualification.TabIndex = 45;
			this.txt_school_1_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_1_year.Location = new Point(227, 45);
			this.txt_school_1_year.Name = "txt_school_1_year";
			this.txt_school_1_year.Size = new System.Drawing.Size(211, 24);
			this.txt_school_1_year.TabIndex = 40;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(630, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 16);
			this.label5.TabIndex = 38;
			this.label5.Text = "Qualification";
			this.cbo_school_1_leve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_school_1_leve.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections1 = this.cbo_school_1_leve.Items;
			object[] objArray3 = new object[] { "", "Masters Degree", "Bachelors Degree", "A'Level ", "O'Level" };
//			objectCollections1.AddRange(objArray3);
			this.cbo_school_1_leve.Location = new Point(473, 42);
			this.cbo_school_1_leve.Name = "cbo_school_1_leve";
			this.cbo_school_1_leve.Size = new System.Drawing.Size(160, 26);
			this.cbo_school_1_leve.TabIndex = 37;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(469, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 36;
			this.label4.Text = "Level";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(235, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 35;
			this.label3.Text = "Year";
			this.txt_school_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_school_1_name.Location = new Point(10, 45);
			this.txt_school_1_name.Name = "txt_school_1_name";
			this.txt_school_1_name.Size = new System.Drawing.Size(211, 24);
			this.txt_school_1_name.TabIndex = 27;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(7, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "School Name";
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(707, 3);
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
			this.panel2.Location = new Point(10, 11);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(696, 100);
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
			this.BackColor = Color.Yellow;
			base.ClientSize = new System.Drawing.Size(869, 557);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_education_history";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "EDUCATION HISTORY";
			base.Load += new EventHandler(this.frm_education_history_Load);
			this.panel1.ResumeLayout(false);
			this.panel_details.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel9.ResumeLayout(false);
			((ISupportInitialize)this.picBoxImage).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		protected void RETURN_GUARD_DETAILS(string guard_number)
		{
			string empty;
			string str;
			string empty1;
			string str1;
			DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				int dummy_year = -1;
				this.txt_school_1_name.Text = (dtRow["school_1_name"] != DBNull.Value ? (string)dtRow["school_1_name"] : string.Empty);
				TextBox txtSchool1Year = this.txt_school_1_year;
				if (dtRow["school_1_year"] == DBNull.Value)
				{
					empty = string.Empty;
				}
				else if (Convert.ToInt32(dtRow["school_1_year"]) != dummy_year)
				{
					int num = Convert.ToInt32(dtRow["school_1_year"]);
					empty = num.ToString();
				}
				else
				{
					empty = string.Empty;
				}
				txtSchool1Year.Text = empty;
				this.cbo_school_1_leve.Text = (dtRow["school_1_level"] != DBNull.Value ? (string)dtRow["school_1_level"] : string.Empty);
				this.txt_school_1_qualification.Text = (dtRow["school_1_qualification"] != DBNull.Value ? (string)dtRow["school_1_qualification"] : string.Empty);
				this.txt_school_2_name.Text = (dtRow["school_2_name"] != DBNull.Value ? (string)dtRow["school_2_name"] : string.Empty);
				TextBox txtSchool2Year = this.txt_school_2_year;
				if (dtRow["school_2_year"] == DBNull.Value)
				{
					str = string.Empty;
				}
				else if (Convert.ToInt32(dtRow["school_2_year"]) != dummy_year)
				{
					int num1 = Convert.ToInt32(dtRow["school_2_year"]);
					str = num1.ToString();
				}
				else
				{
					str = string.Empty;
				}
				txtSchool2Year.Text = str;
				this.cbo_school_2_leve.Text = (dtRow["school_2_level"] != DBNull.Value ? (string)dtRow["school_2_level"] : string.Empty);
				this.txt_school_2_qualification.Text = (dtRow["school_2_qualification"] != DBNull.Value ? (string)dtRow["school_2_qualification"] : string.Empty);
				this.txt_school_3_name.Text = (dtRow["school_3_name"] != DBNull.Value ? (string)dtRow["school_3_name"] : string.Empty);
				TextBox txtSchool3Year = this.txt_school_3_year;
				if (dtRow["school_3_year"] == DBNull.Value)
				{
					empty1 = string.Empty;
				}
				else if (Convert.ToInt32(dtRow["school_3_year"]) != dummy_year)
				{
					int num2 = Convert.ToInt32(dtRow["school_3_year"]);
					empty1 = num2.ToString();
				}
				else
				{
					empty1 = string.Empty;
				}
				txtSchool3Year.Text = empty1;
				this.cbo_school_3_leve.Text = (dtRow["school_3_level"] != DBNull.Value ? (string)dtRow["school_3_level"] : string.Empty);
				this.txt_school_3_qualification.Text = (dtRow["school_3_qualification"] != DBNull.Value ? (string)dtRow["school_3_qualification"] : string.Empty);
				this.txt_school_4_name.Text = (dtRow["school_4_name"] != DBNull.Value ? (string)dtRow["school_4_name"] : string.Empty);
				TextBox txtSchool4Year = this.txt_school_4_year;
				if (dtRow["school_4_year"] == DBNull.Value)
				{
					str1 = string.Empty;
				}
				else if (Convert.ToInt32(dtRow["school_4_year"]) != dummy_year)
				{
					int num3 = Convert.ToInt32(dtRow["school_4_year"]);
					str1 = num3.ToString();
				}
				else
				{
					str1 = string.Empty;
				}
				txtSchool4Year.Text = str1;
				this.cbo_school_4_leve.Text = (dtRow["school_4_level"] != DBNull.Value ? (string)dtRow["school_4_level"] : string.Empty);
				this.txt_school_4_qualification.Text = (dtRow["school_4_qualification"] != DBNull.Value ? (string)dtRow["school_4_qualification"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}