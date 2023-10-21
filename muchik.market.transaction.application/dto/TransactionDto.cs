using MongoDB.Bson;
using System;

namespace muchik.market.transaction.application.dto
{
    public class TransactionDto
    {
        //public Object _id { get; set; } = null!;
        //public string Id { get; set; } = null!;
        public int id_invoice { get; set; }
        public decimal amount { get; set; }
        public DateTime CreatedAt { get; set; }



    }
}
