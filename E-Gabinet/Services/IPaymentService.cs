using Egabinet.Models;

namespace Egabinet.Services
{
    public interface IPaymentService
    {
        public Task<PaymentDto> AddAsync(AddPaymentDto addPaymentDto);
        public Task<PaymentDto?> GetByIdAsync(string id);
        public Task<IEnumerable<PaymentDto>> GetAllAsync();
    }
}
