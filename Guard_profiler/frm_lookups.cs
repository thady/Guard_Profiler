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
	public class frm_lookups : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private Panel panel4;

		private DataGridView gdv_branches;

		private DataGridView gdv_departments;

		private DataGridView gdv_positions;

		private Label label1;

		private CheckBox chk_branch_active;

		private TextBox txt_branch_name;

		private Button btnsave;

		private Button btnedit;

		private Button btnnew;

		private Button btn_position_edit;

		private Button btn_position_new;

		private Panel panel6;

		private CheckBox chk_position_active;

		private TextBox txt_position_name;

		private Label label2;

		private Button btn_position_save;

		private Button btn_edit_dept;

		private Panel panel7;

		private CheckBox chk_dept_active;

		private TextBox txt_dept_name;

		private Label label3;

		private Button btn_new_dept;

		private Button btn_save_dept;

		//private ReSize reSize1;

		private TextBox txt_branch_id;

		private Label label4;

		private TextBox txt_dept_id;

		private Label label5;

		private TextBox txt_position_id;

		private Label label6;

		private Panel panel5;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label10;

		private TextBox txt_branch_code;

		private Label label11;

		private TextBox txt_position_code;

		private Label label12;
        private ReSize reSize1;
        private TextBox txt_department_code;

		public frm_lookups()
		{
			this.InitializeComponent();
		}

		private void btn_edit_dept_Click(object sender, EventArgs e)
		{
			this.panel7.Enabled = true;
		}

		private void btn_new_dept_Click(object sender, EventArgs e)
		{
			this.txt_dept_id.Clear();
			this.txt_dept_name.Clear();
			this.chk_dept_active.Checked = false;
			this.panel7.Enabled = true;
		}

		private void btn_position_edit_Click(object sender, EventArgs e)
		{
			this.panel6.Enabled = true;
		}

		private void btn_position_new_Click(object sender, EventArgs e)
		{
			this.txt_position_id.Clear();
			this.txt_position_name.Clear();
			this.chk_position_active.Checked = false;
			this.panel6.Enabled = true;
		}

		private void btn_position_save_Click(object sender, EventArgs e)
		{
			if (this.txt_position_name.Text == string.Empty)
			{
				MessageBox.Show("Position name required");
				return;
			}
			if (this.txt_position_id.Text == string.Empty)
			{
				System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_POSITION_DETAILS", this.txt_position_name.Text, (this.chk_position_active.Checked ? true : false), this.txt_position_code.Text);
				MessageBox.Show("Successfully saved position details");
				this.GET_POSITIONS();
				return;
			}
			System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_POSITION_DETAILS", this.txt_position_name.Text, (this.chk_position_active.Checked ? true : false), Convert.ToInt32(this.txt_position_id.Text), this.txt_position_code.Text);
			MessageBox.Show("Successfully updated position details");
			this.GET_POSITIONS();
		}

		private void btn_save_dept_Click(object sender, EventArgs e)
		{
			if (this.txt_dept_name.Text == string.Empty)
			{
				MessageBox.Show("Department name required");
				return;
			}
			if (this.txt_dept_id.Text == string.Empty)
			{
				System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_DEPARTMENT_DETAILS", this.txt_dept_name.Text, (this.chk_dept_active.Checked ? true : false), this.txt_department_code.Text);
				MessageBox.Show("Successfully saved department details");
				this.GET_DEPARTMENTS();
				return;
			}
			System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_DEPARTMENT_DETAILS", this.txt_dept_name.Text, (this.chk_dept_active.Checked ? true : false), Convert.ToInt32(this.txt_dept_id.Text), this.txt_department_code.Text);
			MessageBox.Show("Successfully updated department details");
			this.GET_DEPARTMENTS();
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			this.panel4.Enabled = true;
		}

		private void btnnew_Click(object sender, EventArgs e)
		{
			this.txt_branch_id.Clear();
			this.txt_branch_name.Clear();
			this.chk_branch_active.Checked = false;
			this.panel4.Enabled = true;
		}

		private void btnsave_Click(object sender, EventArgs e)
		{
			if (this.txt_branch_name.Text == string.Empty)
			{
				MessageBox.Show("Branch name required");
				return;
			}
			if (this.txt_branch_id.Text == string.Empty)
			{
				System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_BRANCH_DETAILS", this.txt_branch_name.Text, (this.chk_branch_active.Checked ? true : false), this.txt_branch_code.Text);
				MessageBox.Show("Successfully saved branch details");
				this.GET_BRANCHES();
				return;
			}
			System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_BRANCH_DETAILS", this.txt_branch_name.Text, (this.chk_branch_active.Checked ? true : false), Convert.ToInt32(this.txt_branch_id.Text), this.txt_branch_code.Text);
			MessageBox.Show("Successfully updated branch details");
			this.GET_BRANCHES();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_lookups_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.GET_BRANCHES();
			this.GET_DEPARTMENTS();
			this.GET_POSITIONS();
		}

		private void gdv_branches_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_branches.Rows.Count != 0)
			{
				this.txt_branch_id.Text = this.gdv_branches.CurrentRow.Cells[1].Value.ToString();
				this.txt_branch_name.Text = this.gdv_branches.CurrentRow.Cells[2].Value.ToString();
				this.txt_branch_code.Text = this.gdv_branches.CurrentRow.Cells[4].Value.ToString();
				this.chk_branch_active.Checked = (bool)this.gdv_branches.CurrentRow.Cells[3].Value;
				this.panel4.Enabled = false;
			}
		}

		private void gdv_departments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_departments.Rows.Count != 0)
			{
				this.txt_dept_id.Text = this.gdv_departments.CurrentRow.Cells[1].Value.ToString();
				this.txt_dept_name.Text = this.gdv_departments.CurrentRow.Cells[2].Value.ToString();
				this.txt_department_code.Text = this.gdv_departments.CurrentRow.Cells[4].Value.ToString();
				this.chk_dept_active.Checked = (bool)this.gdv_departments.CurrentRow.Cells[3].Value;
				this.panel7.Enabled = false;
			}
		}

		private void gdv_positions_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_positions.Rows.Count != 0)
			{
				this.txt_position_id.Text = this.gdv_positions.CurrentRow.Cells[1].Value.ToString();
				this.txt_position_name.Text = this.gdv_positions.CurrentRow.Cells[2].Value.ToString();
				this.txt_position_code.Text = this.gdv_positions.CurrentRow.Cells[4].Value.ToString();
				this.chk_position_active.Checked = (bool)this.gdv_positions.CurrentRow.Cells[3].Value;
				this.panel6.Enabled = false;
			}
		}

		protected void GET_BRANCHES()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
			if (dt != null)
			{
				this.gdv_branches.DataSource = dt;
				this.gdv_branches.Columns[0].Visible = false;
				this.gdv_branches.Columns[1].Visible = false;
				this.gdv_branches.Columns[2].HeaderText = "Branch Name";
				this.gdv_branches.Columns[3].HeaderText = "Branch Active?";
				this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_branches.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_branches.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_branches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_branches.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_branches.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}

		protected void GET_DEPARTMENTS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_DEPARTMENTS");
			if (dt != null)
			{
				this.gdv_departments.DataSource = dt;
				this.gdv_departments.Columns[0].Visible = false;
				this.gdv_departments.Columns[1].Visible = false;
				this.gdv_departments.Columns[2].HeaderText = "Department Name";
				this.gdv_departments.Columns[3].HeaderText = "Department Active?";
				this.gdv_departments.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_departments.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_departments.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_departments.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_departments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_departments.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_departments.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_departments.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_departments.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}

		protected void GET_POSITIONS()
		{
			DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_POSITIONS");
			if (dt != null)
			{
				this.gdv_positions.DataSource = dt;
				this.gdv_positions.Columns[0].Visible = false;
				this.gdv_positions.Columns[1].Visible = false;
				this.gdv_positions.Columns[2].HeaderText = "Position Name";
				this.gdv_positions.Columns[3].HeaderText = "Position Active?";
				this.gdv_positions.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_positions.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_positions.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_positions.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_positions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_positions.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_positions.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_positions.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_positions.DefaultCellStyle.SelectionForeColor = Color.Black;
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_lookups));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.gdv_branches = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_branch_code = new System.Windows.Forms.TextBox();
            this.txt_branch_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_branch_active = new System.Windows.Forms.CheckBox();
            this.txt_branch_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit_dept = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_department_code = new System.Windows.Forms.TextBox();
            this.txt_dept_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_dept_active = new System.Windows.Forms.CheckBox();
            this.txt_dept_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gdv_departments = new System.Windows.Forms.DataGridView();
            this.btn_new_dept = new System.Windows.Forms.Button();
            this.btn_save_dept = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_position_edit = new System.Windows.Forms.Button();
            this.btn_position_new = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_position_code = new System.Windows.Forms.TextBox();
            this.txt_position_id = new System.Windows.Forms.TextBox();
            this.chk_position_active = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_position_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_position_save = new System.Windows.Forms.Button();
            this.gdv_positions = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_branches)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_departments)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_positions)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.gdv_branches);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(716, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 370);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(258, 121);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(79, 31);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(173, 121);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(79, 31);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(343, 121);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 31);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // gdv_branches
            // 
            this.gdv_branches.AllowUserToAddRows = false;
            this.gdv_branches.AllowUserToDeleteRows = false;
            this.gdv_branches.AllowUserToResizeColumns = false;
            this.gdv_branches.AllowUserToResizeRows = false;
            this.gdv_branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_branches.Location = new System.Drawing.Point(3, 158);
            this.gdv_branches.Name = "gdv_branches";
            this.gdv_branches.Size = new System.Drawing.Size(634, 204);
            this.gdv_branches.TabIndex = 1;
            this.gdv_branches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_branches_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txt_branch_code);
            this.panel4.Controls.Add(this.txt_branch_id);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.chk_branch_active);
            this.panel4.Controls.Add(this.txt_branch_name);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 112);
            this.panel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Branch Code";
            // 
            // txt_branch_code
            // 
            this.txt_branch_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_code.Location = new System.Drawing.Point(6, 78);
            this.txt_branch_code.Name = "txt_branch_code";
            this.txt_branch_code.Size = new System.Drawing.Size(156, 24);
            this.txt_branch_code.TabIndex = 5;
            // 
            // txt_branch_id
            // 
            this.txt_branch_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_id.Location = new System.Drawing.Point(168, 78);
            this.txt_branch_id.Name = "txt_branch_id";
            this.txt_branch_id.ReadOnly = true;
            this.txt_branch_id.Size = new System.Drawing.Size(96, 24);
            this.txt_branch_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branch ID";
            // 
            // chk_branch_active
            // 
            this.chk_branch_active.AutoSize = true;
            this.chk_branch_active.ForeColor = System.Drawing.Color.Black;
            this.chk_branch_active.Location = new System.Drawing.Point(6, 42);
            this.chk_branch_active.Name = "chk_branch_active";
            this.chk_branch_active.Size = new System.Drawing.Size(103, 17);
            this.chk_branch_active.TabIndex = 2;
            this.chk_branch_active.Text = "Branch is Active";
            this.chk_branch_active.UseVisualStyleBackColor = true;
            // 
            // txt_branch_name
            // 
            this.txt_branch_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_name.Location = new System.Drawing.Point(6, 16);
            this.txt_branch_name.Name = "txt_branch_name";
            this.txt_branch_name.Size = new System.Drawing.Size(258, 24);
            this.txt_branch_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_edit_dept);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.gdv_departments);
            this.panel2.Controls.Add(this.btn_new_dept);
            this.panel2.Controls.Add(this.btn_save_dept);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 375);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_edit_dept
            // 
            this.btn_edit_dept.Location = new System.Drawing.Point(262, 121);
            this.btn_edit_dept.Name = "btn_edit_dept";
            this.btn_edit_dept.Size = new System.Drawing.Size(79, 31);
            this.btn_edit_dept.TabIndex = 7;
            this.btn_edit_dept.Text = "Edit";
            this.btn_edit_dept.UseVisualStyleBackColor = true;
            this.btn_edit_dept.Click += new System.EventHandler(this.btn_edit_dept_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txt_department_code);
            this.panel7.Controls.Add(this.txt_dept_id);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.chk_dept_active);
            this.panel7.Controls.Add(this.txt_dept_name);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(422, 112);
            this.panel7.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Department Code";
            // 
            // txt_department_code
            // 
            this.txt_department_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department_code.Location = new System.Drawing.Point(6, 81);
            this.txt_department_code.Name = "txt_department_code";
            this.txt_department_code.Size = new System.Drawing.Size(160, 24);
            this.txt_department_code.TabIndex = 6;
            // 
            // txt_dept_id
            // 
            this.txt_dept_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_id.Location = new System.Drawing.Point(172, 81);
            this.txt_dept_id.Name = "txt_dept_id";
            this.txt_dept_id.ReadOnly = true;
            this.txt_dept_id.Size = new System.Drawing.Size(92, 24);
            this.txt_dept_id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department ID";
            // 
            // chk_dept_active
            // 
            this.chk_dept_active.AutoSize = true;
            this.chk_dept_active.Location = new System.Drawing.Point(6, 46);
            this.chk_dept_active.Name = "chk_dept_active";
            this.chk_dept_active.Size = new System.Drawing.Size(127, 17);
            this.chk_dept_active.TabIndex = 2;
            this.chk_dept_active.Text = "Department  is Active";
            this.chk_dept_active.UseVisualStyleBackColor = true;
            // 
            // txt_dept_name
            // 
            this.txt_dept_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dept_name.Location = new System.Drawing.Point(6, 16);
            this.txt_dept_name.Name = "txt_dept_name";
            this.txt_dept_name.Size = new System.Drawing.Size(258, 24);
            this.txt_dept_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department Name";
            // 
            // gdv_departments
            // 
            this.gdv_departments.AllowUserToAddRows = false;
            this.gdv_departments.AllowUserToDeleteRows = false;
            this.gdv_departments.AllowUserToResizeColumns = false;
            this.gdv_departments.AllowUserToResizeRows = false;
            this.gdv_departments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_departments.Location = new System.Drawing.Point(3, 158);
            this.gdv_departments.Name = "gdv_departments";
            this.gdv_departments.Size = new System.Drawing.Size(634, 210);
            this.gdv_departments.TabIndex = 3;
            this.gdv_departments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_departments_CellClick);
            // 
            // btn_new_dept
            // 
            this.btn_new_dept.Location = new System.Drawing.Point(177, 121);
            this.btn_new_dept.Name = "btn_new_dept";
            this.btn_new_dept.Size = new System.Drawing.Size(79, 31);
            this.btn_new_dept.TabIndex = 6;
            this.btn_new_dept.Text = "New";
            this.btn_new_dept.UseVisualStyleBackColor = true;
            this.btn_new_dept.Click += new System.EventHandler(this.btn_new_dept_Click);
            // 
            // btn_save_dept
            // 
            this.btn_save_dept.Location = new System.Drawing.Point(347, 121);
            this.btn_save_dept.Name = "btn_save_dept";
            this.btn_save_dept.Size = new System.Drawing.Size(79, 31);
            this.btn_save_dept.TabIndex = 5;
            this.btn_save_dept.Text = "Save";
            this.btn_save_dept.UseVisualStyleBackColor = true;
            this.btn_save_dept.Click += new System.EventHandler(this.btn_save_dept_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_position_edit);
            this.panel3.Controls.Add(this.btn_position_new);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btn_position_save);
            this.panel3.Controls.Add(this.gdv_positions);
            this.panel3.Location = new System.Drawing.Point(5, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 314);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_position_edit
            // 
            this.btn_position_edit.Location = new System.Drawing.Point(258, 125);
            this.btn_position_edit.Name = "btn_position_edit";
            this.btn_position_edit.Size = new System.Drawing.Size(79, 31);
            this.btn_position_edit.TabIndex = 7;
            this.btn_position_edit.Text = "Edit";
            this.btn_position_edit.UseVisualStyleBackColor = true;
            this.btn_position_edit.Click += new System.EventHandler(this.btn_position_edit_Click);
            // 
            // btn_position_new
            // 
            this.btn_position_new.Location = new System.Drawing.Point(173, 125);
            this.btn_position_new.Name = "btn_position_new";
            this.btn_position_new.Size = new System.Drawing.Size(79, 31);
            this.btn_position_new.TabIndex = 6;
            this.btn_position_new.Text = "New";
            this.btn_position_new.UseVisualStyleBackColor = true;
            this.btn_position_new.Click += new System.EventHandler(this.btn_position_new_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txt_position_code);
            this.panel6.Controls.Add(this.txt_position_id);
            this.panel6.Controls.Add(this.chk_position_active);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txt_position_name);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(422, 122);
            this.panel6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Position Code";
            // 
            // txt_position_code
            // 
            this.txt_position_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position_code.Location = new System.Drawing.Point(6, 78);
            this.txt_position_code.Name = "txt_position_code";
            this.txt_position_code.Size = new System.Drawing.Size(155, 24);
            this.txt_position_code.TabIndex = 8;
            // 
            // txt_position_id
            // 
            this.txt_position_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position_id.Location = new System.Drawing.Point(167, 78);
            this.txt_position_id.Name = "txt_position_id";
            this.txt_position_id.ReadOnly = true;
            this.txt_position_id.Size = new System.Drawing.Size(97, 24);
            this.txt_position_id.TabIndex = 6;
            // 
            // chk_position_active
            // 
            this.chk_position_active.AutoSize = true;
            this.chk_position_active.Location = new System.Drawing.Point(6, 42);
            this.chk_position_active.Name = "chk_position_active";
            this.chk_position_active.Size = new System.Drawing.Size(106, 17);
            this.chk_position_active.TabIndex = 2;
            this.chk_position_active.Text = "Position is Active";
            this.chk_position_active.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Position ID";
            // 
            // txt_position_name
            // 
            this.txt_position_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position_name.Location = new System.Drawing.Point(6, 16);
            this.txt_position_name.Name = "txt_position_name";
            this.txt_position_name.Size = new System.Drawing.Size(258, 24);
            this.txt_position_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position Name";
            // 
            // btn_position_save
            // 
            this.btn_position_save.ForeColor = System.Drawing.Color.Blue;
            this.btn_position_save.Location = new System.Drawing.Point(343, 125);
            this.btn_position_save.Name = "btn_position_save";
            this.btn_position_save.Size = new System.Drawing.Size(79, 31);
            this.btn_position_save.TabIndex = 5;
            this.btn_position_save.Text = "Save";
            this.btn_position_save.UseVisualStyleBackColor = true;
            this.btn_position_save.Click += new System.EventHandler(this.btn_position_save_Click);
            // 
            // gdv_positions
            // 
            this.gdv_positions.AllowUserToAddRows = false;
            this.gdv_positions.AllowUserToDeleteRows = false;
            this.gdv_positions.AllowUserToResizeColumns = false;
            this.gdv_positions.AllowUserToResizeRows = false;
            this.gdv_positions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_positions.Location = new System.Drawing.Point(3, 158);
            this.gdv_positions.Name = "gdv_positions";
            this.gdv_positions.Size = new System.Drawing.Size(630, 149);
            this.gdv_positions.TabIndex = 2;
            this.gdv_positions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_positions_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1366, 741);
            this.panel5.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(3, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "MANAGE POSITIONS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(713, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "MANAGE BRANCHES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(2, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "MANAGE DEPARTMENTS";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 745D;
            this.reSize1.InitialHostContainerWidth = 1366D;
            this.reSize1.Tag = null;
            // 
            // frm_lookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_lookups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "MANAGE BRANCHES,DEPARTMENTS & POSITIONS";
            this.Load += new System.EventHandler(this.frm_lookups_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_branches)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_departments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_positions)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}