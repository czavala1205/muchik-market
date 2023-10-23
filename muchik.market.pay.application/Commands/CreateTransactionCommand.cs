using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class CreateTransactionCommand : TransactionCommand
    {
        public CreateTransactionCommand(int _invoiceId, Decimal _amount)
        {
            id_invoice = _invoiceId;
            amount = _amount;
        }
    }
}
