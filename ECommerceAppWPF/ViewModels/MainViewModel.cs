namespace ECommerceAppWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public CustomerViewModel CustomerViewModel { get; set; }
        public ItemViewModel ItemViewModel { get; set; }
        public ShoppingCartViewModel ShoppingCartViewModel { get; set; }
        public OrderViewModel OrderViewModel { get; set; }

        public MainViewModel()
        {
            CustomerViewModel = new CustomerViewModel();
            ItemViewModel = new ItemViewModel();
            ShoppingCartViewModel = new ShoppingCartViewModel();
            OrderViewModel = new OrderViewModel();
        }
    }
}
