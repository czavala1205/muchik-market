using muchik.market.domain.bus;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Creates;
using muchik.market.transaction.application.events;
using muchik.market.transaction.application.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muchik.market.transaction.application.eventHandlers
{
    public class CreateTransactionEventHandler : IEventHandler<CreateTransactionEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ITransactionService _transactionService;

        public CreateTransactionEventHandler(IEventBus eventBus, ITransactionService transactionService)
        {
            _eventBus = eventBus;
            _transactionService = transactionService;
        }

        public Task Handle(CreateTransactionEvent @event)
        {
            var transactionDto = new CreateTransactionDto
            {
                id_invoice = @event.id_invoice,
                amount = @event.amount
            };

            var successPayment = _transactionService.CreateTransaction(transactionDto);

            return Task.CompletedTask;
        }
    }
}
