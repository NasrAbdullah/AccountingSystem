using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AccountingSystem.Models;
using AccountingSystem.Classes;

namespace AccountingSystem
{
    public partial class PurchasesControl : UserControl
    {
        // قائمة الفواتير المحفوظة
        public static BindingList<PurchaseInvoice> InvoicesList = new BindingList<PurchaseInvoice>();

        // عناصر الفاتورة الحالية الجاري إعدادها
        private BindingList<PurchaseItem> currentInvoiceItems = new BindingList<PurchaseItem>();
        private static int nextInvoiceId = 1;

        public PurchasesControl()
        {
            InitializeComponent();

            // ربط جدول تفاصيل الفاتورة القائمة
            dgvInvoiceItems.DataSource = currentInvoiceItems;
        }

        // عند تحميل الواجهة، نملأ القوائم المنسدلة بالموردين والمنتجات الحالية
        private void PurchasesControl_Load(object sender, EventArgs e)
        {
            LoadVendorsAndProducts();

            UITheme.ApplyButton(btnAddItem);
            UITheme.ApplySecondaryButton(btnSaveInvoice);

            UITheme.ApplyDataGridView(dgvInvoiceItems);
            UITheme.ApplyHeader(panel1);
            UITheme.ApplyCard(panel2);
           
        }

        public void LoadVendorsAndProducts()
        {
            // تعبئة كومبو الموردين
            cmbVendors.DataSource = null;
            cmbVendors.DataSource = VendorsControl.VendorsList;
            cmbVendors.DisplayMember = "Name";
            cmbVendors.ValueMember = "ID";

            // تعبئة كومبو المنتجات
            cmbProducts.DataSource = null;
            cmbProducts.DataSource = ProductsControl.ProductsList;
            cmbProducts.DisplayMember = "Name";
            cmbProducts.ValueMember = "ID";
        }

        // عند اختيار منتج من الكومبو، يظهر سعر الشراء تلقائياً في مربع السعر
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selectedProduct)
            {
                txtPrice.Text = selectedProduct.PurchasePrice.ToString();
            }
        }

        // زر إضافة صنف للفاتورة الحالية
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product selectedProduct)
            {
                if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
                {
                    MessageBox.Show("يرجى إدخال كمية صالحة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : selectedProduct.PurchasePrice;

                // التحقق مما إذا كان المنتج مضافاً سابقاً في الفاتورة الحالية
                var existingItem = currentInvoiceItems.FirstOrDefault(i => i.ProductID == selectedProduct.ID);
                if (existingItem != null)
                {
                    existingItem.Quantity += qty;
                    currentInvoiceItems.ResetBindings();
                }
                else
                {
                    currentInvoiceItems.Add(new PurchaseItem
                    {
                        ProductID = selectedProduct.ID,
                        ProductName = selectedProduct.Name,
                        Quantity = qty,
                        UnitPrice = price
                    });
                }

                CalculateInvoiceTotal();
                txtQuantity.Clear();
            }
        }

        // حساب إجمالي الفاتورة والمتبقي
        private void CalculateInvoiceTotal()
        {
            decimal total = currentInvoiceItems.Sum(item => item.TotalPrice);
            lblTotal.Text = total.ToString("N2");

            decimal paid = decimal.TryParse(txtPaid.Text, out decimal p) ? p : 0;
            lblRemaining.Text = (total - paid).ToString("N2");
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        // زر حفظ وتأكيد الفاتورة
        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (currentInvoiceItems.Count == 0)
            {
                MessageBox.Show("لا يمكن حفظ فاتورة فارغة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(cmbVendors.SelectedItem is Vendor selectedVendor))
            {
                MessageBox.Show("يرجى اختيار مورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = currentInvoiceItems.Sum(i => i.TotalPrice);
            decimal paid = decimal.TryParse(txtPaid.Text, out decimal p) ? p : 0;
            decimal remaining = total - paid;

            // 1. إنشـاء كائن الفاتورة
            PurchaseInvoice invoice = new PurchaseInvoice
            {
                ID = nextInvoiceId++,
                VendorID = selectedVendor.ID,
                VendorName = selectedVendor.Name,
                Date = DateTime.Now,
                Items = currentInvoiceItems.ToList(),
                TotalAmount = total,
                PaidAmount = paid
            };

            // 2. تحديث كميات المنتجات في المخزون تلقائياً (+)
            foreach (var item in currentInvoiceItems)
            {
                var prod = ProductsControl.ProductsList.FirstOrDefault(pr => pr.ID == item.ProductID);
                if (prod != null)
                {
                    prod.Quantity += item.Quantity; // زيادة كمية المخزون
                }
            }
            ProductsControl.ProductsList.ResetBindings(); // إشعار شاشة المنتجات بالتحديث

            // 3. تحديث رصيد المورد بـ المتبقي (إن وجد دين)
            if (remaining > 0)
            {
                selectedVendor.Balance += remaining; // زيادة الدين للمورد
                VendorsControl.VendorsList.ResetBindings(); // إشعار شاشة الموردين
            }

            // 4. حفظ الفاتورة في القائمة وتصفير الشاشة
            InvoicesList.Add(invoice);
            MessageBox.Show("تم حفظ الفاتورة وتحديث المخزون ورصيد المورد بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            currentInvoiceItems.Clear();
            txtPaid.Clear();
            CalculateInvoiceTotal();
        }
    }
}