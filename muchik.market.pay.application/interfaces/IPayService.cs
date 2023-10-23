using muchik.market.pay.application.dto;

namespace muchik.market.pay.application.interfaces
{
    public interface IPayService
    {
        List<OperationDto> GetAllInvoiceOperations(int idInvoice);
        Task<bool> CreateOperation(OperationDto payDto);

        //bool UpdateInvoiceState(int invoiceId);

    }
}
