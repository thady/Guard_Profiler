using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_edit_guard_number : Form
	{
		private IContainer components;

		private Panel panel1;

		public frm_edit_guard_number()
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

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frm_edit_guard_number));
			this.panel1 = new Panel();
			base.SuspendLayout();
			this.panel1.BackColor = Color.Azure;
			this.panel1.Location = new Point(2, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(637, 407);
			this.panel1.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(255, 255, 192);
			base.ClientSize = new System.Drawing.Size(641, 413);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "frm_edit_guard_number";
			this.Text = "Change Guard Number";
			base.ResumeLayout(false);
		}
	}
}