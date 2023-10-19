using muchik.market.transaction.application.dto;

namespace muchik.market.transaction.application.interfaces
{
    public interface ITransactionService
    {
        ICollection<TransactionDto> GetAllTransactions();
        bool CreateTransaction(TransactionDto transactionDto);

        //bool UpdateInvoiceState(int invoiceId);

    }
}
