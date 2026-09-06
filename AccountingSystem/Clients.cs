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

namespace AccountingSystem
{
    public partial class Clients : UserControl
    {
        List<Customer> Customers = new List<Customer>();

        int selectedId = -1;
        int Client_id = 0;

        public Clients()
        {
            InitializeComponent();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // This columns of table 

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "اسم العميل");
            dataGridView1.Columns.Add("Address", "العنوان");
            dataGridView1.Columns.Add("Phone", "التلفون");
        }
        private bool checkExist(string Phone)
        {
            foreach(Customer C in Customers)
            {
                if(C.Phone == Phone)
                {
                    MessageBox.Show("clients aleardy exists!");
                    return true;
                }
            }

            return false;
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPhone.MaxLength = 9;
        }
        private void LoadCustomers()
        {
            dataGridView1.Rows.Clear();

            foreach (Customer C in Customers)
            {
                dataGridView1.Rows.Add(C.Id, C.Name, C.Address, C.Phone);
            }

                 //dataGridView1.DataSource = C;
        }
        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
          
        }

        private void BtnAddCleint_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("please enter client name?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("please enter client address?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("please enter client phone?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                if (checkExist(txtPhone.Text))
                    return;

            }
            Client_id++;
            customer.Id = Client_id;

            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;

            txtName.TabIndex = 0;

            Customers.Add(customer);
            LoadCustomers();

            MessageBox.Show("Clients added successfully!");
            Reset();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("choose clients first!");
                return;
            }

            Customer customer = Customers.First(c => c.Id == selectedId);

            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;

            LoadCustomers();

            MessageBox.Show("updated successfully!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (selectedId == -1)
            {
                MessageBox.Show("No Clients To Delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer customer = Customers.First(c => c.Id == selectedId);

            Customers.Remove(customer);
            Client_id--;
            LoadCustomers();

            selectedId = -1;

            Reset();

            MessageBox.Show("Delete it successfully!");

        }
        private void Reset()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string SearchTxt = txtSearch.Text.ToLower();

            dataGridView1.Rows.Clear();

            foreach(Customer customer in Customers)
            {
                if(customer.Name.ToLower().Contains(SearchTxt) || customer.Phone.Contains(SearchTxt))
                {
                    dataGridView1.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone);

                }
            }
        }
    }
}
