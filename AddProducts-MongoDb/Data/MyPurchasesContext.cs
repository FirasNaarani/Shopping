using AddProducts_MongoDb.Interface;
using AddProducts_MongoDb.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AddProducts_MongoDb.Data
{
    public class MyPurchasesContext : IMyPurchasesServices
    {
        public readonly IMongoDatabase _db;

        public MyPurchasesContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<MyPurchases> _myPuurchases => _db.GetCollection<MyPurchases>("MyPurchases");

        public IEnumerable<MyPurchases> GetAllPurchases()
        {
            return _myPuurchases.Find(a => true).ToList();
        }

        public MyPurchases getProductById(string PurchaseId)
        {
            var PurchaseDetails = _myPuurchases.Find(c => c.Id == PurchaseId).FirstOrDefault();
            return PurchaseDetails;
        }

        public void Update(string _id, MyPurchases myPurchases)
        {
            var filter = Builders<MyPurchases>.Filter.Eq(c => c.Id, _id);
            var update = Builders<MyPurchases>.Update
                .Set("status", myPurchases.status);
            _myPuurchases.UpdateOne(filter, update);
        }
    }
}
