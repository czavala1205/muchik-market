using AutoMapper;
using muchik.market.pay.application.dto;
using muchik.market.pay.domain.entities;

namespace muchik.market.pay.application.mappings
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<OperationDto, Operation>();

        }
    }
}
