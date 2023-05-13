using Microsoft.AspNetCore.Mvc;
using Payments.Dto;
using Payments.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payments.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly IPaymentRepository paymentRepository;

        public PaymentController(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDto>> GetPayment(string id)
        {
            PaymentDto? payment = await paymentRepository.GetByIdAsync(id);
            return payment == null ? (ActionResult<PaymentDto>)NotFound() : (ActionResult<PaymentDto>)Ok(payment);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDto>>> GetAll()
        {
            IEnumerable<PaymentDto> payments = await paymentRepository.GetAllAsync();


            return Ok(payments);
        }
        [HttpPost]
        public async Task<ActionResult<PaymentDto>> AddPayment([FromBody] AddPaymentDto ddPaymentDto)
        {
            if (ModelState.IsValid)
            {
                PaymentDto payment = await paymentRepository.AddAsync(ddPaymentDto);

                return Ok(payment);
            }
            return BadRequest();

        }
    }
}
