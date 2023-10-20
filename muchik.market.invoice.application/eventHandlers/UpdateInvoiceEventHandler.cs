using muchik.market.domain.bus;
using muchik.market.invoice.application.dto.Updates;
using muchik.market.invoice.application.events;
using muchik.market.invoice.application.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.invoice.application.eventHandlers
{
    public class UpdateInvoiceEventHandler : IEventHandler<UpdateInvoiceEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly IInvoiceService _invoiceService;

        public UpdateInvoiceEventHandler(IEventBus eventBus, IInvoiceService invoiceService)
        {
            _eventBus = eventBus;
            _invoiceService = invoiceService;
        }

        public Task Handle(UpdateInvoiceEvent @event)
        {
            var invoiceDto = new UpdateInvoiceDto
            {
                InvoiceId = @event.InvoiceId,
                State = @event.State
            };

            var successPayment = _invoiceService.UpdateInvoiceState(invoiceDto.InvoiceId);

            return Task.CompletedTask;
        }
    }
}
