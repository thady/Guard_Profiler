namespace Guard_profiler
{
    partial class frm_staffprofiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_staffprofiles));
            this.txt_personal_number = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tin_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_bank_branch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_bank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_acc_number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nssf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_position = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdv_staff = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpbox_staffprofiles = new System.Windows.Forms.GroupBox();
            this.lblstaffid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpbox_staffprofiles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_personal_number
            // 
            this.txt_personal_number.Location = new System.Drawing.Point(327, 93);
            this.txt_personal_number.Name = "txt_personal_number";
            this.txt_personal_number.Size = new System.Drawing.Size(316, 22);
            this.txt_personal_number.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(324, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Personal Number:";
            // 
            // cbo_branch
            // 
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(11, 91);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(294, 24);
            this.cbo_branch.TabIndex = 19;
            this.cbo_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_branch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Branch Name:";
            // 
            // txt_tin_number
            // 
            this.txt_tin_number.Location = new System.Drawing.Point(329, 232);
            this.txt_tin_number.Name = "txt_tin_number";
            this.txt_tin_number.Size = new System.Drawing.Size(316, 22);
            this.txt_tin_number.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(326, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tin Number:";
            // 
            // cbo_bank_branch
            // 
            this.cbo_bank_branch.FormattingEnabled = true;
            this.cbo_bank_branch.Location = new System.Drawing.Point(11, 230);
            this.cbo_bank_branch.Name = "cbo_bank_branch";
            this.cbo_bank_branch.Size = new System.Drawing.Size(296, 24);
            this.cbo_bank_branch.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bank Branch:";
            // 
            // cbo_bank
            // 
            this.cbo_bank.FormattingEnabled = true;
            this.cbo_bank.Location = new System.Drawing.Point(329, 185);
            this.cbo_bank.Name = "cbo_bank";
            this.cbo_bank.Size = new System.Drawing.Size(316, 24);
            this.cbo_bank.TabIndex = 13;
            this.cbo_bank.SelectedIndexChanged += new System.EventHandler(this.cbo_bank_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(326, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bank Name:";
            // 
            // txt_acc_number
            // 
            this.txt_acc_number.Location = new System.Drawing.Point(11, 185);
            this.txt_acc_number.Name = "txt_acc_number";
            this.txt_acc_number.Size = new System.Drawing.Size(296, 22);
            this.txt_acc_number.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Account Number:";
            // 
            // txt_nssf
            // 
            this.txt_nssf.Location = new System.Drawing.Point(180, 140);
            this.txt_nssf.Name = "txt_nssf";
            this.txt_nssf.Size = new System.Drawing.Size(314, 22);
            this.txt_nssf.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(177, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nssf Number:";
            // 
            // cbo_position
            // 
            this.cbo_position.FormattingEnabled = true;
            this.cbo_position.Location = new System.Drawing.Point(11, 138);
            this.cbo_position.Name = "cbo_position";
            this.cbo_position.Size = new System.Drawing.Size(160, 24);
            this.cbo_position.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position:";
            // 
            // cbo_status
            // 
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Items.AddRange(new object[] {
            "",
            "Active",
            "Inactive",
            "On Probation",
            "Suspended"});
            this.cbo_status.Location = new System.Drawing.Point(513, 47);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(130, 24);
            this.cbo_status.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(510, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // cbo_sex
            // 
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cbo_sex.Location = new System.Drawing.Point(327, 47);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(165, 24);
            this.cbo_sex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(324, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sex:";
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_staff_name.Location = new System.Drawing.Point(9, 47);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.Size = new System.Drawing.Size(296, 22);
            this.txt_staff_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Name:";
            // 
            // gdv_staff
            // 
            this.gdv_staff.AllowUserToAddRows = false;
            this.gdv_staff.AllowUserToDeleteRows = false;
            this.gdv_staff.AllowUserToResizeColumns = false;
            this.gdv_staff.AllowUserToResizeRows = false;
            this.gdv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_staff.Location = new System.Drawing.Point(6, 21);
            this.gdv_staff.Name = "gdv_staff";
            this.gdv_staff.RowTemplate.Height = 24;
            this.gdv_staff.Size = new System.Drawing.Size(1132, 436);
            this.gdv_staff.TabIndex = 0;
            this.gdv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_staff_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(9, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1144, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.gdv_staff);
            this.groupBox2.Location = new System.Drawing.Point(9, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1144, 463);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "staff List";
            // 
            // grpbox_staffprofiles
            // 
            this.grpbox_staffprofiles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpbox_staffprofiles.Controls.Add(this.lblstaffid);
            this.grpbox_staffprofiles.Controls.Add(this.txt_personal_number);
            this.grpbox_staffprofiles.Controls.Add(this.label11);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_branch);
            this.grpbox_staffprofiles.Controls.Add(this.label10);
            this.grpbox_staffprofiles.Controls.Add(this.txt_tin_number);
            this.grpbox_staffprofiles.Controls.Add(this.label9);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_bank_branch);
            this.grpbox_staffprofiles.Controls.Add(this.label8);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_bank);
            this.grpbox_staffprofiles.Controls.Add(this.label7);
            this.grpbox_staffprofiles.Controls.Add(this.txt_acc_number);
            this.grpbox_staffprofiles.Controls.Add(this.label6);
            this.grpbox_staffprofiles.Controls.Add(this.txt_nssf);
            this.grpbox_staffprofiles.Controls.Add(this.label5);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_position);
            this.grpbox_staffprofiles.Controls.Add(this.label4);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_status);
            this.grpbox_staffprofiles.Controls.Add(this.label3);
            this.grpbox_staffprofiles.Controls.Add(this.cbo_sex);
            this.grpbox_staffprofiles.Controls.Add(this.label2);
            this.grpbox_staffprofiles.Controls.Add(this.txt_staff_name);
            this.grpbox_staffprofiles.Controls.Add(this.label1);
            this.grpbox_staffprofiles.ForeColor = System.Drawing.Color.Blue;
            this.grpbox_staffprofiles.Location = new System.Drawing.Point(9, 9);
            this.grpbox_staffprofiles.Name = "grpbox_staffprofiles";
            this.grpbox_staffprofiles.Size = new System.Drawing.Size(1144, 260);
            this.grpbox_staffprofiles.TabIndex = 0;
            this.grpbox_staffprofiles.TabStop = false;
            this.grpbox_staffprofiles.Text = "Manage staff profiles";
            // 
            // lblstaffid
            // 
            this.lblstaffid.AutoSize = true;
            this.lblstaffid.Location = new System.Drawing.Point(860, 0);
            this.lblstaffid.Name = "lblstaffid";
            this.lblstaffid.Size = new System.Drawing.Size(12, 17);
            this.lblstaffid.TabIndex = 22;
            this.lblstaffid.Text = ".";
            this.lblstaffid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdvance);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grpbox_staffprofiles);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 862);
            this.panel1.TabIndex = 1;
            // 
            // btnAdvance
            // 
            this.btnAdvance.ForeColor = System.Drawing.Color.Blue;
            this.btnAdvance.Location = new System.Drawing.Point(664, 275);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(151, 31);
            this.btnAdvance.TabIndex = 25;
            this.btnAdvance.Text = "Staff Advance";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnnew
            // 
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(254, 275);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(90, 31);
            this.btnnew.TabIndex = 24;
            this.btnnew.Text = "New Staff";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.Color.Crimson;
            this.btnedit.Location = new System.Drawing.Point(350, 275);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(151, 31);
            this.btnedit.TabIndex = 23;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(507, 275);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 31);
            this.btnsave.TabIndex = 22;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 869D;
            this.reSize1.InitialHostContainerWidth = 1168D;
            this.reSize1.Tag = null;
            // 
            // frm_staffprofiles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1168, 869);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_staffprofiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Profiles";
            this.Load += new System.EventHandler(this.frm_staffprofiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_staff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpbox_staffprofiles.ResumeLayout(false);
            this.grpbox_staffprofiles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_personal_number;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_branch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tin_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_bank_branch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_bank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_acc_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nssf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdv_staff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpbox_staffprofiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label lblstaffid;
        private System.Windows.Forms.Button btnAdvance;
    }
}