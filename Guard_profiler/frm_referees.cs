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
	public class frm_referees : Form
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

		private Label label2;

		private RichTextBox txt_ref_3;

		private Label label4;

		private RichTextBox txt_ref_2;

		private Label label3;

		private RichTextBox txt_ref_1;

		private Button btnEdit;

		private Button btnsave;

		public frm_referees()
		{
			this.InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			Guard_Employment_Records.UPDATE_GUARD_REFFERENCES("UPDATE_GUARD_REFFERENCES", this.txt_guard_number.Text, this.txt_ref_1.Text, this.txt_ref_2.Text, this.txt_ref_3.Text);
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

		private void frm_referees_Load(object sender, EventArgs e)
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
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_referees));
			this.panel1 = new Panel();
			this.btnEdit = new Button();
			this.btnsave = new Button();
			this.panel_details = new Panel();
			this.txt_ref_3 = new RichTextBox();
			this.label4 = new Label();
			this.txt_ref_2 = new RichTextBox();
			this.label3 = new Label();
			this.txt_ref_1 = new RichTextBox();
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
			this.panel1.Location = new Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(652, 527);
			this.panel1.TabIndex = 0;
			this.btnEdit.Location = new Point(414, 468);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(116, 45);
			this.btnEdit.TabIndex = 34;
			this.btnEdit.Text = "EDIT";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
			this.btnsave.Location = new Point(531, 467);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(116, 45);
			this.btnsave.TabIndex = 33;
			this.btnsave.Text = "SAVE DETAILS";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.panel_details.BackColor = Color.FromArgb(224, 224, 224);
			this.panel_details.Controls.Add(this.txt_ref_3);
			this.panel_details.Controls.Add(this.label4);
			this.panel_details.Controls.Add(this.txt_ref_2);
			this.panel_details.Controls.Add(this.label3);
			this.panel_details.Controls.Add(this.txt_ref_1);
			this.panel_details.Controls.Add(this.label2);
			this.panel_details.Location = new Point(3, 149);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(644, 312);
			this.panel_details.TabIndex = 41;
			this.txt_ref_3.Location = new Point(10, 228);
			this.txt_ref_3.Name = "txt_ref_3";
			this.txt_ref_3.Size = new System.Drawing.Size(515, 78);
			this.txt_ref_3.TabIndex = 32;
			this.txt_ref_3.Text = "";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(7, 209);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 16);
			this.label4.TabIndex = 31;
			this.label4.Text = "Reference three and adress";
			this.txt_ref_2.Location = new Point(10, 129);
			this.txt_ref_2.Name = "txt_ref_2";
			this.txt_ref_2.Size = new System.Drawing.Size(515, 78);
			this.txt_ref_2.TabIndex = 30;
			this.txt_ref_2.Text = "";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ActiveCaptionText;
			this.label3.Location = new Point(7, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 16);
			this.label3.TabIndex = 29;
			this.label3.Text = "Reference two and adress";
			this.txt_ref_1.Location = new Point(6, 30);
			this.txt_ref_1.Name = "txt_ref_1";
			this.txt_ref_1.Size = new System.Drawing.Size(515, 78);
			this.txt_ref_1.TabIndex = 28;
			this.txt_ref_1.Text = "";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ActiveCaptionText;
			this.label2.Location = new Point(3, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Reference one and adress";
			this.panel9.BackColor = Color.FromArgb(255, 192, 128);
			this.panel9.BorderStyle = BorderStyle.Fixed3D;
			this.panel9.Controls.Add(this.picBoxImage);
			this.panel9.Location = new Point(497, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(155, 143);
			this.panel9.TabIndex = 40;
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
			this.panel2.Size = new System.Drawing.Size(493, 100);
			this.panel2.TabIndex = 39;
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
			base.ClientSize = new System.Drawing.Size(656, 532);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_referees";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "GUARD REFEREES";
			base.Load += new EventHandler(this.frm_referees_Load);
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
				this.txt_ref_1.Text = (dtRow["reference1_name"] != DBNull.Value ? (string)dtRow["reference1_name"] : string.Empty);
				this.txt_ref_2.Text = (dtRow["reference2_name"] != DBNull.Value ? (string)dtRow["reference2_name"] : string.Empty);
				this.txt_ref_3.Text = (dtRow["reference3_name"] != DBNull.Value ? (string)dtRow["reference3_name"] : string.Empty);
				this.panel_details.Enabled = false;
			}
		}
	}
}