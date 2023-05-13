using Payments.Dto;

namespace Payments.Repository
{
    public interface IPaymentRepository
    {
        public Task<PaymentDto> AddAsync(AddPaymentDto addPaymentDto);
        public Task<PaymentDto?> GetByIdAsync(string id);
        public Task<IEnumerable<PaymentDto>> GetAllAsync();


    }
}
