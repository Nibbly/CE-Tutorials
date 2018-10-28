using GenericInterfaces.Models;
using System;

namespace GenericInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {   
            // This is a comment from the test branch, which should be merged into master by now


            Product p = new Product() { ProductId = 1, ProductName = "Ball" };
            Product p2 = new Product() { ProductId = 1, ProductName = "Goal" };
            IRepository<Product, int> prep = new GenericProductServiceRepository();
            prep.AddItem(p);
            prep.AddItem(p2);

            IRepository<Customer, string> custRep = new GenericCustomerServiceRepository();


            var pnew = prep.GetItems();

            foreach(var prod in pnew)
            {
                Console.WriteLine("{0}", prod.ProductName);
            }
            //Console.WriteLine(pnew.ProductId + " " + pnew.ProductName);

            Console.ReadKey();
        }
    }
}
