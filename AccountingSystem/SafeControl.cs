using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AccountingSystem.Models;

namespace AccountingSystem
{
    public partial class SafeControl : UserControl
    {
        // قائمة الحركة النقدية
        public static BindingList<CashTransaction> TransactionsList = new BindingList<CashTransaction>();
        private static int nextId = 1;

        public SafeControl()
        {
            InitializeComponent();

            // ربط القائمة بالجدول
            dgvTransactions.DataSource = TransactionsList;

            // اختيار الخيار الافتراضي لنوع الحركة
            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;

            CalculateTotals();
        }

        // زر إضافة حركة مالية (إيداع أو سحب)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("يرجى إدخال مبلغ مالي صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("يرجى كتابة بيان للحركة (سبب الإيداع أو السحب)", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = cmbType.SelectedItem?.ToString() ?? "إيداع";

            // فحص أمان: منع السحب إذا كان رصيد الصندوق غير كافٍ
            decimal currentBalance = GetCurrentBalance();
            if (type == "سحب" && amount > currentBalance)
            {
                MessageBox.Show($"المبلغ المراد سحبه ({amount:N2}) أكبر من الرصيد المتوفر بالصندوق ({currentBalance:N2})!", "خطأ سيولة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CashTransaction t = new CashTransaction
            {
                ID = nextId++,
                Date = DateTime.Now,
                TransactionType = type,
                Amount = amount,
                Description = txtDescription.Text.Trim()
            };

            TransactionsList.Add(t);
            CalculateTotals();
            ClearFields();
        }

        // زر إلغاء/حذف حركة مالية
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow == null || dgvTransactions.CurrentRow.Index < 0) return;

            int selectedId = Convert.ToInt32(dgvTransactions.CurrentRow.Cells["ID"].Value);
            CashTransaction tToDelete = TransactionsList.FirstOrDefault(t => t.ID == selectedId);

            if (tToDelete != null)
            {
                TransactionsList.Remove(tToDelete);
                CalculateTotals();
                ClearFields();
            }
        }

        // حساب الرصيد الحالي للصندوق
        private decimal GetCurrentBalance()
        {
            decimal totalDeposits = TransactionsList.Where(t => t.TransactionType == "Cash In").Sum(t => t.Amount);
            decimal totalWithdrawals = TransactionsList.Where(t => t.TransactionType == "Cash Out").Sum(t => t.Amount);
            return totalDeposits - totalWithdrawals;
        }

        // تحديث إحصائيات الصندوق بالواجهة
        private void CalculateTotals()
        {
            decimal deposits = TransactionsList.Where(t => t.TransactionType == "Cash In").Sum(t => t.Amount);
            decimal withdrawals = TransactionsList.Where(t => t.TransactionType == "Cash Out").Sum(t => t.Amount);
            decimal balance = deposits - withdrawals;

            lblTotalDeposits.Text = deposits.ToString("N2");
            lblTotalWithdrawals.Text = withdrawals.ToString("N2");
            lblCurrentBalance.Text = balance.ToString("N2");
        }

        // حدث الضغط على خلايا الجدول
        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];

            txtID.Text = row.Cells["ID"].Value?.ToString();
            cmbType.SelectedItem = row.Cells["TransactionType"].Value?.ToString();
            txtAmount.Text = row.Cells["Amount"].Value?.ToString();
            txtDescription.Text = row.Cells["Description"].Value?.ToString();
        }

        // البحث السريع في العمليات المالية
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchValue))
            {
                dgvTransactions.DataSource = TransactionsList;
            }
            else
            {
                var filtered = TransactionsList.Where(t => t.Description.ToLower().Contains(searchValue) ||
                                                           t.TransactionType.Contains(searchValue)).ToList();
                dgvTransactions.DataSource = filtered;
            }
        }

        // تنظيف الحقول
        private void ClearFields()
        {
            txtID.Clear();
            txtAmount.Clear();
            txtDescription.Clear();
            dgvTransactions.ClearSelection();
        }
    }
}