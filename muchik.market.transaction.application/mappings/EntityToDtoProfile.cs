using AutoMapper;
using MongoDB.Bson;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Filters;
using muchik.market.transaction.domain.entities;

namespace muchik.market.transaction.application.mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Transaction, TransactionDto>();
            CreateMap<Transaction, GetTransactionsDto>();

        }
    }
}
