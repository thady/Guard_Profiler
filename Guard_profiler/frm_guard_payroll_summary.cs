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
    public partial class frm_guard_payroll_summary : Form
    {
        public frm_guard_payroll_summary()
        {
            InitializeComponent();
        }

        private void frm_guard_payroll_summary_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }

        protected void LoadSummary()
        {
            DataTable dt = Payroll_Engine.select_guard_payroll_summary("select_guard_payroll_summary", Convert.ToInt32(SystemConst._active_deployment_id), SystemConst._station_name);
            if (dt.Rows.Count > 0)
            {
                gdv_staff.DataSource = dt;

                gdv_staff.Columns[0].Width = 100;
                //gdv_staff.Columns[2].Width = 150;

                gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;
                gdv_staff.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                gdv_staff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_staff.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_staff.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_staff.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in this.gdv_staff.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11f, GraphicsUnit.Pixel);
                }
                this.gdv_staff.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdv_staff.EnableHeadersVisualStyles = false;

            }
        }
    }
}
