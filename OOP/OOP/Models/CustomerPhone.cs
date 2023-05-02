using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class CustomerPhone:TitleAuditableEnitity
    {


        #region Properties
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        #endregion
        #region Constructor
        public CustomerPhone()
        {

        }
        public CustomerPhone(string title, string areaCode, string number)
        {
            base.Title = title;
            this.AreaCode = areaCode;
            this.Number = number;
        }
        #endregion
        #region Method
        public void Update(string title, string areaCode, string number)
        {
            this.Title = title;
            this.AreaCode = areaCode;
            this.Number = number;
        } 
        #endregion
    }
}
