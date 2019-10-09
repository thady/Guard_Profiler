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
    public partial class frmInventoryStockOutItemDetails : Form
    {
        DataTable dt = new DataTable();
        public frmInventoryStockOutItemDetails()
        {
            InitializeComponent();
        }

        private void frmInventoryStockOutItemDetails_Load(object sender, EventArgs e)
        {
            LoadGuardList();
            LoadItemCategoryList();
            SetRecordDetails();
            LoadStockRecords(lblstockoutmainid.Text);
        }

        protected void SetRecordDetails()
        {
            cbostaff.SelectedValue = InventoryManager.guard_id;
            lblstockoutmainid.Text = InventoryManager.itemstockout_main_id;
            this.Text = "Item StockOut Record Details-" + cbostaff.Text;
            dtReceiveDate.Value = InventoryManager.stock_date;
        }


        protected void LoadGuardList()
        {
            DataTable dt = InventoryManager.select_guardList("select_guard_list");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["full_name"] = string.Empty;
                dtRow["record_guid"] = string.Empty;
                dt.Rows.InsertAt(dtRow, 0);
                this.cbostaff.DataSource = dt;
                this.cbostaff.DisplayMember = "full_name";
                this.cbostaff.ValueMember = "record_guid";

                this.cbostaff.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbostaff.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        protected void LoadItemCategoryList()
        {
            dt = InventoryManager.select_item_category_list("select_item_list_all");

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

        protected void LoadStockRecords(string stockout_main_id)
        {
            dt = InventoryManager.select_line_items_by_stockoutmain_id("select_line_items_by_stockoutmain_id", stockout_main_id);

            gdvStockRecords.DataSource = dt;
            gdvStockRecords.Columns["stockout_id"].Visible = false;
            gdvStockRecords.Columns["item_id"].Visible = false;

            gdvStockRecords.Columns["item_name"].HeaderText = "Date";
            gdvStockRecords.Columns["qty_issued"].HeaderText = "Qty Issued";
            gdvStockRecords.Columns["notes"].HeaderText = "Notes"; 

            this.gdvStockRecords.DefaultCellStyle.SelectionBackColor = Color.White;
            this.gdvStockRecords.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.gdvStockRecords.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gdvStockRecords.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.gdvStockRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gdvStockRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdvStockRecords.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdvStockRecords.DefaultCellStyle.SelectionBackColor = Color.White;
            this.gdvStockRecords.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn c in this.gdvStockRecords.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12f, GraphicsUnit.Pixel);
            }
            this.gdvStockRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvStockRecords.EnableHeadersVisualStyles = false;
        }

        private void gdvStockRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdvStockRecords.Rows.Count > 0)
            {
                lblstockoutid.Text = gdvStockRecords.CurrentRow.Cells[0].Value.ToString();
                cboItem.SelectedValue = gdvStockRecords.CurrentRow.Cells[1].Value.ToString();
                txtQtyIssued.Text = gdvStockRecords.CurrentRow.Cells[3].Value.ToString();
                panelMain.Enabled = false;
            }
        }

        protected void Clear()
        {
            cboItem.SelectedValue = "-1";
            txtQtyIssued.Clear();
            lblstockoutid.Text = "--";
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.SelectedValue.ToString() != "-1")
            {
                txtQty.Text = InventoryManager.select_item_available_stock("select_item_available_stock", cboItem.SelectedValue.ToString()).ToString();
            }
            else
            {
                txtQty.Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelMain.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        protected void save()
        {
            if (cboItem.SelectedValue.ToString() == "-1" || (txtQtyIssued.Text == string.Empty || decimal.Parse(txtQtyIssued.Text) <= 0))
            {
                MessageBox.Show("Item name or Qty Issued cannot be empty","Inventory Manager",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (decimal.Parse(txtQtyIssued.Text) > decimal.Parse(txtQty.Text))
            {
                MessageBox.Show("Quantity issued cannot be greater that available stock for this item", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure you want to update stockout details for" + cbostaff.Text + "?", "Item StockOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    InventoryManager.save_item_stockout("update_item_stockout", lblstockoutid.Text, lblstockoutmainid.Text, cboItem.SelectedValue.ToString(), decimal.Parse(txtQtyIssued.Text), dtReceiveDate.Value, cbostaff.SelectedValue.ToString(), "Item StockOut", SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                    MessageBox.Show("Successfully Updated stock issued for this item", "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Visible = true;
                }
                    
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
