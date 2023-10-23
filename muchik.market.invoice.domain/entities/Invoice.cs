using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.invoice.domain.entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        //public decimal Balance { get; set; }
        public int State { get; set; }
    }
}
