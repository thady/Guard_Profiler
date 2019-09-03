namespace Guard_profiler
{
    partial class frmFingerPrintCapture
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1298, 820);
            this.panelContainer.TabIndex = 0;
            // 
            // frmFingerPrintCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 826);
            this.Controls.Add(this.panelContainer);
            this.Name = "frmFingerPrintCapture";
            this.Text = "frmFingerPrintCapture";
            this.Load += new System.EventHandler(this.frmFingerPrintCapture_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
    }
}