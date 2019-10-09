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
    public partial class frmItemCategoryItem : Form
    {
        DataTable dt = new DataTable();
        public frmItemCategoryItem()
        {
            InitializeComponent();
        }

        private void frmItemCategoryItem_Load(object sender, EventArgs e)
        {
            lblid.Text = InventoryManager.item_cat_id;
            lbl_name.Text = InventoryManager.item_name;

            LoadItemList(lblid.Text);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != string.Empty)
            {
                save();
            }
            else
            {
                MessageBox.Show("Fill in all required fields", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void save()
        {
            if (lblitemid.Text == "-")
            {
                InventoryManager.save_item_details("save_item_details", Guid.NewGuid().ToString(), lblid.Text, txtCategory.Text, chkActive.Checked == true ? true : false, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully saved", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItemList(lblid.Text);
            }
            else
            {
                InventoryManager.save_item_details("update_item_details",lblitemid.Text, lblid.Text, txtCategory.Text, chkActive.Checked == true ? true : false, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully saved", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItemList(lblid.Text);
            }
          
        }

        protected void LoadItemList(string category_id)
        {
            dt = InventoryManager.select_itemList("select_item_list", category_id);
            gdvItems.DataSource = dt;

            gdvItems.Columns["item_id"].Visible = false;
            gdvItems.Columns["item_cat_name"].HeaderText = "Category Name";
            gdvItems.Columns["item_name"].HeaderText = "Item Name";
            gdvItems.Columns["item_active"].HeaderText = "Item Active";
            gdvItems.Columns["usr_date_update"].HeaderText = "Last Updated On";

            gdvItems.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            gdvItems.RowsDefaultCellStyle.BackColor = Color.LightGray;
            gdvItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            gdvItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gdvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItems.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gdvItems.DefaultCellStyle.SelectionBackColor = Color.White;
            gdvItems.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn c in this.gdvItems.Columns)
            {
                c.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 14f, GraphicsUnit.Pixel);
            }
            this.gdvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            this.gdvItems.EnableHeadersVisualStyles = false;
        }

        private void gdvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdvItems.Rows.Count > 0)
            {
                lblitemid.Text = gdvItems.CurrentRow.Cells[0].Value.ToString();
                txtCategory.Text = gdvItems.CurrentRow.Cells[2].Value.ToString();
                chkActive.Checked = Convert.ToBoolean(gdvItems.CurrentRow.Cells[3].Value.ToString());
                pnlContent.Enabled = false;
            }
        }

        protected void Clear()
        {
            lblitemid.Text = "-";
            txtCategory.Clear();
            pnlContent.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlContent.Enabled = true;
        }
    }
}
