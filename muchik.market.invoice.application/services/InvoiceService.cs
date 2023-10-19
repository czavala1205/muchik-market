using AutoMapper;
using muchik.market.invoice.application.dto;
using muchik.market.invoice.application.interfaces;
using muchik.market.invoice.domain.entities;
using muchik.market.invoice.domain.interfaces;

namespace muchik.market.invoice.application.services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public InvoiceService(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }
        public ICollection<InvoiceDto> GetAllInvoices()
        {
            var invoices = _invoiceRepository.List();
            var invoicesDto = _mapper.Map<ICollection<InvoiceDto>>(invoices);
            return invoicesDto;
        }

        public bool CreateInvoice(InvoiceDto createInvoiceDto)
        {
            var invoice = _mapper.Map<Invoice>(createInvoiceDto);
            _invoiceRepository.Add(invoice);
            return _invoiceRepository.Save();
        }

        public bool UpdateInvoiceState(int invoiceId)
        {
            var invoice = _invoiceRepository.GetById(invoiceId);


            if (invoice == null)
                throw new Exception("No se pudo encontrar la factura.");


                        
            invoice.State = 1;
            _invoiceRepository.Update(invoice);
            return _invoiceRepository.Save();
        }

     
    }
}
