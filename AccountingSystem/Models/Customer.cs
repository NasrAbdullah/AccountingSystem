using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Models
{
    public class Customer
    {
         public int Count { get; set; } = 0;
        public string Name { get; set; }    ="";
        public string Phone { get; set; }   ="";
        public string Address { get; set; } ="";
       
        public Customer()
        {
           // Count++;
        }
    }
    
}
