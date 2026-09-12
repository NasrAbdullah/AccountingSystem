using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AccountingSystem.Models
{
    public class PurchaseInvoice
    {
        public int ID { get; set; }
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public DateTime Date { get; set; }
        public List<PurchaseItem> Items { get; set; } = new List<PurchaseItem>();
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal RemainingAmount => TotalAmount - PaidAmount; // المتبقي ديناً على المحل
    }
}
