using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AccountingSystem.Models;
using AccountingSystem.Classes;

namespace AccountingSystem
{
    public partial class VendorsControl : UserControl
    {
        // قائمة الموردين التزامنية
        public static BindingList<Vendor> VendorsList = new BindingList<Vendor>();
        private static int nextId = 1;

        public VendorsControl()
        {
            InitializeComponent();

            // ربط القائمة بالشبكة
            dgvVendors.DataSource = VendorsList;
        }

        // زر إضافة مورد
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم المورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vendor v = new Vendor
            {
                ID = nextId++,
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Balance = decimal.TryParse(txtBalance.Text, out decimal b) ? b : 0
            };

            VendorsList.Add(v);
            ClearFields();
        }

        // زر تعديل مورد
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVendors.CurrentRow == null || dgvVendors.CurrentRow.Index < 0) return;

            int selectedId = Convert.ToInt32(dgvVendors.CurrentRow.Cells["ID"].Value);
            Vendor vendorToEdit = VendorsList.FirstOrDefault(v => v.ID == selectedId);

            if (vendorToEdit != null)
            {
                vendorToEdit.Name = txtName.Text.Trim();
                vendorToEdit.Phone = txtPhone.Text.Trim();
                vendorToEdit.Address = txtAddress.Text.Trim();
                vendorToEdit.Balance = decimal.TryParse(txtBalance.Text, out decimal b) ? b : 0;

                VendorsList.ResetBindings();
                ClearFields();
            }
        }

        // زر حذف مورد
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVendors.CurrentRow == null || dgvVendors.CurrentRow.Index < 0) return;

            int selectedId = Convert.ToInt32(dgvVendors.CurrentRow.Cells["ID"].Value);
            Vendor vendorToDelete = VendorsList.FirstOrDefault(v => v.ID == selectedId);

            if (vendorToDelete != null)
            {
                VendorsList.Remove(vendorToDelete);
                ClearFields();
            }
        }

        // حدث الضغط على خليه بالجدول
        private void dgvVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvVendors.Rows[e.RowIndex];

            txtID.Text = row.Cells["ID"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtBalance.Text = row.Cells["Balance"].Value?.ToString();
        }

        // البحث عن مورد بالاسم أو رقم الهاتف
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchValue))
            {
                dgvVendors.DataSource = VendorsList;
            }
            else
            {
                var filtered = VendorsList.Where(v => v.Name.ToLower().Contains(searchValue) ||
                                                      v.Phone.Contains(searchValue)).ToList();
                dgvVendors.DataSource = filtered;
            }
        }

        // تنظيف الحقول
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtBalance.Clear();
            dgvVendors.ClearSelection();
        }

        private void VendorsControl_Load(object sender, EventArgs e)
        {
            UITheme.ApplyCard(panel1);
            UITheme.ApplyHeader(panel2);
            UITheme.ApplyDataGridView(dgvVendors);

            UITheme.ApplyTextBox(txtID);
            UITheme.ApplyTextBox(txtAddress);
            UITheme.ApplyTextBox(txtBalance);
            UITheme.ApplyTextBox(txtName);
            UITheme.ApplyTextBox(txtPhone);
            UITheme.ApplyTextBox(txtSearch);

            UITheme.ApplyButton(btnAdd);
            UITheme.ApplyDangerButton(btnDelete);
            UITheme.ApplySecondaryButton(btnEdit);



        }
    }
}