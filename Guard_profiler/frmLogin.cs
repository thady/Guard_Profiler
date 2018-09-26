using Guard_profiler.App_code;
using Guard_profiler.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frmLogin : Form
	{
		private IContainer components;

		internal GroupBox GroupBox1;

		internal GroupBox GroupBox12;

		internal PictureBox lognpxt;

		internal TextBox txtpass;

		internal TextBox txtuser;

		internal Label Label3;

		internal Label Label2;

		internal Button btnLogin;

		internal Button btnClose;

		private Panel panel1;

		public frmLogin()
		{
			this.InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Application will exit,proceed??", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				base.Close();
				Application.Exit();
				return;
			}
			if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				base.Visible = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.LOGIN_USER();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private string Encrypt(string clearText)
		{
			string EncryptionKey = "MAKV2SPBNI99212";
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118 });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(clearBytes, 0, (int)clearBytes.Length);
						cs.Close();
					}
					clearText = Convert.ToBase64String(ms.ToArray());
				}
			}
			return clearText;
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frmLogin));
			this.GroupBox1 = new GroupBox();
			this.GroupBox12 = new GroupBox();
			this.lognpxt = new PictureBox();
			this.txtpass = new TextBox();
			this.txtuser = new TextBox();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.btnClose = new Button();
			this.btnLogin = new Button();
			this.panel1 = new Panel();
			this.GroupBox1.SuspendLayout();
			this.GroupBox12.SuspendLayout();
			((ISupportInitialize)this.lognpxt).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.BackColor = Color.LightSteelBlue;
			this.GroupBox1.Controls.Add(this.GroupBox12);
			this.GroupBox1.Controls.Add(this.txtpass);
			this.GroupBox1.Controls.Add(this.txtuser);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Location = new Point(4, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(384, 175);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox12.BackColor = SystemColors.InactiveCaption;
			this.GroupBox12.Controls.Add(this.lognpxt);
			this.GroupBox12.Location = new Point(6, 19);
			this.GroupBox12.Name = "GroupBox12";
			this.GroupBox12.Size = new System.Drawing.Size(142, 128);
			this.GroupBox12.TabIndex = 40;
			this.GroupBox12.TabStop = false;
			this.lognpxt.BackColor = SystemColors.InactiveBorder;
			this.lognpxt.Cursor = Cursors.WaitCursor;
			this.lognpxt.Image = Resources.loginimg1;
			this.lognpxt.Location = new Point(6, 19);
			this.lognpxt.Name = "lognpxt";
			this.lognpxt.Size = new System.Drawing.Size(130, 103);
			this.lognpxt.SizeMode = PictureBoxSizeMode.StretchImage;
			this.lognpxt.TabIndex = 0;
			this.lognpxt.TabStop = false;
			this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtpass.Location = new Point(158, 113);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(206, 26);
			this.txtpass.TabIndex = 5;
			this.txtuser.AutoCompleteCustomSource.AddRange(new string[] { "thadeous", "tash", "lourence" });
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtuser.Location = new Point(158, 61);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(206, 26);
			this.txtuser.TabIndex = 4;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label3.Location = new Point(154, 90);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(79, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Passcode";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label2.Location = new Point(154, 38);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(83, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Username";
			this.btnClose.BackColor = Color.FromArgb(255, 192, 192);
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnClose.ForeColor = Color.Blue;
			this.btnClose.Location = new Point(86, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(98, 30);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Exit";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new EventHandler(this.btnClose_Click);
			this.btnLogin.BackColor = Color.FromArgb(128, 255, 255);
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnLogin.ForeColor = Color.Blue;
			this.btnLogin.Location = new Point(190, 3);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(104, 30);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
			this.panel1.BackColor = Color.DarkGray;
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Location = new Point(4, 185);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 37);
			this.panel1.TabIndex = 5;
			base.AcceptButton = this.btnLogin;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 192, 128);
			base.ClientSize = new System.Drawing.Size(390, 223);
			base.ControlBox = false;
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.GroupBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frmLogin";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			base.Load += new EventHandler(this.frmLogin_Load);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox12.ResumeLayout(false);
			((ISupportInitialize)this.lognpxt).EndInit();
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		protected void LOGIN_USER()
		{
			if (this.txtuser.Text == string.Empty || this.txtpass.Text == string.Empty)
			{
				MessageBox.Show("Username or Password cannot be empty");
				return;
			}
			DataTable dt = Users.LOGIN_USER("LOGIN_USER", this.txtuser.Text, this.Encrypt(this.txtpass.Text));
			if (dt.Rows.Count <= 0)
			{
				MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			DataRow dtRow = dt.Rows[0];
			int user_count = Convert.ToInt32(dtRow["user_id"]);
			string user_department = dtRow["user_department"].ToString();
			bool is_admin = (bool)dtRow["is_admin"];
			if (user_count <= 0)
			{
				MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			base.Visible = false;
			SystemConst._username = this.txtuser.Text;
			SystemConst._user_department = user_department;
			SystemConst.is_admin = is_admin;
		}
	}
}