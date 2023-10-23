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
        public int id_invoice { get; set; }
        public decimal amount { get; set; }
    }
}
