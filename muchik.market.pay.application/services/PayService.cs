using AutoMapper;
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

        public PayService(IPayRepository payRepository, IMapper mapper)
        {
            _payRepository = payRepository;
            _mapper = mapper;
        }
        public ICollection<OperationDto> GetAllOperations()
        {
            var operations = _payRepository.List();
            var operationsDto = _mapper.Map<ICollection<OperationDto>>(operations);
            return operationsDto;
        }

        public bool CreateOperation(OperationDto createOperationDto)
        {
            var operation = _mapper.Map<Operation>(createOperationDto);
            _payRepository.Add(operation);
            return _payRepository.Save();
        }

  
    }
}
