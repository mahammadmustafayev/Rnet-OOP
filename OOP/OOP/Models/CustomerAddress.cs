using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class CustomerAddress : TitleAuditableEnitity
    {


        #region Properties
        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int No { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        
        #endregion
        #region Constructor
        public CustomerAddress()
        {

        }
        public CustomerAddress(string title, string country, string city, string town, string street, string building, int no)
        {
            base.Title = title;
            this.Country = country;
            this.City = city;
            this.Town = town;
            this.Street = street;
            this.Building = building;
            this.No = no;
        }
        #endregion
        #region Method
        public void Update(string title, string country, string city, string town, string street, string building, int no)
        {
            this.Title = title;
            this.Country = country;
            this.City = city;
            this.Town = town;
            this.Street = street;
            this.Building = building;
            this.No = no;
        } 
        #endregion
    }
}
