using System.Collections.Generic;

namespace GenericInterfaces
{

    class CustomerServiceRepository : ICustomerRepository
    {
        public CustomerServiceRepository()
        {
            //Database connection 
        }

        public void AddCustomer(Customer newCustomer)
        {

        }

        public void DeleteCustomer(Customer newCustomer)
        {

        }

        public IEnumerable<Customer> GetPeople()
        {
            var customers = new List<Customer>();

            return customers;
        }

        public Customer GetCustomer(string LastName)
        {
            var customer = new Customer();

            return customer;
        }

        public void UpdatePeople(IEnumerable<Customer> updatedPeople)
        {

        }

        public void UpdateCustomer(string lastName, Customer Customer)
        {

        }
    }
}