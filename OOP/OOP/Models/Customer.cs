using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class Customer : BaseEntity
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; }
        public List<CustomerMail> CustomerMail { get; set; }
        public List<CustomerPhone> CustomerPhones { get; set; }
        public List<Order> Orders { get; set; }
        #endregion
        #region Constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName, string lastName)
        {
            base.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        #endregion
        #region Method
        public void Update(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        } 
        #endregion
    }
}
