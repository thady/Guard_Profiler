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
    public partial class frmItemCategories : Form
    {
        DataTable dt = new DataTable();
        public frmItemCategories()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != string.Empty)
            {
                save();
            }
            else
            {
                MessageBox.Show("Fill in all required values", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        protected void save()
        {
            if (lblid.Text == "-")
            {
                InventoryManager.save_item_category("save_item_category",Guid.NewGuid().ToString(), txtCategory.Text,chkActive.Checked == true?true:false,SystemConst._user_id,SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully saved","Item Categories",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
                LoadItemCategoryList();
            }
            else
            {
                InventoryManager.save_item_category("update_item_category",lblid.Text, txtCategory.Text, chkActive.Checked == true ? true : false, SystemConst._user_id, SystemConst._user_id, DateTime.Today);
                MessageBox.Show("Successfully updated", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                LoadItemCategoryList();
            }
        }

        protected void LoadItemCategoryList()
        {
            dt = InventoryManager.select_item_category_list("select_item_category_list");
            gdvItems.DataSource = dt;

            gdvItems.Columns["item_cat_id"].Visible = false;
            gdvItems.Columns["item_cat_name"].HeaderText = "Category Name";
            gdvItems.Columns["name"].HeaderText = "Created by";
            gdvItems.Columns["usr_date_update"].HeaderText = "Last Updated On";
            gdvItems.Columns["item_cat_active"].HeaderText = "Category is Active";

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

        private void frmItemCategories_Load(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Maximized;
            LoadItemCategoryList();
        }

        private void gdvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdvItems.Rows.Count > 0)
            {
                lblid.Text = gdvItems.CurrentRow.Cells[0].Value.ToString();
                txtCategory.Text = gdvItems.CurrentRow.Cells[1].Value.ToString();
                chkActive.Checked = Convert.ToBoolean(gdvItems.CurrentRow.Cells[3].Value.ToString());

                pnlContent.Enabled = false;
            }
        }

        protected void Clear()
        {
            lblid.Text = "-";
            txtCategory.Clear();
            pnlContent.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlContent.Enabled = true;
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            if (lblid.Text == "-")
            {
                MessageBox.Show("Please select a category", "Item Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InventoryManager.item_cat_id = lblid.Text;
                InventoryManager.item_name = txtCategory.Text;
                frmItemCategoryItem frmNew = new frmItemCategoryItem();
                frmNew.ShowDialog();
            }
        }
    }
}
