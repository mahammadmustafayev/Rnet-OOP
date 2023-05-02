using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class Shipper:NameAuditableEnitity
    {

       
        public string Phone { get; set; }
        public Shipper() { }
        public Shipper(int id, string name, string phone)
        {
            base.Id = id;
            base.Name = name;
            this.Phone = phone;
        }
        public void Update( string name, string phone)
        {
            
            this.Name = name;
            this.Phone = phone;
        }
    }
}
