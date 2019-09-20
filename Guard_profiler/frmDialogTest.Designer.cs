namespace Guard_profiler
{
    partial class _frm_guard_deployment_additional_data
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAccountsHeader = new System.Windows.Forms.Label();
            this.cbo_deploy_period = new System.Windows.Forms.ComboBox();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.bgWorkerImport = new System.ComponentModel.BackgroundWorker();
            this.lblLoad = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 20);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(670, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter additional guard deployment data here for a given deployment period.Use the" +
    " search option to narrow down list";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1005, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Deployment summary report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Coral;
            this.btn_save.Location = new System.Drawing.Point(838, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 23);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Save Batch Record";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Cyan;
            this.btn_search.Location = new System.Drawing.Point(733, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 23);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Guard Number";
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(427, 5);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(300, 21);
            this.txt_guard_number.TabIndex = 24;
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(99, 2);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(227, 23);
            this.cbo_branch.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_guard_number);
            this.panel3.Controls.Add(this.cbo_branch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(2, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 29);
            this.panel3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Select a station";
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToOrderColumns = true;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(3, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.Size = new System.Drawing.Size(1175, 480);
            this.gdv_guards.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdv_guards);
            this.panel2.Location = new System.Drawing.Point(2, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 402);
            this.panel2.TabIndex = 5;
            // 
            // lblAccountsHeader
            // 
            this.lblAccountsHeader.AutoSize = true;
            this.lblAccountsHeader.BackColor = System.Drawing.Color.Black;
            this.lblAccountsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountsHeader.Location = new System.Drawing.Point(609, 11);
            this.lblAccountsHeader.Name = "lblAccountsHeader";
            this.lblAccountsHeader.Size = new System.Drawing.Size(118, 16);
            this.lblAccountsHeader.TabIndex = 30;
            this.lblAccountsHeader.Text = "Payment Period";
            // 
            // cbo_deploy_period
            // 
            this.cbo_deploy_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deploy_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_deploy_period.FormattingEnabled = true;
            this.cbo_deploy_period.Location = new System.Drawing.Point(777, 1);
            this.cbo_deploy_period.Name = "cbo_deploy_period";
            this.cbo_deploy_period.Size = new System.Drawing.Size(401, 33);
            this.cbo_deploy_period.TabIndex = 29;
            this.cbo_deploy_period.SelectionChangeCommitted += new System.EventHandler(this.cbo_deploy_period_SelectionChangeCommitted);
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end_date.Location = new System.Drawing.Point(395, 6);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(208, 21);
            this.dt_end_date.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "For the period of:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start_date.Location = new System.Drawing.Point(135, 6);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(208, 21);
            this.dt_start_date.TabIndex = 10;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 551D;
            this.reSize1.InitialHostContainerWidth = 1185D;
            this.reSize1.Tag = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblAccountsHeader);
            this.panel1.Controls.Add(this.cbo_deploy_period);
            this.panel1.Controls.Add(this.dt_end_date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dt_start_date);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 35);
            this.panel1.TabIndex = 4;
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(794, 18);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(390, 23);
            this.pgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBar.TabIndex = 5;
            // 
            // bgWorkerImport
            // 
            this.bgWorkerImport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerImport_DoWork);
            this.bgWorkerImport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerImport_ProgressChanged);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoad.ForeColor = System.Drawing.Color.White;
            this.lblLoad.Location = new System.Drawing.Point(791, 2);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(210, 13);
            this.lblLoad.TabIndex = 2;
            this.lblLoad.Text = "We are loading your results...Please Wait...";
            // 
            // _frm_guard_deployment_additional_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1185, 551);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "_frm_guard_deployment_additional_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDialogTest";
            this.Load += new System.EventHandler(this._frm_guard_deployment_additional_data_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_guard_number;
        private System.Windows.Forms.ComboBox cbo_branch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gdv_guards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAccountsHeader;
        private System.Windows.Forms.ComboBox cbo_deploy_period;
        private System.Windows.Forms.DateTimePicker dt_end_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_start_date;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.ComponentModel.BackgroundWorker bgWorkerImport;
        private System.Windows.Forms.Label lblLoad;
    }
}