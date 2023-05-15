using Microsoft.EntityFrameworkCore;
using Payments.Data;
using Payments.Domains;
using Payments.Dto;

namespace Payments.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentsDbContext _dbContext;


        public PaymentRepository(PaymentsDbContext _dbContext)
        {
            this._dbContext = _dbContext;

        }


        public async Task<PaymentDto?> GetByIdAsync(string id)
        {

            Payment? payment = await _dbContext.Payments.FirstOrDefaultAsync(u => u.Id == id);
            if (payment == null)
            {
                return null;
            }
            PaymentDto paymentDto = new PaymentDto { Id = payment.Id, Amount = payment.Amount, Type = payment.Type, UserId = payment.UserId };
            return paymentDto;
        }


        public async Task<IEnumerable<PaymentDto>> GetAllAsync()
        {
            return await _dbContext.Payments.Select(p => new PaymentDto { Id = p.Id, Amount = p.Amount, Type = p.Type, UserId = p.UserId }).ToListAsync();
        }


        public async Task<PaymentDto> AddAsync(AddPaymentDto addPaymentDtopayment)
        {
            Payment payment = new Payment { Amount = addPaymentDtopayment.Amount, Type = addPaymentDtopayment.Type, UserId = addPaymentDtopayment.UserId };
            await _dbContext.AddAsync(payment);
            await _dbContext.SaveChangesAsync();

            PaymentDto paymentDto = new PaymentDto { Id = payment.Id, Amount = payment.Amount, Type = payment.Type, UserId = payment.UserId, };
            return paymentDto;
        }


    }
}
