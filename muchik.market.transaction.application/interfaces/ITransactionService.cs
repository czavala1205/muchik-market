using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Filters;

namespace muchik.market.transaction.application.interfaces
{
    public interface ITransactionService
    {
        ICollection<TransactionDto> GetAllInvoiceTransactions(GetTransactionsDto getTransactionDto);
        bool CreateTransaction(TransactionDto transactionDto);

        //bool UpdateInvoiceState(int invoiceId);

    }
}
