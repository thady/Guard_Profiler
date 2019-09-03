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
	public class frm_manage_client_locations : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private Label label6;

		private Label label2;

		private TextBox txt_client_name;

		private TextBox txt_location;

		private TextBox txt_client_code;

		private Label label3;

		private DataGridView gdv_client_locations;

		private Button btnsave;

		private Button btnedit;

		private TextBox txt_record_guid;

		private Button btnnew;

		public frm_manage_client_locations()
		{
			this.InitializeComponent();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.txt_location.ReadOnly = false;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_location.Clear();
			this.txt_location.ReadOnly = false;
			this.txt_record_guid.Clear();
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.txt_location.Text == string.Empty)
			{
				MessageBox.Show("Missing client name", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.txt_record_guid.Text == string.Empty)
			{
				Clients.Save_client_location_details("save_client_location_details", Convert.ToInt32(SystemConst._client_id), this.txt_location.Text);
				MessageBox.Show(string.Concat("New Location for ", this.txt_client_name.Text, " has been added"), "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.Return_client_location_list();
				return;
			}
			Clients.Update_client_location_name("update_client_location_name", this.txt_record_guid.Text, this.txt_location.Text);
			MessageBox.Show(string.Concat("Location details for ", this.txt_client_name.Text, " has been updated"), "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.Return_client_location_list();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_manage_client_locations_Load(object sender, EventArgs e)
		{
			this.txt_client_code.Text = SystemConst._client_code;
			this.txt_client_name.Text = SystemConst._client_name;
			this.Return_client_location_list();
		}

		private void gdv_client_locations_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_client_locations.Rows.Count > 0)
			{
				string record_guid = this.gdv_client_locations.CurrentRow.Cells[0].Value.ToString();
				string location_name = this.gdv_client_locations.CurrentRow.Cells[2].Value.ToString();
				this.txt_location.Text = location_name;
				this.txt_record_guid.Text = record_guid;
				this.txt_location.ReadOnly = true;
			}
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manage_client_locations));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.txt_record_guid = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_client_locations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_client_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_client_locations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.txt_record_guid);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_client_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 332);
            this.panel1.TabIndex = 0;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnew.Location = new System.Drawing.Point(483, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(48, 23);
            this.btnnew.TabIndex = 21;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // txt_record_guid
            // 
            this.txt_record_guid.Location = new System.Drawing.Point(0, 309);
            this.txt_record_guid.Name = "txt_record_guid";
            this.txt_record_guid.Size = new System.Drawing.Size(535, 20);
            this.txt_record_guid.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnedit.Location = new System.Drawing.Point(435, 20);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(48, 23);
            this.btnedit.TabIndex = 20;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.Location = new System.Drawing.Point(379, 20);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(50, 23);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(204, 20);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(173, 21);
            this.txt_location.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Location Name";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_name.Location = new System.Drawing.Point(3, 20);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.ReadOnly = true;
            this.txt_client_name.Size = new System.Drawing.Size(195, 21);
            this.txt_client_name.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Client Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.gdv_client_locations);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 254);
            this.panel2.TabIndex = 0;
            // 
            // gdv_client_locations
            // 
            this.gdv_client_locations.AllowUserToAddRows = false;
            this.gdv_client_locations.AllowUserToDeleteRows = false;
            this.gdv_client_locations.AllowUserToResizeColumns = false;
            this.gdv_client_locations.AllowUserToResizeRows = false;
            this.gdv_client_locations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_client_locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_client_locations.Location = new System.Drawing.Point(3, 3);
            this.gdv_client_locations.Name = "gdv_client_locations";
            this.gdv_client_locations.ReadOnly = true;
            this.gdv_client_locations.Size = new System.Drawing.Size(525, 248);
            this.gdv_client_locations.TabIndex = 0;
            this.gdv_client_locations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_client_locations_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter or update client location details below";
            // 
            // txt_client_code
            // 
            this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_code.Location = new System.Drawing.Point(427, 0);
            this.txt_client_code.Name = "txt_client_code";
            this.txt_client_code.ReadOnly = true;
            this.txt_client_code.Size = new System.Drawing.Size(101, 21);
            this.txt_client_code.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Client Code";
            // 
            // frm_manage_client_locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(541, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_client_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manage_client_locations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Client Locations";
            this.Load += new System.EventHandler(this.frm_manage_client_locations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_client_locations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		protected void Return_client_location_list()
		{
			DataTable dt = Clients.Return_client_details("return_client_location_list", Convert.ToInt32(SystemConst._client_id));
			if (dt.Rows.Count > 0)
			{
				this.gdv_client_locations.DataSource = dt;
				this.gdv_client_locations.Columns["record_guid"].Visible = false;
				this.gdv_client_locations.Columns["client_id"].Visible = false;
				this.gdv_client_locations.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_client_locations.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_client_locations.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_client_locations.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_client_locations.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_client_locations.DefaultCellStyle.SelectionBackColor = Color.Brown;
				this.gdv_client_locations.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_client_locations.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_client_locations.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_client_locations.EnableHeadersVisualStyles = false;
			}
		}
	}
}