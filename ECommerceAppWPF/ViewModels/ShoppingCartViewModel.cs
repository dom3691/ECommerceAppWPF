using System.Collections.ObjectModel;
using ECommerceAppWPF.Model;
using ECommerceAppWPF.Service;

namespace ECommerceAppWPF.ViewModel
{
    public class ShoppingCartViewModel : ViewModelBase
    {
        private readonly ShoppingCartService _shoppingCartService;

        public ObservableCollection<CartItem> CartItems { get; set; }

        public ShoppingCartViewModel()
        {
            _shoppingCartService = new ShoppingCartService();
            CartItems = new ObservableCollection<CartItem>(_shoppingCartService.GetCartItems(1)); // Example cartId
        }

        public void AddItemToCart(int itemId, int quantity)
        {
            CartItems = new ObservableCollection<CartItem>(_shoppingCartService.AddItemToCart(1, itemId, quantity));
            OnPropertyChanged(nameof(CartItems));
        }

        public void RemoveItemFromCart(int itemId)
        {
            CartItems = new ObservableCollection<CartItem>(_shoppingCartService.RemoveItemFromCart(1, itemId));
            OnPropertyChanged(nameof(CartItems));
        }
    }
}
