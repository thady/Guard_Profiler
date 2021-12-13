namespace Accounts
{
    partial class frmChartofAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChartofAccounts));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlListing = new System.Windows.Forms.Panel();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCreditDebit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpeningBal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.pageMenustrp = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtAccountTitleSearch = new System.Windows.Forms.TextBox();
            this.txtAccountNumberSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.pnlDataEntry.SuspendLayout();
            this.pageMenustrp.SuspendLayout();
            this.grpBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnDelete);
            this.pnlContainer.Controls.Add(this.grpBoxSearch);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.lblID);
            this.pnlContainer.Controls.Add(this.btnNew);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.label8);
            this.pnlContainer.Controls.Add(this.pnlListing);
            this.pnlContainer.Controls.Add(this.pnlDataEntry);
            this.pnlContainer.Location = new System.Drawing.Point(4, 38);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1105, 708);
            this.pnlContainer.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 292);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Doubleclick on a record to view details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chart of Accounts";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(579, 15);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 17);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "--";
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(312, 219);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 28);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(407, 219);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(515, 219);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 28);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chart of Accounts Listing";
            // 
            // pnlListing
            // 
            this.pnlListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlListing.Controls.Add(this.gdvList);
            this.pnlListing.Location = new System.Drawing.Point(-3, 316);
            this.pnlListing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlListing.Name = "pnlListing";
            this.pnlListing.Size = new System.Drawing.Size(1105, 388);
            this.pnlListing.TabIndex = 12;
            // 
            // gdvList
            // 
            this.gdvList.AllowUserToAddRows = false;
            this.gdvList.AllowUserToDeleteRows = false;
            this.gdvList.AllowUserToResizeColumns = false;
            this.gdvList.AllowUserToResizeRows = false;
            this.gdvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvList.Location = new System.Drawing.Point(3, 4);
            this.gdvList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gdvList.Name = "gdvList";
            this.gdvList.ReadOnly = true;
            this.gdvList.RowHeadersWidth = 51;
            this.gdvList.Size = new System.Drawing.Size(1097, 377);
            this.gdvList.TabIndex = 0;
            this.gdvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvList_CellDoubleClick);
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlDataEntry.Controls.Add(this.label6);
            this.pnlDataEntry.Controls.Add(this.cboBranch);
            this.pnlDataEntry.Controls.Add(this.label10);
            this.pnlDataEntry.Controls.Add(this.cboCreditDebit);
            this.pnlDataEntry.Controls.Add(this.label5);
            this.pnlDataEntry.Controls.Add(this.txtOpeningBal);
            this.pnlDataEntry.Controls.Add(this.label4);
            this.pnlDataEntry.Controls.Add(this.cboBank);
            this.pnlDataEntry.Controls.Add(this.cboAccountType);
            this.pnlDataEntry.Controls.Add(this.label3);
            this.pnlDataEntry.Controls.Add(this.txtAccountNumber);
            this.pnlDataEntry.Controls.Add(this.label2);
            this.pnlDataEntry.Controls.Add(this.label1);
            this.pnlDataEntry.Controls.Add(this.txtAccountTitle);
            this.pnlDataEntry.Location = new System.Drawing.Point(1, 34);
            this.pnlDataEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(1104, 177);
            this.pnlDataEntry.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Branch";
            // 
            // cboBranch
            // 
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(617, 132);
            this.cboBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(284, 24);
            this.cboBranch.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Debit/Credit";
            // 
            // cboCreditDebit
            // 
            this.cboCreditDebit.FormattingEnabled = true;
            this.cboCreditDebit.Items.AddRange(new object[] {
            "",
            "Dr",
            "Cr"});
            this.cboCreditDebit.Location = new System.Drawing.Point(324, 133);
            this.cboCreditDebit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCreditDebit.Name = "cboCreditDebit";
            this.cboCreditDebit.Size = new System.Drawing.Size(284, 24);
            this.cboCreditDebit.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opening Balance";
            // 
            // txtOpeningBal
            // 
            this.txtOpeningBal.Location = new System.Drawing.Point(15, 133);
            this.txtOpeningBal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOpeningBal.Name = "txtOpeningBal";
            this.txtOpeningBal.Size = new System.Drawing.Size(284, 22);
            this.txtOpeningBal.TabIndex = 8;
            this.txtOpeningBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningBal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bank?";
            // 
            // cboBank
            // 
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(324, 84);
            this.cboBank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(284, 24);
            this.cboBank.TabIndex = 6;
            // 
            // cboAccountType
            // 
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(15, 31);
            this.cboAccountType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(284, 24);
            this.cboAccountType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Title";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(15, 82);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(284, 22);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Type";
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.Location = new System.Drawing.Point(324, 32);
            this.txtAccountTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(284, 22);
            this.txtAccountTitle.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 748D;
            this.reSize1.InitialHostContainerWidth = 1112D;
            this.reSize1.Tag = null;
            // 
            // pageMenustrp
            // 
            this.pageMenustrp.BackColor = System.Drawing.Color.Gray;
            this.pageMenustrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pageMenustrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.pageMenustrp.Location = new System.Drawing.Point(0, 0);
            this.pageMenustrp.Name = "pageMenustrp";
            this.pageMenustrp.Size = new System.Drawing.Size(1112, 30);
            this.pageMenustrp.TabIndex = 1;
            this.pageMenustrp.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.BackColor = System.Drawing.Color.LightCyan;
            this.grpBoxSearch.Controls.Add(this.btnsearch);
            this.grpBoxSearch.Controls.Add(this.label12);
            this.grpBoxSearch.Controls.Add(this.label11);
            this.grpBoxSearch.Controls.Add(this.txtAccountNumberSearch);
            this.grpBoxSearch.Controls.Add(this.txtAccountTitleSearch);
            this.grpBoxSearch.Location = new System.Drawing.Point(683, 219);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(419, 94);
            this.grpBoxSearch.TabIndex = 20;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Search";
            // 
            // txtAccountTitleSearch
            // 
            this.txtAccountTitleSearch.Location = new System.Drawing.Point(7, 39);
            this.txtAccountTitleSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountTitleSearch.Name = "txtAccountTitleSearch";
            this.txtAccountTitleSearch.Size = new System.Drawing.Size(202, 22);
            this.txtAccountTitleSearch.TabIndex = 14;
            // 
            // txtAccountNumberSearch
            // 
            this.txtAccountNumberSearch.Location = new System.Drawing.Point(214, 39);
            this.txtAccountNumberSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNumberSearch.Name = "txtAccountNumberSearch";
            this.txtAccountNumberSearch.Size = new System.Drawing.Size(179, 22);
            this.txtAccountNumberSearch.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Account Title";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Account Number";
            // 
            // btnsearch
            // 
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(7, 62);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(202, 28);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(485, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 37);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmChartofAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1112, 748);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pageMenustrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChartofAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart of Accounts";
            this.Load += new System.EventHandler(this.frmChartofAccounts_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlListing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlDataEntry.PerformLayout();
            this.pageMenustrp.ResumeLayout(false);
            this.pageMenustrp.PerformLayout();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlListing;
        private System.Windows.Forms.DataGridView gdvList;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccountTitle;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpeningBal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCreditDebit;
        private System.Windows.Forms.MenuStrip pageMenustrp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.TextBox txtAccountNumberSearch;
        private System.Windows.Forms.TextBox txtAccountTitleSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnDelete;
    }
}