using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountingSystem.Classes;
namespace AccountingSystem
{
    public partial class CreateAcc : Form
    {

        public CreateAcc()
        {
            InitializeComponent();
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtname.Text != "")
                {
                    if(txtPassword.Text != "" && txtPassword.Text == txtPassword1.Text)
                    {
                        if (txtPassword.TextLength < 6)
                        {
                            MessageBox.Show("your password less than 6!");
                            return;
                        }

                        User.Username = txtname.Text;
                        User.Password = txtPassword.Text;

                        MessageBox.Show("Account Created Successfully!", "Ok", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password?");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Your Name? ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error, there are problems!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.MaxLength = 10;
            
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {
            UITheme.ApplyContent(panel1);
            UITheme.ApplyCard(panel2);

            UITheme.ApplyTextBox(txtname);
            UITheme.ApplyTextBox(txtPassword);
            UITheme.ApplyTextBox(txtPassword1);

            UITheme.ApplyButton(btnCreate);
            UITheme.ApplySecondaryButton(btnClose);

            UITheme.ApplyLabel(label1);
            UITheme.ApplyLabel(label2);
            UITheme.ApplyLabel(label3);

    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
