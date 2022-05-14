using AddProducts_MongoDb.Interface;
using AddProducts_MongoDb.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AddProducts_MongoDb.Data
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
        public void Create(Products product)
        {
           _products.InsertOne(product);
        }

        public void Delete(string _id)
        {
            var filter = Builders<Products>.Filter.Eq(c => c.Id, _id);
            _products.DeleteOne(filter);
        }

        public void Update(string Id, Products product)
        {
            var filter = Builders<Products>.Filter.Eq(c => c.Id, Id);
            var update = Builders<Products>.Update
                .Set("Id", product.Id)
                .Set("title", product.title)
                .Set("type", product.type)
                .Set("gender", product.gender)
                .Set("size", product.size)
                .Set("price", product.price)
                .Set("color", product.color)
                .Set("Description", product.Description)
                .Set("brand", product.brand)
                .Set("image", product.image);
            _products.UpdateOne(filter, update);
        }

        public Products getProductById(string productId)
        {
            var productDetails = _products.Find(c => c.Id == productId).FirstOrDefault();
            return productDetails;

        }
    }
}



