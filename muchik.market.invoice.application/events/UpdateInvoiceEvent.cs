using muchik.market.domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.invoice.application.events
{
    public class UpdateInvoiceEvent : Event
    {
        public int InvoiceId { get; set; }
        public int State { get; set; }

        public UpdateInvoiceEvent(int invoiceId, int state)
        {
            InvoiceId = invoiceId;
            State = state;
        }
    }
}
