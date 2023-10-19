using Microsoft.AspNetCore.Mvc;
using muchik.market.invoice.application.dto;
using muchik.market.invoice.application.interfaces;

namespace muchik.market.invoice.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet("getAllInvoices")]
        public IActionResult GetAllInvoices()
        {
            return Ok(_invoiceService.GetAllInvoices());
        }

        [HttpPost("createInvoice")]
        public IActionResult CreateInvoice([FromBody] InvoiceDto invoiceDto)
        {
            return Ok(_invoiceService.CreateInvoice(invoiceDto));
        }

        [HttpPatch("updateInvoiceState")]
        public IActionResult UpdateInvoiceState([FromBody] int invoiceId)
        {
            return Ok(_invoiceService.UpdateInvoiceState(invoiceId));
        }
    }
}
