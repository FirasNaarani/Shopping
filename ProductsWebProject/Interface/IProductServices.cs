using ProductsWebProject.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ProductsWebProject.Interface
{
    public interface IProductServices
    {
        IMongoCollection<Products> _products { get; }
        IEnumerable<Products> GetAllProducts();
        IEnumerable<Products> Search(string name);

        IEnumerable<Products> SearchColor(string name);

        Products getProductById(string productId);
        
    }
}
