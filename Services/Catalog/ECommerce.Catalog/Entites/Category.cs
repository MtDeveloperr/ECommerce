using MongoDB.Bson.Serialization.Attributes;

namespace ECommerce.Catalog.Entites
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
