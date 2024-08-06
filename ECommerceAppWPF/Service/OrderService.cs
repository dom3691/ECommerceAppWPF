using System.Collections.Generic;
using System.Linq;
using ECommerceAppWPF.Model;

namespace ECommerceAppWPF.Service
{
    public class OrderService
    {
        private readonly List<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, CartId = 1, OrderStatus = "Not Shipped", OrderDate = DateTime.UtcNow, OrderTotal = 1999.98m }
            };
        }

        public List<Order> GetAllOrders()
        {
            return _orders;
        }

        public string GetOrderStatus(int orderId)
        {
            var order = _orders.FirstOrDefault(o => o.OrderId == orderId);
            return order?.OrderStatus ?? "Order Not Found";
        }

        public string CancelOrder(int orderId)
        {
            var order = _orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null && order.OrderStatus == "Not Shipped")
            {
                order.OrderStatus = "Cancelled";
                return "Order Cancelled";
            }
            return "Cannot Cancel Order";
        }

        public Order CreateOrder(int customerId, List<CartItem> cartItems, int cartId, string orderStatus)
        {
            var orderTotal = cartItems.Sum(item => item.Quantity * item.Item.Price);

            var order = new Order
            {
                CustomerId = customerId,
                CartId = cartId,
                OrderStatus = orderStatus,
                OrderDate = DateTime.UtcNow,
                OrderTotal = orderTotal
            };

            order.OrderId = _orders.Max(o => o.OrderId) + 1;
            _orders.Add(order);

            return order;
        }
    }
}
