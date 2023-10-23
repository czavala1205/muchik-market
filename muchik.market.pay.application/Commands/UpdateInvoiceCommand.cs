using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class UpdateInvoiceCommand : InvoiceCommand
    {
        public UpdateInvoiceCommand(int invoiceId, decimal _totalPagado)
        {
            id_invoice = invoiceId;
            totalPagado = _totalPagado;
            State = 1;
        }
    }
}
