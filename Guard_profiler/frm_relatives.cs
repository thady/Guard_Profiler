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
	public class frm_relatives : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private TextBox txt_guard_number;

		private Label label1;

		private TextBox txt_name;

		private Label label13;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel panel_details;

		private GroupBox groupBox1;

		private Label label2;

		private Label label3;

		private TextBox txt_relative_1_name;

		private Label label4;

		private TextBox txt_relative_1_phone;

		private GroupBox groupBox2;

		private TextBox txt_relative_2_occupation;

		private Label label5;

		private TextBox txt_relative_2_phone;

		private Label label6;

		private TextBox txt_relative_2_name;

		private Label label7;

		private TextBox txt_relative_1_occupation;

		private GroupBox groupBox3;

		private TextBox txt_next_kin_phone;

		private Label label8;

		private TextBox txt_next_kin_adress;

		private Label label9;

		private TextBox txt_next_kin_name;

		private Label label10;

		private Label label11;

		private ComboBox cbo_next_kin_relationship;

		private Label label12;

		private TextBox txt_next_kin_national_id;

		private Button btnEdit;

		private Button btnsave;

		public frm_relatives()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_GUARD_RELATIVE_DETAILS("UPDATE_GUARD_RELATIVE_DETAILS", this.txt_guard_number.Text, this.txt_relative_1_name.Text, this.txt_relative_1_phone.Text, this.txt_relative_1_occupation.Text, this.txt_relative_2_name.Text, this.txt_relative_2_phone.Text, this.txt_relative_2_occupation.Text, this.txt_next_kin_name.Text, this.txt_next_kin_adress.Text, this.cbo_next_kin_relationship.Text, this.txt_next_kin_phone.Text, this.txt_next_kin_national_id.Text);
			this.RETURN_GUARD_DETAILS(this.txt_guard_number.Text);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_relatives_Load(object sender, EventArgs e)
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_relatives));
			this.panel1 = new Panel();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel_details = new Panel();
			this.groupBox3 = new GroupBox();
			this.txt_next_kin_national_id = new TextBox();
			this.label12 = new Label();
			this.cbo_next_kin_relationship = new ComboBox();
			this.label11 = new Label();
			this.txt_next_kin_phone = new TextBox();
			this.label8 = new Label();
			this.txt_next_kin_adress = new TextBox();
			this.label9 = new Label();
			this.txt_next_kin_name = new TextBox();
			this.label10 = new Label();
			this.groupBox2 = new GroupBox();
			this.txt_relative_2_occupation = new TextBox();
			this.label5 = new Label();
			this.txt_relative_2_phone = new TextBox();
			this.label6 = new Label();
			this.txt_relative_2_name = new TextBox();
			this.label7 = new Label();
			this.groupBox1 = new GroupBox();
			this.txt_relative_1_occupation = new TextBox();
			this.label4 = new Label();
			this.txt_relative_1_phone = new TextBox();
			this.label3 = new Label();
			this.txt_relative_1_name = new TextBox();
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
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.panel_details);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(1, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(817, 557);
			this.panel1.TabIndex = 0;
			this.btnEdit.Location = new Point(574, 501);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 41;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(691, 500);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 40;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.panel_details.BorderStyle = BorderStyle.Fixed3D;
			this.panel_details.Controls.Add(this.groupBox3);
			this.panel_details.Controls.Add(this.groupBox2);
			this.panel_details.Controls.Add(this.groupBox1);
			this.panel_details.Location = new Point(3, 160);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(804, 338);
			this.panel_details.TabIndex = 39;
			this.groupBox3.BackColor = Color.LightBlue;
			this.groupBox3.Controls.Add(this.txt_next_kin_national_id);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.cbo_next_kin_relationship);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txt_next_kin_phone);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.txt_next_kin_adress);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txt_next_kin_name);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new Point(3, 227);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(798, 105);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Next of Kin";
			this.txt_next_kin_national_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_next_kin_national_id.Location = new Point(257, 77);
			this.txt_next_kin_national_id.Name = "txt_next_kin_national_id";
			this.txt_next_kin_national_id.Size = new System.Drawing.Size(294, 24);
			this.txt_next_kin_national_id.TabIndex = 35;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = SystemColors.ActiveCaptionText;
			this.label12.Location = new Point(257, 62);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 16);
			this.label12.TabIndex = 34;
			this.label12.Text = "National ID No.";
			this.cbo_next_kin_relationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_next_kin_relationship.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_next_kin_relationship.Items;
			object[] objArray = new object[] { "", "Father", "Mother", "Aunt", "Uncle", "Brother", "Cousin", "Granny", "Friend", "Spouse" };
