namespace Guard_profiler
{
    partial class frmItemCategoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemCategoryItem));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.gdvItems = new System.Windows.Forms.DataGridView();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblitemid = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvItems)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.LightCyan;
            this.pnlContainer.Controls.Add(this.btnNew);
            this.pnlContainer.Controls.Add(this.btnEdit);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.pnlList);
            this.pnlContainer.Controls.Add(this.pnlContent);
            this.pnlContainer.Location = new System.Drawing.Point(5, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1192, 691);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(357, 115);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(168, 44);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(183, 115);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Blue;
            this.btnsave.Location = new System.Drawing.Point(9, 115);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(168, 44);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlList.Controls.Add(this.gdvItems);
            this.pnlList.Location = new System.Drawing.Point(3, 165);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1186, 523);
            this.pnlList.TabIndex = 1;
            // 
            // gdvItems
            // 
            this.gdvItems.AllowUserToAddRows = false;
            this.gdvItems.AllowUserToDeleteRows = false;
            this.gdvItems.AllowUserToResizeColumns = false;
            this.gdvItems.AllowUserToResizeRows = false;
            this.gdvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvItems.Location = new System.Drawing.Point(3, 3);
            this.gdvItems.Name = "gdvItems";
            this.gdvItems.RowTemplate.Height = 24;
            this.gdvItems.Size = new System.Drawing.Size(1179, 517);
            this.gdvItems.TabIndex = 0;
            this.gdvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvItems_CellDoubleClick);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Honeydew;
            this.pnlContent.Controls.Add(this.lblitemid);
            this.pnlContent.Controls.Add(this.lbl_name);
            this.pnlContent.Controls.Add(this.lblid);
            this.pnlContent.Controls.Add(this.chkActive);
            this.pnlContent.Controls.Add(this.txtCategory);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Location = new System.Drawing.Point(9, 10);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1276, 99);
            this.pnlContent.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(583, 66);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 17);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "-";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(6, 65);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(112, 21);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Item is Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(9, 29);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(438, 30);
            this.txtCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 700D;
            this.reSize1.InitialHostContainerWidth = 1202D;
            this.reSize1.Tag = null;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(583, 18);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(19, 25);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "-";
            // 
            // lblitemid
            // 
            this.lblitemid.AutoSize = true;
            this.lblitemid.Location = new System.Drawing.Point(585, 49);
            this.lblitemid.Name = "lblitemid";
            this.lblitemid.Size = new System.Drawing.Size(13, 17);
            this.lblitemid.TabIndex = 7;
            this.lblitemid.Text = "-";
            // 
            // frmItemCategoryItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1202, 700);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemCategoryItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Items";
            this.Load += new System.EventHandler(this.frmItemCategoryItem_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvItems)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gdvItems;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblitemid;
    }
}