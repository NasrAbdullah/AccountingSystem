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
using AccountingSystem.Properties;
using AccountingSystem.Classes;

namespace AccountingSystem
{
    public partial class CustomersControl : UserControl
    {
        List<Customer> Customers = new List<Customer>();

        int selectedId = -1;


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
        public CustomersControl()
        { 
            InitializeComponent();
            SetupCustomerGrid();
            this.BackColor = Color.FromArgb(20, 20, 32);

            btnAdd.BackColor = Color.FromArgb(90, 80, 180);
            btnAdd.ForeColor = Color.White;

            btnEdit.BackColor = Color.FromArgb(70, 110, 180);
            btnEdit.ForeColor = Color.White;

            btnDelete.BackColor = Color.FromArgb(170, 60, 80);
            btnDelete.ForeColor = Color.White;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // This columns of table 

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "اسم العميل");
            dataGridView1.Columns.Add("Address", "العنوان");
            dataGridView1.Columns.Add("Phone", "التلفون");
            dataGridView1.Columns.Add("email", "الايميل");
            dataGridView1.Columns.Add("notes", "ملاحظة");

            UITheme.ApplyCard(panel1);
            UITheme.ApplyFooter(panel3);
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadCustomers()
        {
            dataGridView1.Rows.Clear();

            foreach (Customer C in Customers)
            {
                dataGridView1.Rows.Add(C.Id, C.Name, C.Address, C.Phone, C.Email, C.Notes);
            }

                 //dataGridView1.DataSource = C;
        }

        private void btnAddClints_Click(object sender, EventArgs e)
        {
           
            AddClient frm = new AddClient(this);

            
            frm.ShowDialog();

            LoadCustomers();

         
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            LoadCustomers();
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string SearchTxt = txtSearch.Text.ToLower();

            dataGridView1.Rows.Clear();

            foreach (Customer customer in Customers)
            {
                if (customer.Name.ToLower().Contains(SearchTxt) || customer.Phone.Contains(SearchTxt))
                {
                    dataGridView1.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, customer.Email, customer.Notes);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("choose clients you want to edit on it!");
                return;

            }

             selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            Customer customer = Customers.First(C => C.Id == selectedId);
            AddClient frm = new AddClient(this, customer);    

            frm.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("choose clients you want to delete on him!");
                return;

            }
            try
            {

          
                selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                Customer customer = Customers.First(C => C.Id == selectedId);

                Customers.Remove(customer);

                LoadCustomers();

                selectedId = -1;

                MessageBox.Show("Delete it successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is error!");
            }
        }
    }
}
