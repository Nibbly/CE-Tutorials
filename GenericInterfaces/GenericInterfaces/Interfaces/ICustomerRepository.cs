using System.Collections.Generic;

namespace GenericInterfaces
{

    interface ICustomerRepository
    {
        IEnumerable<Customer> GetPeople();

        Customer GetCustomer(string LastName);

        void AddCustomer(Customer newCustomer);

        void UpdateCustomer(string lastName, Customer Customer);

        void DeleteCustomer(Customer newCustomer);

        void UpdatePeople(IEnumerable<Customer> updatedCustomers);

    }
}