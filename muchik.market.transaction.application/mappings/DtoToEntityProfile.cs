using AutoMapper;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Filters;
using muchik.market.transaction.domain.entities;

namespace muchik.market.transaction.application.mappings
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<TransactionDto, Transaction>();
            CreateMap<GetTransactionsDto, Transaction>();

        }
    }
}
