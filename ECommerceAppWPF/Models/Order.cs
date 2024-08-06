using System;

namespace ECommerceAppWPF.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int CartId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
