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
    public class CreateTransactionCommandHadler : IRequestHandler<CreateTransactionCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public CreateTransactionCommandHadler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransactionCommand request, CancellationToken cancellation)
        {
            _eventBus.Publish(new CreateTransactionEvent(request.id_invoice, request.amount));
            return Task.FromResult(true);
        }
    }
}
