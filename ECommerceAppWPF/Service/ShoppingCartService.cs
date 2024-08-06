using System.Collections.Generic;
using System.Linq;
using ECommerceAppWPF.Model;

namespace ECommerceAppWPF.Service
{
    public class ShoppingCartService
    {
        private readonly List<CartItem> _cartItems;

        public ShoppingCartService()
        {
            _cartItems = new List<CartItem>
            {
                new CartItem { CartItemId = 1, CartId = 1, ItemId = 1, Quantity = 2, Item = new Item { ItemId = 1, ItemName = "Laptop", Price = 999.99m } }
            };
        }

        public List<CartItem> GetCartItems(int cartId)
        {
            return _cartItems.Where(ci => ci.CartId == cartId).ToList();
        }

        public List<CartItem> AddItemToCart(int cartId, int itemId, int quantity)
        {
            var cartItem = _cartItems.FirstOrDefault(ci => ci.CartId == cartId && ci.ItemId == itemId);

            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                var item = new ItemService().GetItemById(itemId);
                _cartItems.Add(new CartItem { CartId = cartId, ItemId = itemId, Quantity = quantity, Item = item });
            }

            return GetCartItems(cartId);
        }

        public List<CartItem> RemoveItemFromCart(int cartId, int itemId)
        {
            var cartItem = _cartItems.FirstOrDefault(ci => ci.CartId == cartId && ci.ItemId == itemId);
            if (cartItem != null)
            {
                _cartItems.Remove(cartItem);
            }
            return GetCartItems(cartId);
        }
    }
}
