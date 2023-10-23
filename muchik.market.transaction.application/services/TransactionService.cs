using MongoDB.Driver;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Creates;
using muchik.market.transaction.application.interfaces;
using muchik.market.transaction.domain.entities;
using muchik.market.transaction.domain.interfaces;

namespace muchik.market.transaction.application.services
{
    public class TransactionService : ITransactionService
    {


        private readonly IMongoCollection<Transaction> _transaction;

        public TransactionService(ITransactionSettings settings, IMongoClient client)
        {
            var database = client.GetDatabase(settings.DatabaseName);
            _transaction = database.GetCollection<Transaction>(settings.TransactionCollectionName);
        }

        public Transaction CreateTransaction(CreateTransactionDto transactionDto)
        {
            var transaction = new Transaction
            {
                id_transaction = Guid.NewGuid().ToString("N"),
                id_invoice = transactionDto.id_invoice,
                amount = transactionDto.amount,
                CreatedAt = DateTime.Now
            };
         
            _transaction.InsertOne(transaction);

            return transaction;

        }

        public List<Transaction> GetAllTransactionsFromInvoice(int idInvoice)
        {
            return _transaction.Find(t => t.id_invoice == idInvoice).ToList();
        }

    }





}

