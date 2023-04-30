using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class Order : BaseEntity
    {
        
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public int ShipperId { get; set; }
        public int CustomerAdderessId { get; set; }
        public bool Status { get; set; }

    }
}
