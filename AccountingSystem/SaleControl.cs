using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingSystem.Models;
using AccountingSystem.Classes;

namespace AccountingSystem
{
    public partial class SaleControl : UserControl
    {

        
        

        private Invoice CurrentInvoices;

        List<Invoice> Invoices = new List<Invoice>();


        private void SetupCustomerGrid()
        {
            // ==============================
            // الاتجاه من اليمين إلى اليسار
            // ==============================
            dataGridView1.RightToLeft = RightToLeft.Yes;

            // ==============================
            // شكل الجدول
            // ==============================
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 35);
            dataGridView1.GridColor = Color.FromArgb(60, 60, 75);

            dataGridView1.BorderStyle = BorderStyle.None;

            // إزالة تحديد الصف بالكامل
            dataGridView1.RowHeadersVisible = false;

            // ==============================
            // العناوين
            // ==============================
            dataGridView1.ColumnHeadersHeight = 45;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(40, 40, 55);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // ==============================
            // الصفوف
            // ==============================
            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.DefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 40);

            dataGridView1.DefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // ==============================
            // عند تحديد العميل
            // ==============================
            dataGridView1.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(70, 90, 130);

            dataGridView1.DefaultCellStyle.SelectionForeColor =
                Color.White;

            // ==============================
            // حجم الأعمدة
            // ==============================
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // ==============================
            // منع المستخدم من تغيير الحجم
            // ==============================
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            // ==============================
            // شكل الخطوط
            // ==============================
            dataGridView1.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            // ==============================
            // تحديد صف كامل
            // ==============================
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            // ==============================
            // منع إضافة صف فارغ من الجدول
            // ==============================
            dataGridView1.AllowUserToAddRows = false;
        }
        public SaleControl()
        {
            InitializeComponent();
            SetupCustomerGrid();

         //   comboBox2.DataSource = Product;

            CurrentInvoices = new Invoice();
            
            comboBox2.DisplayMember = "Name";
           // comboBox2.DisplayMember = "Id";
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SaleControl_Load(object sender, EventArgs e)
        {
      
            // panelProductSearch.Height = 55;

           dataGridView1.Columns.Add("ProductName", "المنتج");
           dataGridView1.Columns.Add("Barcode", "الباركود");
           dataGridView1.Columns.Add("Quantity", "الكمية");
           dataGridView1.Columns.Add("Prict", "السعر");
           dataGridView1.Columns.Add("Total", "الاجمالي");

            this.Dock = DockStyle.Fill;

            lblDateValue.Text = CurrentInvoices.Date.ToString();

            lblInvoiceNumberValue.Text = "INV-000" + CurrentInvoices.Id;
            UITheme.ApplyFooter(panel3);

            UITheme.ApplyCard(panel1);

            UITheme.ApplyLabel(label1);
            UITheme.ApplyLabel(label3);

            UITheme.ApplyTextBox(txtProductSearch);

            UITheme.ApplyPanel(panel4);

            UITheme.ApplyTitle(lblTitle);

            UITheme.ApplyFooter(panel2);

            UITheme.ApplyComboBox(comboBox2);
            UITheme.ApplyComboBox(comboBox1);

            UITheme.ApplyButton(btnAdd);
            UITheme.ApplyButton(btnAddInvo);

            UITheme.ApplyTextBox(txtDiscount);
            UITheme.ApplyTextBox(txtQuantity);
        }

        private void dgvInvoiceItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelInvoiceInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblInvoiceNumberValue_Click(object sender, EventArgs e)
        {

        }

        private void lblInvoiceNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblDateValue_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblIDate_Click(object sender, EventArgs e)
        {

        }

        private void panelProductSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void panelInvoiceSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product SelectedProduct = comboBox2.SelectedItem as Product;

            if(SelectedProduct != null)
            {
               lblPrice.Text = SelectedProduct.PurchasePrice.ToString();
            }
        }

        private void btnAddInvo_Click(object sender, EventArgs e)
        {
            Product SelectedProduct = comboBox2.SelectedItem as Product;

            if(SelectedProduct == null)
            {
                MessageBox.Show("choose product first");
                return;
            }
            else
            {
                int Quantity;
                if( int.TryParse(txtQuantity.Text, out Quantity))
                {
                    Quantity =Convert.ToInt32( txtQuantity.Text);
                }
                else
                {
                    Quantity=1;
                }

                InvoiceItem item = new InvoiceItem
                {
                    Product = SelectedProduct,
                    Quantity = Quantity,
                    Price = SelectedProduct.PurchasePrice

                };

                CurrentInvoices.items.Add(item);

                LoadInvoiceItems();
                UpdateTotals();

            }


        }
        private void LoadInvoiceItems()
        {
            dataGridView1.Rows.Clear();

            foreach(InvoiceItem item in CurrentInvoices.items)
            {
                dataGridView1.Rows.Add(item.Product.Name, " ", item.Quantity, item.Price, item.Total);
            }
        }
        private void UpdateTotals()
        {
            lblSubTotal.Text = CurrentInvoices.SubTotal.ToString("0.00;");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal discount;

            if(decimal.TryParse(txtDiscount.Text, out discount))
            {
                CurrentInvoices.Discount = discount;

            }
            else
            {
                CurrentInvoices.Discount = 0;
            }

            lblGrandTotal.Text = CurrentInvoices.GrandTotal.ToString("0.00;");
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if(CurrentInvoices.items.Count == 0)
            {
                MessageBox.Show("لاتوجد منتجات في الفاتورة!");
                return;
            }

            Invoices.Add(CurrentInvoices);

            MessageBox.Show("تم حفظ الفاتورة");
            
            CurrentInvoices = new Invoice();
            CurrentInvoices.Id++;
            lblInvoiceNumberValue.Text = "INV-000" + CurrentInvoices.Id;

            dataGridView1.Rows.Clear();

            lblGrandTotal.Text = "0.00";
            lblSubTotal.Text = "0.00";
            txtDiscount.Clear();
            txtQuantity.Text = "";

        }

        private void txtProductSearch_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach(var item in CurrentInvoices.items)
            {
                if (item.Product.Name.ToLower().Contains(txtProductSearch.Text.ToLower()))
                {
                    dataGridView1.Rows.Add(item.Product.Name, " ", item.Quantity, item.Price, item.Total);

                }

             
            }
        }
    }
}