//			items.AddRange(objArray);
			this.cbo_next_kin_relationship.Location = new Point(560, 33);
			this.cbo_next_kin_relationship.Name = "cbo_next_kin_relationship";
			this.cbo_next_kin_relationship.Size = new System.Drawing.Size(232, 26);
			this.cbo_next_kin_relationship.TabIndex = 33;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = SystemColors.ActiveCaptionText;
			this.label11.Location = new Point(557, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 16);
			this.label11.TabIndex = 32;
			this.label11.Text = "Relationship";
			this.txt_next_kin_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_next_kin_phone.Location = new Point(9, 77);
			this.txt_next_kin_phone.Name = "txt_next_kin_phone";
			this.txt_next_kin_phone.Size = new System.Drawing.Size(242, 24);
			this.txt_next_kin_phone.TabIndex = 31;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(6, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 16);
			this.label8.TabIndex = 30;
			this.label8.Text = "Phone";
			this.txt_next_kin_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_next_kin_adress.Location = new Point(257, 35);
			this.txt_next_kin_adress.Name = "txt_next_kin_adress";
			this.txt_next_kin_adress.Size = new System.Drawing.Size(294, 24);
			this.txt_next_kin_adress.TabIndex = 29;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ActiveCaptionText;
			this.label9.Location = new Point(257, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 16);
			this.label9.TabIndex = 28;
			this.label9.Text = "Adress";
			this.txt_next_kin_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_next_kin_name.Location = new Point(9, 35);
			this.txt_next_kin_name.Name = "txt_next_kin_name";
			this.txt_next_kin_name.Size = new System.Drawing.Size(242, 24);
			this.txt_next_kin_name.TabIndex = 27;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = SystemColors.ActiveCaptionText;
			this.label10.Location = new Point(6, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "Name";
			this.groupBox2.BackColor = SystemColors.GradientInactiveCaption;
			this.groupBox2.Controls.Add(this.txt_relative_2_occupation);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txt_relative_2_phone);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txt_relative_2_name);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new Point(3, 115);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(551, 106);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Second Relative";
			this.txt_relative_2_occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_2_occupation.Location = new Point(9, 77);
			this.txt_relative_2_occupation.Name = "txt_relative_2_occupation";
			this.txt_relative_2_occupation.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_2_occupation.TabIndex = 31;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(6, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Occupation";
			this.txt_relative_2_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_2_phone.Location = new Point(257, 35);
			this.txt_relative_2_phone.Name = "txt_relative_2_phone";
			this.txt_relative_2_phone.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_2_phone.TabIndex = 29;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(257, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 16);
			this.label6.TabIndex = 28;
			this.label6.Text = "Phone";
			this.txt_relative_2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_2_name.Location = new Point(9, 35);
			this.txt_relative_2_name.Name = "txt_relative_2_name";
			this.txt_relative_2_name.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_2_name.TabIndex = 27;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(6, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 27;
			this.label7.Text = "Name";
			this.groupBox1.BackColor = SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.txt_relative_1_occupation);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_relative_1_phone);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_relative_1_name);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(551, 106);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "First Relative";
			this.txt_relative_1_occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_1_occupation.Location = new Point(9, 77);
			this.txt_relative_1_occupation.Name = "txt_relative_1_occupation";
			this.txt_relative_1_occupation.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_1_occupation.TabIndex = 31;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(6, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 30;
			this.label4.Text = "Occupation";
			this.txt_relative_1_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_1_phone.Location = new Point(257, 35);
			this.txt_relative_1_phone.Name = "txt_relative_1_phone";
			this.txt_relative_1_phone.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_1_phone.TabIndex = 29;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(257, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "Phone";
			this.txt_relative_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_relative_1_name.Location = new Point(9, 35);
			this.txt_relative_1_name.Name = "txt_relative_1_name";
			this.txt_relative_1_name.Size = new System.Drawing.Size(242, 24);
			this.txt_relative_1_name.TabIndex = 27;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Name";
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(659, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(155, 143);
			this.panel9.TabIndex = 38;
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
			this.panel2.Size = new System.Drawing.Size(650, 100);
			this.panel2.TabIndex = 37;
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
			this.BackColor = Color.FromArgb(255, 255, 128);
			base.ClientSize = new System.Drawing.Size(820, 562);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_relatives";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "GUARD RELATIVES DETAILS";
			base.Load += new EventHandler(this.frm_relatives_Load);
			this.panel1.ResumeLayout(false);
			this.panel_details.ResumeLayout(false);
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
			DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				this.txt_relative_1_name.Text = (dtRow["relative_one_name"] != DBNull.Value ? (string)dtRow["relative_one_name"] : string.Empty);
				this.txt_relative_1_phone.Text = (dtRow["relative_one_phone"] != DBNull.Value ? (string)dtRow["relative_one_phone"] : string.Empty);
				this.txt_relative_1_occupation.Text = (dtRow["relative_one_occupation"] != DBNull.Value ? (string)dtRow["relative_one_occupation"] : string.Empty);
				this.txt_relative_2_name.Text = (dtRow["relative_two_name"] != DBNull.Value ? (string)dtRow["relative_two_name"] : string.Empty);
				this.txt_relative_2_phone.Text = (dtRow["relative_two_phone"] != DBNull.Value ? (string)dtRow["relative_two_phone"] : string.Empty);
				this.txt_relative_2_occupation.Text = (dtRow["relative_two_occupation"] != DBNull.Value ? (string)dtRow["relative_two_occupation"] : string.Empty);
				this.txt_next_kin_name.Text = (dtRow["next_of_kin_name"] != DBNull.Value ? (string)dtRow["next_of_kin_name"] : string.Empty);
				this.txt_next_kin_adress.Text = (dtRow["next_of_kin_adress"] != DBNull.Value ? (string)dtRow["next_of_kin_adress"] : string.Empty);
				this.cbo_next_kin_relationship.Text = (dtRow["next_of_kin_relationship"] != DBNull.Value ? (string)dtRow["next_of_kin_relationship"] : string.Empty);
				this.txt_next_kin_phone.Text = (dtRow["next_of_kin_phone"] != DBNull.Value ? (string)dtRow["next_of_kin_phone"] : string.Empty);
				this.txt_next_kin_national_id.Text = (dtRow["next_of_kin_national_id_number"] != DBNull.Value ? (string)dtRow["next_of_kin_national_id_number"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}