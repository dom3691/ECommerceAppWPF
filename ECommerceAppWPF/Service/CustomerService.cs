using System.Collections.Generic;
using System.Linq;
using ECommerceAppWPF.Model;

namespace ECommerceAppWPF.Service
{
    public class CustomerService
    {
        private readonly List<Customer> _customers;

        public CustomerService()
        {
            _customers = new List<Customer>
            {
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "123-456-7890" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "098-765-4321" }
            };
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.CustomerId = _customers.Max(c => c.CustomerId) + 1;
            _customers.Add(customer);
            return customer;
        }
    }
}
