using Microsoft.AspNetCore.Mvc;
using muchik.market.transaction.application.dto;
using muchik.market.transaction.application.dto.Filters;
using muchik.market.transaction.application.interfaces;

namespace muchik.market.transaction.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("getAllInvoiceTransactions")]
        public IActionResult GetAllInvoiceTransactions([FromQuery] GetTransactionsDto idInvoice)
        {
            return Ok(_transactionService.GetAllInvoiceTransactions(idInvoice));
        }

        [HttpPost("createTransaction")]
        public IActionResult CreateTransaction([FromBody] TransactionDto transactionDto)
        {   
            return Ok(_transactionService.CreateTransaction(transactionDto));
        }

    }
}
