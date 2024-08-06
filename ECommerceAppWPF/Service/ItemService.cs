using System.Collections.Generic;
using System.Linq;
using ECommerceAppWPF.Model;

namespace ECommerceAppWPF.Service
{
    public class ItemService
    {
        private readonly List<Item> _items;

        public ItemService()
        {
            _items = new List<Item>
            {
                new Item { ItemId = 1, ItemName = "Laptop", Price = 999.99m },
                new Item { ItemId = 2, ItemName = "Smartphone", Price = 499.99m },
                new Item { ItemId = 3, ItemName = "Tablet", Price = 299.99m }
            };
        }

        public List<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItemById(int itemId)
        {
            return _items.FirstOrDefault(i => i.ItemId == itemId);
        }

        public Item AddItem(Item item)
        {
            item.ItemId = _items.Max(i => i.ItemId) + 1;
            _items.Add(item);
            return item;
        }
    }
}
