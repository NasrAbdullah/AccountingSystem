using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Models
{
    public class CashTransaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; } // "إيداع" أو "سحب"
        public decimal Amount { get; set; }
        public string Description { get; set; } // البيان/السبب (مثلاً: إيجار المحل، رأس مال، فاتورة...)
    }
}
