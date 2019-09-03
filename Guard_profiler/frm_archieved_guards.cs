using Guard_profiler.App_code;
using LarcomAndYoung.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Guard_profiler
{
	public class frm_archieved_guards : Form
	{
		private IContainer components;

		private Panel panel1;

		private Panel PanelContainer;
        private ReSize reSize1;
        private Button btnActivate;
        private TextBox txt_auto_id;
        private TextBox txt_guard_number;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_guard_num;
        private Label label2;
        private Button btnsearch;
        private Label label3;
        private TextBox txt_archive_reason;
        private Label label5;
        private Label label4;
        private Label lblRecordCount;
        private ToolTip ToolTip;
        private Label label6;
        private DataGridView gdv_guards;

		//private ReSize reSize1;

		public frm_archieved_guards()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frm_archieved_guards_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.GET_LIST_OF_ARCHIEVED_GUARDS();
		}

		protected void GET_LIST_OF_ARCHIEVED_GUARDS()
		{
			try
			{
				DataTable dt = sg_Profiles.RETURN_OFFICER_LIST("SELECT_LIST_OF_ARCHIEVED_GUARDS");
				if (dt != null)
				{
					this.gdv_guards.DataSource = dt;
					this.gdv_guards.Columns[0].Visible = false;
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
					this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
					this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
					this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
					this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    this.gdv_guards.Columns["guard_number"].HeaderText = "Guard Number";
                    this.gdv_guards.Columns["full_name"].HeaderText = "Guard Name";
                    this.gdv_guards.Columns["department"].HeaderText = "Department";
                    this.gdv_guards.Columns["position"].HeaderText = "Position";
                    this.gdv_guards.Columns["archieval_date"].HeaderText = "Archival Date";
                    this.gdv_guards.Columns["auto_id"].HeaderText = "Auto ID";
                    this.gdv_guards.Columns["guard_status"].HeaderText = "Guard Status";

                    lblRecordCount.Text = dt.Rows.Count.ToString() + " Records found";
                }
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
			}
		}

        protected void Search_archive()
        {
            try
            {
                DataTable dt = sg_Profiles.search_archive("search_archive", txt_guard_num.Text, txt_name.Text);
                if (dt != null)
                {
                    this.gdv_guards.DataSource = dt;
                    this.gdv_guards.Columns[0].Visible = false;
                    this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                    this.gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    this.gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                    this.gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    this.gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    this.gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                    this.gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    this.gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    this.gdv_guards.Columns["guard_number"].HeaderText = "Guard Number";
                    this.gdv_guards.Columns["full_name"].HeaderText = "Guard Name";
                    this.gdv_guards.Columns["department"].HeaderText = "Department";
                    this.gdv_guards.Columns["position"].HeaderText = "Position";
                    this.gdv_guards.Columns["archieval_date"].HeaderText = "Archival Date";
                    this.gdv_guards.Columns["auto_id"].HeaderText = "Auto ID";
                    this.gdv_guards.Columns["guard_status"].HeaderText = "Guard Status";

                    lblRecordCount.Text = dt.Rows.Count.ToString() + " Records found";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_archieved_guards));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_archive_reason = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_guard_num = new System.Windows.Forms.TextBox();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.txt_auto_id = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblRecordCount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_archive_reason);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_guard_num);
            this.panel1.Controls.Add(this.txt_guard_number);
            this.panel1.Controls.Add(this.txt_auto_id);
            this.panel1.Controls.Add(this.btnActivate);
            this.panel1.Controls.Add(this.PanelContainer);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 620);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doubleclick on a guard to start re-activation";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.ForeColor = System.Drawing.Color.Blue;
            this.lblRecordCount.Location = new System.Drawing.Point(426, 28);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(35, 13);
            this.lblRecordCount.TabIndex = 13;
            this.lblRecordCount.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(900, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Archival Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(796, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Guard Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(693, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Auto ID";
            // 
            // txt_archive_reason
            // 
            this.txt_archive_reason.Location = new System.Drawing.Point(903, 21);
            this.txt_archive_reason.Name = "txt_archive_reason";
            this.txt_archive_reason.ReadOnly = true;
            this.txt_archive_reason.Size = new System.Drawing.Size(100, 20);
            this.txt_archive_reason.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Blue;
            this.btnsearch.Location = new System.Drawing.Point(353, 6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(67, 35);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Guard Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guard Number";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(115, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(232, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_guard_num
            // 
            this.txt_guard_num.Location = new System.Drawing.Point(9, 21);
            this.txt_guard_num.Name = "txt_guard_num";
            this.txt_guard_num.Size = new System.Drawing.Size(100, 20);
            this.txt_guard_num.TabIndex = 4;
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Location = new System.Drawing.Point(799, 21);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.ReadOnly = true;
            this.txt_guard_number.Size = new System.Drawing.Size(100, 20);
            this.txt_guard_number.TabIndex = 3;
            // 
            // txt_auto_id
            // 
            this.txt_auto_id.Location = new System.Drawing.Point(693, 21);
            this.txt_auto_id.Name = "txt_auto_id";
            this.txt_auto_id.ReadOnly = true;
            this.txt_auto_id.Size = new System.Drawing.Size(100, 20);
            this.txt_auto_id.TabIndex = 2;
            // 
            // btnActivate
            // 
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.Color.Red;
            this.btnActivate.Location = new System.Drawing.Point(561, 6);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(126, 35);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "Re-Activate Guard";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.Yellow;
            this.PanelContainer.Controls.Add(this.gdv_guards);
            this.PanelContainer.Location = new System.Drawing.Point(3, 59);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1005, 558);
            this.PanelContainer.TabIndex = 0;
            this.ToolTip.SetToolTip(this.PanelContainer, "Double click on a guard to start re-activation");
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(3, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.ReadOnly = true;
            this.gdv_guards.Size = new System.Drawing.Size(999, 567);
            this.gdv_guards.TabIndex = 1;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            this.gdv_guards.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellDoubleClick);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 626D;
            this.reSize1.InitialHostContainerWidth = 1018D;
            this.reSize1.Tag = null;
            // 
            // frm_archieved_guards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1018, 626);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_archieved_guards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Archieved Guards";
            this.Load += new System.EventHandler(this.frm_archieved_guards_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.ResumeLayout(false);

		}

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gdv_guards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_guards.Rows.Count > 0)
            {
                string auto_id = gdv_guards.CurrentRow.Cells[6].Value.ToString();
                string guard_number = gdv_guards.CurrentRow.Cells[1].Value.ToString();
                txt_auto_id.Text = auto_id;
                txt_guard_number.Text = guard_number;
                txt_archive_reason.Text = gdv_guards.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            int count = sg_Profiles.check_if_archived_guard_number_is_taken("check_if_archived_guard_number_is_taken",txt_guard_number.Text);
            if (count > 0)
            {
                MessageBox.Show("You cannot activate this guard because there is already an activate guard who was assigned this guard number,guard numbers can never be duplicated!!,Operation failed", "Guard Profiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_archive_reason.Text == "Died")
            {
                MessageBox.Show("You cannot activate a guard who has died,operation failed", "Guard Profiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_auto_id.Text == string.Empty)
            {
                MessageBox.Show("No guard selected for re-activation,operation failed", "Guard Profiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure you want to activate this guard?This operation cannot be undone!!", "Re-activate Guard", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    sg_Profiles.ActivateGuard("activate_guard", Convert.ToInt32(txt_auto_id.Text));
                    MessageBox.Show("Successfully re-activated this guard", "Guard Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    base.Visible = true;
                }


            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search_archive();
        }
    }
}