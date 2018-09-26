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
	public class frm_children : Form
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

		private Label label3;

		private TextBox txt_child_1_name;

		private TextBox txt_child_1_contact;

		private Label label2;

		private TextBox txt_child_4_contact;

		private Label label8;

		private TextBox txt_child_4_name;

		private Label label9;

		private TextBox txt_child_3_contact;

		private Label label6;

		private TextBox txt_child_3_name;

		private Label label7;

		private TextBox txt_child_2_contact;

		private Label label4;

		private TextBox txt_child_2_name;

		private Label label5;

		private Button btnEdit;

		private Button btnsave;

		public frm_children()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_GUARD_CHILDREN_DETAILS("UPDATE_GUARD_CHILDREN_DETAILS", this.txt_guard_number.Text, this.txt_child_1_name.Text, this.txt_child_1_contact.Text, this.txt_child_2_name.Text, this.txt_child_2_contact.Text, this.txt_child_3_name.Text, this.txt_child_3_contact.Text, this.txt_child_4_name.Text, this.txt_child_4_contact.Text);
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

		private void frm_children_Load(object sender, EventArgs e)
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_children));
			this.panel1 = new Panel();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel_details = new Panel();
			this.txt_child_4_contact = new TextBox();
			this.label8 = new Label();
			this.txt_child_4_name = new TextBox();
			this.label9 = new Label();
			this.txt_child_3_contact = new TextBox();
			this.label6 = new Label();
			this.txt_child_3_name = new TextBox();
			this.label7 = new Label();
			this.txt_child_2_contact = new TextBox();
			this.label4 = new Label();
			this.txt_child_2_name = new TextBox();
			this.label5 = new Label();
			this.txt_child_1_contact = new TextBox();
			this.label2 = new Label();
			this.txt_child_1_name = new TextBox();
			this.label3 = new Label();
			this.panel9 = new Panel();
			this.picBoxImage = new PictureBox();
			this.panel2 = new Panel();
			this.txt_guard_number = new TextBox();
			this.label1 = new Label();
			this.txt_name = new TextBox();
			this.label13 = new Label();
			this.panel1.SuspendLayout();
			this.panel_details.SuspendLayout();
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
			this.panel1.Location = new Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(711, 463);
			this.panel1.TabIndex = 0;
			this.btnEdit.Location = new Point(472, 396);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 75;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(589, 395);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 74;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.panel_details.BackColor = Color.FromArgb(224, 224, 224);
			this.panel_details.BorderStyle = BorderStyle.Fixed3D;
			this.panel_details.Controls.Add(this.txt_child_4_contact);
			this.panel_details.Controls.Add(this.label8);
			this.panel_details.Controls.Add(this.txt_child_4_name);
			this.panel_details.Controls.Add(this.label9);
			this.panel_details.Controls.Add(this.txt_child_3_contact);
			this.panel_details.Controls.Add(this.label6);
			this.panel_details.Controls.Add(this.txt_child_3_name);
			this.panel_details.Controls.Add(this.label7);
			this.panel_details.Controls.Add(this.txt_child_2_contact);
			this.panel_details.Controls.Add(this.label4);
			this.panel_details.Controls.Add(this.txt_child_2_name);
			this.panel_details.Controls.Add(this.label5);
			this.panel_details.Controls.Add(this.txt_child_1_contact);
			this.panel_details.Controls.Add(this.label2);
			this.panel_details.Controls.Add(this.txt_child_1_name);
			this.panel_details.Controls.Add(this.label3);
			this.panel_details.Location = new Point(3, 149);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(699, 241);
			this.panel_details.TabIndex = 38;
			this.txt_child_4_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_4_contact.Location = new Point(369, 175);
			this.txt_child_4_contact.Name = "txt_child_4_contact";
			this.txt_child_4_contact.Size = new System.Drawing.Size(214, 24);
			this.txt_child_4_contact.TabIndex = 48;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = SystemColors.ActiveCaptionText;
			this.label8.Location = new Point(366, 156);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(136, 16);
			this.label8.TabIndex = 47;
			this.label8.Text = "Fourth Child's Contact";
			this.txt_child_4_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_4_name.Location = new Point(10, 175);
			this.txt_child_4_name.Name = "txt_child_4_name";
			this.txt_child_4_name.Size = new System.Drawing.Size(350, 24);
			this.txt_child_4_name.TabIndex = 46;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ActiveCaptionText;
			this.label9.Location = new Point(7, 156);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 16);
			this.label9.TabIndex = 45;
			this.label9.Text = "Fourth Child's Name";
			this.txt_child_3_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_3_contact.Location = new Point(369, 130);
			this.txt_child_3_contact.Name = "txt_child_3_contact";
			this.txt_child_3_contact.Size = new System.Drawing.Size(214, 24);
			this.txt_child_3_contact.TabIndex = 44;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ActiveCaptionText;
			this.label6.Location = new Point(366, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(130, 16);
			this.label6.TabIndex = 43;
			this.label6.Text = "Third Child's Contact";
			this.txt_child_3_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_3_name.Location = new Point(10, 130);
			this.txt_child_3_name.Name = "txt_child_3_name";
			this.txt_child_3_name.Size = new System.Drawing.Size(350, 24);
			this.txt_child_3_name.TabIndex = 42;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = SystemColors.ActiveCaptionText;
			this.label7.Location = new Point(7, 111);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(122, 16);
			this.label7.TabIndex = 41;
			this.label7.Text = "Third Child's Name";
			this.txt_child_2_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_2_contact.Location = new Point(369, 79);
			this.txt_child_2_contact.Name = "txt_child_2_contact";
			this.txt_child_2_contact.Size = new System.Drawing.Size(214, 24);
			this.txt_child_2_contact.TabIndex = 40;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(366, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 16);
			this.label4.TabIndex = 39;
			this.label4.Text = "Second Child's Contact";
			this.txt_child_2_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_2_name.Location = new Point(10, 79);
			this.txt_child_2_name.Name = "txt_child_2_name";
			this.txt_child_2_name.Size = new System.Drawing.Size(350, 24);
			this.txt_child_2_name.TabIndex = 38;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(7, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 16);
			this.label5.TabIndex = 37;
			this.label5.Text = "Second Child's Name";
			this.txt_child_1_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_1_contact.Location = new Point(369, 31);
			this.txt_child_1_contact.Name = "txt_child_1_contact";
			this.txt_child_1_contact.Size = new System.Drawing.Size(214, 24);
			this.txt_child_1_contact.TabIndex = 36;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(366, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 16);
			this.label2.TabIndex = 35;
			this.label2.Text = "First Child's Contact";
			this.txt_child_1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_child_1_name.Location = new Point(10, 31);
			this.txt_child_1_name.Name = "txt_child_1_name";
			this.txt_child_1_name.Size = new System.Drawing.Size(350, 24);
			this.txt_child_1_name.TabIndex = 34;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(7, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "First Child's Name";
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(553, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(155, 143);
			this.panel9.TabIndex = 37;
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
			this.panel2.Size = new System.Drawing.Size(544, 100);
			this.panel2.TabIndex = 36;
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
			base.ClientSize = new System.Drawing.Size(716, 469);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_children";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "GUARD CHILDREN INFORMATION";
			base.Load += new EventHandler(this.frm_children_Load);
			this.panel1.ResumeLayout(false);
			this.panel_details.ResumeLayout(false);
			this.panel_details.PerformLayout();
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
				this.txt_child_1_name.Text = (dtRow["child_one_name"] != DBNull.Value ? (string)dtRow["child_one_name"] : string.Empty);
				this.txt_child_1_contact.Text = (dtRow["child_one_contact"] != DBNull.Value ? (string)dtRow["child_one_contact"] : string.Empty);
				this.txt_child_2_name.Text = (dtRow["child_two_name"] != DBNull.Value ? (string)dtRow["child_two_name"] : string.Empty);
				this.txt_child_2_contact.Text = (dtRow["child_two_contact"] != DBNull.Value ? (string)dtRow["child_two_contact"] : string.Empty);
				this.txt_child_3_name.Text = (dtRow["child_three_name"] != DBNull.Value ? (string)dtRow["child_three_name"] : string.Empty);
				this.txt_child_3_contact.Text = (dtRow["child_three_contact"] != DBNull.Value ? (string)dtRow["child_three_contact"] : string.Empty);
				this.txt_child_4_name.Text = (dtRow["child_four_name"] != DBNull.Value ? (string)dtRow["child_four_name"] : string.Empty);
				this.txt_child_4_contact.Text = (dtRow["child_four_contact"] != DBNull.Value ? (string)dtRow["child_four_contact"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}