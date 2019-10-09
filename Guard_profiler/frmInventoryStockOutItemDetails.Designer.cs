namespace Guard_profiler
{
    partial class frmInventoryStockOutItemDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryStockOutItemDetails));
            this.pnlList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblstockoutmainid = new System.Windows.Forms.Label();
            this.lblstockoutid = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtQtyIssued = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbostaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.gdvStockRecords = new System.Windows.Forms.DataGridView();
            this.pnlList.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStockRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlList.Controls.Add(this.gdvStockRecords);
            this.pnlList.Location = new System.Drawing.Point(2, 193);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(931, 412);
            this.pnlList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Item Stock Issue(Double click on an item to to view and update stockout deta" +
    "ils)";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(4, 148);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(140, 39);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save Details";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(150, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 39);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Details";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(296, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Content";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblstockoutmainid
            // 
            this.lblstockoutmainid.AutoSize = true;
            this.lblstockoutmainid.ForeColor = System.Drawing.Color.Blue;
            this.lblstockoutmainid.Location = new System.Drawing.Point(477, 148);
            this.lblstockoutmainid.Name = "lblstockoutmainid";
            this.lblstockoutmainid.Size = new System.Drawing.Size(13, 17);
            this.lblstockoutmainid.TabIndex = 6;
            this.lblstockoutmainid.Text = "-";
            // 
            // lblstockoutid
            // 
            this.lblstockoutid.AutoSize = true;
            this.lblstockoutid.ForeColor = System.Drawing.Color.Blue;
            this.lblstockoutid.Location = new System.Drawing.Point(477, 170);
            this.lblstockoutid.Name = "lblstockoutid";
            this.lblstockoutid.Size = new System.Drawing.Size(13, 17);
            this.lblstockoutid.TabIndex = 7;
            this.lblstockoutid.Text = "-";
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
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label21);
            this.panelMain.Controls.Add(this.cboItem);
            this.panelMain.Controls.Add(this.txtQty);
            this.panelMain.Location = new System.Drawing.Point(4, 26);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(929, 118);
            this.panelMain.TabIndex = 51;
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
            this.cbostaff.Enabled = false;
            this.cbostaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostaff.FormattingEnabled = true;
            this.cbostaff.Location = new System.Drawing.Point(303, 26);
            this.cbostaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbostaff.Name = "cbostaff";
            this.cbostaff.Size = new System.Drawing.Size(535, 33);
            this.cbostaff.TabIndex = 64;
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
            this.dtReceiveDate.Enabled = false;
            this.dtReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReceiveDate.Location = new System.Drawing.Point(3, 82);
            this.dtReceiveDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtReceiveDate.Name = "dtReceiveDate";
            this.dtReceiveDate.Size = new System.Drawing.Size(293, 30);
            this.dtReceiveDate.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Issue Date";
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
            this.cboItem.Enabled = false;
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
            this.gdvStockRecords.Location = new System.Drawing.Point(5, 4);
            this.gdvStockRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvStockRecords.Name = "gdvStockRecords";
            this.gdvStockRecords.ReadOnly = true;
            this.gdvStockRecords.RowTemplate.Height = 24;
            this.gdvStockRecords.Size = new System.Drawing.Size(923, 401);
            this.gdvStockRecords.TabIndex = 72;
            this.gdvStockRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvStockRecords_CellDoubleClick);
            // 
            // frmInventoryStockOutItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 609);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblstockoutid);
            this.Controls.Add(this.lblstockoutmainid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoryStockOutItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item StockOut Record Details";
            this.Load += new System.EventHandler(this.frmInventoryStockOutItemDetails_Load);
            this.pnlList.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvStockRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblstockoutmainid;
        private System.Windows.Forms.Label lblstockoutid;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtQtyIssued;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbostaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridView gdvStockRecords;
    }
}