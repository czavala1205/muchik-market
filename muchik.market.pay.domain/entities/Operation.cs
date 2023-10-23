using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.domain.entities
{
    public class Operation
    {
        public int Id { get; set; }
        public int Id_invoice { get; set; }
        public decimal Amount { get; set; }
        //public int State { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
