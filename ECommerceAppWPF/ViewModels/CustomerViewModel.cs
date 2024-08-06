using System.Collections.ObjectModel;
using System.Windows.Input;
using ECommerceAppWPF.Model;
using ECommerceAppWPF.Service;

namespace ECommerceAppWPF.ViewModel
{
    public class CustomerViewModel : ViewModelBase
    {
        private readonly CustomerService _customerService;

        public ObservableCollection<Customer> Customers { get; set; }
        public Customer NewCustomer { get; set; }

        public ICommand AddCustomerCommand { get; }

        public CustomerViewModel()
        {
            _customerService = new CustomerService();
            Customers = new ObservableCollection<Customer>(_customerService.GetAllCustomers());
            NewCustomer = new Customer();
            AddCustomerCommand = new RelayCommand(AddCustomer);
        }

        private void AddCustomer(object parameter)
        {
            var addedCustomer = _customerService.AddCustomer(NewCustomer);
            Customers.Add(addedCustomer);
            NewCustomer = new Customer(); // Reset the new customer fields
            OnPropertyChanged(nameof(NewCustomer));
        }
    }
}
