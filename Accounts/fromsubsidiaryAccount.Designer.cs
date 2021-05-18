namespace Accounts
{
    partial class frmsubsidiaryAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsubsidiaryAccount));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpboxSearch = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.cboControlAccSearch = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboSubLedgerSearch = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodeSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pnlListing = new System.Windows.Forms.Panel();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cboDebitCredit = new System.Windows.Forms.ComboBox();
            this.txtOpeningBal = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboNorminalAcc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLedgerCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.txtAccountTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.grpboxSearch.SuspendLayout();
            this.pnlListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.pnlDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Info;
            this.pnlContainer.Controls.Add(this.grpboxSearch);
            this.pnlContainer.Controls.Add(this.label9);
            this.pnlContainer.Controls.Add(this.label7);
            this.pnlContainer.Controls.Add(this.lblID);
            this.pnlContainer.Controls.Add(this.btnNew);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.pnlListing);
            this.pnlContainer.Controls.Add(this.pnlDataEntry);
            this.pnlContainer.Location = new System.Drawing.Point(4, 5);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1336, 1031);
            this.pnlContainer.TabIndex = 1;
            // 
            // grpboxSearch
            // 
            this.grpboxSearch.BackColor = System.Drawing.Color.LightCyan;
            this.grpboxSearch.Controls.Add(this.label8);
            this.grpboxSearch.Controls.Add(this.txtAccountTitle);
            this.grpboxSearch.Controls.Add(this.btnsearch);
            this.grpboxSearch.Controls.Add(this.cboControlAccSearch);
            this.grpboxSearch.Controls.Add(this.label16);
            this.grpboxSearch.Controls.Add(this.cboSubLedgerSearch);
            this.grpboxSearch.Controls.Add(this.label15);
            this.grpboxSearch.Controls.Add(this.txtCodeSearch);
            this.grpboxSearch.Controls.Add(this.label14);
            this.grpboxSearch.Location = new System.Drawing.Point(309, 500);
            this.grpboxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxSearch.Name = "grpboxSearch";
            this.grpboxSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxSearch.Size = new System.Drawing.Size(1023, 92);
            this.grpboxSearch.TabIndex = 20;
            this.grpboxSearch.TabStop = false;
            this.grpboxSearch.Text = "Quick Search ";
            // 
            // btnsearch
            // 
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(906, 17);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(112, 68);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cboControlAccSearch
            // 
            this.cboControlAccSearch.FormattingEnabled = true;
            this.cboControlAccSearch.Items.AddRange(new object[] {
            "",
            "Dr",
            "Cr"});
            this.cboControlAccSearch.Location = new System.Drawing.Point(678, 47);
            this.cboControlAccSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboControlAccSearch.Name = "cboControlAccSearch";
            this.cboControlAccSearch.Size = new System.Drawing.Size(224, 28);
            this.cboControlAccSearch.TabIndex = 29;
            this.cboControlAccSearch.SelectedIndexChanged += new System.EventHandler(this.cboControlAccSearch_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(664, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Control Acc";
            // 
            // cboSubLedgerSearch
            // 
            this.cboSubLedgerSearch.FormattingEnabled = true;
            this.cboSubLedgerSearch.Items.AddRange(new object[] {
            "",
            "Dr",
            "Cr"});
            this.cboSubLedgerSearch.Location = new System.Drawing.Point(442, 47);
            this.cboSubLedgerSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubLedgerSearch.Name = "cboSubLedgerSearch";
            this.cboSubLedgerSearch.Size = new System.Drawing.Size(224, 28);
            this.cboSubLedgerSearch.TabIndex = 26;
            this.cboSubLedgerSearch.SelectedIndexChanged += new System.EventHandler(this.cboSubLedgerSearch_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(438, 24);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Sub Ledger";
            // 
            // txtCodeSearch
            // 
            this.txtCodeSearch.Location = new System.Drawing.Point(14, 49);
            this.txtCodeSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeSearch.Name = "txtCodeSearch";
            this.txtCodeSearch.Size = new System.Drawing.Size(168, 26);
            this.txtCodeSearch.TabIndex = 26;
            this.txtCodeSearch.TextChanged += new System.EventHandler(this.txtCodeSearch_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Account Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 582);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Doubleclick on a record to view details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Subcidiary Accounts";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(651, 18);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 20);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "--";
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(498, 455);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 35);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Location = new System.Drawing.Point(604, 455);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(726, 455);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 35);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pnlListing
            // 
            this.pnlListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlListing.Controls.Add(this.gdvList);
            this.pnlListing.Location = new System.Drawing.Point(4, 602);
            this.pnlListing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlListing.Name = "pnlListing";
            this.pnlListing.Size = new System.Drawing.Size(1328, 468);
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
            this.gdvList.Location = new System.Drawing.Point(4, 5);
            this.gdvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdvList.Name = "gdvList";
            this.gdvList.ReadOnly = true;
            this.gdvList.RowHeadersWidth = 62;
            this.gdvList.Size = new System.Drawing.Size(1318, 419);
            this.gdvList.TabIndex = 0;
            this.gdvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvList_CellDoubleClick);
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlDataEntry.Controls.Add(this.txtAddress);
            this.pnlDataEntry.Controls.Add(this.cboBranch);
            this.pnlDataEntry.Controls.Add(this.label13);
            this.pnlDataEntry.Controls.Add(this.label12);
            this.pnlDataEntry.Controls.Add(this.txtEmail);
            this.pnlDataEntry.Controls.Add(this.label11);
            this.pnlDataEntry.Controls.Add(this.txtPhone);
            this.pnlDataEntry.Controls.Add(this.label6);
            this.pnlDataEntry.Controls.Add(this.chkActive);
            this.pnlDataEntry.Controls.Add(this.cboDebitCredit);
            this.pnlDataEntry.Controls.Add(this.txtOpeningBal);
            this.pnlDataEntry.Controls.Add(this.txtTitle);
            this.pnlDataEntry.Controls.Add(this.label10);
            this.pnlDataEntry.Controls.Add(this.cboNorminalAcc);
            this.pnlDataEntry.Controls.Add(this.label5);
            this.pnlDataEntry.Controls.Add(this.label4);
            this.pnlDataEntry.Controls.Add(this.cboLedgerCategory);
            this.pnlDataEntry.Controls.Add(this.label3);
            this.pnlDataEntry.Controls.Add(this.label2);
            this.pnlDataEntry.Controls.Add(this.label1);
            this.pnlDataEntry.Controls.Add(this.txtcode);
            this.pnlDataEntry.Location = new System.Drawing.Point(4, 43);
            this.pnlDataEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(1328, 408);
            this.pnlDataEntry.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(366, 303);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(468, 98);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Text = "";
            // 
            // cboBranch
            // 
            this.cboBranch.FormattingEnabled = true;
            this.cboBranch.Location = new System.Drawing.Point(16, 371);
            this.cboBranch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBranch.Name = "cboBranch";
            this.cboBranch.Size = new System.Drawing.Size(319, 28);
            this.cboBranch.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 346);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Branch/Station";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(362, 282);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Physical Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 311);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 26);
            this.txtEmail.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 282);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(366, 246);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(319, 26);
            this.txtPhone.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(362, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telephone Contact";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(14, 215);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(156, 24);
            this.chkActive.TabIndex = 17;
            this.chkActive.Text = "Account is Active";
            this.chkActive.UseVisualStyleBackColor = false;
            // 
            // cboDebitCredit
            // 
            this.cboDebitCredit.FormattingEnabled = true;
            this.cboDebitCredit.Items.AddRange(new object[] {
            "",
            "Dr",
            "Cr"});
            this.cboDebitCredit.Location = new System.Drawing.Point(366, 168);
            this.cboDebitCredit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDebitCredit.Name = "cboDebitCredit";
            this.cboDebitCredit.Size = new System.Drawing.Size(319, 28);
            this.cboDebitCredit.TabIndex = 16;
            // 
            // txtOpeningBal
            // 
            this.txtOpeningBal.Location = new System.Drawing.Point(366, 103);
            this.txtOpeningBal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOpeningBal.Name = "txtOpeningBal";
            this.txtOpeningBal.Size = new System.Drawing.Size(319, 26);
            this.txtOpeningBal.TabIndex = 15;
            this.txtOpeningBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningBal_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(366, 32);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(319, 26);
            this.txtTitle.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(360, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Debit/Credit";
            // 
            // cboNorminalAcc
            // 
            this.cboNorminalAcc.FormattingEnabled = true;
            this.cboNorminalAcc.Location = new System.Drawing.Point(16, 165);
            this.cboNorminalAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNorminalAcc.Name = "cboNorminalAcc";
            this.cboNorminalAcc.Size = new System.Drawing.Size(319, 28);
            this.cboNorminalAcc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Norminal Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(360, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opening Balance";
            // 
            // cboLedgerCategory
            // 
            this.cboLedgerCategory.FormattingEnabled = true;
            this.cboLedgerCategory.Location = new System.Drawing.Point(16, 103);
            this.cboLedgerCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLedgerCategory.Name = "cboLedgerCategory";
            this.cboLedgerCategory.Size = new System.Drawing.Size(319, 28);
            this.cboLedgerCategory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(360, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Ledger Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Code";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(16, 32);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(319, 26);
            this.txtcode.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = true;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 1050D;
            this.reSize1.InitialHostContainerWidth = 1346D;
            this.reSize1.Tag = null;
            // 
            // txtAccountTitle
            // 
            this.txtAccountTitle.Location = new System.Drawing.Point(193, 49);
            this.txtAccountTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.Size = new System.Drawing.Size(241, 26);
            this.txtAccountTitle.TabIndex = 30;
            this.txtAccountTitle.TextChanged += new System.EventHandler(this.txtAccountTitle_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Account Title";
            // 
            // frmsubsidiaryAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1346, 1050);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmsubsidiaryAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Subsidiary Accounts";
            this.Load += new System.EventHandler(this.fromsubsidiaryAccount_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.grpboxSearch.ResumeLayout(false);
            this.grpboxSearch.PerformLayout();
            this.pnlListing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlDataEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel pnlListing;
        private System.Windows.Forms.DataGridView gdvList;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboNorminalAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLedgerCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpeningBal;
        private System.Windows.Forms.ComboBox cboDebitCredit;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.GroupBox grpboxSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodeSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboSubLedgerSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboControlAccSearch;
        private System.Windows.Forms.Button btnsearch;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccountTitle;
    }
}