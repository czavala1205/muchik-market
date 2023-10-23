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
        public int id_invoice { get; set; }
        public Decimal amount { get; set; }

        public CreateTransactionEvent(int _invoiceId, decimal _amount)
        {
            id_invoice = _invoiceId;
            amount = _amount;
        }
    }
}
