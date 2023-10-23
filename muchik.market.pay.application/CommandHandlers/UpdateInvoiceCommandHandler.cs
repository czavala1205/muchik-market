using MediatR;
using muchik.market.domain.bus;
using muchik.market.pay.application.Commands;
using muchik.market.pay.application.events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.pay.application.CommandHandlers
{
    public class UpdateInvoiceCommandHandler : IRequestHandler<UpdateInvoiceCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public UpdateInvoiceCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(UpdateInvoiceCommand request, CancellationToken cancellation)
        {
            _eventBus.Publish(new UpdateInvoiceEvent(request.id_invoice, request.State, request.totalPagado));
            return Task.FromResult(true);
        }
    }
}
