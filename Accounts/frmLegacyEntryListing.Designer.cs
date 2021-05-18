
namespace Accounts
{
    partial class frmLegacyEntryListing
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
            this.grpboxEntries = new System.Windows.Forms.GroupBox();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.grpboxEntries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxEntries
            // 
            this.grpboxEntries.Controls.Add(this.grdList);
            this.grpboxEntries.Location = new System.Drawing.Point(3, 3);
            this.grpboxEntries.Name = "grpboxEntries";
            this.grpboxEntries.Size = new System.Drawing.Size(1147, 797);
            this.grpboxEntries.TabIndex = 0;
            this.grpboxEntries.TabStop = false;
            this.grpboxEntries.Text = "Entry Listings";
            // 
            // grdList
            // 
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Location = new System.Drawing.Point(6, 21);
            this.grdList.Name = "grdList";
            this.grdList.RowHeadersWidth = 51;
            this.grdList.RowTemplate.Height = 24;
            this.grdList.Size = new System.Drawing.Size(1135, 770);
            this.grdList.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 802D;
            this.reSize1.InitialHostContainerWidth = 1151D;
            this.reSize1.Tag = null;
            // 
            // frmLegacyEntryListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 802);
            this.Controls.Add(this.grpboxEntries);
            this.Name = "frmLegacyEntryListing";
            this.Text = "frmLegacyEntryListing";
            this.Load += new System.EventHandler(this.frmLegacyEntryListing_Load);
            this.grpboxEntries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxEntries;
        private System.Windows.Forms.DataGridView grdList;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}