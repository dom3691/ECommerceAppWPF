using System.Collections.ObjectModel;
using ECommerceAppWPF.Model;
using ECommerceAppWPF.Service;

namespace ECommerceAppWPF.ViewModel
{
    public class ItemViewModel : ViewModelBase
    {
        private readonly ItemService _itemService;

        public ObservableCollection<Item> Items { get; set; }

        public ItemViewModel()
        {
            _itemService = new ItemService();
            Items = new ObservableCollection<Item>(_itemService.GetAllItems());
        }
    }
}
