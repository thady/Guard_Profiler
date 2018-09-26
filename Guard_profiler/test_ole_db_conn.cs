using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class test_ole_db_conn : Form
	{
		private IContainer components;

		private Button button1;

		public test_ole_db_conn()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.get_conn();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		protected void get_conn()
		{
			DataTable dt = new DataTable();
			OleDbCommand cmd = new OleDbCommand()
			{
				CommandText = "SELECT LabNo FROM Specimens WHERE SerNo = 21730"
			};
			OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=M:\\LIMS\\HRL2013.mdb;");
			try
			{
				cnn.Open();
				cmd.Connection = cnn;
				(new OleDbDataAdapter(cmd)).Fill(dt);
				if (dt.Rows.Count > 0)
				{
					DataRow dtRow = dt.Rows[0];
					int labno = Convert.ToInt32(dtRow["LabNo"]);
					MessageBox.Show(labno.ToString());
				}
				cnn.Close();
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		private void InitializeComponent()
		{
			this.button1 = new Button();
			base.SuspendLayout();
			this.button1.Location = new Point(126, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(284, 261);
			base.Controls.Add(this.button1);
			base.Name = "test_ole_db_conn";
			this.Text = "test_ole_db_conn";
			base.Load += new EventHandler(this.test_ole_db_conn_Load);
			base.ResumeLayout(false);
		}

		private void test_ole_db_conn_Load(object sender, EventArgs e)
		{
		}
	}
}