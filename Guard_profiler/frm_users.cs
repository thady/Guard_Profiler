using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
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
	public class frm_users : Form
	{
		private IContainer components;

		//private ReSize reSize1;

		private Panel panel1;

		private Panel panel4;

		private RichTextBox txt_user_id;

		private Panel panel10;

		private Button btnNew;

		private Button btnedit;

		private Button btnsave;

		private Panel panel3;

		private ComboBox cbo_gender;

		private Label label5;

		private CheckBox chk_active;

		private CheckBox chk_admin;

		private TextBox txt_password2;

		private Label label4;

		private TextBox txt_password;

		private Label label3;

		private TextBox txt_username;

		private Label label1;

		private TextBox txt_name;

		private Label label2;

		private Panel panel2;

		private DataGridView gdv_users;

		private Label label6;

		private ComboBox cbo_department;

		public frm_users()
		{
			this.InitializeComponent();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.panel3.Enabled = true;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			this.Clear();
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.txt_user_id.Text == string.Empty)
			{
				this.SAVE_NEW_USER_DETAILS();
				return;
			}
			Users.UPDATE_USER_DETAILS("UPDATE_USER_DETAILS", this.txt_name.Text, this.cbo_gender.Text, (this.chk_admin.Checked ? true : false), (this.chk_active.Checked ? true : false), this.cbo_department.Text, Convert.ToInt32(this.txt_user_id.Text));
			MessageBox.Show("Successfully updated user details");
		}

		protected void Clear()
		{
			this.txt_name.Clear();
			this.txt_password.Clear();
			this.txt_user_id.Clear();
			this.txt_username.Clear();
			this.cbo_gender.Text = string.Empty;
			this.chk_active.Checked = true;
			this.chk_admin.Checked = false;
			this.panel3.Enabled = true;
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

		private void frm_users_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.GET_DEPARTMENTS();
			this.SELECT_USER_LIST();
		}

		private void gdv_users_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_users.Rows.Count != 0)
			{
				int user_id = Convert.ToInt32(this.gdv_users.CurrentRow.Cells[0].Value.ToString());
				DataTable dt = Users.SELECT_USER_DETAILS("SELECT_USER_DETAILS", user_id);
				if (dt.Rows.Count != 0)
				{
					DataRow dtRow = dt.Rows[0];
					this.txt_name.Text = (dtRow["name"] != DBNull.Value ? (string)dtRow["name"] : string.Empty);
					this.cbo_gender.Text = (dtRow["gender"] != DBNull.Value ? (string)dtRow["gender"] : string.Empty);
					this.txt_username.Text = (dtRow["user_name"] != DBNull.Value ? (string)dtRow["user_name"] : string.Empty);
					this.chk_admin.Checked = (bool)dtRow["is_admin"];
					this.chk_active.Checked = (bool)dtRow["user_active"];
					this.cbo_department.Text = (dtRow["user_department"] != DBNull.Value ? (string)dtRow["user_department"] : string.Empty);
					this.txt_user_id.Text = user_id.ToString();
					this.panel3.Enabled = false;
				}
			}
		}

		protected void GET_DEPARTMENTS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_DEPARTMENTS");
			if (dt != null)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["department_name"] = string.Empty;
				dtRow["auto_id"] = -99;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_department.DisplayMember = "department_name";
				this.cbo_department.ValueMember = "auto_id";
				this.cbo_department.DataSource = dt;
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_users));
			//this.reSize1 = new ReSize(this.components);
			this.panel2 = new Panel();
			this.gdv_users = new DataGridView();
			this.cbo_gender = new ComboBox();
			this.label5 = new Label();
			this.chk_active = new CheckBox();
			this.panel3 = new Panel();
			this.cbo_department = new ComboBox();
			this.label6 = new Label();
			this.chk_admin = new CheckBox();
			this.txt_password2 = new TextBox();
			this.label4 = new Label();
			this.txt_password = new TextBox();
			this.label3 = new Label();
			this.txt_username = new TextBox();
			this.label1 = new Label();
			this.txt_name = new TextBox();
			this.label2 = new Label();
			this.btnNew = new Button();
			this.btnedit = new Button();
			this.panel10 = new Panel();
			this.btnsave = new Button();
			this.txt_user_id = new RichTextBox();
			this.panel4 = new Panel();
			this.panel1 = new Panel();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.gdv_users).BeginInit();
			this.panel3.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			//this.reSize1.About = null;
			//this.reSize1.AutoCenterFormOnLoad = false;
			//this.reSize1.Enabled = true;
			//this.reSize1.HostContainer = this;
			//this.reSize1.InitialHostContainerHeight = 509;
			//this.reSize1.InitialHostContainerWidth = 878;
			//this.reSize1.Tag = null;
			this.panel2.BorderStyle = BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.gdv_users);
			this.panel2.Location = new Point(392, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(469, 414);
			this.panel2.TabIndex = 0;
			this.gdv_users.AllowUserToAddRows = false;
			this.gdv_users.AllowUserToDeleteRows = false;
			this.gdv_users.AllowUserToResizeColumns = false;
			this.gdv_users.AllowUserToResizeRows = false;
			this.gdv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_users.Location = new Point(3, 3);
			this.gdv_users.Name = "gdv_users";
			this.gdv_users.ReadOnly = true;
			this.gdv_users.Size = new System.Drawing.Size(459, 404);
			this.gdv_users.TabIndex = 2;
			this.gdv_users.CellClick += new DataGridViewCellEventHandler(this.gdv_users_CellClick);
			this.cbo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_gender.FormattingEnabled = true;
			this.cbo_gender.Items.AddRange(new object[] { "", "Male", "Female" });
			this.cbo_gender.Location = new Point(6, 67);
			this.cbo_gender.Name = "cbo_gender";
			this.cbo_gender.Size = new System.Drawing.Size(180, 26);
			this.cbo_gender.TabIndex = 32;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.Red;
			this.label5.Location = new Point(3, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 16);
			this.label5.TabIndex = 31;
			this.label5.Text = "Gender";
			this.chk_active.AutoSize = true;
			this.chk_active.Checked = true;
			this.chk_active.CheckState = CheckState.Checked;
			this.chk_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_active.Location = new Point(6, 306);
			this.chk_active.Name = "chk_active";
			this.chk_active.Size = new System.Drawing.Size(163, 20);
			this.chk_active.TabIndex = 30;
			this.chk_active.Text = " User Account is Active";
			this.chk_active.UseVisualStyleBackColor = true;
			this.panel3.BorderStyle = BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.cbo_department);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.cbo_gender);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.chk_active);
			this.panel3.Controls.Add(this.chk_admin);
			this.panel3.Controls.Add(this.txt_password2);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txt_password);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txt_username);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txt_name);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new Point(7, 73);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(379, 355);
			this.panel3.TabIndex = 1;
			this.cbo_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cbo_department.FormattingEnabled = true;
			this.cbo_department.Location = new Point(6, 110);
			this.cbo_department.Name = "cbo_department";
			this.cbo_department.Size = new System.Drawing.Size(180, 26);
			this.cbo_department.TabIndex = 34;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.Red;
			this.label6.Location = new Point(3, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 16);
			this.label6.TabIndex = 33;
			this.label6.Text = "Department";
			this.chk_admin.AutoSize = true;
			this.chk_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.chk_admin.Location = new Point(6, 280);
			this.chk_admin.Name = "chk_admin";
			this.chk_admin.Size = new System.Drawing.Size(196, 20);
			this.chk_admin.TabIndex = 29;
			this.chk_admin.Text = "User is system Administrator";
			this.chk_admin.UseVisualStyleBackColor = true;
			this.txt_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_password2.Location = new Point(6, 250);
			this.txt_password2.Name = "txt_password2";
			this.txt_password2.PasswordChar = '*';
			this.txt_password2.Size = new System.Drawing.Size(334, 24);
			this.txt_password2.TabIndex = 28;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Red;
			this.label4.Location = new Point(6, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 16);
			this.label4.TabIndex = 27;
			this.label4.Text = "Re-type password";
			this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_password.Location = new Point(6, 204);
			this.txt_password.Name = "txt_password";
			this.txt_password.PasswordChar = '*';
			this.txt_password.Size = new System.Drawing.Size(334, 24);
			this.txt_password.TabIndex = 26;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Red;
			this.label3.Location = new Point(3, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 25;
			this.label3.Text = "Password";
			this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_username.Location = new Point(6, 158);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(334, 24);
			this.txt_username.TabIndex = 24;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Red;
			this.label1.Location = new Point(3, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "Username";
			this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_name.Location = new Point(6, 24);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(334, 24);
			this.txt_name.TabIndex = 22;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(3, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Name";
			this.btnNew.Location = new Point(3, 3);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(88, 37);
			this.btnNew.TabIndex = 2;
			this.btnNew.Text = "New User";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new EventHandler(this.btnNew_Click);
			this.btnedit.Location = new Point(92, 3);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(88, 37);
			this.btnedit.TabIndex = 1;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btnedit.Click += new EventHandler(this.btnedit_Click);
			this.panel10.BackColor = Color.FromArgb(192, 192, 255);
			this.panel10.Controls.Add(this.btnNew);
			this.panel10.Controls.Add(this.btnedit);
			this.panel10.Controls.Add(this.btnsave);
			this.panel10.Location = new Point(66, 434);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(320, 43);
			this.panel10.TabIndex = 31;
			this.btnsave.Location = new Point(180, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(131, 37);
			this.btnsave.TabIndex = 0;
			this.btnsave.Text = "Save User Details";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.txt_user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_user_id.Location = new Point(3, 3);
			this.txt_user_id.Name = "txt_user_id";
			this.txt_user_id.Size = new System.Drawing.Size(214, 52);
			this.txt_user_id.TabIndex = 0;
			this.txt_user_id.Text = "";
			this.panel4.Controls.Add(this.txt_user_id);
			this.panel4.Enabled = false;
			this.panel4.Location = new Point(7, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(379, 64);
			this.panel4.TabIndex = 32;
			this.panel1.BackColor = Color.Azure;
			this.panel1.BorderStyle = BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(3, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(872, 494);
			this.panel1.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(878, 509);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_users";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "MANAGE USERS";
			base.Load += new EventHandler(this.frm_users_Load);
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.gdv_users).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		protected void SAVE_NEW_USER_DETAILS()
		{
			if (this.txt_name.Text == string.Empty || this.txt_username.Text == string.Empty || this.txt_password.Text == string.Empty || this.txt_password2.Text == string.Empty || this.cbo_gender.Text == string.Empty)
			{
				MessageBox.Show("All fields marked red are mandatory");
				return;
			}
			if (this.txt_password.Text != this.txt_password2.Text)
			{
				MessageBox.Show("Password Fields must match");
				return;
			}
			Users.NEW_USER_PROFILE("NEW_USER_PROFILE", this.txt_name.Text, this.cbo_gender.Text, this.txt_username.Text, this.Encrypt(this.txt_password.Text), (this.chk_admin.Checked ? true : false), (this.chk_active.Checked ? true : false), this.cbo_department.Text);
			MessageBox.Show("User added successfully");
		}

		protected void SELECT_USER_LIST()
		{
			DataTable dt = Users.SELECT_USER_LIST("SELECT_USER_LIST");
			if (dt != null && dt.Rows.Count != 0)
			{
				this.gdv_users.DataSource = dt;
				int count = dt.Rows.Count;
				this.gdv_users.Columns[0].Visible = false;
				this.gdv_users.Columns[1].HeaderText = "Name";
				this.gdv_users.Columns[2].HeaderText = "Gender";
				this.gdv_users.Columns[3].HeaderText = "Admin?";
				this.gdv_users.Columns[4].HeaderText = "Active?";
				this.gdv_users.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_users.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_users.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_users.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_users.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_users.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_users.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_users.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_users.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}
	}
}