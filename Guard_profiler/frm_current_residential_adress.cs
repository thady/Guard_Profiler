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
	public class frm_current_residential_adress : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel9;

		private PictureBox picBoxImage;

		private Panel panel2;

		private Label label13;

		private TextBox txt_guard_number;

		private Label label1;

		private TextBox txt_name;

		private Panel panel_details;

		private Label label2;

		private RichTextBox txt_adress;

		private Label label3;

		private TextBox txt_county;

		private ComboBox cbo_dstrict;

		private Label label4;

		private Label label5;

		private Label label6;

		private TextBox txt_sub_county;

		private TextBox txt_parish;

		private Label label7;

		private TextBox txt_village;

		private Label label8;

		private Label label9;

		private TextBox txt_zone;

		private TextBox txt_landlord_name;

		private Label label10;

		private TextBox txt_lc_1_chairperson_name;

		private Label label11;

		private TextBox txt_lc_1_chairperson_phone;

		private Button btnEdit;

		private Button btnsave;

		public frm_current_residential_adress()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_CURRENT_RESIDENTIAL_ADRESS_DETAILS("UPDATE_CURRENT_RESIDENTIAL_ADRESS_DETAILS", this.txt_guard_number.Text, this.txt_adress.Text, this.cbo_dstrict.Text, this.txt_county.Text, this.txt_sub_county.Text, this.txt_parish.Text, this.txt_village.Text, this.txt_zone.Text, this.txt_landlord_name.Text, this.txt_lc_1_chairperson_name.Text, this.txt_lc_1_chairperson_phone.Text);
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

		private void frm_current_residential_adress_Load(object sender, EventArgs e)
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_current_residential_adress));
			this.panel1 = new Panel();
			this.panel_details = new Panel();
			this.txt_lc_1_chairperson_phone = new TextBox();
			this.label11 = new Label();
			this.txt_lc_1_chairperson_name = new TextBox();
			this.label10 = new Label();
			this.txt_landlord_name = new TextBox();
			this.label9 = new Label();
			this.txt_zone = new TextBox();
			this.label8 = new Label();
			this.txt_village = new TextBox();
			this.label7 = new Label();
			this.txt_parish = new TextBox();
			this.label6 = new Label();
			this.txt_sub_county = new TextBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.cbo_dstrict = new ComboBox();
			this.txt_county = new TextBox();
			this.label3 = new Label();
			this.txt_adress = new RichTextBox();
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
			this.panel_details.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.panel_details);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Location = new Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(717, 519);
			this.panel1.TabIndex = 0;
			this.panel_details.BackColor = SystemColors.Control;
			this.panel_details.BorderStyle = BorderStyle.Fixed3D;
			this.panel_details.Controls.Add(this.txt_lc_1_chairperson_phone);
			this.panel_details.Controls.Add(this.label11);
			this.panel_details.Controls.Add(this.txt_lc_1_chairperson_name);
			this.panel_details.Controls.Add(this.label10);
			this.panel_details.Controls.Add(this.txt_landlord_name);
			this.panel_details.Controls.Add(this.label9);
			this.panel_details.Controls.Add(this.txt_zone);
			this.panel_details.Controls.Add(this.label8);
			this.panel_details.Controls.Add(this.txt_village);
			this.panel_details.Controls.Add(this.label7);
			this.panel_details.Controls.Add(this.txt_parish);
			this.panel_details.Controls.Add(this.label6);
			this.panel_details.Controls.Add(this.txt_sub_county);
			this.panel_details.Controls.Add(this.label5);
			this.panel_details.Controls.Add(this.label4);
			this.panel_details.Controls.Add(this.cbo_dstrict);
			this.panel_details.Controls.Add(this.txt_county);
			this.panel_details.Controls.Add(this.label3);
			this.panel_details.Controls.Add(this.txt_adress);
			this.panel_details.Controls.Add(this.label2);
			this.panel_details.Location = new Point(3, 147);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(705, 315);
			this.panel_details.TabIndex = 36;
			this.txt_lc_1_chairperson_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_lc_1_chairperson_phone.Location = new Point(265, 285);
			this.txt_lc_1_chairperson_phone.Name = "txt_lc_1_chairperson_phone";
			this.txt_lc_1_chairperson_phone.Size = new System.Drawing.Size(203, 24);
			this.txt_lc_1_chairperson_phone.TabIndex = 45;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = SystemColors.ActiveCaptionText;
			this.label11.Location = new Point(262, 267);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(149, 16);
			this.label11.TabIndex = 44;
			this.label11.Text = "LC1 Chairperson Phone";
			this.txt_lc_1_chairperson_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_lc_1_chairperson_name.Location = new Point(11, 285);
			this.txt_lc_1_chairperson_name.Name = "txt_lc_1_chairperson_name";
			this.txt_lc_1_chairperson_name.Size = new System.Drawing.Size(246, 24);
			this.txt_lc_1_chairperson_name.TabIndex = 43;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = SystemColors.ActiveCaptionText;
			this.label10.Location = new Point(8, 267);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(147, 16);
			this.label10.TabIndex = 42;
			this.label10.Text = "LC1 Chairperson Name";
			this.txt_landlord_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_landlord_name.Location = new Point(263, 240);
			this.txt_landlord_name.Name = "txt_landlord_name";
			this.txt_landlord_name.Size = new System.Drawing.Size(414, 24);
			this.txt_landlord_name.TabIndex = 41;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ActiveCaptionText;
			this.label9.Location = new Point(263, 221);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 16);
			this.label9.TabIndex = 40;
			this.label9.Text = "Landlord Name(If Any)";
			this.txt_zone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_zone.Location = new Point(11, 240);
			this.txt_zone.Name = "txt_zone";
			this.txt_zone.Size = new System.Drawing.Size(246, 24);
			this.txt_zone.TabIndex = 39;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(8, 221);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 16);
			this.label8.TabIndex = 38;
			this.label8.Text = "Zone";
			this.txt_village.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_village.Location = new Point(474, 194);
			this.txt_village.Name = "txt_village";
			this.txt_village.Size = new System.Drawing.Size(203, 24);
			this.txt_village.TabIndex = 37;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(471, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 16);
			this.label7.TabIndex = 36;
			this.label7.Text = "Village";
			this.txt_parish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_parish.Location = new Point(265, 194);
			this.txt_parish.Name = "txt_parish";
			this.txt_parish.Size = new System.Drawing.Size(203, 24);
			this.txt_parish.TabIndex = 35;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(262, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 16);
			this.label6.TabIndex = 34;
			this.label6.Text = "Parish";
			this.txt_sub_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_sub_county.Location = new Point(10, 194);
			this.txt_sub_county.Name = "txt_sub_county";
			this.txt_sub_county.Size = new System.Drawing.Size(246, 24);
			this.txt_sub_county.TabIndex = 33;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(7, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 32;
			this.label5.Text = "Sub-County";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(262, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 16);
			this.label4.TabIndex = 31;
			this.label4.Text = "County/Division";
			this.cbo_dstrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_dstrict.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_dstrict.Items;
			object[] objArray = new object[] { "", "Arua", "Buikwe", "Busia", "FortPotal", "Gomba", "Gulu Lira", "Hoima", "Iganga", "Isingiro", "Jinja", "Kabaale", "Kampala", "Kamuli", "Kibaale", "Kiboga", "Kumi", "Luweero", "Masaka", "Masindi", "Mbale", "Mbarara", "Mityana", "Mpigi", "Mukono", "Nakasongola", "Nwoya", "Pader", "Sembabule", "Soroti", "Tororo", "Wakiso" };
//			items.AddRange(objArray);
			this.cbo_dstrict.Location = new Point(10, 146);
			this.cbo_dstrict.Name = "cbo_dstrict";
			this.cbo_dstrict.Size = new System.Drawing.Size(246, 26);
			this.cbo_dstrict.TabIndex = 30;
			this.txt_county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_county.Location = new Point(265, 146);
			this.txt_county.Name = "txt_county";
			this.txt_county.Size = new System.Drawing.Size(203, 24);
			this.txt_county.TabIndex = 27;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(7, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "District";
			this.txt_adress.Location = new Point(10, 28);
			this.txt_adress.Name = "txt_adress";
			this.txt_adress.Size = new System.Drawing.Size(446, 96);
			this.txt_adress.TabIndex = 28;
			this.txt_adress.Text = "";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Yellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(7, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Current Adress";
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
			this.btnEdit.Location = new Point(479, 464);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 47;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(596, 463);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 46;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(722, 524);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_current_residential_adress";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "CURRENT RESIDENTIAL DETAILS";
			base.Load += new EventHandler(this.frm_current_residential_adress_Load);
			this.panel1.ResumeLayout(false);
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
				this.txt_adress.Text = (dtRow["current_adress"] != DBNull.Value ? (string)dtRow["current_adress"] : string.Empty);
				this.cbo_dstrict.Text = (dtRow["current_district"] != DBNull.Value ? (string)dtRow["current_district"] : string.Empty);
				this.txt_county.Text = (dtRow["current_county"] != DBNull.Value ? (string)dtRow["current_county"] : string.Empty);
				this.txt_sub_county.Text = (dtRow["current_sub_county"] != DBNull.Value ? (string)dtRow["current_sub_county"] : string.Empty);
				this.txt_parish.Text = (dtRow["current_parish"] != DBNull.Value ? (string)dtRow["current_parish"] : string.Empty);
				this.txt_village.Text = (dtRow["current_village"] != DBNull.Value ? (string)dtRow["current_village"] : string.Empty);
				this.txt_zone.Text = (dtRow["current_zone"] != DBNull.Value ? (string)dtRow["current_zone"] : string.Empty);
				this.txt_landlord_name.Text = (dtRow["landlord_name"] != DBNull.Value ? (string)dtRow["landlord_name"] : string.Empty);
				this.txt_lc_1_chairperson_name.Text = (dtRow["lc1_chairperson_name"] != DBNull.Value ? (string)dtRow["lc1_chairperson_name"] : string.Empty);
				this.txt_lc_1_chairperson_phone.Text = (dtRow["lc1_chairperson_phone"] != DBNull.Value ? (string)dtRow["lc1_chairperson_phone"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}