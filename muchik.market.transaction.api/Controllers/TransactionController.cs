using Microsoft.AspNetCore.Mvc;
using muchik.market.transaction.application.dto;
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

        [HttpGet("getAllTransactions")]
        public IActionResult GetAllTransactions()
        {
            return Ok(_transactionService.GetAllTransactions());
        }

        [HttpPost("createTransaction")]
        public IActionResult CreateTransaction([FromBody] TransactionDto transactionDto)
        {

            _transactionService.CreateTransaction(transactionDto);
            return Ok();
        }

    }
}
