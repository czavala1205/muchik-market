using MongoDB.Driver;
using MongoFramework;
using Transaction = muchik.market.transaction.domain.entities.Transaction;

namespace muchik.market.transaction.infrastructure.context
{
    public partial class TransactionContext2 : MongoDbContext
    {
       
        public TransactionContext2(IMongoDbConnection options)
            : base(options) { }

        public MongoDbSet<Transaction> Transaction { get; set; }

        //public IMongoCollection<Transaction> Transactions => _database.GetCollection<Transaction>("transactions");




    }
}
