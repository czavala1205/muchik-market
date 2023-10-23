using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Creates;
using muchik.market.transaction.application.dto.Filters;
using muchik.market.transaction.domain.entities;

namespace muchik.market.transaction.application.interfaces
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactionsFromInvoice(int idInvoice);

        Transaction CreateTransaction(CreateTransactionDto entity);



    }
}
