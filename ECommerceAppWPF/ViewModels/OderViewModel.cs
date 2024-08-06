using System.Collections.ObjectModel;
using ECommerceAppWPF.Model;
using ECommerceAppWPF.Service;

namespace ECommerceAppWPF.ViewModel
{
    public class OrderViewModel : ViewModelBase
    {
        private readonly OrderService _orderService;

        public ObservableCollection<Order> Orders { get; set; }

        public OrderViewModel()
        {
            _orderService = new OrderService();
            Orders = new ObservableCollection<Order>(_orderService.GetAllOrders());
        }

        public string GetOrderStatus(int orderId)
        {
            return _orderService.GetOrderStatus(orderId);
        }

        public string CancelOrder(int orderId)
        {
            return _orderService.CancelOrder(orderId);
        }

        public void CreateOrder(int customerId, List<CartItem> cartItems, int cartId, string orderStatus)
        {
            var order = _orderService.CreateOrder(customerId, cartItems, cartId, orderStatus);
            Orders.Add(order);
        }
    }
}
