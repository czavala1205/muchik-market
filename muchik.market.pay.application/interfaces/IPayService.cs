using muchik.market.pay.application.dto;

namespace muchik.market.pay.application.interfaces
{
    public interface IPayService
    {
        ICollection<OperationDto> GetAllOperations();
        Task<bool> CreateOperation(OperationDto payDto);

        //bool UpdateInvoiceState(int invoiceId);

    }
}
