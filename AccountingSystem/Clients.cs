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
        private void Button1_Click(object sender, EventArgs e)
        {
            // create object 
            Customer customer = new Customer();
            Customer.Count++;
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;

            txtName.TabIndex = 0;

            if (txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("please fill boxes!", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (checkExist(txtPhone.Text))
                    return;
               

                MessageBox.Show("Clients added successfully!");
            }

           
            Customers.Add(customer);
            LoadCustomers();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            if(selectedId == -1)
            {
                MessageBox.Show("chooose clients first!");
                return;
            }

            Customer customer = Customers.First(c => Customers.Count == selectedId);

            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Phone = txtPhone.Text;

            LoadCustomers();
            MessageBox.Show("updated successfully!");

            foreach(Customer C in Customers)
            {
                if(Customers.Count == selectedId)
                {
                    MessageBox.Show(selectedId.ToString());

                }
            }

            //txtName.Text = customer.Name;
            //txtPhone.Text = customer.Phone;
            //txtAddress.Text = customer.Address;

            //customer.Name = txtName.Text;
            //customer.Address = txtAddress.Text;
            //customer.Phone = txtPhone.Text;

        }

        private void Button3_Click(object sender, EventArgs e)
        {


            if (Customer.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(Customer.Count - 1);
                Customer.Count--;
            }
            else
            {
                MessageBox.Show("No Clients To Delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
                dataGridView1.Rows.Add(Customer.Count, C.Name, C.Address, C.Phone);
            }
        }
        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                  selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
          
        }
    }
}
