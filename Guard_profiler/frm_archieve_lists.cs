using Guard_profiler.App_code;
using Guard_profiler.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_archieve_lists : Form
	{
		private IContainer components;

		private Panel panel1;

		private DataGridView gdv_guards;

		private Panel panel2;

		private Panel panel3;

		private DataGridView gdv_statisctics;

		private ComboBox cbo_branch_search;

		private ComboBox cbo_guard_status;

		private Label label43;

		private Label label2;

		private Button btn_name_search;

		private Button btn_export_list;

		private Button btn_export_single_report;

		private Panel panel4;

		private Button btn_export_stats;

		private TextBox txt_guard_number;

		private PictureBox pictureBox1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private Label label1;

		public frm_archieve_lists()
		{
			this.InitializeComponent();
		}

		private void btn_export_list_Click(object sender, EventArgs e)
		{
			SystemConst._guard_status = this.cbo_guard_status.Text;
			(new frm_archieved_guard_list_report()).ShowDialog();
		}

		private void btn_export_single_report_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an officer to view report");
            }
            else
            {
                string guard_number = txt_guard_number.Text;
                SystemConst.guard_number = guard_number;
                SystemConst._Single_report_type = "Archieve";

                frmcrystal_report_single report = new frmcrystal_report_single();
                report.ShowDialog();
            }
        }

		private void btn_export_stats_Click(object sender, EventArgs e)
		{
			if (this.gdv_statisctics.Rows.Count == 0)
			{
				MessageBox.Show("No Archieve Stats available for export", "Stats", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SaveFileDialog sfd = new SaveFileDialog()
			{
				Filter = "Excel Documents (*.xls)|*.xls",
				FileName = "export.xls"
			};
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.ToCsV(this.gdv_statisctics, sfd.FileName);
			}
		}

		private void btn_name_search_Click(object sender, EventArgs e)
		{
			if (this.cbo_guard_status.Text != string.Empty && this.cbo_branch_search.Text == string.Empty)
			{
				DataTable _dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS("FILTER_ARCHIEVE_BY_STATUS", this.cbo_guard_status.Text);
				if (_dt == null)
				{
					this.gdv_statisctics.DataSource = null;
					return;
				}
				this.gdv_guards.DataSource = _dt;
				this.gdv_guards.Columns[0].Visible = false;
				this.gdv_guards.Columns[1].Visible = false;
				this.gdv_guards.Columns[2].HeaderText = "NAME";
				this.gdv_guards.Columns[3].HeaderText = "BRANCH";
				this.gdv_guards.Columns[4].HeaderText = "STATUS";
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				return;
			}
			if (this.cbo_guard_status.Text == string.Empty && this.cbo_branch_search.Text != string.Empty)
			{
				DataTable _dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_BRANCH("FILTER_ARCHIEVE_BY_STATION", this.cbo_branch_search.Text);
				if (_dt == null)
				{
					this.gdv_statisctics.DataSource = null;
					return;
				}
				this.gdv_guards.DataSource = _dt;
				this.gdv_guards.Columns[0].Visible = false;
				this.gdv_guards.Columns[1].Visible = false;
				this.gdv_guards.Columns[2].HeaderText = "NAME";
				this.gdv_guards.Columns[3].HeaderText = "BRANCH";
				this.gdv_guards.Columns[4].HeaderText = "STATUS";
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
				return;
			}
			if (!(this.cbo_guard_status.Text != string.Empty) || !(this.cbo_branch_search.Text != string.Empty))
			{
				this.GET_GUARD_LIST();
				return;
			}
			DataTable dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_BRANCH_AND_STATUS("FILTER_ARCHIEVE_BY_STATION", this.cbo_branch_search.Text, this.cbo_guard_status.Text);
			if (dt == null)
			{
				this.gdv_statisctics.DataSource = null;
				return;
			}
			this.gdv_guards.DataSource = dt;
			this.gdv_guards.Columns[0].Visible = false;
			this.gdv_guards.Columns[1].Visible = false;
			this.gdv_guards.Columns[2].HeaderText = "NAME";
			this.gdv_guards.Columns[3].HeaderText = "BRANCH";
			this.gdv_guards.Columns[4].HeaderText = "STATUS";
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

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_archieve_lists_Load(object sender, EventArgs e)
		{
			this.GET_GUARD_LIST();
			this.SELECT_ARCHIVED_GUARDS_STATS();
			this.GET_BRANCHES_SEARCH();
		}

		private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.gdv_guards.Rows.Count != 0)
			{
				this.txt_guard_number.Text = this.gdv_guards.CurrentRow.Cells[0].Value.ToString();
			}
		}

		private void gdv_guards_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		protected void GET_BRANCHES_SEARCH()
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
				this.cbo_branch_search.ValueMember = "auto_id";
			}
		}

		protected void GET_GUARD_LIST()
		{
			try
			{
				DataTable dt = Archieve_Lists.RETURN_OFFICER_LIST("SELECT_ARCHIEVED_GUARDS_LIST");
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.Columns[1].Visible = false;
					this.gdv_guards.Columns[2].HeaderText = "NAME";
					this.gdv_guards.Columns[3].HeaderText = "BRANCH";
					this.gdv_guards.Columns[4].HeaderText = "STATUS";
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_archieve_lists));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gdv_statisctics = new System.Windows.Forms.DataGridView();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_export_single_report = new System.Windows.Forms.Button();
            this.btn_export_list = new System.Windows.Forms.Button();
            this.btn_name_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.cbo_guard_status = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_export_stats = new System.Windows.Forms.Button();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_statisctics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.txt_guard_number);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gdv_guards);
            this.panel1.Location = new System.Drawing.Point(2, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 531);
            this.panel1.TabIndex = 0;
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.ForeColor = System.Drawing.Color.White;
            this.txt_guard_number.Location = new System.Drawing.Point(3, 500);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.ReadOnly = true;
            this.txt_guard_number.Size = new System.Drawing.Size(538, 31);
            this.txt_guard_number.TabIndex = 1;
            this.txt_guard_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.gdv_statisctics);
            this.panel3.Location = new System.Drawing.Point(547, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 525);
            this.panel3.TabIndex = 2;
            // 
            // gdv_statisctics
            // 
            this.gdv_statisctics.AllowUserToAddRows = false;
            this.gdv_statisctics.AllowUserToDeleteRows = false;
            this.gdv_statisctics.AllowUserToResizeColumns = false;
            this.gdv_statisctics.AllowUserToResizeRows = false;
            this.gdv_statisctics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_statisctics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_statisctics.Location = new System.Drawing.Point(3, 3);
            this.gdv_statisctics.Name = "gdv_statisctics";
            this.gdv_statisctics.ReadOnly = true;
            this.gdv_statisctics.Size = new System.Drawing.Size(299, 519);
            this.gdv_statisctics.TabIndex = 3;
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
            this.gdv_guards.Size = new System.Drawing.Size(538, 499);
            this.gdv_guards.TabIndex = 1;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            this.gdv_guards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_export_single_report);
            this.panel2.Controls.Add(this.btn_export_list);
            this.panel2.Controls.Add(this.btn_name_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label43);
            this.panel2.Controls.Add(this.cbo_branch_search);
            this.panel2.Controls.Add(this.cbo_guard_status);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 53);
            this.panel2.TabIndex = 1;
            // 
            // btn_export_single_report
            // 
            this.btn_export_single_report.BackColor = System.Drawing.Color.Aqua;
            this.btn_export_single_report.Location = new System.Drawing.Point(404, 27);
            this.btn_export_single_report.Name = "btn_export_single_report";
            this.btn_export_single_report.Size = new System.Drawing.Size(131, 23);
            this.btn_export_single_report.TabIndex = 66;
            this.btn_export_single_report.Text = "Export Single Report";
            this.btn_export_single_report.UseVisualStyleBackColor = false;
            this.btn_export_single_report.Click += new System.EventHandler(this.btn_export_single_report_Click);
            // 
            // btn_export_list
            // 
            this.btn_export_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_export_list.Location = new System.Drawing.Point(404, 3);
            this.btn_export_list.Name = "btn_export_list";
            this.btn_export_list.Size = new System.Drawing.Size(131, 23);
            this.btn_export_list.TabIndex = 65;
            this.btn_export_list.Text = "Export as List by status";
            this.btn_export_list.UseVisualStyleBackColor = false;
            this.btn_export_list.Click += new System.EventHandler(this.btn_export_list_Click);
            // 
            // btn_name_search
            // 
            this.btn_name_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_name_search.Location = new System.Drawing.Point(266, 3);
            this.btn_name_search.Name = "btn_name_search";
            this.btn_name_search.Size = new System.Drawing.Size(65, 47);
            this.btn_name_search.TabIndex = 64;
            this.btn_name_search.Text = "Search";
            this.btn_name_search.UseVisualStyleBackColor = false;
            this.btn_name_search.Click += new System.EventHandler(this.btn_name_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Branch";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Yellow;
            this.label43.Location = new System.Drawing.Point(20, 6);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 13);
            this.label43.TabIndex = 62;
            this.label43.Text = "Status";
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(67, 27);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(193, 23);
            this.cbo_branch_search.TabIndex = 1;
            // 
            // cbo_guard_status
            // 
            this.cbo_guard_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_guard_status.FormattingEnabled = true;
            this.cbo_guard_status.Location = new System.Drawing.Point(67, 3);
            this.cbo_guard_status.Name = "cbo_guard_status";
            this.cbo_guard_status.Size = new System.Drawing.Size(193, 23);
            this.cbo_guard_status.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btn_export_stats);
            this.panel4.Location = new System.Drawing.Point(549, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 53);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archieve Stats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guard_profiler.Properties.Resources.arrrrr;
            this.pictureBox1.Location = new System.Drawing.Point(86, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_export_stats
            // 
            this.btn_export_stats.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_export_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_stats.ForeColor = System.Drawing.Color.Blue;
            this.btn_export_stats.Location = new System.Drawing.Point(131, 2);
            this.btn_export_stats.Name = "btn_export_stats";
            this.btn_export_stats.Size = new System.Drawing.Size(174, 49);
            this.btn_export_stats.TabIndex = 0;
            this.btn_export_stats.Text = "Export Statistics Report to Excel";
            this.btn_export_stats.UseVisualStyleBackColor = false;
            this.btn_export_stats.Click += new System.EventHandler(this.btn_export_stats_Click);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 592D;
            this.reSize1.InitialHostContainerWidth = 860D;
            this.reSize1.Tag = null;
            // 
            // frm_archieve_lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(860, 592);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_archieve_lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guard Archive Lists & Reports";
            this.Load += new System.EventHandler(this.frm_archieve_lists_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_statisctics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		protected void SELECT_ARCHIVED_GUARDS_STATS()
		{
			try
			{
				DataTable dt = Archieve_Lists.SELECT_ARCHIVED_GUARDS_STATS("SELECT_ARCHIVED_GUARDS_STATS");
				if (dt != null)
				{
					this.gdv_statisctics.DataSource = dt;
					this.gdv_statisctics.Columns[0].HeaderText = "STATUS";
					this.gdv_statisctics.Columns[1].HeaderText = "TOTAL";
					this.gdv_statisctics.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_statisctics.DefaultCellStyle.SelectionForeColor = Color.Black;
					this.gdv_statisctics.RowsDefaultCellStyle.BackColor = Color.LightGray;
					this.gdv_statisctics.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
					this.gdv_statisctics.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					this.gdv_statisctics.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_statisctics.RowHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_statisctics.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_statisctics.DefaultCellStyle.SelectionForeColor = Color.Black;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}

		private void ToCsV(DataGridView dGV, string filename)
		{
			string stOutput = "";
			string sHeaders = "";
			for (int j = 0; j < dGV.Columns.Count; j++)
			{
				sHeaders = string.Concat(sHeaders.ToString(), Convert.ToString(dGV.Columns[j].HeaderText), "\t");
			}
			stOutput = string.Concat(stOutput, sHeaders, "\r\n");
			for (int i = 0; i < dGV.RowCount - 1; i++)
			{
				string stLine = "";
				for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
				{
					stLine = string.Concat(stLine.ToString(), Convert.ToString(dGV.Rows[i].Cells[j].Value), "\t");
				}
				stOutput = string.Concat(stOutput, stLine, "\r\n");
			}
			byte[] output = Encoding.GetEncoding(1254).GetBytes(stOutput);
			FileStream fs = new FileStream(filename, FileMode.Create);
			BinaryWriter bw = new BinaryWriter(fs);
			bw.Write(output, 0, (int)output.Length);
			bw.Flush();
			bw.Close();
			fs.Close();
		}
	}
}