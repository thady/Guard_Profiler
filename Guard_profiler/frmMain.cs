using Guard_profiler.App_code;
using Guard_profiler.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frmMain : Form
	{
		private Timer t;

		private IContainer components;

		private Panel panel1;

		private ToolStripMenuItem toolstrip_hr;

		private ToolStripMenuItem toolstrip_admin;

		private Button btnLogOut;

		private ToolStripMenuItem manageUsersToolStripMenuItem;

		private ToolStripMenuItem manageDepartmentsBranchesPositionsToolStripMenuItem;

		private Panel panel_user;

		private Label lbl_name_message;

		private Panel panel2;

		private RichTextBox richTextBox1;

		private Panel panel3;

		private Label lbl_user_session_name;

		private Label lbl_clock;

		private Label label1;

		private ToolStripMenuItem toolstripreports;

		private ToolStripMenuItem activeGuardsByBranchReportToolStripMenuItem;

		private ToolStripMenuItem allGuardsReportToolStripMenuItem;

		private ToolStripMenuItem toolStripMenuItem3;

		private ToolStripMenuItem archievedGuardsReportsToolStripMenuItem;

		private ToolStripMenuItem updatePositionCodesToolStripMenuItem;

		private ToolStripMenuItem toolstrip_accounts;

		private ToolStripMenuItem guardProfilesToolStripMenuItem1;

		private ToolStripMenuItem nonGuardProfilesToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator10;

		private ToolStripSeparator toolStripSeparator9;

		private ToolStripSeparator toolStripSeparator8;

		private ToolStripSeparator toolStripSeparator11;

		private ToolStripSeparator toolStripSeparator12;

		private ToolStripMenuItem toolstrip_wages;

		private Button btnhr;

		private Button btnwages;

		private Button btnaccounts;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolstripHumanResource;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ToolstripWages;
        private ToolStripMenuItem ToolstripAccounts;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem toolstripManageUsers;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem13;
        private Button btnFinance;
        private Panel panelLicence;
        private Label lblClient;
        private Panel panel4;

        private int xpos = 0, ypos = 0;
        private Timer timer1;
        private Panel panel5;
        private Button btnInventory;
        private Button btnCanine;
        private Button btnCommunication;
        private Button button4;
        private Button btnProcurement;
        private Button button5;
        private Button btnVip;
        private Button btnCashTransit;
        public string mode = "Left-to-Right";

        public frmMain()
		{
			this.InitializeComponent();
		}

		private void activeGuardsByBranchReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_guard_lists()).ShowDialog();
		}

		private void activeGuardsReportsByBranchToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void allGuardsReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_sg_list_report()).ShowDialog();
		}

		private void archievedGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_archieve_lists()).ShowDialog();
		}

		private void btnaccounts_Click(object sender, EventArgs e)
		{
			(new frm_accounts_panel()).ShowDialog();
		}

		private void btnhr_Click(object sender, EventArgs e)
		{
			(new frm_hr_panel()).ShowDialog();
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("For security purposes,the system will exit.All unsaved changes may be lost,proceed??", "LogOut", MessageBoxButtons.YesNo);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				Application.Exit();
				(new frmLogin()).ShowDialog();
				return;
			}
			if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				base.Visible = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new frmcrystal_report_single()).Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			(new update_first_last_names()).Show();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			(new test_ole_db_conn()).Show();
		}

		private void button1_Click_3(object sender, EventArgs e)
		{
			(new frm_wages_panel()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            this.Text = SystemConst.ClientName + " Guard Management System V.2";
            lblClient.Text = SystemConst.ClientName + " Guard Management System V.2" + "  For quick help please call 0704098505 or 0705119900";
            base.Visible = true;
			base.WindowState = FormWindowState.Maximized;
			(new frmLogin()).ShowDialog();
			//this.Set_current_deployment_periods();
            Set_user_access_permissions();
            Blink();
        }

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                lblClient.BackColor = lblClient.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }

        private void frmMain_MouseHover(object sender, EventArgs e)
		{
			this.WELCOME_GREET_USER();
			this.StartTimer();
		}

		private void guardProfilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_hr_panel()).ShowDialog();
		}

		private void guardProfilesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			(new sg_profiles()).Show();
		}

		private void guardsSalaryScaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_salary_scale_guards()).ShowDialog();
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnhr = new System.Windows.Forms.Button();
            this.btnwages = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnaccounts = new System.Windows.Forms.Button();
            this.panelLicence = new System.Windows.Forms.Panel();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name_message = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.lbl_user_session_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.guardProfilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nonGuardProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeGuardsByBranchReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.allGuardsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.archievedGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.manageDepartmentsBranchesPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.updatePositionCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolstripHumanResource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolstripWages = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolstripAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripManageUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolstrip_hr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_wages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_accounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripreports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCanine = new System.Windows.Forms.Button();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.btnProcurement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnVip = new System.Windows.Forms.Button();
            this.btnCashTransit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelLicence.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelLicence);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 674);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCashTransit);
            this.panel5.Controls.Add(this.btnVip);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.btnProcurement);
            this.panel5.Controls.Add(this.btnCommunication);
            this.panel5.Controls.Add(this.btnCanine);
            this.panel5.Controls.Add(this.btnInventory);
            this.panel5.Controls.Add(this.btnhr);
            this.panel5.Controls.Add(this.btnwages);
            this.panel5.Controls.Add(this.btnFinance);
            this.panel5.Controls.Add(this.btnaccounts);
            this.panel5.Location = new System.Drawing.Point(3, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1335, 148);
            this.panel5.TabIndex = 12;
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(477, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(238, 70);
            this.btnInventory.TabIndex = 11;
            this.btnInventory.Text = "Inventory Management";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnhr
            // 
            this.btnhr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhr.Image = ((System.Drawing.Image)(resources.GetObject("btnhr.Image")));
            this.btnhr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhr.Location = new System.Drawing.Point(3, 1);
            this.btnhr.Name = "btnhr";
            this.btnhr.Size = new System.Drawing.Size(238, 70);
            this.btnhr.TabIndex = 5;
            this.btnhr.Text = "Human Resources";
            this.btnhr.UseVisualStyleBackColor = true;
            this.btnhr.Click += new System.EventHandler(this.btnhr_Click);
            // 
            // btnwages
            // 
            this.btnwages.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwages.Location = new System.Drawing.Point(3, 71);
            this.btnwages.Name = "btnwages";
            this.btnwages.Size = new System.Drawing.Size(238, 70);
            this.btnwages.TabIndex = 6;
            this.btnwages.Text = "Wages and Deployments";
            this.btnwages.UseVisualStyleBackColor = true;
            this.btnwages.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btnFinance
            // 
            this.btnFinance.Enabled = false;
            this.btnFinance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.Location = new System.Drawing.Point(240, 71);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(238, 70);
            this.btnFinance.TabIndex = 10;
            this.btnFinance.Text = "Customer Management";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnaccounts
            // 
            this.btnaccounts.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnaccounts.Image")));
            this.btnaccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccounts.Location = new System.Drawing.Point(240, 1);
            this.btnaccounts.Name = "btnaccounts";
            this.btnaccounts.Size = new System.Drawing.Size(238, 70);
            this.btnaccounts.TabIndex = 7;
            this.btnaccounts.Text = "Accounts Management";
            this.btnaccounts.UseVisualStyleBackColor = true;
            this.btnaccounts.Click += new System.EventHandler(this.btnaccounts_Click);
            // 
            // panelLicence
            // 
            this.panelLicence.BackColor = System.Drawing.Color.Black;
            this.panelLicence.Controls.Add(this.lblClient);
            this.panelLicence.Location = new System.Drawing.Point(-2, 640);
            this.panelLicence.Name = "panelLicence";
            this.panelLicence.Size = new System.Drawing.Size(1345, 32);
            this.panelLicence.TabIndex = 11;
            // 
            // lblClient
            // 
            this.lblClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(378, 11);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(38, 15);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "label2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.panel_user);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1335, 78);
            this.panel4.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(417, 64);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Advanced Guard Security Management Software Systems.Designed by Skytel\nsoftware s" +
    "ystems Inc\nFor quick help contact : 0704098505/0705119900.";
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.Black;
            this.panel_user.Controls.Add(this.label1);
            this.panel_user.Controls.Add(this.lbl_name_message);
            this.panel_user.Location = new System.Drawing.Point(426, 3);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(266, 65);
            this.panel_user.TabIndex = 1;
            this.panel_user.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are logged in";
            // 
            // lbl_name_message
            // 
            this.lbl_name_message.AutoSize = true;
            this.lbl_name_message.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_message.ForeColor = System.Drawing.Color.White;
            this.lbl_name_message.Location = new System.Drawing.Point(6, 3);
            this.lbl_name_message.Name = "lbl_name_message";
            this.lbl_name_message.Size = new System.Drawing.Size(144, 20);
            this.lbl_name_message.TabIndex = 0;
            this.lbl_name_message.Text = "lbl_name_message";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.lbl_clock);
            this.panel3.Controls.Add(this.lbl_user_session_name);
            this.panel3.Location = new System.Drawing.Point(698, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 65);
            this.panel3.TabIndex = 4;
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.ForeColor = System.Drawing.Color.White;
            this.lbl_clock.Location = new System.Drawing.Point(9, 30);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(58, 14);
            this.lbl_clock.TabIndex = 1;
            this.lbl_clock.Text = "Waiting.....";
            // 
            // lbl_user_session_name
            // 
            this.lbl_user_session_name.AutoSize = true;
            this.lbl_user_session_name.ForeColor = System.Drawing.Color.White;
            this.lbl_user_session_name.Location = new System.Drawing.Point(9, 10);
            this.lbl_user_session_name.Name = "lbl_user_session_name";
            this.lbl_user_session_name.Size = new System.Drawing.Size(67, 14);
            this.lbl_user_session_name.TabIndex = 0;
            this.lbl_user_session_name.Text = "User Session:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(1179, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 52);
            this.panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guardProfilesToolStripMenuItem1
            // 
            this.guardProfilesToolStripMenuItem1.Name = "guardProfilesToolStripMenuItem1";
            this.guardProfilesToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.guardProfilesToolStripMenuItem1.Text = "Guard Profiles";
            this.guardProfilesToolStripMenuItem1.Click += new System.EventHandler(this.guardProfilesToolStripMenuItem1_Click);
            // 
            // nonGuardProfilesToolStripMenuItem
            // 
            this.nonGuardProfilesToolStripMenuItem.Name = "nonGuardProfilesToolStripMenuItem";
            this.nonGuardProfilesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.nonGuardProfilesToolStripMenuItem.Text = "Other Staff Profiles";
            this.nonGuardProfilesToolStripMenuItem.Click += new System.EventHandler(this.nonGuardProfilesToolStripMenuItem_Click);
            // 
            // activeGuardsByBranchReportToolStripMenuItem
            // 
            this.activeGuardsByBranchReportToolStripMenuItem.Name = "activeGuardsByBranchReportToolStripMenuItem";
            this.activeGuardsByBranchReportToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.activeGuardsByBranchReportToolStripMenuItem.Text = "Active Guards by Branch Reports";
            this.activeGuardsByBranchReportToolStripMenuItem.Click += new System.EventHandler(this.activeGuardsByBranchReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(304, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem3.Text = "Kampala Guards Reports";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(304, 6);
            // 
            // allGuardsReportToolStripMenuItem
            // 
            this.allGuardsReportToolStripMenuItem.Name = "allGuardsReportToolStripMenuItem";
            this.allGuardsReportToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.allGuardsReportToolStripMenuItem.Text = "All Guards Report";
            this.allGuardsReportToolStripMenuItem.Click += new System.EventHandler(this.allGuardsReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(304, 6);
            // 
            // archievedGuardsReportsToolStripMenuItem
            // 
            this.archievedGuardsReportsToolStripMenuItem.Name = "archievedGuardsReportsToolStripMenuItem";
            this.archievedGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.archievedGuardsReportsToolStripMenuItem.Text = "Archieved Guards Reports";
            this.archievedGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.archievedGuardsReportsToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.manageUsersToolStripMenuItem.Text = "Manage users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(364, 6);
            // 
            // manageDepartmentsBranchesPositionsToolStripMenuItem
            // 
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Name = "manageDepartmentsBranchesPositionsToolStripMenuItem";
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Text = "Manage Departments,Branches & Positions";
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Click += new System.EventHandler(this.manageDepartmentsBranchesPositionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(364, 6);
            // 
            // updatePositionCodesToolStripMenuItem
            // 
            this.updatePositionCodesToolStripMenuItem.Name = "updatePositionCodesToolStripMenuItem";
            this.updatePositionCodesToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.updatePositionCodesToolStripMenuItem.Text = "Update Position Codes";
            this.updatePositionCodesToolStripMenuItem.Click += new System.EventHandler(this.updatePositionCodesToolStripMenuItem_Click);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 741D;
            this.reSize1.InitialHostContainerWidth = 1348D;
            this.reSize1.Tag = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripHumanResource,
            this.ToolstripWages,
            this.ToolstripAccounts,
            this.toolStripMenuItem6,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 61);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Enter += new System.EventHandler(this.menuStrip1_Enter);
            // 
            // ToolstripHumanResource
            // 
            this.ToolstripHumanResource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.ToolstripHumanResource.Name = "ToolstripHumanResource";
            this.ToolstripHumanResource.Size = new System.Drawing.Size(148, 57);
            this.ToolstripHumanResource.Text = "Human Resources";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItem1.Text = "Guard Profiles";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 26);
            this.toolStripMenuItem2.Text = "Other Staff Profiles";
            // 
            // ToolstripWages
            // 
            this.ToolstripWages.Name = "ToolstripWages";
            this.ToolstripWages.Size = new System.Drawing.Size(68, 57);
            this.ToolstripWages.Text = "Wages";
            this.ToolstripWages.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // ToolstripAccounts
            // 
            this.ToolstripAccounts.Name = "ToolstripAccounts";
            this.ToolstripAccounts.Size = new System.Drawing.Size(85, 57);
            this.ToolstripAccounts.Text = "Accounts";
            this.ToolstripAccounts.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripSeparator1,
            this.toolStripMenuItem8,
            this.toolStripSeparator2,
            this.toolStripMenuItem9,
            this.toolStripSeparator3,
            this.toolStripMenuItem10});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(134, 57);
            this.toolStripMenuItem6.Text = "General Reports";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem7.Text = "Active Guards by Branch Reports";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(304, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem8.Text = "Kampala Guards Reports";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem9.Text = "All Guards Report";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(304, 6);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem10.Text = "Archieved Guards Reports";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripManageUsers,
            this.toolStripSeparator4,
            this.toolStripMenuItem12,
            this.toolStripSeparator5,
            this.toolStripMenuItem13});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(68, 57);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // toolstripManageUsers
            // 
            this.toolstripManageUsers.Enabled = false;
            this.toolstripManageUsers.Name = "toolstripManageUsers";
            this.toolstripManageUsers.Size = new System.Drawing.Size(366, 26);
            this.toolstripManageUsers.Text = "Manage users";
            this.toolstripManageUsers.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(363, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(366, 26);
            this.toolStripMenuItem12.Text = "Manage Departments,Branches & Positions";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(363, 6);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(366, 26);
            this.toolStripMenuItem13.Text = "Update Position Codes";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolstrip_hr
            // 
            this.toolstrip_hr.Image = global::Guard_profiler.Properties.Resources.hr_icon;
            this.toolstrip_hr.Name = "toolstrip_hr";
            this.toolstrip_hr.Size = new System.Drawing.Size(164, 62);
            this.toolstrip_hr.Text = "Human Resources";
            this.toolstrip_hr.Click += new System.EventHandler(this.guardProfilesToolStripMenuItem_Click);
            // 
            // toolstrip_wages
            // 
            this.toolstrip_wages.Image = global::Guard_profiler.Properties.Resources.wages;
            this.toolstrip_wages.Name = "toolstrip_wages";
            this.toolstrip_wages.Size = new System.Drawing.Size(85, 62);
            this.toolstrip_wages.Text = "Wages";
            this.toolstrip_wages.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolstrip_accounts
            // 
            this.toolstrip_accounts.Image = global::Guard_profiler.Properties.Resources.accounts;
            this.toolstrip_accounts.Name = "toolstrip_accounts";
            this.toolstrip_accounts.Size = new System.Drawing.Size(101, 62);
            this.toolstrip_accounts.Text = "Accounts";
            this.toolstrip_accounts.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolstripreports
            // 
            this.toolstripreports.Image = global::Guard_profiler.Properties.Resources.reports;
            this.toolstripreports.Name = "toolstripreports";
            this.toolstripreports.Size = new System.Drawing.Size(150, 62);
            this.toolstripreports.Text = "General Reports";
            // 
            // toolstrip_admin
            // 
            this.toolstrip_admin.Image = global::Guard_profiler.Properties.Resources.user_admin_1;
            this.toolstrip_admin.Name = "toolstrip_admin";
            this.toolstrip_admin.Size = new System.Drawing.Size(84, 62);
            this.toolstrip_admin.Text = "Admin";
            // 
            // btnCanine
            // 
            this.btnCanine.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanine.Location = new System.Drawing.Point(477, 71);
            this.btnCanine.Name = "btnCanine";
            this.btnCanine.Size = new System.Drawing.Size(238, 70);
            this.btnCanine.TabIndex = 12;
            this.btnCanine.Text = "Canine Management";
            this.btnCanine.UseVisualStyleBackColor = true;
            // 
            // btnCommunication
            // 
            this.btnCommunication.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommunication.Location = new System.Drawing.Point(714, 3);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(238, 70);
            this.btnCommunication.TabIndex = 13;
            this.btnCommunication.Text = "Communication Department";
            this.btnCommunication.UseVisualStyleBackColor = true;
            // 
            // btnProcurement
            // 
            this.btnProcurement.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurement.Location = new System.Drawing.Point(714, 71);
            this.btnProcurement.Name = "btnProcurement";
            this.btnProcurement.Size = new System.Drawing.Size(238, 70);
            this.btnProcurement.TabIndex = 14;
            this.btnProcurement.Text = "Procurement and Asset Registry";
            this.btnProcurement.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(951, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 70);
            this.button4.TabIndex = 15;
            this.button4.Text = "Fleet Management";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(951, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(238, 70);
            this.button5.TabIndex = 16;
            this.button5.Text = "Inspection and Standard Unit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnVip
            // 
            this.btnVip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVip.Location = new System.Drawing.Point(1188, 3);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(141, 70);
            this.btnVip.TabIndex = 17;
            this.btnVip.Text = "VIP Protection Management";
            this.btnVip.UseVisualStyleBackColor = true;
            // 
            // btnCashTransit
            // 
            this.btnCashTransit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashTransit.Location = new System.Drawing.Point(1188, 71);
            this.btnCashTransit.Name = "btnCashTransit";
            this.btnCashTransit.Size = new System.Drawing.Size(140, 70);
            this.btnCashTransit.TabIndex = 18;
            this.btnCashTransit.Text = "Cash in Transit Management";
            this.btnCashTransit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1348, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO-V.2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseHover += new System.EventHandler(this.frmMain_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelLicence.ResumeLayout(false);
            this.panelLicence.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

		}

		private void leaveManagementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_employment_record()).Show();
		}

		private void manageDepartmentsBranchesPositionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_lookups()).Show();
		}

		private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_users()).ShowDialog();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void menuStrip1_MouseEnter(object sender, EventArgs e)
		{
			if (SystemConst._user_department == "Accounts")
			{
				if (!SystemConst.is_admin)
				{
					this.toolstrip_admin.Enabled = false;
				}
				else
				{
					this.toolstrip_admin.Enabled = true;
				}
				this.ToolstripAccounts.Enabled = true;
				this.ToolstripHumanResource.Enabled = false;
				this.ToolstripWages.Enabled = false;
				this.toolstripreports.Enabled = false;
				this.btnhr.Enabled = false;
				this.btnaccounts.Enabled = true;
				this.btnwages.Enabled = false;
                this.btnFinance.Enabled = false;
                return;
			}
			if (SystemConst._user_department == "Wages")
			{
				if (!SystemConst.is_admin)
				{
					this.toolstrip_admin.Enabled = false;
				}
				else
				{
					this.toolstrip_admin.Enabled = true;
				}
				this.ToolstripAccounts.Enabled = false;
				this.ToolstripHumanResource.Enabled = false;
				this.ToolstripWages.Enabled = true;
				this.toolstripreports.Enabled = false;
				this.btnhr.Enabled = false;
				this.btnaccounts.Enabled = false;
				this.btnwages.Enabled = true;
                this.btnFinance.Enabled = false;
                return;
			}
			if (SystemConst._user_department == "Human Resource")
			{
				if (!SystemConst.is_admin)
				{
					this.toolstrip_admin.Enabled = false;
				}
				else
				{
					this.toolstrip_admin.Enabled = true;
				}
				this.ToolstripAccounts.Enabled = false;
				this.ToolstripHumanResource.Enabled = true;
				this.ToolstripWages.Enabled = false;
				this.toolstripreports.Enabled = true;
				this.btnhr.Enabled = true;
				this.btnaccounts.Enabled = false;
				this.btnwages.Enabled = false;
                this.btnFinance.Enabled = false;
            }

            if (SystemConst._user_department == "Finance")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = false;
                this.btnFinance.Enabled = true;
            }

            if (SystemConst.Get_username() == "jimjohn" || SystemConst.Get_username() == "thad")
            {
                toolstripManageUsers.Enabled = true;
                this.ToolstripAccounts.Enabled = true;
                this.ToolstripHumanResource.Enabled = true;
                this.ToolstripWages.Enabled = true;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = true;
                this.btnaccounts.Enabled = true;
                this.btnwages.Enabled = true;
                this.btnFinance.Enabled = true;
            }
            else
            {
                toolstripManageUsers.Enabled = false;
            }
        }

        protected void Set_user_access_permissions()
        {
            if (SystemConst._user_department == "Accounts")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = true;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = false;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = true;
                this.btnwages.Enabled = false;
                this.btnFinance.Enabled = false;
                return;
            }
            if (SystemConst._user_department == "Wages")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = true;
                this.toolstripreports.Enabled = false;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = true;
                this.btnFinance.Enabled = false;
                return;
            }
            if (SystemConst._user_department == "Human Resource")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = true;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = true;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = false;
                this.btnFinance.Enabled = false;
            }

            if (SystemConst._user_department == "Finance")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = false;
                this.btnFinance.Enabled = true;
            }

            if (SystemConst.Get_username() == "jimjohn" || SystemConst.Get_username() == "thad")
            {
                toolstripManageUsers.Enabled = true;
                toolstripManageUsers.Enabled = true;
                this.ToolstripAccounts.Enabled = true;
                this.ToolstripHumanResource.Enabled = true;
                this.ToolstripWages.Enabled = true;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = true;
                this.btnaccounts.Enabled = true;
                this.btnwages.Enabled = true;
                this.btnFinance.Enabled = true;
            }
            else
            {
                toolstripManageUsers.Enabled = false;
            }
        }

		private void nonGuardProfilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void otherEmployeeSalaryScaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_assign_salary_scales_to_guards()).Show();
		}

		private void panel1_MouseHover(object sender, EventArgs e)
		{
			this.WELCOME_GREET_USER();
			this.StartTimer();
            if (SystemConst._user_department == "Accounts")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = true;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = false;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = true;
                this.btnwages.Enabled = false;
                return;
            }
            if (SystemConst._user_department == "Wages")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = false;
                this.ToolstripWages.Enabled = true;
                this.toolstripreports.Enabled = false;
                this.btnhr.Enabled = false;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = true;
                return;
            }
            if (SystemConst._user_department == "Human Resource")
            {
                if (!SystemConst.is_admin)
                {
                    this.toolstrip_admin.Enabled = false;
                }
                else
                {
                    this.toolstrip_admin.Enabled = true;
                }
                this.ToolstripAccounts.Enabled = false;
                this.ToolstripHumanResource.Enabled = true;
                this.ToolstripWages.Enabled = false;
                this.toolstripreports.Enabled = true;
                this.btnhr.Enabled = true;
                this.btnaccounts.Enabled = false;
                this.btnwages.Enabled = false;
            }
        }

		private void removeNumberFromGuardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_free_guard_number()).Show();
		}

		//protected void Set_current_deployment_periods()
		//{
		//	DataTable dt = Guard_deployment.Select_active_deployment_period("select_active_deployment_period");
		//	if (dt.Rows.Count > 0)
		//	{
		//		DataRow dtRow = dt.Rows[0];
		//		int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
		//		SystemConst._active_deployment_id = num.ToString();
		//		SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
		//		SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
		//	}
		//}

		protected void StartTimer()
		{
			this.t = new Timer()
			{
				Interval = 1000
			};
			this.t.Tick += new EventHandler(this.t_Tick);
			this.t.Enabled = true;
		}

		protected void t_Tick(object sender, EventArgs e)
		{
			this.lbl_clock.Text = DateTime.Now.ToString();
			this.lbl_user_session_name.Text = string.Concat("Login session for: ", SystemConst.Get_username());
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			(new frm_transfer_guards()).Show();
		}

		private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
		{
			(new frm_wages_panel()).ShowDialog();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			(new frm_kampal_guards_filter()).ShowDialog();
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			(new frm_accounts_panel()).ShowDialog();
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			(new frm_guards_salary_scale_mapping_dashboard()).ShowDialog();
		}

		private void transferGuardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_archieved_guards()).Show();
		}

		private void updatePositionCodesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new frm_update_guard_position_codes()).ShowDialog();
		}

		protected void WELCOME_GREET_USER()
		{
			if (DateTime.Now.Hour < 12)
			{
				this.lbl_name_message.Text = string.Concat("Good Morning ", SystemConst.Get_username());
				this.panel_user.Visible = true;
				return;
			}
			if (DateTime.Now.Hour < 17)
			{
				this.lbl_name_message.Text = string.Concat("Good Afternoon ", SystemConst.Get_username());
				this.panel_user.Visible = true;
				return;
			}
			this.lbl_name_message.Text = string.Concat("Good Evening ", SystemConst.Get_username());
			this.panel_user.Visible = true;
		}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sg_profiles profiles = new sg_profiles();
            profiles.Show();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            frm_wages_panel wages = new frm_wages_panel();
            wages.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_accounts_panel accounts = new frm_accounts_panel();
            accounts.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_guard_lists list = new frm_guard_lists();
            list.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_kampal_guards_filter kamp = new frm_kampal_guards_filter();
            kamp.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frm_sg_list_report report = new frm_sg_list_report();
            report.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frm_archieve_lists archieve = new frm_archieve_lists();
            archieve.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frm_users users = new frm_users();
            users.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frm_lookups lookups = new frm_lookups();
            lookups.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frm_update_guard_position_codes codes = new frm_update_guard_position_codes();
            codes.ShowDialog();
        }

        private void menuStrip1_Enter(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventoryPanel frmNew = new frmInventoryPanel();
            frmNew.ShowDialog();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            frmCustomerManagement mgt = new frmCustomerManagement();
            mgt.ShowDialog();
        }
    }
}