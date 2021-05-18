
namespace Accounts
{
    partial class frmLegacyReportFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegacyReportFilter));
            this.grbFilters = new System.Windows.Forms.GroupBox();
            this.grpclientstatement = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboclient = new System.Windows.Forms.ComboBox();
            this.cbostation = new System.Windows.Forms.ComboBox();
            this.statement_end_date = new System.Windows.Forms.DateTimePicker();
            this.btnExportStatement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statement_start_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDebtorsList = new System.Windows.Forms.GroupBox();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbFilters.SuspendLayout();
            this.grpclientstatement.SuspendLayout();
            this.grpDebtorsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFilters
            // 
            this.grbFilters.Controls.Add(this.grpclientstatement);
            this.grbFilters.Controls.Add(this.grpDebtorsList);
            this.grbFilters.Location = new System.Drawing.Point(3, 2);
            this.grbFilters.Name = "grbFilters";
            this.grbFilters.Size = new System.Drawing.Size(960, 669);
            this.grbFilters.TabIndex = 0;
            this.grbFilters.TabStop = false;
            this.grbFilters.Text = "Report Parameters";
            // 
            // grpclientstatement
            // 
            this.grpclientstatement.Controls.Add(this.label7);
            this.grpclientstatement.Controls.Add(this.cboclient);
            this.grpclientstatement.Controls.Add(this.cbostation);
            this.grpclientstatement.Controls.Add(this.statement_end_date);
            this.grpclientstatement.Controls.Add(this.btnExportStatement);
            this.grpclientstatement.Controls.Add(this.label4);
            this.grpclientstatement.Controls.Add(this.statement_start_date);
            this.grpclientstatement.Controls.Add(this.label5);
            this.grpclientstatement.Controls.Add(this.label6);
            this.grpclientstatement.Location = new System.Drawing.Point(9, 249);
            this.grpclientstatement.Name = "grpclientstatement";
            this.grpclientstatement.Size = new System.Drawing.Size(492, 290);
            this.grpclientstatement.TabIndex = 8;
            this.grpclientstatement.TabStop = false;
            this.grpclientstatement.Text = "Client Statement Report Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Client Name";
            // 
            // cboclient
            // 
            this.cboclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclient.FormattingEnabled = true;
            this.cboclient.Location = new System.Drawing.Point(103, 81);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(316, 33);
            this.cboclient.TabIndex = 8;
            // 
            // cbostation
            // 
            this.cbostation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostation.FormattingEnabled = true;
            this.cbostation.Location = new System.Drawing.Point(103, 27);
            this.cbostation.Name = "cbostation";
            this.cbostation.Size = new System.Drawing.Size(316, 33);
            this.cbostation.TabIndex = 7;
            this.cbostation.SelectedIndexChanged += new System.EventHandler(this.cbostation_SelectedIndexChanged);
            // 
            // statement_end_date
            // 
            this.statement_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statement_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.statement_end_date.Location = new System.Drawing.Point(103, 179);
            this.statement_end_date.Name = "statement_end_date";
            this.statement_end_date.ShowCheckBox = true;
            this.statement_end_date.Size = new System.Drawing.Size(316, 27);
            this.statement_end_date.TabIndex = 5;
            // 
            // btnExportStatement
            // 
            this.btnExportStatement.Location = new System.Drawing.Point(269, 212);
            this.btnExportStatement.Name = "btnExportStatement";
            this.btnExportStatement.Size = new System.Drawing.Size(150, 37);
            this.btnExportStatement.TabIndex = 6;
            this.btnExportStatement.Text = "Generate Report";
            this.btnExportStatement.UseVisualStyleBackColor = true;
            this.btnExportStatement.Click += new System.EventHandler(this.btnExportStatement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Station Name";
            // 
            // statement_start_date
            // 
            this.statement_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statement_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.statement_start_date.Location = new System.Drawing.Point(103, 144);
            this.statement_start_date.Name = "statement_start_date";
            this.statement_start_date.ShowCheckBox = true;
            this.statement_start_date.Size = new System.Drawing.Size(316, 27);
            this.statement_start_date.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "End Date";
            // 
            // grpDebtorsList
            // 
            this.grpDebtorsList.Controls.Add(this.cboBranch);
            this.grpDebtorsList.Controls.Add(this.dtPickerEnd);
            this.grpDebtorsList.Controls.Add(this.button1);
            this.grpDebtorsList.Controls.Add(this.label1);
            this.grpDebtorsList.Controls.Add(this.dtPickerStart);
            this.grpDebtorsList.Controls.Add(this.label2);
            this.grpDebtorsList.Controls.Add(this.label3);
            this.grpDebtorsList.Location = new System.Drawing.Point(9, 30);
            this.grpDebtorsList.Name = "grpDebtorsList";
            this.grpDebtorsList.Size = new System.Drawing.Size(492, 204);
            this.grpDebtorsList.TabIndex = 7;
            this.grpDebtorsList.TabStop = false;
            this.grpDebtorsList.Text = "Debtors List Report Filter";
            // 
            // cboBranch
            // 
            this.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(103, 27);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(316, 33);
            this.cboBranch.TabIndex = 7;
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerEnd.Location = new System.Drawing.Point(103, 110);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.ShowCheckBox = true;
            this.dtPickerEnd.Size = new System.Drawing.Size(316, 27);
            this.dtPickerEnd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Station Code";
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerStart.Location = new System.Drawing.Point(103, 75);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.ShowCheckBox = true;
            this.dtPickerStart.Size = new System.Drawing.Size(316, 27);
            this.dtPickerStart.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date";
            // 
            // frmLegacyReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 674);
            this.Controls.Add(this.grbFilters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLegacyReportFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report name";
            this.Load += new System.EventHandler(this.frmLegacyReportFilter_Load);
            this.grbFilters.ResumeLayout(false);
            this.grpclientstatement.ResumeLayout(false);
            this.grpclientstatement.PerformLayout();
            this.grpDebtorsList.ResumeLayout(false);
            this.grpDebtorsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpDebtorsList;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.GroupBox grpclientstatement;
        private System.Windows.Forms.ComboBox cbostation;
        private System.Windows.Forms.DateTimePicker statement_end_date;
        private System.Windows.Forms.Button btnExportStatement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker statement_start_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboclient;
    }
}