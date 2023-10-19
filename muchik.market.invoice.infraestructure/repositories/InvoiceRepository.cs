using Microsoft.EntityFrameworkCore;
using muchik.market.invoice.domain.entities;
using muchik.market.invoice.domain.interfaces;
using muchik.market.invoice.infrastructure.context;

namespace muchik.market.invoice.infrastructure.repositories
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(InvoiceContext context) : base(context) { }
    }
}
