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
    public partial class frmInventoryStockOut : Form
    {
        DataTable dt = new DataTable();
        public static string errorMessage = string.Empty;
        public frmInventoryStockOut()
        {
            InitializeComponent();
        }

        private void frmInventoryStockOut_Load(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
            LoadItemCategoryList();
            LoadGuardList();
            LoadStockRecords();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedValue.ToString() == "-1" || txtQtyIssued.Text == "0" || txtQtyIssued.Text == string.Empty)
            {
                MessageBox.Show("No Item or Quantity Supplied", "Add Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (decimal.Parse(txtQtyIssued.Text) > decimal.Parse(txtQty.Text))
            {
                MessageBox.Show("There is not enough stock for the selected item", "Add Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AddToCatalogue();
            }
        }

        protected void AddToCatalogue()
        {
            string item_id = cboItem.SelectedValue.ToString();
            string item_name = cboItem.Text;
            string staff_id = cbostaff.Text;
            DateTime dateReceived = dtReceiveDate.Value.Date;
            string qty = txtQtyIssued.Text;

            if (checkItemInCatalogue(item_id))
            {
                gdvItemCatalogue.Rows.Add(item_id, item_name, staff_id, qty, false);


                this.gdvItemCatalogue.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdvItemCatalogue.DefaultCellStyle.SelectionForeColor = Color.Black;
                this.gdvItemCatalogue.RowsDefaultCellStyle.BackColor = Color.LightGray;
                this.gdvItemCatalogue.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                this.gdvItemCatalogue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.gdvItemCatalogue.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdvItemCatalogue.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                this.gdvItemCatalogue.DefaultCellStyle.SelectionBackColor = Color.White;
                this.gdvItemCatalogue.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in this.gdvItemCatalogue.Columns)
                {
                    c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14f, GraphicsUnit.Pixel);
                }
                this.gdvItemCatalogue.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                this.gdvItemCatalogue.EnableHeadersVisualStyles = false;
            }
            else
            {
                MessageBox.Show("Item already posted in the catalogue,please consider editing or removing item from catalogue first", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected bool checkItemInCatalogue(string item_id)
        {
            bool isValid = true;
            if (gdvItemCatalogue.Rows.Count > 0)
            {
                for (int i = 0; i < gdvItemCatalogue.Rows.Count; i++)
                {
                    string _item_id = gdvItemCatalogue.Rows[i].Cells[0].Value.ToString();
                    if (item_id.Equals(_item_id))
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        protected void RemoveItem()
        {
            for (int x = 0; x < gdvItemCatalogue.Rows.Count; x++)
            {
                bool isChecked = Convert.ToBoolean(gdvItemCatalogue.Rows[x].Cells[4].Value);
                if (isChecked)
                {
                    gdvItemCatalogue.Rows.RemoveAt(x);
                    gdvItemCatalogue.Refresh();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void Clear()
        {
            cboItem.SelectedValue = "-1";
            cbostaff.Text = string.Empty;
            txtQtyIssued.Text = "0";
            dtReceiveDate.Value = DateTime.Today;
            gdvItemCatalogue.Rows.Clear();
            gdvItemCatalogue.Refresh();
            lblid.Text = "--";
            btnsave.Enabled = true;
        }

        private void txtQtyIssued_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the selected items from the list", "Remove Items", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                RemoveItem();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void cbostaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbostaff.SelectedValue.ToString() != "-1")
            {
                lblItemsCatalogHeader.Text = "Items Catalogue-Items to be issued to:" + cbostaff.Text;
            }
            else
            {
                lblItemsCatalogHeader.Text = "Items Catalogue";
            }
        }


        protected void save()
        {
            if (gdvItemCatalogue.Rows.Count > 0)
            {
                System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Are you sure you want to Issue out these items to " + cbostaff.Text + "?", "Item StockOut", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    if (lblid.Text == "--")
                    {
                        string stockout_main_id = Guid.NewGuid().ToString();
                        InventoryManager.save_item_stockout_main("save_item_stockout_main", stockout_main_id,dtReceiveDate.Value,gdvItemCatalogue.Rows.Count,cbostaff.SelectedValue.ToString(),"Item StockOut",SystemConst._user_id,SystemConst._user_id, DateTime.Today);
                        if (ValidateStockValues())
                        {
                            for (int x = 0; x < gdvItemCatalogue.Rows.Count; x++)
                            {
                                string item_id = gdvItemCatalogue.Rows[x].Cells[0].Value.ToString();
                                string item_name = gdvItemCatalogue.Rows[x].Cells[1].Value.ToString();
                                string receiver_id = gdvItemCatalogue.Rows[x].Cells[2].Value.ToString();
                                decimal issue_qty = decimal.Parse(gdvItemCatalogue.Rows[x].Cells[3].Value.ToString());
                                DateTime issue_date = dtReceiveDate.Value.Date;

                                InventoryManager.save_item_stockout("save_item_stockout", Guid.NewGuid().ToString(), stockout_main_id, item_id, issue_qty, dtReceiveDate.Value, cbostaff.SelectedValue.ToString(), "Item StockOut", SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                            }

                            MessageBox.Show("Items have been successfully issued out to " + cbostaff.Text, "Inventory Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStockRecords();
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //tell user to edit instead
                    }
                }
                else
                {
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No Items found in feeds catalogue,save failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected bool ValidateStockValues()
        {
            bool isValid = true;
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < gdvItemCatalogue.Rows.Count; x++)
            {
                string item_id = gdvItemCatalogue.Rows[x].Cells[0].Value.ToString();
                string item_name = gdvItemCatalogue.Rows[x].Cells[1].Value.ToString();
                decimal issue_Qty = decimal.Parse(gdvItemCatalogue.Rows[x].Cells[3].Value.ToString());
                decimal item_available_stock = InventoryManager.select_item_available_stock("select_item_available_stock", item_id);

                if (item_available_stock < issue_Qty)
                {
                    sb.Append(item_name + ",");
                    isValid = false;
                }
            }
            errorMessage = "Some Feeds have low stock compared to what is being issued out,items: " + sb.ToString() + " are too low in stock!!,save failed";

            return isValid;
        }

        private void btnsaveCatalogue_Click(object sender, EventArgs e)
        {
            save();
        }

        protected void LoadStockRecords()
        {
            dt = InventoryManager.LoadStockOutRecord("select_item_stockout_records");

            gdvStockRecords.DataSource = dt;
            gdvStockRecords.Columns["stockout_main_id"].Visible = false;
            gdvStockRecords.Columns["record_guid"].Visible = false;
            gdvStockRecords.Columns["usr_date_update"].Visible = false;

            gdvStockRecords.Columns["issue_date"].HeaderText = "Date";
            gdvStockRecords.Columns["item_count"].HeaderText = "Item Count";
            gdvStockRecords.Columns["full_name"].HeaderText = "Issued To";
            gdvStockRecords.Columns["notes"].HeaderText = "Notes";
            gdvStockRecords.Columns["name"].HeaderText = "Issued By";
            gdvStockRecords.Columns["full_name"].Width = 250;
            gdvStockRecords.Columns["item_count"].Width = 50;
            gdvStockRecords.Columns["issue_date"].Width = 100;

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
                InventoryManager.itemstockout_main_id = gdvStockRecords.CurrentRow.Cells[0].Value.ToString();
                InventoryManager.stock_date = Convert.ToDateTime(gdvStockRecords.CurrentRow.Cells[2].Value);
                InventoryManager.guard_id = gdvStockRecords.CurrentRow.Cells[1].Value.ToString();
                frmInventoryStockOutItemDetails frmNew = new frmInventoryStockOutItemDetails();
                frmNew.ShowDialog();
            }
        }
    }
}
