using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_guard_bank_details : Form
	{
		private IContainer components;

		private Panel panel1;

		private Label label1;

		private Label label2;

		private Panel panel2;

		private Label label3;

		private Label label4;

		private ComboBox cbo_bank;

		private ComboBox cbo_branch_name;

		private Label label5;

		private TextBox txt_account_number;

		private TextBox txt_nssf_number;

		private Label label6;

		private Button btnsave;

		private Button btnedit;

		private Button btnnew;

		private Panel panel3;

		private Label label8;

		private Label label7;

		private ComboBox cbo_branch_search;

		private Label label9;

		private TextBox txt_guard_number_search;

		private Button btnsearch;

		private DataGridView gdv_guards;

		//private ReSize reSize1;

		private Label label10;
        private ReSize reSize1;
        private TextBox txt_guard_number;

		public frm_guard_bank_details()
		{
			this.InitializeComponent();
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.cbo_bank.Text == string.Empty || this.cbo_branch_name.Text == string.Empty || this.txt_account_number.Text == string.Empty || this.txt_nssf_number.Text == string.Empty || this.txt_guard_number.Text == string.Empty)
			{
				MessageBox.Show("Fields with (*) are required", "save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Salary_scales.insert_update_guard_account_details("insert_update_guard_account_details", this.txt_guard_number.Text, Convert.ToInt32(this.cbo_bank.SelectedValue.ToString()), Convert.ToInt32(this.cbo_branch_name.SelectedValue.ToString()), this.txt_account_number.Text, this.txt_nssf_number.Text);
			MessageBox.Show("Success", "save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.get_guard_bank_mapping();
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			if (!(this.cbo_branch_name.Text != string.Empty) && !(this.txt_guard_number.Text != string.Empty))
			{
				this.gdv_guards.DataSource = null;
				this.gdv_guards.Rows.Clear();
				this.gdv_guards.Refresh();
				this.get_guard_bank_mapping();
				return;
			}
			this.gdv_guards.DataSource = null;
			this.gdv_guards.Rows.Clear();
			this.gdv_guards.Refresh();
			this.select_guard_bank_details_mapping_search();
		}

		private void cbo_bank_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cbo_bank.SelectedValue.ToString() != "-1")
			{
				this.get_bank_branches(Convert.ToInt32(this.cbo_bank.SelectedValue.ToString()));
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

		private void frm_guard_bank_details_Load(object sender, EventArgs e)
		{
			this.get_bank_list();
			this.GET_BRANCHES();
			this.get_guard_bank_mapping();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_guards.Rows.Count > 0)
			{
				this.txt_guard_number.Text = this.gdv_guards.CurrentRow.Cells[2].Value.ToString();
			}
		}

		protected void get_bank_branches(int bank_id)
		{
			DataTable dt = Salary_scales.get_bank_branches("get_bank_branches", bank_id);
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_guid"] = string.Empty;
				dtRow["branch_id"] = -1;
				dtRow["bank_id"] = -1;
				dtRow["branch_name"] = string.Empty;
				dtRow["branch_active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_branch_name.DisplayMember = "branch_name";
				this.cbo_branch_name.ValueMember = "branch_id";
				this.cbo_branch_name.DataSource = dt;
			}
		}

		protected void get_bank_list()
		{
			DataTable dt = Salary_scales.return_bank_lists("return_bank_lists");
			if (dt.Rows.Count != 0)
			{
				DataRow dtRow = dt.NewRow();
				dtRow["record_id"] = -1;
				dtRow["bank_code"] = string.Empty;
				dtRow["bank_name"] = string.Empty;
				dtRow["bank_active"] = true;
				dt.Rows.InsertAt(dtRow, 0);
				this.cbo_bank.DisplayMember = "bank_name";
				this.cbo_bank.ValueMember = "record_id";
				this.cbo_bank.DataSource = dt;
			}
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
				this.cbo_branch_search.DataSource = dt;
				this.cbo_branch_search.DisplayMember = "branch";
				this.cbo_branch_search.ValueMember = "branch_code";
			}
		}

		protected void get_guard_bank_mapping()
		{
			DataTable dt = Salary_scales.return_bank_lists("select_guard_bank_details_mapping");
			if (dt.Rows.Count != 0)
			{
				this.gdv_guards.DataSource = dt;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_bank_details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txt_guard_number_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_nssf_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_account_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_branch_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_bank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txt_guard_number_search);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbo_branch_search);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 465);
            this.panel1.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(474, 136);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txt_guard_number_search
            // 
            this.txt_guard_number_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_search.Location = new System.Drawing.Point(328, 132);
            this.txt_guard_number_search.Name = "txt_guard_number_search";
            this.txt_guard_number_search.Size = new System.Drawing.Size(140, 26);
            this.txt_guard_number_search.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Guard Number";
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_branch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(50, 135);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(174, 24);
            this.cbo_branch_search.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Branch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(3, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search Guards below";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.gdv_guards);
            this.panel3.Location = new System.Drawing.Point(5, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 298);
            this.panel3.TabIndex = 2;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(5, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.Size = new System.Drawing.Size(687, 292);
            this.gdv_guards.TabIndex = 0;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Details here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_guard_number);
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txt_nssf_number);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_account_number);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbo_branch_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbo_bank);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(5, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 100);
            this.panel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(466, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Guard Number";
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Enabled = false;
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(469, 17);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(130, 26);
            this.txt_guard_number.TabIndex = 11;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(620, 66);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(72, 23);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(542, 66);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(461, 66);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_nssf_number
            // 
            this.txt_nssf_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nssf_number.Location = new System.Drawing.Point(244, 63);
            this.txt_nssf_number.Name = "txt_nssf_number";
            this.txt_nssf_number.Size = new System.Drawing.Size(211, 26);
            this.txt_nssf_number.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nssf Number";
            // 
            // txt_account_number
            // 
            this.txt_account_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account_number.Location = new System.Drawing.Point(8, 63);
            this.txt_account_number.Name = "txt_account_number";
            this.txt_account_number.Size = new System.Drawing.Size(211, 26);
            this.txt_account_number.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Number";
            // 
            // cbo_branch_name
            // 
            this.cbo_branch_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_name.FormattingEnabled = true;
            this.cbo_branch_name.Location = new System.Drawing.Point(244, 20);
            this.cbo_branch_name.Name = "cbo_branch_name";
            this.cbo_branch_name.Size = new System.Drawing.Size(211, 24);
            this.cbo_branch_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Branch Name";
            // 
            // cbo_bank
            // 
            this.cbo_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_bank.FormattingEnabled = true;
            this.cbo_bank.Location = new System.Drawing.Point(8, 20);
            this.cbo_bank.Name = "cbo_bank";
            this.cbo_bank.Size = new System.Drawing.Size(211, 24);
            this.cbo_bank.TabIndex = 1;
            this.cbo_bank.SelectedIndexChanged += new System.EventHandler(this.cbo_bank_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bank Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage bank and Nssf information for guards";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 491D;
            this.reSize1.InitialHostContainerWidth = 706D;
            this.reSize1.Tag = null;
            // 
            // frm_guard_bank_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(706, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_guard_bank_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank & NSSF Details";
            this.Load += new System.EventHandler(this.frm_guard_bank_details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		protected void select_guard_bank_details_mapping_search()
		{
			DataTable dt = Salary_scales.select_guard_bank_details_mapping_search("select_guard_bank_details_mapping_search", this.cbo_branch_search.Text, this.txt_guard_number_search.Text);
			if (dt.Rows.Count != 0)
			{
				this.gdv_guards.DataSource = dt;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}
	}
}