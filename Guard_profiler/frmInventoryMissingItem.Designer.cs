namespace Guard_profiler
{
    partial class frmInventoryMissingItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryMissingItem));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            this.gdvMissingItems = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.txtQtyLost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbostaff = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssignedItemQty = new System.Windows.Forms.TextBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.btnsave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvMissingItems)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Azure;
            this.pnlContainer.Controls.Add(this.lblid);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnNew);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.panelMain);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.pnlList);
            this.pnlContainer.Location = new System.Drawing.Point(2, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1284, 787);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlList.Controls.Add(this.gdvMissingItems);
            this.pnlList.Location = new System.Drawing.Point(3, 202);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1276, 582);
            this.pnlList.TabIndex = 0;
            // 
            // gdvMissingItems
            // 
            this.gdvMissingItems.AllowUserToAddRows = false;
            this.gdvMissingItems.AllowUserToDeleteRows = false;
            this.gdvMissingItems.AllowUserToResizeColumns = false;
            this.gdvMissingItems.AllowUserToResizeRows = false;
            this.gdvMissingItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvMissingItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvMissingItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdvMissingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdvMissingItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvMissingItems.Location = new System.Drawing.Point(3, 2);
            this.gdvMissingItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gdvMissingItems.Name = "gdvMissingItems";
            this.gdvMissingItems.ReadOnly = true;
            this.gdvMissingItems.RowTemplate.Height = 24;
            this.gdvMissingItems.Size = new System.Drawing.Size(1268, 578);
            this.gdvMissingItems.TabIndex = 73;
            this.gdvMissingItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvStockRecords_CellContentClick);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Silver;
            this.panelMain.Controls.Add(this.txtAssignedItemQty);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.txtComment);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtQtyLost);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.cbostaff);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.dtReceiveDate);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label21);
            this.panelMain.Controls.Add(this.cboItem);
            this.panelMain.Location = new System.Drawing.Point(4, 26);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1274, 122);
            this.panelMain.TabIndex = 75;
            // 
            // txtQtyLost
            // 
            this.txtQtyLost.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtQtyLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyLost.ForeColor = System.Drawing.Color.White;
            this.txtQtyLost.Location = new System.Drawing.Point(533, 84);
            this.txtQtyLost.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyLost.Name = "txtQtyLost";
            this.txtQtyLost.Size = new System.Drawing.Size(126, 30);
            this.txtQtyLost.TabIndex = 67;
            this.txtQtyLost.Text = "0";
            this.txtQtyLost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Total Qty Missing";
            // 
            // cbostaff
            // 
            this.cbostaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostaff.FormattingEnabled = true;
            this.cbostaff.Location = new System.Drawing.Point(303, 26);
            this.cbostaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbostaff.Name = "cbostaff";
            this.cbostaff.Size = new System.Drawing.Size(356, 33);
            this.cbostaff.TabIndex = 64;
            this.cbostaff.SelectedIndexChanged += new System.EventHandler(this.cbostaff_SelectedIndexChanged);
            this.cbostaff.SelectionChangeCommitted += new System.EventHandler(this.cbostaff_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Select Guard";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Missing Date";
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
            this.cboItem.SelectionChangeCommitted += new System.EventHandler(this.cboItem_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Record Missing Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(666, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(666, 24);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(485, 87);
            this.txtComment.TabIndex = 69;
            this.txtComment.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 18);
            this.label6.TabIndex = 70;
            this.label6.Text = "Total Items Assigned to Guard";
            // 
            // txtAssignedItemQty
            // 
            this.txtAssignedItemQty.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAssignedItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignedItemQty.ForeColor = System.Drawing.Color.White;
            this.txtAssignedItemQty.Location = new System.Drawing.Point(306, 84);
            this.txtAssignedItemQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssignedItemQty.Name = "txtAssignedItemQty";
            this.txtAssignedItemQty.Size = new System.Drawing.Size(204, 30);
            this.txtAssignedItemQty.TabIndex = 71;
            this.txtAssignedItemQty.Text = "0";
            this.txtAssignedItemQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 802D;
            this.reSize1.InitialHostContainerWidth = 1288D;
            this.reSize1.Tag = null;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(6, 155);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(146, 41);
            this.btnsave.TabIndex = 76;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(310, 155);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(146, 41);
            this.btnNew.TabIndex = 77;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(158, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 41);
            this.btnEdit.TabIndex = 78;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(734, 172);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 17);
            this.lblid.TabIndex = 79;
            this.lblid.Text = "-";
            // 
            // frmInventoryMissingItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1288, 802);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventoryMissingItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Missing Item";
            this.Load += new System.EventHandler(this.frmInventoryMissingItem_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvMissingItems)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gdvMissingItems;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox txtQtyLost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbostaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssignedItemQty;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblid;
    }
}