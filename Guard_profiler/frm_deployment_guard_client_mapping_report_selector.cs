using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

using System.Data;

namespace Guard_profiler
{
	public class frm_deployment_guard_client_mapping_report_selector : Form
	{
		private IContainer components;

		private Panel panel1;

		private Button btnreport;

		private Label label3;

		private Label label2;

		private DateTimePicker dt_end_date;

		private DateTimePicker dt_start_date;

		private Label label1;
        private ComboBox cbo_guard_name;

		public frm_deployment_guard_client_mapping_report_selector()
		{
			this.InitializeComponent();
		}

		private void btnreport_Click(object sender, EventArgs e)
		{
			if (cbo_guard_name.SelectedValue.ToString() == string.Empty || !this.dt_start_date.Checked || !this.dt_end_date.Checked)
			{
				MessageBox.Show("All values are required", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
            SystemConst.guard_number = cbo_guard_name.SelectedValue.ToString();
			SystemConst._deployment_start_date = this.dt_start_date.Value.Date;
			SystemConst._deployment_end_date = this.dt_end_date.Value.Date;
			SystemConst._finance_crystal_report_type = "GUARD";
			(new frm_finance_detailed_guard_pay_roll_report()).Show();
		}


        protected void GET_ACTIVE_GUARDS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_LIST_OF_ACTIVE_GUARDS");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["full_name"] = string.Empty;
                dtRow["guard_number"] = string.Empty;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbo_guard_name.DataSource = dt;
                this.cbo_guard_name.DisplayMember = "full_name";
                this.cbo_guard_name.ValueMember = "guard_number";

                this.cbo_guard_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbo_guard_name.AutoCompleteSource = AutoCompleteSource.ListItems;
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

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_deployment_guard_client_mapping_report_selector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_guard_name = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.cbo_guard_name);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dt_end_date);
            this.panel1.Controls.Add(this.dt_start_date);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 258);
            this.panel1.TabIndex = 1;
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(118, 161);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(146, 31);
            this.btnreport.TabIndex = 7;
            this.btnreport.Text = "Generate Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select a guard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "End date";
            // 
            // dt_end_date
            // 
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(24, 85);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(205, 20);
            this.dt_end_date.TabIndex = 3;
            // 
            // dt_start_date
            // 
            this.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start_date.Location = new System.Drawing.Point(24, 43);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(202, 20);
            this.dt_start_date.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start date";
            // 
            // cbo_guard_name
            // 
            this.cbo_guard_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_guard_name.FormattingEnabled = true;
            this.cbo_guard_name.Location = new System.Drawing.Point(24, 127);
            this.cbo_guard_name.Name = "cbo_guard_name";
            this.cbo_guard_name.Size = new System.Drawing.Size(324, 28);
            this.cbo_guard_name.TabIndex = 9;
            // 
            // frm_deployment_guard_client_mapping_report_selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_deployment_guard_client_mapping_report_selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deployment Reporting";
            this.Load += new System.EventHandler(this.frm_deployment_guard_client_mapping_report_selector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        private void frm_deployment_guard_client_mapping_report_selector_Load(object sender, EventArgs e)
        {
            GET_ACTIVE_GUARDS();
        }
    }
}