using Guard_profiler.App_code;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_wages_panel : Form
	{
		private IContainer components;

		private Panel panel1;

		private Splitter splitter1;

		private Button btn_deployment_summary;

		private Button btn_deploy_guards_batch;

		private Button btn_other_data;

		private Splitter splitter2;

		private Button btn_public_holidays;

		private Button btn_fire_arms;

		private Button btnActiveDeployment;

		private Label label1;

		private Button btn_lst;

		private Label label2;

		private Button btn_deployment_periods;

		private Label label3;

		private Button btnreport;

		private Button btnclientreport;
        private Button btndeploymentschedule;
        private Button btn_clients;
        private Button btnguard_clientreport;

		public frm_wages_panel()
		{
			this.InitializeComponent();
		}

		private void btn_clients_Click(object sender, EventArgs e)
		{
			(new frm_manage_clients()).Show();
		}

		private void btn_deploy_guards_batch_Click(object sender, EventArgs e)
		{
			(new frm_guard_deployment_summary_batch()).Show();
		}

		private void btn_deployment_periods_Click(object sender, EventArgs e)
		{
			(new frm_deployment_periods()).ShowDialog();
		}

		private void btn_deployment_summary_Click(object sender, EventArgs e)
		{
			(new frm_guard_deployment_summary()).Show();
		}

		private void btn_other_data_Click(object sender, EventArgs e)
		{
			(new frm_guard_deployment_additional_data()).Show();
		}

		private void btn_public_holidays_Click(object sender, EventArgs e)
		{
			(new frm_manage_public_holidays()).ShowDialog();
		}

		private void btnclientreport_Click(object sender, EventArgs e)
		{
			(new frm_clients_guards_mapping_report_selector()).ShowDialog();
		}

		private void btnguard_clientreport_Click(object sender, EventArgs e)
		{
			(new frm_deployment_guard_client_mapping_report_selector()).ShowDialog();
		}

		private void btnreport_Click(object sender, EventArgs e)
		{
			SystemConst._finance_report_type = "Deployment summary report";
			(new frm_finance_reports_parameter_selector()).ShowDialog();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_wages_panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndeploymentschedule = new System.Windows.Forms.Button();
            this.btnguard_clientreport = new System.Windows.Forms.Button();
            this.btnclientreport = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btn_deployment_periods = new System.Windows.Forms.Button();
            this.btn_lst = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btnActiveDeployment = new System.Windows.Forms.Button();
            this.btn_fire_arms = new System.Windows.Forms.Button();
            this.btn_public_holidays = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_other_data = new System.Windows.Forms.Button();
            this.btn_deploy_guards_batch = new System.Windows.Forms.Button();
            this.btn_deployment_summary = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btndeploymentschedule);
            this.panel1.Controls.Add(this.btnguard_clientreport);
            this.panel1.Controls.Add(this.btnclientreport);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btn_deployment_periods);
            this.panel1.Controls.Add(this.btn_lst);
            this.panel1.Controls.Add(this.btn_clients);
            this.panel1.Controls.Add(this.btnActiveDeployment);
            this.panel1.Controls.Add(this.btn_fire_arms);
            this.panel1.Controls.Add(this.btn_public_holidays);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_other_data);
            this.panel1.Controls.Add(this.btn_deploy_guards_batch);
            this.panel1.Controls.Add(this.btn_deployment_summary);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 377);
            this.panel1.TabIndex = 1;
            // 
            // btndeploymentschedule
            // 
            this.btndeploymentschedule.ForeColor = System.Drawing.Color.Blue;
            this.btndeploymentschedule.Location = new System.Drawing.Point(419, 186);
            this.btndeploymentschedule.Margin = new System.Windows.Forms.Padding(4);
            this.btndeploymentschedule.Name = "btndeploymentschedule";
            this.btndeploymentschedule.Size = new System.Drawing.Size(319, 55);
            this.btndeploymentschedule.TabIndex = 15;
            this.btndeploymentschedule.Text = "Guard Deployment Schedule Report";
            this.btndeploymentschedule.UseVisualStyleBackColor = true;
            this.btndeploymentschedule.Click += new System.EventHandler(this.btndeploymentschedule_Click);
            // 
            // btnguard_clientreport
            // 
            this.btnguard_clientreport.ForeColor = System.Drawing.Color.Blue;
            this.btnguard_clientreport.Location = new System.Drawing.Point(419, 124);
            this.btnguard_clientreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnguard_clientreport.Name = "btnguard_clientreport";
            this.btnguard_clientreport.Size = new System.Drawing.Size(319, 55);
            this.btnguard_clientreport.TabIndex = 14;
            this.btnguard_clientreport.Text = "Guard--->Client Mapping Report";
            this.btnguard_clientreport.UseVisualStyleBackColor = true;
            this.btnguard_clientreport.Click += new System.EventHandler(this.btnguard_clientreport_Click);
            // 
            // btnclientreport
            // 
            this.btnclientreport.ForeColor = System.Drawing.Color.Red;
            this.btnclientreport.Location = new System.Drawing.Point(419, 62);
            this.btnclientreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnclientreport.Name = "btnclientreport";
            this.btnclientreport.Size = new System.Drawing.Size(319, 55);
            this.btnclientreport.TabIndex = 13;
            this.btnclientreport.Text = "Client - Guard Mapping Report";
            this.btnclientreport.UseVisualStyleBackColor = true;
            this.btnclientreport.Click += new System.EventHandler(this.btnclientreport_Click);
            // 
            // btnreport
            // 
            this.btnreport.ForeColor = System.Drawing.Color.Blue;
            this.btnreport.Location = new System.Drawing.Point(419, 4);
            this.btnreport.Margin = new System.Windows.Forms.Padding(4);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(319, 55);
            this.btnreport.TabIndex = 12;
            this.btnreport.Text = "Deployment summary report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btn_deployment_periods
            // 
            this.btn_deployment_periods.Location = new System.Drawing.Point(216, 4);
            this.btn_deployment_periods.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deployment_periods.Name = "btn_deployment_periods";
            this.btn_deployment_periods.Size = new System.Drawing.Size(195, 55);
            this.btn_deployment_periods.TabIndex = 11;
            this.btn_deployment_periods.Text = "Manage Deployment Periods";
            this.btn_deployment_periods.UseVisualStyleBackColor = true;
            this.btn_deployment_periods.Click += new System.EventHandler(this.btn_deployment_periods_Click);
            // 
            // btn_lst
            // 
            this.btn_lst.Enabled = false;
            this.btn_lst.Location = new System.Drawing.Point(216, 311);
            this.btn_lst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lst.Name = "btn_lst";
            this.btn_lst.Size = new System.Drawing.Size(195, 55);
            this.btn_lst.TabIndex = 10;
            this.btn_lst.Text = "Manage guard Local Service Tax payments";
            this.btn_lst.UseVisualStyleBackColor = true;
            // 
            // btn_clients
            // 
            this.btn_clients.Enabled = false;
            this.btn_clients.Location = new System.Drawing.Point(216, 249);
            this.btn_clients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(195, 55);
            this.btn_clients.TabIndex = 9;
            this.btn_clients.Text = "Manage Client(Customer) data";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btnActiveDeployment
            // 
            this.btnActiveDeployment.Location = new System.Drawing.Point(216, 186);
            this.btnActiveDeployment.Margin = new System.Windows.Forms.Padding(4);
            this.btnActiveDeployment.Name = "btnActiveDeployment";
            this.btnActiveDeployment.Size = new System.Drawing.Size(195, 55);
            this.btnActiveDeployment.TabIndex = 8;
            this.btnActiveDeployment.Text = "My Active Deployment";
            this.btnActiveDeployment.UseVisualStyleBackColor = true;
            this.btnActiveDeployment.Click += new System.EventHandler(this.btn_fire_arm_guard_assign_Click);
            // 
            // btn_fire_arms
            // 
            this.btn_fire_arms.Enabled = false;
            this.btn_fire_arms.Location = new System.Drawing.Point(216, 127);
            this.btn_fire_arms.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fire_arms.Name = "btn_fire_arms";
            this.btn_fire_arms.Size = new System.Drawing.Size(195, 55);
            this.btn_fire_arms.TabIndex = 7;
            this.btn_fire_arms.Text = "Manage fire arms";
            this.btn_fire_arms.UseVisualStyleBackColor = true;
            // 
            // btn_public_holidays
            // 
            this.btn_public_holidays.Location = new System.Drawing.Point(216, 63);
            this.btn_public_holidays.Margin = new System.Windows.Forms.Padding(4);
            this.btn_public_holidays.Name = "btn_public_holidays";
            this.btn_public_holidays.Size = new System.Drawing.Size(195, 55);
            this.btn_public_holidays.TabIndex = 6;
            this.btn_public_holidays.Text = "Manage Public Hoildays";
            this.btn_public_holidays.UseVisualStyleBackColor = true;
            this.btn_public_holidays.Click += new System.EventHandler(this.btn_public_holidays_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(207, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(207, 377);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // btn_other_data
            // 
            this.btn_other_data.Location = new System.Drawing.Point(4, 126);
            this.btn_other_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_other_data.Name = "btn_other_data";
            this.btn_other_data.Size = new System.Drawing.Size(195, 55);
            this.btn_other_data.TabIndex = 3;
            this.btn_other_data.Text = "Guard additional monthly data";
            this.btn_other_data.UseVisualStyleBackColor = true;
            this.btn_other_data.Click += new System.EventHandler(this.btn_other_data_Click);
            // 
            // btn_deploy_guards_batch
            // 
            this.btn_deploy_guards_batch.Location = new System.Drawing.Point(4, 63);
            this.btn_deploy_guards_batch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deploy_guards_batch.Name = "btn_deploy_guards_batch";
            this.btn_deploy_guards_batch.Size = new System.Drawing.Size(195, 55);
            this.btn_deploy_guards_batch.TabIndex = 2;
            this.btn_deploy_guards_batch.Text = "Grouped Deploy";
            this.btn_deploy_guards_batch.UseVisualStyleBackColor = true;
            this.btn_deploy_guards_batch.Click += new System.EventHandler(this.btn_deploy_guards_batch_Click);
            // 
            // btn_deployment_summary
            // 
            this.btn_deployment_summary.Location = new System.Drawing.Point(4, 4);
            this.btn_deployment_summary.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deployment_summary.Name = "btn_deployment_summary";
            this.btn_deployment_summary.Size = new System.Drawing.Size(195, 55);
            this.btn_deployment_summary.TabIndex = 1;
            this.btn_deployment_summary.Text = "Guard Deployment";
            this.btn_deployment_summary.UseVisualStyleBackColor = true;
            this.btn_deployment_summary.Click += new System.EventHandler(this.btn_deployment_summary_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.PowderBlue;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(207, 377);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deployment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin Lookups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reports";
            // 
            // frm_wages_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_wages_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Securiko Uganda Ltd-Wage Managemet";
            this.Load += new System.EventHandler(this.frm_wages_panel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private void btndeploymentschedule_Click(object sender, EventArgs e)
        {
            frmDeploymentscheduleReport report = new frmDeploymentscheduleReport();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDeployguards_single r = new frmDeployguards_single();
            r.Show();
        }

        private void frm_wages_panel_Load(object sender, EventArgs e)
        {
            setDeploymentPeriod();
        }

        protected void setDeploymentPeriod()
        {
            if (SystemConst._active_deployment_id == string.Empty)
            {
                MessageBox.Show("You havent set any deployment period yet.You will not be able to deploy any guards if you haven't set a deployment period.You can do this from your active deployments panel.", "Message Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnActiveDeployment.ForeColor = Color.Red;
            }
            else
            {
                btnActiveDeployment.ForeColor = Color.Black;
            }
        }

        private void btn_fire_arm_guard_assign_Click(object sender, EventArgs e)
        {
            frmMyActiveDeployment fnew = new frmMyActiveDeployment();
            fnew.ShowDialog();
        }
    }
}