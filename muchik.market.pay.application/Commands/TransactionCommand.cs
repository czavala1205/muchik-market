using muchik.market.domain.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class TransactionCommand : Command
    {
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
    }
}
