using GenericInterfaces.Models;
using System;
using System.Collections.Generic;

namespace GenericInterfaces
{

    class GenericProductServiceRepository : IRepository<Product, int>
    {
        public List<Product> ProductList { get; set; }

        public GenericProductServiceRepository()
        {
            ProductList = new List<Product>();
            //Database connection 
        }

        public void AddItem(Product newItem)
        {
            if (!ProductList.Exists(p => p.ProductId == newItem.ProductId))
            {
                ProductList.Add(newItem);
                return;
            }

            Console.WriteLine("A product with the ID of {0} already exists. Item has not been added.", newItem.ProductId);
        }

        public void DeleteItem(Product newItem)
        {
            
        }

        public Product GetItem(int key)
        {
            var product = ProductList.Find(p => p.ProductId == key);

            return product;
        }

        public IEnumerable<Product> GetItems()
        {
            return ProductList;
        }

        public void UpdateItem(int key, Product item)
        {

        }

        public void UpdateItems(IEnumerable<Product> updatedItems)
        {
            
        }
    }
}