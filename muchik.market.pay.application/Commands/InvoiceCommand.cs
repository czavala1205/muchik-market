using muchik.market.domain.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.Commands
{
    public class InvoiceCommand : Command
    {
        public int id_invoice { get; set; }

        public decimal totalPagado { get; set; }
        public int State { get; set; }
    }
}
