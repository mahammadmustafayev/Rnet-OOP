using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class Product:BaseIdName
    {
        
        public double Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }
    }
}
