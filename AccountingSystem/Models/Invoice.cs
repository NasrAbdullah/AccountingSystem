using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Discount { get; set; }

        public  List<InvoiceItem> items { get; set; }


        public Invoice()
        {
        
            Date = DateTime.Now;

            items = new List<InvoiceItem>();


        }
        public  decimal SubTotal
        {
            get{
                return items.Sum(x => x.Total);
            }
        }
        public decimal GrandTotal
        {
            get 
            {
                return SubTotal - Discount;
            }
        }
    }
}
