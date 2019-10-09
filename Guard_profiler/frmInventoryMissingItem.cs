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
    public partial class frmInventoryMissingItem : Form
    {
        DataTable dt = new DataTable();
        public frmInventoryMissingItem()
        {
            InitializeComponent();
        }

        private void frmInventoryMissingItem_Load(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
            LoadItemCategoryList();
            LoadGuardList();
            LoadMissingItems();
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
        private void gdvStockRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbostaff_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtAssignedItemQty.Text = InventoryManager.select_item_qty_assigned_to_guard("select_item_qty_assigned_to_guard", cboItem.SelectedValue.ToString(), cbostaff.SelectedValue.ToString()).ToString();
        }

        private void cbostaff_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtAssignedItemQty.Text = InventoryManager.select_item_qty_assigned_to_guard("select_item_qty_assigned_to_guard", cboItem.SelectedValue.ToString(), cbostaff.SelectedValue.ToString()).ToString();
        }

        protected void save()
        {
            if (cboItem.SelectedValue.ToString() == "-1" || cbostaff.SelectedValue.ToString() == "-1" || txtQtyLost.Text == string.Empty || decimal.Parse(txtQtyLost.Text) > decimal.Parse(txtAssignedItemQty.Text) || decimal.Parse(txtQtyLost.Text) <= 0)
            {
                MessageBox.Show("Item item or staff name cannot be empty,Quantity of items lost must not be greater than the total item quantity assigned to staff member","Missing Items",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (lblid.Text == "-")
                {
                    InventoryManager.save_missing_item("save_missing_item", Guid.NewGuid().ToString(), cboItem.SelectedValue.ToString(), cbostaff.SelectedValue.ToString(), dtReceiveDate.Value, decimal.Parse(txtQtyLost.Text), txtComment.Text, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                    MessageBox.Show("Successfully recorded missing item", "Missing Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMissingItems();
                }
                else
                {
                    InventoryManager.save_missing_item("update_missing_item", lblid.Text, cboItem.SelectedValue.ToString(), cbostaff.SelectedValue.ToString(), dtReceiveDate.Value, decimal.Parse(txtQtyLost.Text), txtComment.Text, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                    MessageBox.Show("Successfully updated missing item", "Missing Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMissingItems();
                }
            }
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            save();
        }

        protected void LoadMissingItems()
        {
            dt = InventoryManager.select_lost_item_list("select_lost_item_list");

            gdvMissingItems.DataSource = dt;
            gdvMissingItems.Columns["record_id"].Visible = false;
            gdvMissingItems.Columns["item_id"].Visible = false;
            gdvMissingItems.Columns["guard_id"].Visible = false;
            gdvMissingItems.Columns["notes"].Visible = false;
            gdvMissingItems.Columns["usr_date_update"].Visible = false;

            gdvMissingItems.Columns["date_lost"].HeaderText = "Missing Date";
            gdvMissingItems.Columns["item_name"].HeaderText = "Item Name";
            gdvMissingItems.Columns["full_name"].HeaderText = "Guard Name";
            gdvMissingItems.Columns["qty_lost"].HeaderText = "Item Qty Lost";
            gdvMissingItems.Columns["name"].HeaderText = "Updated By";


            this.gdvMissingItems.DefaultCellStyle.SelectionBackColor = Color.White;
            this.gdvMissingItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.gdvMissingItems.RowsDefaultCellStyle.BackColor = Color.LightGray;
            this.gdvMissingItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.gdvMissingItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.gdvMissingItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdvMissingItems.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            this.gdvMissingItems.DefaultCellStyle.SelectionBackColor = Color.White;
            this.gdvMissingItems.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn c in this.gdvMissingItems.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14f, GraphicsUnit.Pixel);
            }
            this.gdvMissingItems.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvMissingItems.EnableHeadersVisualStyles = false;
        }
    }
}
