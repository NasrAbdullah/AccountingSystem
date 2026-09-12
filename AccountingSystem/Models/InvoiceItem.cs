using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Models
{
    public class InvoiceItem
    {
        // here we will make class from oday here
        public Product Product { get; set; } 

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total {
            get { return Quantity * Price; } 
        } 


    }
}
