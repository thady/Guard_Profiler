using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guard_profiler
{
    public partial class frmInventoryPanel : Form
    {
        public frmInventoryPanel()
        {
            InitializeComponent();
        }

        private void btnItemCategory_Click(object sender, EventArgs e)
        {
            frmItemCategories frmNew = new frmItemCategories();
            frmNew.ShowDialog();
        }

        private void btnStockLevels_Click(object sender, EventArgs e)
        {
            frmItemStockIn frmNew = new frmItemStockIn();
            frmNew.ShowDialog();
        }

        private void btnStockIssue_Click(object sender, EventArgs e)
        {
            frmInventoryStockOut frmNew = new frmInventoryStockOut();
            frmNew.ShowDialog();
        }

        private void btnLostItem_Click(object sender, EventArgs e)
        {
            frmInventoryMissingItem frmNew = new frmInventoryMissingItem();
            frmNew.ShowDialog();
        }
    }
}
