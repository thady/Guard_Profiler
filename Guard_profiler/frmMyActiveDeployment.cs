using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frmMyActiveDeployment : Form
    {
        public frmMyActiveDeployment()
        {
            InitializeComponent();
        }

        private void frmMyActiveDeployment_Load(object sender, EventArgs e)
        {
            return_deployment_periods();
            LoadMycurrentDeployPeriod();

            lblname.Text = SystemConst._name;
        }

        protected void return_deployment_periods()
        {
            DataTable dt = Guard_deployment.Return_list_of_deployment_periods("return_list_of_deployment_periods");
            if (dt.Rows.Count > 0)
            {
                this.gdv_deployment_periods.DataSource = dt;
                this.gdv_deployment_periods.Columns["deploy_id"].Visible = false;
                this.gdv_deployment_periods.Columns["deploy_start_date"].HeaderText = "Deployment start date";
                this.gdv_deployment_periods.Columns["deploy_end_date"].HeaderText = "Deployment end date";
                this.gdv_deployment_periods.Columns["created_by"].HeaderText = "Created by";
                this.gdv_deployment_periods.Columns["active_deployment"].Visible = false;
                this.gdv_deployment_periods.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_deployment_periods.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_deployment_periods.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_deployment_periods.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                this.gdv_deployment_periods.DefaultCellStyle.SelectionForeColor = Color.Black;
                foreach (DataGridViewColumn c in this.gdv_deployment_periods.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
                }
                this.gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_deployment_periods.EnableHeadersVisualStyles = false;
            }


           
        }

        protected void LoadMycurrentDeployPeriod()
        {
            DataTable _dt = Guard_deployment.select_my_active_deployment_period("select_my_active_deployment_period", SystemConst._user_id);
            if (_dt.Rows.Count > 0)
            {
                this.gdv_current_deployment_period.DataSource = _dt;
                this.gdv_current_deployment_period.Columns["deploy_id"].Visible = false;
                this.gdv_current_deployment_period.Columns["deploy_start_date"].HeaderText = "Deployment start date";
                this.gdv_current_deployment_period.Columns["deploy_end_date"].HeaderText = "Deployment end date";
                this.gdv_current_deployment_period.Columns["user_id"].Visible = false;
                this.gdv_current_deployment_period.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdv_current_deployment_period.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdv_current_deployment_period.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdv_current_deployment_period.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_current_deployment_period.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdv_current_deployment_period.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                this.gdv_current_deployment_period.DefaultCellStyle.SelectionForeColor = Color.Black;
                foreach (DataGridViewColumn c in this.gdv_current_deployment_period.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
                }
                this.gdv_current_deployment_period.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_current_deployment_period.EnableHeadersVisualStyles = false;
            }
        }

        protected void Set_current_deployment_periods()
        {
            DataTable dt = Guard_deployment.select_my_active_deployment_period("select_my_active_deployment_period", SystemConst._user_id);
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];
                int num = Convert.ToInt32(dtRow["deploy_id"].ToString());
                SystemConst._active_deployment_id = num.ToString();
                SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
                SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
            }
            else
            {
                SystemConst._active_deployment_id = string.Empty;
            }
        }

        private void gdv_deployment_periods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.gdv_deployment_periods.Rows.Count > 0)
            {
                this.dt_start_date.Value = Convert.ToDateTime(this.gdv_deployment_periods.CurrentRow.Cells[1].Value);
                this.dt_end_date.Value = Convert.ToDateTime(this.gdv_deployment_periods.CurrentRow.Cells[2].Value);
                this.lbl_guid.Text = this.gdv_deployment_periods.CurrentRow.Cells[0].Value.ToString();
            }
        }

        protected void save()
        {
            if (lbl_guid.Text == "lbl_guid")
            {
                MessageBox.Show("Please select a deployment period from the list", "Guard Profiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Guard_deployment.save_update_my_current_deployment_period("save_my_current_deploy_period", Convert.ToInt32(lbl_guid.Text), SystemConst._user_id);
                MessageBox.Show("Successfully updated your current deployment period", "Guard Profiler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return_deployment_periods();
                LoadMycurrentDeployPeriod();
                Set_current_deployment_periods();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}
