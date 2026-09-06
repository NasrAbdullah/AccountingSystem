using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingSystem.Models
{
    public class Customer
    {
        static public int Count { get; set; } = 0;
        public int Id { get; set; } = -1;
        public string Name { get; set; }    ="";
        public string Phone { get; set; }   ="";
        public string Address { get; set; } ="";
       
        public Customer()
        {
           Count++;
        }
    }
    
}
