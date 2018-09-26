using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_bank_lookups : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private DataGridView gdv_banks;

		private Label label1;

		private Label label2;

		private TextBox txt_bank_code;

		private Label label3;

		private TextBox txt_bank_name;

		private CheckBox chk_active;

		private Button btnsave;

		private Button btn_branches;

		private Button btnedit;

		private Button btnnew;

		public frm_bank_lookups()
		{
			this.InitializeComponent();
		}

		private void btn_branches_Click(object sender, EventArgs e)
		{
			(new frm_bank_branches()).ShowDialog();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.txt_bank_code.Enabled = true;
			this.txt_bank_name.Enabled = true;
			this.chk_active.Enabled = true;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_bank_code.Enabled = true;
			this.txt_bank_name.Enabled = true;
			this.chk_active.Enabled = true;
			this.txt_bank_code.Clear();
			this.txt_bank_name.Clear();
			this.chk_active.Checked = true;
			Salary_scales.bank_id = -1;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.txt_bank_code.Text == string.Empty || this.txt_bank_name.Text == string.Empty)
			{
				MessageBox.Show("Bank name & code are required fields", "Accounts info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Salary_scales.save_update_bank_details("save_update_bank_details", this.txt_bank_code.Text, this.txt_bank_name.Text, (this.chk_active.Checked ? true : false));
			MessageBox.Show("Success", "Accounts info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.get_bank_list();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_bank_lookups_Load(object sender, EventArgs e)
		{
			this.get_bank_list();
		}

		private void gdv_banks_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_banks.Rows.Count > 0)
			{
				Salary_scales.bank_id = Convert.ToInt32(this.gdv_banks.CurrentRow.Cells[0].Value.ToString());
				this.txt_bank_code.Text = this.gdv_banks.CurrentRow.Cells[1].Value.ToString();
				this.txt_bank_name.Text = this.gdv_banks.CurrentRow.Cells[2].Value.ToString();
				this.chk_active.Checked = Convert.ToBoolean(this.gdv_banks.CurrentRow.Cells[3].Value);
				this.txt_bank_code.Enabled = false;
				this.txt_bank_name.Enabled = false;
				this.chk_active.Enabled = false;
			}
		}

		protected void get_bank_list()
		{
			DataTable dt = Salary_scales.return_bank_lists("return_bank_lists");
			this.gdv_banks.DataSource = dt;
			this.gdv_banks.Columns["record_id"].Visible = false;
			this.gdv_banks.DefaultCellStyle.SelectionBackColor = Color.White;
			this.gdv_banks.DefaultCellStyle.SelectionForeColor = Color.Black;
			this.gdv_banks.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_banks.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_banks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_banks.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_banks.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_banks.DefaultCellStyle.SelectionBackColor = Color.White;
			this.gdv_banks.DefaultCellStyle.SelectionForeColor = Color.Black;
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bank_lookups));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdv_banks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btn_branches = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.txt_bank_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bank_code = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_banks)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 508);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Bank details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gdv_banks);
            this.panel3.Location = new System.Drawing.Point(6, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 377);
            this.panel3.TabIndex = 1;
            // 
            // gdv_banks
            // 
            this.gdv_banks.AllowUserToAddRows = false;
            this.gdv_banks.AllowUserToDeleteRows = false;
            this.gdv_banks.AllowUserToResizeColumns = false;
            this.gdv_banks.AllowUserToResizeRows = false;
            this.gdv_banks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_banks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_banks.Location = new System.Drawing.Point(3, 3);
            this.gdv_banks.Name = "gdv_banks";
            this.gdv_banks.Size = new System.Drawing.Size(732, 304);
            this.gdv_banks.TabIndex = 0;
            this.gdv_banks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_banks_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btn_branches);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.chk_active);
            this.panel2.Controls.Add(this.txt_bank_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_bank_code);
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 96);
            this.panel2.TabIndex = 0;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(404, 48);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(55, 33);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(343, 48);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(55, 33);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btn_branches
            // 
            this.btn_branches.Location = new System.Drawing.Point(465, 48);
            this.btn_branches.Name = "btn_branches";
            this.btn_branches.Size = new System.Drawing.Size(93, 33);
            this.btn_branches.TabIndex = 6;
            this.btn_branches.Text = "Bank Branches";
            this.btn_branches.UseVisualStyleBackColor = true;
            this.btn_branches.Click += new System.EventHandler(this.btn_branches_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(248, 48);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 33);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chk_active.Location = new System.Drawing.Point(248, 25);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(93, 17);
            this.chk_active.TabIndex = 4;
            this.chk_active.Text = "Bank is active";
            this.chk_active.UseVisualStyleBackColor = false;
            // 
            // txt_bank_name
            // 
            this.txt_bank_name.Location = new System.Drawing.Point(6, 61);
            this.txt_bank_name.Name = "txt_bank_name";
            this.txt_bank_name.Size = new System.Drawing.Size(222, 20);
            this.txt_bank_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bank Code";
            // 
            // txt_bank_code
            // 
            this.txt_bank_code.Location = new System.Drawing.Point(6, 22);
            this.txt_bank_code.Name = "txt_bank_code";
            this.txt_bank_code.Size = new System.Drawing.Size(222, 20);
            this.txt_bank_code.TabIndex = 0;
            // 
            // frm_bank_lookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 512);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_bank_lookups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Bank Details";
            this.Load += new System.EventHandler(this.frm_bank_lookups_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_banks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
	}
}