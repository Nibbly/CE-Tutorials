using System;
using System.Collections.Generic;

namespace GenericInterfaces
{

    class GenericCustomerServiceRepository : IRepository<Customer, string>
    {
        public void AddItem(Customer newItem)
        {
            
        }

        public void DeleteItem(Customer newItem)
        {
            
        }

        public Customer GetItem(string key)
        {
            var Customer = new Customer();

            return Customer;
        }

        public IEnumerable<Customer> GetItems()
        {
            var customers = new List<Customer>();

            return customers;
        }

        public void UpdateItem(string key, Customer item)
        {
            throw new NotImplementedException();
        }

        public void UpdateItems(IEnumerable<Customer> updatedItems)
        {
            
        }
    }
}