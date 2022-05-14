using ProductsWebProject.Interface;
using ProductsWebProject.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using MongoDB.Driver;

namespace ProductsWebProject.Data
{
    public class ProductsContext : IProductServices
    {
        public readonly IMongoDatabase _db;

        public ProductsContext(IOptions<Settings> options)
        {
            var client=new MongoClient(options.Value.ConnectionString);
            _db= client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Products> _products => _db.GetCollection<Products>("myFirstDatabase");

        public IEnumerable<Products> GetAllProducts()
        {
            return _products.Find(a=>true).ToList();
        }
       
        public Products getProductById(string productId)
        {
            var productDetails = _products.Find(c => c.Id == productId).FirstOrDefault();
            return productDetails;

        }
        public IEnumerable<Products> Search(string name)
        {
            return _products.Find(a => a.title.ToLower().Contains(name.ToLower()) == true).ToList();
        }
        public IEnumerable<Products> SearchColor(string color)
        {
            return _products.Find(a => a.color.ToLower().Contains(color.ToLower()) == true).ToList();
        }
    }
}



