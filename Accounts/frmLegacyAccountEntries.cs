using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccountsBackEnd;


namespace Accounts
{
    public partial class frmLegacyAccountEntries : Form
    {
        DataTable dt = new DataTable();
        public frmLegacyAccountEntries()
        {
            InitializeComponent();
            //setFont();
        }

        #region setFont
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        protected void setFont()
        {
            List<Control> allControls = GetAllControls(this);
            allControls.ForEach(k => k.Font = new System.Drawing.Font("Microsoft Sans Serif", 14));
        }
        #endregion

        private void frmLegacyAccountEntries_Load(object sender, EventArgs e)
        {
            //LoadRecords();
        }

        protected void LoadRecords()
        {
            dt = LegacyReports.LoadLegacyAccountEntries("select_legacy_transaction_entries",Convert.ToInt32(cboYear.Text));
            gdvList.DataSource = dt;

            gdvList.Columns["dat"].HeaderText = "Date";
            gdvList.Columns["tref"].HeaderText = "Reference Number";
            gdvList.Columns["chq"].HeaderText = "Cheque Number";
            gdvList.Columns["payee"].HeaderText = "Payee";
            gdvList.Columns["dcode"].HeaderText = "Debit Account code";
            gdvList.Columns["ccode"].HeaderText = "Credit Account code";
            gdvList.Columns["dtitle"].HeaderText = "Credit Account Title";
            gdvList.Columns["ctitle"].HeaderText = "Credit Account Title";
            gdvList.Columns["sub"].HeaderText = "Sub-Ledger";
            gdvList.Columns["amt"].HeaderText = "Amount";

            gdvList.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvList.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            gdvList.DefaultCellStyle.SelectionForeColor = Color.Black;
            foreach (DataGridViewColumn c in this.gdvList.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12f, GraphicsUnit.Pixel);
            }
            this.gdvList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvList.EnableHeadersVisualStyles = false;
        }

        private void btnLoadLegacyData_Click(object sender, EventArgs e)
        {
            if(cboYear.Text == string.Empty)
            {
                MessageBox.Show("Please select a financial year", "Load Legacy Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LoadRecords();
            }
        }
    }
}
