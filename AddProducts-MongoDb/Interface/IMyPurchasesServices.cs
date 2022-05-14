using AddProducts_MongoDb.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AddProducts_MongoDb.Interface
{
    public interface IMyPurchasesServices
    {
        IMongoCollection<MyPurchases> _myPuurchases { get; }
        IEnumerable<MyPurchases> GetAllPurchases();
        MyPurchases getProductById(string PurchaseId);
        void Update(string _id, MyPurchases myPurchases);
    }
}
