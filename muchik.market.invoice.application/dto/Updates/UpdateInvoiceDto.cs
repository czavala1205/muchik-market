using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.invoice.application.dto.Updates
{
    public class UpdateInvoiceDto
    {
        public int InvoiceId { get; set; }
        public int State { get; set; }
        public decimal TotalPagado { get; set; }

    }
}
