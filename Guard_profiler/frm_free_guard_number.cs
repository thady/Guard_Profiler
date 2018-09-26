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
	public class frm_free_guard_number : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel panel2;

		private TextBox txt_guard_number;

		private Label label1;

		private Button btnsearch;

		private DataGridView gdv_guards;

		//private ReSize reSize1;

		private Label label2;

		private CheckBox chk_remove;

		private CheckBox chk_images;

		private CheckBox chk_data_archieve;

		private Panel panel3;

		private Button btn_un_assigned;

		private TextBox txt_guard_number_remove;

		private Label label3;
        private ReSize reSize1;
        private TextBox txt_guid;

		public frm_free_guard_number()
		{
			this.InitializeComponent();
		}

		protected void ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD()
		{
			if (this.txt_guard_number_remove.Text == string.Empty)
			{
				MessageBox.Show("Select or type in a guard number to archieve");
				return;
			}
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("You are about to remove a number from a guard,this will archieve the guard's details.This action cannot be undone,proceed??", "Archieve Guard", MessageBoxButtons.YesNo);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				sg_Profiles.UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS("UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS", this.txt_guid.Text);
				MessageBox.Show("All guard details have been successfully archieved,you can access them from the archived guards module");
				return;
			}
			if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				base.Visible = true;
				this.txt_guard_number.Clear();
				this.txt_guard_number_remove.Clear();
			}
		}

		private void btn_un_assigned_Click(object sender, EventArgs e)
		{
			this.ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD();
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			if (this.txt_guard_number.Text == string.Empty)
			{
				this.GET_GUARD_LIST();
				return;
			}
			this.SEARCH_GUARD_BY_GUARD_NUMBER();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_free_guard_number_Load(object sender, EventArgs e)
		{
			this.GET_GUARD_LIST();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.txt_guard_number_remove.Text = this.gdv_guards.CurrentRow.Cells[1].Value.ToString();
			this.txt_guid.Text = this.gdv_guards.CurrentRow.Cells[0].Value.ToString();
		}

		protected void GET_GUARD_LIST()
		{
			try
			{
				DataTable dt = sg_Profiles.RETURN_OFFICER_LIST("SELECT_LIST_OF_GUARDS_WITH_GUARD_NUMBER");
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.Columns[1].HeaderText = "Guard Number";
					this.gdv_guards.Columns[2].HeaderText = "Name";
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
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_free_guard_number));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_data_archieve = new System.Windows.Forms.CheckBox();
            this.chk_images = new System.Windows.Forms.CheckBox();
            this.chk_remove = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_un_assigned = new System.Windows.Forms.Button();
            this.txt_guard_number_remove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.gdv_guards);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 466);
            this.panel1.TabIndex = 0;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(3, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.ReadOnly = true;
            this.gdv_guards.Size = new System.Drawing.Size(863, 456);
            this.gdv_guards.TabIndex = 0;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.txt_guard_number);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 66);
            this.panel2.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(194, 1);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(141, 60);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "SEARCH GUARD NUMBER";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(10, 24);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(163, 31);
            this.txt_guard_number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guard Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search and select the guard number you want to un-assign";
            // 
            // chk_data_archieve
            // 
            this.chk_data_archieve.AutoSize = true;
            this.chk_data_archieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chk_data_archieve.Checked = true;
            this.chk_data_archieve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_data_archieve.Enabled = false;
            this.chk_data_archieve.Location = new System.Drawing.Point(379, 12);
            this.chk_data_archieve.Name = "chk_data_archieve";
            this.chk_data_archieve.Size = new System.Drawing.Size(207, 17);
            this.chk_data_archieve.TabIndex = 3;
            this.chk_data_archieve.Text = "Archieve Guard Details after un-assign";
            this.chk_data_archieve.UseVisualStyleBackColor = false;
            // 
            // chk_images
            // 
            this.chk_images.AutoSize = true;
            this.chk_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chk_images.Checked = true;
            this.chk_images.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_images.Enabled = false;
            this.chk_images.Location = new System.Drawing.Point(379, 35);
            this.chk_images.Name = "chk_images";
            this.chk_images.Size = new System.Drawing.Size(137, 17);
            this.chk_images.TabIndex = 4;
            this.chk_images.Text = "Archieve Guard Images";
            this.chk_images.UseVisualStyleBackColor = false;
            // 
            // chk_remove
            // 
            this.chk_remove.AutoSize = true;
            this.chk_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chk_remove.Checked = true;
            this.chk_remove.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_remove.Enabled = false;
            this.chk_remove.Location = new System.Drawing.Point(379, 61);
            this.chk_remove.Name = "chk_remove";
            this.chk_remove.Size = new System.Drawing.Size(159, 17);
            this.chk_remove.TabIndex = 5;
            this.chk_remove.Text = "Remove from Active Guards";
            this.chk_remove.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_un_assigned);
            this.panel3.Controls.Add(this.txt_guard_number_remove);
            this.panel3.Location = new System.Drawing.Point(592, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 60);
            this.panel3.TabIndex = 6;
            // 
            // btn_un_assigned
            // 
            this.btn_un_assigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_un_assigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_un_assigned.Location = new System.Drawing.Point(190, 0);
            this.btn_un_assigned.Name = "btn_un_assigned";
            this.btn_un_assigned.Size = new System.Drawing.Size(91, 56);
            this.btn_un_assigned.TabIndex = 4;
            this.btn_un_assigned.Text = "Remove from Guard";
            this.btn_un_assigned.UseVisualStyleBackColor = false;
            this.btn_un_assigned.Click += new System.EventHandler(this.btn_un_assigned_Click);
            // 
            // txt_guard_number_remove
            // 
            this.txt_guard_number_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_remove.Location = new System.Drawing.Point(3, 14);
            this.txt_guard_number_remove.Name = "txt_guard_number_remove";
            this.txt_guard_number_remove.Size = new System.Drawing.Size(181, 31);
            this.txt_guard_number_remove.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(593, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Guard  Number to be un-assigned";
            // 
            // txt_guid
            // 
            this.txt_guid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_guid.ForeColor = System.Drawing.Color.White;
            this.txt_guid.Location = new System.Drawing.Point(12, 562);
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.ReadOnly = true;
            this.txt_guid.Size = new System.Drawing.Size(873, 20);
            this.txt_guid.TabIndex = 8;
            this.txt_guid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 584D;
            this.reSize1.InitialHostContainerWidth = 889D;
            this.reSize1.Tag = null;
            // 
            // frm_free_guard_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(889, 584);
            this.Controls.Add(this.txt_guid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chk_remove);
            this.Controls.Add(this.chk_images);
            this.Controls.Add(this.chk_data_archieve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_free_guard_number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Assigned Number from a Guard";
            this.Load += new System.EventHandler(this.frm_free_guard_number_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		protected void SEARCH_GUARD_BY_GUARD_NUMBER()
		{
			try
			{
				DataTable dt = sg_Profiles.RETURN_OFFICER_LIST_BY_GUARD_NUMBER("SEARCH_GUARD_BY_NUMBER", this.txt_guard_number.Text);
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
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
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}
	}
}