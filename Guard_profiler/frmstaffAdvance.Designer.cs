namespace Guard_profiler
{
    partial class frmstaffAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstaffAdvance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdvAdvanceList = new System.Windows.Forms.DataGridView();
            this.grpboxMain = new System.Windows.Forms.GroupBox();
            this.lblad_id = new System.Windows.Forms.Label();
            this.lblstaffid = new System.Windows.Forms.Label();
            this.chkfullypaid = new System.Windows.Forms.CheckBox();
            this.txtAmountBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtamountPaid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtAdvanceDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_staff_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAdvanceList)).BeginInit();
            this.grpboxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.grpboxMain);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 688);
            this.panel1.TabIndex = 0;
            // 
            // btnnew
            // 
            this.btnnew.ForeColor = System.Drawing.Color.Blue;
            this.btnnew.Location = new System.Drawing.Point(121, 164);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(108, 31);
            this.btnnew.TabIndex = 27;
            this.btnnew.Text = "New Advance";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.Color.Crimson;
            this.btnedit.Location = new System.Drawing.Point(235, 164);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(151, 31);
            this.btnedit.TabIndex = 26;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(392, 164);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(151, 31);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdvAdvanceList);
            this.groupBox2.Location = new System.Drawing.Point(8, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advance List";
            // 
            // gdvAdvanceList
            // 
            this.gdvAdvanceList.AllowUserToAddRows = false;
            this.gdvAdvanceList.AllowUserToDeleteRows = false;
            this.gdvAdvanceList.AllowUserToResizeColumns = false;
            this.gdvAdvanceList.AllowUserToResizeRows = false;
            this.gdvAdvanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvAdvanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAdvanceList.Location = new System.Drawing.Point(9, 21);
            this.gdvAdvanceList.Name = "gdvAdvanceList";
            this.gdvAdvanceList.RowTemplate.Height = 24;
            this.gdvAdvanceList.Size = new System.Drawing.Size(957, 455);
            this.gdvAdvanceList.TabIndex = 0;
            this.gdvAdvanceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvAdvanceList_CellDoubleClick);
            // 
            // grpboxMain
            // 
            this.grpboxMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpboxMain.Controls.Add(this.lblad_id);
            this.grpboxMain.Controls.Add(this.lblstaffid);
            this.grpboxMain.Controls.Add(this.chkfullypaid);
            this.grpboxMain.Controls.Add(this.txtAmountBalance);
            this.grpboxMain.Controls.Add(this.label5);
            this.grpboxMain.Controls.Add(this.txtamountPaid);
            this.grpboxMain.Controls.Add(this.label4);
            this.grpboxMain.Controls.Add(this.txtamount);
            this.grpboxMain.Controls.Add(this.label3);
            this.grpboxMain.Controls.Add(this.dtAdvanceDate);
            this.grpboxMain.Controls.Add(this.label2);
            this.grpboxMain.Controls.Add(this.txt_staff_name);
            this.grpboxMain.Controls.Add(this.label1);
            this.grpboxMain.Location = new System.Drawing.Point(8, 10);
            this.grpboxMain.Name = "grpboxMain";
            this.grpboxMain.Size = new System.Drawing.Size(973, 152);
            this.grpboxMain.TabIndex = 0;
            this.grpboxMain.TabStop = false;
            this.grpboxMain.Text = "Enter Advance Details";
            // 
            // lblad_id
            // 
            this.lblad_id.AutoSize = true;
            this.lblad_id.Location = new System.Drawing.Point(715, 45);
            this.lblad_id.Name = "lblad_id";
            this.lblad_id.Size = new System.Drawing.Size(10, 13);
            this.lblad_id.TabIndex = 13;
            this.lblad_id.Text = ".";
            // 
            // lblstaffid
            // 
            this.lblstaffid.AutoSize = true;
            this.lblstaffid.Location = new System.Drawing.Point(715, 22);
            this.lblstaffid.Name = "lblstaffid";
            this.lblstaffid.Size = new System.Drawing.Size(10, 13);
            this.lblstaffid.TabIndex = 12;
            this.lblstaffid.Text = ".";
            // 
            // chkfullypaid
            // 
            this.chkfullypaid.AutoSize = true;
            this.chkfullypaid.Enabled = false;
            this.chkfullypaid.Location = new System.Drawing.Point(9, 115);
            this.chkfullypaid.Name = "chkfullypaid";
            this.chkfullypaid.Size = new System.Drawing.Size(123, 17);
            this.chkfullypaid.TabIndex = 11;
            this.chkfullypaid.Text = "Advance is fully paid";
            this.chkfullypaid.UseVisualStyleBackColor = true;
            // 
            // txtAmountBalance
            // 
            this.txtAmountBalance.Location = new System.Drawing.Point(322, 87);
            this.txtAmountBalance.Name = "txtAmountBalance";
            this.txtAmountBalance.ReadOnly = true;
            this.txtAmountBalance.Size = new System.Drawing.Size(147, 20);
            this.txtAmountBalance.TabIndex = 10;
            this.txtAmountBalance.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(319, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Advance Balance:";
            // 
            // txtamountPaid
            // 
            this.txtamountPaid.Location = new System.Drawing.Point(158, 87);
            this.txtamountPaid.Name = "txtamountPaid";
            this.txtamountPaid.ReadOnly = true;
            this.txtamountPaid.Size = new System.Drawing.Size(147, 20);
            this.txtamountPaid.TabIndex = 8;
            this.txtamountPaid.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(155, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount Paid:";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(9, 87);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(140, 20);
            this.txtamount.TabIndex = 6;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Advance Amount:";
            // 
            // dtAdvanceDate
            // 
            this.dtAdvanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdvanceDate.Location = new System.Drawing.Point(322, 42);
            this.dtAdvanceDate.Name = "dtAdvanceDate";
            this.dtAdvanceDate.Size = new System.Drawing.Size(200, 20);
            this.dtAdvanceDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(319, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advance Date:";
            // 
            // txt_staff_name
            // 
            this.txt_staff_name.Location = new System.Drawing.Point(9, 42);
            this.txt_staff_name.Name = "txt_staff_name";
            this.txt_staff_name.ReadOnly = true;
            this.txt_staff_name.Size = new System.Drawing.Size(296, 20);
            this.txt_staff_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Name:";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 691D;
            this.reSize1.InitialHostContainerWidth = 989D;
            this.reSize1.Tag = null;
            // 
            // frmstaffAdvance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(989, 691);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmstaffAdvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Advance ";
            this.Load += new System.EventHandler(this.frmstaffAdvance_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvAdvanceList)).EndInit();
            this.grpboxMain.ResumeLayout(false);
            this.grpboxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpboxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_staff_name;
        private System.Windows.Forms.DateTimePicker dtAdvanceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtamountPaid;
        private System.Windows.Forms.TextBox txtAmountBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkfullypaid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gdvAdvanceList;
        private System.Windows.Forms.Label lblstaffid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblad_id;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}