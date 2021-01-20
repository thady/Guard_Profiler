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

        protected void Set_current_deployment_periods()
        {
            DataTable dt = Guard_deployment.select_my_active_deployment_period("select_my_active_deployment_period", SystemConst._user_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];
                int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
                SystemConst._active_deployment_id = num.ToString();
                SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
                SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
            }
            else
            {
                SystemConst._active_deployment_id = string.Empty;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.lognpxt = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lognpxt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GroupBox1.Controls.Add(this.GroupBox12);
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.txtuser);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(520, 204);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox12
            // 
            this.GroupBox12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GroupBox12.Controls.Add(this.lognpxt);
            this.GroupBox12.Location = new System.Drawing.Point(6, 19);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(142, 128);
            this.GroupBox12.TabIndex = 40;
            this.GroupBox12.TabStop = false;
            // 
            // lognpxt
            // 
            this.lognpxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lognpxt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lognpxt.Image = global::Guard_profiler.Properties.Resources.loginimg1;
            this.lognpxt.Location = new System.Drawing.Point(6, 19);
            this.lognpxt.Name = "lognpxt";
            this.lognpxt.Size = new System.Drawing.Size(130, 103);
            this.lognpxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lognpxt.TabIndex = 0;
            this.lognpxt.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(158, 113);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(206, 26);
            this.txtpass.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteCustomSource.AddRange(new string[] {
            "thadeous",
            "tash",
            "lourence"});
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(158, 61);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(206, 26);
            this.txtuser.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(154, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Passcode";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(154, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Username";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(86, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(190, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(-2, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 65);
            this.panel1.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(526, 275);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lognpxt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
            string user_id = dtRow["auto_id"].ToString();
            string name = dtRow["name"].ToString();
            bool is_admin = (bool)dtRow["is_admin"];
			if (user_count <= 0)
			{
				MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			base.Visible = false;
			SystemConst._username = this.txtuser.Text;
            SystemConst._name = name;
            SystemConst._user_department = user_department;
            SystemConst._user_id = user_id;
            SystemConst.is_admin = is_admin;

            if (user_department != "NSSF")
            {
                Set_current_deployment_periods();
            }

        }
	}
}