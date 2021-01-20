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
            this.grpboxQuickActions = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGeneralLedger = new System.Windows.Forms.Button();
            this.grpboxJournalEntryListing = new System.Windows.Forms.GroupBox();
            this.gdvList = new System.Windows.Forms.DataGridView();
            this.grpboxJournalEntry = new System.Windows.Forms.GroupBox();
            this.txt_batch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPayee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCreditAccount = new System.Windows.Forms.ComboBox();
            this.cboDebitAccount = new System.Windows.Forms.ComboBox();
            this.chkOnHold = new System.Windows.Forms.CheckBox();
            this.chkPosted = new System.Windows.Forms.CheckBox();
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
            this.chkAudited = new System.Windows.Forms.CheckBox();
            this.pnlOuterContainer.SuspendLayout();
            this.grpboxJournalEntrySearch.SuspendLayout();
            this.xDatesearch.SuspendLayout();
            this.grpboxQuickActions.SuspendLayout();
            this.grpboxJournalEntryListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvList)).BeginInit();
            this.grpboxJournalEntry.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlOuterContainer.Controls.Add(this.grpboxJournalEntry);
            this.pnlOuterContainer.Location = new System.Drawing.Point(2, 1);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Size = new System.Drawing.Size(983, 627);
            this.pnlOuterContainer.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(49, 463);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 28);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Journal Entry";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.Color.Magenta;
            this.btnEdit.Location = new System.Drawing.Point(195, 463);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 28);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(296, 463);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 28);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
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
            this.grpboxJournalEntrySearch.Location = new System.Drawing.Point(404, 3);
            this.grpboxJournalEntrySearch.Name = "grpboxJournalEntrySearch";
            this.grpboxJournalEntrySearch.Size = new System.Drawing.Size(576, 75);
            this.grpboxJournalEntrySearch.TabIndex = 2;
            this.grpboxJournalEntrySearch.TabStop = false;
            this.grpboxJournalEntrySearch.Text = "Journal Entry Search Panel";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SlateGray;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(481, 29);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 41);
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
            this.label13.Location = new System.Drawing.Point(375, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cheque Number";
            // 
            // txtchequesearch
            // 
            this.txtchequesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchequesearch.Location = new System.Drawing.Point(375, 46);
            this.txtchequesearch.Name = "txtchequesearch";
            this.txtchequesearch.Size = new System.Drawing.Size(102, 21);
            this.txtchequesearch.TabIndex = 28;
            this.txtchequesearch.TextChanged += new System.EventHandler(this.txtchequesearch_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(272, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Reference Number";
            // 
            // txtrefsearch
            // 
            this.txtrefsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrefsearch.Location = new System.Drawing.Point(272, 46);
            this.txtrefsearch.Name = "txtrefsearch";
            this.txtrefsearch.Size = new System.Drawing.Size(97, 21);
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
            this.xDatesearch.Location = new System.Drawing.Point(6, 17);
            this.xDatesearch.Name = "xDatesearch";
            this.xDatesearch.Size = new System.Drawing.Size(260, 52);
            this.xDatesearch.TabIndex = 0;
            this.xDatesearch.TabStop = false;
            this.xDatesearch.Text = "Date Range";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(119, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "From";
            // 
            // dtPickersearchTo
            // 
            this.dtPickersearchTo.Checked = false;
            this.dtPickersearchTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickersearchTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickersearchTo.Location = new System.Drawing.Point(119, 29);
            this.dtPickersearchTo.Name = "dtPickersearchTo";
            this.dtPickersearchTo.ShowCheckBox = true;
            this.dtPickersearchTo.Size = new System.Drawing.Size(107, 21);
            this.dtPickersearchTo.TabIndex = 25;
            // 
            // dtPickersearchfrom
            // 
            this.dtPickersearchfrom.Checked = false;
            this.dtPickersearchfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickersearchfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickersearchfrom.Location = new System.Drawing.Point(6, 29);
            this.dtPickersearchfrom.Name = "dtPickersearchfrom";
            this.dtPickersearchfrom.ShowCheckBox = true;
            this.dtPickersearchfrom.Size = new System.Drawing.Size(107, 21);
            this.dtPickersearchfrom.TabIndex = 24;
            // 
            // grpboxQuickActions
            // 
            this.grpboxQuickActions.BackColor = System.Drawing.Color.AliceBlue;
            this.grpboxQuickActions.Controls.Add(this.lblID);
            this.grpboxQuickActions.Controls.Add(this.btnGeneralLedger);
            this.grpboxQuickActions.ForeColor = System.Drawing.Color.Blue;
            this.grpboxQuickActions.Location = new System.Drawing.Point(10, 497);
            this.grpboxQuickActions.Name = "grpboxQuickActions";
            this.grpboxQuickActions.Size = new System.Drawing.Size(388, 127);
            this.grpboxQuickActions.TabIndex = 1;
            this.grpboxQuickActions.TabStop = false;
            this.grpboxQuickActions.Text = "Quick Actions";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 111);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
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
            this.btnGeneralLedger.Size = new System.Drawing.Size(134, 28);
            this.btnGeneralLedger.TabIndex = 3;
            this.btnGeneralLedger.Text = "View General Ledger";
            this.btnGeneralLedger.UseVisualStyleBackColor = false;
            // 
            // grpboxJournalEntryListing
            // 
            this.grpboxJournalEntryListing.BackColor = System.Drawing.SystemColors.Info;
            this.grpboxJournalEntryListing.Controls.Add(this.gdvList);
            this.grpboxJournalEntryListing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpboxJournalEntryListing.Location = new System.Drawing.Point(404, 81);
            this.grpboxJournalEntryListing.Name = "grpboxJournalEntryListing";
            this.grpboxJournalEntryListing.Size = new System.Drawing.Size(576, 543);
            this.grpboxJournalEntryListing.TabIndex = 1;
            this.grpboxJournalEntryListing.TabStop = false;
            this.grpboxJournalEntryListing.Text = "Journal Entry Listing";
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
            this.gdvList.Size = new System.Drawing.Size(570, 518);
            this.gdvList.TabIndex = 0;
            this.gdvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvList_CellDoubleClick);
            // 
            // grpboxJournalEntry
            // 
            this.grpboxJournalEntry.BackColor = System.Drawing.Color.Azure;
            this.grpboxJournalEntry.Controls.Add(this.chkAudited);
            this.grpboxJournalEntry.Controls.Add(this.txt_batch);
            this.grpboxJournalEntry.Controls.Add(this.label9);
            this.grpboxJournalEntry.Controls.Add(this.txtPayee);
            this.grpboxJournalEntry.Controls.Add(this.label1);
            this.grpboxJournalEntry.Controls.Add(this.cboCreditAccount);
            this.grpboxJournalEntry.Controls.Add(this.cboDebitAccount);
            this.grpboxJournalEntry.Controls.Add(this.chkOnHold);
            this.grpboxJournalEntry.Controls.Add(this.chkPosted);
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
            this.grpboxJournalEntry.Location = new System.Drawing.Point(10, 3);
            this.grpboxJournalEntry.Name = "grpboxJournalEntry";
            this.grpboxJournalEntry.Size = new System.Drawing.Size(388, 454);
            this.grpboxJournalEntry.TabIndex = 0;
            this.grpboxJournalEntry.TabStop = false;
            this.grpboxJournalEntry.Text = "Journal Entry Panel";
            // 
            // txt_batch
            // 
            this.txt_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_batch.Location = new System.Drawing.Point(6, 161);
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.Size = new System.Drawing.Size(251, 21);
            this.txt_batch.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(3, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Batch";
            // 
            // txtPayee
            // 
            this.txtPayee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayee.Location = new System.Drawing.Point(6, 200);
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.Size = new System.Drawing.Size(251, 21);
            this.txtPayee.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Payee";
            // 
            // cboCreditAccount
            // 
            this.cboCreditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCreditAccount.FormattingEnabled = true;
            this.cboCreditAccount.Location = new System.Drawing.Point(6, 400);
            this.cboCreditAccount.Name = "cboCreditAccount";
            this.cboCreditAccount.Size = new System.Drawing.Size(251, 23);
            this.cboCreditAccount.TabIndex = 19;
            // 
            // cboDebitAccount
            // 
            this.cboDebitAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDebitAccount.FormattingEnabled = true;
            this.cboDebitAccount.Location = new System.Drawing.Point(6, 357);
            this.cboDebitAccount.Name = "cboDebitAccount";
            this.cboDebitAccount.Size = new System.Drawing.Size(251, 23);
            this.cboDebitAccount.TabIndex = 18;
            // 
            // chkOnHold
            // 
            this.chkOnHold.AutoSize = true;
            this.chkOnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkOnHold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOnHold.Location = new System.Drawing.Point(128, 429);
            this.chkOnHold.Name = "chkOnHold";
            this.chkOnHold.Size = new System.Drawing.Size(120, 17);
            this.chkOnHold.TabIndex = 17;
            this.chkOnHold.Text = "Transaction on hold";
            this.chkOnHold.UseVisualStyleBackColor = false;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chkPosted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPosted.Location = new System.Drawing.Point(6, 429);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(116, 17);
            this.chkPosted.TabIndex = 16;
            this.chkPosted.Text = "Transacton Posted";
            this.chkPosted.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(6, 316);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(251, 21);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(3, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Credit Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(3, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Debit Account";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(6, 244);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(251, 54);
            this.txt_description.TabIndex = 9;
            this.txt_description.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Particulars";
            // 
            // txt_cheque_number
            // 
            this.txt_cheque_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cheque_number.Location = new System.Drawing.Point(6, 122);
            this.txt_cheque_number.Name = "txt_cheque_number";
            this.txt_cheque_number.Size = new System.Drawing.Size(251, 21);
            this.txt_cheque_number.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cheque Number";
            // 
            // txt_refference_number
            // 
            this.txt_refference_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refference_number.Location = new System.Drawing.Point(6, 79);
            this.txt_refference_number.Name = "txt_refference_number";
            this.txt_refference_number.Size = new System.Drawing.Size(251, 21);
            this.txt_refference_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Refference Number";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Checked = false;
            this.dtPickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDate.Location = new System.Drawing.Point(6, 36);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.ShowCheckBox = true;
            this.dtPickerDate.Size = new System.Drawing.Size(251, 21);
            this.dtPickerDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 629D;
            this.reSize1.InitialHostContainerWidth = 986D;
            this.reSize1.Tag = null;
            // 
            // chkAudited
            // 
            this.chkAudited.AutoSize = true;
            this.chkAudited.BackColor = System.Drawing.Color.Khaki;
            this.chkAudited.Enabled = false;
            this.chkAudited.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudited.Location = new System.Drawing.Point(254, 429);
            this.chkAudited.Name = "chkAudited";
            this.chkAudited.Size = new System.Drawing.Size(62, 17);
            this.chkAudited.TabIndex = 36;
            this.chkAudited.Text = "Audited";
            this.chkAudited.UseVisualStyleBackColor = false;
            // 
            // frmJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(986, 629);
            this.Controls.Add(this.pnlOuterContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmJournalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Entry";
            this.Load += new System.EventHandler(this.frmJournalEntry_Load);
            this.pnlOuterContainer.ResumeLayout(false);
            this.grpboxJournalEntrySearch.ResumeLayout(false);
            this.grpboxJournalEntrySearch.PerformLayout();
            this.xDatesearch.ResumeLayout(false);
            this.xDatesearch.PerformLayout();
            this.grpboxQuickActions.ResumeLayout(false);
            this.grpboxQuickActions.PerformLayout();
            this.grpboxJournalEntryListing.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_batch;
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
    }
}