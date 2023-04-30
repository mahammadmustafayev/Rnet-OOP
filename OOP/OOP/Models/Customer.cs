using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class Customer : BaseEntity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
