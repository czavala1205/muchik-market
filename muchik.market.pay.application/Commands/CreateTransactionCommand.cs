using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class CreateTransactionCommand : TransactionCommand
    {
        public CreateTransactionCommand(int invoiceId, Decimal amount)
        {
            InvoiceId = invoiceId;
            Amount = amount;
        }
    }
}
