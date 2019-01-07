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
    public partial class frm_staff_payroll_summary_view : Form
    {
        public frm_staff_payroll_summary_view()
        {
            InitializeComponent();
        }

        private void frm_staff_payroll_summary_view_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }

        protected void LoadSummary()
        {
            DataTable dt = StaffPayrollReports.select_staff_payroll_summary("select_staff_payroll_summary", StaffPayrollReports._payment_period_id, StaffPayrollReports._branch_id, StaffPayrollReports._payment_month);
            if (dt.Rows.Count > 0)
            {
                gdv_staff.DataSource = dt;

                gdv_staff.Columns[4].Width = 90;
                gdv_staff.Columns[2].Width = 150;

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
