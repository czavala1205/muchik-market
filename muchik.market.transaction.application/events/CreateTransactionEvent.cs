using muchik.market.domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.application.events
{
    public class CreateTransactionEvent : Event
    {
        public int InvoiceId { get; set; }
        public Decimal Amount { get; set; }

        public CreateTransactionEvent(int invoiceId, decimal amount)
        {
            InvoiceId = invoiceId;
            Amount = amount;
        }
    }
}
