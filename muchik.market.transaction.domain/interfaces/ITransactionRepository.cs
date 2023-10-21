using MongoDB.Bson;
using muchik.market.transaction.domain.entities;
using System.Linq.Expressions;

namespace muchik.market.transaction.domain.interfaces
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        //Transaction Create(Transaction entity);

        //Transaction Read(string id);

        //void Update(Transaction entity);

        //void Delete(string id);

        //IEnumerable<Transaction> List(Expression<Func<Transaction, bool>> filter = null, Func<IQueryable<Transaction>,
        //    IOrderedQueryable<Transaction>> orderBy = null, string includeProperties = "");


    }
}
