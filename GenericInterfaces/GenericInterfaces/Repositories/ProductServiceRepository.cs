using GenericInterfaces.Models;
using System;
using System.Collections.Generic;

namespace GenericInterfaces
{

    class ProductServiceRepository : IProductRepository
    {
        public List<Product> ProductList { get; set; }

        public ProductServiceRepository()
        {
            ProductList = new List<Product>();
            //Database connection 
        }

        public void AddProduct(Models.Product newProduct)
        {
            if (!ProductList.Exists(p => p.ProductId == newProduct.ProductId))
            {
                ProductList.Add(newProduct);
                return;
            }

            Console.WriteLine("A product with the ID of {0} already exists. Item has not been added.", newProduct.ProductId);

        }

        public void DeleteProduct(Models.Product newProduct)
        {

        }

        public IEnumerable<Models.Product> GetProducts()
        {
            return ProductList;
        }

        public Product GetProduct(int productId)
        {
            var product = ProductList.Find(p => p.ProductId == productId);

            return product;
        }

        public void UpdateProducts(IEnumerable<Models.Product> updatedProducts)
        {

        }

        public void UpdateProduct(int productId, Models.Product product)
        {

        }
    }
}