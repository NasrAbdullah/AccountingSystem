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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UITheme.ApplyHeader(panel1);
            UITheme.ApplyContent(panel2);
            UITheme.ApplyForm(this);
            UITheme.ApplyDataGridView(dataGridView1);
            

        }
    }
}
