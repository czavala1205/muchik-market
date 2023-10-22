using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace muchik.market.transaction.domain.entities
{
    public class Transaction
    {
        [JsonIgnore]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string id_transaction { get; set; } = Guid.NewGuid().ToString("N");
        public int id_invoice { get; set; }
        public decimal amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

