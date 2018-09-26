using Guard_profiler.App_code;
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
	public class frm_pre_login : Form
	{
		private IContainer components;

		internal TextBox txtpass;

		internal TextBox txtuser;

		internal Label Label3;

		internal Label Label2;

		internal Button btnLogin;

		private Label label1;

		private Panel panel1;

		private Panel panel_guard_number;

		private ComboBox cbo_branch;

		private Label label4;

		private Label label5;

		internal TextBox txt_guard_number_current;

		private GroupBox groupBox1;

		private Label label49;

		private Label label48;

		private Label label47;

		private TextBox txt_guard_number_complete;

		private TextBox txt_guard_number_static_code;

		private TextBox txt_guard_number_auto_code;

		private Button btn_update_guard_number;

		private Label lbl_guid;

		public frm_pre_login()
		{
			this.InitializeComponent();
		}

		private void btn_update_guard_number_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number_static_code.Text == string.Empty || this.txt_guard_number_complete.Text == string.Empty)
			{
				MessageBox.Show("Type in the correct new guard number to update", "Update Guard Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure you want to change this guard number??", "Change guard number", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != System.Windows.Forms.DialogResult.Yes)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
				}
				return;
			}
			sg_Profiles.CHANGE_GUARD_NUMBER("CHANGE_GUARD_NUMBER", this.lbl_guid.Text, this.txt_guard_number_complete.Text);
			MessageBox.Show("Guard Number has been successfully updated", "Update Guard Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			this.LOGIN_USER();
		}

		private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_branch.Text == string.Empty)
			{
				this.txt_guard_number_auto_code.Clear();
				return;
			}
			this.txt_guard_number_auto_code.Text = this.cbo_branch.SelectedValue.ToString();
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

		private void frm_pre_login_Load(object sender, EventArgs e)
		{
			this.panel_guard_number.Visible = false;
			this.GET_BRANCHES();
			this.cbo_branch.Text = SystemConst._branch_name;
			this.txt_guard_number_current.Text = SystemConst.guard_number;
			this.lbl_guid.Text = SystemConst.record_guid;
			this.cbo_branch_SelectedIndexChanged(this.cbo_branch, null);
		}

		protected void GET_BRANCHES()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["auto_id"] = -1;
				dtRow["branch"] = string.Empty;
				dtRow["active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_branch.DataSource = dt;
				this.cbo_branch.DisplayMember = "branch";
				this.cbo_branch.ValueMember = "branch_code";
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_pre_login));
			this.txtpass = new TextBox();
			this.txtuser = new TextBox();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.btnLogin = new Button();
			this.label1 = new Label();
			this.panel1 = new Panel();
			this.panel_guard_number = new Panel();
			this.groupBox1 = new GroupBox();
			this.btn_update_guard_number = new Button();
			this.label49 = new Label();
			this.label48 = new Label();
			this.label47 = new Label();
			this.txt_guard_number_complete = new TextBox();
			this.txt_guard_number_static_code = new TextBox();
			this.txt_guard_number_auto_code = new TextBox();
			this.txt_guard_number_current = new TextBox();
			this.label5 = new Label();
			this.cbo_branch = new ComboBox();
			this.label4 = new Label();
			this.lbl_guid = new Label();
			this.panel1.SuspendLayout();
			this.panel_guard_number.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtpass.Location = new Point(101, 45);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(177, 26);
			this.txtpass.TabIndex = 9;
			this.txtuser.AutoCompleteCustomSource.AddRange(new string[] { "thadeous", "tash", "lourence" });
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txtuser.Location = new Point(101, 3);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(177, 26);
			this.txtuser.TabIndex = 8;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label3.Location = new Point(12, 48);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(79, 20);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Passcode";
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.Label2.Location = new Point(12, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(83, 20);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Username";
			this.btnLogin.BackColor = Color.FromArgb(224, 224, 224);
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnLogin.ForeColor = Color.Blue;
			this.btnLogin.Location = new Point(197, 77);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(81, 31);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "Confirm";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 255, 128);
			this.label1.Location = new Point(114, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Login to Change Guard Number";
			this.panel1.Controls.Add(this.txtuser);
			this.panel1.Controls.Add(this.Label2);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.Label3);
			this.panel1.Controls.Add(this.txtpass);
			this.panel1.Location = new Point(2, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 114);
			this.panel1.TabIndex = 12;
			this.panel_guard_number.Controls.Add(this.groupBox1);
			this.panel_guard_number.Controls.Add(this.txt_guard_number_current);
			this.panel_guard_number.Controls.Add(this.label5);
			this.panel_guard_number.Controls.Add(this.cbo_branch);
			this.panel_guard_number.Controls.Add(this.label4);
			this.panel_guard_number.Location = new Point(2, 162);
			this.panel_guard_number.Name = "panel_guard_number";
			this.panel_guard_number.Size = new System.Drawing.Size(571, 192);
			this.panel_guard_number.TabIndex = 13;
			this.groupBox1.Controls.Add(this.btn_update_guard_number);
			this.groupBox1.Controls.Add(this.label49);
			this.groupBox1.Controls.Add(this.label48);
			this.groupBox1.Controls.Add(this.label47);
			this.groupBox1.Controls.Add(this.txt_guard_number_complete);
			this.groupBox1.Controls.Add(this.txt_guard_number_static_code);
			this.groupBox1.Controls.Add(this.txt_guard_number_auto_code);
			this.groupBox1.ForeColor = Color.Blue;
			this.groupBox1.Location = new Point(13, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(413, 115);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Guard Number Details";
			this.btn_update_guard_number.ForeColor = Color.Red;
			this.btn_update_guard_number.Location = new Point(212, 80);
			this.btn_update_guard_number.Name = "btn_update_guard_number";
			this.btn_update_guard_number.Size = new System.Drawing.Size(140, 29);
			this.btn_update_guard_number.TabIndex = 73;
			this.btn_update_guard_number.Text = "Update Guard Number";
			this.btn_update_guard_number.UseVisualStyleBackColor = true;
			this.btn_update_guard_number.Click += new EventHandler(this.btn_update_guard_number_Click);
			this.label49.AutoSize = true;
			this.label49.BackColor = Color.Yellow;
			this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label49.Location = new Point(86, 29);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(65, 16);
			this.label49.TabIndex = 72;
			this.label49.Text = "Assigned";
			this.label48.AutoSize = true;
			this.label48.BackColor = Color.Yellow;
			this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label48.Location = new Point(195, 29);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(123, 16);
			this.label48.TabIndex = 71;
			this.label48.Text = "New Guard number";
			this.label47.AutoSize = true;
			this.label47.BackColor = Color.Yellow;
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label47.Location = new Point(12, 27);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(35, 16);
			this.label47.TabIndex = 70;
			this.label47.Text = "Auto";
			this.txt_guard_number_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number_complete.Location = new Point(195, 45);
			this.txt_guard_number_complete.Name = "txt_guard_number_complete";
			this.txt_guard_number_complete.ReadOnly = true;
			this.txt_guard_number_complete.Size = new System.Drawing.Size(157, 29);
			this.txt_guard_number_complete.TabIndex = 69;
			this.txt_guard_number_static_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number_static_code.Location = new Point(89, 45);
			this.txt_guard_number_static_code.Name = "txt_guard_number_static_code";
			this.txt_guard_number_static_code.Size = new System.Drawing.Size(100, 29);
			this.txt_guard_number_static_code.TabIndex = 68;
			this.txt_guard_number_static_code.TextChanged += new EventHandler(this.txt_guard_number_static_code_TextChanged);
			this.txt_guard_number_auto_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number_auto_code.Location = new Point(15, 45);
			this.txt_guard_number_auto_code.Name = "txt_guard_number_auto_code";
			this.txt_guard_number_auto_code.ReadOnly = true;
			this.txt_guard_number_auto_code.Size = new System.Drawing.Size(71, 29);
			this.txt_guard_number_auto_code.TabIndex = 67;
			this.txt_guard_number_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_guard_number_current.Location = new Point(249, 33);
			this.txt_guard_number_current.Name = "txt_guard_number_current";
			this.txt_guard_number_current.ReadOnly = true;
			this.txt_guard_number_current.Size = new System.Drawing.Size(177, 26);
			this.txt_guard_number_current.TabIndex = 11;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ActiveCaptionText;
			this.label5.Location = new Point(246, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Current Guard Number";
			this.cbo_branch.Enabled = false;
			this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_branch.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbo_branch.Items;
			object[] objArray = new object[] { "", "Kampala", "Mbale", "Entebbe", "Lira", "Hoima" };
//			items.AddRange(objArray);
			this.cbo_branch.Location = new Point(13, 33);
			this.cbo_branch.Name = "cbo_branch";
			this.cbo_branch.Size = new System.Drawing.Size(227, 26);
			this.cbo_branch.TabIndex = 9;
			this.cbo_branch.SelectedIndexChanged += new EventHandler(this.cbo_branch_SelectedIndexChanged);
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ActiveCaptionText;
			this.label4.Location = new Point(10, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Branch";
			this.lbl_guid.AutoSize = true;
			this.lbl_guid.BackColor = Color.Yellow;
			this.lbl_guid.Location = new Point(264, 367);
			this.lbl_guid.Name = "lbl_guid";
			this.lbl_guid.Size = new System.Drawing.Size(43, 13);
			this.lbl_guid.TabIndex = 14;
			this.lbl_guid.Text = "lbl_guid";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(575, 380);
			base.Controls.Add(this.lbl_guid);
			base.Controls.Add(this.panel_guard_number);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_pre_login";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Change Guard Number";
			base.Load += new EventHandler(this.frm_pre_login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel_guard_number.ResumeLayout(false);
			this.panel_guard_number.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		protected void LOGIN_USER()
		{
			if (this.txtuser.Text == string.Empty || this.txtpass.Text == string.Empty)
			{
				MessageBox.Show("Username or Password cannot be empty");
				return;
			}
			if (Convert.ToInt32(Users.LOGIN_USER("LOGIN_USER", this.txtuser.Text, this.Encrypt(this.txtpass.Text)).Rows[0]["user_id"]) != 1)
			{
				MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			this.panel_guard_number.Visible = true;
			this.txtuser.Clear();
			this.txtpass.Clear();
		}

		private void txt_guard_number_static_code_TextChanged(object sender, EventArgs e)
		{
			if (!(this.txt_guard_number_auto_code.Text != string.Empty) || !(this.txt_guard_number_static_code.Text != string.Empty))
			{
				this.txt_guard_number_complete.Clear();
				return;
			}
			this.txt_guard_number_complete.Text = string.Concat(this.txt_guard_number_auto_code.Text, this.txt_guard_number_static_code.Text);
		}
	}
}