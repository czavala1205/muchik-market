namespace muchik.market.transaction.application.dto
{
    public class TransactionDto
    {
        public string Id { get; set; } = null!;
        public int IdInvoice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } 

    }
}
