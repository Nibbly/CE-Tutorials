using GenericInterfaces.Models;
using System.Collections.Generic;

namespace GenericInterfaces
{

    interface IProductRepository
    {
        IEnumerable<Models.Product> GetProducts();

        Product GetProduct(int productId);

        void AddProduct(Models.Product newProduct);

        void UpdateProduct(int productId, Models.Product Product);

        void DeleteProduct(Models.Product newProduct);

        void UpdateProducts(IEnumerable<Models.Product> updatedProducts);

    }
}