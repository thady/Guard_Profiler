namespace Accounts
{
    partial class frmJournalEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournalEntry));
            this.pnlOuterContainer = new System.Windows.Forms.Panel();
            this.pnlsave = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.chksimultaneousoffOn = new System.Windows.Forms.CheckBox();
            this.chkAudited = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCredit = new System.Windows.Forms.TextBox();
            this.txtTotalDebit = new System.Windows.Forms.TextBox();
            this.chkOnHold = new System.Windows.Forms.CheckBox();
            this.chkPosted = new System.Windows.Forms.CheckBox();
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
            this.grpboxQuickActions = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGeneralLedger = new System.Windows.Forms.Button();
            this.grpboxJournalEntryListing = new System.Windows.Forms.GroupBox();
            this.grpboxPostTransactions = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.dtPickerPost = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.grpboxJournalEntry = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboDrCr = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboPayee = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboSubAccount = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboFy = new System.Windows.Forms.ComboBox();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCreditAccount = new System.Windows.Forms.ComboBox();
            this.cboDebitAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cheque_number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_refference_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.pnlOuterContainer.SuspendLayout();
            this.pnlsave.SuspendLayout();
            this.grpboxJournalEntrySearch.SuspendLayout();
            this.xDatesearch.SuspendLayout();
            this.grpboxQuickActions.SuspendLayout();
            this.grpboxJournalEntryListing.SuspendLayout();
            this.grpboxPostTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.grpboxJournalEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuterContainer
            // 
            this.pnlOuterContainer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlOuterContainer.Controls.Add(this.pnlsave);
            this.pnlOuterContainer.Controls.Add(this.chksimultaneousoffOn);
            this.pnlOuterContainer.Controls.Add(this.chkAudited);
            this.pnlOuterContainer.Controls.Add(this.label14);
            this.pnlOuterContainer.Controls.Add(this.label9);
            this.pnlOuterContainer.Controls.Add(this.txtTotalCredit);
            this.pnlOuterContainer.Controls.Add(this.txtTotalDebit);
            this.pnlOuterContainer.Controls.Add(this.chkOnHold);
            this.pnlOuterContainer.Controls.Add(this.chkPosted);
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntrySearch);
            this.pnlOuterContainer.Controls.Add(this.grpboxQuickActions);
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntryListing);
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntry);
            this.pnlOuterContainer.Location = new System.Drawing.Point(2, 4);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Size = new System.Drawing.Size(1075, 875);
            this.pnlOuterContainer.TabIndex = 0;
            // 
            // pnlsave
            // 
            this.pnlsave.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlsave.Controls.Add(this.btnNew);
            this.pnlsave.Controls.Add(this.btnEdit);
            this.pnlsave.Controls.Add(this.btnsave);
            this.pnlsave.Location = new System.Drawing.Point(9, 727);
            this.pnlsave.Name = "pnlsave";
            this.pnlsave.Size = new System.Drawing.Size(418, 57);
            this.pnlsave.TabIndex = 41;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(4, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 47);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Journal Entry";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Magenta;
            this.btnEdit.Location = new System.Drawing.Point(147, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 47);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(284, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 47);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // chksimultaneousoffOn
            // 
            this.chksimultaneousoffOn.AutoSize = true;
            this.chksimultaneousoffOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chksimultaneousoffOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksimultaneousoffOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chksimultaneousoffOn.Location = new System.Drawing.Point(13, 7);
            this.chksimultaneousoffOn.Name = "chksimultaneousoffOn";
            this.chksimultaneousoffOn.Size = new System.Drawing.Size(298, 21);
            this.chksimultaneousoffOn.TabIndex = 40;
            this.chksimultaneousoffOn.Text = "Allow Non simultaneous journal entry";
            this.chksimultaneousoffOn.UseVisualStyleBackColor = false;
            this.chksimultaneousoffOn.CheckedChanged += new System.EventHandler(this.chksimultaneousoffOn_CheckedChanged);
            // 
            // chkAudited
            // 
            this.chkAudited.AutoSize = true;
            this.chkAudited.BackColor = System.Drawing.Color.Khaki;
            this.chkAudited.Enabled = false;
            this.chkAudited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudited.Location = new System.Drawing.Point(309, 637);
            this.chkAudited.Name = "chkAudited";
            this.chkAudited.Size = new System.Drawing.Size(78, 21);
            this.chkAudited.TabIndex = 36;
            this.chkAudited.Text = "Audited";
            this.chkAudited.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(209, 664);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Total Credits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(10, 664);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Total Debits";
            // 
            // txtTotalCredit
            // 
            this.txtTotalCredit.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTotalCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCredit.ForeColor = System.Drawing.Color.White;
            this.txtTotalCredit.Location = new System.Drawing.Point(213, 687);
            this.txtTotalCredit.Name = "txtTotalCredit";
            this.txtTotalCredit.ReadOnly = true;
            this.txtTotalCredit.Size = new System.Drawing.Size(207, 34);
            this.txtTotalCredit.TabIndex = 38;
            this.txtTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalDebit
            // 
            this.txtTotalDebit.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTotalDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDebit.ForeColor = System.Drawing.Color.White;
            this.txtTotalDebit.Location = new System.Drawing.Point(9, 687);
            this.txtTotalDebit.Name = "txtTotalDebit";
            this.txtTotalDebit.ReadOnly = true;
            this.txtTotalDebit.Size = new System.Drawing.Size(178, 34);
            this.txtTotalDebit.TabIndex = 37;
            this.txtTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkOnHold
            // 
            this.chkOnHold.AutoSize = true;
            this.chkOnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkOnHold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOnHold.Location = new System.Drawing.Point(156, 639);
            this.chkOnHold.Name = "chkOnHold";
            this.chkOnHold.Size = new System.Drawing.Size(156, 21);
            this.chkOnHold.TabIndex = 17;
            this.chkOnHold.Text = "Transaction on hold";
            this.chkOnHold.UseVisualStyleBackColor = false;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkPosted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPosted.Location = new System.Drawing.Point(11, 639);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(150, 21);
            this.chkPosted.TabIndex = 16;
            this.chkPosted.Text = "Transacton Posted";
            this.chkPosted.UseVisualStyleBackColor = false;
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
            this.grpboxJournalEntrySearch.Location = new System.Drawing.Point(433, 8);
            this.grpboxJournalEntrySearch.Name = "grpboxJournalEntrySearch";
            this.grpboxJournalEntrySearch.Size = new System.Drawing.Size(639, 117);
            this.grpboxJournalEntrySearch.TabIndex = 2;
            this.grpboxJournalEntrySearch.TabStop = false;
            this.grpboxJournalEntrySearch.Text = "Journal Entry Search Panel";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(538, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 84);
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
            this.label13.Location = new System.Drawing.Point(416, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cheque No.";
            // 
            // txtchequesearch
            // 
            this.txtchequesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequesearch.Location = new System.Drawing.Point(419, 66);
            this.txtchequesearch.Name = "txtchequesearch";
            this.txtchequesearch.Size = new System.Drawing.Size(102, 24);
            this.txtchequesearch.TabIndex = 28;
            this.txtchequesearch.TextChanged += new System.EventHandler(this.txtchequesearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(282, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Reference No.";
            // 
            // txtrefsearch
            // 
            this.txtrefsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefsearch.Location = new System.Drawing.Point(281, 66);
            this.txtrefsearch.Name = "txtrefsearch";
            this.txtrefsearch.Size = new System.Drawing.Size(97, 24);
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
            this.xDatesearch.Location = new System.Drawing.Point(15, 20);
            this.xDatesearch.Name = "xDatesearch";
            this.xDatesearch.Size = new System.Drawing.Size(260, 90);
            this.xDatesearch.TabIndex = 0;
            this.xDatesearch.TabStop = false;
            this.xDatesearch.Text = "Date Range";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(130, 26);
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
            this.label10.Location = new System.Drawing.Point(6, 25);
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
            this.dtPickersearchTo.Location = new System.Drawing.Point(133, 46);
            this.dtPickersearchTo.Name = "dtPickersearchTo";
            this.dtPickersearchTo.ShowCheckBox = true;
            this.dtPickersearchTo.Size = new System.Drawing.Size(107, 24);
            this.dtPickersearchTo.TabIndex = 25;
            // 
            // dtPickersearchfrom
            // 
            this.dtPickersearchfrom.Checked = false;
            this.dtPickersearchfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickersearchfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickersearchfrom.Location = new System.Drawing.Point(9, 46);
            this.dtPickersearchfrom.Name = "dtPickersearchfrom";
            this.dtPickersearchfrom.ShowCheckBox = true;
            this.dtPickersearchfrom.Size = new System.Drawing.Size(107, 24);
            this.dtPickersearchfrom.TabIndex = 24;
            // 
            // grpboxQuickActions
            // 
            this.grpboxQuickActions.BackColor = System.Drawing.Color.AliceBlue;
            this.grpboxQuickActions.Controls.Add(this.lblID);
            this.grpboxQuickActions.Controls.Add(this.btnGeneralLedger);
            this.grpboxQuickActions.ForeColor = System.Drawing.Color.Blue;
            this.grpboxQuickActions.Location = new System.Drawing.Point(3, 782);
            this.grpboxQuickActions.Name = "grpboxQuickActions";
            this.grpboxQuickActions.Size = new System.Drawing.Size(424, 85);
            this.grpboxQuickActions.TabIndex = 1;
            this.grpboxQuickActions.TabStop = false;
            this.grpboxQuickActions.Text = "Quick Actions";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "--";
            // 
            // btnGeneralLedger
            // 
            this.btnGeneralLedger.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGeneralLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralLedger.ForeColor = System.Drawing.Color.White;
            this.btnGeneralLedger.Location = new System.Drawing.Point(6, 19);
            this.btnGeneralLedger.Name = "btnGeneralLedger";
            this.btnGeneralLedger.Size = new System.Drawing.Size(178, 28);
            this.btnGeneralLedger.TabIndex = 3;
            this.btnGeneralLedger.Text = "View General Ledger";
            this.btnGeneralLedger.UseVisualStyleBackColor = false;
            // 
            // grpboxJournalEntryListing
            // 
            this.grpboxJournalEntryListing.BackColor = System.Drawing.SystemColors.Info;
            this.grpboxJournalEntryListing.Controls.Add(this.grpboxPostTransactions);
            this.grpboxJournalEntryListing.Controls.Add(this.btnDelete);
            this.grpboxJournalEntryListing.Controls.Add(this.gdvList);
            this.grpboxJournalEntryListing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpboxJournalEntryListing.Location = new System.Drawing.Point(433, 128);
            this.grpboxJournalEntryListing.Name = "grpboxJournalEntryListing";
            this.grpboxJournalEntryListing.Size = new System.Drawing.Size(639, 739);
            this.grpboxJournalEntryListing.TabIndex = 1;
            this.grpboxJournalEntryListing.TabStop = false;
            this.grpboxJournalEntryListing.Text = "Journal Entry Listing";
            // 
            // grpboxPostTransactions
            // 
            this.grpboxPostTransactions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpboxPostTransactions.Controls.Add(this.label19);
            this.grpboxPostTransactions.Controls.Add(this.btnPost);
            this.grpboxPostTransactions.Controls.Add(this.dtPickerPost);
            this.grpboxPostTransactions.Location = new System.Drawing.Point(6, 655);
            this.grpboxPostTransactions.Name = "grpboxPostTransactions";
            this.grpboxPostTransactions.Size = new System.Drawing.Size(381, 78);
            this.grpboxPostTransactions.TabIndex = 9;
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
            this.btnPost.Location = new System.Drawing.Point(9, 38);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(159, 28);
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
            this.dtPickerPost.Location = new System.Drawing.Point(174, 42);
            this.dtPickerPost.Name = "dtPickerPost";
            this.dtPickerPost.ShowCheckBox = true;
            this.dtPickerPost.Size = new System.Drawing.Size(174, 24);
            this.dtPickerPost.TabIndex = 8;
            this.dtPickerPost.ValueChanged += new System.EventHandler(this.dtPickerPost_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(474, 693);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 28);
            this.btnDelete.TabIndex = 6;
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
            this.gdvList.Location = new System.Drawing.Point(6, 19);
            this.gdvList.Name = "gdvList";
            this.gdvList.ReadOnly = true;
            this.gdvList.RowHeadersWidth = 62;
            this.gdvList.Size = new System.Drawing.Size(633, 630);
            this.gdvList.TabIndex = 0;
            this.gdvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvList_CellDoubleClick);
            // 
            // grpboxJournalEntry
            // 
            this.grpboxJournalEntry.BackColor = System.Drawing.Color.Azure;
            this.grpboxJournalEntry.Controls.Add(this.label18);
            this.grpboxJournalEntry.Controls.Add(this.cboDrCr);
            this.grpboxJournalEntry.Controls.Add(this.label17);
            this.grpboxJournalEntry.Controls.Add(this.cboPayee);
            this.grpboxJournalEntry.Controls.Add(this.label16);
            this.grpboxJournalEntry.Controls.Add(this.cboSubAccount);
            this.grpboxJournalEntry.Controls.Add(this.label15);
            this.grpboxJournalEntry.Controls.Add(this.cboFy);
            this.grpboxJournalEntry.Controls.Add(this.txtPayee);
            this.grpboxJournalEntry.Controls.Add(this.label1);
            this.grpboxJournalEntry.Controls.Add(this.cboCreditAccount);
            this.grpboxJournalEntry.Controls.Add(this.cboDebitAccount);
            this.grpboxJournalEntry.Controls.Add(this.txtAmount);
            this.grpboxJournalEntry.Controls.Add(this.label8);
            this.grpboxJournalEntry.Controls.Add(this.label7);
            this.grpboxJournalEntry.Controls.Add(this.label6);
            this.grpboxJournalEntry.Controls.Add(this.txt_description);
            this.grpboxJournalEntry.Controls.Add(this.label5);
            this.grpboxJournalEntry.Controls.Add(this.txt_cheque_number);
            this.grpboxJournalEntry.Controls.Add(this.label4);
            this.grpboxJournalEntry.Controls.Add(this.txt_refference_number);
            this.grpboxJournalEntry.Controls.Add(this.label3);
            this.grpboxJournalEntry.Controls.Add(this.dtPickerDate);
            this.grpboxJournalEntry.Controls.Add(this.label2);
            this.grpboxJournalEntry.ForeColor = System.Drawing.Color.Blue;
            this.grpboxJournalEntry.Location = new System.Drawing.Point(10, 34);
            this.grpboxJournalEntry.Name = "grpboxJournalEntry";
            this.grpboxJournalEntry.Size = new System.Drawing.Size(417, 599);
            this.grpboxJournalEntry.TabIndex = 0;
            this.grpboxJournalEntry.TabStop = false;
            this.grpboxJournalEntry.Text = "Journal Entry Panel";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(266, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 20);
            this.label18.TabIndex = 31;
            this.label18.Text = "Debit or Credit";
            // 
            // cboDrCr
            // 
            this.cboDrCr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrCr.FormattingEnabled = true;
            this.cboDrCr.Location = new System.Drawing.Point(266, 193);
            this.cboDrCr.Name = "cboDrCr";
            this.cboDrCr.Size = new System.Drawing.Size(145, 26);
            this.cboDrCr.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Sub-Ledger Payee";
            // 
            // cboPayee
            // 
            this.cboPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayee.FormattingEnabled = true;
            this.cboPayee.Location = new System.Drawing.Point(10, 253);
            this.cboPayee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Size = new System.Drawing.Size(248, 26);
            this.cboPayee.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Sub-Ledger";
            // 
            // cboSubAccount
            // 
            this.cboSubAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubAccount.FormattingEnabled = true;
            this.cboSubAccount.Location = new System.Drawing.Point(10, 193);
            this.cboSubAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubAccount.Name = "cboSubAccount";
            this.cboSubAccount.Size = new System.Drawing.Size(248, 26);
            this.cboSubAccount.TabIndex = 26;
            this.cboSubAccount.SelectedIndexChanged += new System.EventHandler(this.cboSubAccount_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(261, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Financial Year";
            // 
            // cboFy
            // 
            this.cboFy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFy.FormattingEnabled = true;
            this.cboFy.Location = new System.Drawing.Point(265, 38);
            this.cboFy.Name = "cboFy";
            this.cboFy.Size = new System.Drawing.Size(145, 26);
            this.cboFy.TabIndex = 22;
            // 
            // txtPayee
            // 
            this.txtPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayee.Location = new System.Drawing.Point(6, 307);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(251, 24);
            this.txtPayee.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payee";
            // 
            // cboCreditAccount
            // 
            this.cboCreditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCreditAccount.FormattingEnabled = true;
            this.cboCreditAccount.Location = new System.Drawing.Point(6, 560);
            this.cboCreditAccount.Name = "cboCreditAccount";
            this.cboCreditAccount.Size = new System.Drawing.Size(251, 26);
            this.cboCreditAccount.TabIndex = 19;
            // 
            // cboDebitAccount
            // 
            this.cboDebitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDebitAccount.FormattingEnabled = true;
            this.cboDebitAccount.Location = new System.Drawing.Point(4, 508);
            this.cboDebitAccount.Name = "cboDebitAccount";
            this.cboDebitAccount.Size = new System.Drawing.Size(251, 26);
            this.cboDebitAccount.TabIndex = 18;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(6, 458);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(251, 24);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 435);
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
            this.label7.Location = new System.Drawing.Point(3, 537);
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
            this.label6.Location = new System.Drawing.Point(3, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Debit Account";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(7, 378);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(250, 54);
            this.txt_description.TabIndex = 9;
            this.txt_description.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Particulars";
            // 
            // txt_cheque_number
            // 
            this.txt_cheque_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheque_number.Location = new System.Drawing.Point(7, 145);
            this.txt_cheque_number.Name = "txt_cheque_number";
            this.txt_cheque_number.Size = new System.Drawing.Size(251, 24);
            this.txt_cheque_number.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cheque Number";
            // 
            // txt_refference_number
            // 
            this.txt_refference_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refference_number.Location = new System.Drawing.Point(6, 94);
            this.txt_refference_number.Name = "txt_refference_number";
            this.txt_refference_number.Size = new System.Drawing.Size(251, 24);
            this.txt_refference_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 71);
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
            this.dtPickerDate.Location = new System.Drawing.Point(6, 40);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.ShowCheckBox = true;
            this.dtPickerDate.Size = new System.Drawing.Size(251, 24);
            this.dtPickerDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 883D;
            this.reSize1.InitialHostContainerWidth = 1081D;
            this.reSize1.Tag = null;
            // 
            // frmJournalEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1081, 883);
            this.Controls.Add(this.pnlOuterContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJournalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Entry";
            this.Load += new System.EventHandler(this.frmJournalEntry_Load);
            this.pnlOuterContainer.ResumeLayout(false);
            this.pnlOuterContainer.PerformLayout();
            this.pnlsave.ResumeLayout(false);
            this.grpboxJournalEntrySearch.ResumeLayout(false);
            this.grpboxJournalEntrySearch.PerformLayout();
            this.xDatesearch.ResumeLayout(false);
            this.xDatesearch.PerformLayout();
            this.grpboxQuickActions.ResumeLayout(false);
            this.grpboxQuickActions.PerformLayout();
            this.grpboxJournalEntryListing.ResumeLayout(false);
            this.grpboxPostTransactions.ResumeLayout(false);
            this.grpboxPostTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).EndInit();
            this.grpboxJournalEntry.ResumeLayout(false);
            this.grpboxJournalEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuterContainer;
        private System.Windows.Forms.GroupBox grpboxJournalEntry;
        private System.Windows.Forms.GroupBox grpboxJournalEntryListing;
        private System.Windows.Forms.GroupBox grpboxQuickActions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_refference_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cheque_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.CheckBox chkOnHold;
        private System.Windows.Forms.CheckBox chkPosted;
        private System.Windows.Forms.GroupBox grpboxJournalEntrySearch;
        private System.Windows.Forms.DataGridView gdvList;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.ComboBox cboCreditAccount;
        private System.Windows.Forms.ComboBox cboDebitAccount;
        private System.Windows.Forms.Button btnGeneralLedger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayee;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox xDatesearch;
        private System.Windows.Forms.DateTimePicker dtPickersearchfrom;
        private System.Windows.Forms.DateTimePicker dtPickersearchTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtrefsearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtchequesearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.CheckBox chkAudited;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTotalCredit;
        private System.Windows.Forms.TextBox txtTotalDebit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboFy;
        private System.Windows.Forms.ComboBox cboSubAccount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboPayee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboDrCr;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.CheckBox chksimultaneousoffOn;
        private System.Windows.Forms.Panel pnlsave;
        private System.Windows.Forms.GroupBox grpboxPostTransactions;
        private System.Windows.Forms.DateTimePicker dtPickerPost;
        private System.Windows.Forms.Label label19;
    }
}