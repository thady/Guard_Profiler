namespace Guard_profiler
{
    partial class frmInventoryPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventoryPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnItemCategory = new System.Windows.Forms.Button();
            this.btnStockIssue = new System.Windows.Forms.Button();
            this.btnStockLevels = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLostItem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnItemCategory
            // 
            this.btnItemCategory.ForeColor = System.Drawing.Color.Blue;
            this.btnItemCategory.Location = new System.Drawing.Point(4, 4);
            this.btnItemCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemCategory.Name = "btnItemCategory";
            this.btnItemCategory.Size = new System.Drawing.Size(529, 50);
            this.btnItemCategory.TabIndex = 7;
            this.btnItemCategory.Text = "Manage Item Categories";
            this.btnItemCategory.UseVisualStyleBackColor = true;
            this.btnItemCategory.Click += new System.EventHandler(this.btnItemCategory_Click);
            // 
            // btnStockIssue
            // 
            this.btnStockIssue.ForeColor = System.Drawing.Color.Blue;
            this.btnStockIssue.Location = new System.Drawing.Point(4, 113);
            this.btnStockIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockIssue.Name = "btnStockIssue";
            this.btnStockIssue.Size = new System.Drawing.Size(529, 50);
            this.btnStockIssue.TabIndex = 10;
            this.btnStockIssue.Text = "Manage Item Stock Issueing";
            this.btnStockIssue.UseVisualStyleBackColor = true;
            this.btnStockIssue.Click += new System.EventHandler(this.btnStockIssue_Click);
            // 
            // btnStockLevels
            // 
            this.btnStockLevels.ForeColor = System.Drawing.Color.Blue;
            this.btnStockLevels.Location = new System.Drawing.Point(4, 56);
            this.btnStockLevels.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockLevels.Name = "btnStockLevels";
            this.btnStockLevels.Size = new System.Drawing.Size(529, 50);
            this.btnStockLevels.TabIndex = 11;
            this.btnStockLevels.Text = "Manage Item Stock Levels";
            this.btnStockLevels.UseVisualStyleBackColor = true;
            this.btnStockLevels.Click += new System.EventHandler(this.btnStockLevels_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnLostItem);
            this.panel1.Controls.Add(this.btnStockLevels);
            this.panel1.Controls.Add(this.btnStockIssue);
            this.panel1.Controls.Add(this.btnItemCategory);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 333);
            this.panel1.TabIndex = 4;
            // 
            // btnLostItem
            // 
            this.btnLostItem.ForeColor = System.Drawing.Color.Red;
            this.btnLostItem.Location = new System.Drawing.Point(0, 166);
            this.btnLostItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnLostItem.Name = "btnLostItem";
            this.btnLostItem.Size = new System.Drawing.Size(529, 50);
            this.btnLostItem.TabIndex = 12;
            this.btnLostItem.Text = "Record Missing Item";
            this.btnLostItem.UseVisualStyleBackColor = true;
            this.btnLostItem.Click += new System.EventHandler(this.btnLostItem_Click);
            // 
            // frmInventoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventoryPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnItemCategory;
        private System.Windows.Forms.Button btnStockIssue;
        private System.Windows.Forms.Button btnStockLevels;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLostItem;
    }
}