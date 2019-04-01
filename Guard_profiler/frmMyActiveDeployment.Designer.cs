namespace Guard_profiler
{
    partial class frmMyActiveDeployment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyActiveDeployment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.gdv_deployment_periods = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_current_deployment_period = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_guid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_periods)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_current_deployment_period)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lbl_guid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1237, 802);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Active Deployment Period";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(11, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(259, 47);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.dt_end_date);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dt_start_date);
            this.panel3.Location = new System.Drawing.Point(7, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 58);
            this.panel3.TabIndex = 2;
            // 
            // dt_end_date
            // 
            this.dt_end_date.Enabled = false;
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Location = new System.Drawing.Point(311, 25);
            this.dt_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(299, 24);
            this.dt_end_date.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(307, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "From";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Enabled = false;
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Location = new System.Drawing.Point(4, 25);
            this.dt_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(301, 24);
            this.dt_start_date.TabIndex = 0;
            // 
            // gdv_deployment_periods
            // 
            this.gdv_deployment_periods.AllowUserToAddRows = false;
            this.gdv_deployment_periods.AllowUserToDeleteRows = false;
            this.gdv_deployment_periods.AllowUserToResizeColumns = false;
            this.gdv_deployment_periods.AllowUserToResizeRows = false;
            this.gdv_deployment_periods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_deployment_periods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_deployment_periods.Location = new System.Drawing.Point(4, 12);
            this.gdv_deployment_periods.Name = "gdv_deployment_periods";
            this.gdv_deployment_periods.RowTemplate.Height = 24;
            this.gdv_deployment_periods.Size = new System.Drawing.Size(1213, 397);
            this.gdv_deployment_periods.TabIndex = 0;
            this.gdv_deployment_periods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_deployment_periods_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdv_deployment_periods);
            this.panel1.Location = new System.Drawing.Point(6, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 412);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of Deployment Periods.Please double click on a deployment and click the upda" +
    "te button at the top to set it as your current deployment period";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gdv_current_deployment_period);
            this.panel2.Location = new System.Drawing.Point(6, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1217, 206);
            this.panel2.TabIndex = 7;
            // 
            // gdv_current_deployment_period
            // 
            this.gdv_current_deployment_period.AllowUserToAddRows = false;
            this.gdv_current_deployment_period.AllowUserToDeleteRows = false;
            this.gdv_current_deployment_period.AllowUserToResizeColumns = false;
            this.gdv_current_deployment_period.AllowUserToResizeRows = false;
            this.gdv_current_deployment_period.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_current_deployment_period.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_current_deployment_period.Location = new System.Drawing.Point(3, 3);
            this.gdv_current_deployment_period.Name = "gdv_current_deployment_period";
            this.gdv_current_deployment_period.RowTemplate.Height = 24;
            this.gdv_current_deployment_period.Size = new System.Drawing.Size(1211, 200);
            this.gdv_current_deployment_period.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(276, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "My Current Deployment Period";
            // 
            // lbl_guid
            // 
            this.lbl_guid.AutoSize = true;
            this.lbl_guid.Location = new System.Drawing.Point(692, 47);
            this.lbl_guid.Name = "lbl_guid";
            this.lbl_guid.Size = new System.Drawing.Size(57, 17);
            this.lbl_guid.TabIndex = 9;
            this.lbl_guid.Text = "lbl_guid";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Blue;
            this.lblname.Location = new System.Drawing.Point(848, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(80, 25);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "lblname";
            // 
            // frmMyActiveDeployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 822);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMyActiveDeployment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Active Deployment Period";
            this.Load += new System.EventHandler(this.frmMyActiveDeployment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_periods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_current_deployment_period)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdv_deployment_periods;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dt_end_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_start_date;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gdv_current_deployment_period;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_guid;
        private System.Windows.Forms.Label lblname;
    }
}