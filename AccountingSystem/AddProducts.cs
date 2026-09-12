using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingSystem.Models;

namespace AccountingSystem
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }
        ProductsControl pc;
        private static int nextId = 1; // عداد الترقيم التلقائي
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product p = new Product
            {
                ID = nextId++, // زيادة الـ ID تلقائياً
                Name = txtName.Text.Trim(),
                PurchasePrice = decimal.TryParse(txtPurchasePrice.Text, out decimal pp) ? pp : 0,
                SalePrice = decimal.TryParse(txtSalePrice.Text, out decimal sp) ? sp : 0,
                Quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0
            };
            pc = new ProductsControl(p);
        }
    }
}
