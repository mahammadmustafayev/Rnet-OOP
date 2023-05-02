using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class Product:NameAuditableEnitity
    {
      
        public double Price { get; set; }
        public int Amount { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        #region Constructor
        public Product() { }
        public Product(string name, double price, int amount, int unitsInStock)
        {
            base.Name = name;
            this.Price = price;
            this.Amount = amount;
            this.UnitsInStock = unitsInStock;
        }
        #endregion
        #region Method
        public void Update(string name, double price, int amount, int unitsInStock)
        {
            this.Name = name;
            this.Price = price;
            this.Amount = amount;
            this.UnitsInStock = unitsInStock;
        } 
        #endregion
    }
}
