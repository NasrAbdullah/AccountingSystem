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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panelSidebar.Width = 205;
          

            panelHeader.Width = 60;
          //  panelHeader.BackColor = Color.Purple;

           // panelContent.BackColor = Color.Green;

            panelLogo.Height = 80;
           // panelLogo.BackColor = Color.Gray;

            pictureBox1.Image = Image.FromFile("D:/PictureToDesign/random picture/shop.jpg");

           
        }
        private void OpenControl(UserControl Control)
        {
            // clear to panel 
            panelContent.Controls.Clear();
            Control.Dock = DockStyle.Fill;

            // add new user control
            panelContent.Controls.Add(Control);
            Control.BringToFront();

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenControl(new DashBoardControl());
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            OpenControl(new Clients());
        }
    }
}
