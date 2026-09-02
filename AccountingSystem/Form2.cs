using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem
{
    public partial class Form2 : Form
    {
       static int id = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           if(txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("please fill boxes!", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ++id;
                dataGridView1.Rows.Add(id, txtName.Text, txtAddress.Text, cmbbxGender.Text, txtPhone.Text);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.TabIndex = 0;

            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "اسم العميل");
            dataGridView1.Columns.Add("Address", "العنوان");
            dataGridView1.Columns.Add("Gender", "الجنس");
            dataGridView1.Columns.Add("Phone", "التلفون");

            cmbbxGender.Items.Add("Male");
            cmbbxGender.Items.Add("Female");


            cmbbxGender.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                dataGridView1.Rows.RemoveAt(id - 1);
                id--;
            }
            else
            {
                MessageBox.Show("No Clients To Delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Not Ready
            //txtName.Text = dataGridView1
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
