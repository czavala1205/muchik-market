namespace muchik.market.transaction.domain.entities
{
    public class Transaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public int IdInvoice { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
