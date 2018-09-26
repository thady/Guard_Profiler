using Guard_profiler.App_code;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_manage_clients : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private DataGridView gdv_clients;

		private Panel panel_details;

		private Panel panel4;

		private Label label1;

		private Label label2;

		private Label label6;

		private TextBox txt_client_name;

		private Label label3;

		private Label label4;

		private TextBox txt_client_code;

		private TextBox txt_adress;

		private Label label5;

		private TextBox txt_client_rate;

		private CheckBox chk_client_active;

		private Button btnedit;

		private Button btnsave;

		private TextBox txt_record_guid;

		private Panel panel5;

		private Button btnnew;

		private Panel panel3;

		private Button btn_locations;

		private Label label7;

		private TextBox txt_client_id;

		public frm_manage_clients()
		{
			this.InitializeComponent();
		}

		private void btn_locations_Click(object sender, EventArgs e)
		{
			if (this.txt_record_guid.Text == string.Empty)
			{
				MessageBox.Show("Please select a client", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SystemConst._client_name = this.txt_client_name.Text;
			SystemConst._client_code = this.txt_client_code.Text;
			(new frm_manage_client_locations()).ShowDialog();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.panel_details.Enabled = true;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_adress.Clear();
			this.txt_client_code.Clear();
			this.txt_client_name.Clear();
			this.txt_client_rate.Clear();
			this.chk_client_active.Checked = true;
			this.txt_record_guid.Clear();
			this.txt_client_id.Clear();
			this.panel_details.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			this.Save_client_details();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_manage_clients_Load(object sender, EventArgs e)
		{
			this.Return_list_of_clients();
		}

		private void gdv_clients_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string empty;
			if (this.gdv_clients.Rows.Count > 0)
			{
				int client_id = Convert.ToInt32(this.gdv_clients.CurrentRow.Cells[1].Value.ToString());
				SystemConst._client_id = client_id.ToString();
				DataTable dt = Clients.Return_client_details("return_client_details", client_id);
				if (dt.Rows.Count > 0)
				{
					DataRow dtRow = dt.Rows[0];
					this.txt_adress.Text = dtRow["client_adress"].ToString();
					this.txt_client_code.Text = dtRow["client_code"].ToString();
					this.txt_client_name.Text = dtRow["client_name"].ToString();
					TextBox txtClientRate = this.txt_client_rate;
					if (float.Parse(dtRow["client_rate"].ToString()) == 0f)
					{
						empty = string.Empty;
					}
					else
					{
						float single = float.Parse(dtRow["client_rate"].ToString());
						empty = single.ToString();
					}
					txtClientRate.Text = empty;
					this.chk_client_active.Checked = (Convert.ToBoolean(dtRow["client_active"]) ? true : false);
					this.txt_record_guid.Text = dtRow["record_guid"].ToString();
					TextBox txtClientId = this.txt_client_id;
					int num = Convert.ToInt32(dtRow["client_id"].ToString());
					txtClientId.Text = num.ToString();
					this.panel_details.Enabled = false;
				}
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_manage_clients));
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.gdv_clients = new DataGridView();
			this.panel_details = new Panel();
			this.panel4 = new Panel();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label6 = new Label();
			this.txt_client_name = new TextBox();
			this.label3 = new Label();
			this.txt_client_code = new TextBox();
			this.label4 = new Label();
			this.txt_adress = new TextBox();
			this.label5 = new Label();
			this.txt_client_rate = new TextBox();
			this.chk_client_active = new CheckBox();
			this.btnsave = new Button();
			this.btnedit = new Button();
			this.txt_record_guid = new TextBox();
			this.panel5 = new Panel();
			this.btnnew = new Button();
			this.panel3 = new Panel();
			this.btn_locations = new Button();
			this.label7 = new Label();
			this.txt_client_id = new TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.gdv_clients).BeginInit();
			this.panel_details.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.txt_record_guid);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel_details);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(837, 520);
			this.panel1.TabIndex = 0;
			this.panel2.BackColor = Color.FromArgb(192, 255, 255);
			this.panel2.Controls.Add(this.gdv_clients);
			this.panel2.Location = new Point(3, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(831, 384);
			this.panel2.TabIndex = 0;
			this.gdv_clients.AllowUserToAddRows = false;
			this.gdv_clients.AllowUserToDeleteRows = false;
			this.gdv_clients.AllowUserToResizeColumns = false;
			this.gdv_clients.AllowUserToResizeRows = false;
			this.gdv_clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_clients.Location = new Point(3, 3);
			this.gdv_clients.Name = "gdv_clients";
			this.gdv_clients.ReadOnly = true;
			this.gdv_clients.Size = new System.Drawing.Size(825, 378);
			this.gdv_clients.TabIndex = 0;
			this.gdv_clients.CellClick += new DataGridViewCellEventHandler(this.gdv_clients_CellClick);
			this.panel_details.BackColor = Color.Silver;
			this.panel_details.Controls.Add(this.txt_client_id);
			this.panel_details.Controls.Add(this.label7);
			this.panel_details.Controls.Add(this.chk_client_active);
			this.panel_details.Controls.Add(this.txt_client_rate);
			this.panel_details.Controls.Add(this.label5);
			this.panel_details.Controls.Add(this.txt_adress);
			this.panel_details.Controls.Add(this.label4);
			this.panel_details.Controls.Add(this.txt_client_code);
			this.panel_details.Controls.Add(this.label3);
			this.panel_details.Controls.Add(this.txt_client_name);
			this.panel_details.Controls.Add(this.label6);
			this.panel_details.Location = new Point(6, 21);
			this.panel_details.Name = "panel_details";
			this.panel_details.Size = new System.Drawing.Size(429, 85);
			this.panel_details.TabIndex = 1;
			this.panel4.BackColor = Color.FromArgb(255, 224, 192);
			this.panel4.Location = new Point(638, 21);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(193, 85);
			this.panel4.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(255, 255, 128);
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(9, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter or Update Client Information below";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(255, 255, 128);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(638, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Search Clients Below";
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.FromArgb(255, 192, 128);
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.Location = new Point(3, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 15);
			this.label6.TabIndex = 6;
			this.label6.Text = "Client Name";
			this.txt_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_client_name.Location = new Point(3, 20);
			this.txt_client_name.Name = "txt_client_name";
			this.txt_client_name.Size = new System.Drawing.Size(223, 21);
			this.txt_client_name.TabIndex = 15;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(255, 192, 128);
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(232, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 15);
			this.label3.TabIndex = 16;
			this.label3.Text = "Client Code";
			this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_client_code.Location = new Point(231, 20);
			this.txt_client_code.Name = "txt_client_code";
			this.txt_client_code.Size = new System.Drawing.Size(93, 21);
			this.txt_client_code.TabIndex = 17;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Aqua;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(3, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 15);
			this.label4.TabIndex = 18;
			this.label4.Text = "Client Adress";
			this.txt_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_adress.Location = new Point(3, 61);
			this.txt_adress.Name = "txt_adress";
			this.txt_adress.Size = new System.Drawing.Size(223, 21);
			this.txt_adress.TabIndex = 19;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Aqua;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(232, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "Rate";
			this.txt_client_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_client_rate.Location = new Point(231, 61);
			this.txt_client_rate.Name = "txt_client_rate";
			this.txt_client_rate.Size = new System.Drawing.Size(93, 21);
			this.txt_client_rate.TabIndex = 21;
			this.chk_client_active.AutoSize = true;
			this.chk_client_active.BackColor = Color.FromArgb(255, 255, 128);
			this.chk_client_active.Checked = true;
			this.chk_client_active.CheckState = CheckState.Checked;
			this.chk_client_active.Location = new Point(339, 24);
			this.chk_client_active.Name = "chk_client_active";
			this.chk_client_active.Size = new System.Drawing.Size(85, 17);
			this.chk_client_active.TabIndex = 22;
			this.chk_client_active.Text = "Client Active";
			this.chk_client_active.UseVisualStyleBackColor = false;
			this.btnsave.BackColor = Color.FromArgb(128, 255, 255);
			this.btnsave.Location = new Point(120, 3);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(73, 41);
			this.btnsave.TabIndex = 23;
			this.btnsave.Text = "SAVE";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.btnedit.BackColor = Color.FromArgb(255, 224, 192);
			this.btnedit.Location = new Point(5, 1);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(62, 43);
			this.btnedit.TabIndex = 24;
			this.btnedit.Text = "EDIT";
			this.btnedit.UseVisualStyleBackColor = false;
			this.btnedit.Click += new EventHandler(this.btnedit_Click);
			this.txt_record_guid.Location = new Point(6, 497);
			this.txt_record_guid.Name = "txt_record_guid";
			this.txt_record_guid.ReadOnly = true;
			this.txt_record_guid.Size = new System.Drawing.Size(828, 20);
			this.txt_record_guid.TabIndex = 1;
			this.txt_record_guid.TextAlign = HorizontalAlignment.Center;
			this.panel5.BackColor = SystemColors.InactiveCaption;
			this.panel5.Controls.Add(this.btn_locations);
			this.panel5.Controls.Add(this.panel3);
			this.panel5.Location = new Point(438, 21);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(194, 85);
			this.panel5.TabIndex = 25;
			this.btnnew.BackColor = Color.FromArgb(255, 192, 128);
			this.btnnew.Location = new Point(67, 3);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(54, 41);
			this.btnnew.TabIndex = 25;
			this.btnnew.Text = "NEW";
			this.btnnew.UseVisualStyleBackColor = false;
			this.btnnew.Click += new EventHandler(this.btnnew_Click);
			this.panel3.BackColor = Color.Silver;
			this.panel3.Controls.Add(this.btnedit);
			this.panel3.Controls.Add(this.btnsave);
			this.panel3.Controls.Add(this.btnnew);
			this.panel3.Location = new Point(-2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(196, 47);
			this.panel3.TabIndex = 26;
			this.btn_locations.BackColor = Color.FromArgb(192, 255, 192);
			this.btn_locations.Location = new Point(3, 55);
			this.btn_locations.Name = "btn_locations";
			this.btn_locations.Size = new System.Drawing.Size(188, 27);
			this.btn_locations.TabIndex = 27;
			this.btn_locations.Text = "Update Client Locations";
			this.btn_locations.UseVisualStyleBackColor = false;
			this.btn_locations.Click += new EventHandler(this.btn_locations_Click);
			this.label7.AutoSize = true;
			this.label7.BackColor = Color.Aqua;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.Location = new Point(336, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 15);
			this.label7.TabIndex = 23;
			this.label7.Text = "Client ID";
			this.txt_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txt_client_id.Location = new Point(333, 62);
			this.txt_client_id.Name = "txt_client_id";
			this.txt_client_id.ReadOnly = true;
			this.txt_client_id.Size = new System.Drawing.Size(93, 21);
			this.txt_client_id.TabIndex = 24;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 192, 128);
			base.ClientSize = new System.Drawing.Size(842, 523);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_manage_clients";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "New Securiko Uganda Ltd-Manage Client Profiles";
			base.Load += new EventHandler(this.frm_manage_clients_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.gdv_clients).EndInit();
			this.panel_details.ResumeLayout(false);
			this.panel_details.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		protected void Return_list_of_clients()
		{
			DataTable dt = Clients.Return_list_of_clients("return_list_of_clients");
			if (dt.Rows.Count > 0)
			{
				this.gdv_clients.DataSource = dt;
				this.gdv_clients.Columns["record_guid"].Visible = false;
				this.gdv_clients.Columns["client_id"].Visible = false;
				this.gdv_clients.Columns["client_code"].Visible = false;
				this.gdv_clients.Columns["client_name"].Width = 150;
				this.gdv_clients.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_clients.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_clients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_clients.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_clients.DefaultCellStyle.SelectionBackColor = Color.Brown;
				this.gdv_clients.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_clients.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_clients.EnableHeadersVisualStyles = false;
			}
		}

		protected void Save_client_details()
		{
			if (this.txt_client_code.Text == string.Empty || this.txt_client_name.Text == string.Empty)
			{
				MessageBox.Show("Client Code & name cannot be empty", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.txt_record_guid.Text == string.Empty)
			{
				Clients.Save_new_client_details("save_new_client_details", this.txt_client_code.Text, this.txt_client_name.Text, this.txt_adress.Text, (this.txt_client_rate.Text != string.Empty ? float.Parse(this.txt_client_rate.Text) : 0f), (this.chk_client_active.Checked ? true : false));
				MessageBox.Show("New Client details successfully saved", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.Return_list_of_clients();
				return;
			}
			Clients.Update_client_details("update_client_details", this.txt_client_code.Text, this.txt_client_name.Text, this.txt_adress.Text, (this.txt_client_rate.Text != string.Empty ? float.Parse(this.txt_client_rate.Text) : 0f), (this.chk_client_active.Checked ? true : false), Convert.ToInt32(this.txt_client_id.Text));
			MessageBox.Show("New Client details successfully updated", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.Return_list_of_clients();
		}
	}
}