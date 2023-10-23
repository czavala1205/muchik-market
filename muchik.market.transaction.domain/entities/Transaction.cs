using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace muchik.market.transaction.domain.entities
{
    public class Transaction
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        //public string _t { get; set; } = null!;
        [BsonElement("id_transaction")]
        public string id_transaction { get; set; }

        [BsonElement("id_invoice")]
        public int id_invoice { get; set; }

        [BsonElement("amount")]
        public decimal amount { get; set; } 

        [BsonElement("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

