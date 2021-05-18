
namespace Accounts
{
    partial class frmLegacyAccountEntries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLegacyAccountEntries));
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.grpboxFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnLoadLegacyData = new System.Windows.Forms.Button();
            this.tblLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.grpboxFilter.SuspendLayout();
            this.tblLayoutContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvList
            // 
            this.gdvList.AllowUserToAddRows = false;
            this.gdvList.AllowUserToDeleteRows = false;
            this.gdvList.AllowUserToResizeColumns = false;
            this.gdvList.AllowUserToResizeRows = false;
            this.gdvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvList.Location = new System.Drawing.Point(4, 4);
            this.gdvList.Margin = new System.Windows.Forms.Padding(4);
            this.gdvList.Name = "gdvList";
            this.gdvList.ReadOnly = true;
            this.gdvList.RowHeadersWidth = 51;
            this.gdvList.Size = new System.Drawing.Size(982, 613);
            this.gdvList.TabIndex = 1;
            // 
            // grpboxFilter
            // 
            this.grpboxFilter.Controls.Add(this.btnLoadLegacyData);
            this.grpboxFilter.Controls.Add(this.cboYear);
            this.grpboxFilter.Controls.Add(this.label1);
            this.grpboxFilter.Location = new System.Drawing.Point(6, 1);
            this.grpboxFilter.Name = "grpboxFilter";
            this.grpboxFilter.Size = new System.Drawing.Size(990, 65);
            this.grpboxFilter.TabIndex = 1;
            this.grpboxFilter.TabStop = false;
            this.grpboxFilter.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013"});
            this.cboYear.Location = new System.Drawing.Point(60, 21);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(322, 33);
            this.cboYear.TabIndex = 1;
            // 
            // btnLoadLegacyData
            // 
            this.btnLoadLegacyData.Location = new System.Drawing.Point(397, 21);
            this.btnLoadLegacyData.Name = "btnLoadLegacyData";
            this.btnLoadLegacyData.Size = new System.Drawing.Size(156, 33);
            this.btnLoadLegacyData.TabIndex = 2;
            this.btnLoadLegacyData.Text = "Load Legacy Entries";
            this.btnLoadLegacyData.UseVisualStyleBackColor = true;
            this.btnLoadLegacyData.Click += new System.EventHandler(this.btnLoadLegacyData_Click);
            // 
            // tblLayoutContainer
            // 
            this.tblLayoutContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutContainer.AutoScroll = true;
            this.tblLayoutContainer.ColumnCount = 1;
            this.tblLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutContainer.Controls.Add(this.gdvList, 0, 0);
            this.tblLayoutContainer.Location = new System.Drawing.Point(6, 72);
            this.tblLayoutContainer.Name = "tblLayoutContainer";
            this.tblLayoutContainer.RowCount = 1;
            this.tblLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutContainer.Size = new System.Drawing.Size(990, 621);
            this.tblLayoutContainer.TabIndex = 2;
            // 
            // frmLegacyAccountEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(998, 696);
            this.Controls.Add(this.tblLayoutContainer);
            this.Controls.Add(this.grpboxFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLegacyAccountEntries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Legacy-Data-Account Entries";
            this.Load += new System.EventHandler(this.frmLegacyAccountEntries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.grpboxFilter.ResumeLayout(false);
            this.grpboxFilter.PerformLayout();
            this.tblLayoutContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gdvList;
        private System.Windows.Forms.GroupBox grpboxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnLoadLegacyData;
        private System.Windows.Forms.TableLayoutPanel tblLayoutContainer;
    }
}