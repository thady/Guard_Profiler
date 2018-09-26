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
	public class frm_officer_img_large : Form
	{
		private IContainer components;

		private Panel panel1;

		private Label lbl_guid;

		private Panel panel2;

		private Panel panel3;

		private Button btnSave;

		private Button btnBrowse;

		private Button button1;

		private Panel panel4;

		private TextBox txt_forceNumber;

		private Label label2;

		private TextBox txt_name;

		private Label label1;

		private OpenFileDialog ImageDialog;

		private PictureBox picBoxImage;

		public frm_officer_img_large()
		{
			this.InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Image";
				dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
				if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					this.picBoxImage.Image = new Bitmap(dlg.FileName);
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.picBoxImage.Image == null)
			{
				MessageBox.Show("No Image selected");
				return;
			}
			try
			{
				Image img = this.picBoxImage.Image;
				byte[] arr = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
				HeadShotEngine.INSERT_OR_UPDATE_IMAGE("UPDATE_GUARD_IMAGE_LARGE", this.lbl_guid.Text, arr);
				MessageBox.Show("Update Successfull");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
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

		private void frm_officer_img_large_Load(object sender, EventArgs e)
		{
			this.txt_forceNumber.Text = SystemConst.OfficerID;
			this.txt_name.Text = SystemConst.OfficerName;
			this.lbl_guid.Text = SystemConst.record_guid;
			this.GET_OFFICER_HEADSHOT("SELECT_OFFICER_IMAGE_LARGE", this.lbl_guid.Text);
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
				if (dtRow["image_data_large"] != DBNull.Value)
				{
					MemoryStream stream = new MemoryStream((byte[])dtRow["image_data_large"]);
					this.picBoxImage.Image = Image.FromStream(stream);
					return;
				}
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_officer_img_large));
			this.panel1 = new Panel();
			this.lbl_guid = new Label();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.btnSave = new Button();
			this.btnBrowse = new Button();
			this.button1 = new Button();
			this.panel4 = new Panel();
			this.txt_forceNumber = new TextBox();
			this.label2 = new Label();
			this.txt_name = new TextBox();
			this.label1 = new Label();
			this.ImageDialog = new OpenFileDialog();
			this.picBoxImage = new PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.picBoxImage).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.lbl_guid);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(809, 568);
			this.panel1.TabIndex = 1;
			this.lbl_guid.AutoSize = true;
			this.lbl_guid.BackColor = Color.Yellow;
			this.lbl_guid.Location = new Point(8, 549);
			this.lbl_guid.Name = "lbl_guid";
			this.lbl_guid.Size = new System.Drawing.Size(43, 13);
			this.lbl_guid.TabIndex = 6;
			this.lbl_guid.Text = "lbl_guid";
			this.panel2.BackColor = Color.Yellow;
			this.panel2.Controls.Add(this.picBoxImage);
			this.panel2.Location = new Point(232, 130);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(404, 334);
			this.panel2.TabIndex = 3;
			this.panel3.BackColor = SystemColors.ButtonFace;
			this.panel3.Controls.Add(this.btnSave);
			this.panel3.Controls.Add(this.btnBrowse);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Location = new Point(230, 470);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(406, 68);
			this.panel3.TabIndex = 4;
			this.btnSave.Location = new Point(291, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(109, 62);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "SAVE IMAGE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new EventHandler(this.btnSave_Click);
			this.btnBrowse.Location = new Point(133, 3);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(152, 62);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "BROWSE FROM FILE";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
			this.button1.Location = new Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 62);
			this.button1.TabIndex = 0;
			this.button1.Text = "CAPTURE FROM CAMERA";
			this.button1.UseVisualStyleBackColor = true;
			this.panel4.BackColor = Color.GhostWhite;
			this.panel4.BorderStyle = BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.txt_forceNumber);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt_name);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Enabled = false;
			this.panel4.Location = new Point(231, 21);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(404, 100);
			this.panel4.TabIndex = 5;
			this.txt_forceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_forceNumber.Location = new Point(108, 54);
			this.txt_forceNumber.Name = "txt_forceNumber";
			this.txt_forceNumber.Size = new System.Drawing.Size(289, 24);
			this.txt_forceNumber.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(3, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Guard Number";
			this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_name.Location = new Point(108, 18);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(289, 24);
			this.txt_name.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(54, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.ImageDialog.FileName = "openFileDialog1";
			this.picBoxImage.BackColor = Color.White;
			this.picBoxImage.Location = new Point(3, 3);
			this.picBoxImage.Name = "picBoxImage";
			this.picBoxImage.Size = new System.Drawing.Size(397, 328);
			this.picBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picBoxImage.TabIndex = 0;
			this.picBoxImage.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 192, 128);
			base.ClientSize = new System.Drawing.Size(814, 575);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_officer_img_large";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Attach Large Photo to Officer Record";
			base.Load += new EventHandler(this.frm_officer_img_large_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((ISupportInitialize)this.picBoxImage).EndInit();
			base.ResumeLayout(false);
		}
	}
}