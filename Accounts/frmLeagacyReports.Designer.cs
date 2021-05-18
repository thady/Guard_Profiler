
namespace Accounts
{
    partial class frmLeagacyReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeagacyReports));
            this.grbLegacyData = new System.Windows.Forms.GroupBox();
            this.btnClientstatement = new System.Windows.Forms.Button();
            this.btnDebtorsList = new System.Windows.Forms.Button();
            this.btnIncomeExpenditure = new System.Windows.Forms.Button();
            this.btnTrialBalance = new System.Windows.Forms.Button();
            this.btnAccountEntries = new System.Windows.Forms.Button();
            this.grbLegacyData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLegacyData
            // 
            this.grbLegacyData.Controls.Add(this.btnAccountEntries);
            this.grbLegacyData.Controls.Add(this.btnTrialBalance);
            this.grbLegacyData.Controls.Add(this.btnIncomeExpenditure);
            this.grbLegacyData.Controls.Add(this.btnClientstatement);
            this.grbLegacyData.Controls.Add(this.btnDebtorsList);
            this.grbLegacyData.Location = new System.Drawing.Point(2, 2);
            this.grbLegacyData.Name = "grbLegacyData";
            this.grbLegacyData.Size = new System.Drawing.Size(805, 334);
            this.grbLegacyData.TabIndex = 0;
            this.grbLegacyData.TabStop = false;
            this.grbLegacyData.Text = "Legacy Accounts Data Reports";
            // 
            // btnClientstatement
            // 
            this.btnClientstatement.Location = new System.Drawing.Point(253, 30);
            this.btnClientstatement.Name = "btnClientstatement";
            this.btnClientstatement.Size = new System.Drawing.Size(237, 70);
            this.btnClientstatement.TabIndex = 1;
            this.btnClientstatement.Text = "Client Statement";
            this.btnClientstatement.UseVisualStyleBackColor = true;
            this.btnClientstatement.Click += new System.EventHandler(this.btnClientstatement_Click);
            // 
            // btnDebtorsList
            // 
            this.btnDebtorsList.Location = new System.Drawing.Point(10, 30);
            this.btnDebtorsList.Name = "btnDebtorsList";
            this.btnDebtorsList.Size = new System.Drawing.Size(237, 70);
            this.btnDebtorsList.TabIndex = 0;
            this.btnDebtorsList.Text = "Debtors Lists";
            this.btnDebtorsList.UseVisualStyleBackColor = true;
            this.btnDebtorsList.Click += new System.EventHandler(this.btnDebtorsList_Click);
            // 
            // btnIncomeExpenditure
            // 
            this.btnIncomeExpenditure.Location = new System.Drawing.Point(496, 30);
            this.btnIncomeExpenditure.Name = "btnIncomeExpenditure";
            this.btnIncomeExpenditure.Size = new System.Drawing.Size(237, 70);
            this.btnIncomeExpenditure.TabIndex = 2;
            this.btnIncomeExpenditure.Text = "Income and Expenditure Report";
            this.btnIncomeExpenditure.UseVisualStyleBackColor = true;
            this.btnIncomeExpenditure.Click += new System.EventHandler(this.btnIncomeExpenditure_Click);
            // 
            // btnTrialBalance
            // 
            this.btnTrialBalance.Location = new System.Drawing.Point(10, 106);
            this.btnTrialBalance.Name = "btnTrialBalance";
            this.btnTrialBalance.Size = new System.Drawing.Size(237, 70);
            this.btnTrialBalance.TabIndex = 3;
            this.btnTrialBalance.Text = "Trial Balance Report";
            this.btnTrialBalance.UseVisualStyleBackColor = true;
            this.btnTrialBalance.Click += new System.EventHandler(this.btnTrialBalance_Click);
            // 
            // btnAccountEntries
            // 
            this.btnAccountEntries.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAccountEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountEntries.Location = new System.Drawing.Point(253, 106);
            this.btnAccountEntries.Name = "btnAccountEntries";
            this.btnAccountEntries.Size = new System.Drawing.Size(237, 70);
            this.btnAccountEntries.TabIndex = 4;
            this.btnAccountEntries.Text = "Account Entries";
            this.btnAccountEntries.UseVisualStyleBackColor = false;
            this.btnAccountEntries.Click += new System.EventHandler(this.btnAccountEntries_Click);
            // 
            // frmLeagacyReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 339);
            this.Controls.Add(this.grbLegacyData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLeagacyReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leagacy Accounts System Reports";
            this.grbLegacyData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLegacyData;
        private System.Windows.Forms.Button btnDebtorsList;
        private System.Windows.Forms.Button btnClientstatement;
        private System.Windows.Forms.Button btnIncomeExpenditure;
        private System.Windows.Forms.Button btnTrialBalance;
        private System.Windows.Forms.Button btnAccountEntries;
    }
}