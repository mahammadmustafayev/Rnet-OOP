using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class CustomerPhone:BaseIdTitle
    {
        
        
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }
}
