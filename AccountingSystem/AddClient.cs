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
using AccountingSystem;
using AccountingSystem.Classes;

namespace AccountingSystem
{
    public partial class AddClient : Form
    {

       Customer customer;
       private CustomersControl userControl;
       
        public AddClient()
        {
           
            InitializeComponent();

         //   this.BackColor = Color.FromArgb(18, 22, 32);
        }
         public AddClient(CustomersControl userControl)
        {
            
            InitializeComponent();
            this.userControl = userControl;
        }
          public AddClient(CustomersControl userControl, Customer customer)
        {
            
            InitializeComponent();
            this.userControl = userControl;
            this.customer = customer;

            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtNotes.Text = customer.Notes;

            
        }
       

        private void AddClient_Load(object sender, EventArgs e)
        {
            UITheme.ApplyButton(btnAddCleint);
            UITheme.ApplySecondaryButton(btnReset);

            UITheme.ApplyCard(panel1);

        }

        private void Reset()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNotes.Clear();


        }

        private void btnAddCleint_Click_1(object sender, EventArgs e)
        {
            if (customer == null)
            {



                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("please enter client name?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                   
                }
                 if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("please enter client address?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("please enter client phone?", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                customer = new Customer();

                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Notes = txtNotes.Text;
                customer.Email = txtEmail.Text;


                txtName.TabIndex = 0;

                userControl.AddCustomer(customer);

                MessageBox.Show("Clients added successfully!");

                Reset();
                this.Close();

            }
            else
            {

                customer.Name = txtName.Text;
                customer.Address = txtAddress.Text;
                customer.Phone = txtPhone.Text;
                customer.Notes = txtNotes.Text;
                customer.Email = txtEmail.Text;

                userControl.LoadCustomers();

                MessageBox.Show("Clients added successfully!");

                Reset();
                this.Close();
            }

        }
       

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
