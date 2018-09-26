using Guard_profiler.App_code;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class update_first_last_names : Form
	{
		private IContainer components;

		private DataGridView gdv_guards;

		private Button btnupdate;

		private Button button1;

		public update_first_last_names()
		{
			this.InitializeComponent();
		}

		private void btnupdate_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.gdv_guards.Rows.Count - 1; i++)
			{
				int auto_id = Convert.ToInt32(this.gdv_guards.Rows[i].Cells[0].Value.ToString());
				this.Cursor = Cursors.AppStarting;
				sg_Profiles.UPDATE_GUARD_FIRST_LAST_NAME("UPDATE_GUARD_FIRST_LAST_NAME", auto_id, this.gdv_guards.Rows[i].Cells[1].Value.ToString(), this.gdv_guards.Rows[i].Cells[2].Value.ToString());
				this.Cursor = Cursors.Default;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.AppStarting;
			this.UPDATE_GUARD_IMAGES();
			this.Cursor = Cursors.Default;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.gdv_guards = new DataGridView();
			this.btnupdate = new Button();
			this.button1 = new Button();
			((ISupportInitialize)this.gdv_guards).BeginInit();
			base.SuspendLayout();
			this.gdv_guards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdv_guards.Location = new Point(23, 129);
			this.gdv_guards.Name = "gdv_guards";
			this.gdv_guards.Size = new System.Drawing.Size(712, 438);
			this.gdv_guards.TabIndex = 0;
			this.btnupdate.Location = new Point(23, 81);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(75, 23);
			this.btnupdate.TabIndex = 1;
			this.btnupdate.Text = "Update Names";
			this.btnupdate.UseVisualStyleBackColor = true;
			this.btnupdate.Click += new EventHandler(this.btnupdate_Click);
			this.button1.Location = new Point(170, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Update Images";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1033, 579);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnupdate);
			base.Controls.Add(this.gdv_guards);
			base.Name = "update_first_last_names";
			this.Text = "update_first_last_names";
			base.Load += new EventHandler(this.update_first_last_names_Load);
			((ISupportInitialize)this.gdv_guards).EndInit();
			base.ResumeLayout(false);
		}

		private void update_first_last_names_Load(object sender, EventArgs e)
		{
			DataTable dt = sg_Profiles.SELECT_GUARD_F_L_NAMES("SELECT_GUARD_F_L_NAMES");
			this.gdv_guards.DataSource = dt;
		}

		protected void UPDATE_GUARD_IMAGES()
		{
			string guard_number = string.Empty;
			byte[] data = null;
			foreach (DataRow dtRow in sg_Profiles.SELECT_GUARD_F_L_NAMES("SELECT_IMAGES_IMPORTED_FROM_ACCESS").Rows)
			{
				if (dtRow["photo"] != DBNull.Value)
				{
					data = (byte[])dtRow["photo"];
				}
				if (dtRow["guard_num"] != DBNull.Value)
				{
					guard_number = (string)dtRow["guard_num"];
				}
				if (!(guard_number != string.Empty) || dtRow["photo"] == DBNull.Value)
				{
					continue;
				}
				sg_Profiles.UPDATE_IMAGES_FROM_ACCESS("UPDATE_IMAGES_FROM_ACCESS", guard_number, data);
			}
		}
	}
}