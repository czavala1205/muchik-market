using muchik.market.domain.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.events
{
    public class UpdateInvoiceEvent : Event
    {
        public int InvoiceId { get; set; }
        public decimal totalPagado {  get; set; }
        public int State { get; set; }

        public UpdateInvoiceEvent(int invoiceId, int state, decimal _totalPagado)
        {
            InvoiceId = invoiceId;
            State = state;
            totalPagado = _totalPagado;
        }
    }
}
