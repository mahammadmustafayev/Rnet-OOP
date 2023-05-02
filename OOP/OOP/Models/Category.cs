using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class Category:NameAuditableEnitity
    {


        #region Properties
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        #endregion
        #region Constructor
        public Category()
        {

        }
        public Category(int id,string name, string description)
        {
            base.Id = id;
            base.Name = name;
            this.Description = description;
        } 
        #endregion
        #region Method
        public void Update(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        } 
        #endregion
    }
}
