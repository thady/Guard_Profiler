namespace Guard_profiler
{
    partial class frmInventoryStockOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryStockOut));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panelSaveCatalogue = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnsaveCatalogue = new System.Windows.Forms.Button();
            this.gdvStockRecords = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtQtyIssued = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbostaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemsCatalogHeader = new System.Windows.Forms.Label();
            this.gdvItemCatalogue = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiver_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove_item = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panelSearch.SuspendLayout();
            this.panelSaveCatalogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStockRecords)).BeginInit();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItemCatalogue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.label9);
            this.panelSearch.Controls.Add(this.label8);
            this.panelSearch.Controls.Add(this.dtPickerTo);
            this.panelSearch.Controls.Add(this.dtPickerFrom);
            this.panelSearch.Location = new System.Drawing.Point(665, 2);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(657, 106);
            this.panelSearch.TabIndex = 72;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(435, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(219, 89);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 63;
            this.label8.Text = "Begin Date";
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerTo.Location = new System.Drawing.Point(121, 6);
            this.dtPickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(293, 38);
            this.dtPickerTo.TabIndex = 62;
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFrom.Location = new System.Drawing.Point(121, 57);
            this.dtPickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(293, 38);
            this.dtPickerFrom.TabIndex = 61;
            // 
            // panelSaveCatalogue
            // 
            this.panelSaveCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSaveCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSaveCatalogue.Controls.Add(this.btnReport);
            this.panelSaveCatalogue.Controls.Add(this.btnsaveCatalogue);
            this.panelSaveCatalogue.Location = new System.Drawing.Point(3, 2);
            this.panelSaveCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSaveCatalogue.Name = "panelSaveCatalogue";
            this.panelSaveCatalogue.Size = new System.Drawing.Size(656, 106);
            this.panelSaveCatalogue.TabIndex = 73;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Red;
            this.btnReport.Location = new System.Drawing.Point(384, 0);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(269, 97);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnsaveCatalogue
            // 
            this.btnsaveCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveCatalogue.Location = new System.Drawing.Point(3, 0);
            this.btnsaveCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsaveCatalogue.Name = "btnsaveCatalogue";
            this.btnsaveCatalogue.Size = new System.Drawing.Size(375, 97);
            this.btnsaveCatalogue.TabIndex = 0;
            this.btnsaveCatalogue.Text = "Save Line Items";
            this.btnsaveCatalogue.UseVisualStyleBackColor = true;
            this.btnsaveCatalogue.Click += new System.EventHandler(this.btnsaveCatalogue_Click);
            // 
            // gdvStockRecords
            // 
            this.gdvStockRecords.AllowUserToAddRows = false;
            this.gdvStockRecords.AllowUserToDeleteRows = false;
            this.gdvStockRecords.AllowUserToResizeColumns = false;
            this.gdvStockRecords.AllowUserToResizeRows = false;
            this.gdvStockRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvStockRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvStockRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvStockRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvStockRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvStockRecords.Location = new System.Drawing.Point(665, 139);
            this.gdvStockRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvStockRecords.Name = "gdvStockRecords";
            this.gdvStockRecords.ReadOnly = true;
            this.gdvStockRecords.RowTemplate.Height = 24;
            this.gdvStockRecords.Size = new System.Drawing.Size(657, 486);
            this.gdvStockRecords.TabIndex = 71;
            this.gdvStockRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvStockRecords_CellDoubleClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.Red;
            this.lblid.Location = new System.Drawing.Point(739, 160);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 17);
            this.lblid.TabIndex = 55;
            this.lblid.Text = "--";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Controls.Add(this.txtQtyIssued);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.cbostaff);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.dtReceiveDate);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label21);
            this.panelMain.Controls.Add(this.cboItem);
            this.panelMain.Controls.Add(this.txtQty);
            this.panelMain.Location = new System.Drawing.Point(3, 19);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1328, 126);
            this.panelMain.TabIndex = 50;
            // 
            // txtQtyIssued
            // 
            this.txtQtyIssued.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtQtyIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyIssued.ForeColor = System.Drawing.Color.White;
            this.txtQtyIssued.Location = new System.Drawing.Point(616, 85);
            this.txtQtyIssued.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyIssued.Name = "txtQtyIssued";
            this.txtQtyIssued.Size = new System.Drawing.Size(221, 30);
            this.txtQtyIssued.TabIndex = 67;
            this.txtQtyIssued.Text = "0";
            this.txtQtyIssued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtyIssued.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyIssued_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Quantity Issued";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Available Stock";
            // 
            // cbostaff
            // 
            this.cbostaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostaff.FormattingEnabled = true;
            this.cbostaff.Location = new System.Drawing.Point(303, 26);
            this.cbostaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbostaff.Name = "cbostaff";
            this.cbostaff.Size = new System.Drawing.Size(535, 33);
            this.cbostaff.TabIndex = 64;
            this.cbostaff.SelectedIndexChanged += new System.EventHandler(this.cbostaff_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Issued To:";
            // 
            // dtReceiveDate
            // 
            this.dtReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceiveDate.Location = new System.Drawing.Point(3, 82);
            this.dtReceiveDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtReceiveDate.Name = "dtReceiveDate";
            this.dtReceiveDate.Size = new System.Drawing.Size(293, 30);
            this.dtReceiveDate.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Issue Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 5);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 18);
            this.label21.TabIndex = 58;
            this.label21.Text = "Item Name";
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(3, 26);
            this.cboItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(293, 33);
            this.cboItem.TabIndex = 41;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.White;
            this.txtQty.Location = new System.Drawing.Point(303, 82);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(305, 30);
            this.txtQty.TabIndex = 62;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gdvStockRecords, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblItemsCatalogHeader, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gdvItemCatalogue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSaveCatalogue, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 193);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.3407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.6593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1325, 648);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(666, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Items Issued(Double Click on record to view items issued)";
            // 
            // lblItemsCatalogHeader
            // 
            this.lblItemsCatalogHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemsCatalogHeader.AutoSize = true;
            this.lblItemsCatalogHeader.BackColor = System.Drawing.Color.Yellow;
            this.lblItemsCatalogHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCatalogHeader.Location = new System.Drawing.Point(4, 114);
            this.lblItemsCatalogHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsCatalogHeader.Name = "lblItemsCatalogHeader";
            this.lblItemsCatalogHeader.Size = new System.Drawing.Size(107, 18);
            this.lblItemsCatalogHeader.TabIndex = 68;
            this.lblItemsCatalogHeader.Text = "Item Catalogue";
            // 
            // gdvItemCatalogue
            // 
            this.gdvItemCatalogue.AllowUserToAddRows = false;
            this.gdvItemCatalogue.AllowUserToResizeColumns = false;
            this.gdvItemCatalogue.AllowUserToResizeRows = false;
            this.gdvItemCatalogue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvItemCatalogue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvItemCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItemCatalogue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_id,
            this.item_name,
            this.receiver_id,
            this.Qty,
            this.remove_item});
            this.gdvItemCatalogue.Location = new System.Drawing.Point(3, 139);
            this.gdvItemCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvItemCatalogue.Name = "gdvItemCatalogue";
            this.gdvItemCatalogue.RowTemplate.Height = 24;
            this.gdvItemCatalogue.Size = new System.Drawing.Size(656, 486);
            this.gdvItemCatalogue.TabIndex = 70;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(221, 150);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 37);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Remove from List";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(393, 150);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(119, 37);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(5, 150);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(211, 37);
            this.btnsave.TabIndex = 51;
            this.btnsave.Text = "Add to Item Catalogue";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // item_id
            // 
            this.item_id.HeaderText = "item_id";
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Visible = false;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // receiver_id
            // 
            this.receiver_id.HeaderText = "Issued To";
            this.receiver_id.Name = "receiver_id";
            this.receiver_id.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity Issued";
            this.Qty.Name = "Qty";
            // 
            // remove_item
            // 
            this.remove_item.HeaderText = "Remove from List";
            this.remove_item.Name = "remove_item";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 852D;
            this.reSize1.InitialHostContainerWidth = 1335D;
            this.reSize1.Tag = null;
            // 
            // frmInventoryStockOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1335, 852);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryStockOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item StockOut Management";
            this.Load += new System.EventHandler(this.frmInventoryStockOut_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelSaveCatalogue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvStockRecords)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItemCatalogue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.Panel panelSaveCatalogue;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnsaveCatalogue;
        private System.Windows.Forms.DataGridView gdvStockRecords;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtQtyIssued;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbostaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemsCatalogHeader;
        private System.Windows.Forms.DataGridView gdvItemCatalogue;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn remove_item;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}