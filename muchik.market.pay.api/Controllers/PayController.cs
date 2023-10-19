using Microsoft.AspNetCore.Mvc;
using muchik.market.pay.application.dto;
using muchik.market.pay.application.interfaces;

namespace muchik.market.pay.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayController : ControllerBase
    {
        private readonly IPayService _payService;

        public PayController(IPayService payService)
        {
            _payService = payService;
        }

        [HttpGet("getAllOperations")]
        public IActionResult GetAllOperations()
        {
            return Ok(_payService.GetAllOperations());
        }

        [HttpPost("createOperation")]
        public IActionResult CreateOperation([FromBody] OperationDto operationDto)
        {
            return Ok(_payService.CreateOperation(operationDto));
        }

       
    }
}
