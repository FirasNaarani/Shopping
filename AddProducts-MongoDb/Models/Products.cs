using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AddProducts_MongoDb.Models
{
    public class Products
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]

        public string type { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public string size { get; set; }
        [Required]
        public float price { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string brand { get; set; }
        [Required]
        public string image { get; set; }
    }

}
