using ProductsWebProject.Interface;
using StoreProducts.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using MongoDB.Driver;

namespace ProductsWebProject.Data
{
    public class MyPurchasesContext : IMyPurchasesServices
    {
        public readonly IMongoDatabase _db;

        public MyPurchasesContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<MyPurchases> _myPurchases => _db.GetCollection<MyPurchases>("MyPurchases");

        public void Create(MyPurchases myPurchases)
        {
            _myPurchases.InsertOne(myPurchases);
        }
    }
}



