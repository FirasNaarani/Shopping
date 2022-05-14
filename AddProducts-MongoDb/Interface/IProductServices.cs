using AddProducts_MongoDb.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AddProducts_MongoDb.Interface
{
    public interface IProductServices
    {
        IMongoCollection<Products> _products { get; }
        IEnumerable<Products> GetAllProducts();
        Products getProductById(string productId);
        void Create(Products product);
        void Update(string _id,Products product);
        void Delete(string _id);
    }
}
