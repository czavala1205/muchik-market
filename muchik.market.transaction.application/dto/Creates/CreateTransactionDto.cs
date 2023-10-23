using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.application.dto.Creates
{
    public class CreateTransactionDto
    {

        public int id_invoice { get; set; }
        public decimal amount { get; set; }
    }
}
