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
	public class frm_home_adress_of_origin : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel4;

		private Panel panel_details;

		private RichTextBox txt_guard_adress;

		private Label label2;

		private Panel panel2;

		private TextBox txt_guard_number;

		private Label label1;

		private TextBox txt_name;

		private Label label13;

		private Panel panel9;

		private PictureBox picBoxImage;

		private TextBox txt_neighbor_phone;

		private Label label14;

		private TextBox txt_neighbor_name;

		private Label label12;

		private TextBox txt_lc1_chairperson_phone;

		private Label label11;

		private TextBox txt_lc1_chairperson_name;

		private Label label10;

		private TextBox txt_zone;

		private Label label8;

		private TextBox txt_village;

		private Label label7;

		private TextBox txt_parish;

		private Label label6;

		private TextBox txt_sub_county;

		private Label label5;

		private Label label4;

		private ComboBox cbo_district;

		private TextBox txt_county;

		private Label label3;

		private Button btnEdit;

		private Button btnsave;

		public frm_home_adress_of_origin()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_GUARD_HOME_ADRESS_OF_ORIGIN("UPDATE_GUARD_HOME_ADRESS_OF_ORIGIN", this.txt_guard_number.Text, this.txt_guard_adress.Text, this.cbo_district.Text, this.txt_county.Text, this.txt_sub_county.Text, this.txt_parish.Text, this.txt_village.Text, this.txt_zone.Text, this.txt_lc1_chairperson_name.Text, this.txt_lc1_chairperson_phone.Text, this.txt_neighbor_name.Text, this.txt_neighbor_phone.Text);
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

		private void frm_home_adress_of_origin_Load(object sender, EventArgs e)
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_home_adress_of_origin));
			this.panel1 = new Panel();
			this.panel4 = new Panel();
			this.panel_details = new Panel();
			this.txt_neighbor_phone = new TextBox();
			this.label14 = new Label();
			this.txt_neighbor_name = new TextBox();
			this.label12 = new Label();
			this.txt_lc1_chairperson_phone = new TextBox();
			this.label11 = new Label();
			this.txt_lc1_chairperson_name = new TextBox();
			this.label10 = new Label();
			this.txt_zone = new TextBox();
			this.label8 = new Label();
			this.txt_village = new TextBox();
			this.label7 = new Label();
			this.txt_parish = new TextBox();
			this.label6 = new Label();
			this.txt_sub_county = new TextBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.cbo_district = new ComboBox();
			this.txt_county = new TextBox();
			this.label3 = new Label();
			this.txt_guard_adress = new RichTextBox();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.txt_guard_number = new TextBox();
			this.label1 = new Label();
			this.txt_name = new TextBox();
			this.label13 = new Label();
			this.panel9 = new Panel();
			this.picBoxImage = new PictureBox();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel_details.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			base.SuspendLayout();
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(722, 526);
			this.panel1.TabIndex = 0;
			this.panel4.BackColor = Color.Azure;
			this.panel4.BorderStyle = BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.panel_details);
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Controls.Add(this.panel9);
			this.panel4.Location = new Point(3, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(717, 515);
			this.panel4.TabIndex = 1;
			this.panel_details.BackColor = SystemColors.Control;
			this.panel_details.BorderStyle = BorderStyle.Fixed3D;
			this.panel_details.Controls.Add(this.txt_neighbor_phone);
			this.panel_details.Controls.Add(this.label14);
			this.panel_details.Controls.Add(this.txt_neighbor_name);
			this.panel_details.Controls.Add(this.label12);
			this.panel_details.Controls.Add(this.txt_lc1_chairperson_phone);
			this.panel_details.Controls.Add(this.label11);
			this.panel_details.Controls.Add(this.txt_lc1_chairperson_name);
			this.panel_details.Controls.Add(this.label10);
			this.panel_details.Controls.Add(this.txt_zone);
			this.panel_details.Controls.Add(this.label8);
			this.panel_details.Controls.Add(this.txt_village);
			this.panel_details.Controls.Add(this.label7);
			this.panel_details.Controls.Add(this.txt_parish);
			this.panel_details.Controls.Add(this.label6);
			this.panel_details.Controls.Add(this.txt_sub_county);
			this.panel_details.Controls.Add(this.label5);
			this.panel_details.Controls.Add(this.label4);
			this.panel_details.Controls.Add(this.cbo_district);
			this.panel_details.Controls.Add(this.txt_county);
			this.panel_details.Controls.Add(this.label3);
			this.panel_details.Controls.Add(this.txt_guard_adress);
			this.panel_details.Controls.Add(this.label2);
			this.panel_details.Location = new Point(3, 147);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(705, 360);
			this.panel_details.TabIndex = 36;
			this.txt_neighbor_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_neighbor_phone.Location = new Point(263, 329);
			this.txt_neighbor_phone.Name = "txt_neighbor_phone";
			this.txt_neighbor_phone.Size = new System.Drawing.Size(205, 24);
			this.txt_neighbor_phone.TabIndex = 69;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.ForeColor = SystemColors.ActiveCaptionText;
			this.label14.Location = new Point(263, 313);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(161, 16);
			this.label14.TabIndex = 68;
			this.label14.Text = "Village Neighbor's Phone";
			this.txt_neighbor_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_neighbor_name.Location = new Point(11, 329);
			this.txt_neighbor_name.Name = "txt_neighbor_name";
			this.txt_neighbor_name.Size = new System.Drawing.Size(246, 24);
			this.txt_neighbor_name.TabIndex = 67;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = SystemColors.ActiveCaptionText;
			this.label12.Location = new Point(8, 313);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(149, 16);
			this.label12.TabIndex = 66;
			this.label12.Text = "Village Neighbor Name";
			this.txt_lc1_chairperson_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_lc1_chairperson_phone.Location = new Point(263, 286);
			this.txt_lc1_chairperson_phone.Name = "txt_lc1_chairperson_phone";
			this.txt_lc1_chairperson_phone.Size = new System.Drawing.Size(205, 24);
			this.txt_lc1_chairperson_phone.TabIndex = 65;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = SystemColors.ActiveCaptionText;
			this.label11.Location = new Point(262, 267);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(149, 16);
			this.label11.TabIndex = 64;
			this.label11.Text = "LC1 Chairperson Phone";
			this.txt_lc1_chairperson_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_lc1_chairperson_name.Location = new Point(10, 286);
			this.txt_lc1_chairperson_name.Name = "txt_lc1_chairperson_name";
			this.txt_lc1_chairperson_name.Size = new System.Drawing.Size(246, 24);
			this.txt_lc1_chairperson_name.TabIndex = 63;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = SystemColors.ActiveCaptionText;
			this.label10.Location = new Point(8, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(147, 16);
			this.label10.TabIndex = 62;
			this.label10.Text = "LC1 Chairperson Name";
			this.txt_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_zone.Location = new Point(263, 240);
			this.txt_zone.Name = "txt_zone";
			this.txt_zone.Size = new System.Drawing.Size(205, 24);
			this.txt_zone.TabIndex = 61;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(262, 221);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 16);
			this.label8.TabIndex = 60;
			this.label8.Text = "Zone";
			this.txt_village.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_village.Location = new Point(11, 240);
			this.txt_village.Name = "txt_village";
			this.txt_village.Size = new System.Drawing.Size(245, 24);
			this.txt_village.TabIndex = 59;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(8, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 16);
			this.label7.TabIndex = 58;
			this.label7.Text = "Village";
			this.txt_parish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_parish.Location = new Point(265, 194);
			this.txt_parish.Name = "txt_parish";
			this.txt_parish.Size = new System.Drawing.Size(203, 24);
			this.txt_parish.TabIndex = 57;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(262, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 16);
			this.label6.TabIndex = 56;
			this.label6.Text = "Parish";
			this.txt_sub_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_sub_county.Location = new Point(10, 194);
			this.txt_sub_county.Name = "txt_sub_county";
			this.txt_sub_county.Size = new System.Drawing.Size(246, 24);
			this.txt_sub_county.TabIndex = 55;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(7, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 54;
			this.label5.Text = "Sub-County";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(262, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 16);
			this.label4.TabIndex = 53;
			this.label4.Text = "County/Division";
			this.cbo_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_district.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_district.Items;
			object[] objArray = new object[] { "", "Arua", "Buikwe", "Busia", "FortPotal", "Gomba", "Gulu Lira", "Hoima", "Iganga", "Isingiro", "Jinja", "Kabaale", "Kampala", "Kamuli", "Kibaale", "Kiboga", "Kumi", "Luweero", "Masaka", "Masindi", "Mbale", "Mbarara", "Mityana", "Mpigi", "Mukono", "Nakasongola", "Nwoya", "Pader", "Sembabule", "Soroti", "Tororo", "Wakiso" };
//			items.AddRange(objArray);
			this.cbo_district.Location = new Point(10, 146);
			this.cbo_district.Name = "cbo_district";
			this.cbo_district.Size = new System.Drawing.Size(246, 26);
			this.cbo_district.TabIndex = 52;
			this.txt_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_county.Location = new Point(265, 146);
			this.txt_county.Name = "txt_county";
			this.txt_county.Size = new System.Drawing.Size(203, 24);
			this.txt_county.TabIndex = 50;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(7, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 51;
			this.label3.Text = "District";
			this.txt_guard_adress.Location = new Point(10, 28);
			this.txt_guard_adress.Name = "txt_guard_adress";
			this.txt_guard_adress.Size = new System.Drawing.Size(458, 96);
			this.txt_guard_adress.TabIndex = 28;
			this.txt_guard_adress.Text = "";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 255, 128);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(7, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Guard Home Adress of Origin";
			this.panel2.BackColor = Color.FromArgb(255, 224, 192);
			this.panel2.BorderStyle = BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txt_guard_number);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txt_name);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Enabled = false;
			this.panel2.Location = new Point(3, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(555, 100);
			this.panel2.TabIndex = 35;
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
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(559, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(155, 143);
			this.panel9.TabIndex = 34;
			this.picBoxImage.BackColor = Color.LightCyan;
			this.picBoxImage.BorderStyle = BorderStyle.FixedSingle;
			this.picBoxImage.Location = new Point(3, 3);
			this.picBoxImage.Name = "picBoxImage";
			this.picBoxImage.Size = new System.Drawing.Size(145, 133);
			this.picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picBoxImage.TabIndex = 0;
			this.picBoxImage.TabStop = false;
			this.btnEdit.Location = new Point(490, 529);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 71;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(607, 528);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 70;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(726, 576);
			base.Controls.Add(this.btnEdit);
			base.Controls.Add(this.btnsave);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_home_adress_of_origin";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "HOME ADRESS OF ORIGIN DETAILS";
			base.Load += new EventHandler(this.frm_home_adress_of_origin_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel_details.ResumeLayout(false);
			this.panel_details.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel9.ResumeLayout(false);
			((ISupportInitialize)this.picBoxImage).EndInit();
			base.ResumeLayout(false);
		}

		protected void RETURN_GUARD_DETAILS(string guard_number)
		{
			DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.Rows[0];
				this.txt_guard_adress.Text = (dtRow["home_origin_adress"] != DBNull.Value ? (string)dtRow["home_origin_adress"] : string.Empty);
				this.cbo_district.Text = (dtRow["home_district"] != DBNull.Value ? (string)dtRow["home_district"] : string.Empty);
				this.txt_county.Text = (dtRow["home_county"] != DBNull.Value ? (string)dtRow["home_county"] : string.Empty);
				this.txt_sub_county.Text = (dtRow["home_sub_county"] != DBNull.Value ? (string)dtRow["home_sub_county"] : string.Empty);
				this.txt_parish.Text = (dtRow["home_parish"] != DBNull.Value ? (string)dtRow["home_parish"] : string.Empty);
				this.txt_village.Text = (dtRow["home_village"] != DBNull.Value ? (string)dtRow["home_village"] : string.Empty);
				this.txt_zone.Text = (dtRow["home_zone"] != DBNull.Value ? (string)dtRow["home_zone"] : string.Empty);
				this.txt_lc1_chairperson_name.Text = (dtRow["home_lc1_chaiperson_name"] != DBNull.Value ? (string)dtRow["home_lc1_chaiperson_name"] : string.Empty);
				this.txt_lc1_chairperson_phone.Text = (dtRow["home_lc1_chaiperson_phone"] != DBNull.Value ? (string)dtRow["home_lc1_chaiperson_phone"] : string.Empty);
				this.txt_neighbor_name.Text = (dtRow["home_village_neigbor_name"] != DBNull.Value ? (string)dtRow["home_village_neigbor_name"] : string.Empty);
				this.txt_neighbor_phone.Text = (dtRow["home_village_neigbor_phone"] != DBNull.Value ? (string)dtRow["home_village_neigbor_phone"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}