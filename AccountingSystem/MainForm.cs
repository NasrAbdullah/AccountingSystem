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

        private void BtnSales_Click(object sender, EventArgs e)
        {
            OpenControl(new SaleControl());
        }

        private void Btnexpenses_Click(object sender, EventArgs e)
        {
           
        }

        private void PanelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PanelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FlowMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {

        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCash_Click(object sender, EventArgs e)
        {

        }

        private void Btnreprts_Click(object sender, EventArgs e)
        {

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {

        }

        private void BtnGoOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
