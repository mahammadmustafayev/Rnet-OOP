using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class OrderDetail:BaseEntity
    {
        
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }
    }
}
