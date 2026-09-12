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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // panelSidebar.Width = 205;
          

            panelHeader.Width = 60;
          //  panelHeader.BackColor = Color.Purple;

           // panelContent.BackColor = Color.Green;

            panelLogo.Height = 80;
            // panelLogo.BackColor = Color.Gray;

            UITheme.ApplySidebar(panelSidebar);
            UITheme.ApplyCard(panelLogo);
            UITheme.ApplyCard(panelُExpenses);
            UITheme.ApplyCard(panelPurchases);
            UITheme.ApplyCard(panelProfit);
            UITheme.ApplyCard(panelSales);

            UITheme.ApplyHeader(panelHeader);
            panelHeader.ForeColor = Color.White;

            UITheme.ApplyForm(this);

            UITheme.ApplyContent(panelContent);

            UITheme.ApplyButton(btnCash);
            UITheme.ApplyButton(btnCustomers);
            UITheme.ApplyButton(btnDashboard);
            UITheme.ApplyButton(btnVendors);
            UITheme.ApplyButton(btnGoOut);
            UITheme.ApplyButton(btnProducts);
            UITheme.ApplyButton(btnreprts);
            UITheme.ApplyButton(btnSales);
            UITheme.ApplyButton(btnSettings);
            UITheme.ApplyButton(btnPurchases);

            


           

           
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
            //  OpenControl(new MainForm());
            
         
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            OpenControl(new CustomersControl());
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            OpenControl(new SaleControl());
        }

        private void Btnexpenses_Click(object sender, EventArgs e)
        {
            OpenControl(new VendorsControl());
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
            OpenControl(new PurchasesControl());
        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            OpenControl(new SafeControl());
        }

        private void Btnreprts_Click(object sender, EventArgs e)
        {

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenControl(new ProductsControl());
        }

        private void BtnGoOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            
        }
    }
}
