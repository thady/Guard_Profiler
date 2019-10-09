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
    public partial class frmItemStockIn : Form
    {
        DataTable dt = new DataTable();
        public frmItemStockIn()
        {
            InitializeComponent();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmItemStockIn_Load(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
            LoadItemCategoryList();
            LoadItemStockLevels();
            LoadItemStockList();
        }

        protected void LoadItemCategoryList()
        {
            dt = InventoryManager.select_item_category_list("select_item_category_list");

            DataRow dtRow = dt.NewRow();
            dtRow["item_cat_name"] = "select one";
            dtRow["item_cat_id"] = "-1";
            dt.Rows.InsertAt(dtRow, 0);
            this.cboItemCategory.DataSource = dt;
            this.cboItemCategory.DisplayMember = "item_cat_name";
            this.cboItemCategory.ValueMember = "item_cat_id";

            this.cboItemCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboItemCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        protected void LoadItemList(string category_id)
        {
            dt = InventoryManager.select_itemList("select_item_list", category_id);

            DataRow dtRow = dt.NewRow();
            dtRow["item_name"] = "select one";
            dtRow["item_id"] = "-1";
            dt.Rows.InsertAt(dtRow, 0);
            this.cboItem.DataSource = dt;
            this.cboItem.DisplayMember = "item_name";
            this.cboItem.ValueMember = "item_id";

            this.cboItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboItem.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemList(cboItemCategory.SelectedValue.ToString());
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedValue.ToString() == "-1" || cboItemCategory.SelectedValue.ToString() == "-1" || txtQty.Text == string.Empty)
            {
                MessageBox.Show("Fill in all required fields", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                saveItemStock();
            }
        }

        protected void saveItemStock()
        {
            if (lblid.Text == "-")
            {
                InventoryManager.save_item_stock("save_item_stock", Guid.NewGuid().ToString(), dtsockdate.Value, cboItem.SelectedValue.ToString(), Convert.ToDecimal(txtQty.Text), txtNotes.Text, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully saved", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItemStockLevels();
                LoadItemStockList();
                Clear();
            }
            else
            {
                InventoryManager.save_item_stock("update_item_stock",lblid.Text, dtsockdate.Value, cboItem.SelectedValue.ToString(), Convert.ToDecimal(txtQty.Text), txtNotes.Text, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully saved", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItemStockLevels();
                LoadItemStockList();
                Clear();
            }
            
        }

        protected void LoadItemStockLevels()
        {
            dt = InventoryManager.select_item_category_list("select_item_stock_levels");
            gdvItems.DataSource = dt;

            gdvItems.Columns["item_cat_name"].HeaderText = "Item Category Name";
            gdvItems.Columns["item_name"].HeaderText = "Item Name";
            gdvItems.Columns["qty"].HeaderText = "Available Stock";
            gdvItems.Columns["last_restock_date"].HeaderText = "Last Restocked On";

            gdvItems.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            gdvItems.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItems.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItems.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItems.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewRow row in gdvItems.Rows)
                if (Convert.ToInt32(row.Cells[2].Value) < 20)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

            foreach (DataGridViewColumn c in this.gdvItems.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12f, GraphicsUnit.Pixel);
            }
            this.gdvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvItems.EnableHeadersVisualStyles = false;  
        }

        protected void LoadItemStockList()
        {
            dt = InventoryManager.select_item_category_list("select_item_stock_list");
            gdvItemStockList.DataSource = dt;

            gdvItemStockList.Columns["stock_id"].Visible = false;
            gdvItemStockList.Columns["item_id"].Visible = false;
            gdvItemStockList.Columns["item_cat_id"].Visible = false;
            gdvItemStockList.Columns["notes"].Visible = false;
            gdvItemStockList.Columns["stock_date"].HeaderText = "Date";
            gdvItemStockList.Columns["item_cat_name"].HeaderText = "Category";
            gdvItemStockList.Columns["item_name"].HeaderText = "Item";
            gdvItemStockList.Columns["qty"].HeaderText = "Stockin Qty";


            gdvItemStockList.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItemStockList.DefaultCellStyle.SelectionForeColor = Color.Black;
            gdvItemStockList.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvItemStockList.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvItemStockList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvItemStockList.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItemStockList.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItemStockList.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItemStockList.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn c in this.gdvItemStockList.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12f, GraphicsUnit.Pixel);
            }
            this.gdvItemStockList.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvItemStockList.EnableHeadersVisualStyles = false;
        }

        private void gdvItemStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdvItemStockList.Rows.Count > 0)
            {
                lblid.Text = gdvItemStockList.CurrentRow.Cells[0].Value.ToString();
                dtsockdate.Value = Convert.ToDateTime(gdvItemStockList.CurrentRow.Cells[3].Value.ToString());
                cboItemCategory.SelectedValue = gdvItemStockList.CurrentRow.Cells[2].Value.ToString();
                cboItem.SelectedValue = gdvItemStockList.CurrentRow.Cells[1].Value.ToString();
                txtQty.Text = gdvItemStockList.CurrentRow.Cells[6].Value.ToString();
                txtNotes.Text = gdvItemStockList.CurrentRow.Cells[7].Value.ToString();

                pnlContent.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlContent.Enabled = true;
        }

        protected void Clear()
        {
            lblid.Text = "-";
            dtsockdate.Value = DateTime.Today;
            cboItemCategory.SelectedValue = "-1";
            txtNotes.Clear();
            txtQty.Clear();
            pnlContent.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
