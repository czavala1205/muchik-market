using AutoMapper;
using MongoDB.Bson;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Filters;
using muchik.market.transaction.application.interfaces;
using muchik.market.transaction.domain.entities;
using muchik.market.transaction.domain.interfaces;

namespace muchik.market.transaction.application.services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public ICollection<TransactionDto> GetAllInvoiceTransactions(GetTransactionsDto getTransactionsDto)
        {
            int idInvoice = getTransactionsDto.id_invoice;
            var transactions = _transactionRepository.List();
            var transactionsDto = _mapper.Map<ICollection<TransactionDto>>(transactions);
            return transactionsDto;
        }
        public bool CreateTransaction(TransactionDto createTransactionDto)
        {
            
            var transaction = _mapper.Map<Transaction>(createTransactionDto);
            //transaction._id = ObjectId.GenerateNewId().ToString();
            //_transactionRepository.Add(transaction);
            return false;//_transactionRepository.Save();
        }

  
    }
}
