namespace muchik.market.invoice.application.dto
{
    public class InvoiceDto
    {
        public int Id { get; set; } 
        public decimal Amount { get; set; } = 0;
        public int State { get; set; } = 0;

    }
}
