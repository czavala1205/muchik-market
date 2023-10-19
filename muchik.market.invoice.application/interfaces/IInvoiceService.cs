using muchik.market.invoice.application.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.invoice.application.interfaces
{
    public interface IInvoiceService
    {
        ICollection<InvoiceDto> GetAllInvoices();
        bool CreateInvoice(InvoiceDto invoiceDto);
        bool UpdateInvoiceState(int invoiceId);

    }
}
