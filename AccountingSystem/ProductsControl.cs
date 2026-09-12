using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AccountingSystem.Models;

namespace AccountingSystem
{
    public partial class ProductsControl : UserControl
    {
        // قائمة ذكية تزامنية تحدّث الـ DataGridView تلقائياً بدون إعادة ربط
        public static BindingList<Product> ProductsList = new BindingList<Product>();
        AddProducts p1;

        public ProductsControl()
        {
            InitializeComponent();

            // ربط القائمة بالشبكة مرة واحدة فقط
            dgvProducts.DataSource = ProductsList;
        }
        public ProductsControl(Product p)
        {
            ProductsList.Add(p);
        }
        // زر الإضافة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            p1 = new AddProducts();
           p1.ShowDialog();
        }

        // زر التعديل
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.Index < 0) return;

            int selectedId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ID"].Value);
            Product productToEdit = ProductsList.FirstOrDefault(p => p.ID == selectedId);

            if (productToEdit != null)
            {
                productToEdit.Name = txtName.Text.Trim();
                productToEdit.PurchasePrice = decimal.TryParse(txtPurchasePrice.Text, out decimal pp) ? pp : 0;
                productToEdit.SalePrice = decimal.TryParse(txtSalePrice.Text, out decimal sp) ? sp : 0;
                productToEdit.Quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0;

                ProductsList.ResetBindings(); // إعادة تحديث العرض في الجدول بسلامة
                ClearFields();
            }
        }

        // زر الحذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.Index < 0) return;

            int selectedId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ID"].Value);
            Product productToDelete = ProductsList.FirstOrDefault(p => p.ID == selectedId);

            if (productToDelete != null)
            {
                ProductsList.Remove(productToDelete); // الحذف فورياً بدون كراش
                ClearFields();
            }
        }

        // حدث الضغط على صف في الجدول (CellClick)
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // حماية صارمة لمنع خطأ Index -1 عند الضغط على العناوين أو الهوامش
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            txtID.Text = row.Cells["ID"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value?.ToString();
            txtSalePrice.Text = row.Cells["SalePrice"].Value?.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
        }

        // البحث السريع
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchValue))
            {
                dgvProducts.DataSource = ProductsList;
            }
            else
            {
                var filtered = ProductsList.Where(p => p.Name.ToLower().Contains(searchValue)).ToList();
                dgvProducts.DataSource = filtered;
            }
        }

        // دالة تنظيف الحقول
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            txtQuantity.Clear();
            dgvProducts.ClearSelection();
        }

        private void ProductsControl_Load(object sender, EventArgs e)
        {

        }
    }
}