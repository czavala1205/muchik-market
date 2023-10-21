using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.application.dto.Creates
{
    public class CreateTransactionDto
    {

        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
    }
}
