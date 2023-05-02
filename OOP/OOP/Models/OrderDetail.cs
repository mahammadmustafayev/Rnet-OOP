using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class OrderDetail:BaseEntity
    {

        #region Properties
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int Discount { get; set; }
        
        #endregion
        #region Constructor
        public OrderDetail()
        {

        }
        public OrderDetail(int orderId, int productId, double price, int count, int discount)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
            this.Count = count;
            this.Discount = discount;
        }
        #endregion
        #region Method
        public void Update(int orderId, int productId, double price, int count, int discount)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.Price = price;
            this.Count = count;
            this.Discount = discount;
        } 
        #endregion
    }
}
