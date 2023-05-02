using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class CustomerMail : TitleAuditableEnitity
    {

        #region Properties
        public string Mail { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } 
        #endregion
        #region Constructor
        public CustomerMail()
        {

        }
        public CustomerMail(string title, string mail)
        {

            base.Title = title;
            this.Mail = mail;
        }
        #endregion
        #region Method
        public void Update(string title, string mail)
        {

            this.Title = title;
            this.Mail = mail;
        } 
        #endregion
    }
}
