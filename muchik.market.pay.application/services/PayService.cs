using AutoMapper;
using muchik.market.domain.bus;
using muchik.market.pay.application.Commands;
using muchik.market.pay.application.dto;
using muchik.market.pay.application.interfaces;
using muchik.market.pay.domain.entities;
using muchik.market.pay.domain.interfaces;

namespace muchik.market.pay.application.services
{
    public class PayService : IPayService
    {
        private readonly IPayRepository _payRepository;
        private readonly IMapper _mapper;
        private readonly IEventBus _eventBus;

        public PayService(IPayRepository payRepository, IMapper mapper, IEventBus eventBus)
        {
            _payRepository = payRepository;
            _mapper = mapper;
            _eventBus = eventBus;
        }
        public List<OperationDto> GetAllInvoiceOperations(int idInvoice)
        {
            var operations = _payRepository.List(i => i.Id_invoice == idInvoice).ToList();
            var operationsDto = _mapper.Map<List<OperationDto>>(operations);
            return operationsDto;
        }

        public async Task<bool> CreateOperation(OperationDto createOperationDto)
        {
            var operation = _mapper.Map<Operation>(createOperationDto);
            _payRepository.Add(operation);

            var operations = GetAllInvoiceOperations(createOperationDto.id_invoice);
            decimal totalPagado = 0;

            foreach (var item in operations)
            {
                totalPagado += item.amount;
            }


            var successRegister = _payRepository.Save();

            if (successRegister)
            {
                await _eventBus.SendCommand(new UpdateInvoiceCommand(createOperationDto.id_invoice,totalPagado));
                await _eventBus.SendCommand(new CreateTransactionCommand(createOperationDto.id_invoice, createOperationDto.amount));
            }

            return successRegister;
        }

  
    }
}
