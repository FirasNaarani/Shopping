using ProductsWebProject.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace ProductsWebProject.Interface
{
    public interface IMyPurchasesServices
    {
        IMongoCollection<StoreProducts.Models.MyPurchases> _myPurchases { get; }
        void Create(StoreProducts.Models.MyPurchases myPurchases);

    }
}
