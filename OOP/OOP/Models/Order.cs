using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Models.Base;

namespace OOP.Models
{
    internal class Order : BaseEntity
    {

        #region Properties
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }
        public int CustomerAdderessId { get; set; }
        public CustomerAddress CustomerAddress { get; set; }
        public bool Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        #endregion
        #region Constructor
        public Order()
        {

        }
        public Order(int customerId, DateTime orderDate, DateTime deliveredDate, int shipperId, int customerAdderessId, bool status)
        {
            this.CustomerId = customerId;
            this.OrderDate = orderDate;
            this.DeliveredDate = deliveredDate;
            this.ShipperId = shipperId;
            this.CustomerAdderessId = customerAdderessId;
            this.Status = status;
        }
        #endregion
        #region Method
        public void Update(int customerId, DateTime orderDate, DateTime deliveredDate, int shipperId, int customerAdderessId, bool status)
        {
            this.CustomerId = customerId;
            this.OrderDate = orderDate;
            this.DeliveredDate = deliveredDate;
            this.ShipperId = shipperId;
            this.CustomerAdderessId = customerAdderessId;
            this.Status = status;
        } 
        #endregion
    }
}
