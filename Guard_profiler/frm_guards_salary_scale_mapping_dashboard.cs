using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_guards_salary_scale_mapping_dashboard : Form
	{
		private IContainer components;

		private Panel panel1;
        private ReSize reSize1;
        private DataGridView gdv_guard_salaries;

		//private ReSize reSize1;

		public frm_guards_salary_scale_mapping_dashboard()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_guards_salary_scale_mapping_dashboard_Load(object sender, EventArgs e)
		{
			this.Return_guard_salary_mappings();
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guards_salary_scale_mapping_dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdv_guard_salaries = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.gdv_guard_salaries);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 508);
            this.panel1.TabIndex = 0;
            // 
            // gdv_guard_salaries
            // 
            this.gdv_guard_salaries.AllowUserToAddRows = false;
            this.gdv_guard_salaries.AllowUserToDeleteRows = false;
            this.gdv_guard_salaries.AllowUserToResizeColumns = false;
            this.gdv_guard_salaries.AllowUserToResizeRows = false;
            this.gdv_guard_salaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guard_salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guard_salaries.Location = new System.Drawing.Point(9, 21);
            this.gdv_guard_salaries.Name = "gdv_guard_salaries";
            this.gdv_guard_salaries.ReadOnly = true;
            this.gdv_guard_salaries.Size = new System.Drawing.Size(648, 473);
            this.gdv_guard_salaries.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 521D;
            this.reSize1.InitialHostContainerWidth = 667D;
            this.reSize1.Tag = null;
            // 
            // frm_guards_salary_scale_mapping_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_guards_salary_scale_mapping_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guards Salaries";
            this.Load += new System.EventHandler(this.frm_guards_salary_scale_mapping_dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).EndInit();
            this.ResumeLayout(false);

		}

		protected void Return_guard_salary_mappings()
		{
			DataTable dt = Salary_scales.return_guard_salary_mappings("return_guard_salary_mappings");
			if (dt.Rows.Count > 0)
			{
				this.gdv_guard_salaries.DataSource = dt;
				this.gdv_guard_salaries.Columns[0].HeaderText = "Guard Name";
				this.gdv_guard_salaries.Columns[1].HeaderText = "Branch";
				this.gdv_guard_salaries.Columns[2].HeaderText = "Duration Served(Years):0 Means Less than a year";
				this.gdv_guard_salaries.Columns[3].HeaderText = "Posible Salary Scale";
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				this.gdv_guard_salaries.RowsDefaultCellStyle.BackColor = Color.LightGray;
				this.gdv_guard_salaries.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.RowHeadersDefaultCellStyle.BackColor = Color.Black;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
				this.gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;
				foreach (DataGridViewColumn c in this.gdv_guard_salaries.Columns)
				{
					c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12.5f, GraphicsUnit.Pixel);
				}
				this.gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
				this.gdv_guard_salaries.EnableHeadersVisualStyles = false;
			}
		}
	}
}