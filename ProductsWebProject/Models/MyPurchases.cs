using MongoDB.Bson.Serialization.Attributes;
using ProductsWebProject.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreProducts.Models
{
    public class MyPurchases
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string ClientAddress { get; set; }
        [Required]
        public string VisaNumber { get; set; }

        public float amount { get; set; }

        public List<Item> products { get; set; }
        public string status { get; set; }

        public string IdClient { get; set; }



    }
}
