namespace Accounts
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.cboDebitAccount = new System.Windows.Forms.ComboBox();
            this.chkOnHold = new System.Windows.Forms.CheckBox();
            this.grpboxJournalEntryListing = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.chkPosted = new System.Windows.Forms.CheckBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.grpboxQuickActions = new System.Windows.Forms.GroupBox();
            this.btnPrintInv = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGeneralLedger = new System.Windows.Forms.Button();
            this.cboCreditAccount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.txt_refference_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.grpboxJournalEntrySearch = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtchequesearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtrefsearch = new System.Windows.Forms.TextBox();
            this.xDatesearch = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPickersearchTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickersearchfrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.grpboxEntry = new System.Windows.Forms.GroupBox();
            this.chkAudited = new System.Windows.Forms.CheckBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDaysCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGuardCount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboPayee = new System.Windows.Forms.ComboBox();
            this.cboDrCr = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboSubAccount = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOuterContainer = new System.Windows.Forms.Panel();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cboFy = new System.Windows.Forms.ComboBox();
            this.grpboxPostTransactions = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.dtPickerPost = new System.Windows.Forms.DateTimePicker();
            this.grpboxJournalEntryListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.grpboxQuickActions.SuspendLayout();
            this.grpboxJournalEntrySearch.SuspendLayout();
            this.xDatesearch.SuspendLayout();
            this.grpboxEntry.SuspendLayout();
            this.pnlOuterContainer.SuspendLayout();
            this.grpboxPostTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client";
            // 
            // cboDebitAccount
            // 
            this.cboDebitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDebitAccount.FormattingEnabled = true;
            this.cboDebitAccount.Location = new System.Drawing.Point(14, 688);
            this.cboDebitAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDebitAccount.Name = "cboDebitAccount";
            this.cboDebitAccount.Size = new System.Drawing.Size(370, 26);
            this.cboDebitAccount.TabIndex = 18;
            // 
            // chkOnHold
            // 
            this.chkOnHold.AutoSize = true;
            this.chkOnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkOnHold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOnHold.Location = new System.Drawing.Point(194, 790);
            this.chkOnHold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOnHold.Name = "chkOnHold";
            this.chkOnHold.Size = new System.Drawing.Size(161, 22);
            this.chkOnHold.TabIndex = 17;
            this.chkOnHold.Text = "Transaction on hold";
            this.chkOnHold.UseVisualStyleBackColor = false;
            // 
            // grpboxJournalEntryListing
            // 
            this.grpboxJournalEntryListing.BackColor = System.Drawing.SystemColors.Info;
            this.grpboxJournalEntryListing.Controls.Add(this.grpboxPostTransactions);
            this.grpboxJournalEntryListing.Controls.Add(this.btnDelete);
            this.grpboxJournalEntryListing.Controls.Add(this.gdvList);
            this.grpboxJournalEntryListing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpboxJournalEntryListing.Location = new System.Drawing.Point(605, 123);
            this.grpboxJournalEntryListing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxJournalEntryListing.Name = "grpboxJournalEntryListing";
            this.grpboxJournalEntryListing.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxJournalEntryListing.Size = new System.Drawing.Size(1310, 901);
            this.grpboxJournalEntryListing.TabIndex = 1;
            this.grpboxJournalEntryListing.TabStop = false;
            this.grpboxJournalEntryListing.Text = "Invoice Entry Listing";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1146, 849);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gdvList
            // 
            this.gdvList.AllowUserToAddRows = false;
            this.gdvList.AllowUserToDeleteRows = false;
            this.gdvList.AllowUserToResizeRows = false;
            this.gdvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvList.Location = new System.Drawing.Point(8, 23);
            this.gdvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdvList.Name = "gdvList";
            this.gdvList.ReadOnly = true;
            this.gdvList.RowHeadersWidth = 62;
            this.gdvList.Size = new System.Drawing.Size(1297, 762);
            this.gdvList.TabIndex = 0;
            this.gdvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvList_CellDoubleClick);
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkPosted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPosted.Location = new System.Drawing.Point(12, 790);
            this.chkPosted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(156, 22);
            this.chkPosted.TabIndex = 16;
            this.chkPosted.Text = "Transacton Posted";
            this.chkPosted.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(14, 624);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(370, 24);
            this.txtAmount.TabIndex = 15;
            // 
            // grpboxQuickActions
            // 
            this.grpboxQuickActions.BackColor = System.Drawing.Color.AliceBlue;
            this.grpboxQuickActions.Controls.Add(this.btnPrintInv);
            this.grpboxQuickActions.Controls.Add(this.lblID);
            this.grpboxQuickActions.Controls.Add(this.btnGeneralLedger);
            this.grpboxQuickActions.ForeColor = System.Drawing.Color.Blue;
            this.grpboxQuickActions.Location = new System.Drawing.Point(4, 892);
            this.grpboxQuickActions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxQuickActions.Name = "grpboxQuickActions";
            this.grpboxQuickActions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxQuickActions.Size = new System.Drawing.Size(582, 127);
            this.grpboxQuickActions.TabIndex = 1;
            this.grpboxQuickActions.TabStop = false;
            this.grpboxQuickActions.Text = "Quick Actions";
            // 
            // btnPrintInv
            // 
            this.btnPrintInv.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrintInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInv.ForeColor = System.Drawing.Color.White;
            this.btnPrintInv.Location = new System.Drawing.Point(240, 29);
            this.btnPrintInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintInv.Name = "btnPrintInv";
            this.btnPrintInv.Size = new System.Drawing.Size(222, 43);
            this.btnPrintInv.TabIndex = 4;
            this.btnPrintInv.Text = "Print selected invoice";
            this.btnPrintInv.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(0, 129);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "--";
            // 
            // btnGeneralLedger
            // 
            this.btnGeneralLedger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGeneralLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralLedger.ForeColor = System.Drawing.Color.White;
            this.btnGeneralLedger.Location = new System.Drawing.Point(9, 29);
            this.btnGeneralLedger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeneralLedger.Name = "btnGeneralLedger";
            this.btnGeneralLedger.Size = new System.Drawing.Size(222, 43);
            this.btnGeneralLedger.TabIndex = 3;
            this.btnGeneralLedger.Text = "View General Ledger";
            this.btnGeneralLedger.UseVisualStyleBackColor = false;
            // 
            // cboCreditAccount
            // 
            this.cboCreditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCreditAccount.FormattingEnabled = true;
            this.cboCreditAccount.Location = new System.Drawing.Point(22, 752);
            this.cboCreditAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCreditAccount.Name = "cboCreditAccount";
            this.cboCreditAccount.Size = new System.Drawing.Size(366, 26);
            this.cboCreditAccount.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(4, 603);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 723);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Credit Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 661);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Debit Account";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(9, 515);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(374, 81);
            this.txt_description.TabIndex = 9;
            this.txt_description.Text = "";
            // 
            // txt_refference_number
            // 
            this.txt_refference_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refference_number.Location = new System.Drawing.Point(9, 122);
            this.txt_refference_number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_refference_number.Name = "txt_refference_number";
            this.txt_refference_number.Size = new System.Drawing.Size(374, 24);
            this.txt_refference_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Refference Number";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Checked = false;
            this.dtPickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDate.Location = new System.Drawing.Point(9, 55);
            this.dtPickerDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.ShowCheckBox = true;
            this.dtPickerDate.Size = new System.Drawing.Size(374, 24);
            this.dtPickerDate.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(75, 839);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(210, 43);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Invoice";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Magenta;
            this.btnEdit.Location = new System.Drawing.Point(294, 839);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 43);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(446, 839);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(153, 43);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grpboxJournalEntrySearch
            // 
            this.grpboxJournalEntrySearch.BackColor = System.Drawing.Color.GhostWhite;
            this.grpboxJournalEntrySearch.Controls.Add(this.btnsearch);
            this.grpboxJournalEntrySearch.Controls.Add(this.label13);
            this.grpboxJournalEntrySearch.Controls.Add(this.txtchequesearch);
            this.grpboxJournalEntrySearch.Controls.Add(this.label12);
            this.grpboxJournalEntrySearch.Controls.Add(this.txtrefsearch);
            this.grpboxJournalEntrySearch.Controls.Add(this.xDatesearch);
            this.grpboxJournalEntrySearch.ForeColor = System.Drawing.Color.Blue;
            this.grpboxJournalEntrySearch.Location = new System.Drawing.Point(606, 5);
            this.grpboxJournalEntrySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxJournalEntrySearch.Name = "grpboxJournalEntrySearch";
            this.grpboxJournalEntrySearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxJournalEntrySearch.Size = new System.Drawing.Size(864, 115);
            this.grpboxJournalEntrySearch.TabIndex = 2;
            this.grpboxJournalEntrySearch.TabStop = false;
            this.grpboxJournalEntrySearch.Text = "Invoice Entry Search Panel";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(722, 45);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(130, 63);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(562, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cheque Number";
            // 
            // txtchequesearch
            // 
            this.txtchequesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequesearch.Location = new System.Drawing.Point(562, 71);
            this.txtchequesearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtchequesearch.Name = "txtchequesearch";
            this.txtchequesearch.Size = new System.Drawing.Size(151, 24);
            this.txtchequesearch.TabIndex = 28;
            this.txtchequesearch.TextChanged += new System.EventHandler(this.txtchequesearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(408, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Reference Number";
            // 
            // txtrefsearch
            // 
            this.txtrefsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefsearch.Location = new System.Drawing.Point(408, 71);
            this.txtrefsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrefsearch.Name = "txtrefsearch";
            this.txtrefsearch.Size = new System.Drawing.Size(144, 24);
            this.txtrefsearch.TabIndex = 24;
            this.txtrefsearch.TextChanged += new System.EventHandler(this.txtrefsearch_TextChanged);
            // 
            // xDatesearch
            // 
            this.xDatesearch.BackColor = System.Drawing.Color.Lavender;
            this.xDatesearch.Controls.Add(this.label11);
            this.xDatesearch.Controls.Add(this.label10);
            this.xDatesearch.Controls.Add(this.dtPickersearchTo);
            this.xDatesearch.Controls.Add(this.dtPickersearchfrom);
            this.xDatesearch.Location = new System.Drawing.Point(9, 26);
            this.xDatesearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xDatesearch.Name = "xDatesearch";
            this.xDatesearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xDatesearch.Size = new System.Drawing.Size(390, 80);
            this.xDatesearch.TabIndex = 0;
            this.xDatesearch.TabStop = false;
            this.xDatesearch.Text = "Date Range";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(178, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(9, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "From";
            // 
            // dtPickersearchTo
            // 
            this.dtPickersearchTo.Checked = false;
            this.dtPickersearchTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickersearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickersearchTo.Location = new System.Drawing.Point(178, 45);
            this.dtPickersearchTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPickersearchTo.Name = "dtPickersearchTo";
            this.dtPickersearchTo.ShowCheckBox = true;
            this.dtPickersearchTo.Size = new System.Drawing.Size(158, 24);
            this.dtPickersearchTo.TabIndex = 25;
            // 
            // dtPickersearchfrom
            // 
            this.dtPickersearchfrom.Checked = false;
            this.dtPickersearchfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickersearchfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickersearchfrom.Location = new System.Drawing.Point(9, 45);
            this.dtPickersearchfrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPickersearchfrom.Name = "dtPickersearchfrom";
            this.dtPickersearchfrom.ShowCheckBox = true;
            this.dtPickersearchfrom.Size = new System.Drawing.Size(158, 24);
            this.dtPickersearchfrom.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Particulars";
            // 
            // grpboxEntry
            // 
            this.grpboxEntry.BackColor = System.Drawing.Color.Azure;
            this.grpboxEntry.Controls.Add(this.label9);
            this.grpboxEntry.Controls.Add(this.cboFy);
            this.grpboxEntry.Controls.Add(this.chkAudited);
            this.grpboxEntry.Controls.Add(this.txtrate);
            this.grpboxEntry.Controls.Add(this.label18);
            this.grpboxEntry.Controls.Add(this.txtDaysCount);
            this.grpboxEntry.Controls.Add(this.label17);
            this.grpboxEntry.Controls.Add(this.txtGuardCount);
            this.grpboxEntry.Controls.Add(this.label16);
            this.grpboxEntry.Controls.Add(this.cboPayee);
            this.grpboxEntry.Controls.Add(this.cboDrCr);
            this.grpboxEntry.Controls.Add(this.label15);
            this.grpboxEntry.Controls.Add(this.cboSubAccount);
            this.grpboxEntry.Controls.Add(this.label14);
            this.grpboxEntry.Controls.Add(this.label1);
            this.grpboxEntry.Controls.Add(this.cboCreditAccount);
            this.grpboxEntry.Controls.Add(this.cboDebitAccount);
            this.grpboxEntry.Controls.Add(this.chkOnHold);
            this.grpboxEntry.Controls.Add(this.chkPosted);
            this.grpboxEntry.Controls.Add(this.txtAmount);
            this.grpboxEntry.Controls.Add(this.label8);
            this.grpboxEntry.Controls.Add(this.label7);
            this.grpboxEntry.Controls.Add(this.label6);
            this.grpboxEntry.Controls.Add(this.txt_description);
            this.grpboxEntry.Controls.Add(this.label5);
            this.grpboxEntry.Controls.Add(this.txt_refference_number);
            this.grpboxEntry.Controls.Add(this.label3);
            this.grpboxEntry.Controls.Add(this.dtPickerDate);
            this.grpboxEntry.Controls.Add(this.label2);
            this.grpboxEntry.ForeColor = System.Drawing.Color.Blue;
            this.grpboxEntry.Location = new System.Drawing.Point(15, 5);
            this.grpboxEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxEntry.Name = "grpboxEntry";
            this.grpboxEntry.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpboxEntry.Size = new System.Drawing.Size(582, 824);
            this.grpboxEntry.TabIndex = 0;
            this.grpboxEntry.TabStop = false;
            this.grpboxEntry.Text = "Invoice Entry Panel";
            // 
            // chkAudited
            // 
            this.chkAudited.AutoSize = true;
            this.chkAudited.BackColor = System.Drawing.Color.Khaki;
            this.chkAudited.Enabled = false;
            this.chkAudited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudited.Location = new System.Drawing.Point(384, 790);
            this.chkAudited.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAudited.Name = "chkAudited";
            this.chkAudited.Size = new System.Drawing.Size(78, 22);
            this.chkAudited.TabIndex = 35;
            this.chkAudited.Text = "Audited";
            this.chkAudited.UseVisualStyleBackColor = false;
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(9, 449);
            this.txtrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrate.Name = "txtrate";
            this.txtrate.ReadOnly = true;
            this.txtrate.Size = new System.Drawing.Size(374, 24);
            this.txtrate.TabIndex = 34;
            this.txtrate.Text = "17700.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(4, 420);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "Rate";
            // 
            // txtDaysCount
            // 
            this.txtDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysCount.Location = new System.Drawing.Point(200, 387);
            this.txtDaysCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDaysCount.Name = "txtDaysCount";
            this.txtDaysCount.Size = new System.Drawing.Size(182, 24);
            this.txtDaysCount.TabIndex = 32;
            this.txtDaysCount.TextChanged += new System.EventHandler(this.txtDaysCount_TextChanged);
            this.txtDaysCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaysCount_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(205, 358);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "#Days";
            // 
            // txtGuardCount
            // 
            this.txtGuardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardCount.Location = new System.Drawing.Point(8, 387);
            this.txtGuardCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuardCount.Name = "txtGuardCount";
            this.txtGuardCount.Size = new System.Drawing.Size(176, 24);
            this.txtGuardCount.TabIndex = 30;
            this.txtGuardCount.TextChanged += new System.EventHandler(this.txtGuardCount_TextChanged);
            this.txtGuardCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardCount_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(3, 358);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "# Guards";
            // 
            // cboPayee
            // 
            this.cboPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayee.FormattingEnabled = true;
            this.cboPayee.Location = new System.Drawing.Point(8, 318);
            this.cboPayee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Size = new System.Drawing.Size(374, 26);
            this.cboPayee.TabIndex = 28;
            // 
            // cboDrCr
            // 
            this.cboDrCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrCr.FormattingEnabled = true;
            this.cboDrCr.Location = new System.Drawing.Point(8, 248);
            this.cboDrCr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDrCr.Name = "cboDrCr";
            this.cboDrCr.Size = new System.Drawing.Size(374, 26);
            this.cboDrCr.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(3, 219);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Debit or Credit?";
            // 
            // cboSubAccount
            // 
            this.cboSubAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubAccount.FormattingEnabled = true;
            this.cboSubAccount.Location = new System.Drawing.Point(8, 179);
            this.cboSubAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubAccount.Name = "cboSubAccount";
            this.cboSubAccount.Size = new System.Drawing.Size(374, 26);
            this.cboSubAccount.TabIndex = 25;
            this.cboSubAccount.SelectedIndexChanged += new System.EventHandler(this.cboSubAccount_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(3, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Sub-Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // pnlOuterContainer
            // 
            this.pnlOuterContainer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlOuterContainer.Controls.Add(this.btnNew);
            this.pnlOuterContainer.Controls.Add(this.btnEdit);
            this.pnlOuterContainer.Controls.Add(this.btnsave);
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntrySearch);
            this.pnlOuterContainer.Controls.Add(this.grpboxQuickActions);
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntryListing);
            this.pnlOuterContainer.Controls.Add(this.grpboxEntry);
            this.pnlOuterContainer.Location = new System.Drawing.Point(1, 4);
            this.pnlOuterContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Size = new System.Drawing.Size(1919, 1029);
            this.pnlOuterContainer.TabIndex = 1;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 1050D;
            this.reSize1.InitialHostContainerWidth = 1924D;
            this.reSize1.Tag = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(403, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Financial Year";
            // 
            // cboFy
            // 
            this.cboFy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFy.FormattingEnabled = true;
            this.cboFy.Location = new System.Drawing.Point(407, 53);
            this.cboFy.Name = "cboFy";
            this.cboFy.Size = new System.Drawing.Size(145, 26);
            this.cboFy.TabIndex = 38;
            // 
            // grpboxPostTransactions
            // 
            this.grpboxPostTransactions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpboxPostTransactions.Controls.Add(this.label19);
            this.grpboxPostTransactions.Controls.Add(this.btnPost);
            this.grpboxPostTransactions.Controls.Add(this.dtPickerPost);
            this.grpboxPostTransactions.Location = new System.Drawing.Point(10, 793);
            this.grpboxPostTransactions.Name = "grpboxPostTransactions";
            this.grpboxPostTransactions.Size = new System.Drawing.Size(506, 100);
            this.grpboxPostTransactions.TabIndex = 10;
            this.grpboxPostTransactions.TabStop = false;
            this.grpboxPostTransactions.Text = "Select a Date and click the button to post all transactions for the selected date" +
    "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(174, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "Transaction Date";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.Color.Blue;
            this.btnPost.Location = new System.Drawing.Point(9, 56);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(233, 38);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "Post Transactions";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // dtPickerPost
            // 
            this.dtPickerPost.Checked = false;
            this.dtPickerPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerPost.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerPost.Location = new System.Drawing.Point(248, 60);
            this.dtPickerPost.Name = "dtPickerPost";
            this.dtPickerPost.ShowCheckBox = true;
            this.dtPickerPost.Size = new System.Drawing.Size(174, 24);
            this.dtPickerPost.TabIndex = 8;
            this.dtPickerPost.ValueChanged += new System.EventHandler(this.dtPickerPost_ValueChanged);
            // 
            // frmInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.pnlOuterContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Manager";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.grpboxJournalEntryListing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.grpboxQuickActions.ResumeLayout(false);
            this.grpboxQuickActions.PerformLayout();
            this.grpboxJournalEntrySearch.ResumeLayout(false);
            this.grpboxJournalEntrySearch.PerformLayout();
            this.xDatesearch.ResumeLayout(false);
            this.xDatesearch.PerformLayout();
            this.grpboxEntry.ResumeLayout(false);
            this.grpboxEntry.PerformLayout();
            this.pnlOuterContainer.ResumeLayout(false);
            this.grpboxPostTransactions.ResumeLayout(false);
            this.grpboxPostTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDebitAccount;
        private System.Windows.Forms.CheckBox chkOnHold;
        private System.Windows.Forms.GroupBox grpboxJournalEntryListing;
        private System.Windows.Forms.DataGridView gdvList;
        private System.Windows.Forms.CheckBox chkPosted;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox grpboxQuickActions;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnGeneralLedger;
        private System.Windows.Forms.ComboBox cboCreditAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TextBox txt_refference_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox grpboxJournalEntrySearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtchequesearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrefsearch;
        private System.Windows.Forms.GroupBox xDatesearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickersearchTo;
        private System.Windows.Forms.DateTimePicker dtPickersearchfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlOuterContainer;
        private System.Windows.Forms.GroupBox grpboxEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSubAccount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboDrCr;
        private System.Windows.Forms.ComboBox cboPayee;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGuardCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDaysCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.CheckBox chkAudited;
        private System.Windows.Forms.Button btnPrintInv;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFy;
        private System.Windows.Forms.GroupBox grpboxPostTransactions;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DateTimePicker dtPickerPost;
    }
}