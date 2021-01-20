namespace Accounts
{
    partial class frmBranches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranches));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.gdv_branches = new System.Windows.Forms.DataGridView();
            this.pnlEntry = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_branch_code = new System.Windows.Forms.TextBox();
            this.txt_branch_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_branch_active = new System.Windows.Forms.CheckBox();
            this.txt_branch_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_branches)).BeginInit();
            this.pnlEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Lavender;
            this.pnlContainer.Controls.Add(this.lblID);
            this.pnlContainer.Controls.Add(this.btnedit);
            this.pnlContainer.Controls.Add(this.btnnew);
            this.pnlContainer.Controls.Add(this.btnsave);
            this.pnlContainer.Controls.Add(this.gdv_branches);
            this.pnlContainer.Controls.Add(this.pnlEntry);
            this.pnlContainer.Location = new System.Drawing.Point(2, 1);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(677, 534);
            this.pnlContainer.TabIndex = 1;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(258, 121);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(79, 31);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(173, 121);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(79, 31);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(343, 121);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 31);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // gdv_branches
            // 
            this.gdv_branches.AllowUserToAddRows = false;
            this.gdv_branches.AllowUserToDeleteRows = false;
            this.gdv_branches.AllowUserToResizeColumns = false;
            this.gdv_branches.AllowUserToResizeRows = false;
            this.gdv_branches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_branches.Location = new System.Drawing.Point(3, 158);
            this.gdv_branches.Name = "gdv_branches";
            this.gdv_branches.ReadOnly = true;
            this.gdv_branches.Size = new System.Drawing.Size(666, 368);
            this.gdv_branches.TabIndex = 1;
            this.gdv_branches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_branches_CellDoubleClick);
            // 
            // pnlEntry
            // 
            this.pnlEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlEntry.Controls.Add(this.label10);
            this.pnlEntry.Controls.Add(this.txt_branch_code);
            this.pnlEntry.Controls.Add(this.txt_branch_id);
            this.pnlEntry.Controls.Add(this.label4);
            this.pnlEntry.Controls.Add(this.chk_branch_active);
            this.pnlEntry.Controls.Add(this.txt_branch_name);
            this.pnlEntry.Controls.Add(this.label1);
            this.pnlEntry.Location = new System.Drawing.Point(3, 3);
            this.pnlEntry.Name = "pnlEntry";
            this.pnlEntry.Size = new System.Drawing.Size(422, 112);
            this.pnlEntry.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Branch Code";
            // 
            // txt_branch_code
            // 
            this.txt_branch_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_code.Location = new System.Drawing.Point(6, 78);
            this.txt_branch_code.Name = "txt_branch_code";
            this.txt_branch_code.Size = new System.Drawing.Size(156, 24);
            this.txt_branch_code.TabIndex = 5;
            // 
            // txt_branch_id
            // 
            this.txt_branch_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_id.Location = new System.Drawing.Point(168, 78);
            this.txt_branch_id.Name = "txt_branch_id";
            this.txt_branch_id.ReadOnly = true;
            this.txt_branch_id.Size = new System.Drawing.Size(96, 24);
            this.txt_branch_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branch ID";
            // 
            // chk_branch_active
            // 
            this.chk_branch_active.AutoSize = true;
            this.chk_branch_active.ForeColor = System.Drawing.Color.Black;
            this.chk_branch_active.Location = new System.Drawing.Point(6, 42);
            this.chk_branch_active.Name = "chk_branch_active";
            this.chk_branch_active.Size = new System.Drawing.Size(103, 17);
            this.chk_branch_active.TabIndex = 2;
            this.chk_branch_active.Text = "Branch is Active";
            this.chk_branch_active.UseVisualStyleBackColor = true;
            // 
            // txt_branch_name
            // 
            this.txt_branch_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_branch_name.Location = new System.Drawing.Point(6, 16);
            this.txt_branch_name.Name = "txt_branch_name";
            this.txt_branch_name.Size = new System.Drawing.Size(258, 24);
            this.txt_branch_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch Name";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 536D;
            this.reSize1.InitialHostContainerWidth = 680D;
            this.reSize1.Tag = null;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(452, 130);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "--";
            // 
            // frmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(680, 536);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBranches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Branch Codes";
            this.Load += new System.EventHandler(this.frmBranches_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_branches)).EndInit();
            this.pnlEntry.ResumeLayout(false);
            this.pnlEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView gdv_branches;
        private System.Windows.Forms.Panel pnlEntry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_branch_code;
        private System.Windows.Forms.TextBox txt_branch_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_branch_active;
        private System.Windows.Forms.TextBox txt_branch_name;
        private System.Windows.Forms.Label label1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Label lblID;
    }
}