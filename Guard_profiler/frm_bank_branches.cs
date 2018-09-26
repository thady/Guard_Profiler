using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_bank_branches : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel3;

		private DataGridView gdv_branches;

		private Panel panel4;

		private Button btnnew;

		private Button btnedit;

		private Button btnsave;

		private CheckBox chk_active;

		private TextBox txt_branch_name;

		private Label label3;

		private Label label2;

		private TextBox txt_branch_id;

		private Label label1;

		private TextBox txt_bank_id;

		public frm_bank_branches()
		{
			this.InitializeComponent();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.txt_branch_name.ReadOnly = false;
			this.chk_active.Enabled = true;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_branch_id.Clear();
			this.txt_branch_name.Clear();
			this.txt_branch_name.ReadOnly = false;
			this.chk_active.Enabled = true;
			this.chk_active.Checked = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			int branch_id = -1;
			if (this.txt_branch_name.Text == string.Empty)
			{
				MessageBox.Show("Bank branch is a required field", "Accounts info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.txt_branch_id.Text != string.Empty)
			{
				branch_id = Convert.ToInt32(this.txt_branch_id.Text);
			}
			Salary_scales.save_update_branch_details("save_update_branch_details", this.txt_branch_name.Text, (this.chk_active.Checked ? true : false), branch_id);
			MessageBox.Show("Success", "Accounts info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.get_bank_branches();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_bank_branches_Load(object sender, EventArgs e)
		{
			this.get_bank_branches();
		}

		private void gdv_branches_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_branches.Rows.Count > 0)
			{
				this.txt_branch_name.Text = this.gdv_branches.CurrentRow.Cells[3].Value.ToString();
				this.chk_active.Checked = Convert.ToBoolean(this.gdv_branches.CurrentRow.Cells[4].Value);
				this.txt_branch_id.Text = this.gdv_branches.CurrentRow.Cells[1].Value.ToString();
				this.txt_branch_name.ReadOnly = true;
				this.chk_active.Enabled = false;
			}
		}

		protected void get_bank_branches()
		{
			DataTable dt = Salary_scales.get_bank_branches("get_bank_branches", Salary_scales.bank_id);
			this.gdv_branches.DataSource = dt;
			this.gdv_branches.Columns["record_guid"].Visible = false;
			this.gdv_branches.Columns["branch_id"].Visible = false;
			this.gdv_branches.Columns["bank_id"].Visible = false;
			this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
			this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
			this.gdv_branches.RowsDefaultCellStyle.BackColor = Color.LightGray;
			this.gdv_branches.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
			this.gdv_branches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.gdv_branches.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_branches.RowHeadersDefaultCellStyle.BackColor = Color.Black;
			this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
			this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
			this.txt_bank_id.Text = Salary_scales.bank_id.ToString();
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_bank_branches));
			this.panel1 = new Panel();
			this.panel4 = new Panel();
			this.label1 = new Label();
			this.txt_bank_id = new TextBox();
			this.btnnew = new Button();
			this.btnedit = new Button();
			this.btnsave = new Button();
			this.chk_active = new CheckBox();
			this.txt_branch_name = new TextBox();
			this.label3 = new Label();
			this.label2 = new Label();
			this.txt_branch_id = new TextBox();
			this.panel3 = new Panel();
			this.gdv_branches = new DataGridView();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.gdv_branches).BeginInit();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(549, 418);
			this.panel1.TabIndex = 0;
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.txt_bank_id);
			this.panel4.Controls.Add(this.btnnew);
			this.panel4.Controls.Add(this.btnedit);
			this.panel4.Controls.Add(this.btnsave);
			this.panel4.Controls.Add(this.chk_active);
			this.panel4.Controls.Add(this.txt_branch_name);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt_branch_id);
			this.panel4.Location = new Point(6, 10);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(540, 96);
			this.panel4.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new Point(416, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Bank ID";
			this.txt_bank_id.Enabled = false;
			this.txt_bank_id.Location = new Point(494, 3);
			this.txt_bank_id.Name = "txt_bank_id";
			this.txt_bank_id.Size = new System.Drawing.Size(39, 20);
			this.txt_bank_id.TabIndex = 9;
			this.btnnew.Location = new Point(479, 60);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(55, 33);
			this.btnnew.TabIndex = 8;
			this.btnnew.Text = "New";
			this.btnnew.UseVisualStyleBackColor = true;
			this.btnnew.Click += new EventHandler(this.btnnew_Click);
			this.btnedit.Location = new Point(418, 60);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(55, 33);
			this.btnedit.TabIndex = 7;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btnedit.Click += new EventHandler(this.btnedit_Click);
			this.btnsave.Location = new Point(323, 60);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(93, 33);
			this.btnsave.TabIndex = 5;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new EventHandler(this.btnsave_Click);
			this.chk_active.AutoSize = true;
			this.chk_active.BackColor = Color.FromArgb(128, 255, 128);
			this.chk_active.Location = new Point(248, 25);
			this.chk_active.Name = "chk_active";
			this.chk_active.Size = new System.Drawing.Size(102, 17);
			this.chk_active.TabIndex = 4;
			this.chk_active.Text = "Branch is active";
			this.chk_active.UseVisualStyleBackColor = false;
			this.txt_branch_name.Location = new Point(6, 61);
			this.txt_branch_name.Name = "txt_branch_name";
			this.txt_branch_name.Size = new System.Drawing.Size(222, 20);
			this.txt_branch_name.TabIndex = 3;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(6, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Branch Name";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(6, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Branch ID";
			this.txt_branch_id.Enabled = false;
			this.txt_branch_id.Location = new Point(6, 22);
			this.txt_branch_id.Name = "txt_branch_id";
			this.txt_branch_id.Size = new System.Drawing.Size(222, 20);
			this.txt_branch_id.TabIndex = 0;
			this.panel3.Controls.Add(this.gdv_branches);
			this.panel3.Location = new Point(3, 109);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(543, 306);
			this.panel3.TabIndex = 1;
			this.gdv_branches.AllowUserToAddRows = false;
			this.gdv_branches.AllowUserToDeleteRows = false;
			this.gdv_branches.AllowUserToResizeColumns = false;
			this.gdv_branches.AllowUserToResizeRows = false;
			this.gdv_branches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.gdv_branches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_branches.Location = new Point(3, 3);
			this.gdv_branches.Name = "gdv_branches";
			this.gdv_branches.Size = new System.Drawing.Size(537, 300);
			this.gdv_branches.TabIndex = 0;
			this.gdv_branches.CellClick += new DataGridViewCellEventHandler(this.gdv_branches_CellClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(553, 422);
			base.Controls.Add(this.panel1);
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "frm_bank_branches";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Manage Bank Branches";
			base.Load += new EventHandler(this.frm_bank_branches_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			((ISupportInitialize)this.gdv_branches).EndInit();
			base.ResumeLayout(false);
		}
	}
}