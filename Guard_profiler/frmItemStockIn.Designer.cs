namespace Guard_profiler
{
    partial class frmItemStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemStockIn));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.gdvItems = new System.Windows.Forms.DataGridView();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtsockdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdvItemStockList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItems)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItemStockList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.tableLayoutPanel1);
            this.pnlContainer.Controls.Add(this.btnReports);
            this.pnlContainer.Controls.Add(this.btnNew);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.pnlContent);
            this.pnlContainer.Controls.Add(this.lblid);
            this.pnlContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1288, 799);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Blue;
            this.btnReports.Location = new System.Drawing.Point(344, 150);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(152, 33);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Inventory Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(208, 150);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 33);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(108, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(9, 150);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 33);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlList.Controls.Add(this.gdvItems);
            this.pnlList.Location = new System.Drawing.Point(641, 35);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(632, 537);
            this.pnlList.TabIndex = 1;
            // 
            // gdvItems
            // 
            this.gdvItems.AllowUserToAddRows = false;
            this.gdvItems.AllowUserToDeleteRows = false;
            this.gdvItems.AllowUserToResizeColumns = false;
            this.gdvItems.AllowUserToResizeRows = false;
            this.gdvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItems.Location = new System.Drawing.Point(3, 3);
            this.gdvItems.Name = "gdvItems";
            this.gdvItems.RowTemplate.Height = 24;
            this.gdvItems.Size = new System.Drawing.Size(626, 531);
            this.gdvItems.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlContent.Controls.Add(this.txtNotes);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.txtQty);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.dtsockdate);
            this.pnlContent.Controls.Add(this.cboItem);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.cboItemCategory);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Location = new System.Drawing.Point(9, 10);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1276, 134);
            this.pnlContent.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(903, 177);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 17);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Category";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 804D;
            this.reSize1.InitialHostContainerWidth = 1295D;
            this.reSize1.Tag = null;
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(6, 29);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(391, 33);
            this.cboItemCategory.TabIndex = 6;
            this.cboItemCategory.SelectedIndexChanged += new System.EventHandler(this.cboItemCategory_SelectedIndexChanged);
            // 
            // cboItem
            // 
            this.cboItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(6, 85);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(391, 33);
            this.cboItem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Item";
            // 
            // dtsockdate
            // 
            this.dtsockdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsockdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtsockdate.Location = new System.Drawing.Point(422, 32);
            this.dtsockdate.Name = "dtsockdate";
            this.dtsockdate.Size = new System.Drawing.Size(200, 30);
            this.dtsockdate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stock Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(422, 88);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(200, 30);
            this.txtQty.TabIndex = 12;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stockin Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(641, 29);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(511, 86);
            this.txtNotes.TabIndex = 14;
            this.txtNotes.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 214);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.565217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.43478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 575);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.gdvItemStockList);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 537);
            this.panel1.TabIndex = 2;
            // 
            // gdvItemStockList
            // 
            this.gdvItemStockList.AllowUserToAddRows = false;
            this.gdvItemStockList.AllowUserToDeleteRows = false;
            this.gdvItemStockList.AllowUserToResizeColumns = false;
            this.gdvItemStockList.AllowUserToResizeRows = false;
            this.gdvItemStockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvItemStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvItemStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItemStockList.Location = new System.Drawing.Point(3, 3);
            this.gdvItemStockList.Name = "gdvItemStockList";
            this.gdvItemStockList.RowTemplate.Height = 24;
            this.gdvItemStockList.Size = new System.Drawing.Size(626, 531);
            this.gdvItemStockList.TabIndex = 0;
            this.gdvItemStockList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvItemStockList_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Item Stock Records";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Item Stock Levels";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(641, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 26);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 26);
            this.panel3.TabIndex = 17;
            // 
            // frmItemStockIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 804);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemStockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stockin Management";
            this.Load += new System.EventHandler(this.frmItemStockIn_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvItems)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvItemStockList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gdvItems;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtsockdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdvItemStockList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}