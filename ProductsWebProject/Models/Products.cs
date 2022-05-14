using MongoDB.Bson.Serialization.Attributes;

namespace ProductsWebProject.Models
{
    public class Products
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string title { get; set; }
        public string type { get; set; }

        public string gender { get; set; }

        public string size { get; set; }

        public float price { get; set; }

        public string color { get; set; }

        public string Description { get; set; }

        public string brand { get; set; }
        public string image { get; set; }
    }
}
