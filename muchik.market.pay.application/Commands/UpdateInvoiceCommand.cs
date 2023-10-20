using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class UpdateInvoiceCommand : InvoiceCommand
    {
        public UpdateInvoiceCommand(int invoiceId, int state)
        {
            InvoiceId = invoiceId;
            State = state;
        }
    }
}
