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
        public ICollection<OperationDto> GetAllOperations()
        {
            var operations = _payRepository.List();
            var operationsDto = _mapper.Map<ICollection<OperationDto>>(operations);
            return operationsDto;
        }

        public async Task<bool> CreateOperation(OperationDto createOperationDto)
        {
            var operation = _mapper.Map<Operation>(createOperationDto);
            _payRepository.Add(operation);
            
            var successRegister = _payRepository.Save();
            if (successRegister)
            {
                await _eventBus.SendCommand(new UpdateInvoiceCommand(createOperationDto.IdInvoice, createOperationDto.State));
            }

            return successRegister;
        }

  
    }
}
