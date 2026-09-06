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
    public partial class Login : Form
    {
        string username = User.Username;
        string password = User.Password;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            CreateAcc frm = new CreateAcc();

            frm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Enter Username/Password");
                return;
            }

            if(txtName.Text == User.Username)
            {
                if(txtPassword.Text == User.Password)
                {
                    MainForm frm = new MainForm();

                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("invalid password!");
                }
            }
            else
            {
                MessageBox.Show("invalid username");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
