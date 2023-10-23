using muchik.market.invoice.application.dto;
using muchik.market.invoice.domain.entities;
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
        Invoice GetById(int idInvoice);
        Invoice CreateInvoice(InvoiceDto invoiceDto);
        bool UpdateInvoiceState(int invoiceId);

    }
}
