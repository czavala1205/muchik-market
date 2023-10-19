using Microsoft.EntityFrameworkCore;
using muchik.market.pay.domain.entities;
using muchik.market.pay.domain.interfaces;
using muchik.market.pay.infrastructure.context;

namespace muchik.market.pay.infrastructure.repositories
{
    public class PayRepository : GenericRepository<Operation>, IPayRepository
    {
        public PayRepository(PayContext context) : base(context) { }

        //public IEnumerable<Operation> GetAllOperations()
        //{
        //    return _context.Operation.Include(i => i.OrderDetails);
        //}
    }
}
