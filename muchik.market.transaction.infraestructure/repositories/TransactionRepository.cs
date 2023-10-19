using muchik.market.transaction.domain.entities;
using muchik.market.transaction.domain.interfaces;
using muchik.market.transaction.infrastructure.context;

namespace muchik.market.transaction.infrastructure.repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(TransactionContext context) : base(context) { }

        //public IEnumerable<Operation> GetAllOperations()
        //{
        //    return _context.Operation.Include(i => i.OrderDetails);
        //}
    }
}
