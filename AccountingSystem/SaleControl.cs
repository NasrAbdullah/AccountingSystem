using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem
{
    public partial class SaleControl : UserControl
    {
        public SaleControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SaleControl_Load(object sender, EventArgs e)
        {
            panelInvoiceInfo.Height = 140;
            panelHeader.Height = 100;
            // panelProductSearch.Height = 55;

            dgvInvoiceItems.Columns.Add("ProductId", "رقم المنتج");
            dgvInvoiceItems.Columns.Add("ProductName", "المنتج");
            dgvInvoiceItems.Columns.Add("Barcode", "الباركود");
            dgvInvoiceItems.Columns.Add("Quantity", "الكمية");
            dgvInvoiceItems.Columns.Add("Prict", "السعر");
            dgvInvoiceItems.Columns.Add("Discount", "الخصم");
            dgvInvoiceItems.Columns.Add("Total", "الاجمالي");
        }
    }
}
