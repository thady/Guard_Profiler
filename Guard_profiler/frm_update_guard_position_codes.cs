using Guard_profiler.App_code;
using Guard_profiler.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_update_guard_position_codes : Form
	{
		private IContainer components;

		private Panel panel_main;

		private PictureBox pictureBox1;

		private Button btn_execute;

		private Panel panel2;

		public frm_update_guard_position_codes()
		{
			this.InitializeComponent();
		}

		private void btn_execute_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("This might take longer depending on the number of officers in the system,proceed", "Assign Position Codes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != System.Windows.Forms.DialogResult.Yes)
			{
				if (dialogResult == System.Windows.Forms.DialogResult.No)
				{
					base.Visible = true;
				}
				return;
			}
			this.Cursor = Cursors.AppStarting;
			base.Enabled = false;
			this.UPDATE_GUARD_POSITION_CODES();
			base.Enabled = true;
			MessageBox.Show("All guard positions assignment completed", "Assign Position Codes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

		private void frm_update_guard_position_codes_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_update_guard_position_codes));
			this.panel_main = new Panel();
			this.pictureBox1 = new PictureBox();
			this.btn_execute = new Button();
			this.panel2 = new Panel();
			this.panel_main.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel_main.BackColor = SystemColors.ButtonFace;
			this.panel_main.Controls.Add(this.panel2);
			this.panel_main.Controls.Add(this.pictureBox1);
			this.panel_main.Location = new Point(2, 1);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(472, 232);
			this.panel_main.TabIndex = 0;
			this.pictureBox1.Image = Resources.arrrrr;
			this.pictureBox1.Location = new Point(212, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 79);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.btn_execute.BackColor = Color.FromArgb(128, 255, 255);
			this.btn_execute.Location = new Point(3, 2);
			this.btn_execute.Name = "btn_execute";
			this.btn_execute.Size = new System.Drawing.Size(247, 81);
			this.btn_execute.TabIndex = 0;
			this.btn_execute.Text = "EXECUTE POSITION CODE ASSIGNMENTS";
			this.btn_execute.UseVisualStyleBackColor = false;
			this.btn_execute.Click += new EventHandler(this.btn_execute_Click);
			this.panel2.BackColor = Color.Yellow;
			this.panel2.Controls.Add(this.btn_execute);
			this.panel2.Location = new Point(135, 96);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(253, 85);
			this.panel2.TabIndex = 2;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Yellow;
			base.ClientSize = new System.Drawing.Size(475, 236);
			base.Controls.Add(this.panel_main);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_update_guard_position_codes";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Assign Position Codes";
			base.Load += new EventHandler(this.frm_update_guard_position_codes_Load);
			this.panel_main.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		protected void UPDATE_GUARD_POSITION_CODES()
		{
			DataTable dt = Position_Codes.SELECT_GUARD_NUMBER_LIST("SELECT_GUARD_NUMBER_LIST");
			if (dt.Rows.Count != 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					string guard_number = (string)dt.Rows[i]["guard_number"];
					if (guard_number.Contains("CG") && !guard_number.Contains("SCG"))
					{
						Position_Codes.UPDATE_POSITION_CODE("UPDATE_CG_CODE", guard_number);
					}
					else if (guard_number.Contains("RG"))
					{
						Position_Codes.UPDATE_POSITION_CODE("UPDATE_RG_CODE", guard_number);
					}
					else if (guard_number.Contains("SCG"))
					{
						Position_Codes.UPDATE_POSITION_CODE("UPDATE_SCG_CODE", guard_number);
					}
				}
			}
		}
	}
}