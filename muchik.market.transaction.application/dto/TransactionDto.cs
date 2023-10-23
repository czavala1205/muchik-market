using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace muchik.market.transaction.application.dto
{
    public class TransactionDto
    {
        //public Object _id { get; set; } = null!;
        public string _id { get; set; }

        [JsonIgnore]
        [BsonElement("id_transaction")]
        public string id_transaction { get; set; }

        [BsonElement("id_invoice")]
        public int id_invoice { get; set; }

        [BsonElement("amount")]
        public decimal amount { get; set; }

        [BsonElement("CreatedAt")]
        public DateTime CreatedAt { get; set; } 
        //public int id_invoice { get; set; }
        //public decimal amount { get; set; }
        //public DateTime CreatedAt { get; set; }



    }
}
